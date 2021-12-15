using DatabaseModels;
using Presentation.Interfaces;
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

namespace Presentation.Views.Groups
{
    public partial class CuratorView : Form, ICuratorView
    {
        public CuratorView()
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

        public void FillingTable(ICollection<Curator> entites, ICollection<Group> groups)
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
                if (selectedRows[i].Cells["Id"].Value != null)
                    IDs.Add((int)selectedRows[i].Cells["Id"].Value);
            }
            return IDs;
        }
    }
}
