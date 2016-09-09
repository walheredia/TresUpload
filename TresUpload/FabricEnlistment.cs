/*
 * Created by SharpDevelop.
 * User: walterh
 * Date: 9/9/2016
 * Time: 3:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace TresUpload
{
	/// <summary>
	/// Description of FabricEnlistment.
	/// </summary>
	public partial class FabricEnlistment : Form
	{
		public FabricEnlistment()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Btn_startenlistmentClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("C:/Users/walterh/Desktop/BAT/Donwloader.bat");
		}
	}
}
