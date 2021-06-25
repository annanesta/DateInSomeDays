
namespace DateInSomeDays
{
    partial class UserStory
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.BtnReverce = new System.Windows.Forms.Button();
            this.BtnDeleteItem = new System.Windows.Forms.Button();
            this.BtnDeleteAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(384, 448);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // BtnReverce
            // 
            this.BtnReverce.AutoSize = true;
            this.BtnReverce.Location = new System.Drawing.Point(13, 13);
            this.BtnReverce.Name = "BtnReverce";
            this.BtnReverce.Size = new System.Drawing.Size(85, 23);
            this.BtnReverce.TabIndex = 1;
            this.BtnReverce.Text = "Reverce order";
            this.BtnReverce.UseVisualStyleBackColor = true;
            this.BtnReverce.Click += new System.EventHandler(this.BtnReverce_Click);
            // 
            // BtnDeleteItem
            // 
            this.BtnDeleteItem.AutoSize = true;
            this.BtnDeleteItem.Location = new System.Drawing.Point(104, 13);
            this.BtnDeleteItem.Name = "BtnDeleteItem";
            this.BtnDeleteItem.Size = new System.Drawing.Size(85, 23);
            this.BtnDeleteItem.TabIndex = 1;
            this.BtnDeleteItem.Text = "Delete an item";
            this.BtnDeleteItem.UseVisualStyleBackColor = true;
            this.BtnDeleteItem.Click += new System.EventHandler(this.BtnDeleteItem_Click);
            // 
            // BtnDeleteAll
            // 
            this.BtnDeleteAll.AutoSize = true;
            this.BtnDeleteAll.Location = new System.Drawing.Point(195, 13);
            this.BtnDeleteAll.Name = "BtnDeleteAll";
            this.BtnDeleteAll.Size = new System.Drawing.Size(85, 23);
            this.BtnDeleteAll.TabIndex = 1;
            this.BtnDeleteAll.Text = "Delete all";
            this.BtnDeleteAll.UseVisualStyleBackColor = true;
            this.BtnDeleteAll.Click += new System.EventHandler(this.BtnDeleteAll_Click);
            // 
            // UserStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 512);
            this.Controls.Add(this.BtnDeleteAll);
            this.Controls.Add(this.BtnDeleteItem);
            this.Controls.Add(this.BtnReverce);
            this.Controls.Add(this.listView1);
            this.Name = "UserStory";
            this.Text = "UserStory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button BtnReverce;
        private System.Windows.Forms.Button BtnDeleteItem;
        private System.Windows.Forms.Button BtnDeleteAll;
    }
}