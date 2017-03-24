using System;
using System.Collections.Generic;
using System.Linq;
using BSTYDesign.Models;

namespace BSTYDesign.Services
{
    public static class DataService
    {
        private static List<CategoryItem> _items;

        public static List<CategoryItem> GetItems(string category)
        {
            _items = new List<CategoryItem>();

            _items.Add(new CategoryItem()
            {
                Key = 1,
                Title = "Oyane by DO.DO.",
                Abstract = "Oyana is a minimalist ceramics shop located in Nagasaki, Japan, designed by Kei Harada of DO.DO..",
                Author = "BSTY",
                Category = "Interior",
                SubCategory = "Interiors",
                Views = 232
            });

            _items.Add(new CategoryItem()
            {
                Key = 2,
                Title = "Allen Key House by Architect Prineas",
                Abstract = "Allen Key House is a minimal residence located in Lane Cove, Australia, designed by Architect Prineas.",
                Author = "Sarah",
                Category = "Interior",
                SubCategory = "Architecture",
                Views = 434
            });

            _items.Add(new CategoryItem()
            {
                Key = 3,
                Title = "Allen Key House by Architect Prineas",
                Abstract = "Allen Key House is a minimal residence located in Lane Cove, Australia, designed by Architect Prineas.",
                Author = "Sarah",
                Category = "Interior",
                SubCategory = "Architecture",
                Views = 434
            });

            _items.Add(new CategoryItem()
            {
                Key = 4,
                Title = "Allen Key House by Architect Prineas",
                Abstract = "Allen Key House is a minimal residence located in Lane Cove, Australia, designed by Architect Prineas.",
                Author = "Sarah",
                Category = "Interior",
                SubCategory = "Architecture",
                Views = 434
            });

            return _items;
        }

        public static CategoryItem GetItem(int key)
        {
            if (_items != null && _items.Any())
                return _items.FirstOrDefault(item => item.Key == key);

            return null;
        }
    }
}
