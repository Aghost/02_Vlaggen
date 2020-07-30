using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_vlaggen
{
    struct flagStruct
    {
        public String imgName;
        public int imgIndex;
        // public int error-count;
        // public bool active;
    }

    public partial class Form1 : Form
    {
        string imgPath = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()
                            + "\\img\\"; // `cd ../img | bash`
        string currentImage = "";
        uint currentIndex = 0;

        // string foldersize = Directory.EnumerateFiles("./").ToString();
        flagStruct[] flagArray = new flagStruct[255]; // flag-images.count

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
            DirectoryInfo d = new DirectoryInfo(imgPath);
            int flagCount = 0;

            foreach (var file in d.GetFiles("*.svg"))
            {
                flagArray[flagCount].imgName = file.Name; //.Split('.').First().Remove(0, 8).Replace('_', ' ');
                flagArray[flagCount].imgIndex = flagCount;
                
                Console.WriteLine($"{flagArray[flagCount].imgName}\n{flagArray[flagCount].imgIndex}");
                flagCount += 1;
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            currentImage = flagArray[currentIndex -= 1].imgName;
            
            imageBox.Url = new Uri($"{imgPath}{currentImage}");
            Console.WriteLine(imageBox.Url);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            currentImage = flagArray[currentIndex += 1].imgName;

            imageBox.Url = new Uri($"{imgPath}{currentImage}");
            Console.WriteLine(imageBox.Url);
        }

        private void btn_guess_Click(object sender, EventArgs e)
        {
            //textBox.Text = imageBox.Url.ToString().Split('.').First().Split('/').Last().Remove(0, 8).Replace('_', ' ');
        }
    }
}
