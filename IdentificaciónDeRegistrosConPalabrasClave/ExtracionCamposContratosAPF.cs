using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.IO;


namespace IdentificaciónDeRegistrosConPalabrasClave
{
    class ExtracionCamposContratosAPF
    {
        public void Extrae2012()
        {
            long i = 1;
            ContratosCompranetDataContext contratosDataContext = new ContratosCompranetDataContext();
            var data = from contrato in contratosDataContext.Contratos where contrato.AÑO == 2012 select contrato;
            using (System.IO.StreamWriter file =
                   new System.IO.StreamWriter(@"D:\AnalisisPalabrasAPF\Palabras2012.txt"))
            {
                foreach (var contrato in data)
                {
                    file.WriteLine((contrato.DEPENDENCIA + " " + contrato.NOMBRE_DE_LA_UC + " " + contrato.RESPONSABLE + " " + contrato.TITULO_EXPEDIENTE + " " +
                        contrato.TITULO_CONTRATO + " " + contrato.PROVEEDOR_CONTRATISTA + " ").ToLower());
                    Console.Write("2012 " + i + "\r");
                    i++;
                }
            }  
        }

        public void Extrae2013()
        {
            long i = 1;
            ContratosCompranetDataContext contratosDataContext = new ContratosCompranetDataContext();
            var data = from contrato in contratosDataContext.Contratos where contrato.AÑO == 2013 select contrato;
            using (System.IO.StreamWriter file =
                   new System.IO.StreamWriter(@"D:\AnalisisPalabrasAPF\Palabras2013.txt"))
            {
                foreach (var contrato in data)
                {
                    file.WriteLine((contrato.DEPENDENCIA + " " + contrato.NOMBRE_DE_LA_UC + " " + contrato.RESPONSABLE + " " + contrato.TITULO_EXPEDIENTE + " " +
                        contrato.TITULO_CONTRATO + " " + contrato.PROVEEDOR_CONTRATISTA + " ").ToLower());
                    Console.Write("2013 " + i + "\r");
                    i++;
                }
            }
        }

        public void Extrae2014()
        {
            long i = 1;
            ContratosCompranetDataContext contratosDataContext = new ContratosCompranetDataContext();
            var data = from contrato in contratosDataContext.Contratos where contrato.AÑO == 2014 select contrato;
            using (System.IO.StreamWriter file =
                   new System.IO.StreamWriter(@"D:\AnalisisPalabrasAPF\Palabras2014.txt"))
            {
                foreach (var contrato in data)
                {
                    file.WriteLine((contrato.DEPENDENCIA + " " + contrato.NOMBRE_DE_LA_UC + " " + contrato.RESPONSABLE + " " + contrato.TITULO_EXPEDIENTE + " " +
                        contrato.TITULO_CONTRATO + " " + contrato.PROVEEDOR_CONTRATISTA + " ").ToLower());
                    Console.Write("2014 " + i + "\r");
                    i++;
                }
            }
        }

        public void Extrae2015()
        {
            long i = 1;
            ContratosCompranetDataContext contratosDataContext = new ContratosCompranetDataContext();
            var data = from contrato in contratosDataContext.Contratos where contrato.AÑO == 2015 select contrato;
            using (System.IO.StreamWriter file =
                   new System.IO.StreamWriter(@"D:\AnalisisPalabrasAPF\Palabras2015.txt"))
            {
                foreach (var contrato in data)
                {
                    file.WriteLine((contrato.DEPENDENCIA + " " + contrato.NOMBRE_DE_LA_UC + " " + contrato.RESPONSABLE + " " + contrato.TITULO_EXPEDIENTE + " " +
                        contrato.TITULO_CONTRATO + " " + contrato.PROVEEDOR_CONTRATISTA + " ").ToLower());
                    Console.Write("2015 " + i + "\r");
                    i++;
                }
            }
        }

        public void Extrae2016()
        {
            long i = 1;
            ContratosCompranetDataContext contratosDataContext = new ContratosCompranetDataContext();
            var data = from contrato in contratosDataContext.Contratos where contrato.AÑO == 2016 select contrato;
            using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"D:\AnalisisPalabrasAPF\Palabras2016.txt"))
            {
                foreach (var contrato in data)
                {
                    file.WriteLine((contrato.DEPENDENCIA + " " + contrato.NOMBRE_DE_LA_UC + " " + contrato.RESPONSABLE + " " + contrato.TITULO_EXPEDIENTE + " " +
                        contrato.TITULO_CONTRATO + " " + contrato.PROVEEDOR_CONTRATISTA + " ").ToLower());
                    Console.Write("2016 " + i + "\r");
                    i++;
                }
            }
        }

        public void Extrae2017()
        {
            long i = 1;
            ContratosCompranetDataContext contratosDataContext = new ContratosCompranetDataContext();
            var data = from contrato in contratosDataContext.Contratos where contrato.AÑO == 2017 select contrato;
            using (System.IO.StreamWriter file =
                   new System.IO.StreamWriter(@"D:\AnalisisPalabrasAPF\Palabras2017.txt"))
            {
                foreach (var contrato in data)
                {
                    file.WriteLine((contrato.DEPENDENCIA + " " + contrato.NOMBRE_DE_LA_UC + " " + contrato.RESPONSABLE + " " + contrato.TITULO_EXPEDIENTE + " " +
                        contrato.TITULO_CONTRATO + " " + contrato.PROVEEDOR_CONTRATISTA + " ").ToLower());
                    Console.Write("2017 " + i + "\r");
                    i++;
                }
            }
        }

        public void Extrae2018()
        {
            long i = 1;
            ContratosCompranetDataContext contratosDataContext = new ContratosCompranetDataContext();
            var data = from contrato in contratosDataContext.Contratos where contrato.AÑO == 2018 select contrato;
            using (System.IO.StreamWriter file =
                   new System.IO.StreamWriter(@"D:\AnalisisPalabrasAPF\Palabras2018.txt"))
            {
                foreach (var contrato in data)
                {
                    file.WriteLine((contrato.DEPENDENCIA + " " + contrato.NOMBRE_DE_LA_UC + " " + contrato.RESPONSABLE + " " + contrato.TITULO_EXPEDIENTE + " " +
                        contrato.TITULO_CONTRATO + " " + contrato.PROVEEDOR_CONTRATISTA + " ").ToLower());
                    Console.Write("2018 " + i + "\r");
                    i++;
                }
            }
        }
    }
}
