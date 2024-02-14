using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
			myProcess = new System.Diagnostics.Process();
			myProcess.StartInfo = new System.Diagnostics.ProcessStartInfo(rtbRunProcess.Text);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            InitProcess();
            myProcess.Start();
            listViewProcesses.Items.Add(myProcess.Id.ToString());
            listViewProcesses.Items[listViewProcesses.Items.Count - 1].SubItems.Add(myProcess.ProcessName.ToString());
            ProcessInfo();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
			int index = listViewProcesses.Items.Count - 1;
			try
            {
                if(index < 0) { return; }
				myProcess = System.Diagnostics.Process.GetProcessById(Convert.ToInt32(listViewProcesses.Items[index].SubItems[0].Text));
				if (listViewProcesses.SelectedItems.Count > 0)
				{
                    index = listViewProcesses.SelectedItems[0].Index;
					myProcess = System.Diagnostics.Process.GetProcessById(Convert.ToInt32(listViewProcesses.SelectedItems[0].SubItems[0].Text));
				}
                myProcess.CloseMainWindow();
                myProcess.Close();
                listViewProcesses.Items.RemoveAt(index);
            }
            catch (Exception currentItemIsNullException)
            {
                listViewProcesses.Items.RemoveAt(index);
            }
            finally 
            {
                myProcess = listViewProcesses.Items.Count > 0 ? System.Diagnostics.Process.GetProcessById(
                                Convert.ToInt32(listViewProcesses.Items[listViewProcesses.Items.Count - 1].SubItems[0].Text)) : null;
				ProcessInfo();
			}
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
                labelProcessInfo.Text = $"Processes count: {listViewProcesses.Items.Count}\n";
                labelProcessInfo.Text += $"PID: {myProcess.Id}\n";
                labelProcessInfo.Text += $"Process name: {myProcess.ProcessName}\n";
                labelProcessInfo.Text += $"Start time: {myProcess.StartTime}\n";
                labelProcessInfo.Text += $"Processor time: {myProcess.TotalProcessorTime}\n";
                labelProcessInfo.Text += $"Memory usage: {(float) (myProcess.WorkingSet64 / (1024 * 1024))}\n"; 
            }
            else
            {
                labelProcessInfo.Text = "Список процессов пуст";
            }
        }

        private void listViewProcesses_MouseDoubleClick(object sender, MouseEventArgs e)
		{
            myProcess = System.Diagnostics.Process.GetProcessById(Convert.ToInt32(listViewProcesses.SelectedItems[0].SubItems[0].Text));
			ProcessInfo();
        }
    }
}
