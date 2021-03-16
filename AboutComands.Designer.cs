
namespace OrganizerB
{
    partial class AboutComands
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Command5Goal = new System.Windows.Forms.Label();
            this.Command5L = new System.Windows.Forms.Label();
            this.Command4Goal = new System.Windows.Forms.Label();
            this.Command4L = new System.Windows.Forms.Label();
            this.Command3Goal = new System.Windows.Forms.Label();
            this.Command3L = new System.Windows.Forms.Label();
            this.Command2Goal = new System.Windows.Forms.Label();
            this.Command2L = new System.Windows.Forms.Label();
            this.Command1Goal = new System.Windows.Forms.Label();
            this.Command1L = new System.Windows.Forms.Label();
            this.GoalsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Penalty5 = new System.Windows.Forms.Label();
            this.Command5S = new System.Windows.Forms.Label();
            this.Penalty4 = new System.Windows.Forms.Label();
            this.Command4S = new System.Windows.Forms.Label();
            this.Penalty3 = new System.Windows.Forms.Label();
            this.Command3S = new System.Windows.Forms.Label();
            this.Penalty2 = new System.Windows.Forms.Label();
            this.Command2S = new System.Windows.Forms.Label();
            this.Penalty1 = new System.Windows.Forms.Label();
            this.Command1S = new System.Windows.Forms.Label();
            this.PenaltyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoalsChart)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PenaltyChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(502, 408);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(494, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Голы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Command5Goal);
            this.splitContainer1.Panel1.Controls.Add(this.Command5L);
            this.splitContainer1.Panel1.Controls.Add(this.Command4Goal);
            this.splitContainer1.Panel1.Controls.Add(this.Command4L);
            this.splitContainer1.Panel1.Controls.Add(this.Command3Goal);
            this.splitContainer1.Panel1.Controls.Add(this.Command3L);
            this.splitContainer1.Panel1.Controls.Add(this.Command2Goal);
            this.splitContainer1.Panel1.Controls.Add(this.Command2L);
            this.splitContainer1.Panel1.Controls.Add(this.Command1Goal);
            this.splitContainer1.Panel1.Controls.Add(this.Command1L);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GoalsChart);
            this.splitContainer1.Size = new System.Drawing.Size(488, 376);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 0;
            // 
            // Command5Goal
            // 
            this.Command5Goal.AutoSize = true;
            this.Command5Goal.Location = new System.Drawing.Point(91, 144);
            this.Command5Goal.Name = "Command5Goal";
            this.Command5Goal.Size = new System.Drawing.Size(25, 13);
            this.Command5Goal.TabIndex = 9;
            this.Command5Goal.Text = "500";
            // 
            // Command5L
            // 
            this.Command5L.AutoSize = true;
            this.Command5L.Location = new System.Drawing.Point(5, 144);
            this.Command5L.Name = "Command5L";
            this.Command5L.Size = new System.Drawing.Size(50, 13);
            this.Command5L.TabIndex = 8;
            this.Command5L.Text = "Йокерит";
            // 
            // Command4Goal
            // 
            this.Command4Goal.AutoSize = true;
            this.Command4Goal.Location = new System.Drawing.Point(91, 112);
            this.Command4Goal.Name = "Command4Goal";
            this.Command4Goal.Size = new System.Drawing.Size(25, 13);
            this.Command4Goal.TabIndex = 7;
            this.Command4Goal.Text = "400";
            // 
            // Command4L
            // 
            this.Command4L.AutoSize = true;
            this.Command4L.Location = new System.Drawing.Point(5, 112);
            this.Command4L.Name = "Command4L";
            this.Command4L.Size = new System.Drawing.Size(40, 13);
            this.Command4L.TabIndex = 6;
            this.Command4L.Text = "Барыс";
            // 
            // Command3Goal
            // 
            this.Command3Goal.AutoSize = true;
            this.Command3Goal.Location = new System.Drawing.Point(91, 77);
            this.Command3Goal.Name = "Command3Goal";
            this.Command3Goal.Size = new System.Drawing.Size(25, 13);
            this.Command3Goal.TabIndex = 5;
            this.Command3Goal.Text = "300";
            // 
            // Command3L
            // 
            this.Command3L.AutoSize = true;
            this.Command3L.Location = new System.Drawing.Point(5, 77);
            this.Command3L.Name = "Command3L";
            this.Command3L.Size = new System.Drawing.Size(33, 13);
            this.Command3L.TabIndex = 4;
            this.Command3L.Text = "Амур";
            // 
            // Command2Goal
            // 
            this.Command2Goal.AutoSize = true;
            this.Command2Goal.Location = new System.Drawing.Point(91, 41);
            this.Command2Goal.Name = "Command2Goal";
            this.Command2Goal.Size = new System.Drawing.Size(25, 13);
            this.Command2Goal.TabIndex = 3;
            this.Command2Goal.Text = "200";
            // 
            // Command2L
            // 
            this.Command2L.AutoSize = true;
            this.Command2L.Location = new System.Drawing.Point(5, 41);
            this.Command2L.Name = "Command2L";
            this.Command2L.Size = new System.Drawing.Size(80, 13);
            this.Command2L.TabIndex = 2;
            this.Command2L.Text = "Автомобилист";
            // 
            // Command1Goal
            // 
            this.Command1Goal.AutoSize = true;
            this.Command1Goal.Location = new System.Drawing.Point(91, 11);
            this.Command1Goal.Name = "Command1Goal";
            this.Command1Goal.Size = new System.Drawing.Size(25, 13);
            this.Command1Goal.TabIndex = 1;
            this.Command1Goal.Text = "100";
            // 
            // Command1L
            // 
            this.Command1L.AutoSize = true;
            this.Command1L.Location = new System.Drawing.Point(5, 11);
            this.Command1L.Name = "Command1L";
            this.Command1L.Size = new System.Drawing.Size(55, 13);
            this.Command1L.TabIndex = 0;
            this.Command1L.Text = "Авангард";
            // 
            // GoalsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.GoalsChart.ChartAreas.Add(chartArea1);
            this.GoalsChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.GoalsChart.Legends.Add(legend1);
            this.GoalsChart.Location = new System.Drawing.Point(0, 0);
            this.GoalsChart.Name = "GoalsChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.GoalsChart.Series.Add(series1);
            this.GoalsChart.Size = new System.Drawing.Size(322, 376);
            this.GoalsChart.TabIndex = 1;
            this.GoalsChart.Text = "chart2";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(494, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Штрафы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.Penalty5);
            this.splitContainer2.Panel1.Controls.Add(this.Command5S);
            this.splitContainer2.Panel1.Controls.Add(this.Penalty4);
            this.splitContainer2.Panel1.Controls.Add(this.Command4S);
            this.splitContainer2.Panel1.Controls.Add(this.Penalty3);
            this.splitContainer2.Panel1.Controls.Add(this.Command3S);
            this.splitContainer2.Panel1.Controls.Add(this.Penalty2);
            this.splitContainer2.Panel1.Controls.Add(this.Command2S);
            this.splitContainer2.Panel1.Controls.Add(this.Penalty1);
            this.splitContainer2.Panel1.Controls.Add(this.Command1S);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.PenaltyChart);
            this.splitContainer2.Size = new System.Drawing.Size(488, 376);
            this.splitContainer2.SplitterDistance = 162;
            this.splitContainer2.TabIndex = 1;
            // 
            // Penalty5
            // 
            this.Penalty5.AutoSize = true;
            this.Penalty5.Location = new System.Drawing.Point(102, 153);
            this.Penalty5.Name = "Penalty5";
            this.Penalty5.Size = new System.Drawing.Size(25, 13);
            this.Penalty5.TabIndex = 19;
            this.Penalty5.Text = "500";
            // 
            // Command5S
            // 
            this.Command5S.AutoSize = true;
            this.Command5S.Location = new System.Drawing.Point(16, 153);
            this.Command5S.Name = "Command5S";
            this.Command5S.Size = new System.Drawing.Size(50, 13);
            this.Command5S.TabIndex = 18;
            this.Command5S.Text = "Йокерит";
            // 
            // Penalty4
            // 
            this.Penalty4.AutoSize = true;
            this.Penalty4.Location = new System.Drawing.Point(102, 121);
            this.Penalty4.Name = "Penalty4";
            this.Penalty4.Size = new System.Drawing.Size(25, 13);
            this.Penalty4.TabIndex = 17;
            this.Penalty4.Text = "400";
            // 
            // Command4S
            // 
            this.Command4S.AutoSize = true;
            this.Command4S.Location = new System.Drawing.Point(16, 121);
            this.Command4S.Name = "Command4S";
            this.Command4S.Size = new System.Drawing.Size(40, 13);
            this.Command4S.TabIndex = 16;
            this.Command4S.Text = "Барыс";
            // 
            // Penalty3
            // 
            this.Penalty3.AutoSize = true;
            this.Penalty3.Location = new System.Drawing.Point(102, 86);
            this.Penalty3.Name = "Penalty3";
            this.Penalty3.Size = new System.Drawing.Size(25, 13);
            this.Penalty3.TabIndex = 15;
            this.Penalty3.Text = "300";
            // 
            // Command3S
            // 
            this.Command3S.AutoSize = true;
            this.Command3S.Location = new System.Drawing.Point(16, 86);
            this.Command3S.Name = "Command3S";
            this.Command3S.Size = new System.Drawing.Size(33, 13);
            this.Command3S.TabIndex = 14;
            this.Command3S.Text = "Амур";
            // 
            // Penalty2
            // 
            this.Penalty2.AutoSize = true;
            this.Penalty2.Location = new System.Drawing.Point(102, 50);
            this.Penalty2.Name = "Penalty2";
            this.Penalty2.Size = new System.Drawing.Size(25, 13);
            this.Penalty2.TabIndex = 13;
            this.Penalty2.Text = "200";
            // 
            // Command2S
            // 
            this.Command2S.AutoSize = true;
            this.Command2S.Location = new System.Drawing.Point(16, 50);
            this.Command2S.Name = "Command2S";
            this.Command2S.Size = new System.Drawing.Size(80, 13);
            this.Command2S.TabIndex = 12;
            this.Command2S.Text = "Автомобилист";
            // 
            // Penalty1
            // 
            this.Penalty1.AutoSize = true;
            this.Penalty1.Location = new System.Drawing.Point(102, 20);
            this.Penalty1.Name = "Penalty1";
            this.Penalty1.Size = new System.Drawing.Size(25, 13);
            this.Penalty1.TabIndex = 11;
            this.Penalty1.Text = "100";
            // 
            // Command1S
            // 
            this.Command1S.AutoSize = true;
            this.Command1S.Location = new System.Drawing.Point(16, 20);
            this.Command1S.Name = "Command1S";
            this.Command1S.Size = new System.Drawing.Size(55, 13);
            this.Command1S.TabIndex = 10;
            this.Command1S.Text = "Авангард";
            // 
            // PenaltyChart
            // 
            chartArea2.Name = "ChartArea1";
            this.PenaltyChart.ChartAreas.Add(chartArea2);
            this.PenaltyChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.PenaltyChart.Legends.Add(legend2);
            this.PenaltyChart.Location = new System.Drawing.Point(0, 0);
            this.PenaltyChart.Name = "PenaltyChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.PenaltyChart.Series.Add(series2);
            this.PenaltyChart.Size = new System.Drawing.Size(322, 376);
            this.PenaltyChart.TabIndex = 0;
            this.PenaltyChart.Text = "chart1";
            // 
            // AboutComands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 408);
            this.Controls.Add(this.tabControl1);
            this.Name = "AboutComands";
            this.Text = "О командах";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GoalsChart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PenaltyChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label Command5Goal;
        private System.Windows.Forms.Label Command5L;
        private System.Windows.Forms.Label Command4Goal;
        private System.Windows.Forms.Label Command4L;
        private System.Windows.Forms.Label Command3Goal;
        private System.Windows.Forms.Label Command3L;
        private System.Windows.Forms.Label Command2Goal;
        private System.Windows.Forms.Label Command2L;
        private System.Windows.Forms.Label Command1Goal;
        private System.Windows.Forms.Label Command1L;
        private System.Windows.Forms.Label Penalty5;
        private System.Windows.Forms.Label Command5S;
        private System.Windows.Forms.Label Penalty4;
        private System.Windows.Forms.Label Command4S;
        private System.Windows.Forms.Label Penalty3;
        private System.Windows.Forms.Label Command3S;
        private System.Windows.Forms.Label Penalty2;
        private System.Windows.Forms.Label Command2S;
        private System.Windows.Forms.Label Penalty1;
        private System.Windows.Forms.Label Command1S;
        private System.Windows.Forms.DataVisualization.Charting.Chart GoalsChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PenaltyChart;
    }
}