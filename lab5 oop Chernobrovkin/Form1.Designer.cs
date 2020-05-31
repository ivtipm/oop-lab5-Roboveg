namespace KrestNol_Test_DC
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
            this.label_cross = new System.Windows.Forms.Label();
            this.label_null = new System.Windows.Forms.Label();
            this.label_cross_wins = new System.Windows.Forms.Label();
            this.label_null_wins = new System.Windows.Forms.Label();
            this.button_restart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.button_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_cross
            // 
            this.label_cross.AutoSize = true;
            this.label_cross.Location = new System.Drawing.Point(293, 108);
            this.label_cross.Name = "label_cross";
            this.label_cross.Size = new System.Drawing.Size(58, 13);
            this.label_cross.TabIndex = 0;
            this.label_cross.Text = "Крестики:";
            // 
            // label_null
            // 
            this.label_null.AutoSize = true;
            this.label_null.Location = new System.Drawing.Point(303, 205);
            this.label_null.Name = "label_null";
            this.label_null.Size = new System.Drawing.Size(48, 13);
            this.label_null.TabIndex = 1;
            this.label_null.Text = "Нолики:";
            // 
            // label_cross_wins
            // 
            this.label_cross_wins.AutoSize = true;
            this.label_cross_wins.Location = new System.Drawing.Point(357, 108);
            this.label_cross_wins.Name = "label_cross_wins";
            this.label_cross_wins.Size = new System.Drawing.Size(13, 13);
            this.label_cross_wins.TabIndex = 2;
            this.label_cross_wins.Text = "0";
            this.label_cross_wins.Click += new System.EventHandler(this.Label_cross_wins_Click);
            // 
            // label_null_wins
            // 
            this.label_null_wins.AutoSize = true;
            this.label_null_wins.Location = new System.Drawing.Point(357, 205);
            this.label_null_wins.Name = "label_null_wins";
            this.label_null_wins.Size = new System.Drawing.Size(13, 13);
            this.label_null_wins.TabIndex = 3;
            this.label_null_wins.Text = "0";
            // 
            // button_restart
            // 
            this.button_restart.Location = new System.Drawing.Point(89, 315);
            this.button_restart.Name = "button_restart";
            this.button_restart.Size = new System.Drawing.Size(75, 23);
            this.button_restart.TabIndex = 4;
            this.button_restart.Text = "Заново";
            this.button_restart.UseVisualStyleBackColor = true;
            this.button_restart.Click += new System.EventHandler(this.Button_restart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(429, 24);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(223, 315);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 23);
            this.button_reset.TabIndex = 7;
            this.button_reset.Text = "Сбросить";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.Button_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_restart);
            this.Controls.Add(this.label_null_wins);
            this.Controls.Add(this.label_cross_wins);
            this.Controls.Add(this.label_null);
            this.Controls.Add(this.label_cross);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Крестики-нолики (2players1pc edition)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_cross;
        private System.Windows.Forms.Label label_null;
        private System.Windows.Forms.Label label_cross_wins;
        private System.Windows.Forms.Label label_null_wins;
        private System.Windows.Forms.Button button_restart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Button button_reset;
    }
}

