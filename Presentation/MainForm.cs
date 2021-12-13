using Core;
using Core.Repositories;
using Core.Repositories.Interfaces;
using DatabaseContext;
using DatabaseModels;
using Microsoft.Extensions.DependencyInjection;
using Presentation;
using Presentation.Presenters;
using Presentation.Presenters.Groups;
using Presentation.Presenters.Interfaces;
using Presentation.Views.Groups;
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
            
            StudentView studentView = new StudentView();
            IStudentRepository studentRepository = new StudentRepository();
            IDatabasePresenter<Student> databasePresenter = new MainStudentPresenter(studentView, studentRepository);
            studentView.Show();
        }

        private void button_groups_Click(object sender, EventArgs e)
        {
            GroupView groupView = new GroupView();
            IGroupRepository groupRepository = new GroupRepository();
            IDatabasePresenter<Group> databasePresenter = new MainGroupPresenter(groupView, groupRepository);
            groupView.Show();
        }
    }
}
