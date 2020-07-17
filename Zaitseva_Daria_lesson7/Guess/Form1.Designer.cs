namespace Guess
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMainText = new System.Windows.Forms.Label();
            this.lblAttemptNumberText = new System.Windows.Forms.Label();
            this.lblAttemptNumber = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMainText
            // 
            this.lblMainText.AutoSize = true;
            this.lblMainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMainText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMainText.Location = new System.Drawing.Point(134, 71);
            this.lblMainText.Name = "lblMainText";
            this.lblMainText.Size = new System.Drawing.Size(59, 20);
            this.lblMainText.TabIndex = 0;
            this.lblMainText.Text = "label1";

            // 
            // lblAttemptNumberText
            // 
            this.lblAttemptNumberText.AutoSize = true;
            this.lblAttemptNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAttemptNumberText.Location = new System.Drawing.Point(238, 191);
            this.lblAttemptNumberText.Name = "lblAttemptNumberText";
            this.lblAttemptNumberText.Size = new System.Drawing.Size(53, 20);
            this.lblAttemptNumberText.TabIndex = 1;
            this.lblAttemptNumberText.Text = "label1";
            // 
            // lblAttemptNumber
            // 
            this.lblAttemptNumber.AutoSize = true;
            this.lblAttemptNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblAttemptNumber.Location = new System.Drawing.Point(410, 184);
            this.lblAttemptNumber.Name = "lblAttemptNumber";
            this.lblAttemptNumber.Size = new System.Drawing.Size(109, 39);
            this.lblAttemptNumber.TabIndex = 2;
            this.lblAttemptNumber.Text = "label1";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStart.Location = new System.Drawing.Point(141, 309);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(187, 63);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "button1";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblAttemptNumber);
            this.Controls.Add(this.lblAttemptNumberText);
            this.Controls.Add(this.lblMainText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainText;
        private System.Windows.Forms.Label lblAttemptNumberText;
        private System.Windows.Forms.Label lblAttemptNumber;
        private System.Windows.Forms.Button btnStart;
    }
}

