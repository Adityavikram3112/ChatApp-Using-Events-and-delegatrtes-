
namespace ChatApp__Using_Events_and_delegatrtes__
{
    partial class ChatForm
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
            this.SendButton = new System.Windows.Forms.Button();
            this.DisplayBox = new System.Windows.Forms.ListBox();
            this.SendTextBox = new System.Windows.Forms.TextBox();
            this.TextRecive = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(275, 174);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "SEND";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // DisplayBox
            // 
            this.DisplayBox.FormattingEnabled = true;
            this.DisplayBox.Location = new System.Drawing.Point(12, 12);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.Size = new System.Drawing.Size(338, 134);
            this.DisplayBox.TabIndex = 1;
            // 
            // SendTextBox
            // 
            this.SendTextBox.Location = new System.Drawing.Point(12, 174);
            this.SendTextBox.Name = "SendTextBox";
            this.SendTextBox.Size = new System.Drawing.Size(238, 20);
            this.SendTextBox.TabIndex = 2;
            // 
            // TextRecive
            // 
            this.TextRecive.Location = new System.Drawing.Point(12, 157);
            this.TextRecive.Multiline = true;
            this.TextRecive.Name = "TextRecive";
            this.TextRecive.Size = new System.Drawing.Size(40, 11);
            this.TextRecive.TabIndex = 3;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 246);
            this.Controls.Add(this.TextRecive);
            this.Controls.Add(this.SendTextBox);
            this.Controls.Add(this.DisplayBox);
            this.Controls.Add(this.SendButton);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.ListBox DisplayBox;
        private System.Windows.Forms.TextBox SendTextBox;
        private System.Windows.Forms.TextBox TextRecive;
    }
}