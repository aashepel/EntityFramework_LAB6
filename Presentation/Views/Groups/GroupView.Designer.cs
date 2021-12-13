namespace Presentation.Views.Groups
{
    partial class GroupView
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
            this.button_create = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_loadData = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(1131, 26);
            this.button_create.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(139, 49);
            this.button_create.TabIndex = 0;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.CreationDate});
            this.dataGridView1.Location = new System.Drawing.Point(22, 87);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1248, 847);
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
            this.Name.HeaderText = "Группа";
            this.Name.MinimumWidth = 10;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 200;
            // 
            // CreationDate
            // 
            this.CreationDate.HeaderText = "Дата создания";
            this.CreationDate.MinimumWidth = 10;
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.ReadOnly = true;
            this.CreationDate.Width = 200;
            // 
            // button_loadData
            // 
            this.button_loadData.Location = new System.Drawing.Point(22, 26);
            this.button_loadData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_loadData.Name = "button_loadData";
            this.button_loadData.Size = new System.Drawing.Size(139, 49);
            this.button_loadData.TabIndex = 2;
            this.button_loadData.Text = "Load Data";
            this.button_loadData.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(1279, 87);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(195, 46);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Delete selected";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // GroupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 960);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_loadData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_create);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
        private System.Windows.Forms.Button button_loadData;
        private System.Windows.Forms.Button button_delete;
    }
}