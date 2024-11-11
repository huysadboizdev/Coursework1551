namespace Coursework1551
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.play = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.play.Location = new System.Drawing.Point(12, 259);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(160, 73);
            this.play.TabIndex = 0;
            this.play.Text = "Play Game";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.Color.Cyan;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(12, 66);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(710, 55);
            this.welcome.TabIndex = 1;
            this.welcome.Text = "Welcome to the Olympic Games";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Yellow;
            this.exit.Location = new System.Drawing.Point(547, 259);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(156, 73);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Coursework1551.Properties.Resources._1c5e88ae5848ce1f7a4bce03c2eb763b;
            this.ClientSize = new System.Drawing.Size(737, 650);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.play);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button exit;
    }
}

