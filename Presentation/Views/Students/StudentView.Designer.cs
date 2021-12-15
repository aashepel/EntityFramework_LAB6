namespace Presentation.Views.Students
{
    partial class StudentView
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
            this.button_createStudent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_loadData = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_createStudent
            // 
            this.button_createStudent.Location = new System.Drawing.Point(668, 12);
            this.button_createStudent.Name = "button_createStudent";
            this.button_createStudent.Size = new System.Drawing.Size(120, 23);
            this.button_createStudent.TabIndex = 0;
            this.button_createStudent.Text = "Create student";
            this.button_createStudent.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 290);
            this.dataGridView1.TabIndex = 1;
            // 
            // button_loadData
            // 
            this.button_loadData.Location = new System.Drawing.Point(12, 12);
            this.button_loadData.Name = "button_loadData";
            this.button_loadData.Size = new System.Drawing.Size(75, 23);
            this.button_loadData.TabIndex = 2;
            this.button_loadData.Text = "Load data";
            this.button_loadData.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(793, 41);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(133, 22);
            this.button_Delete.TabIndex = 3;
            this.button_Delete.Text = "Delete selected";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(794, 67);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(132, 23);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_loadData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_createStudent);
            this.Name = "StudentView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_createStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_loadData;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_save;
    }
}