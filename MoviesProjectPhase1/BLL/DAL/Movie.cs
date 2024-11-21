using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DAL
{
    public class Movie
    {
        public int Id { get; set; } // Birincil anahtar
        public string Title { get; set; } // Film başlığı
        public string Genre { get; set; } // Tür
        public int ReleaseYear { get; set; } // Yayın yılı
    }

}
