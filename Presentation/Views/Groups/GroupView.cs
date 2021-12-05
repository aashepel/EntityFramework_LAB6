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
    public partial class GroupView : Form, IViewDatabase<Group>
    {
        public GroupView()
        {
            InitializeComponent();
            button_create.Click += (s, e) => CreateClick?.Invoke();
        }

        public event Action CreateClick;
        public event Action DeleteClick;
        public event Action UpdateClick;
        public event Action LoadClick;

        public void FillingTable(ICollection<Student> entites)
        {
            throw new NotImplementedException();
        }
    }
}
