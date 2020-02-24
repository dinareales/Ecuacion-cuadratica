using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcuacionCuadratica
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			//manejo de secciones  
			try
			{
				String sentence = textEcuacion.Text;
				char[] charArr = sentence.ToCharArray(); //convierte un string a un  array de caracteres
				String letra = "";
				//recorre cada uno de los caracteres y encuentra la letra
				foreach (char ch in charArr)
				{
					if (char.IsLetter(ch))
					{
						letra = "" + ch; break;
					}
				}
				if (letra == "")
				{
					MessageBox.Show("Ha ocurrido un error , no se han ingresado las variables");
					return;
				}

				int letra1 = sentence.IndexOf(letra + "2");     //Busco la ubicacion de x^2
				String A = sentence.Substring(0, letra1);  //Recorto el valor de A

				int ubicacionletra = letra1 + 2; //me ubico donde empieza B

				String subSentence = sentence.Substring(ubicacionletra, (sentence.Length - ubicacionletra)); //recorto desde donde empieza B hasta el final
				int letra2 = subSentence.IndexOf(letra); //busco la segunda letra en el substring
				String B = sentence.Substring(ubicacionletra, letra2); //Recorto el valor de B

				int ubicacionletra2 = letra2 + 1;
				String subsubSentence = subSentence.Substring(ubicacionletra2, (subSentence.Length - ubicacionletra2)); //recorto desde donde empieza C hasta el final
				int letra3 = subSentence.IndexOf("="); //busco el igual en el substring
				String D = subSentence.Substring(ubicacionletra2, letra3 - ubicacionletra2); //Recorto el valor de D			

				int ubicacionletra3 = letra3 + 1;
				String R = subSentence.Substring(ubicacionletra3, (subSentence.Length - ubicacionletra3)); //recorto el valor de R

				operacion(A, B, D, R);
			}
			catch (ArgumentException)
			{
				MessageBox.Show("Ha ocurrido un error , verifique  su funcion");
			}

		}

		private void operacion(String A, String B, String D, String R)
		{
			//convertimos a numeros los valores   
			double numA = double.Parse(A);
			double numB = double.Parse(B);
			double numD = double.Parse(D);
			double numR = double.Parse(R);
			double numC = numD - numR;
			double x1;
			double x2;
			 //validamos que no pueda ingresar los numeros negativos en la raiz
			if (Math.Sqrt(Math.Pow(numB, 2) - (4 * numA * numC)) > 0)
			{
				//calculamos las raices
				x1 = (-numB + Math.Sqrt(numB * numB - 4 * numA * numC)) / (2 * numA);
				x2 = (-numB - Math.Sqrt(numB * numB - 4 * numA * numC)) / (2 * numA);

				raiz1.Text= "El valor de la raiz positiva es: " + x1;
				raiz2.Text ="El valor de la raiz negativa es: " + x2;
			}
			else
			{
				MessageBox.Show("Error en la raíz, el contenido de la raiz no puede ser negativo");
			}
		}

	}
}
