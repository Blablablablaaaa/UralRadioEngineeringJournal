using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UralRadioEngineeringJournal.Domain
{
    public class EditBoard
    {
        public Guid Id { get; set; }
        public string FullNameRu { get; set; }
        public string FullNameEn { get; set; }
        public string WorkPlace { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public Role Role { get; set; }
        public string email { get; set; }
    }
}
