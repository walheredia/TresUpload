/*
 * Created by SharpDevelop.
 * User: walterh
 * Date: 5/4/2016
 * Time: 1:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TresUpload
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(78, 35);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 49);
			this.button1.TabIndex = 0;
			this.button1.Text = "AD";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(78, 102);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(113, 49);
			this.button2.TabIndex = 1;
			this.button2.Text = "AZ";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "TresUpload";
			this.ResumeLayout(false);

		}
	}
}
