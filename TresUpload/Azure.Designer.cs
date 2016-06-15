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
		private System.Windows.Forms.ProgressBar pb_structure;
		private System.Windows.Forms.Button btn_CreateStructure;
		private System.Windows.Forms.FolderBrowserDialog fbd_createStructure;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox chkbx_CloudAppDiscovery;
		private System.Windows.Forms.CheckBox chkbx_ADProtectionCenter;
		private System.Windows.Forms.CheckBox chkbx_ADIAM;
		private System.Windows.Forms.CheckBox chkbx_RBAC;
		private System.Windows.Forms.CheckBox chkbx_SQLDB;
		private System.Windows.Forms.CheckBox chkbx_AzureSearch;
		private System.Windows.Forms.CheckBox chkbx_DocDB;
		private System.Windows.Forms.CheckBox chkbx_IntuneMAMExtension;
		private System.Windows.Forms.CheckBox chkbx_B2C;
		private System.Windows.Forms.CheckBox chkbx_B2B;
		private System.Windows.Forms.CheckBox chkbx_WindowsAzurePack;
		private System.Windows.Forms.CheckBox chkbx_InsightExtension;
		private System.Windows.Forms.CheckBox chkbx_PortalClassic;
		private System.Windows.Forms.CheckBox chkbx_StoreExperience;
		private System.Windows.Forms.CheckBox chkbx_StoreMarketplace;
		private System.Windows.Forms.CheckBox chkbx_InsightCommon;
		private System.Windows.Forms.CheckBox chkbx_InsightMonRP;
		private System.Windows.Forms.CheckBox chkbx_InsightEvtRP;
		private System.Windows.Forms.CheckBox chkbx_InsightNotRP;
		private System.Windows.Forms.CheckBox chkbx_PortalFX;
		private System.Windows.Forms.CheckBox chkbx_ResourceManager;
		private System.Windows.Forms.CheckBox chkbx_ResourceProviderSDK;
		private System.Windows.Forms.CheckBox chkbx_RedisCacheExtension;
		private System.Windows.Forms.CheckBox chkbx_RedisChacheRP;
		private System.Windows.Forms.CheckBox chkbx_SchedulerRP;
		private System.Windows.Forms.CheckBox chkbx_SchedulerExtension;
		
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
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.chkbx_CloudAppDiscovery = new System.Windows.Forms.CheckBox();
			this.chkbx_ADProtectionCenter = new System.Windows.Forms.CheckBox();
			this.chkbx_ADIAM = new System.Windows.Forms.CheckBox();
			this.chkbx_RBAC = new System.Windows.Forms.CheckBox();
			this.chkbx_SQLDB = new System.Windows.Forms.CheckBox();
			this.chkbx_AzureSearch = new System.Windows.Forms.CheckBox();
			this.chkbx_DocDB = new System.Windows.Forms.CheckBox();
			this.chkbx_IntuneMAMExtension = new System.Windows.Forms.CheckBox();
			this.chkbx_B2C = new System.Windows.Forms.CheckBox();
			this.chkbx_B2B = new System.Windows.Forms.CheckBox();
			this.chkbx_WindowsAzurePack = new System.Windows.Forms.CheckBox();
			this.chkbx_InsightExtension = new System.Windows.Forms.CheckBox();
			this.chkbx_PortalClassic = new System.Windows.Forms.CheckBox();
			this.chkbx_StoreExperience = new System.Windows.Forms.CheckBox();
			this.chkbx_StoreMarketplace = new System.Windows.Forms.CheckBox();
			this.chkbx_InsightCommon = new System.Windows.Forms.CheckBox();
			this.chkbx_InsightMonRP = new System.Windows.Forms.CheckBox();
			this.chkbx_InsightEvtRP = new System.Windows.Forms.CheckBox();
			this.chkbx_InsightNotRP = new System.Windows.Forms.CheckBox();
			this.chkbx_PortalFX = new System.Windows.Forms.CheckBox();
			this.chkbx_ResourceManager = new System.Windows.Forms.CheckBox();
			this.chkbx_ResourceProviderSDK = new System.Windows.Forms.CheckBox();
			this.chkbx_RedisCacheExtension = new System.Windows.Forms.CheckBox();
			this.chkbx_RedisChacheRP = new System.Windows.Forms.CheckBox();
			this.chkbx_SchedulerRP = new System.Windows.Forms.CheckBox();
			this.chkbx_SchedulerExtension = new System.Windows.Forms.CheckBox();
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
			this.btn_CreateStructure.Location = new System.Drawing.Point(403, 624);
			this.btn_CreateStructure.Name = "btn_CreateStructure";
			this.btn_CreateStructure.Size = new System.Drawing.Size(170, 27);
			this.btn_CreateStructure.TabIndex = 3;
			this.btn_CreateStructure.Text = "Create Structure";
			this.btn_CreateStructure.UseVisualStyleBackColor = true;
			this.btn_CreateStructure.Click += new System.EventHandler(this.Btn_CreateStructureClick);
			// 
			// pb_structure
			// 
			this.pb_structure.Location = new System.Drawing.Point(12, 595);
			this.pb_structure.Name = "pb_structure";
			this.pb_structure.Size = new System.Drawing.Size(561, 23);
			this.pb_structure.TabIndex = 2;
			// 
			// GrBox_Select_Components
			// 
			this.GrBox_Select_Components.Controls.Add(this.button3);
			this.GrBox_Select_Components.Controls.Add(this.button2);
			this.GrBox_Select_Components.Controls.Add(this.button1);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_CloudAppDiscovery);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_ADProtectionCenter);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_ADIAM);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_RBAC);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_SQLDB);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_AzureSearch);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_DocDB);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_IntuneMAMExtension);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_B2C);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_B2B);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_WindowsAzurePack);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_InsightExtension);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_PortalClassic);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_StoreExperience);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_StoreMarketplace);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_InsightCommon);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_InsightMonRP);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_InsightEvtRP);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_InsightNotRP);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_PortalFX);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_ResourceManager);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_ResourceProviderSDK);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_RedisCacheExtension);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_RedisChacheRP);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_SchedulerRP);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_SchedulerExtension);
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
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button3.Location = new System.Drawing.Point(479, 313);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(76, 66);
			this.button3.TabIndex = 29;
			this.button3.Text = "Invert";
			this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(391, 313);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(82, 30);
			this.button2.TabIndex = 28;
			this.button2.Text = "Check All";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Btn_CheckAllClick);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(391, 349);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 30);
			this.button1.TabIndex = 27;
			this.button1.Text = "Uncheck All";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Btn_UnCheckAllClick);
			// 
			// chkbx_CloudAppDiscovery
			// 
			this.chkbx_CloudAppDiscovery.Checked = true;
			this.chkbx_CloudAppDiscovery.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_CloudAppDiscovery.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_CloudAppDiscovery.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_CloudAppDiscovery.Location = new System.Drawing.Point(391, 55);
			this.chkbx_CloudAppDiscovery.Name = "chkbx_CloudAppDiscovery";
			this.chkbx_CloudAppDiscovery.Size = new System.Drawing.Size(164, 24);
			this.chkbx_CloudAppDiscovery.TabIndex = 25;
			this.chkbx_CloudAppDiscovery.Text = "Cloud App Discovery (17)";
			this.chkbx_CloudAppDiscovery.UseVisualStyleBackColor = true;
			// 
			// chkbx_ADProtectionCenter
			// 
			this.chkbx_ADProtectionCenter.Checked = true;
			this.chkbx_ADProtectionCenter.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_ADProtectionCenter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_ADProtectionCenter.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_ADProtectionCenter.Location = new System.Drawing.Point(391, 25);
			this.chkbx_ADProtectionCenter.Name = "chkbx_ADProtectionCenter";
			this.chkbx_ADProtectionCenter.Size = new System.Drawing.Size(150, 24);
			this.chkbx_ADProtectionCenter.TabIndex = 24;
			this.chkbx_ADProtectionCenter.Text = "AD Protection Center (17)";
			this.chkbx_ADProtectionCenter.UseVisualStyleBackColor = true;
			// 
			// chkbx_ADIAM
			// 
			this.chkbx_ADIAM.Checked = true;
			this.chkbx_ADIAM.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_ADIAM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_ADIAM.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_ADIAM.Location = new System.Drawing.Point(202, 355);
			this.chkbx_ADIAM.Name = "chkbx_ADIAM";
			this.chkbx_ADIAM.Size = new System.Drawing.Size(181, 24);
			this.chkbx_ADIAM.TabIndex = 23;
			this.chkbx_ADIAM.Text = "AD IAM (17)";
			this.chkbx_ADIAM.UseVisualStyleBackColor = true;
			// 
			// chkbx_RBAC
			// 
			this.chkbx_RBAC.Checked = true;
			this.chkbx_RBAC.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_RBAC.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_RBAC.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_RBAC.Location = new System.Drawing.Point(202, 325);
			this.chkbx_RBAC.Name = "chkbx_RBAC";
			this.chkbx_RBAC.Size = new System.Drawing.Size(181, 24);
			this.chkbx_RBAC.TabIndex = 22;
			this.chkbx_RBAC.Text = "Role Based Access Control (17)";
			this.chkbx_RBAC.UseVisualStyleBackColor = true;
			// 
			// chkbx_SQLDB
			// 
			this.chkbx_SQLDB.Checked = true;
			this.chkbx_SQLDB.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_SQLDB.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_SQLDB.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_SQLDB.Location = new System.Drawing.Point(202, 295);
			this.chkbx_SQLDB.Name = "chkbx_SQLDB";
			this.chkbx_SQLDB.Size = new System.Drawing.Size(181, 24);
			this.chkbx_SQLDB.TabIndex = 21;
			this.chkbx_SQLDB.Text = "DataInsight Azure SQLDB (17)";
			this.chkbx_SQLDB.UseVisualStyleBackColor = true;
			// 
			// chkbx_AzureSearch
			// 
			this.chkbx_AzureSearch.Checked = true;
			this.chkbx_AzureSearch.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_AzureSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_AzureSearch.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_AzureSearch.Location = new System.Drawing.Point(202, 265);
			this.chkbx_AzureSearch.Name = "chkbx_AzureSearch";
			this.chkbx_AzureSearch.Size = new System.Drawing.Size(181, 24);
			this.chkbx_AzureSearch.TabIndex = 20;
			this.chkbx_AzureSearch.Text = "DataInsight Azure Search (17)";
			this.chkbx_AzureSearch.UseVisualStyleBackColor = true;
			// 
			// chkbx_DocDB
			// 
			this.chkbx_DocDB.Checked = true;
			this.chkbx_DocDB.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_DocDB.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_DocDB.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_DocDB.Location = new System.Drawing.Point(202, 235);
			this.chkbx_DocDB.Name = "chkbx_DocDB";
			this.chkbx_DocDB.Size = new System.Drawing.Size(181, 24);
			this.chkbx_DocDB.TabIndex = 19;
			this.chkbx_DocDB.Text = "DataInsight Azure DocDB (17)";
			this.chkbx_DocDB.UseVisualStyleBackColor = true;
			// 
			// chkbx_IntuneMAMExtension
			// 
			this.chkbx_IntuneMAMExtension.Checked = true;
			this.chkbx_IntuneMAMExtension.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_IntuneMAMExtension.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_IntuneMAMExtension.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_IntuneMAMExtension.Location = new System.Drawing.Point(202, 205);
			this.chkbx_IntuneMAMExtension.Name = "chkbx_IntuneMAMExtension";
			this.chkbx_IntuneMAMExtension.Size = new System.Drawing.Size(181, 24);
			this.chkbx_IntuneMAMExtension.TabIndex = 18;
			this.chkbx_IntuneMAMExtension.Text = "Microsoft Intune MAM Extension (17)";
			this.chkbx_IntuneMAMExtension.UseVisualStyleBackColor = true;
			// 
			// chkbx_B2C
			// 
			this.chkbx_B2C.Checked = true;
			this.chkbx_B2C.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_B2C.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_B2C.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_B2C.Location = new System.Drawing.Point(202, 175);
			this.chkbx_B2C.Name = "chkbx_B2C";
			this.chkbx_B2C.Size = new System.Drawing.Size(181, 24);
			this.chkbx_B2C.TabIndex = 17;
			this.chkbx_B2C.Text = "AD B2C (28)";
			this.chkbx_B2C.UseVisualStyleBackColor = true;
			// 
			// chkbx_B2B
			// 
			this.chkbx_B2B.Checked = true;
			this.chkbx_B2B.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_B2B.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_B2B.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_B2B.Location = new System.Drawing.Point(202, 145);
			this.chkbx_B2B.Name = "chkbx_B2B";
			this.chkbx_B2B.Size = new System.Drawing.Size(181, 24);
			this.chkbx_B2B.TabIndex = 16;
			this.chkbx_B2B.Text = "AD B2B (10)";
			this.chkbx_B2B.UseVisualStyleBackColor = true;
			// 
			// chkbx_WindowsAzurePack
			// 
			this.chkbx_WindowsAzurePack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_WindowsAzurePack.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_WindowsAzurePack.Location = new System.Drawing.Point(202, 114);
			this.chkbx_WindowsAzurePack.Name = "chkbx_WindowsAzurePack";
			this.chkbx_WindowsAzurePack.Size = new System.Drawing.Size(198, 24);
			this.chkbx_WindowsAzurePack.TabIndex = 15;
			this.chkbx_WindowsAzurePack.Text = "Windows Azure Pack (Classic) (11)";
			this.chkbx_WindowsAzurePack.UseVisualStyleBackColor = true;
			// 
			// chkbx_InsightExtension
			// 
			this.chkbx_InsightExtension.Checked = true;
			this.chkbx_InsightExtension.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_InsightExtension.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_InsightExtension.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_InsightExtension.Location = new System.Drawing.Point(202, 84);
			this.chkbx_InsightExtension.Name = "chkbx_InsightExtension";
			this.chkbx_InsightExtension.Size = new System.Drawing.Size(181, 24);
			this.chkbx_InsightExtension.TabIndex = 14;
			this.chkbx_InsightExtension.Text = "Azure Insight Extension (17)";
			this.chkbx_InsightExtension.UseVisualStyleBackColor = true;
			// 
			// chkbx_PortalClassic
			// 
			this.chkbx_PortalClassic.Checked = true;
			this.chkbx_PortalClassic.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_PortalClassic.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_PortalClassic.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_PortalClassic.Location = new System.Drawing.Point(202, 54);
			this.chkbx_PortalClassic.Name = "chkbx_PortalClassic";
			this.chkbx_PortalClassic.Size = new System.Drawing.Size(181, 24);
			this.chkbx_PortalClassic.TabIndex = 13;
			this.chkbx_PortalClassic.Text = "Azure Portal (Classic) (10)";
			this.chkbx_PortalClassic.UseVisualStyleBackColor = true;
			// 
			// chkbx_StoreExperience
			// 
			this.chkbx_StoreExperience.Checked = true;
			this.chkbx_StoreExperience.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_StoreExperience.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_StoreExperience.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_StoreExperience.Location = new System.Drawing.Point(202, 24);
			this.chkbx_StoreExperience.Name = "chkbx_StoreExperience";
			this.chkbx_StoreExperience.Size = new System.Drawing.Size(181, 24);
			this.chkbx_StoreExperience.TabIndex = 12;
			this.chkbx_StoreExperience.Text = "Azure Store Experience (17)";
			this.chkbx_StoreExperience.UseVisualStyleBackColor = true;
			// 
			// chkbx_StoreMarketplace
			// 
			this.chkbx_StoreMarketplace.Checked = true;
			this.chkbx_StoreMarketplace.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_StoreMarketplace.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_StoreMarketplace.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_StoreMarketplace.Location = new System.Drawing.Point(5, 355);
			this.chkbx_StoreMarketplace.Name = "chkbx_StoreMarketplace";
			this.chkbx_StoreMarketplace.Size = new System.Drawing.Size(181, 24);
			this.chkbx_StoreMarketplace.TabIndex = 11;
			this.chkbx_StoreMarketplace.Text = "Azure Store Marketplace (17)";
			this.chkbx_StoreMarketplace.UseVisualStyleBackColor = true;
			// 
			// chkbx_InsightCommon
			// 
			this.chkbx_InsightCommon.Checked = true;
			this.chkbx_InsightCommon.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_InsightCommon.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_InsightCommon.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_InsightCommon.Location = new System.Drawing.Point(5, 325);
			this.chkbx_InsightCommon.Name = "chkbx_InsightCommon";
			this.chkbx_InsightCommon.Size = new System.Drawing.Size(181, 24);
			this.chkbx_InsightCommon.TabIndex = 10;
			this.chkbx_InsightCommon.Text = "Azure Insight Common (17)";
			this.chkbx_InsightCommon.UseVisualStyleBackColor = true;
			// 
			// chkbx_InsightMonRP
			// 
			this.chkbx_InsightMonRP.Checked = true;
			this.chkbx_InsightMonRP.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_InsightMonRP.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_InsightMonRP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_InsightMonRP.Location = new System.Drawing.Point(5, 295);
			this.chkbx_InsightMonRP.Name = "chkbx_InsightMonRP";
			this.chkbx_InsightMonRP.Size = new System.Drawing.Size(181, 24);
			this.chkbx_InsightMonRP.TabIndex = 9;
			this.chkbx_InsightMonRP.Text = "Azure Insight MonRP (17)";
			this.chkbx_InsightMonRP.UseVisualStyleBackColor = true;
			// 
			// chkbx_InsightEvtRP
			// 
			this.chkbx_InsightEvtRP.Checked = true;
			this.chkbx_InsightEvtRP.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_InsightEvtRP.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_InsightEvtRP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_InsightEvtRP.Location = new System.Drawing.Point(5, 265);
			this.chkbx_InsightEvtRP.Name = "chkbx_InsightEvtRP";
			this.chkbx_InsightEvtRP.Size = new System.Drawing.Size(181, 24);
			this.chkbx_InsightEvtRP.TabIndex = 8;
			this.chkbx_InsightEvtRP.Text = "Azure Insight EvtRP (17)";
			this.chkbx_InsightEvtRP.UseVisualStyleBackColor = true;
			// 
			// chkbx_InsightNotRP
			// 
			this.chkbx_InsightNotRP.Checked = true;
			this.chkbx_InsightNotRP.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_InsightNotRP.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_InsightNotRP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_InsightNotRP.Location = new System.Drawing.Point(5, 235);
			this.chkbx_InsightNotRP.Name = "chkbx_InsightNotRP";
			this.chkbx_InsightNotRP.Size = new System.Drawing.Size(181, 24);
			this.chkbx_InsightNotRP.TabIndex = 7;
			this.chkbx_InsightNotRP.Text = "Azure Insight NotRP (17)";
			this.chkbx_InsightNotRP.UseVisualStyleBackColor = true;
			// 
			// chkbx_PortalFX
			// 
			this.chkbx_PortalFX.Checked = true;
			this.chkbx_PortalFX.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_PortalFX.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_PortalFX.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_PortalFX.Location = new System.Drawing.Point(6, 205);
			this.chkbx_PortalFX.Name = "chkbx_PortalFX";
			this.chkbx_PortalFX.Size = new System.Drawing.Size(181, 24);
			this.chkbx_PortalFX.TabIndex = 6;
			this.chkbx_PortalFX.Text = "Azure Portal FX (17)";
			this.chkbx_PortalFX.UseVisualStyleBackColor = true;
			// 
			// chkbx_ResourceManager
			// 
			this.chkbx_ResourceManager.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_ResourceManager.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_ResourceManager.Location = new System.Drawing.Point(5, 175);
			this.chkbx_ResourceManager.Name = "chkbx_ResourceManager";
			this.chkbx_ResourceManager.Size = new System.Drawing.Size(181, 24);
			this.chkbx_ResourceManager.TabIndex = 5;
			this.chkbx_ResourceManager.Text = "Azure Resource Manager (17)";
			this.chkbx_ResourceManager.UseVisualStyleBackColor = true;
			// 
			// chkbx_ResourceProviderSDK
			// 
			this.chkbx_ResourceProviderSDK.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_ResourceProviderSDK.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_ResourceProviderSDK.Location = new System.Drawing.Point(5, 145);
			this.chkbx_ResourceProviderSDK.Name = "chkbx_ResourceProviderSDK";
			this.chkbx_ResourceProviderSDK.Size = new System.Drawing.Size(204, 24);
			this.chkbx_ResourceProviderSDK.TabIndex = 4;
			this.chkbx_ResourceProviderSDK.Text = "Azure Resource Provider SDK (17)";
			this.chkbx_ResourceProviderSDK.UseVisualStyleBackColor = true;
			// 
			// chkbx_RedisCacheExtension
			// 
			this.chkbx_RedisCacheExtension.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_RedisCacheExtension.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_RedisCacheExtension.Location = new System.Drawing.Point(5, 115);
			this.chkbx_RedisCacheExtension.Name = "chkbx_RedisCacheExtension";
			this.chkbx_RedisCacheExtension.Size = new System.Drawing.Size(195, 24);
			this.chkbx_RedisCacheExtension.TabIndex = 3;
			this.chkbx_RedisCacheExtension.Text = "Azure Redis Cache Extension (17)";
			this.chkbx_RedisCacheExtension.UseVisualStyleBackColor = true;
			// 
			// chkbx_RedisChacheRP
			// 
			this.chkbx_RedisChacheRP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_RedisChacheRP.Location = new System.Drawing.Point(5, 85);
			this.chkbx_RedisChacheRP.Name = "chkbx_RedisChacheRP";
			this.chkbx_RedisChacheRP.Size = new System.Drawing.Size(181, 24);
			this.chkbx_RedisChacheRP.TabIndex = 2;
			this.chkbx_RedisChacheRP.Text = "Azure Redis Cache RP (17)";
			this.chkbx_RedisChacheRP.UseVisualStyleBackColor = true;
			// 
			// chkbx_SchedulerRP
			// 
			this.chkbx_SchedulerRP.Checked = true;
			this.chkbx_SchedulerRP.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_SchedulerRP.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_SchedulerRP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_SchedulerRP.Location = new System.Drawing.Point(5, 55);
			this.chkbx_SchedulerRP.Name = "chkbx_SchedulerRP";
			this.chkbx_SchedulerRP.Size = new System.Drawing.Size(181, 24);
			this.chkbx_SchedulerRP.TabIndex = 1;
			this.chkbx_SchedulerRP.Text = "Azure Scheduler RP (17)";
			this.chkbx_SchedulerRP.UseVisualStyleBackColor = true;
			// 
			// chkbx_SchedulerExtension
			// 
			this.chkbx_SchedulerExtension.Checked = true;
			this.chkbx_SchedulerExtension.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_SchedulerExtension.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_SchedulerExtension.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_SchedulerExtension.Location = new System.Drawing.Point(5, 25);
			this.chkbx_SchedulerExtension.Name = "chkbx_SchedulerExtension";
			this.chkbx_SchedulerExtension.Size = new System.Drawing.Size(180, 24);
			this.chkbx_SchedulerExtension.TabIndex = 0;
			this.chkbx_SchedulerExtension.Text = "Azure Scheduler Extension (17)";
			this.chkbx_SchedulerExtension.UseVisualStyleBackColor = true;
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
			this.LblTitle_Panel1.Text = "Please, select components in order to create the structure";
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
