
namespace mcqr_dialog
{
    partial class dialog_yesno
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NoButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(12, 76);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(123, 23);
            this.NoButton.TabIndex = 0;
            this.NoButton.Text = "だめ";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(141, 76);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(131, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "いいずぇ";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButtonClick);
            // 
            // Text
            // 
            this.Text.AutoSize = true;
            this.Text.Location = new System.Drawing.Point(35, 30);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(209, 15);
            this.Text.TabIndex = 2;
            this.Text.Text = "実行中ですが、終了してもよろしいですか？";
            // 
            // dialog_yesno
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.NoButton;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.NoButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 150);
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "dialog_yesno";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.dialog_yesno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Button OKButton;
        private new System.Windows.Forms.Label Text;
    }
}

