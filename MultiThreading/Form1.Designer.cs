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
            mailTaskBindingSource = new System.Windows.Forms.BindingSource(components);
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            numericMailCount = new System.Windows.Forms.NumericUpDown();
            rbAll = new System.Windows.Forms.RadioButton();
            rbGoogleProvider = new System.Windows.Forms.RadioButton();
            rbSmtp = new System.Windows.Forms.RadioButton();
            taskIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ProviderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ısRunningDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ısStartedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            secondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mailTaskBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericMailCount).BeginInit();
            SuspendLayout();
            // 
            // lbLogs
            // 
            lbLogs.BackColor = System.Drawing.SystemColors.WindowFrame;
            lbLogs.Dock = System.Windows.Forms.DockStyle.Bottom;
            lbLogs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbLogs.FormattingEnabled = true;
            lbLogs.ItemHeight = 15;
            lbLogs.Location = new System.Drawing.Point(0, 423);
            lbLogs.Name = "lbLogs";
            lbLogs.Size = new System.Drawing.Size(1064, 199);
            lbLogs.TabIndex = 0;
            lbLogs.SelectedIndexChanged += lbLogs_SelectedIndexChanged;
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
            btnStartTask.Dock = System.Windows.Forms.DockStyle.Left;
            btnStartTask.Enabled = false;
            btnStartTask.Location = new System.Drawing.Point(3, 19);
            btnStartTask.Name = "btnStartTask";
            btnStartTask.Size = new System.Drawing.Size(75, 47);
            btnStartTask.TabIndex = 3;
            btnStartTask.Text = "Start";
            btnStartTask.UseVisualStyleBackColor = true;
            btnStartTask.Click += btnStartTask_Click;
            // 
            // btnStopTask
            // 
            btnStopTask.Dock = System.Windows.Forms.DockStyle.Left;
            btnStopTask.Enabled = false;
            btnStopTask.Location = new System.Drawing.Point(78, 19);
            btnStopTask.Name = "btnStopTask";
            btnStopTask.Size = new System.Drawing.Size(75, 47);
            btnStopTask.TabIndex = 4;
            btnStopTask.Text = "Stop";
            btnStopTask.UseVisualStyleBackColor = true;
            btnStopTask.Click += btnStopTask_Click;
            // 
            // btnRunTask
            // 
            btnRunTask.Dock = System.Windows.Forms.DockStyle.Right;
            btnRunTask.Enabled = false;
            btnRunTask.Location = new System.Drawing.Point(986, 19);
            btnRunTask.Name = "btnRunTask";
            btnRunTask.Size = new System.Drawing.Size(75, 47);
            btnRunTask.TabIndex = 5;
            btnRunTask.Text = "Run";
            btnRunTask.UseVisualStyleBackColor = true;
            btnRunTask.Click += btnRunTask_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { taskIdDataGridViewTextBoxColumn, ProviderType, ısRunningDataGridViewCheckBoxColumn, ısStartedDataGridViewCheckBoxColumn, secondDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1 });
            dataGridView1.DataSource = mailTaskBindingSource;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            dataGridView1.Location = new System.Drawing.Point(0, 273);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(1064, 150);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // mailTaskBindingSource
            // 
            mailTaskBindingSource.AllowNew = false;
            mailTaskBindingSource.DataSource = typeof(MailTask);
            mailTaskBindingSource.CurrentItemChanged += mailTaskBindingSource_CurrentItemChanged_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRunTask);
            groupBox1.Controls.Add(btnStopTask);
            groupBox1.Controls.Add(btnStartTask);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            groupBox1.Location = new System.Drawing.Point(0, 204);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1064, 69);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericMailCount);
            groupBox2.Controls.Add(rbAll);
            groupBox2.Controls.Add(rbGoogleProvider);
            groupBox2.Controls.Add(rbSmtp);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            groupBox2.Location = new System.Drawing.Point(0, 140);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(1064, 64);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // numericMailCount
            // 
            numericMailCount.Dock = System.Windows.Forms.DockStyle.Right;
            numericMailCount.Location = new System.Drawing.Point(941, 19);
            numericMailCount.Name = "numericMailCount";
            numericMailCount.Size = new System.Drawing.Size(120, 23);
            numericMailCount.TabIndex = 9;
            // 
            // rbAll
            // 
            rbAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            rbAll.AutoSize = true;
            rbAll.Location = new System.Drawing.Point(182, 23);
            rbAll.Name = "rbAll";
            rbAll.Size = new System.Drawing.Size(39, 19);
            rbAll.TabIndex = 2;
            rbAll.TabStop = true;
            rbAll.Text = "All";
            rbAll.UseVisualStyleBackColor = true;
            // 
            // rbGoogleProvider
            // 
            rbGoogleProvider.Anchor = System.Windows.Forms.AnchorStyles.Left;
            rbGoogleProvider.AutoSize = true;
            rbGoogleProvider.Location = new System.Drawing.Point(72, 22);
            rbGoogleProvider.Name = "rbGoogleProvider";
            rbGoogleProvider.Size = new System.Drawing.Size(89, 19);
            rbGoogleProvider.TabIndex = 1;
            rbGoogleProvider.TabStop = true;
            rbGoogleProvider.Text = "Google Mail";
            rbGoogleProvider.UseVisualStyleBackColor = true;
            // 
            // rbSmtp
            // 
            rbSmtp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            rbSmtp.AutoSize = true;
            rbSmtp.Location = new System.Drawing.Point(6, 23);
            rbSmtp.Name = "rbSmtp";
            rbSmtp.Size = new System.Drawing.Size(53, 19);
            rbSmtp.TabIndex = 0;
            rbSmtp.TabStop = true;
            rbSmtp.Text = "Smtp";
            rbSmtp.UseVisualStyleBackColor = true;
            // 
            // taskIdDataGridViewTextBoxColumn
            // 
            taskIdDataGridViewTextBoxColumn.DataPropertyName = "TaskId";
            taskIdDataGridViewTextBoxColumn.HeaderText = "TaskId";
            taskIdDataGridViewTextBoxColumn.Name = "taskIdDataGridViewTextBoxColumn";
            taskIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProviderType
            // 
            ProviderType.DataPropertyName = "ProviderType";
            ProviderType.HeaderText = "ProviderType";
            ProviderType.Name = "ProviderType";
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
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            ClientSize = new System.Drawing.Size(1064, 622);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnListMailTasks);
            Controls.Add(lbLogs);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mailTaskBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericMailCount).EndInit();
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
        private System.Windows.Forms.BindingSource mailTaskBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericMailCount;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbGoogleProvider;
        private System.Windows.Forms.RadioButton rbSmtp;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProviderType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ısRunningDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ısStartedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}
