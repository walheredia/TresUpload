/*
 * Created by SharpDevelop.
 * User: walterh
 * Date: 5/6/2016
 * Time: 12:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TresUpload
{
	partial class Azure
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label LblTitle_Panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox GrBox_Select_Components;
		private System.Windows.Forms.CheckBox chkb_StoreMarketplace;
		private System.Windows.Forms.CheckBox chkb_InsightCommon;
		private System.Windows.Forms.CheckBox chkb_InsightMonRP;
		private System.Windows.Forms.CheckBox chkb_InsightEvtRP;
		private System.Windows.Forms.CheckBox chkb_InsightNotRP;
		private System.Windows.Forms.CheckBox chkb_PortalFX;
		private System.Windows.Forms.CheckBox chkb_ResourceManager;
		private System.Windows.Forms.CheckBox chkb_ResourceProviderSDK;
		private System.Windows.Forms.CheckBox chkb_RedisCacheExtension;
		private System.Windows.Forms.CheckBox chkb_RedisChacheRP;
		private System.Windows.Forms.CheckBox chkb_SchedulerRP;
		private System.Windows.Forms.CheckBox chkb_SchedulerExtension;
		private System.Windows.Forms.CheckBox chkb_CloudAppDiscovery;
		private System.Windows.Forms.CheckBox chkb_ProtectionCenter;
		private System.Windows.Forms.CheckBox chkb_IAM;
		private System.Windows.Forms.CheckBox chkb_RoleBasedAccessControl;
		private System.Windows.Forms.CheckBox chkb_SQLDB;
		private System.Windows.Forms.CheckBox chkb_AzureSearch;
		private System.Windows.Forms.CheckBox chkb_DocDB;
		private System.Windows.Forms.CheckBox chkb_MicrosoftIntuneMAMExtension;
		private System.Windows.Forms.CheckBox chkb_B2C;
		private System.Windows.Forms.CheckBox chkb_B2B;
		private System.Windows.Forms.CheckBox chkb_WindowsAzurePack;
		private System.Windows.Forms.CheckBox chkb_InsightExtension;
		private System.Windows.Forms.CheckBox chkb_PortalClassic;
		private System.Windows.Forms.CheckBox chkb_StoreExperience;
		private System.Windows.Forms.Button btn_CheckAll;
		private System.Windows.Forms.Button btn_UnCheckAll;
		private System.Windows.Forms.Button btn_Invert;
		private System.Windows.Forms.ProgressBar pb_structure;
		private System.Windows.Forms.Button btn_CreateStructure;
		private System.Windows.Forms.FolderBrowserDialog fbd_createStructure;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Azure));
			this.panel1 = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.btn_CreateStructure = new System.Windows.Forms.Button();
			this.pb_structure = new System.Windows.Forms.ProgressBar();
			this.GrBox_Select_Components = new System.Windows.Forms.GroupBox();
			this.btn_Invert = new System.Windows.Forms.Button();
			this.btn_CheckAll = new System.Windows.Forms.Button();
			this.btn_UnCheckAll = new System.Windows.Forms.Button();
			this.chkb_CloudAppDiscovery = new System.Windows.Forms.CheckBox();
			this.chkb_ProtectionCenter = new System.Windows.Forms.CheckBox();
			this.chkb_IAM = new System.Windows.Forms.CheckBox();
			this.chkb_RoleBasedAccessControl = new System.Windows.Forms.CheckBox();
			this.chkb_SQLDB = new System.Windows.Forms.CheckBox();
			this.chkb_AzureSearch = new System.Windows.Forms.CheckBox();
			this.chkb_DocDB = new System.Windows.Forms.CheckBox();
			this.chkb_MicrosoftIntuneMAMExtension = new System.Windows.Forms.CheckBox();
			this.chkb_B2C = new System.Windows.Forms.CheckBox();
			this.chkb_B2B = new System.Windows.Forms.CheckBox();
			this.chkb_WindowsAzurePack = new System.Windows.Forms.CheckBox();
			this.chkb_InsightExtension = new System.Windows.Forms.CheckBox();
			this.chkb_PortalClassic = new System.Windows.Forms.CheckBox();
			this.chkb_StoreExperience = new System.Windows.Forms.CheckBox();
			this.chkb_StoreMarketplace = new System.Windows.Forms.CheckBox();
			this.chkb_InsightCommon = new System.Windows.Forms.CheckBox();
			this.chkb_InsightMonRP = new System.Windows.Forms.CheckBox();
			this.chkb_InsightEvtRP = new System.Windows.Forms.CheckBox();
			this.chkb_InsightNotRP = new System.Windows.Forms.CheckBox();
			this.chkb_PortalFX = new System.Windows.Forms.CheckBox();
			this.chkb_ResourceManager = new System.Windows.Forms.CheckBox();
			this.chkb_ResourceProviderSDK = new System.Windows.Forms.CheckBox();
			this.chkb_RedisCacheExtension = new System.Windows.Forms.CheckBox();
			this.chkb_RedisChacheRP = new System.Windows.Forms.CheckBox();
			this.chkb_SchedulerRP = new System.Windows.Forms.CheckBox();
			this.chkb_SchedulerExtension = new System.Windows.Forms.CheckBox();
			this.LblTitle_Panel1 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.fbd_createStructure = new System.Windows.Forms.FolderBrowserDialog();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.GrBox_Select_Components.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.Controls.Add(this.splitContainer1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1147, 663);
			this.panel1.TabIndex = 0;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.btn_CreateStructure);
			this.splitContainer1.Panel1.Controls.Add(this.pb_structure);
			this.splitContainer1.Panel1.Controls.Add(this.GrBox_Select_Components);
			this.splitContainer1.Panel1.Controls.Add(this.LblTitle_Panel1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Size = new System.Drawing.Size(1147, 663);
			this.splitContainer1.SplitterDistance = 614;
			this.splitContainer1.TabIndex = 0;
			// 
			// btn_CreateStructure
			// 
			this.btn_CreateStructure.Location = new System.Drawing.Point(392, 484);
			this.btn_CreateStructure.Name = "btn_CreateStructure";
			this.btn_CreateStructure.Size = new System.Drawing.Size(181, 23);
			this.btn_CreateStructure.TabIndex = 3;
			this.btn_CreateStructure.Text = "Create Structure";
			this.btn_CreateStructure.UseVisualStyleBackColor = true;
			this.btn_CreateStructure.Click += new System.EventHandler(this.Btn_CreateStructureClick);
			// 
			// pb_structure
			// 
			this.pb_structure.Location = new System.Drawing.Point(12, 455);
			this.pb_structure.Name = "pb_structure";
			this.pb_structure.Size = new System.Drawing.Size(561, 23);
			this.pb_structure.TabIndex = 2;
			// 
			// GrBox_Select_Components
			// 
			this.GrBox_Select_Components.Controls.Add(this.btn_Invert);
			this.GrBox_Select_Components.Controls.Add(this.btn_CheckAll);
			this.GrBox_Select_Components.Controls.Add(this.btn_UnCheckAll);
			this.GrBox_Select_Components.Controls.Add(this.chkb_CloudAppDiscovery);
			this.GrBox_Select_Components.Controls.Add(this.chkb_ProtectionCenter);
			this.GrBox_Select_Components.Controls.Add(this.chkb_IAM);
			this.GrBox_Select_Components.Controls.Add(this.chkb_RoleBasedAccessControl);
			this.GrBox_Select_Components.Controls.Add(this.chkb_SQLDB);
			this.GrBox_Select_Components.Controls.Add(this.chkb_AzureSearch);
			this.GrBox_Select_Components.Controls.Add(this.chkb_DocDB);
			this.GrBox_Select_Components.Controls.Add(this.chkb_MicrosoftIntuneMAMExtension);
			this.GrBox_Select_Components.Controls.Add(this.chkb_B2C);
			this.GrBox_Select_Components.Controls.Add(this.chkb_B2B);
			this.GrBox_Select_Components.Controls.Add(this.chkb_WindowsAzurePack);
			this.GrBox_Select_Components.Controls.Add(this.chkb_InsightExtension);
			this.GrBox_Select_Components.Controls.Add(this.chkb_PortalClassic);
			this.GrBox_Select_Components.Controls.Add(this.chkb_StoreExperience);
			this.GrBox_Select_Components.Controls.Add(this.chkb_StoreMarketplace);
			this.GrBox_Select_Components.Controls.Add(this.chkb_InsightCommon);
			this.GrBox_Select_Components.Controls.Add(this.chkb_InsightMonRP);
			this.GrBox_Select_Components.Controls.Add(this.chkb_InsightEvtRP);
			this.GrBox_Select_Components.Controls.Add(this.chkb_InsightNotRP);
			this.GrBox_Select_Components.Controls.Add(this.chkb_PortalFX);
			this.GrBox_Select_Components.Controls.Add(this.chkb_ResourceManager);
			this.GrBox_Select_Components.Controls.Add(this.chkb_ResourceProviderSDK);
			this.GrBox_Select_Components.Controls.Add(this.chkb_RedisCacheExtension);
			this.GrBox_Select_Components.Controls.Add(this.chkb_RedisChacheRP);
			this.GrBox_Select_Components.Controls.Add(this.chkb_SchedulerRP);
			this.GrBox_Select_Components.Controls.Add(this.chkb_SchedulerExtension);
			this.GrBox_Select_Components.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GrBox_Select_Components.ForeColor = System.Drawing.Color.SlateBlue;
			this.GrBox_Select_Components.Location = new System.Drawing.Point(12, 31);
			this.GrBox_Select_Components.MaximumSize = new System.Drawing.Size(561, 392);
			this.GrBox_Select_Components.MinimumSize = new System.Drawing.Size(561, 392);
			this.GrBox_Select_Components.Name = "GrBox_Select_Components";
			this.GrBox_Select_Components.Size = new System.Drawing.Size(561, 392);
			this.GrBox_Select_Components.TabIndex = 1;
			this.GrBox_Select_Components.TabStop = false;
			this.GrBox_Select_Components.Text = "Check components";
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
			this.btn_Invert.Click += new System.EventHandler(this.Button1Click);
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
			this.btn_CheckAll.Click += new System.EventHandler(this.Btn_CheckAllClick);
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
			this.btn_UnCheckAll.Click += new System.EventHandler(this.Btn_UnCheckAllClick);
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
			this.LblTitle_Panel1.Size = new System.Drawing.Size(614, 663);
			this.LblTitle_Panel1.TabIndex = 0;
			this.LblTitle_Panel1.Text = "Please, select components to create structure";
			this.LblTitle_Panel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.SlateBlue;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(529, 663);
			this.label1.TabIndex = 1;
			this.label1.Text = "Here will be everything related to source files";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Azure
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1147, 663);
			this.Controls.Add(this.panel1);
			this.Name = "Azure";
			this.Text = "Azure";
			this.panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.GrBox_Select_Components.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
