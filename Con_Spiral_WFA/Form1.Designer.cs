
namespace Con_Spiral_WFA
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.xMittelpunkt = new System.Windows.Forms.TextBox();
            this.yMittelpunkt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startRadius = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maxH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.minR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.filenameCSV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // xMittelpunkt
            // 
            this.xMittelpunkt.AccessibleName = "";
            this.xMittelpunkt.Location = new System.Drawing.Point(271, 16);
            this.xMittelpunkt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xMittelpunkt.Name = "xMittelpunkt";
            this.xMittelpunkt.Size = new System.Drawing.Size(68, 20);
            this.xMittelpunkt.TabIndex = 0;
            // 
            // yMittelpunkt
            // 
            this.yMittelpunkt.AccessibleName = "";
            this.yMittelpunkt.Location = new System.Drawing.Point(353, 16);
            this.yMittelpunkt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yMittelpunkt.Name = "yMittelpunkt";
            this.yMittelpunkt.Size = new System.Drawing.Size(68, 20);
            this.yMittelpunkt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mittelpunkt in m:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Startradius in m:";
            // 
            // startRadius
            // 
            this.startRadius.AccessibleName = "";
            this.startRadius.Location = new System.Drawing.Point(271, 49);
            this.startRadius.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startRadius.Name = "startRadius";
            this.startRadius.Size = new System.Drawing.Size(68, 20);
            this.startRadius.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Maximale Höhe Spirale in m:";
            // 
            // maxH
            // 
            this.maxH.AccessibleName = "";
            this.maxH.Location = new System.Drawing.Point(271, 81);
            this.maxH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maxH.Name = "maxH";
            this.maxH.Size = new System.Drawing.Size(68, 20);
            this.maxH.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Minimaler Radius in m:";
            // 
            // minR
            // 
            this.minR.AccessibleName = "";
            this.minR.Location = new System.Drawing.Point(271, 111);
            this.minR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minR.Name = "minR";
            this.minR.Size = new System.Drawing.Size(68, 20);
            this.minR.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Steigung";
            // 
            // S
            // 
            this.S.AccessibleName = "";
            this.S.Location = new System.Drawing.Point(271, 142);
            this.S.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(68, 20);
            this.S.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 231);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Plot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(512, 16);
            this.cartesianChart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(345, 216);
            this.cartesianChart1.TabIndex = 13;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 231);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 29);
            this.button2.TabIndex = 14;
            this.button2.Text = "Export CSV";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Filename CSV";
            // 
            // filenameCSV
            // 
            this.filenameCSV.AccessibleName = "";
            this.filenameCSV.Location = new System.Drawing.Point(271, 181);
            this.filenameCSV.Margin = new System.Windows.Forms.Padding(2);
            this.filenameCSV.Name = "filenameCSV";
            this.filenameCSV.Size = new System.Drawing.Size(68, 20);
            this.filenameCSV.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 283);
            this.Controls.Add(this.filenameCSV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.S);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.minR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startRadius);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yMittelpunkt);
            this.Controls.Add(this.xMittelpunkt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xMittelpunkt;
        private System.Windows.Forms.TextBox yMittelpunkt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startRadius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maxH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox minR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox S;
        private System.Windows.Forms.Button button1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox filenameCSV;
    }
}

