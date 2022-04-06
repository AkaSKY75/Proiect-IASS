using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGenerator
{
    public record Contact(int id, CodeableConcept relationship, HumanName name, ContactPoint telecom, Address address, string gender, string organization, Period period);


}
