﻿using System.ComponentModel.DataAnnotations;

namespace E_Apoteka.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        List<Medicine> medicines;
    }
}