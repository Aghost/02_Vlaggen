using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace _02_vlaggen
{
    
    struct imgStruct
    {
        public String imgName;
        public int imgIndex;
        // public int error-count;
        // public bool active;
    }

    public partial class Form1 : Form
    {
        static string imgPath = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()
                        + "\\img\\"; // `cd ../img | bash`
        //string imgPath = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()
        //                    + "\\img\\"; // `cd ../img | bash`
        int imgCount = Directory.GetFiles($"{imgPath}", "*.svg").Length;
        
        string currentImage = "";
        int currentIndex = 0;

        imgStruct[] imgArray = null;

        public Form1()
        {
            InitializeComponent();
            Load_Images();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Load_Images()
        {
            imgArray = new imgStruct[imgCount];
            DirectoryInfo d = new DirectoryInfo(imgPath);

            int icnt = 0;
            foreach (var file in d.GetFiles("*.svg"))
            {
                imgArray[icnt].imgName = file.Name;
                imgArray[icnt].imgIndex = icnt;
                
                icnt += 1;
            }

        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            currentIndex -= 1;
            currentIndex %= imgArray.Length;

            currentImage = imgArray[currentIndex].imgName;
            imageBox.Url = new Uri($"{imgPath}{currentImage}");
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            currentIndex += 1;
            currentIndex %= imgArray.Length - 1;

            currentImage = imgArray[currentIndex].imgName;
            imageBox.Url = new Uri($"{imgPath}{currentImage}");
        }

        private void btn_guess_Click(object sender, EventArgs e)
        {
            string answer = imageBox.Url.ToString().Split('.').First().Split('/').Last().Remove(0, 8).Replace('_', ' ');
            if (textBox.Text == answer || textBox.Text == answer.ToLower())
            {
                var imagelist = imgArray.ToList();
                imagelist.RemoveAt(currentIndex);
                imgArray = imagelist.ToArray();

                textBox.Text = "Correct";
                btn_next_Click(sender, e);
                Console.WriteLine(imgArray.Length);
            }

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
