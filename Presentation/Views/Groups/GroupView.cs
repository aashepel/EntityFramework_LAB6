using DatabaseModels;
using Presentation.Interfaces;
using Presentation.Views.Groups.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Views.Groups
{
    public partial class GroupView : Form, IGroupView
    {
        public GroupView()
        {
            InitializeComponent();
            button_create.Click += (s, e) => CreateClick?.Invoke();
            button_loadData.Click += (s, e) => LoadClick?.Invoke();
            button_delete.Click += (s, e) => DeleteClick?.Invoke();
            button_save.Click += (s, e) => SaveClick?.Invoke();
        }

        public event Action CreateClick;
        public event Action DeleteClick;
        public event Action SaveClick;
        public event Action LoadClick;

        public void FillingTable(ICollection<Group> entites)
        {
            dataGridView1.DataSource = entites;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["CreationDate"].ReadOnly = true;
        }

        public List<int> SelectedRowID()
        {
            var selectedRows = dataGridView1.SelectedRows;
            List<int> IDs = new List<int>();
            for (int i = 0; i < selectedRows.Count; i++)
            {
                IDs.Add((int)selectedRows[i].Cells["Id"].Value);
            }
            return IDs;
        }
    }
}
