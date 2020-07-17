namespace Guess
{
    partial class Form2
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
            this.lblTextForm = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTextForm
            // 
            this.lblTextForm.AutoSize = true;
            this.lblTextForm.Location = new System.Drawing.Point(121, 49);
            this.lblTextForm.Name = "lblTextForm";
            this.lblTextForm.Size = new System.Drawing.Size(46, 17);
            this.lblTextForm.TabIndex = 0;
            this.lblTextForm.Text = "label1";
            // 
            // textNumber
            // 
            this.textNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textNumber.Location = new System.Drawing.Point(124, 97);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(226, 55);
            this.textNumber.TabIndex = 1;

            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCheck.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCheck.Location = new System.Drawing.Point(124, 186);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(226, 55);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "button1";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 279);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.lblTextForm);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextForm;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.Button btnCheck;
    }
}