﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JTDBusiness
{
    public class CompanyDto
    {
        public int Id { get; set; }
        public string FantasyName { get; set; }
        public string Cnpj { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public bool Act { get; set; }
    }
}
