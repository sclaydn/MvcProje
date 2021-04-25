using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Content
    {
        [Key]
        public int contentID { get; set; }

        [StringLength(1000)]
        public string ContentValue { get; set; }

        public DateTime contentDate { get; set; }

        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

        public int? WriterID { get; set; }
        //? soru isareti nullable type haline getiriyor
        public virtual Writer Writer { get; set; }
    }
}
