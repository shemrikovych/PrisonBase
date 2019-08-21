using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonBase
{
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            PrisonerLabel.Visible = false;
            RoomLabel.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                string point = textBox1.Text;
                int count = 0;
                for (int i = 0; i < MainForm.PrisonBase.Prisoners.Count; i++)
                {
                    if (MainForm.PrisonBase.Prisoners[i].Article == point)
                    {
                        count++;
                    }
                }
                PrisonerLabel.Visible = true;
                PrisonerLabel.Text = Convert.ToString(count);
            }    
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                string point = textBox2.Text;
                int count = 0;
                for (int i = 0; i < MainForm.PrisonBase.Prisoners.Count; i++)
                {
                    if (MainForm.PrisonBase.Prisoners[i].Room == point)
                    {
                        count++;
                    }
                }
                RoomLabel.Visible = true;
                RoomLabel.Text = Convert.ToString(count);
            }
        }
    }
}
