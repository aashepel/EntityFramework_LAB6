using DatabaseModels;
using Presentation.Views.Curators.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Views.Curators
{
    public partial class CreateCuratorView : Form, ICreateCuratorView
    {
        public CreateCuratorView()
        {
            InitializeComponent();
            button_create.Click += (s, e) => CreateClick?.Invoke();
        }

        public int? GroupId => comboBox_group.SelectedItem == null ? null : (comboBox_group.SelectedItem as Group).Id;
        public string Email => textBox_email.Text;
        public string NameEntity => textBox_name.Text;


        public event Action CreateClick;

        public void ClearAllFields()
        {
            textBox_email.Text = "";
            textBox_name.Text = "";
            comboBox_group.SelectedIndex = 0;
        }

        public void SetGroupComboBox(ICollection<Group> groups)
        {
            comboBox_group.DataSource = groups.ToList();
            comboBox_group.ValueMember = "Id";
            comboBox_group.DisplayMember = "Name";
        }
    }
}
