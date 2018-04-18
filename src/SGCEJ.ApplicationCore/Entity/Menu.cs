using System;
using System.Collections.Generic;
using System.Text;

namespace SGCEJ.ApplicationCore.Entity
{
    public class Menu
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public int? MyProperty { get; set; }

        public ICollection<Menu> SubMenu { get; set; }
    }
}
