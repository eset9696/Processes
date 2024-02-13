using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Processes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listViewProcesses.Columns.Add("PID");
            listViewProcesses.Columns.Add("Name");
        }

        void InitProcess()
        {
            myProcess.StartInfo = new System.Diagnostics.ProcessStartInfo(rtbRunProcess.Text);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            InitProcess();
            myProcess.Start();
            listViewProcesses.Items.Add(myProcess.Id.ToString());
            listViewProcesses.Items[listViewProcesses.Items.Count - 1].SubItems.Add(myProcess.ProcessName.ToString());
            ProcessInfo();
            myProcess = new System.Diagnostics.Process();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                myProcess = System.Diagnostics.Process.GetProcessById(Convert.ToInt32(listViewProcesses.Items[listViewProcesses.Items.Count - 1].SubItems[0].Text));
                myProcess.CloseMainWindow();
                myProcess.Close();
                listViewProcesses.Items.RemoveAt(listViewProcesses.Items.Count - 1);

            }
            catch (Exception currentItemIsNullException)
            {
                listViewProcesses.Items.RemoveAt(listViewProcesses.Items.Count - 1);
            }finally { ProcessInfo(); }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            while (listViewProcesses.Items.Count > 0)
            {
                btnStop_Click (sender, e);
            }
        }

        void ProcessInfo()
        {
            if (listViewProcesses.Items.Count > 0)
            {
                System.Diagnostics.Process process =
                    //listViewProcesses.SelectedItems[0] != null ?
                    //System.Diagnostics.Process.GetProcessById(Convert.ToInt32(listViewProcesses.SelectedItems[0].SubItems[0].Text)):
                    System.Diagnostics.Process.GetProcessById(Convert.ToInt32(listViewProcesses.Items[listViewProcesses.Items.Count - 1].SubItems[0].Text));
                labelProcessInfo.Text = $"Processes count: {listViewProcesses.Items.Count}\n";
                labelProcessInfo.Text += $"PID: {process.Id}\n";
                labelProcessInfo.Text += $"Process name: {process.ProcessName}\n";
                labelProcessInfo.Text += $"Start time: {process.StartTime}\n";
                labelProcessInfo.Text += $"Processor time: {process.TotalProcessorTime}\n";
                labelProcessInfo.Text += $"Memory: {process.PagedMemorySize}\n"; 
            }
            else
            {
                labelProcessInfo.Text = "Список процессов пуст";
            }
        }

        void ProcessInfo1()
        {
            if (listViewProcesses.Items.Count > 0)
            {
                System.Diagnostics.Process process = System.Diagnostics.Process.GetProcessById(Convert.ToInt32(listViewProcesses.SelectedItems[0].SubItems[0].Text));
                    //System.Diagnostics.Process.GetProcessById(Convert.ToInt32(listViewProcesses.Items[listViewProcesses.Items.Count - 1].SubItems[0].Text));
                labelProcessInfo.Text = $"Processes count: {listViewProcesses.Items.Count}\n";
                labelProcessInfo.Text += $"PID: {process.Id}\n";
                labelProcessInfo.Text += $"Process name: {process.ProcessName}\n";
                labelProcessInfo.Text += $"Start time: {process.StartTime}\n";
                labelProcessInfo.Text += $"Processor time: {process.TotalProcessorTime}\n";
                labelProcessInfo.Text += $"Memory: {process.PagedMemorySize}\n";
            }
            else
            {
                labelProcessInfo.Text = "Список процессов пуст";
            }
        }

        private void listViewProcesses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ProcessInfo1();

        }
    }
}
