namespace ДЗформы4
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Browse = new System.Windows.Forms.Button();
            this.LOC = new System.Windows.Forms.TextBox();
            this.NOC = new System.Windows.Forms.TextBox();
            this.NOM = new System.Windows.Forms.TextBox();
            this.NOP = new System.Windows.Forms.TextBox();
            this.valueNOM = new System.Windows.Forms.TextBox();
            this.valueNOP = new System.Windows.Forms.TextBox();
            this.valueNOC = new System.Windows.Forms.TextBox();
            this.valueLOC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(24, 23);
            this.Browse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(150, 44);
            this.Browse.TabIndex = 0;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // LOC
            // 
            this.LOC.Location = new System.Drawing.Point(24, 79);
            this.LOC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LOC.Name = "LOC";
            this.LOC.Size = new System.Drawing.Size(196, 31);
            this.LOC.TabIndex = 1;
            this.LOC.Text = "LOC";
            // 
            // NOC
            // 
            this.NOC.Location = new System.Drawing.Point(236, 79);
            this.NOC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NOC.Name = "NOC";
            this.NOC.Size = new System.Drawing.Size(196, 31);
            this.NOC.TabIndex = 2;
            this.NOC.Text = "NOC";
            // 
            // NOM
            // 
            this.NOM.Location = new System.Drawing.Point(660, 79);
            this.NOM.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NOM.Name = "NOM";
            this.NOM.Size = new System.Drawing.Size(196, 31);
            this.NOM.TabIndex = 4;
            this.NOM.Text = "NOM";
            // 
            // NOP
            // 
            this.NOP.Location = new System.Drawing.Point(448, 79);
            this.NOP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NOP.Name = "NOP";
            this.NOP.Size = new System.Drawing.Size(196, 31);
            this.NOP.TabIndex = 3;
            this.NOP.Text = "NOP";
            // 
            // valueNOM
            // 
            this.valueNOM.Location = new System.Drawing.Point(660, 129);
            this.valueNOM.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.valueNOM.Name = "valueNOM";
            this.valueNOM.Size = new System.Drawing.Size(196, 31);
            this.valueNOM.TabIndex = 11;
            // 
            // valueNOP
            // 
            this.valueNOP.Location = new System.Drawing.Point(448, 129);
            this.valueNOP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.valueNOP.Name = "valueNOP";
            this.valueNOP.Size = new System.Drawing.Size(196, 31);
            this.valueNOP.TabIndex = 10;
            // 
            // valueNOC
            // 
            this.valueNOC.Location = new System.Drawing.Point(236, 129);
            this.valueNOC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.valueNOC.Name = "valueNOC";
            this.valueNOC.Size = new System.Drawing.Size(196, 31);
            this.valueNOC.TabIndex = 9;
            // 
            // valueLOC
            // 
            this.valueLOC.Location = new System.Drawing.Point(24, 129);
            this.valueLOC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.valueLOC.Name = "valueLOC";
            this.valueLOC.Size = new System.Drawing.Size(196, 31);
            this.valueLOC.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.valueNOM);
            this.Controls.Add(this.valueNOP);
            this.Controls.Add(this.valueNOC);
            this.Controls.Add(this.valueLOC);
            this.Controls.Add(this.NOM);
            this.Controls.Add(this.NOP);
            this.Controls.Add(this.NOC);
            this.Controls.Add(this.LOC);
            this.Controls.Add(this.Browse);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox LOC;
        private System.Windows.Forms.TextBox NOC;
        private System.Windows.Forms.TextBox NOM;
        private System.Windows.Forms.TextBox NOP;
        private System.Windows.Forms.TextBox valueNOM;
        private System.Windows.Forms.TextBox valueNOP;
        private System.Windows.Forms.TextBox valueNOC;
        private System.Windows.Forms.TextBox valueLOC;
    }
}

