using Core;
using Core.Repositories;
using Core.Repositories.Interfaces;
using DatabaseContext;
using DatabaseModels;
using Microsoft.Extensions.DependencyInjection;
using Presentation;
using Presentation.Presenters;
using Presentation.Presenters.Curators;
using Presentation.Presenters.Groups;
using Presentation.Presenters.Interfaces;
using Presentation.Views.Curators;
using Presentation.Views.Curators.Interfaces;
using Presentation.Views.Groups;
using Presentation.Views.Groups.Interfaces;
using Presentation.Views.Students;
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

namespace EntityFramework_LAB6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            IStudentView studentView = new StudentView();
            IStudentRepository studentRepository = new StudentRepository();
            IDatabasePresenter<Student> databasePresenter = new MainStudentPresenter(studentView, studentRepository);
            studentView.Show();
        }

        private void button_groups_Click(object sender, EventArgs e)
        {
            IGroupView groupView = new GroupView();
            IGroupRepository groupRepository = new GroupRepository();
            IDatabasePresenter<Group> databasePresenter = new MainGroupPresenter(groupView, groupRepository);
            groupView.Show();
        }

        private void button_curators_Click(object sender, EventArgs e)
        {
            ICuratorView curatorView = new CuratorView();
            ICuratorRepository curatorRepository = new CuratorRepsoitory();
            IDatabasePresenter<Curator> databasePresenter = new MainCuratorPresenter(curatorView, curatorRepository);
            curatorView.Show();
        }

        private void button_students_of_group_Click(object sender, EventArgs e)
        {
            StudentsOfGroupForm studentsOfGroup = new StudentsOfGroupForm();
            studentsOfGroup.Show();
        }

        private void button_curatorNameOfStudent_Click(object sender, EventArgs e)
        {
            CuratorNameOfStudent curatorNameOfStudent = new CuratorNameOfStudent();
            curatorNameOfStudent.Show();
        }

        private void button_avgAge_Click(object sender, EventArgs e)
        {
            AvgStudentsAgeOfGroup avgStudentsAgeOfGroup = new AvgStudentsAgeOfGroup();
            avgStudentsAgeOfGroup.Show();
        }
    }
}
