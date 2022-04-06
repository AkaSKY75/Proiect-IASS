using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGenerator
{
    public record Identifier(int id, string use, CodeableConcept type, string system, string value, Period period, string assigner);
}
