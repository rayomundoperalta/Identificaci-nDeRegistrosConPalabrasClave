using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Data;
using System.Data.Linq;
using IdentificaciónDeRegistrosConPalabrasClave;
using System.Threading;

namespace RegexExample
{
    static class Program
    {
        static HashSet<string> InventarioPalabras = new HashSet<string>();

        static void CreaInventarioPalabras(string FileName)
        {
            Console.WriteLine("Procesamos " + FileName);
            //FileStream ListaProveedores = new FileStream(Console.ReadLine(), FileMode.Open, FileAccess.Read);
            //StreamReader TodosProveedores = new StreamReader(ListaProveedores, System.Text.Encoding.GetEncoding("iso-8859-1"));

            // TodosProveedores.Close();
            // ListaProveedores.Close();

            //InteligenciaDeMercadoDBDataContext IMData = new InteligenciaDeMercadoDBDataContext();
            //GrecopaDataContext GrecopaDB = new GrecopaDataContext();
            //Console.WriteLine("cargamos la base");
            //var BD = from reg in IMData.Contratos_2017_2018_LT_Convertidos select reg;
            //var BD1 = from reg in GrecopaDB.Contratos2017Limpios select reg;
            //var BD2 = from reg in GrecopaDB.Contratos2017Limpios select reg;

            var myRegex = new Regex(@"[a-zA-ZáéíóúÁÉÍÓÚÑñüÜÇç]+");
            string palabras = File.ReadAllText(FileName);
            //string textoOrig = " ";
            //foreach (var registro in BD)
            //{
            //    textoOrig += registro.TITULO_EXPEDIENTE + " " + registro.TITULO_CONTRATO + " " + registro.PROVEEDOR_CONTRATISTA + " ";
            //}
            //foreach (var registro in BD1)
            //{
            //    textoOrig += registro.PROVEEDOR_CONTRATISTA + " ";
            //}
            //foreach (var registro in BD2)
            //{
            //    textoOrig += registro.PROVEEDOR_CONTRATISTA + " ";
            //}
            //Console.WriteLine(textoOrig);
            Console.WriteLine("Separamos las Palabras");
            //Console.ReadKey();
            MatchCollection AllMatches = myRegex.Matches(palabras);
            if (AllMatches.Count > 0)
            {
                foreach (Match someMatch in AllMatches)
                {
                    if (!InventarioPalabras.Contains(someMatch.Groups[0].Value))
                    {
                        InventarioPalabras.Add(someMatch.Groups[0].Value);
                    }
                }
            }
            
            /*
             * Console.WriteLine("Leemos palabras de la categoria buscada");
            int cuantos = 0;

            HashSet<string> CategoriaDePalabras = new HashSet<string>();

            FileStream pb = new FileStream(@"D:\CompranetAbril2018\palabrasEscogidas.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(pb, System.Text.Encoding.GetEncoding("iso-8859-1"));
            string palabras = sr.ReadToEnd();
            sr.Close();
            pb.Close();
            Console.WriteLine("Las separamos con regex");
            MatchCollection PalabrasEscogidas = myRegex.Matches(palabras);
            Console.WriteLine("Las almacenamos en un HashSet");
            foreach (Match SomeMatch in PalabrasEscogidas)
            {
                CategoriaDePalabras.Add(SomeMatch.Groups[0].Value);
            }
            
            Console.WriteLine("Leemos la BD para buscar los registros de interes");
            */
            /* La idea es simple, obtenemos los campos que pueden tener texto únicamente y usaando la expresión regular sacamos
             * las palabras, buscamos en el hashset y cuando haya una coincidencia seleccionamos el registro
             * este procedimiento debe ser mejorado con el análisis de frecuencias de las palabas para ver si los textos
             * realmente son de interés, vamos a probar por ahora asi en lo que definimos como hacer el paso siguiente
             */

            /*
            //var BD = from reg in IMData.Contratos_2017_2018_LTs select reg;
            if (File.Exists(@"D:\CompranetAbril2018\registrosSeleccionados.txt"))
            {
                File.Delete(@"D:\CompranetAbril2018\registrosSeleccionados.txt");
            }
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\CompranetAbril2018\registrosSeleccionados.txt", false, System.Text.Encoding.GetEncoding("iso-8859-1")))
            {
                file.WriteLine("SEC \t" +
                               "AÑO \t" +
                               "SIGLAS \t" +
                               "DEPENDENCIA \t" +
                               "NOMBRE_DE_LA_UC \t" +
                               "RESPONSABLE \t" +
                               "TITULO_EXPEDIENTE \t" +
                               "NUMERO_PROCEDIMIENTO \t" +
                               "TIPO_CONTRATACION \t" +
                               "TIPO_PROCEDIMIENTO \t" +
                               "FORMA_PROCEDIMIENTO \t" +
                               "TITULO_CONTRATO \t" +
                               "FECHA_FIN \t" +
                               "IMPORTE_CONTRATO \t" +
                               "PROVEEDOR_CONTRATISTA \t" +
                               "ANUNCIO");
                foreach (var registro in BD)
                {
                    string texto = registro.TITULO_EXPEDIENTE + " " + registro.TITULO_CONTRATO + " " + registro.PROVEEDOR_CONTRATISTA;
                    MatchCollection PalabrasRegistro = myRegex.Matches(texto);

                    foreach (Match palabraRegistro in PalabrasRegistro)
                    {
                        if (CategoriaDePalabras.Contains(palabraRegistro.Groups[0].Value))
                        {

                            string regSeleccionado =
                                registro.SEC.ToString() + " \t" +
                                registro.AÑO.ToString() + " \t" +
                                registro.SIGLAS + " \t" +
                                registro.DEPENDENCIA + " \t" +
                                registro.NOMBRE_DE_LA_UC + " \t" +
                                registro.RESPONSABLE + " \t" +
                                registro.TITULO_EXPEDIENTE + " \t" +
                                registro.NUMERO_PROCEDIMIENTO + " \t" +
                                registro.TIPO_CONTRATACION + " \t" +
                                registro.TIPO_PROCEDIMIENTO + " \t" +
                                registro.FORMA_PROCEDIMIENTO + " \t" +
                                registro.TITULO_CONTRATO + " \t" +
                                registro.FECHA_FIN + " \t" +
                                registro.IMPORTE_CONTRATO + " \t" +
                                registro.PROVEEDOR_CONTRATISTA + " \t" +
                                registro.ANUNCIO + " ";
                            file.WriteLine(regSeleccionado);
                            //file.WriteLine(palabraRegistro.Groups[0].Value);
                            if (registro.SEC == 35836 && registro.AÑO == 2017)
                            {
                                Console.WriteLine(regSeleccionado);
                                Console.WriteLine(registro.RESPONSABLE);

                                String sal = registro.TITULO_EXPEDIENTE;
                                if (sal[0] == 8220)
                                {
                                    Console.WriteLine("si son comillas ");
                                }
                                else
                                {
                                    Console.WriteLine("--------------- No son iguales {0}-{1}", (int) sal[0], (int) '"');
                                }
                                byte[] ba = System.Text.Encoding.Default.GetBytes(sal);
                                Console.WriteLine(sal);
                                var hexString = BitConverter.ToString(ba);
                                Console.WriteLine(hexString);
                                Console.WriteLine(sal);
                            }
                            cuantos++;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("Terminado " + cuantos);
            Console.ReadKey();
            */
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Empezamos con la lectura de BD");
            ExtracionCamposContratosAPF contratosTexto = new ExtracionCamposContratosAPF();
            Thread t2012 = new Thread(new ThreadStart(contratosTexto.Extrae2012));
            Thread t2013 = new Thread(new ThreadStart(contratosTexto.Extrae2013));
            Thread t2014 = new Thread(new ThreadStart(contratosTexto.Extrae2014));
            Thread t2015 = new Thread(new ThreadStart(contratosTexto.Extrae2015));
            Thread t2016 = new Thread(new ThreadStart(contratosTexto.Extrae2016));
            Thread t2017 = new Thread(new ThreadStart(contratosTexto.Extrae2017));
            Thread t2018 = new Thread(new ThreadStart(contratosTexto.Extrae2018));

            t2012.Start();
            t2013.Start();
            t2014.Start();
            t2015.Start();
            t2016.Start();
            t2017.Start();
            t2018.Start();

            t2012.Join();
            t2013.Join();
            t2014.Join();
            t2015.Join();
            t2016.Join();
            t2017.Join();
            t2018.Join();

            Console.WriteLine("Inventario de Palabras de la base de datos\nDame nombre de archivo:");

            CreaInventarioPalabras(@"D:\AnalisisPalabrasAPF\Palabras2012.txt");
            CreaInventarioPalabras(@"D:\AnalisisPalabrasAPF\Palabras2013.txt");
            CreaInventarioPalabras(@"D:\AnalisisPalabrasAPF\Palabras2014.txt");
            CreaInventarioPalabras(@"D:\AnalisisPalabrasAPF\Palabras2015.txt");
            CreaInventarioPalabras(@"D:\AnalisisPalabrasAPF\Palabras2016.txt");
            CreaInventarioPalabras(@"D:\AnalisisPalabrasAPF\Palabras2017.txt");
            CreaInventarioPalabras(@"D:\AnalisisPalabrasAPF\Palabras2018.txt");

            Console.WriteLine("Terminamos inventario");
            Console.WriteLine("Escribimos el inventario de palabras");
            List<string> ListaInventarioPalabras = new List<string>();

            foreach (string palabra in InventarioPalabras)
            {
                ListaInventarioPalabras.Add(palabra);
            }
            ListaInventarioPalabras.Sort();
            using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"D:\AnalisisPalabrasAPF\Inventario.txt"))
            {
                foreach (string palabra in ListaInventarioPalabras)
                {
                    if (palabra.Length > 2)
                    {
                        file.WriteLine(palabra);
                    }
                }
            }

            Console.WriteLine("Acabamos inventarios");
            Console.ReadKey();
        }
    }
}


