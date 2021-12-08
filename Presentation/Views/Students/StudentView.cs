using DatabaseModels;
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
    public partial class StudentView : Form, IStudentView
    {
        public event Action CreateClick;
        public event Action DeleteClick;
        public event Action UpdateClick;
        public event Action LoadClick;
        public StudentView()
        {
            InitializeComponent();
            button_createStudent.Click += (s, e) => CreateClick?.Invoke();
            button_loadData.Click += (s, e) => LoadClick?.Invoke();
        }

        public void FillingTable(ICollection<Student> entites)
        {
            dataGridView1.Rows.Clear();
            foreach(var student in entites)
            {
                dataGridView1.Rows.Add(student.Id, student.Name, student.Age, student.Group.Name);
            }
        }
    }
}
