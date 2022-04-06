using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGenerator
{
    public record Attachement(int id, string contentType, string language, char[] data, string url, uint size, char[] hash, string title, DateTime creation);
}
