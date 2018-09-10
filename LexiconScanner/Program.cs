using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;

namespace LexiconScanner
{
    // Tokens that represent the input
    internal enum Token
    {
        PalabraEspañol,
        Categoría,
        Construcción,
        Definición,
        Combinación,
        FinDefinición,
        Other
    }

    // Scanner used to find the tokens from a calc lampda string expression
    internal static class LambdaCalcScanner
    {
        // var myRegex = new Regex(@"[a-zA-ZáéíóúÁÉÍÓÚÑñüÜÇç]+");
        // The pattern used with the regular expression class to scan the input
        const string Pattern = @"
                       (?'PalabraEspañol' [a-zA-ZáéíóúÁÉÍÓÚÑñüÜÇç]+ ) |
                       (?'Categoría' \#[0123456789]+ ) |
                       (?'Construcción' \&[0123456789]+ ) |
                       (?'Definición' : ) |
                       (?'Combinación' ° ) |
                       (?'FinDefinición' ; ) |
                       (?'Other' [^ \r\n\t])";

        // Regular expression used to scan the input
        private static Regex MathRegex = new Regex(Pattern, RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace | RegexOptions.Singleline | RegexOptions.Compiled);

        // Enumurable to get tokens from the given expression (scanner)
        public static IEnumerable<TokenEntity> GetLambdaCalcTokens(this string exp)
        {
            Token[] tokens = Enum.GetValues(typeof(Token)).OfType<Token>().ToArray();
            foreach (Match m in MathRegex.Matches(exp))
            {
                // Check which token is matched by this match object
                foreach (Token token in tokens)
                {
                    if (m.Groups[token.ToString()].Success)
                    {
                        yield return new TokenEntity(
                            token,
                            m.Index,
                            m.Value);
                    }
                }
            }
            // return the end string token, to indecate we are done
            yield return new TokenEntity(Token.Other, exp.Length, "\0");
        }
    }

    // Holds token info
    internal class TokenEntity
    {
        public TokenEntity(Token token, int startPos, string value)
        {
            this.Token = token;
            this.StartPos = startPos;
            this.Value = value;
        }

        // Token type
        public Token Token { get; private set; }

        // Start position in the original string
        public int StartPos { get; private set; }

        // Value
        public string Value { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} at {1}: {2}", Token, StartPos, Value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            // @"#1: outsorcing outsou outsourcing outsoursing outsurcing;
            //   #2: administración administracióny administracioon administracioón administracón;
            //   #3: personal depersonal dpersonal epersonal integralpersonal personalpara personals;
            //   #4: servicios servicioss serviciosy sservicio sservicios vservicios yservicios;
            //   #5: integrales integral  integralpersonal;
            //   #6: técnicos técnico;
            //   &1: #1;
            //   &2: #2 ° #3;
            //   &3: #4 ° #5;
            //   &4: #4 ° #6; "
            
            foreach (TokenEntity t in @"#1: outsorcing outsou outsourcing outsoursing outsurcing;
               #2: administración administracióny administracioon administracioón administracón;
               #3: personal depersonal dpersonal epersonal integralpersonal personalpara personals;
               #4: servicios servicioss serviciosy sservicio sservicios vservicios yservicios;
               #5: integrales integral  integralpersonal;
               #6: técnicos técnico;
               &1: #1;
               &2: #2 ° #3;
               &3: #4 ° #5;
               &4: #4 ° #6; ".GetLambdaCalcTokens())
            {
                Console.WriteLine(t);
            }

            Console.WriteLine("F I N");
            Console.ReadKey();
        }
    }
}
