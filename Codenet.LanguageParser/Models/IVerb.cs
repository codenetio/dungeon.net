using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codenet.LanguageParser.Models
{
    public interface IVerb
    {
        string Token { get; set; }
        IList<string> Synonyms { get; set; }
    }
}
