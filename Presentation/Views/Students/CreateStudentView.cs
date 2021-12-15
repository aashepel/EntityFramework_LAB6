using DatabaseModels;
using Presentation.Views.Shared;
using Presentation.Views.Students.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Views.Students
{
    public partial class CreateStudentView : Form, ICreateStudentView
    {
        public uint Age => (uint)numericUpDown_age.Value;
        public int? GroupId => comboBox_idGroup.SelectedItem == null ? null : (comboBox_idGroup.SelectedItem as Group).Id;
        public string NameEntity => textBox_name.Text;

        public CreateStudentView()
        {
            InitializeComponent();
            button_create.Click += (o, e) => CreateClick?.Invoke();
        }

        public event Action CreateClick;

        public void SetComboBoxGroups(ICollection<Group> groups)
        {
            comboBox_idGroup.DataSource = groups;
            comboBox_idGroup.DisplayMember = "Name";
            comboBox_idGroup.ValueMember = "Id";
        }

        public void ClearAllFields()
        {
            numericUpDown_age.Value = 0;
            textBox_name.Text = "";
            comboBox_idGroup.SelectedIndex = 0;
        }
    }
}
