﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateTest.Models
{
    public class HomeModel 
    {
        public HomeModel()
        {
            Article = new ArticleModel();      
        }

        public ArticleModel Article { get; set; }
       
    }
}