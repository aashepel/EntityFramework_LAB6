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

namespace Presentation.Views.Curators
{
    public partial class CreateCuratorView : Form, ICreateCuratorView
    {
        public CreateCuratorView()
        {
            InitializeComponent();
        }

        public event Action CreateClick;

        public void ClearAllFields()
        {
            
        }
    }
}
