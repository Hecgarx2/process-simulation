/*
 * Created by SharpDevelop.
 * User: chomp
 * Date: 12/09/2023
 * Time: 02:36 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Actividad_4
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
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.label1 = new System.Windows.Forms.Label();
			this.lblProcess1 = new System.Windows.Forms.Label();
			this.lblProcess2 = new System.Windows.Forms.Label();
			this.buttonStart = new System.Windows.Forms.Button();
			this.checkBoxWait2 = new System.Windows.Forms.CheckBox();
			this.checkBoxWait1 = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// progressBar1
			// 
			this.progressBar1.BackColor = System.Drawing.Color.Red;
			this.progressBar1.Location = new System.Drawing.Point(240, 122);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(312, 39);
			this.progressBar1.TabIndex = 38;
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(12, 122);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(104, 39);
			this.checkBox1.TabIndex = 43;
			this.checkBox1.Text = "Crear proceso 1";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(15, 180);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(104, 39);
			this.checkBox2.TabIndex = 46;
			this.checkBox2.Text = "Crear proceso 2";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2CheckedChanged);
			// 
			// progressBar2
			// 
			this.progressBar2.BackColor = System.Drawing.Color.Red;
			this.progressBar2.Location = new System.Drawing.Point(240, 176);
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(312, 39);
			this.progressBar2.TabIndex = 45;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(159, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(408, 41);
			this.label1.TabIndex = 57;
			this.label1.Text = "5 estados de los procesos";
			// 
			// lblProcess1
			// 
			this.lblProcess1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProcess1.Location = new System.Drawing.Point(564, 122);
			this.lblProcess1.Name = "lblProcess1";
			this.lblProcess1.Size = new System.Drawing.Size(124, 35);
			this.lblProcess1.TabIndex = 58;
			// 
			// lblProcess2
			// 
			this.lblProcess2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProcess2.Location = new System.Drawing.Point(564, 180);
			this.lblProcess2.Name = "lblProcess2";
			this.lblProcess2.Size = new System.Drawing.Size(124, 35);
			this.lblProcess2.TabIndex = 59;
			// 
			// buttonStart
			// 
			this.buttonStart.Enabled = false;
			this.buttonStart.Location = new System.Drawing.Point(314, 238);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(89, 39);
			this.buttonStart.TabIndex = 63;
			this.buttonStart.Text = "Empezar";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
			// 
			// checkBoxWait2
			// 
			this.checkBoxWait2.Enabled = false;
			this.checkBoxWait2.Location = new System.Drawing.Point(125, 180);
			this.checkBoxWait2.Name = "checkBoxWait2";
			this.checkBoxWait2.Size = new System.Drawing.Size(109, 39);
			this.checkBoxWait2.TabIndex = 65;
			this.checkBoxWait2.Text = "Pausar proceso 2";
			this.checkBoxWait2.UseVisualStyleBackColor = true;
			// 
			// checkBoxWait1
			// 
			this.checkBoxWait1.Enabled = false;
			this.checkBoxWait1.Location = new System.Drawing.Point(122, 122);
			this.checkBoxWait1.Name = "checkBoxWait1";
			this.checkBoxWait1.Size = new System.Drawing.Size(112, 39);
			this.checkBoxWait1.TabIndex = 64;
			this.checkBoxWait1.Text = "Pausar proceso 1";
			this.checkBoxWait1.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 328);
			this.Controls.Add(this.checkBoxWait2);
			this.Controls.Add(this.checkBoxWait1);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.lblProcess2);
			this.Controls.Add(this.lblProcess1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.progressBar2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.progressBar1);
			this.Name = "MainForm";
			this.Text = "Hector Emmanuel Garcia Garcia Actividad_4";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.CheckBox checkBoxWait1;
		private System.Windows.Forms.CheckBox checkBoxWait2;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Label lblProcess2;
		private System.Windows.Forms.Label lblProcess1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.ProgressBar progressBar2;
	}
}
