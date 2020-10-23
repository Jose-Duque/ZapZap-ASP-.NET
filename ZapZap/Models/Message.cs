using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZapZap.Models
{
    public class Message
    {
        public int Id { get; set; }

        public string NameGroup { get; set; }

        public string User { get; set; }

        public string Text { get; set; }

        public DateTime? DateCreate { get; set; }
    }
}
