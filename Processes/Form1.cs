using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Processes
{
    public partial class Form1 : Form
    {
        private Process procCalc = null;
        private Process procWord = null;
        private Process procEx = null;
        private Process procPow = null;
        private Process procEdge = null;
        private Process procCMD = null;
        public Form1()
        {
            InitializeComponent();
            this.Text = "";
        }

        private void start_process(string _name, ref Process proc)
        { 
            try
            {
                if (proc != null )
                {
                    MessageBox.Show("Процесс уже запущен");
                    //так и не сообразил как адекватно заставить работать, замысел был такой:
                    //если процесс запущен, появляется соответсвующее сообщение и не запускает ещё один,
                    //если процесс был закрыт, то запускается, но увы
                    if (proc.HasExited)
                    {
                        proc = null;
                    }
                }
                else
                {
                    proc = Process.Start(_name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            start_process("calc", ref procCalc);
        }
        private void buttonWord_Click(object sender, EventArgs e)
        {
            start_process("WINWORD", ref procWord);
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            start_process("EXCEL", ref procEx);
        }

        private void buttonPowerPnt_Click(object sender, EventArgs e)
        {
            start_process("POWERPNT", ref procPow);
        }

        private void buttonEdgeBrowser_Click(object sender, EventArgs e)
        {
            start_process("MicrosoftEdge", ref procEdge);
        }

        private void buttonCMD_Click(object sender, EventArgs e)
        {
            start_process("cmd", ref procCMD);
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            try
            {
                string logFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\processes.log";
                if (!File.Exists(logFilePath))
                {
                    FileStream fs = File.Create(logFilePath);
                    fs.Close();
                }
                Process[] processes = Process.GetProcesses();
                Process[] currentProcesses = Process.GetProcesses();
                foreach (Process process in currentProcesses)
                {
                    if (Array.IndexOf(processes, process) == -1)
                    {
                        StreamWriter sw = File.AppendText(logFilePath);
                        {
                            sw.WriteLine($"{DateTime.Now} - {process.ProcessName}");
                            sw.Close();
                        }
                    }
                }
                MessageBox.Show(@"запись прошла успешна, путь к файлу: Документы\processes.log");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


