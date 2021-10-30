using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG_Blazor_4.Shared.Models.Services
{
    public class DniResponse
    {
        public string dni { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string nombres { get; set; }
        public string codVerifica { get; set; }
    }
}
