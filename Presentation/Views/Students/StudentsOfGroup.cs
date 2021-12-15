using Core.Repositories;
using Core.Repositories.Interfaces;
using DatabaseModels;
using Presentation.Shared;
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
    public partial class StudentsOfGroupForm : Form
    {
        private readonly IGroupRepository _groupRepos = new GroupRepository();
        public StudentsOfGroupForm()
        {
            InitializeComponent();
            comboBox_groups.DataSource = _groupRepos.GetAll();
            comboBox_groups.DisplayMember = "Name";
            comboBox_groups.ValueMember = "Id";
        }

        private void button_getCount_Click(object sender, EventArgs e)
        {
            var selectedItem = comboBox_groups.SelectedItem;
            if (selectedItem == null)
            {
                MessageShower.ShowMessageError("Выберите группу!");
                return;
            }
            Group selectedGroup = (selectedItem as Group);
            uint result = _groupRepos.CountStudentsInGroup(selectedGroup.Id);
            MessageShower.ShowMessageInfo($"В группе {selectedGroup.Name} {result} человек");
        }
    }
}
