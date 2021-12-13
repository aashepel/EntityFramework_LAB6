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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_loadData = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_createStudent
            // 
            this.button_createStudent.Location = new System.Drawing.Point(1241, 26);
            this.button_createStudent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_createStudent.Name = "button_createStudent";
            this.button_createStudent.Size = new System.Drawing.Size(223, 49);
            this.button_createStudent.TabIndex = 0;
            this.button_createStudent.Text = "Create student";
            this.button_createStudent.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Age,
            this.Group});
            this.dataGridView1.Location = new System.Drawing.Point(22, 87);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1441, 619);
            this.dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 10;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 200;
            // 
            // Name
            // 
            this.Name.HeaderText = "Имя";
            this.Name.MinimumWidth = 10;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 200;
            // 
            // Age
            // 
            this.Age.HeaderText = "Возраст";
            this.Age.MinimumWidth = 10;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 200;
            // 
            // Group
            // 
            this.Group.HeaderText = "Группа";
            this.Group.MinimumWidth = 10;
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            this.Group.Width = 200;
            // 
            // button_loadData
            // 
            this.button_loadData.Location = new System.Drawing.Point(22, 26);
            this.button_loadData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_loadData.Name = "button_loadData";
            this.button_loadData.Size = new System.Drawing.Size(139, 49);
            this.button_loadData.TabIndex = 2;
            this.button_loadData.Text = "Load data";
            this.button_loadData.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(1472, 87);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(247, 46);
            this.button_Delete.TabIndex = 3;
            this.button_Delete.Text = "Delete selected";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1731, 960);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_loadData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_createStudent);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_createStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.Button button_loadData;
        private System.Windows.Forms.Button button_Delete;
    }
}