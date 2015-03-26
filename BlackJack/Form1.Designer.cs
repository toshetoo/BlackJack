namespace BlackJack
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
            this.btnHold = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.lblDealer = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPot = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblDealerScore = new System.Windows.Forms.Label();
            this.lblMoneyValue = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.btnBetTen = new System.Windows.Forms.Button();
            this.btnBetFifty = new System.Windows.Forms.Button();
            this.lblPlayerCards = new System.Windows.Forms.Label();
            this.lblDealerCards = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHold
            // 
            this.btnHold.Location = new System.Drawing.Point(197, 227);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(75, 23);
            this.btnHold.TabIndex = 0;
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(197, 198);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Location = new System.Drawing.Point(12, 9);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(38, 13);
            this.lblDealer.TabIndex = 2;
            this.lblDealer.Text = "Dealer";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(12, 160);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(36, 13);
            this.lblPlayer.TabIndex = 3;
            this.lblPlayer.Text = "Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pot";
            // 
            // lblPot
            // 
            this.lblPot.AutoSize = true;
            this.lblPot.Location = new System.Drawing.Point(223, 25);
            this.lblPot.Name = "lblPot";
            this.lblPot.Size = new System.Drawing.Size(13, 13);
            this.lblPot.TabIndex = 5;
            this.lblPot.Text = "0";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(54, 160);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerScore.TabIndex = 6;
            this.lblPlayerScore.Text = "label2";
            // 
            // lblDealerScore
            // 
            this.lblDealerScore.AutoSize = true;
            this.lblDealerScore.Location = new System.Drawing.Point(56, 9);
            this.lblDealerScore.Name = "lblDealerScore";
            this.lblDealerScore.Size = new System.Drawing.Size(35, 13);
            this.lblDealerScore.TabIndex = 7;
            this.lblDealerScore.Text = "label2";
            // 
            // lblMoneyValue
            // 
            this.lblMoneyValue.AutoSize = true;
            this.lblMoneyValue.Location = new System.Drawing.Point(243, 97);
            this.lblMoneyValue.Name = "lblMoneyValue";
            this.lblMoneyValue.Size = new System.Drawing.Size(29, 13);
            this.lblMoneyValue.TabIndex = 9;
            this.lblMoneyValue.Text = "label";
            this.lblMoneyValue.Click += new System.EventHandler(this.lblMoneyValue_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(198, 97);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(39, 13);
            this.lblMoney.TabIndex = 8;
            this.lblMoney.Text = "Money";
            // 
            // btnBetTen
            // 
            this.btnBetTen.Location = new System.Drawing.Point(197, 123);
            this.btnBetTen.Name = "btnBetTen";
            this.btnBetTen.Size = new System.Drawing.Size(75, 23);
            this.btnBetTen.TabIndex = 10;
            this.btnBetTen.Text = "Bet 10";
            this.btnBetTen.UseVisualStyleBackColor = true;
            this.btnBetTen.Click += new System.EventHandler(this.btnBetTen_Click);
            // 
            // btnBetFifty
            // 
            this.btnBetFifty.Location = new System.Drawing.Point(197, 152);
            this.btnBetFifty.Name = "btnBetFifty";
            this.btnBetFifty.Size = new System.Drawing.Size(75, 23);
            this.btnBetFifty.TabIndex = 11;
            this.btnBetFifty.Text = "Bet 50";
            this.btnBetFifty.UseVisualStyleBackColor = true;
            this.btnBetFifty.Click += new System.EventHandler(this.btnBetFifty_Click);
            // 
            // lblPlayerCards
            // 
            this.lblPlayerCards.AutoSize = true;
            this.lblPlayerCards.Location = new System.Drawing.Point(12, 198);
            this.lblPlayerCards.Name = "lblPlayerCards";
            this.lblPlayerCards.Size = new System.Drawing.Size(0, 13);
            this.lblPlayerCards.TabIndex = 12;
            // 
            // lblDealerCards
            // 
            this.lblDealerCards.AutoSize = true;
            this.lblDealerCards.Location = new System.Drawing.Point(12, 48);
            this.lblDealerCards.Name = "lblDealerCards";
            this.lblDealerCards.Size = new System.Drawing.Size(0, 13);
            this.lblDealerCards.TabIndex = 13;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(197, 59);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblDealerCards);
            this.Controls.Add(this.lblPlayerCards);
            this.Controls.Add(this.btnBetFifty);
            this.Controls.Add(this.btnBetTen);
            this.Controls.Add(this.lblMoneyValue);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblDealerScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblPot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnHold);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPot;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblDealerScore;
        private System.Windows.Forms.Label lblMoneyValue;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Button btnBetTen;
        private System.Windows.Forms.Button btnBetFifty;
        private System.Windows.Forms.Label lblPlayerCards;
        private System.Windows.Forms.Label lblDealerCards;
        private System.Windows.Forms.Button btnStart;
    }
}

