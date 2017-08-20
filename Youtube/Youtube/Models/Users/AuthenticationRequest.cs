using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube.Models.Users
{
    public class AuthenticationRequest
    {
        public string client_id { get; set; }
        public string response_type { get; set; }
        public string redirect_uri { get; set; }
        public string scope { get; set; }
        public string state { get; set; }
        public string login_hint { get; set; }
    }
}
