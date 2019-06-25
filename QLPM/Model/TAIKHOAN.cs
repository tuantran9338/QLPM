using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLPM.Model
{
    public class TAIKHOAN
    {
        [Key]
        public int ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string MAQH { get; set; }

        public virtual QUYENHAN QUYENHAN { get; set; }
    }
}
