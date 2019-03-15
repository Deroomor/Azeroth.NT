using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stsm.API
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Appjmessage")]
    public partial class Appjmessage
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public int? JmessageTypeId { get; set; }
        public string Title { get; set; }
        public string Json { get; set; }
        public DateTime? Time { get; set; }
        public string RemarkMessage { get; set; }
        public string FromUser { get; set; }
        public int? ObjectID { get; set; }
        public string Resource { get; set; }

    }
}
