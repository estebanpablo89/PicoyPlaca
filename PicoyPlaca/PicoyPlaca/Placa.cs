using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoyPlaca
{
    public class Placa
    {
        int numero;

        public void nuevaPlaca(int nuevaplaca)
        {
            numero = nuevaplaca;
        }
        public int ultimoDigito()
        {
            String test = numero.ToString();
             test = test.Substring(test.Length - 1);
             return Convert.ToInt16(test);
        }
    }
}
