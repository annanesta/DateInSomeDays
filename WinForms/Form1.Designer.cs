
namespace DateInSomeDays
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
            this.BoxUserDays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGo = new System.Windows.Forms.Button();
            this.BtnStory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BoxUserDays
            // 
            this.BoxUserDays.Location = new System.Drawing.Point(134, 10);
            this.BoxUserDays.Name = "BoxUserDays";
            this.BoxUserDays.Size = new System.Drawing.Size(42, 20);
            this.BoxUserDays.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "What a day will be in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "days?";
            // 
            // BtnGo
            // 
            this.BtnGo.Location = new System.Drawing.Point(27, 36);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(190, 23);
            this.BtnGo.TabIndex = 2;
            this.BtnGo.Text = "I want to know!";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // BtnStory
            // 
            this.BtnStory.Location = new System.Drawing.Point(142, 89);
            this.BtnStory.Name = "BtnStory";
            this.BtnStory.Size = new System.Drawing.Size(75, 23);
            this.BtnStory.TabIndex = 3;
            this.BtnStory.Text = "story";
            this.BtnStory.UseVisualStyleBackColor = true;
            this.BtnStory.Click += new System.EventHandler(this.BtnStory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 124);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnStory);
            this.Controls.Add(this.BtnGo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxUserDays);
            this.Name = "Form1";
            this.Text = "That day";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxUserDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.Button BtnStory;
        private System.Windows.Forms.Label label3;
    }
}

