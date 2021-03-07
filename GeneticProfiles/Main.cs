using GeneticSharp.Domain.Chromosomes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace GeneticProfiles
{
    public partial class Main : Form
    {
        public static List<Profile> Profiles = new List<Profile>();
        public static List<Span> Spans = new List<Span>();

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
                MessageBox.Show(e.Message);
            }

            dataGridSpans.Columns.Add("Title", "Title");
            dataGridSpans.Columns.Add("Length", "Length");
            dataGridSpans.Columns.Add("Possibles", "Possibles");
            dataGridSpans.Columns.Add("Solution", "Solution");
            dataGridSpans.Columns[0].Width = 50;
            dataGridSpans.Columns[1].Width = 50;
            dataGridSpans.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridSpans.Columns[3].Width = 100;
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            Solver solver = new Solver();

            IChromosome bestChromosome = solver.Solve();

            int counter = 0;

            foreach (Gene gene in bestChromosome.GetGenes())
            {
                dataGridSpans.Rows[counter].Cells[3].Value = (gene.Value as GeneValue).Profile;
                counter++;
            }

            labelTotalWeight.Text = $"{1 / bestChromosome.Fitness} kg";
        }

        private void buttonAddSpan_Click(object sender, EventArgs e)
        {
            new AddSpans().ShowDialog();
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            dataGridSpans.Rows.Clear();

            int counter = 0;

            foreach (Span span in Spans)
            {
                dataGridSpans.Rows.Add();
                dataGridSpans.Rows[counter].Cells[0].Value = span.Title;
                dataGridSpans.Rows[counter].Cells[1].Value = span.Length;

                string profiles = "";

                int profileCounter = 0;

                foreach (Profile profile in span.PossibleProfiles)
                {
                    if (profileCounter.Equals(0))
                    {
                        profiles = profile.ToString();
                    }
                    else
                    {
                        profiles += $", {profile}";
                    }
                    profileCounter++;
                }

                dataGridSpans.Rows[counter].Cells[2].Value = profiles;
                counter++;
            }
        }

        private void buttonEditSpan_Click(object sender, EventArgs e)
        {
            int index = dataGridSpans.CurrentCell.RowIndex;

            new AddSpans(index).ShowDialog();
        }
    }
}
