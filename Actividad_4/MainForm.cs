/*
 * Created by SharpDevelop.
 * User: Hector Emmanuel Garcia Garcia
 * Date: 12/09/2023
 * Time: 02:36 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_4
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		bool activo = false; //Variable que se encarga de revisar que el boton Empezar este activo
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	
		void ButtonStartClick(object sender, EventArgs e)
		{
			
		}
		
		
		async void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked) {
				lblProcess1.Text = "Creando proceso...";
				await Task.Delay(3000);
				buttonStart.Enabled = true; // Reemplaza "button1" con el nombre real de tu botón
			   	lblProcess1.Text = "Proceso listo";
			}
			else{
				buttonStart.Enabled = false; // Reemplaza "button1" con el nombre real de tu botón
			    lblProcess1.Text = "";
			}
		}
		
		async void CheckBox2CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked) {
				lblProcess2.Text = "Creando proceso...";
				await Task.Delay(3000);
				buttonStart.Enabled = true; // Reemplaza "button1" con el nombre real de tu botón
			   	lblProcess2.Text = "Proceso listo";
			}
			else{
				buttonStart.Enabled = false; // Reemplaza "button1" con el nombre real de tu botón
			    lblProcess2.Text = "";
			}
		}
	}
}
