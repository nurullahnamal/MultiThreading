namespace MultiThreading
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbLogs = new System.Windows.Forms.ListBox();
            btnListMailTasks = new System.Windows.Forms.Button();
            btnStartTask = new System.Windows.Forms.Button();
            btnStopTask = new System.Windows.Forms.Button();
            btnRunTask = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            taskIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ısRunningDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ısStartedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            secondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mailTaskBindingSource = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mailTaskBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lbLogs
            // 
            lbLogs.BackColor = System.Drawing.SystemColors.WindowFrame;
            lbLogs.Dock = System.Windows.Forms.DockStyle.Bottom;
            lbLogs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbLogs.FormattingEnabled = true;
            lbLogs.ItemHeight = 15;
            lbLogs.Location = new System.Drawing.Point(0, 427);
            lbLogs.Name = "lbLogs";
            lbLogs.Size = new System.Drawing.Size(935, 199);
            lbLogs.TabIndex = 0;
            // 
            // btnListMailTasks
            // 
            btnListMailTasks.Location = new System.Drawing.Point(-5, 1);
            btnListMailTasks.Name = "btnListMailTasks";
            btnListMailTasks.Size = new System.Drawing.Size(942, 48);
            btnListMailTasks.TabIndex = 1;
            btnListMailTasks.Text = "List Mail Task";
            btnListMailTasks.UseVisualStyleBackColor = true;
            btnListMailTasks.Click += btnListMailTasks_Click;
            // 
            // btnStartTask
            // 
            btnStartTask.Enabled = false;
            btnStartTask.Location = new System.Drawing.Point(22, 207);
            btnStartTask.Name = "btnStartTask";
            btnStartTask.Size = new System.Drawing.Size(75, 23);
            btnStartTask.TabIndex = 3;
            btnStartTask.Text = "Start";
            btnStartTask.UseVisualStyleBackColor = true;
            btnStartTask.Click += btnStartTask_Click;
            // 
            // btnStopTask
            // 
            btnStopTask.Enabled = false;
            btnStopTask.Location = new System.Drawing.Point(325, 207);
            btnStopTask.Name = "btnStopTask";
            btnStopTask.Size = new System.Drawing.Size(75, 23);
            btnStopTask.TabIndex = 4;
            btnStopTask.Text = "Stop";
            btnStopTask.UseVisualStyleBackColor = true;
            btnStopTask.Click += btnStopTask_Click;
            // 
            // btnRunTask
            // 
            btnRunTask.Enabled = false;
            btnRunTask.Location = new System.Drawing.Point(459, 207);
            btnRunTask.Name = "btnRunTask";
            btnRunTask.Size = new System.Drawing.Size(75, 23);
            btnRunTask.TabIndex = 5;
            btnRunTask.Text = "Run";
            btnRunTask.UseVisualStyleBackColor = true;
            btnRunTask.Click += btnRunTask_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { taskIdDataGridViewTextBoxColumn, ısRunningDataGridViewCheckBoxColumn, ısStartedDataGridViewCheckBoxColumn, secondDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1 });
            dataGridView1.DataSource = mailTaskBindingSource;
            dataGridView1.Location = new System.Drawing.Point(-5, 271);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(942, 150);
            dataGridView1.TabIndex = 6;
            // 
            // taskIdDataGridViewTextBoxColumn
            // 
            taskIdDataGridViewTextBoxColumn.DataPropertyName = "TaskId";
            taskIdDataGridViewTextBoxColumn.HeaderText = "TaskId";
            taskIdDataGridViewTextBoxColumn.Name = "taskIdDataGridViewTextBoxColumn";
            taskIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ısRunningDataGridViewCheckBoxColumn
            // 
            ısRunningDataGridViewCheckBoxColumn.DataPropertyName = "IsRunning";
            ısRunningDataGridViewCheckBoxColumn.HeaderText = "IsRunning";
            ısRunningDataGridViewCheckBoxColumn.Name = "ısRunningDataGridViewCheckBoxColumn";
            ısRunningDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ısStartedDataGridViewCheckBoxColumn
            // 
            ısStartedDataGridViewCheckBoxColumn.DataPropertyName = "IsStarted";
            ısStartedDataGridViewCheckBoxColumn.HeaderText = "IsStarted";
            ısStartedDataGridViewCheckBoxColumn.Name = "ısStartedDataGridViewCheckBoxColumn";
            ısStartedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // secondDataGridViewTextBoxColumn
            // 
            secondDataGridViewTextBoxColumn.DataPropertyName = "Second";
            secondDataGridViewTextBoxColumn.HeaderText = "Second";
            secondDataGridViewTextBoxColumn.Name = "secondDataGridViewTextBoxColumn";
            secondDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "NextRunning";
            dataGridViewTextBoxColumn1.HeaderText = "NextRunning";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // mailTaskBindingSource
            // 
            mailTaskBindingSource.AllowNew = false;
            mailTaskBindingSource.DataSource = typeof(MailTask);
            mailTaskBindingSource.CurrentItemChanged += mailTaskBindingSource_CurrentItemChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            ClientSize = new System.Drawing.Size(935, 626);
            Controls.Add(dataGridView1);
            Controls.Add(btnRunTask);
            Controls.Add(btnStopTask);
            Controls.Add(btnStartTask);
            Controls.Add(btnListMailTasks);
            Controls.Add(lbLogs);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mailTaskBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lbLogs;
        private System.Windows.Forms.Button btnListMailTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn nExtRunningDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnStartTask;
        private System.Windows.Forms.Button btnStopTask;
        private System.Windows.Forms.Button btnRunTask;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ısRunningDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ısStartedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource mailTaskBindingSource;
    }
}
