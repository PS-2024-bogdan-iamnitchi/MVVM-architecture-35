namespace MVVM_architecture_35.View
{
    partial class HomeGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.playGameButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(174, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "This is Arrow Puzzle Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label2.Location = new System.Drawing.Point(111, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(779, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "- You have to place arrows strategically on the grid to fill it without having tw" +
    "o arrows";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label3.Location = new System.Drawing.Point(115, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(772, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = " of the same color pointing in the same direction along any row, column, or diago" +
    "nal.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label6.Location = new System.Drawing.Point(122, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(461, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "pattern that adheres to the rule mentioned above.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label7.Location = new System.Drawing.Point(110, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(779, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "- Each player takes turns placing arrows on empty cells of the grid aiming to cre" +
    "ate a";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label8.Location = new System.Drawing.Point(120, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "opponent winning";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label9.Location = new System.Drawing.Point(108, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(774, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "- The game ends when one player can no longer make a legal move, resulting in the" +
    "ir";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.exitButton.Location = new System.Drawing.Point(187, 557);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(180, 55);
            this.exitButton.TabIndex = 21;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            //this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // playGameButton
            // 
            this.playGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playGameButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playGameButton.FlatAppearance.BorderSize = 0;
            this.playGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playGameButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playGameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.playGameButton.Location = new System.Drawing.Point(617, 557);
            this.playGameButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.playGameButton.Name = "playGameButton";
            this.playGameButton.Size = new System.Drawing.Size(180, 55);
            this.playGameButton.TabIndex = 19;
            this.playGameButton.Text = "PLAY GAME";
            this.playGameButton.UseVisualStyleBackColor = false;
            //this.playGameButton.Click += new System.EventHandler(this.playGameButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adminButton.FlatAppearance.BorderSize = 0;
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.adminButton.Location = new System.Drawing.Point(403, 557);
            this.adminButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(180, 55);
            this.adminButton.TabIndex = 20;
            this.adminButton.Text = "ADMIN";
            this.adminButton.UseVisualStyleBackColor = false;
            //this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MVVM_architecture_35.Properties.Resources.demo;
            this.pictureBox1.Location = new System.Drawing.Point(354, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // HomeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playGameButton);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HomeGUI";
            this.Text = "HomeGUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button playGameButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}