namespace Presentation.Views.Students
{
    partial class CreateStudentView
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
            this.numericUpDown_age = new System.Windows.Forms.NumericUpDown();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_create = new System.Windows.Forms.Button();
            this.comboBox_idGroup = new System.Windows.Forms.ComboBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_age)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_age
            // 
            this.numericUpDown_age.Location = new System.Drawing.Point(90, 41);
            this.numericUpDown_age.Name = "numericUpDown_age";
            this.numericUpDown_age.Size = new System.Drawing.Size(217, 23);
            this.numericUpDown_age.TabIndex = 0;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(90, 12);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(217, 23);
            this.textBox_name.TabIndex = 1;
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(187, 99);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(120, 23);
            this.button_create.TabIndex = 2;
            this.button_create.Text = "Создать";
            this.button_create.UseVisualStyleBackColor = true;
            // 
            // comboBox_idGroup
            // 
            this.comboBox_idGroup.FormattingEnabled = true;
            this.comboBox_idGroup.Location = new System.Drawing.Point(90, 70);
            this.comboBox_idGroup.Name = "comboBox_idGroup";
            this.comboBox_idGroup.Size = new System.Drawing.Size(218, 23);
            this.comboBox_idGroup.TabIndex = 3;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 15);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(31, 15);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "Имя";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Location = new System.Drawing.Point(12, 43);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(50, 15);
            this.label_age.TabIndex = 6;
            this.label_age.Text = "Возраст";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(12, 73);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(46, 15);
            this.labelGroup.TabIndex = 7;
            this.labelGroup.Text = "Группа";
            // 
            // CreateStudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 134);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.comboBox_idGroup);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.numericUpDown_age);
            this.Name = "CreateStudentView";
            this.Text = "CreateStudentView";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_age;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.ComboBox comboBox_idGroup;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label labelGroup;
    }
}