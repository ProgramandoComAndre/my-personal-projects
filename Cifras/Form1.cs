using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Cifras
{
    public partial class Form1 : Form
    {
        
        Dictionary<int, string> letrasComNumero = new Dictionary<int, string>();
        PrivateFontCollection fontCollection = new PrivateFontCollection();
        List<Image> animation;
        string[,,] quadrados = new string[,,]
        {
            {
                {"a","b","c"},
                {"d","e","f"},
                {"g","h","i"}

            },

            {
                {"j","k","l"},
                {"m","n","o" },
                {"p","q","r" }
            },

            {
                {"s","t","u"},
                {"v","w","x"},
                {"y","z"," "}
            }
        };






        public Tuple<int,int,int> GetCharIndexes(string character)
        {
            int quadrado = 0;
            int linha = 0;
            int coluna = 0;
            for(int i = 0; i < 3;i++)
            {
                for(int j = 0; j < 3;j++)
                {
                    for(int k = 0; k < 3;k++)
                    {
                        if(quadrados[i,j,k] == character.ToLower())
                        {
                            quadrado = i;
                            linha = j;
                            coluna = k;
                            goto paraAqui;
                        }
                    }
                }
            }

paraAqui:  return new Tuple<int, int, int>(quadrado, linha, coluna);
        }

        public Form1()
        {
            InitializeComponent();
            iniciarDicionario();
            fontCollection.AddFontFile(@"Fontes/codigochines.ttf");
            Font font = new Font(fontCollection.Families[0], 30);
            rtxt_encriptado.Font = font;
            
            

            
            
            
        }

        void iniciarDicionario()
        {
            letrasComNumero.Add(1, "a");
            letrasComNumero.Add(2, "b");
            letrasComNumero.Add(3, "c");
            letrasComNumero.Add(4, "d");
            letrasComNumero.Add(5, "e");
            letrasComNumero.Add(6, "f");
            letrasComNumero.Add(7, "g");
            letrasComNumero.Add(8, "h");
            letrasComNumero.Add(9, "i");
            letrasComNumero.Add(0, "j");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
        public void Animacao()
        {
            foreach(Image img in animation)
            {
                pic_output.Image = img;
                Thread.Sleep(2000);
            }
        }
        private void btn_converter_Click(object sender, EventArgs e)
        {
            animation = new List<Image>();
            string input = txt_input.Text.ToLower();
            
            foreach(char c in input)
            {
                string suffix = "";
                string diretorio = @"Imagens";
                suffix = "a";
                string[] files = Directory.GetFiles(diretorio);
                List<string> listFiles = new List<string>(files);
               if(c == ' ')
                {
                    Image img = Image.FromFile(listFiles.Find(x => x.Contains("fim da palavra.PNG")));
                    animation.Add(img);
                    continue;
                }



                if (char.IsLetter(c))
                {
                    
                    
                    int num = -1;
                    if(letrasComNumero.ContainsValue(c.ToString()))
                    {
                        foreach(int numero in letrasComNumero.Keys)
                        {
                            if(letrasComNumero[numero] == c.ToString())
                            {
                                num = numero;
                                suffix += "n" + c.ToString() + num.ToString() + ".png";
                                break;
                            }
                        }


                    }
                    else
                    {
                        suffix += c.ToString() + ".png";
                    }

                    Image img = Image.FromFile(listFiles.Find(x => x.Contains(suffix)));
                    animation.Add(img);
                    

                }
                else if(char.IsNumber(c))
                {
                    Image eNumero = Image.FromFile(listFiles.Find(x => x.Contains("numeros.PNG")));
                    suffix += "n" + letrasComNumero[int.Parse(c.ToString())] + c.ToString() + ".png";
                    Image img = Image.FromFile(listFiles.Find(x => x.Contains(suffix)));
                    animation.Add(eNumero);
                    animation.Add(img);
                }
            }

            Thread thread = new Thread(Animacao);
            thread.Start();

        }

        private void btn_encriptar_Click(object sender, EventArgs e)
        {
            string[] cifra = File.ReadAllLines(@"Dicionario/Alfabeto_fonetico.dat");
            Dictionary<string, string> alfabeto_fonetico = new Dictionary<string, string>();
            foreach(string s in cifra)
            {
                string[] correspondencia = s.Split('-');
                alfabeto_fonetico.Add(correspondencia[0], correspondencia[1]);
            }

            string normal = txt_normal.Text;
            StringBuilder stringBuilder = new StringBuilder();
            foreach(char c in normal)
            {
                if(char.IsLetter(c))
                {
                    string cUpper = c.ToString().ToUpper();
                    string palavra = alfabeto_fonetico[cUpper];
                    stringBuilder.AppendLine(palavra);
                }
                
            }

            txt_encriptado_alfabeto.Text = stringBuilder.ToString();


            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtxt_encriptado.Text = txt_texto_encriptar_cifra_chinesa.Text.ToLower();
        }

        private void rtxt_encriptado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txt_aEncriptar_Braille.Text == "") return;
            List<Bitmap> imagemFinal = new List<Bitmap>();
            foreach(char c in txt_aEncriptar_Braille.Text.ToLower())
            {
                if (c == ' ')
                    continue;
                Bitmap bmp = new Bitmap(100, 100);
                Graphics g = Graphics.FromImage(bmp);
                Tuple<int, int, int> posicao = GetCharIndexes(c.ToString());
                int quadrado = posicao.Item1+1;
                int linha = posicao.Item2+1;
                int coluna = posicao.Item3+1;

                int xx = 0;
                int y = 0;
                for (int ii = 0; ii < quadrado; ii++)
                {
                    xx = ii * 10;
                    g.FillEllipse(Brushes.Black, xx, y, 7, 7);
                }

                y = 20;
                xx = 0;
                for(int ii = 0; ii < linha; ii++)
                {
                    xx = ii * 10;
                    g.FillEllipse(Brushes.Black, xx, y, 7, 7);
                }

                xx = 0;
                y = 40;
                for(int ii = 0; ii < coluna;ii++)
                {
                    xx = ii * 10;
                    g.FillEllipse(Brushes.Black, xx, y, 7, 7);
                }

                imagemFinal.Add(bmp);

            }

            Bitmap bmpFinal = new Bitmap(100 * imagemFinal.Count, 100);
            Graphics gg = Graphics.FromImage(bmpFinal);
            int x = 0;
            int i = 0;
            foreach(Bitmap bmp in imagemFinal)
            {
                x = 103 * i;
                gg.DrawImage(bmp, x, 0);
                i++;
            }
            pic_braille.Image = bmpFinal;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if((char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar)) && char.GetNumericValue(e.KeyChar) != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_encriptar_data_Click(object sender, EventArgs e)
        {
            List<int> indexes = new List<int>();
            txt_encriptado_data.Text = "";
            foreach(char c in txt_data.Text)
            {
                int i = int.Parse(c.ToString());
                indexes.Add(i);
            }
            Dictionary<int, List<char>> dataCifra = new Dictionary<int, List<char>>();
            string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            int j = 0;
            foreach(int index in indexes)
            {
                List<char> listaChars = new List<char>();
                for (; j < chars.Length; j++)
                {
                    listaChars.Add(chars[j]);
                    if (j + 1 == 10 || j + 1 == 20)
                    {
                        j = j + 1;
                        break;
                    }

                }

               

                dataCifra.Add(index, listaChars);
                Console.WriteLine(dataCifra.Count);
                      
            }

            foreach(char c in txt_texto.Text.ToLower())
            {
                int identificador = -1;
                int indexLista = -1;
                foreach (int index in indexes)
                {
                    foreach(char caractere in dataCifra[index])
                    {
                        if(c == caractere)
                        {
                            identificador = index;
                            indexLista = dataCifra[index].IndexOf(c);
                            goto sair;


                        }
                    }
                }

            sair: indexLista += 1;
                txt_encriptado_data.Text += identificador.ToString() + indexLista.ToString();
            }
        }

        private void btn_encriptar_invertido_Click(object sender, EventArgs e)
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            List<char> alfabetoInvertido = new List<char>();
            alfabetoInvertido.AddRange(alfabeto.ToCharArray());
            alfabetoInvertido.Reverse();
            Dictionary<char, char> cifra = new Dictionary<char, char>();
            for(int i = 0; i < alfabeto.Length;i++)
            {
                cifra.Add(alfabeto[i], alfabetoInvertido[i]);
            }
            foreach (char c in txt_encriptar_invertido.Text.ToLower())
            {
                txt_encriptado_invertido.Text += cifra[c];
            }
        }
    }
}
