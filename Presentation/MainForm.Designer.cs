
namespace EntityFramework_LAB6
{
    partial class MainForm
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
            this.button_students = new System.Windows.Forms.Button();
            this.button_groups = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_students
            // 
            this.button_students.Location = new System.Drawing.Point(12, 12);
            this.button_students.Name = "button_students";
            this.button_students.Size = new System.Drawing.Size(75, 23);
            this.button_students.TabIndex = 0;
            this.button_students.Text = "Students";
            this.button_students.UseVisualStyleBackColor = true;
            this.button_students.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_groups
            // 
            this.button_groups.Location = new System.Drawing.Point(93, 12);
            this.button_groups.Name = "button_groups";
            this.button_groups.Size = new System.Drawing.Size(75, 23);
            this.button_groups.TabIndex = 1;
            this.button_groups.Text = "Groups";
            this.button_groups.UseVisualStyleBackColor = true;
            this.button_groups.Click += new System.EventHandler(this.button_groups_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_groups);
            this.Controls.Add(this.button_students);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_students;
        private System.Windows.Forms.Button button_groups;
    }
}

