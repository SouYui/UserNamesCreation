using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Pruebas
{
    class Program
    {   
        static string SinTildes(string texto) => new String(
            texto.Normalize(NormalizationForm.FormD)
            .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
            .ToArray()).Normalize(NormalizationForm.FormC);

        static void Main(string[] args)
        {
            string CreateUserName(string nombre) {
                string sinTild = SinTildes(nombre);
                string[] divisionEspacios = sinTild.Split();
                string userName = "";

                foreach (var name in divisionEspacios) {
                    if(name.Length > 2) {
                        var substring = name.Substring(0, 3);
                        userName += substring;
                    } else {
                        var substring = "";
                        userName += substring;
                    }
                    
                }

                if (userName != "") {
                    return userName;
                } else {
                    return "";
                }
            }

            var nombreUno = "Daniel Arturo de Arreola de Gómez";
            var nombreDos = "Lorena Peralta Álvarez";
            var userName = CreateUserName(nombreUno);
            var userNameDos = CreateUserName(nombreDos);
            Console.WriteLine(userName);
            Console.WriteLine(userNameDos);
        }
    }
}
