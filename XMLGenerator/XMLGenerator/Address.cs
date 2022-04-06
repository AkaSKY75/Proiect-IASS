using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGenerator
{
    public record Address(int id, string Use, string Type, string Text, string Line, string City, string District, string State, string PostalCode, string Country, Period Period);
}
