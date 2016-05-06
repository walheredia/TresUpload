/*
 * Created by SharpDevelop.
 * User: walterh
 * Date: 5/6/2016
 * Time: 12:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TresUpload
{
	/// <summary>
	/// Description of Azure.
	/// </summary>
	public partial class Azure : Form
	{
		public Azure()
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
			foreach(Control ctrl in LblTitle_Panel1.Controls)
			{

			      if(ctrl.GetType().ToString().ToUpper() == "CHECKBOX")
			     {
			             CheckBox cbx = (CheckBox)ctrl;
			             if (cbx.Checked=true) {
			             	cbx.Checked=false;
			             }
			      }
			}
	    
		}
	}
}
