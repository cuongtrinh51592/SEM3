using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftNews.Models
{
    public class News
    {
        public string Name { get; set; }
        public NewsCategory Category { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public News(string name, NewsCategory category, string title, string description)
        {
            Name = name;
            Category = category;
            Title = title;
            Image = String.Format("/Assets/Images/{0}/{1}.jpg", category, name);
            Description = description;
        }
    }

    public enum NewsCategory
    {
        Sport,
        Business,
        Heath,
        Hitech,
        Showbiz,
        TheWorld
    }
}
