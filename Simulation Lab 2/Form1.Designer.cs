namespace Simulation_Lab_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.edRate = new System.Windows.Forms.NumericUpDown();
            this.edDollar = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDollar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Курс Евро";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Курс Доллар";
            // 
            // chart1
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Minimum = 60D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(20, 92);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "C";
            series1.Legend = "Legend1";
            series1.Name = "Курс 1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "C";
            series2.Legend = "Legend1";
            series2.Name = "Курс 2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(752, 288);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // edRate
            // 
            this.edRate.DecimalPlaces = 2;
            this.edRate.Location = new System.Drawing.Point(20, 50);
            this.edRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edRate.Name = "edRate";
            this.edRate.Size = new System.Drawing.Size(90, 20);
            this.edRate.TabIndex = 4;
            this.edRate.Value = new decimal(new int[] {
            8038,
            0,
            0,
            131072});
            // 
            // edDollar
            // 
            this.edDollar.DecimalPlaces = 2;
            this.edDollar.Location = new System.Drawing.Point(214, 50);
            this.edDollar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edDollar.Name = "edDollar";
            this.edDollar.Size = new System.Drawing.Size(90, 20);
            this.edDollar.TabIndex = 5;
            this.edDollar.Value = new decimal(new int[] {
            7624,
            0,
            0,
            131072});
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(427, 43);
            this.btStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(101, 29);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "Пуск/стоп";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 404);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.edDollar);
            this.Controls.Add(this.edRate);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDollar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown edRate;
        private System.Windows.Forms.NumericUpDown edDollar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btStart;
    }
}

