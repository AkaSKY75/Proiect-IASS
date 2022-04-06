using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGenerator
{
    public record HumanName(string use, string text, string family, string given, string prefix, string suffix, Period period);

}
