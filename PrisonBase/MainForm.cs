using PrisonBase.Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonBase
{
    public partial class MainForm : Form
    {
        public static IBase PrisonBase;


        public MainForm()
        {
            PrisonBase = new Elements.PrisonBase("base.txt");
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (PrisonBase.Prisoners.Count != 0)
            {
                Bind();
                InvisibleRows();
            }
           
        }
        private void Bind()
        {
            dataGridView1.DataSource = new int[] { };

            var data = PrisonBase.Prisoners;

            dataGridView1.DataSource = data;
        }

        void InvisibleRows()
        {
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Age"].Visible = false;

            dataGridView1.Columns["Character"].Visible = false;
            dataGridView1.Columns["City"].Visible = false;
            dataGridView1.Columns["City"].Visible = false;
            dataGridView1.Columns["Relatives"].Visible = false;
            dataGridView1.Columns["Term"].Visible = false;
            dataGridView1.Columns["PrisonDate"].Visible = false;
            dataGridView1.Columns["Caste"].Visible = false;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            PrisonBase.SavePrisoner();
            if (dataGridView1.SelectedRows != null)
            {
                panel1.Visible = true;
                Show();
            }
        }

        public void Show()
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int ind = row.Index;
                NameLabel.Text = PrisonBase.Prisoners[ind].Name;
                ArticleLabel.Text = Convert.ToString(PrisonBase.Prisoners[ind].Article);
                RoomLabel.Text = Convert.ToString(PrisonBase.Prisoners[ind].Room);
                AgeLabel.Text = PrisonBase.Prisoners[ind].Age;
                TermLabel.Text = PrisonBase.Prisoners[ind].Term;
                PrisonDateLabel.Text = PrisonBase.Prisoners[ind].PrisonDate;
                CharacterLabel.Text = PrisonBase.Prisoners[ind].Character;
                CityLabel.Text = PrisonBase.Prisoners[ind].City;
                CasteLabel.Text = PrisonBase.Prisoners[ind].Caste;
                RelativesLabel.Text = PrisonBase.Prisoners[ind].Relatives;
                pictureBox1.Image = new Bitmap(PrisonBase.Prisoners[ind].ImageData);

            }
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            form.ShowDialog();
            Bind();
            InvisibleRows();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int ind = row.Index;
                string ind_ = Convert.ToString(ind);
                PrisonBase.DeletePrisoner(ind_);
                Bind();
                InvisibleRows();
                panel1.Visible = false;
            }
        }

        private void ShowInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (dataGridView1.SelectedRows != null)
            {
                panel1.Visible = true;
                Show();
            }
        }

        private void StatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatsForm form = new StatsForm();
            form.ShowDialog();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PrisonBase.SavePrisoner();
            }
        }

        private void StartEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns["Age"].Visible = true;
            dataGridView1.Columns["Character"].Visible = true;
            dataGridView1.Columns["City"].Visible = true;
            dataGridView1.Columns["City"].Visible = true;
            dataGridView1.Columns["Relatives"].Visible = true;
            dataGridView1.Columns["Term"].Visible = true;
            dataGridView1.Columns["PrisonDate"].Visible = true;
            dataGridView1.Columns["Caste"].Visible = true;
        }

        private void StopEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvisibleRows();
        }
    }
}
