/*
 * Criado por SharpDevelop.
 * Usuário: couti
 * Data: 05/07/2021
 * Hora: 18:42
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RadarDeVelocidade
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			//Botão calcular
			//Recebendo os dados do usuário
			float p1 = float.Parse(textBox1.Text);
			float p2 = float.Parse(textBox2.Text);
			float t = float.Parse(textBox3.Text);
			
			//Calculando a média de velocidade
			float media = (p2-p1) / t;
			
			//Mostando na tela
			label4.Text = "Velocidade média: " + media + " km/h.";
			
			//Método IF
			if (media > 80) //Se a média for maior que 80km/h
			{
				//Verdadeiro
				label5.Text = "Multa aplicada!";
				pictureBox5.Load("policial.png");
			}
			else //Se não
			{
				label5.Text = "Dentro da velocidade permitida!";
					pictureBox5.Load("ned.jpg");
			}
		}
	}
}
