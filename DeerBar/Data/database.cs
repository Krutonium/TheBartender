﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark.Modules.Data
{
    public class coins
    { 
        public long Coins { get; set; }
        public int Daily { get; set; }
    }

    public class delete
    {
        public long CID { get; set; }
        public long MID { get; set; }
    }
}