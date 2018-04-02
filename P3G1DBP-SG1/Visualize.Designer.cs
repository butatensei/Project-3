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
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WeatherButton = new System.Windows.Forms.Button();
            this.RainButton = new System.Windows.Forms.Button();
            this.FrostButton = new System.Windows.Forms.Button();
            this.SubGroupButton = new System.Windows.Forms.Button();
            this.sunButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            this.SuspendLayout();
            // 
            // barChart
            // 
            chartArea1.AxisX.ScaleBreakStyle.Spacing = 5D;
            chartArea1.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.barChart.Legends.Add(legend1);
            this.barChart.Location = new System.Drawing.Point(198, 28);
            this.barChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barChart.Name = "barChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Legend = "Legend1";
            series1.Name = "Fietsendiefstallen";
            this.barChart.Series.Add(series1);
<<<<<<< HEAD
            this.barChart.Series.Add(series2);
            this.barChart.Series.Add(series3);
            this.barChart.Series.Add(series4);
            this.barChart.Size = new System.Drawing.Size(819, 396);
=======
            this.barChart.Size = new System.Drawing.Size(614, 322);
>>>>>>> origin/banic
            this.barChart.TabIndex = 1;
            this.barChart.Text = "ShowData";
            title1.Name = "Fietsendiefstallen";
            this.barChart.Titles.Add(title1);
            // 
            // WeatherButton
            // 
            this.WeatherButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WeatherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.WeatherButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WeatherButton.Location = new System.Drawing.Point(16, 250);
            this.WeatherButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WeatherButton.Name = "WeatherButton";
            this.WeatherButton.Size = new System.Drawing.Size(173, 95);
            this.WeatherButton.TabIndex = 2;
            this.WeatherButton.Text = "☁";
            this.WeatherButton.UseVisualStyleBackColor = true;
            this.WeatherButton.Click += new System.EventHandler(this.WeatherButton_Click);
            // 
            // RainButton
            // 
            this.RainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.RainButton.Location = new System.Drawing.Point(107, 352);
            this.RainButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RainButton.Name = "RainButton";
            this.RainButton.Size = new System.Drawing.Size(83, 71);
            this.RainButton.TabIndex = 3;
            this.RainButton.Text = "☔";
            this.RainButton.UseVisualStyleBackColor = true;
            this.RainButton.Click += new System.EventHandler(this.RainButton_Click);
            // 
            // FrostButton
            // 
            this.FrostButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FrostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.FrostButton.Location = new System.Drawing.Point(16, 352);
            this.FrostButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FrostButton.Name = "FrostButton";
            this.FrostButton.Size = new System.Drawing.Size(83, 71);
            this.FrostButton.TabIndex = 4;
            this.FrostButton.Text = "❄";
            this.FrostButton.UseVisualStyleBackColor = true;
            this.FrostButton.Click += new System.EventHandler(this.FrostButton_Click);
            // 
            // SubGroupButton
            // 
            this.SubGroupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.SubGroupButton.ForeColor = System.Drawing.Color.Black;
            this.SubGroupButton.Location = new System.Drawing.Point(949, 448);
            this.SubGroupButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubGroupButton.Name = "SubGroupButton";
            this.SubGroupButton.Size = new System.Drawing.Size(101, 91);
            this.SubGroupButton.TabIndex = 8;
            this.SubGroupButton.Text = "🚲";
            this.SubGroupButton.UseVisualStyleBackColor = true;
            this.SubGroupButton.Click += new System.EventHandler(this.SubGroupButton_Click);
            // 
<<<<<<< HEAD
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.button1.Location = new System.Drawing.Point(492, 432);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 91);
            this.button1.TabIndex = 9;
            this.button1.Text = "update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
=======
>>>>>>> origin/banic
            // sunButton
            // 
            this.sunButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.sunButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sunButton.Location = new System.Drawing.Point(16, 148);
            this.sunButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sunButton.Name = "sunButton";
            this.sunButton.Size = new System.Drawing.Size(173, 95);
            this.sunButton.TabIndex = 10;
            this.sunButton.Text = "☀";
            this.sunButton.UseVisualStyleBackColor = true;
            this.sunButton.Click += new System.EventHandler(this.sunButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "temperatuur in C°";
            // 
            // labelY
            // 
<<<<<<< HEAD
            this.GroepeerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroepeerBox.FormattingEnabled = true;
            this.GroepeerBox.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "5"});
            this.GroepeerBox.Location = new System.Drawing.Point(828, 343);
            this.GroepeerBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroepeerBox.Name = "GroepeerBox";
            this.GroepeerBox.Size = new System.Drawing.Size(160, 24);
            this.GroepeerBox.TabIndex = 11;
=======
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(157, 32);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(85, 13);
            this.labelY.TabIndex = 12;
            this.labelY.Text = "fietsendiefstallen";
>>>>>>> origin/banic
            // 
            // Visualize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.GroepeerBox);
=======
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.label1);
>>>>>>> origin/banic
            this.Controls.Add(this.sunButton);
            this.Controls.Add(this.SubGroupButton);
            this.Controls.Add(this.FrostButton);
            this.Controls.Add(this.RainButton);
            this.Controls.Add(this.WeatherButton);
            this.Controls.Add(this.barChart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Visualize";
            this.Text = "Fietsenfiefstallen & het Weer";
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
        private System.Windows.Forms.Button WeatherButton;
        private System.Windows.Forms.Button RainButton;
        private System.Windows.Forms.Button FrostButton;
        private System.Windows.Forms.Button SubGroupButton;
        private System.Windows.Forms.Button sunButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelY;
    }
}

