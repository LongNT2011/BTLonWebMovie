﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelAccess.ViewModel
{
    public class DirectorView
    {
        public int DirectorId { get; set; } 
        public string DirectorName { get; set; } = null!;
        public bool IsDelete { get; set; }
    }
}
