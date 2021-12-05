using Presentation.Views.Shared;
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
    public partial class UpdateStudentView : Form, IUpdateStudentView
    {
        public UpdateStudentView()
        {
            InitializeComponent();
        }

        void IView.Show()
        {
            this.Show();
        }
        
        void IView.Close()
        {
            this.Close();
        }
    }
}
