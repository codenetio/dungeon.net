using Codenet.LanguageParser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codenet.LanguageParser
{
    public class Parser<T> : ILanguageParser
        where T : class
    {
        private Dictionary<string, IVerb> _verbs;

        public Parser()
        {
            _verbs = new Dictionary<string, IVerb>();
        }

        /// <summary>
        /// Adds an IVerb and its synonyms to the parser.
        /// </summary>
        /// <param name="verb">The IVerb to add.</param>
        /// <exception cref="InvalidOperationException">
        /// The verb is already defined in the parser.
        /// OR
        /// The verb has a synonym that is already defined in the parser.</exception>
        public void AddVerb(IVerb verb)
        {
            if (_verbs.ContainsKey(verb.Token))
            {
                throw new InvalidOperationException($"The verb {verb.Token} is already defined in the parser.");
            }

            foreach (var token in verb.Synonyms)
            {
                if (_verbs.ContainsKey(token))
                {
                    throw new InvalidOperationException(
                        $"The verb {verb.Token} has a synonym: {token} that is already defined in the parser.");
                }
            }

            _verbs[verb.Token] = verb;
            foreach(var token in verb.Synonyms)
            {
                _verbs[token] = verb;
            }
        }
        
        public void Parse(string phrase)
        {
            var tokens = phrase.Split(' ');
            // split them up
            // format?  verb noun?      
        }
    }
}
