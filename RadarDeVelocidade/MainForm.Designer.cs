/*
 * Criado por SharpDevelop.
 * Usuário: couti
 * Data: 05/07/2021
 * Hora: 18:42
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace RadarDeVelocidade
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pb_Animacao = new System.Windows.Forms.PictureBox();
			this.lbl_Situacao = new System.Windows.Forms.Label();
			this.lbl_Velocidade = new System.Windows.Forms.Label();
			this.btn_Calcular = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_Tempo = new System.Windows.Forms.TextBox();
			this.tb_Posicao2 = new System.Windows.Forms.TextBox();
			this.tb_Posicao1 = new System.Windows.Forms.TextBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pb_Animacao)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pb_Animacao
			// 
			this.pb_Animacao.BackColor = System.Drawing.Color.Transparent;
			this.pb_Animacao.Location = new System.Drawing.Point(528, 26);
			this.pb_Animacao.Name = "pb_Animacao";
			this.pb_Animacao.Size = new System.Drawing.Size(216, 177);
			this.pb_Animacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_Animacao.TabIndex = 27;
			this.pb_Animacao.TabStop = false;
			// 
			// lbl_Situacao
			// 
			this.lbl_Situacao.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Situacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Situacao.Location = new System.Drawing.Point(36, 66);
			this.lbl_Situacao.Name = "lbl_Situacao";
			this.lbl_Situacao.Size = new System.Drawing.Size(469, 44);
			this.lbl_Situacao.TabIndex = 26;
			// 
			// lbl_Velocidade
			// 
			this.lbl_Velocidade.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Velocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Velocidade.Location = new System.Drawing.Point(36, 26);
			this.lbl_Velocidade.Name = "lbl_Velocidade";
			this.lbl_Velocidade.Size = new System.Drawing.Size(397, 40);
			this.lbl_Velocidade.TabIndex = 25;
			this.lbl_Velocidade.Text = "Velocidade média:";
			// 
			// btn_Calcular
			// 
			this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Calcular.Location = new System.Drawing.Point(427, 318);
			this.btn_Calcular.Name = "btn_Calcular";
			this.btn_Calcular.Size = new System.Drawing.Size(143, 58);
			this.btn_Calcular.TabIndex = 24;
			this.btn_Calcular.Text = "Calcular";
			this.btn_Calcular.UseVisualStyleBackColor = true;
			this.btn_Calcular.Click += new System.EventHandler(this.Button1Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(750, 206);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 32);
			this.label3.TabIndex = 23;
			this.label3.Text = "Posição:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(427, 206);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 32);
			this.label2.TabIndex = 22;
			this.label2.Text = "Tempo gasto:";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(166, 206);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 32);
			this.label1.TabIndex = 21;
			this.label1.Text = "Posição:";
			// 
			// tb_Tempo
			// 
			this.tb_Tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_Tempo.Location = new System.Drawing.Point(427, 238);
			this.tb_Tempo.Name = "tb_Tempo";
			this.tb_Tempo.Size = new System.Drawing.Size(136, 31);
			this.tb_Tempo.TabIndex = 20;
			// 
			// tb_Posicao2
			// 
			this.tb_Posicao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_Posicao2.Location = new System.Drawing.Point(750, 238);
			this.tb_Posicao2.Name = "tb_Posicao2";
			this.tb_Posicao2.Size = new System.Drawing.Size(88, 31);
			this.tb_Posicao2.TabIndex = 19;
			// 
			// tb_Posicao1
			// 
			this.tb_Posicao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_Posicao1.Location = new System.Drawing.Point(166, 238);
			this.tb_Posicao1.Name = "tb_Posicao1";
			this.tb_Posicao1.Size = new System.Drawing.Size(89, 31);
			this.tb_Posicao1.TabIndex = 18;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(9, 277);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(67, 57);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 17;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(36, 322);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(10, 92);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 16;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(750, 275);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(92, 139);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 15;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(166, 275);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(92, 139);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(854, 511);
			this.Controls.Add(this.pb_Animacao);
			this.Controls.Add(this.lbl_Situacao);
			this.Controls.Add(this.lbl_Velocidade);
			this.Controls.Add(this.btn_Calcular);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_Tempo);
			this.Controls.Add(this.tb_Posicao2);
			this.Controls.Add(this.tb_Posicao1);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.Text = "RadarDeVelocidade";
			((System.ComponentModel.ISupportInitialize)(this.pb_Animacao)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.TextBox tb_Posicao1;
		private System.Windows.Forms.TextBox tb_Posicao2;
		private System.Windows.Forms.TextBox tb_Tempo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_Calcular;
		private System.Windows.Forms.Label lbl_Velocidade;
		private System.Windows.Forms.Label lbl_Situacao;
		private System.Windows.Forms.PictureBox pb_Animacao;
	}
}
