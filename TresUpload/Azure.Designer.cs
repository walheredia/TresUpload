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
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBox26;
		private System.Windows.Forms.CheckBox checkBox25;
		private System.Windows.Forms.CheckBox checkBox24;
		private System.Windows.Forms.CheckBox checkBox23;
		private System.Windows.Forms.CheckBox checkBox22;
		private System.Windows.Forms.CheckBox checkBox21;
		private System.Windows.Forms.CheckBox checkBox20;
		private System.Windows.Forms.CheckBox checkBox19;
		private System.Windows.Forms.CheckBox checkBox18;
		private System.Windows.Forms.CheckBox checkBox17;
		private System.Windows.Forms.CheckBox checkBox16;
		private System.Windows.Forms.CheckBox checkBox15;
		private System.Windows.Forms.CheckBox checkBox14;
		private System.Windows.Forms.CheckBox checkBox13;
		private System.Windows.Forms.CheckBox checkBox12;
		private System.Windows.Forms.CheckBox checkBox11;
		private System.Windows.Forms.CheckBox checkBox10;
		private System.Windows.Forms.CheckBox checkBox9;
		private System.Windows.Forms.CheckBox checkBox8;
		private System.Windows.Forms.CheckBox checkBox7;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.checkBox8 = new System.Windows.Forms.CheckBox();
			this.checkBox9 = new System.Windows.Forms.CheckBox();
			this.checkBox10 = new System.Windows.Forms.CheckBox();
			this.checkBox11 = new System.Windows.Forms.CheckBox();
			this.checkBox12 = new System.Windows.Forms.CheckBox();
			this.checkBox13 = new System.Windows.Forms.CheckBox();
			this.checkBox14 = new System.Windows.Forms.CheckBox();
			this.checkBox15 = new System.Windows.Forms.CheckBox();
			this.checkBox16 = new System.Windows.Forms.CheckBox();
			this.checkBox17 = new System.Windows.Forms.CheckBox();
			this.checkBox18 = new System.Windows.Forms.CheckBox();
			this.checkBox19 = new System.Windows.Forms.CheckBox();
			this.checkBox20 = new System.Windows.Forms.CheckBox();
			this.checkBox21 = new System.Windows.Forms.CheckBox();
			this.checkBox22 = new System.Windows.Forms.CheckBox();
			this.checkBox23 = new System.Windows.Forms.CheckBox();
			this.checkBox24 = new System.Windows.Forms.CheckBox();
			this.checkBox25 = new System.Windows.Forms.CheckBox();
			this.checkBox26 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
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
			this.GrBox_Select_Components.Controls.Add(this.checkBox13);
			this.GrBox_Select_Components.Controls.Add(this.chkb_StoreExperience);
			this.GrBox_Select_Components.Controls.Add(this.checkBox12);
			this.GrBox_Select_Components.Controls.Add(this.chkb_StoreMarketplace);
			this.GrBox_Select_Components.Controls.Add(this.checkBox11);
			this.GrBox_Select_Components.Controls.Add(this.chkb_InsightCommon);
			this.GrBox_Select_Components.Controls.Add(this.checkBox10);
			this.GrBox_Select_Components.Controls.Add(this.chkb_InsightMonRP);
			this.GrBox_Select_Components.Controls.Add(this.checkBox9);
			this.GrBox_Select_Components.Controls.Add(this.chkb_InsightEvtRP);
			this.GrBox_Select_Components.Controls.Add(this.checkBox8);
			this.GrBox_Select_Components.Controls.Add(this.chkb_InsightNotRP);
			this.GrBox_Select_Components.Controls.Add(this.checkBox7);
			this.GrBox_Select_Components.Controls.Add(this.chkb_PortalFX);
			this.GrBox_Select_Components.Controls.Add(this.checkBox6);
			this.GrBox_Select_Components.Controls.Add(this.chkb_ResourceManager);
			this.GrBox_Select_Components.Controls.Add(this.checkBox5);
			this.GrBox_Select_Components.Controls.Add(this.chkb_ResourceProviderSDK);
			this.GrBox_Select_Components.Controls.Add(this.checkBox4);
			this.GrBox_Select_Components.Controls.Add(this.chkb_RedisCacheExtension);
			this.GrBox_Select_Components.Controls.Add(this.checkBox3);
			this.GrBox_Select_Components.Controls.Add(this.chkb_RedisChacheRP);
			this.GrBox_Select_Components.Controls.Add(this.checkBox2);
			this.GrBox_Select_Components.Controls.Add(this.checkBox1);
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
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(8, 25);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(180, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Azure Scheduler Extension";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox2.Location = new System.Drawing.Point(7, 55);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(181, 24);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Azure Scheduler RP";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox3.Location = new System.Drawing.Point(7, 85);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(181, 24);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "Azure Redis Cache RP";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox4
			// 
			this.checkBox4.Checked = true;
			this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox4.Location = new System.Drawing.Point(7, 115);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(181, 24);
			this.checkBox4.TabIndex = 3;
			this.checkBox4.Text = "Azure Redis Cache Extension";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// checkBox5
			// 
			this.checkBox5.Checked = true;
			this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox5.Location = new System.Drawing.Point(7, 145);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(181, 24);
			this.checkBox5.TabIndex = 4;
			this.checkBox5.Text = "Azure Resource Provider SDK";
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// checkBox6
			// 
			this.checkBox6.Checked = true;
			this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox6.Location = new System.Drawing.Point(7, 175);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(181, 24);
			this.checkBox6.TabIndex = 5;
			this.checkBox6.Text = "Azure Resource Manager";
			this.checkBox6.UseVisualStyleBackColor = true;
			// 
			// checkBox7
			// 
			this.checkBox7.Checked = true;
			this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox7.Location = new System.Drawing.Point(8, 205);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(181, 24);
			this.checkBox7.TabIndex = 6;
			this.checkBox7.Text = "Azure Portal FX";
			this.checkBox7.UseVisualStyleBackColor = true;
			// 
			// checkBox8
			// 
			this.checkBox8.Checked = true;
			this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox8.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox8.Location = new System.Drawing.Point(7, 235);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.Size = new System.Drawing.Size(181, 24);
			this.checkBox8.TabIndex = 7;
			this.checkBox8.Text = "Azure Insight NotRP";
			this.checkBox8.UseVisualStyleBackColor = true;
			// 
			// checkBox9
			// 
			this.checkBox9.Checked = true;
			this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox9.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox9.Location = new System.Drawing.Point(7, 265);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.Size = new System.Drawing.Size(181, 24);
			this.checkBox9.TabIndex = 8;
			this.checkBox9.Text = "Azure Insight EvtRP";
			this.checkBox9.UseVisualStyleBackColor = true;
			// 
			// checkBox10
			// 
			this.checkBox10.Checked = true;
			this.checkBox10.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox10.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox10.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox10.Location = new System.Drawing.Point(7, 295);
			this.checkBox10.Name = "checkBox10";
			this.checkBox10.Size = new System.Drawing.Size(181, 24);
			this.checkBox10.TabIndex = 9;
			this.checkBox10.Text = "Azure Insight MonRP";
			this.checkBox10.UseVisualStyleBackColor = true;
			// 
			// checkBox11
			// 
			this.checkBox11.Checked = true;
			this.checkBox11.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox11.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox11.Location = new System.Drawing.Point(7, 325);
			this.checkBox11.Name = "checkBox11";
			this.checkBox11.Size = new System.Drawing.Size(181, 24);
			this.checkBox11.TabIndex = 10;
			this.checkBox11.Text = "Azure Insight Common";
			this.checkBox11.UseVisualStyleBackColor = true;
			// 
			// checkBox12
			// 
			this.checkBox12.Checked = true;
			this.checkBox12.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox12.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox12.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox12.Location = new System.Drawing.Point(7, 355);
			this.checkBox12.Name = "checkBox12";
			this.checkBox12.Size = new System.Drawing.Size(181, 24);
			this.checkBox12.TabIndex = 11;
			this.checkBox12.Text = "Azure Store Marketplace";
			this.checkBox12.UseVisualStyleBackColor = true;
			// 
			// checkBox13
			// 
			this.checkBox13.Checked = true;
			this.checkBox13.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox13.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox13.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox13.Location = new System.Drawing.Point(194, 25);
			this.checkBox13.Name = "checkBox13";
			this.checkBox13.Size = new System.Drawing.Size(181, 24);
			this.checkBox13.TabIndex = 12;
			this.checkBox13.Text = "Azure Store Experience";
			this.checkBox13.UseVisualStyleBackColor = true;
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
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(381, 356);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 30);
			this.button1.TabIndex = 27;
			this.button1.Text = "Uncheck All";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Btn_UnCheckAllClick);
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
			this.button2.Click += new System.EventHandler(this.Btn_CheckAllClick);
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
			this.button3.Click += new System.EventHandler(this.Button1Click);
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
