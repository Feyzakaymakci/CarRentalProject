﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Payment: IEntity
    {
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
        public string CardNumber { get; set; }
        public decimal Price { get; set; }
        public int ExpirationDate { get; set; }
        public string CVV { get; set; }
     
        
    }
}
