using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGenerator
{
    public record Coding(int id, string system, string version, string code, string display, bool userSelected);

}
