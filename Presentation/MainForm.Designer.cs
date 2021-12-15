
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
            this.button_curators = new System.Windows.Forms.Button();
            this.button_students_of_group = new System.Windows.Forms.Button();
            this.button_curatorNameOfStudent = new System.Windows.Forms.Button();
            this.button_avgAge = new System.Windows.Forms.Button();
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
            // button_curators
            // 
            this.button_curators.Location = new System.Drawing.Point(174, 12);
            this.button_curators.Name = "button_curators";
            this.button_curators.Size = new System.Drawing.Size(75, 23);
            this.button_curators.TabIndex = 2;
            this.button_curators.Text = "Curators";
            this.button_curators.UseVisualStyleBackColor = true;
            this.button_curators.Click += new System.EventHandler(this.button_curators_Click);
            // 
            // button_students_of_group
            // 
            this.button_students_of_group.Location = new System.Drawing.Point(12, 56);
            this.button_students_of_group.Name = "button_students_of_group";
            this.button_students_of_group.Size = new System.Drawing.Size(113, 23);
            this.button_students_of_group.TabIndex = 3;
            this.button_students_of_group.Text = "StudentsOfGroup";
            this.button_students_of_group.UseVisualStyleBackColor = true;
            this.button_students_of_group.Click += new System.EventHandler(this.button_students_of_group_Click);
            // 
            // button_curatorNameOfStudent
            // 
            this.button_curatorNameOfStudent.Location = new System.Drawing.Point(12, 114);
            this.button_curatorNameOfStudent.Name = "button_curatorNameOfStudent";
            this.button_curatorNameOfStudent.Size = new System.Drawing.Size(156, 23);
            this.button_curatorNameOfStudent.TabIndex = 4;
            this.button_curatorNameOfStudent.Text = "Curator name of Student";
            this.button_curatorNameOfStudent.UseVisualStyleBackColor = true;
            this.button_curatorNameOfStudent.Click += new System.EventHandler(this.button_curatorNameOfStudent_Click);
            // 
            // button_avgAge
            // 
            this.button_avgAge.Location = new System.Drawing.Point(12, 85);
            this.button_avgAge.Name = "button_avgAge";
            this.button_avgAge.Size = new System.Drawing.Size(113, 23);
            this.button_avgAge.TabIndex = 5;
            this.button_avgAge.Text = "Avg age of group";
            this.button_avgAge.UseVisualStyleBackColor = true;
            this.button_avgAge.Click += new System.EventHandler(this.button_avgAge_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 166);
            this.Controls.Add(this.button_avgAge);
            this.Controls.Add(this.button_curatorNameOfStudent);
            this.Controls.Add(this.button_students_of_group);
            this.Controls.Add(this.button_curators);
            this.Controls.Add(this.button_groups);
            this.Controls.Add(this.button_students);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_students;
        private System.Windows.Forms.Button button_groups;
        private System.Windows.Forms.Button button_curators;
        private System.Windows.Forms.Button button_students_of_group;
        private System.Windows.Forms.Button button_curatorNameOfStudent;
        private System.Windows.Forms.Button button_avgAge;
    }
}

