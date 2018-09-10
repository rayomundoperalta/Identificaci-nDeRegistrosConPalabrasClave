using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Collections;
using System.Globalization;

namespace IdentificadorRegistros
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
        Other       // Represents unrecognized charachters
    }

    // Scanner used to find the tokens from a calc lampda string expression
    internal static class Scanner
    {
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

        // Enumerable to get tokens from the given expression (scanner)
        public static IEnumerable<TokenEntity> GetTokens(this string exp)
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
            // return the end string token, to indicate we are done
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
            return string.Format("{0} {1}", Token, Value);
        }
    }

    /// <summary>
    /// Lambda expression calculation class
    /// </summary>
    public class IdentificadorRegistros
    {
        public Dictionary<string, HashSet<string>> ListaDeCategorías = new Dictionary<string, HashSet<string>>();
        public Dictionary<string, List<string>> ListaDeConstrucciones = new Dictionary<string, List<string>>();

        TokenEntity lastToken;
        // Holds the tokens enumurator
        IEnumerator<TokenEntity> tokens;
        // Holds the list of parameters in the math equation
        //List<string> parameters;
        // Holds the lampda expression parameter, this is the params double [] args
        //ParameterExpression funcParamsArg = Expression.Parameter(typeof(double[]), "args");
        // Holds the parsed lambda expression
        
        // Holds the compiled delegate 
        //Func function;

        /// <summary>
        /// Initialize the class from the given string expression
        /// </summary>
        /// <param name="exp">Input expression, ie: (a, b) => a + b * 2</param>
        public IdentificadorRegistros(string exp)
        {
            ParseIdentificador(exp);
        }

        private TokenEntity CurrentToken { get { return this.tokens.Current; } }
        private TokenEntity LastToken { get { return this.lastToken; } }

        private bool AdvanceToken()
        {
            this.lastToken = CurrentToken;
            return this.tokens.MoveNext();
        }

        private bool CheckToken(Token token)
        {
            // SOLO AVANZA EL PARSER SI ENCONTRÓ EL TOKEN

            if (CurrentToken != null && CurrentToken.Token == token)
            {
                AdvanceToken();
                return true;
            }
            return false;
        }

        // Parse the given expression, expect ([[[<param1>],<param2>],..]) => <body>
        private void ParseIdentificador(string exp)
        {
            Console.WriteLine("Compilamos la definición de frases para buscar registros de interés");
            this.tokens = exp.GetTokens().GetEnumerator();
            AdvanceToken();

            ParseCategorías();
            ParseCombinaciones();
        }

        private void ParseCategorías()
        {
            while (CheckToken(Token.Categoría))
            {
                HashSet<string> Categoría = new HashSet<string>();
                int NumeroPalabras = 0;
                string NombreCategoria = LastToken.Value;
                if (!CheckToken(Token.Definición))
                    throw GetErrorException("Esperamos ':'", CurrentToken);
                while (CheckToken(Token.PalabraEspañol))
                {
                    NumeroPalabras++;
                    Categoría.Add(LastToken.Value);
                }
                if (!CheckToken(Token.FinDefinición))
                    throw GetErrorException("Esperamos ';'", CurrentToken);
                if (NumeroPalabras == 0)
                {
                    throw GetErrorException("Una Categoría debe tener al menos una palabra", CurrentToken);
                }
                else
                {
                    ListaDeCategorías.Add(NombreCategoria, Categoría);
                }    
            }
        }
        
        private void ParseCombinaciones()
        {
            while (CheckToken(Token.Construcción))
            {
                List<string> CombinaciónDeCategorias = new List<string>();
                int NúmeroDeCategorias = 0;
                string NombreConstrucción;

                NombreConstrucción = LastToken.Value;
                if (!CheckToken(Token.Definición))
                    throw GetErrorException("Esperamos ':'", CurrentToken);
                while (CheckToken(Token.Categoría))
                {
                    NúmeroDeCategorias++;
                    CombinaciónDeCategorias.Add(LastToken.Value);
                }
                if (!CheckToken(Token.FinDefinición))
                    throw GetErrorException("Esperamos ';'", CurrentToken);
                if (NúmeroDeCategorias == 0)
                    throw GetErrorException("Esperamos al menos una categoría por combinación", CurrentToken);
                ListaDeConstrucciones.Add(NombreConstrucción, CombinaciónDeCategorias);
            }
        }

        // Returns back an error exception
        private Exception GetErrorException(string p, TokenEntity tokenEntity)
        {
            return new Exception(string.Format("Error at '{0}': {1}", tokenEntity != null ? tokenEntity.StartPos : 0, p));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IdentificadorRegistros lc = new IdentificadorRegistros(@"#1: outsorcing outsou outsourcing outsoursing outsurcing;
               #2: administración administracióny administracioon administracioón administracón;
               #3: personal depersonal dpersonal epersonal integralpersonal personalpara personals;
               #4: servicios servicioss serviciosy sservicio sservicios vservicios yservicios;
               #5: integrales integral  integralpersonal;
               #6: técnicos técnico;
               &1: #1;
               &2: #2 #3;
               &3: #4 #5;
               &4: #4 #6; ");
            foreach (KeyValuePair<string, HashSet<string>> entry in lc.ListaDeCategorías)
            {
                Console.WriteLine(entry.Key + " " + string.Join(", ", entry.Value));
            }
            

            foreach (KeyValuePair<string, List<string>> entry in lc.ListaDeConstrucciones)
            {
                string contenido = "";
                for (int i = 0; i < entry.Value.Count; i++)
                {
                    contenido += entry.Value[i] + " ";
                }
                Console.WriteLine(entry.Key + " " + contenido);
            }
            Console.WriteLine("T E R M I N A M O S");
            Console.ReadKey();
        }
    }
}
