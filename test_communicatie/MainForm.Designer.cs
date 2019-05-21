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
            this.SuspendLayout();
            // 
            // showTeamsListBox
            // 
            this.showTeamsListBox.FormattingEnabled = true;
            this.showTeamsListBox.ItemHeight = 16;
            this.showTeamsListBox.Location = new System.Drawing.Point(16, 90);
            this.showTeamsListBox.Name = "showTeamsListBox";
            this.showTeamsListBox.Size = new System.Drawing.Size(189, 164);
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
            this.nameBettorLabel.Location = new System.Drawing.Point(706, 12);
            this.nameBettorLabel.Name = "nameBettorLabel";
            this.nameBettorLabel.Size = new System.Drawing.Size(46, 17);
            this.nameBettorLabel.TabIndex = 3;
            this.nameBettorLabel.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Je bent ingelogd als :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Uw portemonnee :";
            // 
            // walletLabel
            // 
            this.walletLabel.AutoSize = true;
            this.walletLabel.Location = new System.Drawing.Point(706, 29);
            this.walletLabel.Name = "walletLabel";
            this.walletLabel.Size = new System.Drawing.Size(46, 17);
            this.walletLabel.TabIndex = 6;
            this.walletLabel.Text = "label5";
            // 
            // machtesComboBox
            // 
            this.machtesComboBox.FormattingEnabled = true;
            this.machtesComboBox.Location = new System.Drawing.Point(266, 90);
            this.machtesComboBox.Name = "machtesComboBox";
            this.machtesComboBox.Size = new System.Drawing.Size(225, 24);
            this.machtesComboBox.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.machtesComboBox);
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
    }
}

