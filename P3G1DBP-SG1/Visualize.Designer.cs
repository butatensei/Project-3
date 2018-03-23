namespace Project3Groep1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.MaandButton = new System.Windows.Forms.Button();
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WeatherButton = new System.Windows.Forms.Button();
            this.RainButton = new System.Windows.Forms.Button();
            this.FrostButton = new System.Windows.Forms.Button();
            this.WeekButton = new System.Windows.Forms.Button();
            this.NeerslagDropdown = new System.Windows.Forms.ComboBox();
            this.TestDropdownLaber = new System.Windows.Forms.Label();
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
            chartArea1.AxisX.Maximum = 12D;
            chartArea1.AxisX.Minimum = 1D;
            chartArea1.AxisX.ScaleBreakStyle.Spacing = 5D;
            chartArea1.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.barChart.Legends.Add(legend1);
            this.barChart.Location = new System.Drawing.Point(148, 21);
            this.barChart.Name = "barChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Fietsendiefstallen";
            this.barChart.Series.Add(series1);
            this.barChart.Size = new System.Drawing.Size(614, 322);
            this.barChart.TabIndex = 1;
            this.barChart.Text = "ShowData";
            title1.Name = "Fietsendiefstallen";
            this.barChart.Titles.Add(title1);
            // 
            // WeatherButton
            // 
            this.WeatherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
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
            // Visualize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

