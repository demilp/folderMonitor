using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FolderMonitor
{
    public class WaitForProcess
    {
        public static List<Process> processes = new List<Process>();
        static WaitForProcess()
        {
        }
        Thread thread;
        string file;
        string processFile;

        public WaitForProcess(string file, string processFile)
        {
            this.file = file;
            this.processFile = processFile;
            FolderMonitor.isProcessingFile = true;
            thread = new Thread(ExecuteCommand);
            thread.Start();
        }
        private void ExecuteCommand()
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = processFile;
                startInfo.WorkingDirectory = Path.GetDirectoryName(processFile);
                string fullFilePath = Path.GetFullPath(file);
                startInfo.Arguments = "\"" + fullFilePath + "\" \"" + Path.GetDirectoryName(fullFilePath) + "\" \"" + Path.GetFileNameWithoutExtension(file) + "\" \"" + Path.GetExtension(file) + "\"";
                startInfo.UseShellExecute = true;
                startInfo.WindowStyle = ProcessWindowStyle.Normal;

                process.StartInfo = startInfo;

                process.Start();
                processes.Add(process);
                process.WaitForExit();
                FolderMonitor.isProcessingFile = false;
            }
            catch (Exception)
            {
                FolderMonitor.isProcessingFile = false;
            }

            if (FolderMonitor.useBypass)
            {
                FolderMonitor.client.SendData("fileProcessed|" + file, "folderMonitorListener");
            }
        }
    }
}
