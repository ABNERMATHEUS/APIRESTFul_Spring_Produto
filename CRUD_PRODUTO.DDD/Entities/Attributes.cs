﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_PRODUTO.Domain.Entities
{

    public class Attributes
    {
        [Key]
        public string Id { get; set; }
        public string Value_name { get; set; }
    }
}
