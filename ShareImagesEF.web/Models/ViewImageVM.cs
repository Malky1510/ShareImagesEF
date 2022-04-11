using ShareImagesEF.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareImagesEF.web.Models
{
    public class ViewImageVM
    {
        public Image Image { get; set; }
        public bool Liked { get; set; }
    }
}
