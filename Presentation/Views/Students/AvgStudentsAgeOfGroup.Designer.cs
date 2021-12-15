namespace Presentation.Views.Students
{
    partial class AvgStudentsAgeOfGroup
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
            this.comboBox_group = new System.Windows.Forms.ComboBox();
            this.button_getAvgAge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_group
            // 
            this.comboBox_group.FormattingEnabled = true;
            this.comboBox_group.Location = new System.Drawing.Point(12, 12);
            this.comboBox_group.Name = "comboBox_group";
            this.comboBox_group.Size = new System.Drawing.Size(241, 23);
            this.comboBox_group.TabIndex = 0;
            // 
            // button_getAvgAge
            // 
            this.button_getAvgAge.Location = new System.Drawing.Point(107, 41);
            this.button_getAvgAge.Name = "button_getAvgAge";
            this.button_getAvgAge.Size = new System.Drawing.Size(146, 23);
            this.button_getAvgAge.TabIndex = 1;
            this.button_getAvgAge.Text = "Get Avg Age Of Group";
            this.button_getAvgAge.UseVisualStyleBackColor = true;
            this.button_getAvgAge.Click += new System.EventHandler(this.button_getAvgAge_Click);
            // 
            // AvgStudentsAgeOfGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 73);
            this.Controls.Add(this.button_getAvgAge);
            this.Controls.Add(this.comboBox_group);
            this.Name = "AvgStudentsAgeOfGroup";
            this.Text = "AvgStudentsAgeOfGroup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_group;
        private System.Windows.Forms.Button button_getAvgAge;
    }
}