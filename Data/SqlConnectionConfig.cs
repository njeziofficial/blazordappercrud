﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDapperCrud.Data
{
    public class SqlConnectionConfig
    {
        public SqlConnectionConfig(string value) => Value = value;
        public string Value { get; }


    }
}
