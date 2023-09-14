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
using System.Threading.Tasks;			//Libreria de Tareas
using System.Windows.Forms;

namespace Actividad_4
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		CheckBox[] checkBoxes;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			checkBoxes = new CheckBox[]{checkBox1, checkBox2};
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//Metodo encargado de monitorear los CheckBox
		void MonitorearCheckBox(){
			foreach (CheckBox check in checkBoxes) {
				if (check.Checked) {				//Si hay al menos un checkBox activado el botón de Empezar debe estar activo
					buttonStart.Enabled = true;		
					return;
				}
				else{
					buttonStart.Enabled = false;
				}
			}
		}
		
		async void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked) {
				lblProcess1.Text = "Creando proceso...";
				await Task.Delay(2000);
				buttonStart.Enabled = true; // El botón Empezar se activa al marcar el checkBox
			   	lblProcess1.Text = "Proceso listo";
			}
			else{
				MonitorearCheckBox(); // Revisa si el botón debe activarse o desactivarse
			    lblProcess1.Text = "";
			}
		}
		
		async void CheckBox2CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked) {
				lblProcess2.Text = "Creando proceso...";
				await Task.Delay(2000);
				buttonStart.Enabled = true; // El botón Empezar se activa al marcar el checkBox
			   	lblProcess2.Text = "Proceso listo";
			}
			else{
				MonitorearCheckBox(); // Revisa si el botón debe activarse o desactivarse
			    lblProcess2.Text = "";
			}
		}
	
		void ButtonStartClick(object sender, EventArgs e)
		{
			checkBox1.Enabled = false;
			checkBox2.Enabled = false;
			checkBoxWait1.Enabled = true;
			checkBoxWait2.Enabled = true;
			Task tareaEjecucion1 = LoadProgressBar1();
			Task tareaEjecucion2 = LoadProgressBar2();
			
		}
		
		async Task LoadProgressBar1(){
		    await Task.Run(async () =>
		    {
		        while (progressBar1.Value != 100)
		        {
		        	if (checkBoxWait1.Checked) {
		        		lblProcess1.Invoke((Action)(() => lblProcess1.Text = "Proceso en espera..."));
		        	}
		        	else{
		        		lblProcess1.Invoke((Action)(() => lblProcess1.Text = "Proceso en ejecucion..."));
		        		await Task.Delay(100);
		            	progressBar1.Invoke((Action)(() => progressBar1.Value++));
		        	}
		        }
		        lblProcess1.Invoke((Action)(() => lblProcess1.Text = "Proceso terminado"));
		    });
		}
		
		async Task LoadProgressBar2(){
		    await Task.Run(async () =>
		    {
		        while (progressBar2.Value != 100)
		        {
		        	if (checkBoxWait2.Checked) {
		        		lblProcess2.Invoke((Action)(() => lblProcess2.Text = "Proceso en espera..."));
		        	}
		        	else{
		        		lblProcess2.Invoke((Action)(() => lblProcess2.Text = "Proceso en ejecucion..."));
		        		await Task.Delay(100);
		            	progressBar2.Invoke((Action)(() => progressBar2.Value++));
		        	}
		        }
		        lblProcess2.Invoke((Action)(() => lblProcess2.Text = "Proceso terminado"));
		    });
		}
	}
}
