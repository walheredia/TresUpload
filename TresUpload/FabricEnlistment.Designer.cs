/*
 * Created by SharpDevelop.
 * User: walterh
 * Date: 9/9/2016
 * Time: 3:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TresUpload
{
	partial class FabricEnlistment
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_startenlistment;
		
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
			this.btn_startenlistment = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_startenlistment
			// 
			this.btn_startenlistment.Location = new System.Drawing.Point(202, 278);
			this.btn_startenlistment.Name = "btn_startenlistment";
			this.btn_startenlistment.Size = new System.Drawing.Size(99, 55);
			this.btn_startenlistment.TabIndex = 1;
			this.btn_startenlistment.Text = "Start Enlistment";
			this.btn_startenlistment.UseVisualStyleBackColor = true;
			this.btn_startenlistment.Click += new System.EventHandler(this.Btn_startenlistmentClick);
			// 
			// FabricEnlistment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(516, 438);
			this.Controls.Add(this.btn_startenlistment);
			this.Name = "FabricEnlistment";
			this.Text = "FabricEnlistment";
			this.ResumeLayout(false);

		}
	}
}
