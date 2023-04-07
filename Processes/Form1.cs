using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Processes
{
    public partial class Form1 : Form
    {
        private Process proc = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                if (proc != null && proc.HasExited)
                {
                    proc = null;
                    MessageBox.Show("Калькулятор уже запущен");
                }
                else
                {
                    proc = Process.Start("calc");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


