﻿using DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Interfaces
{
    public interface IStudentView : IViewDatabase<Student>
    {
        void GetCuratorName(int id);
    }
}