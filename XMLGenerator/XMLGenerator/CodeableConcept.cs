using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGenerator
{
    public record CodeableConcept(int id, Coding coding, string text);
}
