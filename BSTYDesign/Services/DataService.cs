using System;
using System.Collections.Generic;
using BSTYDesign.Models;

namespace BSTYDesign.Services
{
    public static class DataService
    {
        public static List<CategoryItem> GetItems(string category)
        {
            List<CategoryItem> items = new List<CategoryItem>();

            items.Add(new CategoryItem()
            {
                Title = "Oyane by DO.DO.",
                Abstract = "Oyana is a minimalist ceramics shop located in Nagasaki, Japan, designed by Kei Harada of DO.DO..",
                Author = "BSTY",
                Category = "Interior",
                SubCategory = "Interiors",
                Views = 232
            });

            items.Add(new CategoryItem()
            {
                Title = "Allen Key House by Architect Prineas",
                Abstract = "Allen Key House is a minimal residence located in Lane Cove, Australia, designed by Architect Prineas.",
                Author = "Sarah",
                Category = "Interior",
                SubCategory = "Architecture",
                Views = 434
            });

            items.Add(new CategoryItem()
            {
                Title = "Allen Key House by Architect Prineas",
                Abstract = "Allen Key House is a minimal residence located in Lane Cove, Australia, designed by Architect Prineas.",
                Author = "Sarah",
                Category = "Interior",
                SubCategory = "Architecture",
                Views = 434
            });

            items.Add(new CategoryItem()
            {
                Title = "Allen Key House by Architect Prineas",
                Abstract = "Allen Key House is a minimal residence located in Lane Cove, Australia, designed by Architect Prineas.",
                Author = "Sarah",
                Category = "Interior",
                SubCategory = "Architecture",
                Views = 434
            });

            return items;
        }
    }
}
