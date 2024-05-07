namespace CasinoSlot
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_casino = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.lbl_win = new System.Windows.Forms.Label();
            this.lbl_loss = new System.Windows.Forms.Label();
            this.lbl_bid = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_bid = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CasinoSlot.Properties.Resources.Neymar;
            this.pictureBox1.Location = new System.Drawing.Point(10, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CasinoSlot.Properties.Resources.Neymar;
            this.pictureBox2.Location = new System.Drawing.Point(102, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CasinoSlot.Properties.Resources.Neymar;
            this.pictureBox3.Location = new System.Drawing.Point(202, 75);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_casino
            // 
            this.lbl_casino.AutoSize = true;
            this.lbl_casino.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_casino.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_casino.Location = new System.Drawing.Point(12, 9);
            this.lbl_casino.Name = "lbl_casino";
            this.lbl_casino.Size = new System.Drawing.Size(79, 25);
            this.lbl_casino.TabIndex = 1;
            this.lbl_casino.Text = "Casino";
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balance.ForeColor = System.Drawing.Color.Gray;
            this.lbl_balance.Location = new System.Drawing.Point(12, 34);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(118, 25);
            this.lbl_balance.TabIndex = 1;
            this.lbl_balance.Text = "Balance : $";
            // 
            // lbl_win
            // 
            this.lbl_win.AutoSize = true;
            this.lbl_win.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_win.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbl_win.Location = new System.Drawing.Point(12, 202);
            this.lbl_win.Name = "lbl_win";
            this.lbl_win.Size = new System.Drawing.Size(94, 25);
            this.lbl_win.TabIndex = 1;
            this.lbl_win.Text = "Wins : 0";
            // 
            // lbl_loss
            // 
            this.lbl_loss.AutoSize = true;
            this.lbl_loss.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loss.ForeColor = System.Drawing.Color.Tomato;
            this.lbl_loss.Location = new System.Drawing.Point(12, 227);
            this.lbl_loss.Name = "lbl_loss";
            this.lbl_loss.Size = new System.Drawing.Size(88, 25);
            this.lbl_loss.TabIndex = 1;
            this.lbl_loss.Text = "Loss : 0";
            // 
            // lbl_bid
            // 
            this.lbl_bid.AutoSize = true;
            this.lbl_bid.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bid.ForeColor = System.Drawing.Color.Silver;
            this.lbl_bid.Location = new System.Drawing.Point(138, 188);
            this.lbl_bid.Name = "lbl_bid";
            this.lbl_bid.Size = new System.Drawing.Size(134, 25);
            this.lbl_bid.TabIndex = 1;
            this.lbl_bid.Text = "Bid-Amount";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(143, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 31);
            this.textBox1.TabIndex = 2;
            // 
            // btn_play
            // 
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.ForeColor = System.Drawing.Color.White;
            this.btn_play.Location = new System.Drawing.Point(12, 269);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(125, 50);
            this.btn_play.TabIndex = 3;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_bid
            // 
            this.btn_bid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bid.ForeColor = System.Drawing.Color.White;
            this.btn_bid.Location = new System.Drawing.Point(147, 269);
            this.btn_bid.Name = "btn_bid";
            this.btn_bid.Size = new System.Drawing.Size(125, 50);
            this.btn_bid.TabIndex = 3;
            this.btn_bid.Text = "New Bid";
            this.btn_bid.UseVisualStyleBackColor = true;
            this.btn_bid.Click += new System.EventHandler(this.btn_bid_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 331);
            this.Controls.Add(this.btn_bid);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.lbl_loss);
            this.Controls.Add(this.lbl_bid);
            this.Controls.Add(this.lbl_win);
            this.Controls.Add(this.lbl_casino);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Casino Slot Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_casino;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Label lbl_win;
        private System.Windows.Forms.Label lbl_loss;
        private System.Windows.Forms.Label lbl_bid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_bid;
        private System.Windows.Forms.Timer timer1;
    }
}

