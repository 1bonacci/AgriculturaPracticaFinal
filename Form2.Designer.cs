namespace Agricultura_práctica_final
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chtGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.btnGraficarTotal = new System.Windows.Forms.Button();
            this.chtGraficoTotal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraficoTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(481, 472);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGraficar);
            this.tabPage1.Controls.Add(this.cmbLocalidad);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.chtGrafico);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(473, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGraficarTotal);
            this.tabPage2.Controls.Add(this.chtGraficoTotal);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(473, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chtGrafico
            // 
            chartArea3.Name = "ChartArea1";
            this.chtGrafico.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chtGrafico.Legends.Add(legend3);
            this.chtGrafico.Location = new System.Drawing.Point(25, 102);
            this.chtGrafico.Name = "chtGrafico";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chtGrafico.Series.Add(series3);
            this.chtGrafico.Size = new System.Drawing.Size(437, 336);
            this.chtGrafico.TabIndex = 0;
            this.chtGrafico.Text = "chtGrafico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Localidades";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(53, 51);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(181, 21);
            this.cmbLocalidad.TabIndex = 2;
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(306, 49);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(75, 23);
            this.btnGraficar.TabIndex = 3;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // btnGraficarTotal
            // 
            this.btnGraficarTotal.Location = new System.Drawing.Point(188, 35);
            this.btnGraficarTotal.Name = "btnGraficarTotal";
            this.btnGraficarTotal.Size = new System.Drawing.Size(75, 23);
            this.btnGraficarTotal.TabIndex = 5;
            this.btnGraficarTotal.Text = "Graficar";
            this.btnGraficarTotal.UseVisualStyleBackColor = true;
            // 
            // chtGraficoTotal
            // 
            chartArea4.Name = "ChartArea1";
            this.chtGraficoTotal.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chtGraficoTotal.Legends.Add(legend4);
            this.chtGraficoTotal.Location = new System.Drawing.Point(17, 88);
            this.chtGraficoTotal.Name = "chtGraficoTotal";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chtGraficoTotal.Series.Add(series4);
            this.chtGraficoTotal.Size = new System.Drawing.Size(437, 336);
            this.chtGraficoTotal.TabIndex = 4;
            this.chtGraficoTotal.Text = "chtGrafico";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 492);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Gráfico de Producción";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraficoTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGrafico;
        private System.Windows.Forms.Button btnGraficarTotal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraficoTotal;
    }
}