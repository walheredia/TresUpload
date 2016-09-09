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
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem teamToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem activeDirectoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem azureToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fabricEnlistmentToolStripMenuItem;
		
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.activeDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.azureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fabricEnlistmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.teamToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1263, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "MenuStrip_Principal";
			// 
			// teamToolStripMenuItem
			// 
			this.teamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.activeDirectoryToolStripMenuItem,
			this.azureToolStripMenuItem,
			this.fabricEnlistmentToolStripMenuItem,
			this.closeToolStripMenuItem});
			this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
			this.teamToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
			this.teamToolStripMenuItem.Text = "Team";
			// 
			// activeDirectoryToolStripMenuItem
			// 
			this.activeDirectoryToolStripMenuItem.Name = "activeDirectoryToolStripMenuItem";
			this.activeDirectoryToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.activeDirectoryToolStripMenuItem.Text = "Active Directory";
			this.activeDirectoryToolStripMenuItem.Click += new System.EventHandler(this.ActiveDirectoryToolStripMenuItemClick);
			// 
			// azureToolStripMenuItem
			// 
			this.azureToolStripMenuItem.Name = "azureToolStripMenuItem";
			this.azureToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.azureToolStripMenuItem.Text = "Azure";
			this.azureToolStripMenuItem.Click += new System.EventHandler(this.AzureToolStripMenuItemClick);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItemClick);
			// 
			// fabricEnlistmentToolStripMenuItem
			// 
			this.fabricEnlistmentToolStripMenuItem.Name = "fabricEnlistmentToolStripMenuItem";
			this.fabricEnlistmentToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.fabricEnlistmentToolStripMenuItem.Text = "Fabric Enlistment";
			this.fabricEnlistmentToolStripMenuItem.Click += new System.EventHandler(this.FabricEnlistmentToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1263, 722);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TresUpload";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
