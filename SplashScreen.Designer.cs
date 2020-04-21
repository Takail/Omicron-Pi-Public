namespace Omicron_Pi
{
    partial class SplashScreen
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
            this.openExistingConfigButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // openExistingConfigButton
            // 
            this.openExistingConfigButton.Location = new System.Drawing.Point(12, 12);
            this.openExistingConfigButton.Name = "openExistingConfigButton";
            this.openExistingConfigButton.Size = new System.Drawing.Size(176, 27);
            this.openExistingConfigButton.TabIndex = 1;
            this.openExistingConfigButton.Text = "Open Existing Config";
            this.openExistingConfigButton.UseVisualStyleBackColor = true;
            this.openExistingConfigButton.Click += new System.EventHandler(this.openExistingConfigButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Create New Config";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "config_remoteadmin.txt";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 84);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.openExistingConfigButton);
            this.Name = "SplashScreen";
            this.Text = "SplashScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SplashScreen_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button openExistingConfigButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}