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
        public event Action LoadClick;
        public event Action SaveClick;

        public StudentView()
        {
            InitializeComponent();
            button_createStudent.Click += (s, e) => CreateClick?.Invoke();
            button_loadData.Click += (s, e) => LoadClick?.Invoke();
            button_Delete.Click += (s, e) => DeleteClick?.Invoke();
            button_save.Click += (s, e) => SaveClick?.Invoke();
        }

        public void FillingTable(ICollection<Student> entites, ICollection<Group> groups)
        {
            dataGridView1.DataSource = entites;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Group"].Visible = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                var cell = new DataGridViewComboBoxCell();
                cell.DataSource = groups;
                cell.DisplayMember = "Name";
                cell.ValueMember = "Id";
                dataGridView1.Rows[i].Cells["GroupId"] = cell;
            }
        }

        public List<int> SelectedRowID()
        {
            var selectedRows = dataGridView1.SelectedRows;
            List<int> IDs = new List<int>();
            for (int i = 0; i < selectedRows.Count; i++)
            {
                var value = selectedRows[i].Cells["ID"].Value;
                if (value != null)
                    IDs.Add((int)value);
            }
            return IDs;
        }
    }
}
