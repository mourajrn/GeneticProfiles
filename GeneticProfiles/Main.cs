using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticProfiles
{
    public partial class Main : Form
    {
        public static List<Profile> Profiles = new List<Profile>();

        public Main()
        {
            InitializeComponent();

            try
            {
                using (var sr = new StreamReader("C:/Users/Pichau/Desktop/Perfis.csv"))
                {
                    string ln;

                    NumberFormatInfo provider = new NumberFormatInfo();
                    provider.NumberDecimalSeparator = ".";
                    provider.NumberGroupSeparator = ",";

                    while ((ln = sr.ReadLine()) != null)
                    {
                        string name = ln.Split(';')[0];
                        double weight = Convert.ToDouble(ln.Split(';')[1], provider);

                        Profiles.Add(new Profile(name, weight));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            Solver solver = new Solver();

            solver.Solve();
        }
    }
}
