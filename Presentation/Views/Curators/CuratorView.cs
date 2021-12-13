using DatabaseModels;
using Presentation.Interfaces;
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
    public partial class CuratorView : Form, IViewDatabase<Curator>
    {
        public CuratorView()
        {
            InitializeComponent();
            button_create.Click += (s, e) => CreateClick?.Invoke();
            button_loadData.Click += (s, e) => LoadClick?.Invoke();
            button_delete.Click += (s, e) => DeleteClick?.Invoke();
        }

        public event Action CreateClick;
        public event Action DeleteClick;
        public event Action UpdateClick;
        public event Action LoadClick;

        public void FillingTable(ICollection<Curator> entites)
        {
            dataGridView1.Rows.Clear();
            foreach (var curator in entites)
            {
                dataGridView1.Rows.Add(curator.Id, curator.Group.Name, curator.Name, curator.Email);
            }
        }

        public List<int> SelectedRowID()
        {
            var selectedRows = dataGridView1.SelectedRows;
            List<int> IDs = new List<int>();
            for (int i = 0; i < selectedRows.Count; i++)
            {
                IDs.Add((int)selectedRows[i].Cells["ID"].Value);
            }
            return IDs;
        }
    }
}
