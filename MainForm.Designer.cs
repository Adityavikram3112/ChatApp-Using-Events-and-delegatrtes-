
namespace ChatApp__Using_Events_and_delegatrtes__
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
            this.ChatHeadCreaterButoon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChatHeadCreaterButoon
            // 
            this.ChatHeadCreaterButoon.Location = new System.Drawing.Point(55, 61);
            this.ChatHeadCreaterButoon.Name = "ChatHeadCreaterButoon";
            this.ChatHeadCreaterButoon.Size = new System.Drawing.Size(214, 75);
            this.ChatHeadCreaterButoon.TabIndex = 0;
            this.ChatHeadCreaterButoon.Text = "Create New ChatHead";
            this.ChatHeadCreaterButoon.UseVisualStyleBackColor = true;
            this.ChatHeadCreaterButoon.Click += new System.EventHandler(this.ChatHeadCreaterButoon_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 228);
            this.Controls.Add(this.ChatHeadCreaterButoon);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChatHeadCreaterButoon;
    }
}

