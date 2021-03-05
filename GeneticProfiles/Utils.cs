using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticProfiles
{
    public static class Utils
    {
        public static double MultiploSuperior(this double valor, double multiplo) => Math.Ceiling(valor / multiplo) * multiplo;
    }
}
