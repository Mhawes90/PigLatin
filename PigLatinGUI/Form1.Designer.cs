namespace PigLatinGUI
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.engTextBox = new System.Windows.Forms.TextBox();
            this.plTextBox = new System.Windows.Forms.TextBox();
            this.engToPlButton = new System.Windows.Forms.Button();
            this.plToEngButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(196, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(409, 59);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Pig Latin Translator";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // engTextBox
            // 
            this.engTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engTextBox.Location = new System.Drawing.Point(59, 178);
            this.engTextBox.Name = "engTextBox";
            this.engTextBox.Size = new System.Drawing.Size(196, 41);
            this.engTextBox.TabIndex = 1;
            this.engTextBox.Text = "English Word";
            this.engTextBox.TextChanged += new System.EventHandler(this.engTextBox_TextChanged);
            // 
            // plTextBox
            // 
            this.plTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plTextBox.Location = new System.Drawing.Point(485, 178);
            this.plTextBox.Name = "plTextBox";
            this.plTextBox.Size = new System.Drawing.Size(210, 41);
            this.plTextBox.TabIndex = 2;
            this.plTextBox.Text = "Pig Latin Word";
            // 
            // engToPlButton
            // 
            this.engToPlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engToPlButton.Location = new System.Drawing.Point(59, 296);
            this.engToPlButton.Name = "engToPlButton";
            this.engToPlButton.Size = new System.Drawing.Size(297, 63);
            this.engToPlButton.TabIndex = 3;
            this.engToPlButton.Text = "English to Pig Latin";
            this.engToPlButton.UseVisualStyleBackColor = true;
            this.engToPlButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // plToEngButton
            // 
            this.plToEngButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plToEngButton.Location = new System.Drawing.Point(390, 296);
            this.plToEngButton.Name = "plToEngButton";
            this.plToEngButton.Size = new System.Drawing.Size(305, 63);
            this.plToEngButton.TabIndex = 4;
            this.plToEngButton.Text = "Pig Latin to English";
            this.plToEngButton.UseVisualStyleBackColor = true;
            this.plToEngButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 589);
            this.Controls.Add(this.plToEngButton);
            this.Controls.Add(this.engToPlButton);
            this.Controls.Add(this.plTextBox);
            this.Controls.Add(this.engTextBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox engTextBox;
        private System.Windows.Forms.TextBox plTextBox;
        private System.Windows.Forms.Button engToPlButton;
        private System.Windows.Forms.Button plToEngButton;
    }
}

