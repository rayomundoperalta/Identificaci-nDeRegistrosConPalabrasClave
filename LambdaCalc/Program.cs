﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Collections;
using System.Globalization;
using System.Threading;
using System.ComponentModel;

namespace IdentificacionRegistros
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
        private Dictionary<string, string[]> ListaDeCategorías = new Dictionary<string, string[]>();
        private Dictionary<string, List<string>> ListaDeConstrucciones = new Dictionary<string, List<string>>();
        private HashSet<string> InventarioPalabras = new HashSet<string>();
        private string[] ArrayDePalabrasDelInventario;
        private int MínimoPalabras = 0;
        private int MáximoPalabras = 0;

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
            Console.WriteLine("Compilamos la definición de frases para buscar registros de interés");
            this.tokens = exp.GetTokens().GetEnumerator();
            AdvanceToken();

            Console.WriteLine(exp);
            

            ParseCategorías();
            DisplaySet(InventarioPalabras);
            ParseCombinaciones();

            foreach (KeyValuePair<string, String[]> entry in ListaDeCategorías)
            {
                Console.WriteLine(entry.Key + " " + string.Join(", ", entry.Value));
            }

            foreach (KeyValuePair<string, List<string>> entry in ListaDeConstrucciones)
            {
                string contenido = "";
                for (int i = 0; i < entry.Value.Count; i++)
                {
                    contenido += entry.Value[i] + " ";
                }
                Console.WriteLine(entry.Key + " " + contenido);
            }

            Console.WriteLine("C o m p i l a d o");
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

        private void ParseCategorías()
        {
            while (CheckToken(Token.Categoría))
            {
                string[] Categoría = new string[] { };
                string NombreCategoria = LastToken.Value;
                if (!CheckToken(Token.Definición))
                    throw GetErrorException("Esperamos ':'", CurrentToken);
                while (CheckToken(Token.PalabraEspañol))
                {
                    Array.Resize(ref Categoría, Categoría.Length + 1);
                    Categoría[Categoría.Length - 1] = LastToken.Value;
                   
                    if (!InventarioPalabras.Contains(LastToken.Value)) InventarioPalabras.Add(LastToken.Value);
                }
                if (!CheckToken(Token.FinDefinición))
                    throw GetErrorException("Esperamos ';'", CurrentToken);
                if (Categoría.Length == 0)
                {
                    throw GetErrorException("Una Categoría debe tener al menos una palabra", CurrentToken);
                }
                else
                {
                    ListaDeCategorías.Add(NombreCategoria, Categoría);
                    ArrayDePalabrasDelInventario = InventarioPalabras.ToArray<string>();
                }    
            }
        }
        
        private void ParseCombinaciones()
        {
            while (CheckToken(Token.Construcción))
            {
                List<string> CombinaciónDeCategorias = new List<string>();
                string NombreConstrucción;

                NombreConstrucción = LastToken.Value;
                if (!CheckToken(Token.Definición))
                    throw GetErrorException("Esperamos ':'", CurrentToken);
                while (CheckToken(Token.Categoría))
                {
                    CombinaciónDeCategorias.Add(LastToken.Value);
                }
                if (!CheckToken(Token.FinDefinición))
                    throw GetErrorException("Esperamos ';'", CurrentToken);
                if (CombinaciónDeCategorias.Count == 0)
                {
                    throw GetErrorException("Esperamos al menos una categoría por combinación", CurrentToken);
                }
                else
                {
                    ListaDeConstrucciones.Add(NombreConstrucción, CombinaciónDeCategorias);
                    if (CombinaciónDeCategorias.Count < MínimoPalabras) MínimoPalabras = CombinaciónDeCategorias.Count;
                    if (CombinaciónDeCategorias.Count > MáximoPalabras) MáximoPalabras = CombinaciónDeCategorias.Count;
                }
            }
        }

        // Returns back an error exception
        private Exception GetErrorException(string p, TokenEntity tokenEntity)
        {
            return new Exception(string.Format("Error at '{0}': {1}", tokenEntity != null ? tokenEntity.StartPos : 0, p));
        }

        public bool RegistroCalifica(string registro)
        {
            var myRegex = new Regex(@"[a-zA-ZáéíóúÁÉÍÓÚÑñüÜÇç]+");
            MatchCollection PalabrasRegistro = myRegex.Matches(registro.ToLower());
            HashSet<string> inventario = new HashSet<string>(ArrayDePalabrasDelInventario);
            HashSet<string> PalabrasPresentes = new HashSet<string>();
            foreach (Match palabraRegistro in PalabrasRegistro)
            {
                PalabrasPresentes.Add(palabraRegistro.Groups[0].Value.ToLower());
            }

            inventario.IntersectWith(PalabrasPresentes);
            
            if (inventario.Any<string>())
            {
                foreach(KeyValuePair<string, List<string>> entry in ListaDeConstrucciones)
                {
                    bool completa = true;
                    string conjuntos = "";
                    foreach(string NombreCategoria in entry.Value)
                    {
                        inventario = new HashSet<string>(PalabrasPresentes);
                        HashSet<string> PalabrasCategoria = new HashSet<string>(ListaDeCategorías[NombreCategoria]);
                        inventario.IntersectWith(PalabrasCategoria);
                        conjuntos += SetToString(inventario);
                        completa &= inventario.Any<string>();
                    }
                    if (completa)
                    {
                        Console.WriteLine(conjuntos + " " + registro);
                        return completa;
                    }
                    else
                    {
                        completa = false;
                    }
                       
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        private static void DisplaySet(HashSet<string> set)
        {
            Console.Write("{");
            foreach (string str in set)
            {
                Console.Write(" {0}", str);
            }
            Console.WriteLine(" }");
        }

        private static string SetToString(HashSet<string> set)
        {
            string result = "{";
            foreach (string str in set)
            {
                result += " " + str;
            }
            result += " } ";
            return result;
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
            
            Console.ReadKey();
        }
    }
}
