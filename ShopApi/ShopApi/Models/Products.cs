﻿namespace ShopApi.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Description { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}