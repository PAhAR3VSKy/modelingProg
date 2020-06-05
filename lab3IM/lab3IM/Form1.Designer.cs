namespace lab3IM
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.loadingHours = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.loadingPercent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.meanNumbTanker = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.meanTimeTanker = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.meanWaitTanker = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loadingHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanNumbTanker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanTimeTanker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanWaitTanker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // loadingHours
            // 
            chartArea1.Name = "ChartArea1";
            this.loadingHours.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.loadingHours.Legends.Add(legend1);
            this.loadingHours.Location = new System.Drawing.Point(10, 25);
            this.loadingHours.Name = "loadingHours";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.loadingHours.Series.Add(series1);
            this.loadingHours.Size = new System.Drawing.Size(313, 300);
            this.loadingHours.TabIndex = 0;
            this.loadingHours.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Средняя загрузка порта в часах от общего времени работы";
            // 
            // loadingPercent
            // 
            chartArea2.Name = "ChartArea1";
            this.loadingPercent.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.loadingPercent.Legends.Add(legend2);
            this.loadingPercent.Location = new System.Drawing.Point(329, 25);
            this.loadingPercent.Name = "loadingPercent";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.loadingPercent.Series.Add(series2);
            this.loadingPercent.Size = new System.Drawing.Size(300, 300);
            this.loadingPercent.TabIndex = 2;
            this.loadingPercent.Text = "chart2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Средняя загруженность в % от общего времени работы";
            // 
            // meanNumbTanker
            // 
            chartArea3.Name = "ChartArea1";
            this.meanNumbTanker.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.meanNumbTanker.Legends.Add(legend3);
            this.meanNumbTanker.Location = new System.Drawing.Point(10, 349);
            this.meanNumbTanker.Name = "meanNumbTanker";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.meanNumbTanker.Series.Add(series3);
            this.meanNumbTanker.Size = new System.Drawing.Size(313, 300);
            this.meanNumbTanker.TabIndex = 4;
            this.meanNumbTanker.Text = "chart3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Среднее число загруженных танкеров";
            // 
            // meanTimeTanker
            // 
            chartArea4.Name = "ChartArea1";
            this.meanTimeTanker.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.meanTimeTanker.Legends.Add(legend4);
            this.meanTimeTanker.Location = new System.Drawing.Point(329, 349);
            this.meanTimeTanker.Name = "meanTimeTanker";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.meanTimeTanker.Series.Add(series4);
            this.meanTimeTanker.Size = new System.Drawing.Size(300, 300);
            this.meanTimeTanker.TabIndex = 6;
            this.meanTimeTanker.Text = "chart4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Среднее время загрузки танкеров";
            // 
            // meanWaitTanker
            // 
            chartArea5.Name = "ChartArea1";
            this.meanWaitTanker.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.meanWaitTanker.Legends.Add(legend5);
            this.meanWaitTanker.Location = new System.Drawing.Point(635, 349);
            this.meanWaitTanker.Name = "meanWaitTanker";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.meanWaitTanker.Series.Add(series5);
            this.meanWaitTanker.Size = new System.Drawing.Size(300, 300);
            this.meanWaitTanker.TabIndex = 8;
            this.meanWaitTanker.Text = "chart5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(635, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Среднее время ожида-ния танкером погрузки в порту";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(638, 42);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(638, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Время моделирования";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 663);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.meanWaitTanker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.meanTimeTanker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.meanNumbTanker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loadingPercent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadingHours);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.loadingHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanNumbTanker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanTimeTanker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanWaitTanker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart loadingHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart loadingPercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart meanNumbTanker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart meanTimeTanker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart meanWaitTanker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
    }
}

