
namespace OrganizerB.Forms
{
    partial class TasksForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TasksView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CloseTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TaskText = new System.Windows.Forms.TextBox();
            this.TaskDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AddTask = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditTask = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TasksView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.625F));
            this.tableLayoutPanel1.Controls.Add(this.TasksView, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(727, 387);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TasksView
            // 
            this.TasksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TasksView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.TasksView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TasksView.Location = new System.Drawing.Point(231, 3);
            this.TasksView.Name = "TasksView";
            this.TasksView.Size = new System.Drawing.Size(493, 381);
            this.TasksView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EditTask);
            this.panel1.Controls.Add(this.CloseTask);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 381);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddTask);
            this.groupBox1.Controls.Add(this.TaskDatePicker);
            this.groupBox1.Controls.Add(this.TaskText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить задачу";
            // 
            // CloseTask
            // 
            this.CloseTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.CloseTask.Location = new System.Drawing.Point(0, 117);
            this.CloseTask.Name = "CloseTask";
            this.CloseTask.Size = new System.Drawing.Size(222, 23);
            this.CloseTask.TabIndex = 1;
            this.CloseTask.Text = "Завершить задачу";
            this.CloseTask.UseVisualStyleBackColor = true;
            this.CloseTask.Click += new System.EventHandler(this.CloseTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текст задачи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата окончания";
            // 
            // TaskText
            // 
            this.TaskText.Dock = System.Windows.Forms.DockStyle.Top;
            this.TaskText.Location = new System.Drawing.Point(3, 29);
            this.TaskText.Name = "TaskText";
            this.TaskText.Size = new System.Drawing.Size(216, 20);
            this.TaskText.TabIndex = 2;
            // 
            // TaskDatePicker
            // 
            this.TaskDatePicker.CustomFormat = "yyyy/MM/dd";
            this.TaskDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TaskDatePicker.Location = new System.Drawing.Point(3, 68);
            this.TaskDatePicker.Name = "TaskDatePicker";
            this.TaskDatePicker.Size = new System.Drawing.Size(216, 20);
            this.TaskDatePicker.TabIndex = 3;
            this.TaskDatePicker.Value = new System.DateTime(2019, 10, 1, 0, 0, 0, 0);
            // 
            // AddTask
            // 
            this.AddTask.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddTask.Location = new System.Drawing.Point(3, 91);
            this.AddTask.Name = "AddTask";
            this.AddTask.Size = new System.Drawing.Size(216, 23);
            this.AddTask.TabIndex = 4;
            this.AddTask.Text = "Добавить";
            this.AddTask.UseVisualStyleBackColor = true;
            this.AddTask.Click += new System.EventHandler(this.AddTask_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Задача";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Дата выполнения";
            this.Column3.Name = "Column3";
            // 
            // EditTask
            // 
            this.EditTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditTask.Location = new System.Drawing.Point(0, 140);
            this.EditTask.Name = "EditTask";
            this.EditTask.Size = new System.Drawing.Size(222, 23);
            this.EditTask.TabIndex = 2;
            this.EditTask.Text = "Изменить задачи";
            this.EditTask.UseVisualStyleBackColor = true;
            this.EditTask.Click += new System.EventHandler(this.EditTask_Click);
            // 
            // TasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 387);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TasksForm";
            this.Text = "Задачи";
            this.Shown += new System.EventHandler(this.TasksForm_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TasksView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView TasksView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseTask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddTask;
        private System.Windows.Forms.DateTimePicker TaskDatePicker;
        private System.Windows.Forms.TextBox TaskText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button EditTask;
    }
}