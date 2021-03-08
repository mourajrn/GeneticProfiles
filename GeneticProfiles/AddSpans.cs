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
        public List<Span> Spans { get; private set; }
        public Span EditingSpan { get; private set; }

        public AddSpans(List<Span> spans)
        {
            InitializeComponent();

            Spans = spans;

            PossibleProfiles = new List<Profile>();

            foreach (Profile profile in Main.Profiles)
            {
                comboProfiles.Items.Add(profile);
            }

            dataGridProfiles.Columns.Add("Profile", "Profile");
            dataGridProfiles.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            buttonCreateOrModify.Click += buttonCreateSpan_Click;

            comboProfiles.SelectedIndex = 0;
        }

        public AddSpans(List<Span> spans, int index)
        {
            InitializeComponent();

            Spans = spans;

            EditingSpan = Spans.GetRange(index, 1).Single();

            PossibleProfiles = EditingSpan.PossibleProfiles;

            textTitle.Text = EditingSpan.Title;
            textLength.Text = EditingSpan.Length.ToString();

            foreach (Profile profile in Main.Profiles.Where(p => !PossibleProfiles.Contains(p)))
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

            comboProfiles.SelectedIndex = 0;
        }

        private void buttonAssign_Click(object sender, EventArgs e)
        {
            PossibleProfiles.Add(comboProfiles.SelectedItem as Profile);
            dataGridProfiles.Rows.Add(comboProfiles.SelectedItem);

            comboProfiles.Items.Remove(comboProfiles.SelectedItem);

            comboProfiles.SelectedIndex = 0;
        }

        private void buttonCreateSpan_Click(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ",";
            provider.NumberGroupSeparator = ".";

            Spans.Add(new Span(textTitle.Text, Convert.ToDouble(textLength.Text, provider), PossibleProfiles));

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
            if (e.KeyChar == (char)43)
            {
                buttonAssign_Click(this, EventArgs.Empty);
            }
        }

        private void buttonRemoveProfile_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGridProfiles.SelectedRows;

            List<Profile> backupList = new List<Profile>(PossibleProfiles);

            foreach (DataGridViewRow row in rows)
                PossibleProfiles.Remove(backupList.GetRange(row.Index, 1).Single());

            comboProfiles.Items.Clear();

            foreach (Profile profile in Main.Profiles.Where(p => !PossibleProfiles.Contains(p)))
            {
                comboProfiles.Items.Add(profile);
            }

            dataGridProfiles.Rows.Clear();

            foreach (Profile profile in PossibleProfiles)
            {
                dataGridProfiles.Rows.Add(profile);
            }

            comboProfiles.SelectedIndex = 0;
        }

        private void dataGridProfiles_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridProfiles.SelectedRows.Count > 0)
                buttonRemoveProfile.Enabled = true;
            else
                buttonRemoveProfile.Enabled = false;
        }

        private void CreateSpanAndStartOther()
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ",";
            provider.NumberGroupSeparator = ".";

            string title = textTitle.Text;

            Spans.Add(new Span(title, Convert.ToDouble(textLength.Text, provider), PossibleProfiles));

            textTitle.Clear();
            textLength.Clear();

            PossibleProfiles = new List<Profile>();

            comboProfiles.Items.Clear();

            foreach (Profile profile in Main.Profiles)
            {
                comboProfiles.Items.Add(profile);
            }

            dataGridProfiles.Rows.Clear();

            int size = title.Length;

            string prefix = title.Substring(0, 1);

            int number = Convert.ToInt32(title.Substring(1, size - 1));

            textTitle.Text = $"{prefix}{(number + 1)}";

            textLength.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Enter))
            {
                buttonCreateSpan_Click(this, EventArgs.Empty);
            }

            if (keyData == (Keys.Control | Keys.Right))
            {
                CreateSpanAndStartOther();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void dataGridProfiles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)45)
            {
                buttonRemoveProfile_Click(this, EventArgs.Empty);
            }
        }
    }
}
