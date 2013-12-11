
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace Usuario
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void PesosTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void CambioTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void DolarTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void ConvertirClick(object sender, EventArgs e)
		{
			if ( Peso.Text.Length == 0 || Cambio.Text.Length == 0){
				MessageBox.Show("Los campos no deben estar vacios",
				                "Advertencia", MessageBoxButtons.OK);
				return;
			}
			
			
			double dolar, peso, cambio;

			dolar = System.Double.Parse(Peso.Text);
			pesos = System.Double.Parse(Cambio.Text);
			//Opreación
			cambio = dolar / peso;
			Dolar.Text = cambio.ToString();

			
		}
		
		
		void PesoNum_keyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
			{
				MessageBox.Show("Solo se permiten numeros", "Advertencia", 
				                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
				return;
			}

			
		}

		
		void CambioNum_keyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
			{
				MessageBox.Show("Solo se permiten numeros");
				              
				e.Handled = true;
				return;
			}

		}
		
		void DolaresNum_keyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
			{
				MessageBox.Show(" Advertencia solo se permiten números");
				               
				e.Handled = true;
				return;
			}

			
		}
	}
}


