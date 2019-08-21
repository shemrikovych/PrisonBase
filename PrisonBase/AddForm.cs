using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonBase
{
   
    public partial class AddForm : Form
    {
        public string im;
        public Prisoner Prisoner { private set; get; }
      
        public AddForm()
        {
            InitializeComponent();
           
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string article = "1";
            string room = RoomBox.Text;
            string age = AgeBox.Text;
            string character = CharacterBox.Text;
            string city = CityBox.Text;
            string relatives = RelativesBox.Text;
            string term = TermBox.Text;
            string prisondate = PrisonDateBox.Text;
            string caste = CasteBox.Text;
            string imageData = im;
            if (string.IsNullOrWhiteSpace(NameBox.Text) || string.IsNullOrWhiteSpace(ArticleBox.Text) ||
                string.IsNullOrWhiteSpace(RoomBox.Text) || string.IsNullOrWhiteSpace(AgeBox.Text) ||
                string.IsNullOrWhiteSpace(CharacterBox.Text) || string.IsNullOrWhiteSpace(CityBox.Text)||
                string.IsNullOrWhiteSpace(RelativesBox.Text) || string.IsNullOrWhiteSpace(RelativesBox.Text)||
                string.IsNullOrWhiteSpace(TermBox.Text) || string.IsNullOrWhiteSpace(PrisonDateBox.Text)||
                string.IsNullOrWhiteSpace(CasteBox.Text) || string.IsNullOrWhiteSpace(im))
            {
                DialogResult = DialogResult.None;
                Label.Text = "Заполните все поля";
                return;
            }

            if (IsDigitsOnly(ArticleBox.Text) == false)
            {

                DialogResult = DialogResult.None;
                Label.Text = "Введите существующий номер статьи";
                return;

            }
            else
            {
                if (Convert.ToInt32(ArticleBox.Text) > 0 && Convert.ToInt32(ArticleBox.Text) <= 447)
                {
                    article = ArticleBox.Text;
                }
                else
                {
                    DialogResult = DialogResult.None;
                    Label.Text = "Введите существующую статью";
                    return;

                }

            }

            if (IsDigitsOnly(RoomBox.Text) == false)
            {

                DialogResult = DialogResult.None;
                Label.Text = "Введите существующий номер камеры";
                return;

            }
            else
            {
                if (Convert.ToInt32(RoomBox.Text) > 0 && Convert.ToInt32(RoomBox.Text) <= 530)
                {
                    article = ArticleBox.Text;
                }
                else
                {
                    DialogResult = DialogResult.None;
                    Label.Text = "Введите существующий номер камеры";
                    return;

                }
             }

     Prisoner = new Prisoner(name, article, room, age,
                         character,  city, relatives,
                         term,  prisondate, caste, imageData);
            MainForm.PrisonBase.AddPrisoner(Prisoner);
            Close();
            
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG;)|*.BMP;*.JPG;*.PNG;|All files (*.*)| *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                    im = ofd.FileName;
                }
                catch
                {
                    MessageBox.Show("Не удалось открыть данный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }

        private void CanselButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
