using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class SessionCode
    {
        public long Id { get; set; }
        public string Code { get; set; }

        [ForeignKey("Session")]
        public long? SessionId { get; set; }
        [JsonIgnore]
        public Session Session { get; set; }
    }
}
