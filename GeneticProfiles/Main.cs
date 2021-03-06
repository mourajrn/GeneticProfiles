﻿using GeneticSharp.Domain.Chromosomes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GeneticProfiles
{
    public partial class Main : Form
    {
        public static List<Profile> Profiles = new List<Profile>();
        public List<Span> Spans = new List<Span>();

        public Main()
        {
            InitializeComponent();

            try
            {
                using (var sr = new StreamReader("Perfis.csv"))
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

            IChromosome bestChromosome = solver.Solve(Spans);

            int counter = 0;

            foreach (Gene gene in bestChromosome.GetGenes())
            {
                dataGridSpans.Rows[counter].Cells[3].Value = (gene.Value as GeneValue).Profile;
                counter++;
            }

            labelTotalWeight.Text = $"{1 / bestChromosome.Fitness} kg";

            MessageBox.Show("Process finished", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAddSpan_Click(object sender, EventArgs e)
        {
            new AddSpans(Spans).ShowDialog();
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

            new AddSpans(Spans, index).ShowDialog();

            UpdateDataGrid();
        }

        private void dataGridSpans_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridSpans.SelectedRows.Count.Equals(0))
            {
                buttonEditSpan.Enabled = false;
                buttonBatchProfiles.Enabled = false;
                buttonRemoveSpan.Enabled = false;
            }
            
            if (dataGridSpans.SelectedRows.Count.Equals(1))
            {
                buttonEditSpan.Enabled = true;
                buttonBatchProfiles.Enabled = true;
                buttonRemoveSpan.Enabled = true;
            }

            if (dataGridSpans.SelectedRows.Count > 1)
            {
                buttonEditSpan.Enabled = false;
                buttonBatchProfiles.Enabled = true;
                buttonRemoveSpan.Enabled = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Enter))
            {
                buttonSolve_Click(this, EventArgs.Empty);
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void buttonRemoveSpan_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGridSpans.SelectedRows;

            List<Span> backupList = new List<Span>(Spans);

            foreach (DataGridViewRow row in rows)
                Spans.Remove(backupList.GetRange(row.Index, 1).Single());

            UpdateDataGrid();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string output = JsonConvert.SerializeObject(Spans);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter file = new StreamWriter(saveFileDialog.FileName))
                {
                    file.Write(output);
                }
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader file = new StreamReader(openFileDialog.FileName))
                {
                    string input = file.ReadToEnd();
                    List<Span> deserializedSpans = JsonConvert.DeserializeObject<List<Span>>(input);

                    Spans = deserializedSpans;
                }
            }

            UpdateDataGrid();
        }

        private void buttonBatchProfiles_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGridSpans.SelectedRows;

            new BatchProfile(Spans, rows).ShowDialog();

            UpdateDataGrid();
        }
    }
}
