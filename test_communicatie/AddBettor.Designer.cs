namespace test_communicatie
{
    partial class AddBettor
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
            this.newBettorTextBox = new System.Windows.Forms.TextBox();
            this.nameBettorLabel = new System.Windows.Forms.Label();
            this.newBettorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newBettorTextBox
            // 
            this.newBettorTextBox.Location = new System.Drawing.Point(136, 59);
            this.newBettorTextBox.Name = "newBettorTextBox";
            this.newBettorTextBox.Size = new System.Drawing.Size(181, 22);
            this.newBettorTextBox.TabIndex = 0;
            // 
            // nameBettorLabel
            // 
            this.nameBettorLabel.AutoSize = true;
            this.nameBettorLabel.Location = new System.Drawing.Point(9, 62);
            this.nameBettorLabel.Name = "nameBettorLabel";
            this.nameBettorLabel.Size = new System.Drawing.Size(121, 17);
            this.nameBettorLabel.TabIndex = 1;
            this.nameBettorLabel.Text = "Gebruikersnaam :";
            // 
            // newBettorButton
            // 
            this.newBettorButton.Location = new System.Drawing.Point(12, 171);
            this.newBettorButton.Name = "newBettorButton";
            this.newBettorButton.Size = new System.Drawing.Size(121, 51);
            this.newBettorButton.TabIndex = 2;
            this.newBettorButton.Text = "Registreer nieuwe gokker";
            this.newBettorButton.UseVisualStyleBackColor = true;
            this.newBettorButton.Click += new System.EventHandler(this.newBettorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Maak een nieuwe gokker aan zodat je kunt inzetten op de wedstrijden.\r\nJe gebruike" +
    "rsnaam mag niet langer zijn dan 10 karakters.";
            // 
            // AddBettor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 234);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newBettorButton);
            this.Controls.Add(this.nameBettorLabel);
            this.Controls.Add(this.newBettorTextBox);
            this.Name = "AddBettor";
            this.Text = "Nieuwe Gokker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddBettor_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newBettorTextBox;
        private System.Windows.Forms.Label nameBettorLabel;
        private System.Windows.Forms.Button newBettorButton;
        private System.Windows.Forms.Label label1;
    }
}