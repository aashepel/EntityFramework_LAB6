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
    public partial class CreateGroupView : Form, ICreateGroupView
    {
        public CreateGroupView()
        {
            InitializeComponent();
            button_create.Click += (s, e) => CreateClick?.Invoke();
        }

        public string NameEntity => textBox_name.Text;

        public event Action CreateClick;

        public void ClearAllFields()
        {
            textBox_name.Text = "";
        }
    }
}
