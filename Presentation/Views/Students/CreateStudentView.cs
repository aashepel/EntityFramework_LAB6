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
        public CreateStudentView()
        {
            InitializeComponent();

            button_create.Click += (o, e) => CreateClick?.Invoke();
            textBox_name.TextChanged += (o, e) => NameChange?.Invoke(textBox_name.Text);
            numericUpDown_age.ValueChanged += (o, e) => AgeChange?.Invoke((uint)numericUpDown_age.Value);
            comboBox_idGroup.TextChanged += (o, e) => GroupChange?.Invoke(comboBox_idGroup.SelectedItem as string);
        }

        public event Action CreateClick;
        public event Action<uint> AgeChange;
        public event Action<string> NameChange;
        public event Action<string> GroupChange;

        void IView.Show()
        {
            this.Show();
        }

        void IView.Close()
        {
            this.Close();
        }

        public void SetComboBoxGroups(ICollection<Group> groups)
        {
            comboBox_idGroup.Items.Clear();
            var groupsString = groups.Select(p => p.Name).ToArray();
            foreach (var group in groupsString)
            {
                comboBox_idGroup.Items.Add(group);
            }
        }

        public void ClearAllFields()
        {
            numericUpDown_age.Value = 0;
            textBox_name.Text = "";
            comboBox_idGroup.SelectedIndex = 0;
        }
    }
}
