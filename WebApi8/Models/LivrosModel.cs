﻿namespace WebApi8.Models
{
    public class LivrosModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorModel Autor { get; set; }
    }
}