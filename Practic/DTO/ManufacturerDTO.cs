﻿namespace Practic.DTO
{
    public class ManufacturerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductDTO> Products { get; set; }
    }
}
