namespace ProjectManagement
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
            this.TaskList = new System.Windows.Forms.DataGridView();
            this.DeveloperList = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TaskList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeveloperList)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskList
            // 
            this.TaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskList.Location = new System.Drawing.Point(35, 35);
            this.TaskList.Name = "TaskList";
            this.TaskList.RowTemplate.Height = 24;
            this.TaskList.Size = new System.Drawing.Size(316, 194);
            this.TaskList.TabIndex = 0;
            // 
            // DeveloperList
            // 
            this.DeveloperList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeveloperList.Location = new System.Drawing.Point(35, 263);
            this.DeveloperList.Name = "DeveloperList";
            this.DeveloperList.RowTemplate.Height = 24;
            this.DeveloperList.Size = new System.Drawing.Size(316, 171);
            this.DeveloperList.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeveloperList);
            this.Controls.Add(this.TaskList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TaskList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeveloperList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TaskList;
        private System.Windows.Forms.DataGridView DeveloperList;
        private System.Windows.Forms.Button button1;
    }
}

