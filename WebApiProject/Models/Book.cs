﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiProject.Models
{
    public class Book
    {
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Category
        {
            get;
            set;
        }
        public string Author
        {
            get;
            set;
        }

    }
}