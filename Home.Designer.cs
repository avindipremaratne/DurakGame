namespace DurakGame
{
    partial class welcomeForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDeckSize = new System.Windows.Forms.Label();
            this.btnDeckSize20 = new System.Windows.Forms.Button();
            this.btnDeckSize36 = new System.Windows.Forms.Button();
            this.btnDeckSize52 = new System.Windows.Forms.Button();
            this.lblTransfers = new System.Windows.Forms.Label();
            this.cbTransfers = new System.Windows.Forms.CheckBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblName.Location = new System.Drawing.Point(365, 170);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(545, 59);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "ENTER YOUR NAME";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(354, 264);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(566, 31);
            this.txtName.TabIndex = 1;
            // 
            // lblDeckSize
            // 
            this.lblDeckSize.AutoSize = true;
            this.lblDeckSize.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeckSize.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblDeckSize.Location = new System.Drawing.Point(481, 343);
            this.lblDeckSize.Name = "lblDeckSize";
            this.lblDeckSize.Size = new System.Drawing.Size(312, 59);
            this.lblDeckSize.TabIndex = 2;
            this.lblDeckSize.Text = "DECK SIZE";
            // 
            // btnDeckSize20
            // 
            this.btnDeckSize20.BackColor = System.Drawing.Color.White;
            this.btnDeckSize20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeckSize20.Location = new System.Drawing.Point(345, 421);
            this.btnDeckSize20.Name = "btnDeckSize20";
            this.btnDeckSize20.Size = new System.Drawing.Size(195, 116);
            this.btnDeckSize20.TabIndex = 3;
            this.btnDeckSize20.Text = "20";
            this.btnDeckSize20.UseVisualStyleBackColor = false;
            this.btnDeckSize20.Click += new System.EventHandler(this.btnDeckSize20_Click);
            // 
            // btnDeckSize36
            // 
            this.btnDeckSize36.BackColor = System.Drawing.Color.LightBlue;
            this.btnDeckSize36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeckSize36.Location = new System.Drawing.Point(538, 421);
            this.btnDeckSize36.Name = "btnDeckSize36";
            this.btnDeckSize36.Size = new System.Drawing.Size(195, 116);
            this.btnDeckSize36.TabIndex = 4;
            this.btnDeckSize36.Text = "36";
            this.btnDeckSize36.UseVisualStyleBackColor = false;
            this.btnDeckSize36.Click += new System.EventHandler(this.btnDeckSize36_Click);
            // 
            // btnDeckSize52
            // 
            this.btnDeckSize52.BackColor = System.Drawing.Color.White;
            this.btnDeckSize52.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeckSize52.Location = new System.Drawing.Point(732, 421);
            this.btnDeckSize52.Name = "btnDeckSize52";
            this.btnDeckSize52.Size = new System.Drawing.Size(195, 116);
            this.btnDeckSize52.TabIndex = 5;
            this.btnDeckSize52.Text = "52";
            this.btnDeckSize52.UseVisualStyleBackColor = false;
            this.btnDeckSize52.Click += new System.EventHandler(this.btnDeckSize52_Click);
            // 
            // lblTransfers
            // 
            this.lblTransfers.AutoSize = true;
            this.lblTransfers.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransfers.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblTransfers.Location = new System.Drawing.Point(449, 599);
            this.lblTransfers.Name = "lblTransfers";
            this.lblTransfers.Size = new System.Drawing.Size(344, 59);
            this.lblTransfers.TabIndex = 6;
            this.lblTransfers.Text = "TRANSFERS";
            // 
            // cbTransfers
            // 
            this.cbTransfers.AutoSize = true;
            this.cbTransfers.Location = new System.Drawing.Point(809, 616);
            this.cbTransfers.Name = "cbTransfers";
            this.cbTransfers.Size = new System.Drawing.Size(28, 27);
            this.cbTransfers.TabIndex = 7;
            this.cbTransfers.UseVisualStyleBackColor = true;
            this.cbTransfers.CheckedChanged += new System.EventHandler(this.cbTransfers_CheckedChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlay.Location = new System.Drawing.Point(414, 735);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(446, 72);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "PLAY GAME";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // welcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1248, 848);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.cbTransfers);
            this.Controls.Add(this.lblTransfers);
            this.Controls.Add(this.btnDeckSize52);
            this.Controls.Add(this.btnDeckSize36);
            this.Controls.Add(this.btnDeckSize20);
            this.Controls.Add(this.lblDeckSize);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "welcomeForm";
            this.Text = "Durak Game";
            this.Load += new System.EventHandler(this.welcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDeckSize;
        private System.Windows.Forms.Button btnDeckSize20;
        private System.Windows.Forms.Button btnDeckSize36;
        private System.Windows.Forms.Button btnDeckSize52;
        private System.Windows.Forms.Label lblTransfers;
        private System.Windows.Forms.CheckBox cbTransfers;
        private System.Windows.Forms.Button btnPlay;
    }
}

