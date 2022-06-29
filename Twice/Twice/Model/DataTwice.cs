using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Twice.Model
{
    public class DataTwice
    {
        public int id { get; set; }
        [Required(ErrorMessage = "nama wajib diisi")]
        public string nama_album { get; set; }

        public string tahun { get; set; }
        public string produser { get; set; }
    }
}
