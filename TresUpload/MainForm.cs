/*
 * Created by SharpDevelop.
 * User: walterh
 * Date: 5/4/2016
 * Time: 1:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TresUpload
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
			//asd
		}
		void ActiveDirectoryToolStripMenuItemClick(object sender, EventArgs e)
		{
			AD form = new AD();
			// show the newly created instance
			form.MdiParent = this;
			form.WindowState = FormWindowState.Maximized;			
			form.Show();
			
		}
		void AzureToolStripMenuItemClick(object sender, EventArgs e)
		{
			Azure form = new Azure();
			// show the newly created instance
			form.MdiParent = this;
			form.WindowState = FormWindowState.Maximized;			
			form.Show();
		}
		void CloseToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
