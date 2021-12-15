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
    public partial class AvgStudentsAgeOfGroup : Form
    {
        private readonly IGroupRepository _groupRepository = new GroupRepository();
        private readonly ICuratorRepository _curatorRepository = new CuratorRepsoitory();
        public AvgStudentsAgeOfGroup()
        {
            InitializeComponent();
            var curators = _curatorRepository.GetAll().ToList();
            foreach(var curator in curators)
            {
                curator.Name += $" | {curator.Group.Name}";
            }
            comboBox_group.DataSource = _curatorRepository.GetAll();
            comboBox_group.ValueMember = "Id";
            comboBox_group.DisplayMember = "Name";
        }

        private void button_getAvgAge_Click(object sender, EventArgs e)
        {
            var selectedItem = comboBox_group.SelectedItem;
            if (selectedItem == null)
            {
                MessageShower.ShowMessageError("Выберите группу!");
                return;
            }
            Curator selectedCurator = (selectedItem as Curator);
            double result = _groupRepository.AvgAgeStudents(selectedCurator.Id);
            result = Math.Round(result, 2);
            MessageShower.ShowMessageInfo($"В группе {selectedCurator.Group.Name} средний ворзраст {result}");
        }
    }
}
