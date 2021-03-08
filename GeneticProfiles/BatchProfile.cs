using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticProfiles
{
    public partial class BatchProfile : Form
    {
        public List<Span> Spans { get; private set; }

        public DataGridViewSelectedRowCollection Rows { get; private set; }

        public BatchProfile(List<Span> spans, DataGridViewSelectedRowCollection rows)
        {
            InitializeComponent();

            Spans = spans;

            Rows = rows;

            foreach (Profile profile in Main.Profiles)
            {
                comboProfiles.Items.Add(profile);
            }

            comboProfiles.SelectedIndex = 0;
        }

        private void buttonAddProfile_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Rows)
            {
                Span span = Spans.GetRange(row.Index, 1).Single();
                span.AddProfile(comboProfiles.SelectedItem as Profile);
            }
            Close();
        }

        private void buttonRemoveProfile_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Rows)
            {
                Span span = Spans.GetRange(row.Index, 1).Single();
                span.RemoveProfile(comboProfiles.SelectedItem as Profile);
            }
            Close();
        }
    }
}
