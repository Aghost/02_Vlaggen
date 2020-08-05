using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _02_vlaggen
{
    struct imgStruct
    {
        public String imgName;
        public int imgIndex;
        public int errorCount;
    }

    public partial class Form1 : Form
    {
        static string imgPath = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()
                        + "\\img\\";    // `cd ../img | bash`
        int imgCount = Directory.GetFiles($"{imgPath}", "*.svg").Length;
        int totalCorrect = 0;
        int totalFailed = 0;
        int points = 0;
        
        string currentImage = "";
        int currentIndex = 0;

        imgStruct[] imgArray = null;

        public Form1()
        {
            InitializeComponent();
            Load_Images();
            btn_next_Click(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_guess_Click(sender, new EventArgs());
                e.SuppressKeyPress = true;
            }

        }

        private void Load_Images()
        {
            imgArray = new imgStruct[imgCount];
            Update_Label();

            DirectoryInfo d = new DirectoryInfo(imgPath);

            int icnt = 0;
            foreach (var file in d.GetFiles("*.svg"))
            {
                imgArray[icnt].imgName = file.Name;
                imgArray[icnt].imgIndex = icnt;
                imgArray[icnt].errorCount = 5;

                icnt += 1;
            }

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            btn_Start.Visible = false;
        }

        private void Update_Label()
        {
            imgCount = imgArray.Length;
            lbl_Total.Text = $"Total Images: {imgCount}\n\rCorrect: {totalCorrect}\n\rFailed: {totalFailed}";
            lblScore.Text = "Score = \t\t\t" + points.ToString() + "\r\nPotential Points = \t\t+" + imgArray[currentIndex].errorCount;
        }

        private void Array_Remove()
        {
            var imagelist = imgArray.ToList();
            imagelist.RemoveAt(currentIndex);
            imgArray = imagelist.ToArray();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (currentIndex != 0) { currentIndex -= 1; }

            currentImage = imgArray[currentIndex].imgName;
            imageBox.Url = new Uri($"{imgPath}{currentImage}");
            Update_Label();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (currentIndex != imgCount - 1) { currentIndex += 1; }
            else { currentIndex = 0; }
            
            currentImage = imgArray[currentIndex].imgName;
            imageBox.Url = new Uri($"{imgPath}{currentImage}");
            Update_Label();
        }

        private void btn_guess_Click(object sender, EventArgs e)
        {
            string answer = imageBox.Url.ToString().Split('.').First().Split('/').Last().Remove(0, 8).Replace('_', ' ');
   
            if (textBox.Text == answer || textBox.Text == answer.ToLower())
            {
                points += imgArray[currentIndex].errorCount;
                
                var imagelist = imgArray.ToList();
                imagelist.RemoveAt(currentIndex);
                imgArray = imagelist.ToArray();

                lbl_Status.Text = $"{answer} is correct!";
                lbl_Status.ForeColor = Color.Green;

                textBox.Text = "";
                totalCorrect += 1;

                btn_prev_Click(sender, e);
            }
            else if (imgArray[currentIndex].errorCount == 1)
            {
                lbl_Status.Text = $"The answer was:\n\r{answer}";

                totalFailed += 1;
                Array_Remove();
                btn_prev_Click(sender, e);
            }
            else
            {
                StringBuilder charray = new StringBuilder(answer);
                int length = answer.Length;

                imgArray[currentIndex].errorCount -= 1;

                int x = 0;
                while (x < length)
                {
                    charray[x] = ('_');
                    x++;
                }

                Random randi = new Random();
                int y = randi.Next(0, length);
                charray[y] = answer[y];

                lbl_Status.Text = $"Incorrect... \r\nHint: {charray} {x}";
                lbl_Status.ForeColor = Color.Red;
            }
            Update_Label();

        }
        
        private void resizeSvg_Click(object sender, EventArgs e)
        {
            /*
            string text = File.ReadAllText(imgPath + file.Name);
            text = text.Replace("380pt", "380pt");
            text = text.Replace("200pt", "200pt");
            File.WriteAllText(imgPath + file.Name, text);
            */
        }

    }
}