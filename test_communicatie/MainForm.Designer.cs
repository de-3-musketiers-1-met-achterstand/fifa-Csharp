namespace test_communicatie
{
    partial class MainForm
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
            this.showTeamsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBettorLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.walletLabel = new System.Windows.Forms.Label();
            this.machtesComboBox = new System.Windows.Forms.ComboBox();
            this.placeBetGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.betAmountTextBox = new System.Windows.Forms.TextBox();
            this.betButton = new System.Windows.Forms.Button();
            this.team2RadioButton = new System.Windows.Forms.RadioButton();
            this.team1RadioButton = new System.Windows.Forms.RadioButton();
            this.cheatTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cheatLabel = new System.Windows.Forms.Label();
            this.cheatButton2 = new System.Windows.Forms.Button();
            this.cheatButton1 = new System.Windows.Forms.Button();
            this.cheatButton = new System.Windows.Forms.Button();
            this.showBetListBox = new System.Windows.Forms.ListBox();
            this.checkResultButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.team1NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.team2NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.placeBetGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.team1NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team2NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // showTeamsListBox
            // 
            this.showTeamsListBox.FormattingEnabled = true;
            this.showTeamsListBox.ItemHeight = 16;
            this.showTeamsListBox.Location = new System.Drawing.Point(16, 90);
            this.showTeamsListBox.Name = "showTeamsListBox";
            this.showTeamsListBox.Size = new System.Drawing.Size(210, 164);
            this.showTeamsListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voetbal toernooi goklokaal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(590, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hier kunt u geld inzetten op verschillende teams.\r\nU ziet een overzicht van welke" +
    " teams er zijn en de wedstrijden die er gaan worden gespeeld.\r\n";
            // 
            // nameBettorLabel
            // 
            this.nameBettorLabel.AutoSize = true;
            this.nameBettorLabel.Location = new System.Drawing.Point(994, 9);
            this.nameBettorLabel.Name = "nameBettorLabel";
            this.nameBettorLabel.Size = new System.Drawing.Size(46, 17);
            this.nameBettorLabel.TabIndex = 3;
            this.nameBettorLabel.Text = "label3";
            this.nameBettorLabel.Click += new System.EventHandler(this.nameBettorLabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(845, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Je bent ingelogd als :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(862, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Uw portemonnee : €";
            // 
            // walletLabel
            // 
            this.walletLabel.AutoSize = true;
            this.walletLabel.Location = new System.Drawing.Point(994, 26);
            this.walletLabel.Name = "walletLabel";
            this.walletLabel.Size = new System.Drawing.Size(46, 17);
            this.walletLabel.TabIndex = 6;
            this.walletLabel.Text = "label5";
            // 
            // machtesComboBox
            // 
            this.machtesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.machtesComboBox.FormattingEnabled = true;
            this.machtesComboBox.Location = new System.Drawing.Point(60, 60);
            this.machtesComboBox.Name = "machtesComboBox";
            this.machtesComboBox.Size = new System.Drawing.Size(225, 24);
            this.machtesComboBox.TabIndex = 8;
            this.machtesComboBox.SelectedIndexChanged += new System.EventHandler(this.machtesComboBox_SelectedIndexChanged);
            // 
            // placeBetGroupBox
            // 
            this.placeBetGroupBox.Controls.Add(this.team2NumericUpDown);
            this.placeBetGroupBox.Controls.Add(this.team1NumericUpDown);
            this.placeBetGroupBox.Controls.Add(this.label7);
            this.placeBetGroupBox.Controls.Add(this.label6);
            this.placeBetGroupBox.Controls.Add(this.label5);
            this.placeBetGroupBox.Controls.Add(this.betAmountTextBox);
            this.placeBetGroupBox.Controls.Add(this.betButton);
            this.placeBetGroupBox.Controls.Add(this.team2RadioButton);
            this.placeBetGroupBox.Controls.Add(this.team1RadioButton);
            this.placeBetGroupBox.Controls.Add(this.machtesComboBox);
            this.placeBetGroupBox.Location = new System.Drawing.Point(232, 90);
            this.placeBetGroupBox.Name = "placeBetGroupBox";
            this.placeBetGroupBox.Size = new System.Drawing.Size(347, 348);
            this.placeBetGroupBox.TabIndex = 9;
            this.placeBetGroupBox.TabStop = false;
            this.placeBetGroupBox.Text = "Inzetten";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Selecteer hieronder een wedstrijd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bedrag: €";
            // 
            // betAmountTextBox
            // 
            this.betAmountTextBox.Location = new System.Drawing.Point(112, 223);
            this.betAmountTextBox.Name = "betAmountTextBox";
            this.betAmountTextBox.Size = new System.Drawing.Size(108, 22);
            this.betAmountTextBox.TabIndex = 12;
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(112, 276);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(108, 54);
            this.betButton.TabIndex = 11;
            this.betButton.Text = "Plaats gok";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // team2RadioButton
            // 
            this.team2RadioButton.AutoSize = true;
            this.team2RadioButton.Location = new System.Drawing.Point(212, 118);
            this.team2RadioButton.Name = "team2RadioButton";
            this.team2RadioButton.Size = new System.Drawing.Size(77, 21);
            this.team2RadioButton.TabIndex = 10;
            this.team2RadioButton.TabStop = true;
            this.team2RadioButton.Text = "Team 2";
            this.team2RadioButton.UseVisualStyleBackColor = true;
            // 
            // team1RadioButton
            // 
            this.team1RadioButton.AutoSize = true;
            this.team1RadioButton.Location = new System.Drawing.Point(28, 118);
            this.team1RadioButton.Name = "team1RadioButton";
            this.team1RadioButton.Size = new System.Drawing.Size(77, 21);
            this.team1RadioButton.TabIndex = 9;
            this.team1RadioButton.TabStop = true;
            this.team1RadioButton.Text = "Team 1";
            this.team1RadioButton.UseVisualStyleBackColor = true;
            // 
            // cheatTextBox
            // 
            this.cheatTextBox.Location = new System.Drawing.Point(6, 21);
            this.cheatTextBox.Name = "cheatTextBox";
            this.cheatTextBox.Size = new System.Drawing.Size(198, 22);
            this.cheatTextBox.TabIndex = 10;
            this.cheatTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cheatTextBox_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cheatLabel);
            this.groupBox1.Controls.Add(this.cheatButton2);
            this.groupBox1.Controls.Add(this.cheatButton1);
            this.groupBox1.Controls.Add(this.cheatButton);
            this.groupBox1.Controls.Add(this.cheatTextBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 164);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cheats";
            // 
            // cheatLabel
            // 
            this.cheatLabel.AutoSize = true;
            this.cheatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheatLabel.Location = new System.Drawing.Point(23, 144);
            this.cheatLabel.Name = "cheatLabel";
            this.cheatLabel.Size = new System.Drawing.Size(0, 17);
            this.cheatLabel.TabIndex = 14;
            // 
            // cheatButton2
            // 
            this.cheatButton2.Enabled = false;
            this.cheatButton2.Location = new System.Drawing.Point(6, 108);
            this.cheatButton2.Name = "cheatButton2";
            this.cheatButton2.Size = new System.Drawing.Size(198, 23);
            this.cheatButton2.TabIndex = 13;
            this.cheatButton2.Text = "+1000";
            this.cheatButton2.UseVisualStyleBackColor = true;
            this.cheatButton2.Click += new System.EventHandler(this.cheatButton2_Click);
            // 
            // cheatButton1
            // 
            this.cheatButton1.Enabled = false;
            this.cheatButton1.Location = new System.Drawing.Point(129, 57);
            this.cheatButton1.Name = "cheatButton1";
            this.cheatButton1.Size = new System.Drawing.Size(75, 23);
            this.cheatButton1.TabIndex = 12;
            this.cheatButton1.Text = "+100";
            this.cheatButton1.UseVisualStyleBackColor = true;
            this.cheatButton1.Click += new System.EventHandler(this.cheatButton1_Click);
            // 
            // cheatButton
            // 
            this.cheatButton.Enabled = false;
            this.cheatButton.Location = new System.Drawing.Point(6, 57);
            this.cheatButton.Name = "cheatButton";
            this.cheatButton.Size = new System.Drawing.Size(75, 23);
            this.cheatButton.TabIndex = 11;
            this.cheatButton.Text = "+10";
            this.cheatButton.UseVisualStyleBackColor = true;
            this.cheatButton.Click += new System.EventHandler(this.cheatButton_Click);
            // 
            // showBetListBox
            // 
            this.showBetListBox.FormattingEnabled = true;
            this.showBetListBox.ItemHeight = 16;
            this.showBetListBox.Location = new System.Drawing.Point(585, 90);
            this.showBetListBox.Name = "showBetListBox";
            this.showBetListBox.Size = new System.Drawing.Size(455, 292);
            this.showBetListBox.TabIndex = 12;
            // 
            // checkResultButton
            // 
            this.checkResultButton.Location = new System.Drawing.Point(585, 395);
            this.checkResultButton.Name = "checkResultButton";
            this.checkResultButton.Size = new System.Drawing.Size(455, 51);
            this.checkResultButton.TabIndex = 13;
            this.checkResultButton.Text = "Uitslagen binnehalen";
            this.checkResultButton.UseVisualStyleBackColor = true;
            this.checkResultButton.Click += new System.EventHandler(this.checkResultButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Uitslag :";
            // 
            // team1NumericUpDown
            // 
            this.team1NumericUpDown.Location = new System.Drawing.Point(102, 171);
            this.team1NumericUpDown.Name = "team1NumericUpDown";
            this.team1NumericUpDown.Size = new System.Drawing.Size(44, 22);
            this.team1NumericUpDown.TabIndex = 14;
            // 
            // team2NumericUpDown
            // 
            this.team2NumericUpDown.Location = new System.Drawing.Point(185, 171);
            this.team2NumericUpDown.Name = "team2NumericUpDown";
            this.team2NumericUpDown.Size = new System.Drawing.Size(44, 22);
            this.team2NumericUpDown.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 450);
            this.Controls.Add(this.checkResultButton);
            this.Controls.Add(this.showBetListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.placeBetGroupBox);
            this.Controls.Add(this.walletLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameBettorLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showTeamsListBox);
            this.Name = "MainForm";
            this.Text = "Toernooi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.placeBetGroupBox.ResumeLayout(false);
            this.placeBetGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.team1NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.team2NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox showTeamsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameBettorLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label walletLabel;
        private System.Windows.Forms.ComboBox machtesComboBox;
        private System.Windows.Forms.GroupBox placeBetGroupBox;
        private System.Windows.Forms.TextBox betAmountTextBox;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.RadioButton team2RadioButton;
        private System.Windows.Forms.RadioButton team1RadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cheatTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cheatButton2;
        private System.Windows.Forms.Button cheatButton1;
        private System.Windows.Forms.Button cheatButton;
        private System.Windows.Forms.Label cheatLabel;
        private System.Windows.Forms.ListBox showBetListBox;
        private System.Windows.Forms.Button checkResultButton;
        private System.Windows.Forms.NumericUpDown team2NumericUpDown;
        private System.Windows.Forms.NumericUpDown team1NumericUpDown;
        private System.Windows.Forms.Label label7;
    }
}

