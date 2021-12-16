namespace DurakGame
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            DurakLib.Card card1 = new DurakLib.Card();
            this.flpPlayerHand = new System.Windows.Forms.FlowLayoutPanel();
            this.flpAIHand = new System.Windows.Forms.FlowLayoutPanel();
            this.pbDeckDummyCard1 = new System.Windows.Forms.PictureBox();
            this.pbDeckDummyCard3 = new System.Windows.Forms.PictureBox();
            this.pbDeckDummyCard2 = new System.Windows.Forms.PictureBox();
            this.lblAttackStatus = new System.Windows.Forms.Label();
            this.flpBout = new System.Windows.Forms.FlowLayoutPanel();
            this.cbTrump = new CardBox.CardPictureBox();
            this.lblDeckSize = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeckDummyCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeckDummyCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeckDummyCard2)).BeginInit();
            this.SuspendLayout();
            // 
            // flpPlayerHand
            // 
            this.flpPlayerHand.BackColor = System.Drawing.Color.DarkBlue;
            this.flpPlayerHand.Location = new System.Drawing.Point(299, 734);
            this.flpPlayerHand.Name = "flpPlayerHand";
            this.flpPlayerHand.Size = new System.Drawing.Size(954, 276);
            this.flpPlayerHand.TabIndex = 0;
            // 
            // flpAIHand
            // 
            this.flpAIHand.BackColor = System.Drawing.Color.DarkBlue;
            this.flpAIHand.Location = new System.Drawing.Point(305, 5);
            this.flpAIHand.Name = "flpAIHand";
            this.flpAIHand.Size = new System.Drawing.Size(954, 276);
            this.flpAIHand.TabIndex = 1;
            // 
            // pbDeckDummyCard1
            // 
            this.pbDeckDummyCard1.Image = ((System.Drawing.Image)(resources.GetObject("pbDeckDummyCard1.Image")));
            this.pbDeckDummyCard1.Location = new System.Drawing.Point(29, 371);
            this.pbDeckDummyCard1.Name = "pbDeckDummyCard1";
            this.pbDeckDummyCard1.Size = new System.Drawing.Size(150, 232);
            this.pbDeckDummyCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeckDummyCard1.TabIndex = 2;
            this.pbDeckDummyCard1.TabStop = false;
            // 
            // pbDeckDummyCard3
            // 
            this.pbDeckDummyCard3.Image = ((System.Drawing.Image)(resources.GetObject("pbDeckDummyCard3.Image")));
            this.pbDeckDummyCard3.Location = new System.Drawing.Point(27, 377);
            this.pbDeckDummyCard3.Name = "pbDeckDummyCard3";
            this.pbDeckDummyCard3.Size = new System.Drawing.Size(150, 232);
            this.pbDeckDummyCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeckDummyCard3.TabIndex = 4;
            this.pbDeckDummyCard3.TabStop = false;
            // 
            // pbDeckDummyCard2
            // 
            this.pbDeckDummyCard2.Image = global::DurakGame.Properties.Resources.Back;
            this.pbDeckDummyCard2.Location = new System.Drawing.Point(26, 384);
            this.pbDeckDummyCard2.Name = "pbDeckDummyCard2";
            this.pbDeckDummyCard2.Size = new System.Drawing.Size(150, 232);
            this.pbDeckDummyCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeckDummyCard2.TabIndex = 5;
            this.pbDeckDummyCard2.TabStop = false;
            // 
            // lblAttackStatus
            // 
            this.lblAttackStatus.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblAttackStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttackStatus.Location = new System.Drawing.Point(299, 661);
            this.lblAttackStatus.Name = "lblAttackStatus";
            this.lblAttackStatus.Size = new System.Drawing.Size(954, 70);
            this.lblAttackStatus.TabIndex = 6;
            this.lblAttackStatus.Text = "You are the defender";
            this.lblAttackStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpBout
            // 
            this.flpBout.BackColor = System.Drawing.Color.Transparent;
            this.flpBout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpBout.Location = new System.Drawing.Point(305, 287);
            this.flpBout.Name = "flpBout";
            this.flpBout.Size = new System.Drawing.Size(954, 364);
            this.flpBout.TabIndex = 2;
            // 
            // cbTrump
            // 
            card1.FaceUp = false;
            card1.Rank = DurakLib.Rank.Ace;
            card1.Suit = DurakLib.Suit.Clubs;
            this.cbTrump.Card = card1;
            this.cbTrump.CardOrientation = System.Windows.Forms.Orientation.Vertical;
            this.cbTrump.FaceUp = false;
            this.cbTrump.Location = new System.Drawing.Point(26, 426);
            this.cbTrump.Name = "cbTrump";
            this.cbTrump.Rank = DurakLib.Rank.Ace;
            this.cbTrump.Size = new System.Drawing.Size(150, 232);
            this.cbTrump.Suit = DurakLib.Suit.Clubs;
            this.cbTrump.TabIndex = 7;
            // 
            // lblDeckSize
            // 
            this.lblDeckSize.AutoSize = true;
            this.lblDeckSize.BackColor = System.Drawing.Color.Transparent;
            this.lblDeckSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeckSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDeckSize.Location = new System.Drawing.Point(73, 314);
            this.lblDeckSize.Name = "lblDeckSize";
            this.lblDeckSize.Size = new System.Drawing.Size(62, 42);
            this.lblDeckSize.TabIndex = 8;
            this.lblDeckSize.Text = "36";
            // 
            // btnAction
            // 
            this.btnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold);
            this.btnAction.Location = new System.Drawing.Point(1357, 398);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(180, 180);
            this.btnAction.TabIndex = 9;
            this.btnAction.Text = "PASS";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1351, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "AI Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1338, 865);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "[Player Name]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(1315, 805);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "<SHOW AVATAR>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(1298, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "<SHOW AVATAR>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1586, 1012);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.lblDeckSize);
            this.Controls.Add(this.flpBout);
            this.Controls.Add(this.lblAttackStatus);
            this.Controls.Add(this.pbDeckDummyCard2);
            this.Controls.Add(this.pbDeckDummyCard3);
            this.Controls.Add(this.pbDeckDummyCard1);
            this.Controls.Add(this.flpAIHand);
            this.Controls.Add(this.flpPlayerHand);
            this.Controls.Add(this.cbTrump);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDeckDummyCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeckDummyCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeckDummyCard2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPlayerHand;
        private System.Windows.Forms.FlowLayoutPanel flpAIHand;
        private System.Windows.Forms.PictureBox pbDeckDummyCard1;
        private System.Windows.Forms.PictureBox pbDeckDummyCard3;
        private System.Windows.Forms.PictureBox pbDeckDummyCard2;
        private System.Windows.Forms.Label lblAttackStatus;
        private System.Windows.Forms.FlowLayoutPanel flpBout;
        private CardBox.CardPictureBox cbTrump;
        private System.Windows.Forms.Label lblDeckSize;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}