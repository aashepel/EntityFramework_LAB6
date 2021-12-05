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
                dataGridView1.Rows.Add();
                dataGridView1["ID", dataGridView1.RowCount - 1].Value = student.Id;
                dataGridView1["Name", dataGridView1.RowCount - 1].Value = student.Name;
                dataGridView1["Age", dataGridView1.RowCount - 1].Value = student.Age;
                dataGridView1["Group", dataGridView1.RowCount - 1].Value = student.Group.Name;
            }
        }
    }
}
