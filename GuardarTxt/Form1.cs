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
using Microsoft.VisualBasic;

namespace GuardarTxt
{
    public partial class Form1 : Form
    {
        public String correo;
        public String numPC;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Escribre.WriteLine(textBox1.Text);
            //Escribre.WriteLine();
            //Escribre.WriteLine(numericUpDown1.Value);
            //Escribre.Close();
            if (File.Exists("Credenciales.txt"))
            {
                MessageBox.Show("Si existe");
                TextReader Leer = new StreamReader("Credenciales.txt");
                correo = Leer.ReadLine();
                Leer.ReadLine();
                numPC = Leer.ReadLine();
                Leer.Close();

                if (correo == null | numPC == null| correo == "" | numPC == "")
                {
                    TextWriter Escribre = new StreamWriter("Credenciales.txt");
                    MessageBox.Show("Debes ingresar credenciales");
                    String var = Interaction.InputBox("Ingresa Tu correo Electronico","CORREO ELECTRONICO","Obb@gamail.com");

                    Escribre.WriteLine(var);
                    Escribre.WriteLine();
                    String var2 = Interaction.InputBox("Ingresa el numero de la PC", "Numero de la computadora", "1");
                    Escribre.WriteLine(var2);
                    Escribre.Close();
                }
            }
            else
            {
                MessageBox.Show("No existe");
                TextWriter Escribre = new StreamWriter("Credenciales.txt");
                MessageBox.Show("Debes ingresar credenciales");
                String var = Interaction.InputBox("Ingresa Tu correo Electronico", "CORREO ELECTRONICO", "Obb@gamail.com");

                Escribre.WriteLine(var);
                Escribre.WriteLine();
                String var2 = Interaction.InputBox("Ingresa el numero de la PC", "Numero de la computadora", "1");
                Escribre.WriteLine(var2);
                Escribre.Close();

                TextReader Leer = new StreamReader("Credenciales.txt");
                correo = Leer.ReadLine();
                Leer.ReadLine();
                numPC = Leer.ReadLine();
                Leer.Close();


            }
            
            MessageBox.Show(correo + " " + numPC);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TextReader Leer = new StreamReader("Credenciales.txt");
            //correo = Leer.ReadLine();
            //MessageBox.Show(Leer.ReadLine());
            //numPC = Leer.ReadLine();
            //Leer.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(correo + " "+ numPC);
        }
    }
}
