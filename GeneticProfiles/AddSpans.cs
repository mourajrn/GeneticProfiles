using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticProfiles
{
    public partial class AddSpans : Form
    {
        public List<Profile> PossibleProfiles { get; private set; }
        public Span EditingSpan { get; private set; }

        public AddSpans()
        {
            InitializeComponent();

            PossibleProfiles = new List<Profile>();

            foreach (Profile profile in Main.Profiles)
            {
                comboProfiles.Items.Add(profile);
            }

            dataGridProfiles.Columns.Add("Profile", "Profile");
            dataGridProfiles.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            buttonCreateOrModify.Click += buttonCreateSpan_Click;
        }

        public AddSpans(int index)
        {
            InitializeComponent();

            EditingSpan = Main.Spans.GetRange(index, 1).Single();

            PossibleProfiles = EditingSpan.PossibleProfiles;

            textTitle.Text = EditingSpan.Title;
            textLength.Text = EditingSpan.Length.ToString();

            foreach (Profile profile in Main.Profiles)
            {
                comboProfiles.Items.Add(profile);
            }

            dataGridProfiles.Columns.Add("Profile", "Profile");
            dataGridProfiles.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            foreach (Profile profile in PossibleProfiles)
            {
                dataGridProfiles.Rows.Add(profile);
            }

            buttonCreateOrModify.Text = "Modify";

            buttonCreateOrModify.Click += buttonModifySpan_Click;
        }

        private void buttonAssign_Click(object sender, EventArgs e)
        {
            PossibleProfiles.Add(comboProfiles.SelectedItem as Profile);
            dataGridProfiles.Rows.Add(comboProfiles.SelectedItem);

            comboProfiles.Items.Remove(comboProfiles.SelectedItem);
        }

        private void buttonCreateSpan_Click(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ",";
            provider.NumberGroupSeparator = ".";

            Main.Spans.Add(new Span(textTitle.Text, Convert.ToDouble(textLength.Text, provider), PossibleProfiles));

            Close();
        }

        private void buttonModifySpan_Click(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ",";
            provider.NumberGroupSeparator = ".";

            EditingSpan.Modify(textTitle.Text, Convert.ToDouble(textLength.Text, provider), PossibleProfiles);

            MessageBox.Show("Modified");

            Close();
        }

        private void comboProfiles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                buttonAssign_Click(this, EventArgs.Empty);
            }
        }
    }
}
