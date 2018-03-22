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
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.testButton = new System.Windows.Forms.Button();
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            this.SuspendLayout();
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(75, 369);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 0;
            this.testButton.Text = "TEST";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // barChart
            // 
            chartArea1.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea1);
            legendItem1.Color = System.Drawing.Color.Red;
            legendItem1.Name = "Regen";
            legend1.CustomItems.Add(legendItem1);
            legend1.Name = "Legend1";
            this.barChart.Legends.Add(legend1);
            this.barChart.Location = new System.Drawing.Point(41, 23);
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
            // Visualize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.barChart);
            this.Controls.Add(this.testButton);
            this.Name = "Visualize";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
    }
}

