namespace Niblack
{
    partial class Niblack_Form
    {
        
        private System.ComponentModel.IContainer components = null;

        
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
       
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.PoB1 = new System.Windows.Forms.ProgressBar();
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.OpenBut = new System.Windows.Forms.Button();
            this.fLP1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.kBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.areaBox = new System.Windows.Forms.TextBox();
            this.codeBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.fLP1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Progress:";
            // 
            // PoB1
            // 
            this.PoB1.Location = new System.Drawing.Point(307, 328);
            this.PoB1.Margin = new System.Windows.Forms.Padding(2);
            this.PoB1.Name = "PoB1";
            this.PoB1.Size = new System.Drawing.Size(143, 20);
            this.PoB1.TabIndex = 7;
            this.PoB1.Click += new System.EventHandler(this.PoB1_Click);
            // 
            // PB1
            // 
            this.PB1.Location = new System.Drawing.Point(2, 2);
            this.PB1.Margin = new System.Windows.Forms.Padding(2);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(452, 236);
            this.PB1.TabIndex = 0;
            this.PB1.TabStop = false;
            // 
            // OpenBut
            // 
            this.OpenBut.Location = new System.Drawing.Point(10, 287);
            this.OpenBut.Margin = new System.Windows.Forms.Padding(2);
            this.OpenBut.Name = "OpenBut";
            this.OpenBut.Size = new System.Drawing.Size(105, 31);
            this.OpenBut.TabIndex = 1;
            this.OpenBut.Text = "Megnyitás";
            this.OpenBut.UseVisualStyleBackColor = true;
            this.OpenBut.Click += new System.EventHandler(this.OpenBut_Click);
            // 
            // fLP1
            // 
            this.fLP1.Controls.Add(this.PB1);
            this.fLP1.Location = new System.Drawing.Point(9, 10);
            this.fLP1.Margin = new System.Windows.Forms.Padding(2);
            this.fLP1.Name = "fLP1";
            this.fLP1.Size = new System.Drawing.Size(454, 264);
            this.fLP1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 300);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "k:";
            // 
            // kBox
            // 
            this.kBox.Location = new System.Drawing.Point(178, 300);
            this.kBox.Margin = new System.Windows.Forms.Padding(2);
            this.kBox.Name = "kBox";
            this.kBox.Size = new System.Drawing.Size(76, 20);
            this.kBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 328);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Area:";
            // 
            // areaBox
            // 
            this.areaBox.Location = new System.Drawing.Point(178, 328);
            this.areaBox.Margin = new System.Windows.Forms.Padding(2);
            this.areaBox.Name = "areaBox";
            this.areaBox.Size = new System.Drawing.Size(76, 20);
            this.areaBox.TabIndex = 4;
            // 
            // codeBut
            // 
            this.codeBut.Location = new System.Drawing.Point(9, 323);
            this.codeBut.Margin = new System.Windows.Forms.Padding(2);
            this.codeBut.Name = "codeBut";
            this.codeBut.Size = new System.Drawing.Size(106, 29);
            this.codeBut.TabIndex = 5;
            this.codeBut.Text = "Niblack ";
            this.codeBut.UseVisualStyleBackColor = true;
            this.codeBut.Click += new System.EventHandler(this.codeBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Beállítások:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Progress:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Niblack_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(472, 366);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codeBut);
            this.Controls.Add(this.areaBox);
            this.Controls.Add(this.kBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fLP1);
            this.Controls.Add(this.OpenBut);
            this.Controls.Add(this.PoB1);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Niblack_Form";
            this.Text = "Kép feldolgozás (Niblack eljárás)";
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.fLP1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.Button OpenBut;
        private System.Windows.Forms.FlowLayoutPanel fLP1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox areaBox;
        private System.Windows.Forms.Button codeBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ProgressBar PoB1;
        private System.Windows.Forms.Label label5;
        
    }
}

