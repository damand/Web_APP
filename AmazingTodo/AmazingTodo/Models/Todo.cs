﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazingTodo.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public String Text { get; set; }
        public DateTime? Due { get; set; }
        public int Priority { get; set; }
    }
}