namespace MKO
{
    partial class Form1
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

        private void SetDefaultChart()
        {
            this.chart1.Series.Clear();
        }

        private void DeleteSeries(string name)
        {
            var series = this.chart1.Series.FindByName(name);
            this.chart1.Series.Remove(series);
        }

        private void AddPoints(string name, System.Drawing.Color color)
        {
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();

            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = $"Line {name}";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.Color = color;
            this.chart1.Series.Add(series1);

            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Name = $"Points {name}";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.Color = color;
            this.chart1.Series.Add(series2);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.inputT = new System.Windows.Forms.TextBox();
            this.inputB = new System.Windows.Forms.TextBox();
            this.readInputButton = new System.Windows.Forms.Button();
            this.inputSigma = new System.Windows.Forms.TextBox();
            this.inputF = new System.Windows.Forms.TextBox();
            this.inputQ = new System.Windows.Forms.TextBox();
            this.labelT = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelSigma = new System.Windows.Forms.Label();
            this.labelF = new System.Windows.Forms.Label();
            this.labelQ = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.inputN = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelL = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputT
            // 
            this.inputT.Location = new System.Drawing.Point(21, 20);
            this.inputT.Name = "inputT";
            this.inputT.Size = new System.Drawing.Size(100, 22);
            this.inputT.TabIndex = 0;
            // 
            // inputB
            // 
            this.inputB.Location = new System.Drawing.Point(21, 58);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(100, 22);
            this.inputB.TabIndex = 1;
            // 
            // readInputButton
            // 
            this.readInputButton.Location = new System.Drawing.Point(21, 247);
            this.readInputButton.Name = "readInputButton";
            this.readInputButton.Size = new System.Drawing.Size(100, 28);
            this.readInputButton.TabIndex = 6;
            this.readInputButton.Text = "Solve";
            this.readInputButton.UseVisualStyleBackColor = true;
            this.readInputButton.Click += new System.EventHandler(this.readInputButton_Click);
            // 
            // inputSigma
            // 
            this.inputSigma.Location = new System.Drawing.Point(21, 99);
            this.inputSigma.Name = "inputSigma";
            this.inputSigma.Size = new System.Drawing.Size(100, 22);
            this.inputSigma.TabIndex = 2;
            // 
            // inputF
            // 
            this.inputF.Location = new System.Drawing.Point(21, 137);
            this.inputF.Name = "inputF";
            this.inputF.Size = new System.Drawing.Size(100, 22);
            this.inputF.TabIndex = 3;
            // 
            // inputQ
            // 
            this.inputQ.Location = new System.Drawing.Point(21, 175);
            this.inputQ.Name = "inputQ";
            this.inputQ.Size = new System.Drawing.Size(100, 22);
            this.inputQ.TabIndex = 4;
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Location = new System.Drawing.Point(128, 24);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(33, 17);
            this.labelT.TabIndex = 7;
            this.labelT.Text = "T(x)";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(128, 62);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(32, 17);
            this.labelB.TabIndex = 8;
            this.labelB.Text = "b(x)";
            // 
            // labelSigma
            // 
            this.labelSigma.AutoSize = true;
            this.labelSigma.Location = new System.Drawing.Point(128, 102);
            this.labelSigma.Name = "labelSigma";
            this.labelSigma.Size = new System.Drawing.Size(32, 17);
            this.labelSigma.TabIndex = 9;
            this.labelSigma.Text = "σ(x)";
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Location = new System.Drawing.Point(128, 140);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(28, 17);
            this.labelF.TabIndex = 10;
            this.labelF.Text = "f(x)";
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.Location = new System.Drawing.Point(131, 179);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(16, 17);
            this.labelQ.TabIndex = 11;
            this.labelQ.Text = "q";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(131, 210);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(16, 17);
            this.labelN.TabIndex = 13;
            this.labelN.Text = "n";
            // 
            // inputN
            // 
            this.inputN.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.inputN.Location = new System.Drawing.Point(21, 208);
            this.inputN.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inputN.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.inputN.Name = "inputN";
            this.inputN.Size = new System.Drawing.Size(100, 22);
            this.inputN.TabIndex = 5;
            this.inputN.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea1.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.Maximum = 1D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(167, 24);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.Size = new System.Drawing.Size(1098, 622);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(21, 336);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 30);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "L =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "H =";
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Location = new System.Drawing.Point(55, 432);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(0, 17);
            this.labelL.TabIndex = 22;
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(55, 469);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(0, 17);
            this.labelH.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 658);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.inputN);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.labelF);
            this.Controls.Add(this.labelSigma);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelT);
            this.Controls.Add(this.inputQ);
            this.Controls.Add(this.inputF);
            this.Controls.Add(this.inputSigma);
            this.Controls.Add(this.readInputButton);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputT);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inputN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputT;
        private System.Windows.Forms.TextBox inputB;
        private System.Windows.Forms.TextBox inputSigma;
        private System.Windows.Forms.TextBox inputF;
        private System.Windows.Forms.TextBox inputQ;
        private System.Windows.Forms.Button readInputButton;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelSigma;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.NumericUpDown inputN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.Label labelH;
    }
}

