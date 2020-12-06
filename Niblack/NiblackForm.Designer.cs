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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.fLP1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Eredeti";
            // 
            // PoB1
            // 
            this.PoB1.Location = new System.Drawing.Point(14, 645);
            this.PoB1.Name = "PoB1";
            this.PoB1.Size = new System.Drawing.Size(440, 31);
            this.PoB1.TabIndex = 7;
            this.PoB1.Click += new System.EventHandler(this.PoB1_Click);
            // 
            // PB1
            // 
            this.PB1.Location = new System.Drawing.Point(3, 3);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(437, 263);
            this.PB1.TabIndex = 0;
            this.PB1.TabStop = false;
            this.PB1.Click += new System.EventHandler(this.PB1_Click);
            // 
            // OpenBut
            // 
            this.OpenBut.Location = new System.Drawing.Point(12, 434);
            this.OpenBut.Name = "OpenBut";
            this.OpenBut.Size = new System.Drawing.Size(158, 48);
            this.OpenBut.TabIndex = 1;
            this.OpenBut.Text = "Megnyitás";
            this.OpenBut.UseVisualStyleBackColor = true;
            this.OpenBut.Click += new System.EventHandler(this.OpenBut_Click);
            // 
            // fLP1
            // 
            this.fLP1.Controls.Add(this.PB1);
            this.fLP1.Location = new System.Drawing.Point(14, 15);
            this.fLP1.Name = "fLP1";
            this.fLP1.Size = new System.Drawing.Size(440, 313);
            this.fLP1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "k:";
            // 
            // kBox
            // 
            this.kBox.Location = new System.Drawing.Point(231, 462);
            this.kBox.Name = "kBox";
            this.kBox.Size = new System.Drawing.Size(112, 26);
            this.kBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Area:";
            // 
            // areaBox
            // 
            this.areaBox.Location = new System.Drawing.Point(231, 502);
            this.areaBox.Name = "areaBox";
            this.areaBox.Size = new System.Drawing.Size(112, 26);
            this.areaBox.TabIndex = 4;
            // 
            // codeBut
            // 
            this.codeBut.Location = new System.Drawing.Point(11, 493);
            this.codeBut.Name = "codeBut";
            this.codeBut.Size = new System.Drawing.Size(159, 45);
            this.codeBut.TabIndex = 5;
            this.codeBut.Text = "Niblack ";
            this.codeBut.UseVisualStyleBackColor = true;
            this.codeBut.Click += new System.EventHandler(this.codeBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Beállítások:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 679);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Progress:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(535, 15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(440, 313);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.pictureBox1, true);
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 272);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sobel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(727, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Niblack";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(535, 363);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(440, 313);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(437, 272);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(727, 693);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sobel";
            // 
            // Niblack_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1032, 722);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
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
            this.Name = "Niblack_Form";
            this.Text = "Kép feldolgozás (Niblack eljárás)";
            this.Load += new System.EventHandler(this.Niblack_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.fLP1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
    }
}

