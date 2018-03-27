﻿namespace Project3Groep1
{
    partial class Visualize
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.MaandButton = new System.Windows.Forms.Button();
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WeatherButton = new System.Windows.Forms.Button();
            this.RainButton = new System.Windows.Forms.Button();
            this.FrostButton = new System.Windows.Forms.Button();
            this.WeekButton = new System.Windows.Forms.Button();
            this.NeerslagDropdown = new System.Windows.Forms.ComboBox();
            this.TestDropdownLaber = new System.Windows.Forms.Label();
            this.SubGroupButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            this.SuspendLayout();
            // 
            // MaandButton
            // 
            this.MaandButton.Location = new System.Drawing.Point(148, 349);
            this.MaandButton.Name = "MaandButton";
            this.MaandButton.Size = new System.Drawing.Size(75, 23);
            this.MaandButton.TabIndex = 0;
            this.MaandButton.Text = "Maand";
            this.MaandButton.UseVisualStyleBackColor = true;
            this.MaandButton.Click += new System.EventHandler(this.maandButton_Click);
            // 
            // barChart
            // 
            chartArea3.AxisX.Maximum = 365D;
            chartArea3.AxisX.Minimum = 1D;
            chartArea3.AxisX.ScaleBreakStyle.Spacing = 5D;
            chartArea3.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.barChart.Legends.Add(legend3);
            this.barChart.Location = new System.Drawing.Point(148, 21);
            this.barChart.Name = "barChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Fietsendiefstallen";
            this.barChart.Series.Add(series3);
            this.barChart.Size = new System.Drawing.Size(614, 322);
            this.barChart.TabIndex = 1;
            this.barChart.Text = "ShowData";
            title3.Name = "Fietsendiefstallen";
            this.barChart.Titles.Add(title3);
            // 
            // WeatherButton
            // 
            this.WeatherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.WeatherButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WeatherButton.Location = new System.Drawing.Point(12, 21);
            this.WeatherButton.Name = "WeatherButton";
            this.WeatherButton.Size = new System.Drawing.Size(76, 74);
            this.WeatherButton.TabIndex = 2;
            this.WeatherButton.Text = "☁";
            this.WeatherButton.UseVisualStyleBackColor = true;
            this.WeatherButton.Click += new System.EventHandler(this.WeatherButton_Click);
            // 
            // RainButton
            // 
            this.RainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.RainButton.Location = new System.Drawing.Point(12, 101);
            this.RainButton.Name = "RainButton";
            this.RainButton.Size = new System.Drawing.Size(76, 74);
            this.RainButton.TabIndex = 3;
            this.RainButton.Text = "☔";
            this.RainButton.UseVisualStyleBackColor = true;
            this.RainButton.Click += new System.EventHandler(this.RainButton_Click);
            // 
            // FrostButton
            // 
            this.FrostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.FrostButton.Location = new System.Drawing.Point(12, 181);
            this.FrostButton.Name = "FrostButton";
            this.FrostButton.Size = new System.Drawing.Size(76, 74);
            this.FrostButton.TabIndex = 4;
            this.FrostButton.Text = "❄";
            this.FrostButton.UseVisualStyleBackColor = true;
            this.FrostButton.Click += new System.EventHandler(this.FrostButton_Click);
            // 
            // WeekButton
            // 
            this.WeekButton.Location = new System.Drawing.Point(229, 349);
            this.WeekButton.Name = "WeekButton";
            this.WeekButton.Size = new System.Drawing.Size(75, 23);
            this.WeekButton.TabIndex = 5;
            this.WeekButton.Text = "Week";
            this.WeekButton.UseVisualStyleBackColor = true;
            // 
            // NeerslagDropdown
            // 
            this.NeerslagDropdown.FormattingEnabled = true;
            this.NeerslagDropdown.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.NeerslagDropdown.Location = new System.Drawing.Point(12, 351);
            this.NeerslagDropdown.Name = "NeerslagDropdown";
            this.NeerslagDropdown.Size = new System.Drawing.Size(121, 21);
            this.NeerslagDropdown.TabIndex = 6;
            this.NeerslagDropdown.SelectedIndexChanged += new System.EventHandler(this.NeerslagDropdown_SelectedIndexChanged);
            // 
            // TestDropdownLaber
            // 
            this.TestDropdownLaber.AutoSize = true;
            this.TestDropdownLaber.Location = new System.Drawing.Point(13, 332);
            this.TestDropdownLaber.Name = "TestDropdownLaber";
            this.TestDropdownLaber.Size = new System.Drawing.Size(76, 13);
            this.TestDropdownLaber.TabIndex = 7;
            this.TestDropdownLaber.Text = "neerslag mode";
            // 
            // SubGroupButton
            // 
            this.SubGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.SubGroupButton.ForeColor = System.Drawing.Color.Black;
            this.SubGroupButton.Location = new System.Drawing.Point(712, 364);
            this.SubGroupButton.Name = "SubGroupButton";
            this.SubGroupButton.Size = new System.Drawing.Size(76, 74);
            this.SubGroupButton.TabIndex = 8;
            this.SubGroupButton.Text = "🚲";
            this.SubGroupButton.UseVisualStyleBackColor = true;
            this.SubGroupButton.Click += new System.EventHandler(this.SubGroupButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.button1.Location = new System.Drawing.Point(369, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 74);
            this.button1.TabIndex = 9;
            this.button1.Text = "update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Visualize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SubGroupButton);
            this.Controls.Add(this.TestDropdownLaber);
            this.Controls.Add(this.NeerslagDropdown);
            this.Controls.Add(this.WeekButton);
            this.Controls.Add(this.FrostButton);
            this.Controls.Add(this.RainButton);
            this.Controls.Add(this.WeatherButton);
            this.Controls.Add(this.barChart);
            this.Controls.Add(this.MaandButton);
            this.Name = "Visualize";
            this.Text = "Fietsenfiefstallen & het Weer";
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MaandButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
        private System.Windows.Forms.Button WeatherButton;
        private System.Windows.Forms.Button RainButton;
        private System.Windows.Forms.Button FrostButton;
        private System.Windows.Forms.Button WeekButton;
        private System.Windows.Forms.ComboBox NeerslagDropdown;
        private System.Windows.Forms.Label TestDropdownLaber;
        private System.Windows.Forms.Button SubGroupButton;
        private System.Windows.Forms.Button button1;
    }
}

