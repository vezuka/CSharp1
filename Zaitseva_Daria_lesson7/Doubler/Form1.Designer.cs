namespace Doubler
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
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.movesText = new System.Windows.Forms.Label();
            this.movesNumber = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goalNumberText = new System.Windows.Forms.Label();
            this.goalNumber = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(597, 96);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(114, 45);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "button1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(597, 179);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(114, 46);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "button1";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(597, 258);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 47);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "button2";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblNumber.Location = new System.Drawing.Point(291, 168);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(132, 48);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "label1";
          //  this.lblNumber.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(192, 323);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(252, 69);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "button1";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // movesText
            // 
            this.movesText.AutoSize = true;
            this.movesText.Location = new System.Drawing.Point(223, 273);
            this.movesText.Name = "movesText";
            this.movesText.Size = new System.Drawing.Size(46, 17);
            this.movesText.TabIndex = 5;
            this.movesText.Text = "label1";
            // 
            // movesNumber
            // 
            this.movesNumber.AutoSize = true;
            this.movesNumber.Location = new System.Drawing.Point(363, 273);
            this.movesNumber.Name = "movesNumber";
            this.movesNumber.Size = new System.Drawing.Size(46, 17);
            this.movesNumber.TabIndex = 6;
            this.movesNumber.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // goalNumberText
            // 
            this.goalNumberText.AutoSize = true;
            this.goalNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.goalNumberText.Location = new System.Drawing.Point(126, 93);
            this.goalNumberText.Name = "goalNumberText";
            this.goalNumberText.Size = new System.Drawing.Size(53, 20);
            this.goalNumberText.TabIndex = 8;
            this.goalNumberText.Text = "label1";
            // 
            // goalNumber
            // 
            this.goalNumber.AutoSize = true;
            this.goalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.goalNumber.Location = new System.Drawing.Point(363, 85);
            this.goalNumber.Name = "goalNumber";
            this.goalNumber.Size = new System.Drawing.Size(81, 29);
            this.goalNumber.TabIndex = 9;
            this.goalNumber.Text = "label1";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 460);
            this.Controls.Add(this.goalNumber);
            this.Controls.Add(this.goalNumberText);
            this.Controls.Add(this.movesNumber);
            this.Controls.Add(this.movesText);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label movesText;
        private System.Windows.Forms.Label movesNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.Label goalNumberText;
        private System.Windows.Forms.Label goalNumber;
    }
}

