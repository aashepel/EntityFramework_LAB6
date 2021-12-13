﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModels
{
    public abstract class BaseEntity
    {
        public abstract int Id { get; set; }
        public abstract bool IsValid();
    }
}
