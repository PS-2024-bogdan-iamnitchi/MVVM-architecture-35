namespace MVVM_architecture_35.View
{
    partial class GameGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.oponentLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudLevel = new System.Windows.Forms.NumericUpDown();
            this.oponentMovesPictureBox = new System.Windows.Forms.PictureBox();
            this.playerMovesPictureBox = new System.Windows.Forms.PictureBox();
            this.nudOponentScore = new System.Windows.Forms.NumericUpDown();
            this.nudPlayerScore = new System.Windows.Forms.NumericUpDown();
            this.restartGameButton = new System.Windows.Forms.Button();
            this.playPauseButton = new System.Windows.Forms.Button();
            this.leaveGameButton = new System.Windows.Forms.Button();
            this.timerCPU = new System.Windows.Forms.Timer(this.components);
            this.buttonsTableLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.nudLoggedInPlayerScore = new System.Windows.Forms.NumericUpDown();
            this.loggedInPlayerScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oponentMovesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerMovesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOponentScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoggedInPlayerScore)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(252, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arrow Puzzle Game";
            // 
            // playerLabel
            // 
            this.playerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.playerLabel.Location = new System.Drawing.Point(753, 200);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(176, 32);
            this.playerLabel.TabIndex = 25;
            this.playerLabel.Text = "Your moves:";
            // 
            // oponentLabel
            // 
            this.oponentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oponentLabel.AutoSize = true;
            this.oponentLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oponentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.oponentLabel.Location = new System.Drawing.Point(509, 200);
            this.oponentLabel.Name = "oponentLabel";
            this.oponentLabel.Size = new System.Drawing.Size(227, 32);
            this.oponentLabel.TabIndex = 26;
            this.oponentLabel.Text = "Oponent moves:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label4.Location = new System.Drawing.Point(360, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 43);
            this.label4.TabIndex = 29;
            this.label4.Text = "Level: ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label6.Location = new System.Drawing.Point(509, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 32);
            this.label6.TabIndex = 32;
            this.label6.Text = "Oponent score:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label7.Location = new System.Drawing.Point(764, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 32);
            this.label7.TabIndex = 31;
            this.label7.Text = "Your score:";
            // 
            // nudLevel
            // 
            this.nudLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudLevel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.nudLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.nudLevel.Location = new System.Drawing.Point(502, 92);
            this.nudLevel.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.ReadOnly = true;
            this.nudLevel.Size = new System.Drawing.Size(125, 38);
            this.nudLevel.TabIndex = 40;
            this.nudLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudLevel.UseWaitCursor = true;
            this.nudLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            //this.nudLevel.ValueChanged += new System.EventHandler(this.nudLevel_ValueChanged);
            // 
            // oponentMovesPictureBox
            // 
            this.oponentMovesPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.oponentMovesPictureBox.Image = global::MVVM_architecture_35.Properties.Resources.red_level1;
            this.oponentMovesPictureBox.Location = new System.Drawing.Point(565, 251);
            this.oponentMovesPictureBox.Name = "oponentMovesPictureBox";
            this.oponentMovesPictureBox.Size = new System.Drawing.Size(128, 126);
            this.oponentMovesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.oponentMovesPictureBox.TabIndex = 23;
            this.oponentMovesPictureBox.TabStop = false;
            // 
            // playerMovesPictureBox
            // 
            this.playerMovesPictureBox.Image = global::MVVM_architecture_35.Properties.Resources.green_level1;
            this.playerMovesPictureBox.Location = new System.Drawing.Point(778, 251);
            this.playerMovesPictureBox.Name = "playerMovesPictureBox";
            this.playerMovesPictureBox.Size = new System.Drawing.Size(128, 125);
            this.playerMovesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playerMovesPictureBox.TabIndex = 36;
            this.playerMovesPictureBox.TabStop = false;
            // 
            // nudOponentScore
            // 
            this.nudOponentScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudOponentScore.Cursor = System.Windows.Forms.Cursors.No;
            this.nudOponentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudOponentScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.nudOponentScore.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudOponentScore.Location = new System.Drawing.Point(565, 459);
            this.nudOponentScore.Name = "nudOponentScore";
            this.nudOponentScore.ReadOnly = true;
            this.nudOponentScore.Size = new System.Drawing.Size(128, 38);
            this.nudOponentScore.TabIndex = 37;
            this.nudOponentScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudPlayerScore
            // 
            this.nudPlayerScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudPlayerScore.Cursor = System.Windows.Forms.Cursors.No;
            this.nudPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPlayerScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.nudPlayerScore.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudPlayerScore.Location = new System.Drawing.Point(778, 459);
            this.nudPlayerScore.Name = "nudPlayerScore";
            this.nudPlayerScore.ReadOnly = true;
            this.nudPlayerScore.Size = new System.Drawing.Size(128, 38);
            this.nudPlayerScore.TabIndex = 38;
            this.nudPlayerScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // restartGameButton
            // 
            this.restartGameButton.BackgroundImage = global::MVVM_architecture_35.Properties.Resources.update;
            this.restartGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.restartGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartGameButton.FlatAppearance.BorderSize = 0;
            this.restartGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartGameButton.Location = new System.Drawing.Point(701, 532);
            this.restartGameButton.Name = "restartGameButton";
            this.restartGameButton.Size = new System.Drawing.Size(70, 70);
            this.restartGameButton.TabIndex = 39;
            this.restartGameButton.UseVisualStyleBackColor = true;
            //this.restartGameButton.Click += new System.EventHandler(this.restartGameButton_Click);
            // 
            // playPauseButton
            // 
            this.playPauseButton.BackgroundImage = global::MVVM_architecture_35.Properties.Resources.start;
            this.playPauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playPauseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playPauseButton.FlatAppearance.BorderSize = 0;
            this.playPauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playPauseButton.Location = new System.Drawing.Point(838, 532);
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(70, 70);
            this.playPauseButton.TabIndex = 35;
            this.playPauseButton.UseVisualStyleBackColor = true;
            //this.playPauseButton.Click += new System.EventHandler(this.playGameButton_Click);
            // 
            // leaveGameButton
            // 
            this.leaveGameButton.BackgroundImage = global::MVVM_architecture_35.Properties.Resources.delete;
            this.leaveGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leaveGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leaveGameButton.FlatAppearance.BorderSize = 0;
            this.leaveGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaveGameButton.Location = new System.Drawing.Point(562, 532);
            this.leaveGameButton.Name = "leaveGameButton";
            this.leaveGameButton.Size = new System.Drawing.Size(70, 70);
            this.leaveGameButton.TabIndex = 41;
            this.leaveGameButton.UseVisualStyleBackColor = true;
            //this.leaveGameButton.Click += new System.EventHandler(this.leaveGameButton_Click);
            // 
            // timerCPU
            // 
            this.timerCPU.Interval = 1000;
            //this.timerCPU.Tick += new System.EventHandler(this.CPUMove);
            // 
            // buttonsTableLayout
            // 
            this.buttonsTableLayout.Location = new System.Drawing.Point(55, 200);
            this.buttonsTableLayout.Name = "buttonsTableLayout";
            this.buttonsTableLayout.Size = new System.Drawing.Size(441, 405);
            this.buttonsTableLayout.TabIndex = 42;
            // 
            // nudLoggedInPlayerScore
            // 
            this.nudLoggedInPlayerScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudLoggedInPlayerScore.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.nudLoggedInPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLoggedInPlayerScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.nudLoggedInPlayerScore.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudLoggedInPlayerScore.Location = new System.Drawing.Point(57, 79);
            this.nudLoggedInPlayerScore.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLoggedInPlayerScore.Name = "nudLoggedInPlayerScore";
            this.nudLoggedInPlayerScore.ReadOnly = true;
            this.nudLoggedInPlayerScore.Size = new System.Drawing.Size(125, 35);
            this.nudLoggedInPlayerScore.TabIndex = 44;
            this.nudLoggedInPlayerScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudLoggedInPlayerScore.UseWaitCursor = true;
            // 
            // loggedInPlayerScoreLabel
            // 
            this.loggedInPlayerScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loggedInPlayerScoreLabel.AutoSize = true;
            this.loggedInPlayerScoreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedInPlayerScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.loggedInPlayerScoreLabel.Location = new System.Drawing.Point(24, 39);
            this.loggedInPlayerScoreLabel.Name = "loggedInPlayerScoreLabel";
            this.loggedInPlayerScoreLabel.Size = new System.Drawing.Size(189, 32);
            this.loggedInPlayerScoreLabel.TabIndex = 43;
            this.loggedInPlayerScoreLabel.Text = "Saved Score:";
            // 
            // GameGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.nudLoggedInPlayerScore);
            this.Controls.Add(this.loggedInPlayerScoreLabel);
            this.Controls.Add(this.buttonsTableLayout);
            this.Controls.Add(this.leaveGameButton);
            this.Controls.Add(this.playPauseButton);
            this.Controls.Add(this.restartGameButton);
            this.Controls.Add(this.nudPlayerScore);
            this.Controls.Add(this.nudOponentScore);
            this.Controls.Add(this.playerMovesPictureBox);
            this.Controls.Add(this.nudLevel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oponentLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.oponentMovesPictureBox);
            this.Controls.Add(this.label1);
            this.Name = "GameGUI";
            this.Text = "GameGUI";
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oponentMovesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerMovesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOponentScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoggedInPlayerScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox oponentMovesPictureBox;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label oponentLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudLevel;
        private System.Windows.Forms.PictureBox playerMovesPictureBox;
        private System.Windows.Forms.NumericUpDown nudOponentScore;
        private System.Windows.Forms.NumericUpDown nudPlayerScore;
        private System.Windows.Forms.Button restartGameButton;
        private System.Windows.Forms.Button playPauseButton;
        private System.Windows.Forms.Button leaveGameButton;
        private System.Windows.Forms.Timer timerCPU;
        private System.Windows.Forms.FlowLayoutPanel buttonsTableLayout;
        private System.Windows.Forms.NumericUpDown nudLoggedInPlayerScore;
        private System.Windows.Forms.Label loggedInPlayerScoreLabel;
    }
}