using System;

namespace BSTYDesign.Models
{
    public class CategoryItem
    {
        public string Title { get; set; }
        public DateTime PostDateTime { get; set; }
        public string Abstract { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public string Author { get; set; }
        public int Views { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }

        public string PostDisplay => $"{PostDateTime.ToString("MMM dd, yyyy").ToUpper()} / {SubCategory.ToUpper()}";
        public string DetailDisplay => $"By {Author.ToUpper()} - {Views} Views";
    }
}
