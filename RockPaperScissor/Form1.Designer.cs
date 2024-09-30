
namespace RockPaperScissor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtWinner = new TextBox();
            btnRock = new Button();
            btnSec = new Button();
            btnPaper = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblP = new Label();
            lblc = new Label();
            pctBxP = new PictureBox();
            pctBxc = new PictureBox();
            lblscorep = new Label();
            lblscorec = new Label();
            ((System.ComponentModel.ISupportInitialize)pctBxP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctBxc).BeginInit();
            SuspendLayout();
            // 
            // txtWinner
            // 
            txtWinner.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWinner.Location = new Point(24, 363);
            txtWinner.Name = "txtWinner";
            txtWinner.Size = new Size(749, 46);
            txtWinner.TabIndex = 4;
            txtWinner.TextAlign = HorizontalAlignment.Center;
            // 
            // btnRock
            // 
            btnRock.BackgroundImage = (Image)resources.GetObject("btnRock.BackgroundImage");
            btnRock.Font = new Font("Californian FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRock.Image = (Image)resources.GetObject("btnRock.Image");
            btnRock.Location = new Point(24, 445);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(208, 198);
            btnRock.TabIndex = 5;
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += btnRock_Click;
            // 
            // btnSec
            // 
            btnSec.Font = new Font("Californian FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSec.Image = (Image)resources.GetObject("btnSec.Image");
            btnSec.Location = new Point(565, 445);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(208, 198);
            btnSec.TabIndex = 6;
            btnSec.UseVisualStyleBackColor = true;
            btnSec.Click += btnSec_Click;
            // 
            // btnPaper
            // 
            btnPaper.BackgroundImageLayout = ImageLayout.Zoom;
            btnPaper.Font = new Font("Californian FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPaper.Image = (Image)resources.GetObject("btnPaper.Image");
            btnPaper.Location = new Point(292, 445);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(208, 198);
            btnPaper.TabIndex = 7;
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlText;
            button4.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(292, 657);
            button4.Name = "button4";
            button4.Size = new Size(208, 61);
            button4.TabIndex = 8;
            button4.Text = "Restart Game";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(161, 9);
            label1.Name = "label1";
            label1.Size = new Size(476, 79);
            label1.TabIndex = 0;
            label1.Text = "Rock Paper Scissor";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 114);
            label2.Name = "label2";
            label2.Size = new Size(94, 40);
            label2.TabIndex = 1;
            label2.Text = "Player";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(587, 114);
            label3.Name = "label3";
            label3.Size = new Size(145, 40);
            label3.TabIndex = 2;
            label3.Text = "Computer";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(374, 120);
            label4.Name = "label4";
            label4.Size = new Size(43, 32);
            label4.TabIndex = 3;
            label4.Text = "VS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(310, 134);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 9;
            // 
            // lblP
            // 
            lblP.AutoSize = true;
            lblP.Location = new Point(100, 171);
            lblP.Name = "lblP";
            lblP.Size = new Size(0, 15);
            lblP.TabIndex = 10;
            // 
            // lblc
            // 
            lblc.AutoSize = true;
            lblc.Location = new Point(637, 172);
            lblc.Name = "lblc";
            lblc.Size = new Size(0, 15);
            lblc.TabIndex = 11;
            // 
            // pctBxP
            // 
            pctBxP.Location = new Point(49, 171);
            pctBxP.Name = "pctBxP";
            pctBxP.Size = new Size(169, 164);
            pctBxP.SizeMode = PictureBoxSizeMode.CenterImage;
            pctBxP.TabIndex = 12;
            pctBxP.TabStop = false;
            // 
            // pctBxc
            // 
            pctBxc.Location = new Point(578, 171);
            pctBxc.Name = "pctBxc";
            pctBxc.Size = new Size(169, 164);
            pctBxc.SizeMode = PictureBoxSizeMode.CenterImage;
            pctBxc.TabIndex = 13;
            pctBxc.TabStop = false;
            // 
            // lblscorep
            // 
            lblscorep.AutoSize = true;
            lblscorep.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblscorep.Location = new Point(170, 120);
            lblscorep.Name = "lblscorep";
            lblscorep.Size = new Size(0, 32);
            lblscorep.TabIndex = 14;
            lblscorep.Click += lblscorep_Click;
            // 
            // lblscorec
            // 
            lblscorec.AutoSize = true;
            lblscorec.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblscorec.Location = new Point(726, 120);
            lblscorec.Name = "lblscorec";
            lblscorec.Size = new Size(0, 32);
            lblscorec.TabIndex = 15;
            lblscorec.Click += lblscorec_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 719);
            Controls.Add(lblscorec);
            Controls.Add(lblscorep);
            Controls.Add(pctBxc);
            Controls.Add(pctBxP);
            Controls.Add(lblc);
            Controls.Add(lblP);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(btnPaper);
            Controls.Add(btnSec);
            Controls.Add(btnRock);
            Controls.Add(txtWinner);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pctBxP).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctBxc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private TextBox txtWinner;
        private Button btnRock;
        private Button btnSec;
        private Button btnPaper;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblP;
        private Label lblc;
        private PictureBox pctBxP;
        private PictureBox pctBxc;
        private Label lblscorep;
        private Label lblscorec;
    }
}
