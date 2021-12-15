namespace Presentation.Views.Curators
{
    partial class CuratorNameOfStudent
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
            this.comboBox_students = new System.Windows.Forms.ComboBox();
            this.button_getCuratorName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_students
            // 
            this.comboBox_students.FormattingEnabled = true;
            this.comboBox_students.Location = new System.Drawing.Point(12, 12);
            this.comboBox_students.Name = "comboBox_students";
            this.comboBox_students.Size = new System.Drawing.Size(225, 23);
            this.comboBox_students.TabIndex = 0;
            // 
            // button_getCuratorName
            // 
            this.button_getCuratorName.Location = new System.Drawing.Point(111, 41);
            this.button_getCuratorName.Name = "button_getCuratorName";
            this.button_getCuratorName.Size = new System.Drawing.Size(126, 23);
            this.button_getCuratorName.TabIndex = 1;
            this.button_getCuratorName.Text = "Get Curator Name";
            this.button_getCuratorName.UseVisualStyleBackColor = true;
            this.button_getCuratorName.Click += new System.EventHandler(this.button_getCuratorName_Click);
            // 
            // CuratorNameOfStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 84);
            this.Controls.Add(this.button_getCuratorName);
            this.Controls.Add(this.comboBox_students);
            this.Name = "CuratorNameOfStudent";
            this.Text = "CuratorNameOfStudent";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_students;
        private System.Windows.Forms.Button button_getCuratorName;
    }
}