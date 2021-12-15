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

namespace Presentation.Views.Curators
{
    public partial class CuratorNameOfStudent : Form
    {
        private IStudentRepository _studentRepository = new StudentRepository();
        public CuratorNameOfStudent()
        {
            InitializeComponent();
            List<Student> students = _studentRepository.GetAll().ToList();
            foreach (Student student in students)
            {
                student.Name += $" | {student.Group.Name}";
            }
            comboBox_students.DataSource = students;
            comboBox_students.DisplayMember = "Name";
            comboBox_students.ValueMember = "Id";
        }

        private void button_getCuratorName_Click(object sender, EventArgs e)
        {
            var selectedItem = comboBox_students.SelectedItem;
            if (selectedItem == null)
            {
                MessageShower.ShowMessageError("Выберите группу!");
                return;
            }
            Student selectedStudent = (selectedItem as Student);
            string? result = _studentRepository.GetCuratorNameOfStudent(selectedStudent.Id);
            if (result != null)
                MessageShower.ShowMessageInfo($"У студента {selectedStudent.Name}, принадлежащего группе {selectedStudent.Group.Name} куратор: {result}");
            else
                MessageShower.ShowMessageError("У группы нет куратора");
        }
    }
}
