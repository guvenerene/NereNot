using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NereNot.Entity
{
    class Mission
    {
        [Key]
        public Guid msnRef { get; set; }
        [Index(IsUnique = true)]
        [DataType("nvarChar")]
        [StringLength(1500)]
        public string msnHead { get; set; }
        public string msnContent { get; set; }
        public bool msnNotify { get; set; }
        public string msnNotifyTime { get; set; }
        public DateTime msnNotifyDate { get; set; }
        public bool msnOffer { get; set; }
        public bool msnProject { get; set; }
        public bool msnFileIsOn { get; set; }
        public Mission()
        {
            msnRef = Guid.NewGuid();
        }
    }
}