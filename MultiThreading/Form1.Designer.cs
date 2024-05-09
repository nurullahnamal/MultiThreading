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
            listBox1 = new System.Windows.Forms.ListBox();
            btnListMailTasks = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            TaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ısRunningDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ısStartedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            secondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nExtRunningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mailTaskBindingSource = new System.Windows.Forms.BindingSource(components);
            btnStartTask = new System.Windows.Forms.Button();
            btnStopTask = new System.Windows.Forms.Button();
            btnRunTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mailTaskBindingSource).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            listBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(0, 427);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(935, 199);
            listBox1.TabIndex = 0;
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
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { TaskId, ısRunningDataGridViewCheckBoxColumn, ısStartedDataGridViewCheckBoxColumn, secondDataGridViewTextBoxColumn, nExtRunningDataGridViewTextBoxColumn });
            dataGridView1.DataSource = mailTaskBindingSource;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            dataGridView1.Location = new System.Drawing.Point(0, 277);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(935, 150);
            dataGridView1.TabIndex = 2;
            // 
            // TaskId
            // 
            TaskId.DataPropertyName = "TaskId";
            TaskId.HeaderText = "TaskId";
            TaskId.Name = "TaskId";
            TaskId.ReadOnly = true;
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
            // nExtRunningDataGridViewTextBoxColumn
            // 
            nExtRunningDataGridViewTextBoxColumn.DataPropertyName = "NExtRunning";
            nExtRunningDataGridViewTextBoxColumn.HeaderText = "NExtRunning";
            nExtRunningDataGridViewTextBoxColumn.Name = "nExtRunningDataGridViewTextBoxColumn";
            nExtRunningDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailTaskBindingSource
            // 
            mailTaskBindingSource.AllowNew = false;
            mailTaskBindingSource.DataSource = typeof(MailTask);
            mailTaskBindingSource.CurrentChanged += mailTaskBindingSource_CurrentChanged;
            mailTaskBindingSource.CurrentItemChanged += mailTaskBindingSource_CurrentItemChanged;
            // 
            // btnStartTask
            // 
            btnStartTask.Enabled = false;
            btnStartTask.Location = new System.Drawing.Point(-5, 234);
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
            btnStopTask.Location = new System.Drawing.Point(192, 222);
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
            btnRunTask.Location = new System.Drawing.Point(387, 222);
            btnRunTask.Name = "btnRunTask";
            btnRunTask.Size = new System.Drawing.Size(75, 23);
            btnRunTask.TabIndex = 5;
            btnRunTask.Text = "Run";
            btnRunTask.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            ClientSize = new System.Drawing.Size(935, 626);
            Controls.Add(btnRunTask);
            Controls.Add(btnStopTask);
            Controls.Add(btnStartTask);
            Controls.Add(dataGridView1);
            Controls.Add(btnListMailTasks);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mailTaskBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnListMailTasks;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mailTaskBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ısRunningDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ısStartedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nExtRunningDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnStartTask;
        private System.Windows.Forms.Button btnStopTask;
        private System.Windows.Forms.Button btnRunTask;
    }
}
