using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip.Models
{
    public class Moeda
    {
        //Encapsulamento "tradicional"
 /*       private string lado;

       public string Lado { get => lado; set => lado = value; }
*/
        //Criando uma propriedade
        //Utilize o atalho "prop" dê enter e depois troque o nome da propriedade SEMPRE começando com maiúscula

        public string Lado { get; set; }

        public void Sortear()
        {
            Lado = new Random().Next(2).ToString();
            if (Lado == "0")
            {
                Lado = "Cara";
            }
            else
            {
                Lado = "coroa";
            }
        }
    }
}
