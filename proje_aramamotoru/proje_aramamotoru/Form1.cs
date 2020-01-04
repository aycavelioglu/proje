using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proje_aramamotoru
{
    public partial class Form1 : Form
    {
        readonly string TxtSearchUrl = @"C:\proje\kelimeler\kelimeler.txt";
        readonly int WordDistance = 70; //Benzerlik oranı, kelimedeki benzerlik bu yüzdenin üstünde ise bunu mu demek istedinize kaydeder
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void aranacak_kelime_TextChanged(object sender, EventArgs e)
        {
            aranacak_kelime.Text = " "; 
        }

        private void text_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pdf_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void arama_Click(object sender, EventArgs e)
        {
                    var txtResult = new Result();
                    txtResult.arananKelime = aranacak_kelime.Text;
                    txtResult.kelimeVarmi = TxtSearch(txtResult.arananKelime);
                    txtResult.yakinKelimeler = TxtNestedSearch(txtResult.arananKelime);
                    MessageBox.Show(txtResult.arananKelime.ToString());
                    MessageBox.Show("kelime bulundu.");
                    listBox1.DataSource = null;
                    listBox1.Items.Clear();
                    listBox1.DataSource = txtResult.yakinKelimeler;
                   
                  
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        public bool TxtSearch(string searchKeyw)
        {
            List<string> lines = System.IO.File.ReadAllLines(TxtSearchUrl).ToList();
            // Display the file contents by using a foreach loop.

            bool isHaving = lines.Any(w => w == searchKeyw);

            return isHaving;
        }

        public List<string> TxtNestedSearch(string searchKeyw)
        {
            List<string> lines = System.IO.File.ReadAllLines(TxtSearchUrl).ToList();

            List<string> results = new List<string>();

            bool isAdding = false;
            foreach (string line in lines)
            {
                isAdding = false;

                foreach (string item in line.Split(' '))
                {
                    //Burda txt den okunan satırda kelime arasında boşluk var boşluğa göre gölüp her kelime içerisindeki benzerliğine bakıyor.
                    //Örn: dosyadan 'Elma Suyu' nu okudu. Aratılan 'lma' olsun.
                    //lma yı ilk başta Elma nın içinde sonra Suyu nun içinde arıyor. İkisinden birinde WordDistance oranının üstünde ise ekleme yapıyor. 
                    //Burda bi açık nokta var. Oda Girilen kelimenin arasında boşluk varsa. Bu durumda yapılacaksa bu da split edilerek içiçe döngü ile yapılabilir.

                    var distance = LevenshteinAlgorithm.GetSimilarityRatio(item, searchKeyw); 

                    if (distance >= WordDistance)
                    {
                        isAdding = true;
                    }
                }

                if (isAdding)
                {
                    results.Add(line);
                }
            }

            return results;
        }

        public class Result
        {
            public string arananKelime { get; set; }
            public bool kelimeVarmi { get; set; }
            public List<string> yakinKelimeler { get; set; }
        }
    }
}
