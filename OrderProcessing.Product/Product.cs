﻿namespace OrderProcessing.Product
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; } = 0;  
        public decimal Price { get; set; } = 0;

    }
}
