namespace Presentation.Views.Students
{
    partial class StudentsOfGroupForm
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
            this.comboBox_groups = new System.Windows.Forms.ComboBox();
            this.button_getCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_groups
            // 
            this.comboBox_groups.FormattingEnabled = true;
            this.comboBox_groups.Location = new System.Drawing.Point(12, 12);
            this.comboBox_groups.Name = "comboBox_groups";
            this.comboBox_groups.Size = new System.Drawing.Size(121, 23);
            this.comboBox_groups.TabIndex = 0;
            // 
            // button_getCount
            // 
            this.button_getCount.Location = new System.Drawing.Point(12, 41);
            this.button_getCount.Name = "button_getCount";
            this.button_getCount.Size = new System.Drawing.Size(121, 23);
            this.button_getCount.TabIndex = 1;
            this.button_getCount.Text = "Get Count";
            this.button_getCount.UseVisualStyleBackColor = true;
            this.button_getCount.Click += new System.EventHandler(this.button_getCount_Click);
            // 
            // StudentsOfGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(152, 76);
            this.Controls.Add(this.button_getCount);
            this.Controls.Add(this.comboBox_groups);
            this.Name = "StudentsOfGroup";
            this.Text = "StudentsOfGroup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_groups;
        private System.Windows.Forms.Button button_getCount;
    }
}