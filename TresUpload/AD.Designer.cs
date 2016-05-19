/*
 * Created by SharpDevelop.
 * User: walterh
 * Date: 5/4/2016
 * Time: 3:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TresUpload
{
	partial class AD
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel PanelLeft;
		private System.Windows.Forms.Panel PanelRight;
		private System.Windows.Forms.Button btn_CreateStructure;
		private System.Windows.Forms.GroupBox GrBox_Select_Components;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btn_Invert;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btn_CheckAll;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_UnCheckAll;
		private System.Windows.Forms.CheckBox checkBox26;
		private System.Windows.Forms.CheckBox chkb_CloudAppDiscovery;
		private System.Windows.Forms.CheckBox checkBox25;
		private System.Windows.Forms.CheckBox chkb_ProtectionCenter;
		private System.Windows.Forms.CheckBox checkBox24;
		private System.Windows.Forms.CheckBox chkb_IAM;
		private System.Windows.Forms.CheckBox checkBox23;
		private System.Windows.Forms.CheckBox chkb_RoleBasedAccessControl;
		private System.Windows.Forms.CheckBox checkBox22;
		private System.Windows.Forms.CheckBox chkb_SQLDB;
		private System.Windows.Forms.CheckBox checkBox21;
		private System.Windows.Forms.CheckBox chkb_AzureSearch;
		private System.Windows.Forms.CheckBox checkBox20;
		private System.Windows.Forms.CheckBox chkb_DocDB;
		private System.Windows.Forms.CheckBox checkBox19;
		private System.Windows.Forms.CheckBox chkb_MicrosoftIntuneMAMExtension;
		private System.Windows.Forms.CheckBox checkBox18;
		private System.Windows.Forms.CheckBox chkb_B2C;
		private System.Windows.Forms.CheckBox checkBox17;
		private System.Windows.Forms.CheckBox chkb_B2B;
		private System.Windows.Forms.CheckBox checkBox16;
		private System.Windows.Forms.CheckBox chkb_WindowsAzurePack;
		private System.Windows.Forms.CheckBox checkBox15;
		private System.Windows.Forms.CheckBox chkb_InsightExtension;
		private System.Windows.Forms.CheckBox checkBox14;
		private System.Windows.Forms.CheckBox chkb_PortalClassic;
		private System.Windows.Forms.CheckBox chbx_MFA_SAS;
		private System.Windows.Forms.CheckBox chkb_StoreExperience;
		private System.Windows.Forms.CheckBox chbx_IAMUX;
		private System.Windows.Forms.CheckBox chkb_StoreMarketplace;
		private System.Windows.Forms.CheckBox chbx_AzureSecurityCenter;
		private System.Windows.Forms.CheckBox chkb_InsightCommon;
		private System.Windows.Forms.CheckBox chbx_PIM;
		private System.Windows.Forms.CheckBox chkb_InsightMonRP;
		private System.Windows.Forms.CheckBox chbx_MIM;
		private System.Windows.Forms.CheckBox chkb_InsightEvtRP;
		private System.Windows.Forms.CheckBox chbx_Atlanta;
		private System.Windows.Forms.CheckBox chkb_InsightNotRP;
		private System.Windows.Forms.CheckBox chbx_Adallom;
		private System.Windows.Forms.CheckBox chkb_PortalFX;
		private System.Windows.Forms.CheckBox chbx_ESTS;
		private System.Windows.Forms.CheckBox chkb_ResourceManager;
		private System.Windows.Forms.CheckBox chbx_MSA;
		private System.Windows.Forms.CheckBox chkb_ResourceProviderSDK;
		private System.Windows.Forms.CheckBox chbxADConnectHealth;
		private System.Windows.Forms.CheckBox chkb_RedisCacheExtension;
		private System.Windows.Forms.CheckBox chbx_ADConnect;
		private System.Windows.Forms.CheckBox chkb_RedisChacheRP;
		private System.Windows.Forms.CheckBox chbx_ADBillingExtension;
		private System.Windows.Forms.CheckBox chkbx_ADBilling;
		private System.Windows.Forms.CheckBox chkb_SchedulerRP;
		private System.Windows.Forms.CheckBox chkb_SchedulerExtension;
		private System.Windows.Forms.Label LblTitle_Panel1;
		private System.Windows.Forms.ProgressBar pb_structure;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AD));
			this.PanelLeft = new System.Windows.Forms.Panel();
			this.PanelRight = new System.Windows.Forms.Panel();
			this.btn_CreateStructure = new System.Windows.Forms.Button();
			this.GrBox_Select_Components = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.btn_Invert = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btn_CheckAll = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btn_UnCheckAll = new System.Windows.Forms.Button();
			this.checkBox26 = new System.Windows.Forms.CheckBox();
			this.chkb_CloudAppDiscovery = new System.Windows.Forms.CheckBox();
			this.checkBox25 = new System.Windows.Forms.CheckBox();
			this.chkb_ProtectionCenter = new System.Windows.Forms.CheckBox();
			this.checkBox24 = new System.Windows.Forms.CheckBox();
			this.chkb_IAM = new System.Windows.Forms.CheckBox();
			this.checkBox23 = new System.Windows.Forms.CheckBox();
			this.chkb_RoleBasedAccessControl = new System.Windows.Forms.CheckBox();
			this.checkBox22 = new System.Windows.Forms.CheckBox();
			this.chkb_SQLDB = new System.Windows.Forms.CheckBox();
			this.checkBox21 = new System.Windows.Forms.CheckBox();
			this.chkb_AzureSearch = new System.Windows.Forms.CheckBox();
			this.checkBox20 = new System.Windows.Forms.CheckBox();
			this.chkb_DocDB = new System.Windows.Forms.CheckBox();
			this.checkBox19 = new System.Windows.Forms.CheckBox();
			this.chkb_MicrosoftIntuneMAMExtension = new System.Windows.Forms.CheckBox();
			this.checkBox18 = new System.Windows.Forms.CheckBox();
			this.chkb_B2C = new System.Windows.Forms.CheckBox();
			this.checkBox17 = new System.Windows.Forms.CheckBox();
			this.chkb_B2B = new System.Windows.Forms.CheckBox();
			this.checkBox16 = new System.Windows.Forms.CheckBox();
			this.chkb_WindowsAzurePack = new System.Windows.Forms.CheckBox();
			this.checkBox15 = new System.Windows.Forms.CheckBox();
			this.chkb_InsightExtension = new System.Windows.Forms.CheckBox();
			this.checkBox14 = new System.Windows.Forms.CheckBox();
			this.chkb_PortalClassic = new System.Windows.Forms.CheckBox();
			this.chbx_MFA_SAS = new System.Windows.Forms.CheckBox();
			this.chkb_StoreExperience = new System.Windows.Forms.CheckBox();
			this.chbx_IAMUX = new System.Windows.Forms.CheckBox();
			this.chkb_StoreMarketplace = new System.Windows.Forms.CheckBox();
			this.chbx_AzureSecurityCenter = new System.Windows.Forms.CheckBox();
			this.chkb_InsightCommon = new System.Windows.Forms.CheckBox();
			this.chbx_PIM = new System.Windows.Forms.CheckBox();
			this.chkb_InsightMonRP = new System.Windows.Forms.CheckBox();
			this.chbx_MIM = new System.Windows.Forms.CheckBox();
			this.chkb_InsightEvtRP = new System.Windows.Forms.CheckBox();
			this.chbx_Atlanta = new System.Windows.Forms.CheckBox();
			this.chkb_InsightNotRP = new System.Windows.Forms.CheckBox();
			this.chbx_Adallom = new System.Windows.Forms.CheckBox();
			this.chkb_PortalFX = new System.Windows.Forms.CheckBox();
			this.chbx_ESTS = new System.Windows.Forms.CheckBox();
			this.chkb_ResourceManager = new System.Windows.Forms.CheckBox();
			this.chbx_MSA = new System.Windows.Forms.CheckBox();
			this.chkb_ResourceProviderSDK = new System.Windows.Forms.CheckBox();
			this.chbxADConnectHealth = new System.Windows.Forms.CheckBox();
			this.chkb_RedisCacheExtension = new System.Windows.Forms.CheckBox();
			this.chbx_ADConnect = new System.Windows.Forms.CheckBox();
			this.chkb_RedisChacheRP = new System.Windows.Forms.CheckBox();
			this.chbx_ADBillingExtension = new System.Windows.Forms.CheckBox();
			this.chkbx_ADBilling = new System.Windows.Forms.CheckBox();
			this.chkb_SchedulerRP = new System.Windows.Forms.CheckBox();
			this.chkb_SchedulerExtension = new System.Windows.Forms.CheckBox();
			this.LblTitle_Panel1 = new System.Windows.Forms.Label();
			this.pb_structure = new System.Windows.Forms.ProgressBar();
			this.PanelLeft.SuspendLayout();
			this.GrBox_Select_Components.SuspendLayout();
			this.SuspendLayout();
			// 
			// PanelLeft
			// 
			this.PanelLeft.Controls.Add(this.btn_CreateStructure);
			this.PanelLeft.Controls.Add(this.GrBox_Select_Components);
			this.PanelLeft.Controls.Add(this.LblTitle_Panel1);
			this.PanelLeft.Controls.Add(this.pb_structure);
			this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.PanelLeft.Location = new System.Drawing.Point(0, 0);
			this.PanelLeft.Name = "PanelLeft";
			this.PanelLeft.Size = new System.Drawing.Size(565, 626);
			this.PanelLeft.TabIndex = 0;
			// 
			// PanelRight
			// 
			this.PanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelRight.Location = new System.Drawing.Point(565, 0);
			this.PanelRight.Name = "PanelRight";
			this.PanelRight.Size = new System.Drawing.Size(518, 626);
			this.PanelRight.TabIndex = 1;
			// 
			// btn_CreateStructure
			// 
			this.btn_CreateStructure.Location = new System.Drawing.Point(388, 484);
			this.btn_CreateStructure.Name = "btn_CreateStructure";
			this.btn_CreateStructure.Size = new System.Drawing.Size(181, 23);
			this.btn_CreateStructure.TabIndex = 7;
			this.btn_CreateStructure.Text = "Create Structure";
			this.btn_CreateStructure.UseVisualStyleBackColor = true;
			// 
			// GrBox_Select_Components
			// 
			this.GrBox_Select_Components.Controls.Add(this.button3);
			this.GrBox_Select_Components.Controls.Add(this.btn_Invert);
			this.GrBox_Select_Components.Controls.Add(this.button2);
			this.GrBox_Select_Components.Controls.Add(this.btn_CheckAll);
			this.GrBox_Select_Components.Controls.Add(this.button1);
			this.GrBox_Select_Components.Controls.Add(this.btn_UnCheckAll);
			this.GrBox_Select_Components.Controls.Add(this.checkBox26);
			this.GrBox_Select_Components.Controls.Add(this.chkb_CloudAppDiscovery);
			this.GrBox_Select_Components.Controls.Add(this.checkBox25);
			this.GrBox_Select_Components.Controls.Add(this.chkb_ProtectionCenter);
			this.GrBox_Select_Components.Controls.Add(this.checkBox24);
			this.GrBox_Select_Components.Controls.Add(this.chkb_IAM);
			this.GrBox_Select_Components.Controls.Add(this.checkBox23);
			this.GrBox_Select_Components.Controls.Add(this.chkb_RoleBasedAccessControl);
			this.GrBox_Select_Components.Controls.Add(this.checkBox22);
			this.GrBox_Select_Components.Controls.Add(this.chkb_SQLDB);
			this.GrBox_Select_Components.Controls.Add(this.checkBox21);
			this.GrBox_Select_Components.Controls.Add(this.chkb_AzureSearch);
			this.GrBox_Select_Components.Controls.Add(this.checkBox20);
			this.GrBox_Select_Components.Controls.Add(this.chkb_DocDB);
			this.GrBox_Select_Components.Controls.Add(this.checkBox19);
			this.GrBox_Select_Components.Controls.Add(this.chkb_MicrosoftIntuneMAMExtension);
			this.GrBox_Select_Components.Controls.Add(this.checkBox18);
			this.GrBox_Select_Components.Controls.Add(this.chkb_B2C);
			this.GrBox_Select_Components.Controls.Add(this.checkBox17);
			this.GrBox_Select_Components.Controls.Add(this.chkb_B2B);
			this.GrBox_Select_Components.Controls.Add(this.checkBox16);
			this.GrBox_Select_Components.Controls.Add(this.chkb_WindowsAzurePack);
			this.GrBox_Select_Components.Controls.Add(this.checkBox15);
			this.GrBox_Select_Components.Controls.Add(this.chkb_InsightExtension);
			this.GrBox_Select_Components.Controls.Add(this.checkBox14);
			this.GrBox_Select_Components.Controls.Add(this.chkb_PortalClassic);
			this.GrBox_Select_Components.Controls.Add(this.chbx_MFA_SAS);
			this.GrBox_Select_Components.Controls.Add(this.chkb_StoreExperience);
			this.GrBox_Select_Components.Controls.Add(this.chbx_IAMUX);
			this.GrBox_Select_Components.Controls.Add(this.chkb_StoreMarketplace);
			this.GrBox_Select_Components.Controls.Add(this.chbx_AzureSecurityCenter);
			this.GrBox_Select_Components.Controls.Add(this.chkb_InsightCommon);
			this.GrBox_Select_Components.Controls.Add(this.chbx_PIM);
			this.GrBox_Select_Components.Controls.Add(this.chkb_InsightMonRP);
			this.GrBox_Select_Components.Controls.Add(this.chbx_MIM);
			this.GrBox_Select_Components.Controls.Add(this.chkb_InsightEvtRP);
			this.GrBox_Select_Components.Controls.Add(this.chbx_Atlanta);
			this.GrBox_Select_Components.Controls.Add(this.chkb_InsightNotRP);
			this.GrBox_Select_Components.Controls.Add(this.chbx_Adallom);
			this.GrBox_Select_Components.Controls.Add(this.chkb_PortalFX);
			this.GrBox_Select_Components.Controls.Add(this.chbx_ESTS);
			this.GrBox_Select_Components.Controls.Add(this.chkb_ResourceManager);
			this.GrBox_Select_Components.Controls.Add(this.chbx_MSA);
			this.GrBox_Select_Components.Controls.Add(this.chkb_ResourceProviderSDK);
			this.GrBox_Select_Components.Controls.Add(this.chbxADConnectHealth);
			this.GrBox_Select_Components.Controls.Add(this.chkb_RedisCacheExtension);
			this.GrBox_Select_Components.Controls.Add(this.chbx_ADConnect);
			this.GrBox_Select_Components.Controls.Add(this.chkb_RedisChacheRP);
			this.GrBox_Select_Components.Controls.Add(this.chbx_ADBillingExtension);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_ADBilling);
			this.GrBox_Select_Components.Controls.Add(this.chkb_SchedulerRP);
			this.GrBox_Select_Components.Controls.Add(this.chkb_SchedulerExtension);
			this.GrBox_Select_Components.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GrBox_Select_Components.ForeColor = System.Drawing.Color.SlateBlue;
			this.GrBox_Select_Components.Location = new System.Drawing.Point(8, 31);
			this.GrBox_Select_Components.MaximumSize = new System.Drawing.Size(561, 392);
			this.GrBox_Select_Components.MinimumSize = new System.Drawing.Size(561, 392);
			this.GrBox_Select_Components.Name = "GrBox_Select_Components";
			this.GrBox_Select_Components.Size = new System.Drawing.Size(561, 392);
			this.GrBox_Select_Components.TabIndex = 5;
			this.GrBox_Select_Components.TabStop = false;
			this.GrBox_Select_Components.Text = "Check components";
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button3.Location = new System.Drawing.Point(477, 320);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(76, 66);
			this.button3.TabIndex = 29;
			this.button3.Text = "Invert";
			this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button3.UseVisualStyleBackColor = true;
			// 
			// btn_Invert
			// 
			this.btn_Invert.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Invert.Image = ((System.Drawing.Image)(resources.GetObject("btn_Invert.Image")));
			this.btn_Invert.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_Invert.Location = new System.Drawing.Point(476, 320);
			this.btn_Invert.Name = "btn_Invert";
			this.btn_Invert.Size = new System.Drawing.Size(76, 66);
			this.btn_Invert.TabIndex = 29;
			this.btn_Invert.Text = "Invert";
			this.btn_Invert.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_Invert.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(381, 320);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(90, 30);
			this.button2.TabIndex = 28;
			this.button2.Text = "Check All";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// btn_CheckAll
			// 
			this.btn_CheckAll.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_CheckAll.Location = new System.Drawing.Point(380, 320);
			this.btn_CheckAll.Name = "btn_CheckAll";
			this.btn_CheckAll.Size = new System.Drawing.Size(90, 30);
			this.btn_CheckAll.TabIndex = 28;
			this.btn_CheckAll.Text = "Check All";
			this.btn_CheckAll.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(381, 356);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 30);
			this.button1.TabIndex = 27;
			this.button1.Text = "Uncheck All";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btn_UnCheckAll
			// 
			this.btn_UnCheckAll.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_UnCheckAll.Location = new System.Drawing.Point(380, 356);
			this.btn_UnCheckAll.Name = "btn_UnCheckAll";
			this.btn_UnCheckAll.Size = new System.Drawing.Size(90, 30);
			this.btn_UnCheckAll.TabIndex = 27;
			this.btn_UnCheckAll.Text = "Uncheck All";
			this.btn_UnCheckAll.UseVisualStyleBackColor = true;
			// 
			// checkBox26
			// 
			this.checkBox26.Checked = true;
			this.checkBox26.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox26.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox26.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox26.Location = new System.Drawing.Point(381, 55);
			this.checkBox26.Name = "checkBox26";
			this.checkBox26.Size = new System.Drawing.Size(175, 24);
			this.checkBox26.TabIndex = 25;
			this.checkBox26.Text = "Cloud App Discovery";
			this.checkBox26.UseVisualStyleBackColor = true;
			// 
			// chkb_CloudAppDiscovery
			// 
			this.chkb_CloudAppDiscovery.Checked = true;
			this.chkb_CloudAppDiscovery.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_CloudAppDiscovery.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_CloudAppDiscovery.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_CloudAppDiscovery.Location = new System.Drawing.Point(380, 55);
			this.chkb_CloudAppDiscovery.Name = "chkb_CloudAppDiscovery";
			this.chkb_CloudAppDiscovery.Size = new System.Drawing.Size(175, 24);
			this.chkb_CloudAppDiscovery.TabIndex = 25;
			this.chkb_CloudAppDiscovery.Text = "Cloud App Discovery";
			this.chkb_CloudAppDiscovery.UseVisualStyleBackColor = true;
			// 
			// checkBox25
			// 
			this.checkBox25.Checked = true;
			this.checkBox25.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox25.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox25.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox25.Location = new System.Drawing.Point(381, 25);
			this.checkBox25.Name = "checkBox25";
			this.checkBox25.Size = new System.Drawing.Size(175, 24);
			this.checkBox25.TabIndex = 24;
			this.checkBox25.Text = "AD Protection Center";
			this.checkBox25.UseVisualStyleBackColor = true;
			// 
			// chkb_ProtectionCenter
			// 
			this.chkb_ProtectionCenter.Checked = true;
			this.chkb_ProtectionCenter.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_ProtectionCenter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_ProtectionCenter.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_ProtectionCenter.Location = new System.Drawing.Point(380, 25);
			this.chkb_ProtectionCenter.Name = "chkb_ProtectionCenter";
			this.chkb_ProtectionCenter.Size = new System.Drawing.Size(175, 24);
			this.chkb_ProtectionCenter.TabIndex = 24;
			this.chkb_ProtectionCenter.Text = "AD Protection Center";
			this.chkb_ProtectionCenter.UseVisualStyleBackColor = true;
			// 
			// checkBox24
			// 
			this.checkBox24.Checked = true;
			this.checkBox24.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox24.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox24.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox24.Location = new System.Drawing.Point(194, 355);
			this.checkBox24.Name = "checkBox24";
			this.checkBox24.Size = new System.Drawing.Size(181, 24);
			this.checkBox24.TabIndex = 23;
			this.checkBox24.Text = "AD IAM";
			this.checkBox24.UseVisualStyleBackColor = true;
			// 
			// chkb_IAM
			// 
			this.chkb_IAM.Checked = true;
			this.chkb_IAM.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_IAM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_IAM.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_IAM.Location = new System.Drawing.Point(193, 355);
			this.chkb_IAM.Name = "chkb_IAM";
			this.chkb_IAM.Size = new System.Drawing.Size(181, 24);
			this.chkb_IAM.TabIndex = 23;
			this.chkb_IAM.Text = "AD IAM";
			this.chkb_IAM.UseVisualStyleBackColor = true;
			// 
			// checkBox23
			// 
			this.checkBox23.Checked = true;
			this.checkBox23.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox23.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox23.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox23.Location = new System.Drawing.Point(194, 325);
			this.checkBox23.Name = "checkBox23";
			this.checkBox23.Size = new System.Drawing.Size(181, 24);
			this.checkBox23.TabIndex = 22;
			this.checkBox23.Text = "Role Based Access Control";
			this.checkBox23.UseVisualStyleBackColor = true;
			// 
			// chkb_RoleBasedAccessControl
			// 
			this.chkb_RoleBasedAccessControl.Checked = true;
			this.chkb_RoleBasedAccessControl.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_RoleBasedAccessControl.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_RoleBasedAccessControl.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_RoleBasedAccessControl.Location = new System.Drawing.Point(193, 325);
			this.chkb_RoleBasedAccessControl.Name = "chkb_RoleBasedAccessControl";
			this.chkb_RoleBasedAccessControl.Size = new System.Drawing.Size(181, 24);
			this.chkb_RoleBasedAccessControl.TabIndex = 22;
			this.chkb_RoleBasedAccessControl.Text = "Role Based Access Control";
			this.chkb_RoleBasedAccessControl.UseVisualStyleBackColor = true;
			// 
			// checkBox22
			// 
			this.checkBox22.Checked = true;
			this.checkBox22.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox22.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox22.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox22.Location = new System.Drawing.Point(194, 295);
			this.checkBox22.Name = "checkBox22";
			this.checkBox22.Size = new System.Drawing.Size(181, 24);
			this.checkBox22.TabIndex = 21;
			this.checkBox22.Text = "DataInsight Azure SQLDB";
			this.checkBox22.UseVisualStyleBackColor = true;
			// 
			// chkb_SQLDB
			// 
			this.chkb_SQLDB.Checked = true;
			this.chkb_SQLDB.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_SQLDB.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_SQLDB.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_SQLDB.Location = new System.Drawing.Point(193, 295);
			this.chkb_SQLDB.Name = "chkb_SQLDB";
			this.chkb_SQLDB.Size = new System.Drawing.Size(181, 24);
			this.chkb_SQLDB.TabIndex = 21;
			this.chkb_SQLDB.Text = "DataInsight Azure SQLDB";
			this.chkb_SQLDB.UseVisualStyleBackColor = true;
			// 
			// checkBox21
			// 
			this.checkBox21.Checked = true;
			this.checkBox21.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox21.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox21.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox21.Location = new System.Drawing.Point(194, 265);
			this.checkBox21.Name = "checkBox21";
			this.checkBox21.Size = new System.Drawing.Size(181, 24);
			this.checkBox21.TabIndex = 20;
			this.checkBox21.Text = "DataInsight Azure Search";
			this.checkBox21.UseVisualStyleBackColor = true;
			// 
			// chkb_AzureSearch
			// 
			this.chkb_AzureSearch.Checked = true;
			this.chkb_AzureSearch.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_AzureSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_AzureSearch.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_AzureSearch.Location = new System.Drawing.Point(193, 265);
			this.chkb_AzureSearch.Name = "chkb_AzureSearch";
			this.chkb_AzureSearch.Size = new System.Drawing.Size(181, 24);
			this.chkb_AzureSearch.TabIndex = 20;
			this.chkb_AzureSearch.Text = "DataInsight Azure Search";
			this.chkb_AzureSearch.UseVisualStyleBackColor = true;
			// 
			// checkBox20
			// 
			this.checkBox20.Checked = true;
			this.checkBox20.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox20.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox20.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox20.Location = new System.Drawing.Point(194, 235);
			this.checkBox20.Name = "checkBox20";
			this.checkBox20.Size = new System.Drawing.Size(181, 24);
			this.checkBox20.TabIndex = 19;
			this.checkBox20.Text = "DataInsight Azure DocDB";
			this.checkBox20.UseVisualStyleBackColor = true;
			// 
			// chkb_DocDB
			// 
			this.chkb_DocDB.Checked = true;
			this.chkb_DocDB.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_DocDB.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_DocDB.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_DocDB.Location = new System.Drawing.Point(193, 235);
			this.chkb_DocDB.Name = "chkb_DocDB";
			this.chkb_DocDB.Size = new System.Drawing.Size(181, 24);
			this.chkb_DocDB.TabIndex = 19;
			this.chkb_DocDB.Text = "DataInsight Azure DocDB";
			this.chkb_DocDB.UseVisualStyleBackColor = true;
			// 
			// checkBox19
			// 
			this.checkBox19.Checked = true;
			this.checkBox19.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox19.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox19.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox19.Location = new System.Drawing.Point(194, 205);
			this.checkBox19.Name = "checkBox19";
			this.checkBox19.Size = new System.Drawing.Size(181, 24);
			this.checkBox19.TabIndex = 18;
			this.checkBox19.Text = "Microsoft Intune MAM Extension";
			this.checkBox19.UseVisualStyleBackColor = true;
			// 
			// chkb_MicrosoftIntuneMAMExtension
			// 
			this.chkb_MicrosoftIntuneMAMExtension.Checked = true;
			this.chkb_MicrosoftIntuneMAMExtension.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_MicrosoftIntuneMAMExtension.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_MicrosoftIntuneMAMExtension.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_MicrosoftIntuneMAMExtension.Location = new System.Drawing.Point(193, 205);
			this.chkb_MicrosoftIntuneMAMExtension.Name = "chkb_MicrosoftIntuneMAMExtension";
			this.chkb_MicrosoftIntuneMAMExtension.Size = new System.Drawing.Size(181, 24);
			this.chkb_MicrosoftIntuneMAMExtension.TabIndex = 18;
			this.chkb_MicrosoftIntuneMAMExtension.Text = "Microsoft Intune MAM Extension";
			this.chkb_MicrosoftIntuneMAMExtension.UseVisualStyleBackColor = true;
			// 
			// checkBox18
			// 
			this.checkBox18.Checked = true;
			this.checkBox18.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox18.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox18.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox18.Location = new System.Drawing.Point(194, 175);
			this.checkBox18.Name = "checkBox18";
			this.checkBox18.Size = new System.Drawing.Size(181, 24);
			this.checkBox18.TabIndex = 17;
			this.checkBox18.Text = "AD B2C";
			this.checkBox18.UseVisualStyleBackColor = true;
			// 
			// chkb_B2C
			// 
			this.chkb_B2C.Checked = true;
			this.chkb_B2C.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_B2C.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_B2C.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_B2C.Location = new System.Drawing.Point(193, 175);
			this.chkb_B2C.Name = "chkb_B2C";
			this.chkb_B2C.Size = new System.Drawing.Size(181, 24);
			this.chkb_B2C.TabIndex = 17;
			this.chkb_B2C.Text = "AD B2C";
			this.chkb_B2C.UseVisualStyleBackColor = true;
			// 
			// checkBox17
			// 
			this.checkBox17.Checked = true;
			this.checkBox17.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox17.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox17.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox17.Location = new System.Drawing.Point(194, 145);
			this.checkBox17.Name = "checkBox17";
			this.checkBox17.Size = new System.Drawing.Size(181, 24);
			this.checkBox17.TabIndex = 16;
			this.checkBox17.Text = "AD B2B";
			this.checkBox17.UseVisualStyleBackColor = true;
			// 
			// chkb_B2B
			// 
			this.chkb_B2B.Checked = true;
			this.chkb_B2B.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_B2B.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_B2B.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_B2B.Location = new System.Drawing.Point(193, 145);
			this.chkb_B2B.Name = "chkb_B2B";
			this.chkb_B2B.Size = new System.Drawing.Size(181, 24);
			this.chkb_B2B.TabIndex = 16;
			this.chkb_B2B.Text = "AD B2B";
			this.chkb_B2B.UseVisualStyleBackColor = true;
			// 
			// checkBox16
			// 
			this.checkBox16.Checked = true;
			this.checkBox16.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox16.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox16.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox16.Location = new System.Drawing.Point(194, 115);
			this.checkBox16.Name = "checkBox16";
			this.checkBox16.Size = new System.Drawing.Size(181, 24);
			this.checkBox16.TabIndex = 15;
			this.checkBox16.Text = "Windows Azure Pack (Classic)";
			this.checkBox16.UseVisualStyleBackColor = true;
			// 
			// chkb_WindowsAzurePack
			// 
			this.chkb_WindowsAzurePack.Checked = true;
			this.chkb_WindowsAzurePack.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_WindowsAzurePack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_WindowsAzurePack.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_WindowsAzurePack.Location = new System.Drawing.Point(193, 115);
			this.chkb_WindowsAzurePack.Name = "chkb_WindowsAzurePack";
			this.chkb_WindowsAzurePack.Size = new System.Drawing.Size(181, 24);
			this.chkb_WindowsAzurePack.TabIndex = 15;
			this.chkb_WindowsAzurePack.Text = "Windows Azure Pack (Classic)";
			this.chkb_WindowsAzurePack.UseVisualStyleBackColor = true;
			// 
			// checkBox15
			// 
			this.checkBox15.Checked = true;
			this.checkBox15.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox15.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox15.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox15.Location = new System.Drawing.Point(194, 85);
			this.checkBox15.Name = "checkBox15";
			this.checkBox15.Size = new System.Drawing.Size(181, 24);
			this.checkBox15.TabIndex = 14;
			this.checkBox15.Text = "Azure Insight Extension";
			this.checkBox15.UseVisualStyleBackColor = true;
			// 
			// chkb_InsightExtension
			// 
			this.chkb_InsightExtension.Checked = true;
			this.chkb_InsightExtension.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_InsightExtension.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_InsightExtension.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_InsightExtension.Location = new System.Drawing.Point(193, 85);
			this.chkb_InsightExtension.Name = "chkb_InsightExtension";
			this.chkb_InsightExtension.Size = new System.Drawing.Size(181, 24);
			this.chkb_InsightExtension.TabIndex = 14;
			this.chkb_InsightExtension.Text = "Azure Insight Extension";
			this.chkb_InsightExtension.UseVisualStyleBackColor = true;
			// 
			// checkBox14
			// 
			this.checkBox14.Checked = true;
			this.checkBox14.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox14.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox14.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox14.Location = new System.Drawing.Point(194, 55);
			this.checkBox14.Name = "checkBox14";
			this.checkBox14.Size = new System.Drawing.Size(181, 24);
			this.checkBox14.TabIndex = 13;
			this.checkBox14.Text = "Azure Portal (Classic)";
			this.checkBox14.UseVisualStyleBackColor = true;
			// 
			// chkb_PortalClassic
			// 
			this.chkb_PortalClassic.Checked = true;
			this.chkb_PortalClassic.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_PortalClassic.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_PortalClassic.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_PortalClassic.Location = new System.Drawing.Point(193, 55);
			this.chkb_PortalClassic.Name = "chkb_PortalClassic";
			this.chkb_PortalClassic.Size = new System.Drawing.Size(181, 24);
			this.chkb_PortalClassic.TabIndex = 13;
			this.chkb_PortalClassic.Text = "Azure Portal (Classic)";
			this.chkb_PortalClassic.UseVisualStyleBackColor = true;
			// 
			// chbx_MFA_SAS
			// 
			this.chbx_MFA_SAS.Checked = true;
			this.chbx_MFA_SAS.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_MFA_SAS.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_MFA_SAS.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_MFA_SAS.Location = new System.Drawing.Point(194, 25);
			this.chbx_MFA_SAS.Name = "chbx_MFA_SAS";
			this.chbx_MFA_SAS.Size = new System.Drawing.Size(181, 24);
			this.chbx_MFA_SAS.TabIndex = 12;
			this.chbx_MFA_SAS.Text = "Azure Store Experience";
			this.chbx_MFA_SAS.UseVisualStyleBackColor = true;
			// 
			// chkb_StoreExperience
			// 
			this.chkb_StoreExperience.Checked = true;
			this.chkb_StoreExperience.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_StoreExperience.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_StoreExperience.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_StoreExperience.Location = new System.Drawing.Point(193, 25);
			this.chkb_StoreExperience.Name = "chkb_StoreExperience";
			this.chkb_StoreExperience.Size = new System.Drawing.Size(181, 24);
			this.chkb_StoreExperience.TabIndex = 12;
			this.chkb_StoreExperience.Text = "Azure Store Experience";
			this.chkb_StoreExperience.UseVisualStyleBackColor = true;
			// 
			// chbx_IAMUX
			// 
			this.chbx_IAMUX.Checked = true;
			this.chbx_IAMUX.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_IAMUX.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_IAMUX.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_IAMUX.Location = new System.Drawing.Point(7, 355);
			this.chbx_IAMUX.Name = "chbx_IAMUX";
			this.chbx_IAMUX.Size = new System.Drawing.Size(181, 24);
			this.chbx_IAMUX.TabIndex = 11;
			this.chbx_IAMUX.Text = "IAMUX";
			this.chbx_IAMUX.UseVisualStyleBackColor = true;
			// 
			// chkb_StoreMarketplace
			// 
			this.chkb_StoreMarketplace.Checked = true;
			this.chkb_StoreMarketplace.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_StoreMarketplace.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_StoreMarketplace.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_StoreMarketplace.Location = new System.Drawing.Point(6, 355);
			this.chkb_StoreMarketplace.Name = "chkb_StoreMarketplace";
			this.chkb_StoreMarketplace.Size = new System.Drawing.Size(181, 24);
			this.chkb_StoreMarketplace.TabIndex = 11;
			this.chkb_StoreMarketplace.Text = "Azure Store Marketplace";
			this.chkb_StoreMarketplace.UseVisualStyleBackColor = true;
			// 
			// chbx_AzureSecurityCenter
			// 
			this.chbx_AzureSecurityCenter.Checked = true;
			this.chbx_AzureSecurityCenter.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_AzureSecurityCenter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_AzureSecurityCenter.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_AzureSecurityCenter.Location = new System.Drawing.Point(7, 325);
			this.chbx_AzureSecurityCenter.Name = "chbx_AzureSecurityCenter";
			this.chbx_AzureSecurityCenter.Size = new System.Drawing.Size(181, 24);
			this.chbx_AzureSecurityCenter.TabIndex = 10;
			this.chbx_AzureSecurityCenter.Text = "Azure Security Center";
			this.chbx_AzureSecurityCenter.UseVisualStyleBackColor = true;
			// 
			// chkb_InsightCommon
			// 
			this.chkb_InsightCommon.Checked = true;
			this.chkb_InsightCommon.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_InsightCommon.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_InsightCommon.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_InsightCommon.Location = new System.Drawing.Point(6, 325);
			this.chkb_InsightCommon.Name = "chkb_InsightCommon";
			this.chkb_InsightCommon.Size = new System.Drawing.Size(181, 24);
			this.chkb_InsightCommon.TabIndex = 10;
			this.chkb_InsightCommon.Text = "Azure Insight Common";
			this.chkb_InsightCommon.UseVisualStyleBackColor = true;
			// 
			// chbx_PIM
			// 
			this.chbx_PIM.Checked = true;
			this.chbx_PIM.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_PIM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_PIM.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_PIM.Location = new System.Drawing.Point(7, 295);
			this.chbx_PIM.Name = "chbx_PIM";
			this.chbx_PIM.Size = new System.Drawing.Size(181, 24);
			this.chbx_PIM.TabIndex = 9;
			this.chbx_PIM.Text = "PIM";
			this.chbx_PIM.UseVisualStyleBackColor = true;
			// 
			// chkb_InsightMonRP
			// 
			this.chkb_InsightMonRP.Checked = true;
			this.chkb_InsightMonRP.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_InsightMonRP.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_InsightMonRP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_InsightMonRP.Location = new System.Drawing.Point(6, 295);
			this.chkb_InsightMonRP.Name = "chkb_InsightMonRP";
			this.chkb_InsightMonRP.Size = new System.Drawing.Size(181, 24);
			this.chkb_InsightMonRP.TabIndex = 9;
			this.chkb_InsightMonRP.Text = "Azure Insight MonRP";
			this.chkb_InsightMonRP.UseVisualStyleBackColor = true;
			// 
			// chbx_MIM
			// 
			this.chbx_MIM.Checked = true;
			this.chbx_MIM.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_MIM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_MIM.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_MIM.Location = new System.Drawing.Point(7, 265);
			this.chbx_MIM.Name = "chbx_MIM";
			this.chbx_MIM.Size = new System.Drawing.Size(181, 24);
			this.chbx_MIM.TabIndex = 8;
			this.chbx_MIM.Text = "MIM";
			this.chbx_MIM.UseVisualStyleBackColor = true;
			// 
			// chkb_InsightEvtRP
			// 
			this.chkb_InsightEvtRP.Checked = true;
			this.chkb_InsightEvtRP.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_InsightEvtRP.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_InsightEvtRP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_InsightEvtRP.Location = new System.Drawing.Point(6, 265);
			this.chkb_InsightEvtRP.Name = "chkb_InsightEvtRP";
			this.chkb_InsightEvtRP.Size = new System.Drawing.Size(181, 24);
			this.chkb_InsightEvtRP.TabIndex = 8;
			this.chkb_InsightEvtRP.Text = "Azure Insight EvtRP";
			this.chkb_InsightEvtRP.UseVisualStyleBackColor = true;
			// 
			// chbx_Atlanta
			// 
			this.chbx_Atlanta.Checked = true;
			this.chbx_Atlanta.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_Atlanta.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_Atlanta.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_Atlanta.Location = new System.Drawing.Point(7, 235);
			this.chbx_Atlanta.Name = "chbx_Atlanta";
			this.chbx_Atlanta.Size = new System.Drawing.Size(181, 24);
			this.chbx_Atlanta.TabIndex = 7;
			this.chbx_Atlanta.Text = "Atlanta";
			this.chbx_Atlanta.UseVisualStyleBackColor = true;
			// 
			// chkb_InsightNotRP
			// 
			this.chkb_InsightNotRP.Checked = true;
			this.chkb_InsightNotRP.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_InsightNotRP.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_InsightNotRP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_InsightNotRP.Location = new System.Drawing.Point(6, 235);
			this.chkb_InsightNotRP.Name = "chkb_InsightNotRP";
			this.chkb_InsightNotRP.Size = new System.Drawing.Size(181, 24);
			this.chkb_InsightNotRP.TabIndex = 7;
			this.chkb_InsightNotRP.Text = "Azure Insight NotRP";
			this.chkb_InsightNotRP.UseVisualStyleBackColor = true;
			// 
			// chbx_Adallom
			// 
			this.chbx_Adallom.Checked = true;
			this.chbx_Adallom.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_Adallom.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_Adallom.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_Adallom.Location = new System.Drawing.Point(8, 205);
			this.chbx_Adallom.Name = "chbx_Adallom";
			this.chbx_Adallom.Size = new System.Drawing.Size(181, 24);
			this.chbx_Adallom.TabIndex = 6;
			this.chbx_Adallom.Text = "Adallom";
			this.chbx_Adallom.UseVisualStyleBackColor = true;
			// 
			// chkb_PortalFX
			// 
			this.chkb_PortalFX.Checked = true;
			this.chkb_PortalFX.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_PortalFX.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_PortalFX.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_PortalFX.Location = new System.Drawing.Point(7, 205);
			this.chkb_PortalFX.Name = "chkb_PortalFX";
			this.chkb_PortalFX.Size = new System.Drawing.Size(181, 24);
			this.chkb_PortalFX.TabIndex = 6;
			this.chkb_PortalFX.Text = "Azure Portal FX";
			this.chkb_PortalFX.UseVisualStyleBackColor = true;
			// 
			// chbx_ESTS
			// 
			this.chbx_ESTS.Checked = true;
			this.chbx_ESTS.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_ESTS.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_ESTS.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_ESTS.Location = new System.Drawing.Point(7, 175);
			this.chbx_ESTS.Name = "chbx_ESTS";
			this.chbx_ESTS.Size = new System.Drawing.Size(181, 24);
			this.chbx_ESTS.TabIndex = 5;
			this.chbx_ESTS.Text = "ESTS";
			this.chbx_ESTS.UseVisualStyleBackColor = true;
			// 
			// chkb_ResourceManager
			// 
			this.chkb_ResourceManager.Checked = true;
			this.chkb_ResourceManager.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_ResourceManager.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_ResourceManager.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_ResourceManager.Location = new System.Drawing.Point(6, 175);
			this.chkb_ResourceManager.Name = "chkb_ResourceManager";
			this.chkb_ResourceManager.Size = new System.Drawing.Size(181, 24);
			this.chkb_ResourceManager.TabIndex = 5;
			this.chkb_ResourceManager.Text = "Azure Resource Manager";
			this.chkb_ResourceManager.UseVisualStyleBackColor = true;
			// 
			// chbx_MSA
			// 
			this.chbx_MSA.Checked = true;
			this.chbx_MSA.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_MSA.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_MSA.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_MSA.Location = new System.Drawing.Point(7, 145);
			this.chbx_MSA.Name = "chbx_MSA";
			this.chbx_MSA.Size = new System.Drawing.Size(181, 24);
			this.chbx_MSA.TabIndex = 4;
			this.chbx_MSA.Text = "MSA";
			this.chbx_MSA.UseVisualStyleBackColor = true;
			// 
			// chkb_ResourceProviderSDK
			// 
			this.chkb_ResourceProviderSDK.Checked = true;
			this.chkb_ResourceProviderSDK.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_ResourceProviderSDK.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_ResourceProviderSDK.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_ResourceProviderSDK.Location = new System.Drawing.Point(6, 145);
			this.chkb_ResourceProviderSDK.Name = "chkb_ResourceProviderSDK";
			this.chkb_ResourceProviderSDK.Size = new System.Drawing.Size(181, 24);
			this.chkb_ResourceProviderSDK.TabIndex = 4;
			this.chkb_ResourceProviderSDK.Text = "Azure Resource Provider SDK";
			this.chkb_ResourceProviderSDK.UseVisualStyleBackColor = true;
			// 
			// chbxADConnectHealth
			// 
			this.chbxADConnectHealth.Checked = true;
			this.chbxADConnectHealth.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbxADConnectHealth.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbxADConnectHealth.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbxADConnectHealth.Location = new System.Drawing.Point(7, 115);
			this.chbxADConnectHealth.Name = "chbxADConnectHealth";
			this.chbxADConnectHealth.Size = new System.Drawing.Size(181, 24);
			this.chbxADConnectHealth.TabIndex = 3;
			this.chbxADConnectHealth.Text = "AD Connect Health";
			this.chbxADConnectHealth.UseVisualStyleBackColor = true;
			// 
			// chkb_RedisCacheExtension
			// 
			this.chkb_RedisCacheExtension.Checked = true;
			this.chkb_RedisCacheExtension.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_RedisCacheExtension.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_RedisCacheExtension.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_RedisCacheExtension.Location = new System.Drawing.Point(6, 115);
			this.chkb_RedisCacheExtension.Name = "chkb_RedisCacheExtension";
			this.chkb_RedisCacheExtension.Size = new System.Drawing.Size(181, 24);
			this.chkb_RedisCacheExtension.TabIndex = 3;
			this.chkb_RedisCacheExtension.Text = "Azure Redis Cache Extension";
			this.chkb_RedisCacheExtension.UseVisualStyleBackColor = true;
			// 
			// chbx_ADConnect
			// 
			this.chbx_ADConnect.Checked = true;
			this.chbx_ADConnect.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_ADConnect.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_ADConnect.Location = new System.Drawing.Point(7, 85);
			this.chbx_ADConnect.Name = "chbx_ADConnect";
			this.chbx_ADConnect.Size = new System.Drawing.Size(181, 24);
			this.chbx_ADConnect.TabIndex = 2;
			this.chbx_ADConnect.Text = "AD Connect";
			this.chbx_ADConnect.UseVisualStyleBackColor = true;
			// 
			// chkb_RedisChacheRP
			// 
			this.chkb_RedisChacheRP.Checked = true;
			this.chkb_RedisChacheRP.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_RedisChacheRP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_RedisChacheRP.Location = new System.Drawing.Point(6, 85);
			this.chkb_RedisChacheRP.Name = "chkb_RedisChacheRP";
			this.chkb_RedisChacheRP.Size = new System.Drawing.Size(181, 24);
			this.chkb_RedisChacheRP.TabIndex = 2;
			this.chkb_RedisChacheRP.Text = "Azure Redis Cache RP";
			this.chkb_RedisChacheRP.UseVisualStyleBackColor = true;
			// 
			// chbx_ADBillingExtension
			// 
			this.chbx_ADBillingExtension.Checked = true;
			this.chbx_ADBillingExtension.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_ADBillingExtension.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_ADBillingExtension.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_ADBillingExtension.Location = new System.Drawing.Point(7, 55);
			this.chbx_ADBillingExtension.Name = "chbx_ADBillingExtension";
			this.chbx_ADBillingExtension.Size = new System.Drawing.Size(181, 24);
			this.chbx_ADBillingExtension.TabIndex = 1;
			this.chbx_ADBillingExtension.Text = "AD Billing Extension";
			this.chbx_ADBillingExtension.UseVisualStyleBackColor = true;
			// 
			// chkbx_ADBilling
			// 
			this.chkbx_ADBilling.Checked = true;
			this.chkbx_ADBilling.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_ADBilling.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_ADBilling.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_ADBilling.Location = new System.Drawing.Point(8, 25);
			this.chkbx_ADBilling.Name = "chkbx_ADBilling";
			this.chkbx_ADBilling.Size = new System.Drawing.Size(180, 24);
			this.chkbx_ADBilling.TabIndex = 0;
			this.chkbx_ADBilling.Text = "AD Billing";
			this.chkbx_ADBilling.UseVisualStyleBackColor = true;
			// 
			// chkb_SchedulerRP
			// 
			this.chkb_SchedulerRP.Checked = true;
			this.chkb_SchedulerRP.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_SchedulerRP.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_SchedulerRP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_SchedulerRP.Location = new System.Drawing.Point(6, 55);
			this.chkb_SchedulerRP.Name = "chkb_SchedulerRP";
			this.chkb_SchedulerRP.Size = new System.Drawing.Size(181, 24);
			this.chkb_SchedulerRP.TabIndex = 1;
			this.chkb_SchedulerRP.Text = "Azure Scheduler RP";
			this.chkb_SchedulerRP.UseVisualStyleBackColor = true;
			// 
			// chkb_SchedulerExtension
			// 
			this.chkb_SchedulerExtension.Checked = true;
			this.chkb_SchedulerExtension.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkb_SchedulerExtension.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkb_SchedulerExtension.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkb_SchedulerExtension.Location = new System.Drawing.Point(7, 25);
			this.chkb_SchedulerExtension.Name = "chkb_SchedulerExtension";
			this.chkb_SchedulerExtension.Size = new System.Drawing.Size(180, 24);
			this.chkb_SchedulerExtension.TabIndex = 0;
			this.chkb_SchedulerExtension.Text = "Azure Scheduler Extension";
			this.chkb_SchedulerExtension.UseVisualStyleBackColor = true;
			// 
			// LblTitle_Panel1
			// 
			this.LblTitle_Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblTitle_Panel1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTitle_Panel1.ForeColor = System.Drawing.Color.SlateBlue;
			this.LblTitle_Panel1.Location = new System.Drawing.Point(0, 0);
			this.LblTitle_Panel1.Name = "LblTitle_Panel1";
			this.LblTitle_Panel1.Size = new System.Drawing.Size(565, 626);
			this.LblTitle_Panel1.TabIndex = 4;
			this.LblTitle_Panel1.Text = "Please, select components to create structure";
			this.LblTitle_Panel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pb_structure
			// 
			this.pb_structure.Location = new System.Drawing.Point(8, 455);
			this.pb_structure.Name = "pb_structure";
			this.pb_structure.Size = new System.Drawing.Size(561, 23);
			this.pb_structure.TabIndex = 6;
			// 
			// AD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1083, 626);
			this.Controls.Add(this.PanelRight);
			this.Controls.Add(this.PanelLeft);
			this.Name = "AD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AD";
			this.PanelLeft.ResumeLayout(false);
			this.GrBox_Select_Components.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
