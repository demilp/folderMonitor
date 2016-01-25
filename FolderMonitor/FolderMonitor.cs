using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderMonitor
{
    public partial class FolderMonitor : Form
    {
        bool overwrite = true;
        bool queueMode = false;
        public static bool isProcessingFile = false;
        public static bool useBypass;
        public static Bypass.BypassClient client;
        public FolderMonitor()
        {
            InitializeComponent();
        }

        private void buttonBrowseSourceFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBoxSource.Text))
            {
                folderBrowserDialogSource.SelectedPath = textBoxSource.Text;
            }
            else
            {
                folderBrowserDialogSource.SelectedPath = Environment.CurrentDirectory;
            }

            DialogResult res = folderBrowserDialogSource.ShowDialog();
            if (res == DialogResult.OK)
            {
                textBoxSource.Text = folderBrowserDialogSource.SelectedPath;
            }
        }

        private void buttonBrowseOriginalsFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBoxSource.Text))
            {
                folderBrowserDialogOriginals.SelectedPath = textBoxOrginals.Text;
            }
            else
            {
                folderBrowserDialogOriginals.SelectedPath = Environment.CurrentDirectory;
            }

            DialogResult res = folderBrowserDialogOriginals.ShowDialog();
            if (res == DialogResult.OK)
            {
                textBoxOrginals.Text = folderBrowserDialogOriginals.SelectedPath;
            }
        }

        private void buttonBrowseDestinationFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBoxSource.Text))
            {
                folderBrowserDialogDestination.SelectedPath = textBoxDestination.Text;
            }
            else
            {
                folderBrowserDialogDestination.SelectedPath = Environment.CurrentDirectory;
            }

            DialogResult res = folderBrowserDialogDestination.ShowDialog();
            if (res == DialogResult.OK)
            {
                textBoxDestination.Text = folderBrowserDialogDestination.SelectedPath;
            }
        }

        private void buttonBrowseProcessFile_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {

            labelError.Text = "";
            if (!File.Exists(textBoxProcess.Text))
            {
                labelError.Text = "Process file not found";
                return;
            }
            string[] newFiles = GetNewFiles();
            if (newFiles == null)
            {
                return;
            }
            
            for (int i = 0; i < newFiles.Length; i++)
            {
                if (queueMode && isProcessingFile)
                {
                    return;
                }
                string d = MoveNewFile(newFiles[i]);
                ProcessFile(d);
            }
        }

        private string[] GetNewFiles()
        {
            try
            {
                List<string> p = new List<string>(Directory.GetFiles(textBoxSource.Text, textBoxExtension.Text));

                for (int i = p.Count-1; i >= 0; i--)
                {
                    FileStream stream = null;

                    try
                    {
                        stream = new FileInfo(p[i]).Open(FileMode.Open, FileAccess.Read, FileShare.None);
                    }
                    catch (IOException)
                    {
                        p.RemoveAt(i);
                    }
                    finally
                    {
                        if (stream != null)
                            stream.Close();
                    }
                }
                return p.ToArray();
            }

            catch (Exception e)
            {
                labelError.Text = "Source directory not found: " + e.Message;
                return null;
            }
            

        }
        private string MoveNewFile(string file)
        {
            try
            {
                File.Copy(file, textBoxOrginals.Text + '\\' + Path.GetFileName(file), overwrite);
                string d = textBoxDestination.Text + '\\' + Path.GetFileName(file);
                File.Copy(file, d, overwrite);
                File.Delete(file);
                return d;
            }
            catch (Exception e)
            {
                labelError.Text = "Error copying files: " + e.Message;
            }
            return "";
            
        }
        private void ProcessFile(string file)
        {
            new WaitForProcess(file, textBoxProcess.Text);
            /*Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = textBoxProcess.Text;
            startInfo.WorkingDirectory = Path.GetDirectoryName(textBoxProcess.Text);
            startInfo.Arguments = file + " " + Path.GetDirectoryName(file) + " " + Path.GetFileNameWithoutExtension(file) + " " + Path.GetExtension(file);
            startInfo.UseShellExecute = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            process.StartInfo = startInfo;

            process.Start();
            process.WaitForExit();*/
        }

        private void FolderMonitor_Load(object sender, EventArgs e)
        {
            textBoxSource.Text = ConfigurationManager.AppSettings["sourceFolder"];
            textBoxOrginals.Text = ConfigurationManager.AppSettings["originalsFolder"];
            textBoxDestination.Text = ConfigurationManager.AppSettings["destinationFolder"];
            textBoxExtension.Text = ConfigurationManager.AppSettings["extension"];
            overwrite = ConfigurationManager.AppSettings["overwriteFiles"].ToLower() == "true";
            queueMode = ConfigurationManager.AppSettings["queueMode"].ToLower() == "true";
            useBypass = ConfigurationManager.AppSettings["useBypass"].ToLower() == "true";
            if (useBypass)
            {
                client = new Bypass.BypassClient(ConfigurationManager.AppSettings["bypassIp"], int.Parse(ConfigurationManager.AppSettings["bypassPort"]), ConfigurationManager.AppSettings["bypassDelimiter"], ConfigurationManager.AppSettings["bypassId"], "");
            }
        }

        private void FolderMonitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null)
            {
                client.Close();
            }
            Configuration config = ConfigurationManager.OpenExeConfiguration(Path.Combine(Environment.CurrentDirectory, AppDomain.CurrentDomain.FriendlyName));
            config.AppSettings.Settings["extension"].Value = textBoxExtension.Text;
            config.AppSettings.Settings["destinationFolder"].Value = textBoxDestination.Text;
            config.AppSettings.Settings["originalsFolder"].Value = textBoxOrginals.Text;
            config.AppSettings.Settings["sourceFolder"].Value = textBoxSource.Text;
            config.AppSettings.Settings["processFile"].Value = textBoxProcess.Text;
            config.Save(ConfigurationSaveMode.Modified);
        }

    }
}
