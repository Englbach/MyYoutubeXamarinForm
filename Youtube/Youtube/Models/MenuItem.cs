using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youtube.Models.Enums;

namespace Youtube.Models
{
    public class MenuItem
    {
        public string Title { get; set; }
        public MenuItemType MenuItemType { get; set; }
        public bool IsEnabled { get; set; }
        public Type ViewModelType { get; set; }
    }
}
