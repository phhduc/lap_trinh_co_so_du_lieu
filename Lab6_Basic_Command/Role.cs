﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Basic_Command
{
    internal class Role
    {
        public string ID { get; set; }
        public string RoleName { get; set; }

        public Role(string iD, string roleName)
        {
            ID = iD;
            RoleName = roleName;
        }
    }
}
