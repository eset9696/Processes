namespace Processes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbRunProcess = new System.Windows.Forms.RichTextBox();
            this.listViewProcesses = new System.Windows.Forms.ListView();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.labelProcessInfo = new System.Windows.Forms.Label();
            this.myProcess = new System.Diagnostics.Process();
            this.SuspendLayout();
            // 
            // rtbRunProcess
            // 
            this.rtbRunProcess.Location = new System.Drawing.Point(13, 12);
            this.rtbRunProcess.Name = "rtbRunProcess";
            this.rtbRunProcess.Size = new System.Drawing.Size(333, 40);
            this.rtbRunProcess.TabIndex = 0;
            this.rtbRunProcess.Text = "mspaint";
            // 
            // listViewProcesses
            // 
            this.listViewProcesses.FullRowSelect = true;
            this.listViewProcesses.HideSelection = false;
            this.listViewProcesses.Location = new System.Drawing.Point(352, 12);
            this.listViewProcesses.MultiSelect = false;
            this.listViewProcesses.Name = "listViewProcesses";
            this.listViewProcesses.Size = new System.Drawing.Size(478, 426);
            this.listViewProcesses.TabIndex = 1;
            this.listViewProcesses.UseCompatibleStateImageBehavior = false;
            this.listViewProcesses.View = System.Windows.Forms.View.Details;
            this.listViewProcesses.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewProcesses_MouseDoubleClick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 58);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(271, 58);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // labelProcessInfo
            // 
            this.labelProcessInfo.AutoSize = true;
            this.labelProcessInfo.Location = new System.Drawing.Point(13, 88);
            this.labelProcessInfo.Name = "labelProcessInfo";
            this.labelProcessInfo.Size = new System.Drawing.Size(44, 16);
            this.labelProcessInfo.TabIndex = 4;
            this.labelProcessInfo.Text = "label1";
            // 
            // myProcess
            // 
            this.myProcess.StartInfo.Domain = "";
            this.myProcess.StartInfo.LoadUserProfile = false;
            this.myProcess.StartInfo.Password = null;
            this.myProcess.StartInfo.StandardErrorEncoding = null;
            this.myProcess.StartInfo.StandardOutputEncoding = null;
            this.myProcess.StartInfo.UserName = "";
            this.myProcess.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.labelProcessInfo);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.listViewProcesses);
            this.Controls.Add(this.rtbRunProcess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbRunProcess;
        private System.Windows.Forms.ListView listViewProcesses;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label labelProcessInfo;
        private System.Diagnostics.Process myProcess;
    }
}

