using System;
using System.Windows.Forms;

namespace RadarDeVelocidade
{
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
			float pos1 = float.Parse(tb_Posicao1.Text);
			float pos2 = float.Parse(tb_Posicao2.Text);
			float temp = float.Parse(tb_Tempo.Text);
			
			//Calculando a média de velocidade
			float velocidadeMedia = (pos2-pos1) / temp;
			
			//Mostando na tela
			lbl_Velocidade.Text = "Velocidade média: " + velocidadeMedia + " km/h.";
			
			//Fazendo a verificação com o método if/else
			if (velocidadeMedia > 80){
				//Se a velocidade média for maior que 80km/h
				lbl_Situacao.Text = "Multa aplicada!";
				pb_Animacao.Load("policial.png");
			}
			else{
				//Se não
				lbl_Situacao.Text = "Dentro da velocidade permitida!";
				pb_Animacao.Load("ned.jpg");
			}
		}
	}
}