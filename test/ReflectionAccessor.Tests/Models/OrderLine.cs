﻿using System;

namespace ReflectionAccessor.Tests.Models
{
    public class OrderLine
    {
        public string Sku { get; set; }

        public string Description { get; set; }

        public int Quanity { get; set; }

        public decimal UnitPrice { get; set; }
    }
}