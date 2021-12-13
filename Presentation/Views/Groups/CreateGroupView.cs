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
            textBox_name.TextChanged += (s, e) => NameChange?.Invoke(textBox_name.Text);
            button_create.Click += (s, e) => CreateClick?.Invoke();
        }

        public event Action<string> NameChange;
        public event Action CreateClick;

        public void ClearAllFields()
        {
            textBox_name.Text = "";
        }
    }
}
