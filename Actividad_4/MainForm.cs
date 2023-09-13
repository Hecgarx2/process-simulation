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
using System.Windows.Forms;

namespace Actividad_4
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		
		void Button1Click(object sender, EventArgs e)
		{
			while (progressBar1.Value != 100) {
				progressBar1.Value++;
			}			
		}
	}
}
