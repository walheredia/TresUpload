﻿/*
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
		private System.Windows.Forms.Button btn_ChekAll;
		private System.Windows.Forms.Button btn_CheckAll;
		private System.Windows.Forms.Button btn_UnchekAll;
		private System.Windows.Forms.Button btn_UnCheckAll;
		private System.Windows.Forms.CheckBox checkBox25;
		private System.Windows.Forms.CheckBox chbx_IAMUX;
		private System.Windows.Forms.CheckBox chbx_PIM;
		private System.Windows.Forms.CheckBox chbx_MIM;
		private System.Windows.Forms.CheckBox chbx_Atlanta;
		private System.Windows.Forms.CheckBox chbx_Adallom;
		private System.Windows.Forms.CheckBox chbx_ESTS;
		//private System.Windows.Forms.CheckBox chbx_MSA_AccountKC;
		private System.Windows.Forms.CheckBox chbx_ADConnectHealth;
		private System.Windows.Forms.CheckBox chbx_ADConnect;
		private System.Windows.Forms.CheckBox chbx_ADBillingExtension;
		private System.Windows.Forms.CheckBox chkbx_ADBilling;
		private System.Windows.Forms.Label LblTitle_Panel1;
		private System.Windows.Forms.ProgressBar pb_structure;
		private System.Windows.Forms.CheckBox chbx_Rome;
		private System.Windows.Forms.CheckBox chbx_MFA;
		private System.Windows.Forms.CheckBox chbx_MFAAgent;
		private System.Windows.Forms.CheckBox chbx_MFAiPhone;
		private System.Windows.Forms.CheckBox chbx_MFAAndroid;
		private System.Windows.Forms.CheckBox chbx_MFAiPhone25;
		private System.Windows.Forms.CheckBox chbx_MFAWinPhone;
		private System.Windows.Forms.FolderBrowserDialog fbd_createStructure;
		private System.Windows.Forms.MaskedTextBox mtb_yearmonth;
		private System.Windows.Forms.FolderBrowserDialog fbd_copyfiles;
		private System.Windows.Forms.Button btn_copyfiles;
		private System.Windows.Forms.ProgressBar pbr_structure;
		private System.Windows.Forms.ProgressBar pbr_CopyFiles;
		private System.Windows.Forms.Label lbl_yearmonth;
		private System.Windows.Forms.Label lbl_copyfiles;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Label lbl_event;
		private System.Windows.Forms.CheckBox chbx_ERM;
		private System.Windows.Forms.CheckBox chbx_MSA_AccountKC;
		private System.Windows.Forms.CheckBox chbx_MSA_AccountWPWiz;
		private System.Windows.Forms.CheckBox chbx_MSA_AppRegPortal;
		private System.Windows.Forms.CheckBox chbx_MSA_AccountXbox;
		private System.Windows.Forms.CheckBox chbx_MSA_AuthAndroid;
		private System.Windows.Forms.CheckBox chbx_MSA_Login;
		private System.Windows.Forms.CheckBox chbx_MSA_Account;
		private System.Windows.Forms.CheckBox chbx_SSPR;
		private System.Windows.Forms.CheckBox chbx_KeyVault;
		private System.Windows.Forms.CheckBox chbx_PowerShell33;
		private System.Windows.Forms.CheckBox chbx_PowerShell7;
		private System.Windows.Forms.CheckBox chbx_PowerShell6;
		private System.Windows.Forms.CheckBox chbx_MSODS33;
		private System.Windows.Forms.CheckBox chbx_MSODS108;
		private System.Windows.Forms.CheckBox chbx_ADRS;
		private System.Windows.Forms.Label lbl_component_title;
		private System.Windows.Forms.Label lbl_file_title;
		private System.Windows.Forms.Label lbl_component;
		private System.Windows.Forms.Label lbl_file;
		private System.Windows.Forms.Label bar;
		private System.Windows.Forms.Button btn_export;
		//private System.Windows.Forms.CheckBox chbx_PowerShell6;
		//private System.Windows.Forms.CheckBox chbx_KeyVault;
		//private System.Windows.Forms.CheckBox chbx_SSPR;
		//private System.Windows.Forms.CheckBox chbx_MSA_AuthAndroid;
		//private System.Windows.Forms.CheckBox chbx_MSA_Account;
		//private System.Windows.Forms.CheckBox chbx_MSA_Login;
		//private System.Windows.Forms.CheckBox chbx_MSA_AccountWPWiz;
		//private System.Windows.Forms.CheckBox chbx_MSA_AccountXbox;
		//private System.Windows.Forms.CheckBox chbx_MSA_AppRegPortal;
		
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
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AD));
			this.PanelLeft = new System.Windows.Forms.Panel();
			this.lbl_yearmonth = new System.Windows.Forms.Label();
			this.pbr_structure = new System.Windows.Forms.ProgressBar();
			this.mtb_yearmonth = new System.Windows.Forms.MaskedTextBox();
			this.btn_CreateStructure = new System.Windows.Forms.Button();
			this.GrBox_Select_Components = new System.Windows.Forms.GroupBox();
			this.chbx_ADRS = new System.Windows.Forms.CheckBox();
			this.chbx_MSODS108 = new System.Windows.Forms.CheckBox();
			this.chbx_MFA = new System.Windows.Forms.CheckBox();
			this.chbx_MIM = new System.Windows.Forms.CheckBox();
			this.chbx_MSODS33 = new System.Windows.Forms.CheckBox();
			this.chbx_PowerShell6 = new System.Windows.Forms.CheckBox();
			this.chbx_PowerShell7 = new System.Windows.Forms.CheckBox();
			this.chbx_PowerShell33 = new System.Windows.Forms.CheckBox();
			this.chbx_KeyVault = new System.Windows.Forms.CheckBox();
			this.chbx_SSPR = new System.Windows.Forms.CheckBox();
			this.chbx_MSA_Login = new System.Windows.Forms.CheckBox();
			this.chbx_MSA_Account = new System.Windows.Forms.CheckBox();
			this.chbx_MSA_AuthAndroid = new System.Windows.Forms.CheckBox();
			this.chbx_MSA_AppRegPortal = new System.Windows.Forms.CheckBox();
			this.chbx_MSA_AccountXbox = new System.Windows.Forms.CheckBox();
			this.chbx_MSA_AccountWPWiz = new System.Windows.Forms.CheckBox();
			this.chbx_ERM = new System.Windows.Forms.CheckBox();
			this.chbx_MFAWinPhone = new System.Windows.Forms.CheckBox();
			this.chbx_MFAiPhone25 = new System.Windows.Forms.CheckBox();
			this.chbx_MFAiPhone = new System.Windows.Forms.CheckBox();
			this.chbx_MFAAndroid = new System.Windows.Forms.CheckBox();
			this.chbx_MFAAgent = new System.Windows.Forms.CheckBox();
			this.chbx_Rome = new System.Windows.Forms.CheckBox();
			this.button3 = new System.Windows.Forms.Button();
			this.btn_Invert = new System.Windows.Forms.Button();
			this.btn_ChekAll = new System.Windows.Forms.Button();
			this.btn_CheckAll = new System.Windows.Forms.Button();
			this.btn_UnchekAll = new System.Windows.Forms.Button();
			this.btn_UnCheckAll = new System.Windows.Forms.Button();
			this.checkBox25 = new System.Windows.Forms.CheckBox();
			this.chbx_IAMUX = new System.Windows.Forms.CheckBox();
			this.chbx_PIM = new System.Windows.Forms.CheckBox();
			this.chbx_Atlanta = new System.Windows.Forms.CheckBox();
			this.chbx_Adallom = new System.Windows.Forms.CheckBox();
			this.chbx_ESTS = new System.Windows.Forms.CheckBox();
			this.chbx_MSA_AccountKC = new System.Windows.Forms.CheckBox();
			this.chbx_ADConnectHealth = new System.Windows.Forms.CheckBox();
			this.chbx_ADConnect = new System.Windows.Forms.CheckBox();
			this.chbx_ADBillingExtension = new System.Windows.Forms.CheckBox();
			this.chkbx_ADBilling = new System.Windows.Forms.CheckBox();
			this.LblTitle_Panel1 = new System.Windows.Forms.Label();
			this.pb_structure = new System.Windows.Forms.ProgressBar();
			this.fbd_createStructure = new System.Windows.Forms.FolderBrowserDialog();
			this.fbd_copyfiles = new System.Windows.Forms.FolderBrowserDialog();
			this.PanelRight = new System.Windows.Forms.Panel();
			this.bar = new System.Windows.Forms.Label();
			this.lbl_file = new System.Windows.Forms.Label();
			this.lbl_component = new System.Windows.Forms.Label();
			this.lbl_file_title = new System.Windows.Forms.Label();
			this.lbl_component_title = new System.Windows.Forms.Label();
			this.lbl_event = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.lbl_copyfiles = new System.Windows.Forms.Label();
			this.pbr_CopyFiles = new System.Windows.Forms.ProgressBar();
			this.btn_copyfiles = new System.Windows.Forms.Button();
			this.btn_export = new System.Windows.Forms.Button();
			this.PanelLeft.SuspendLayout();
			this.GrBox_Select_Components.SuspendLayout();
			this.PanelRight.SuspendLayout();
			this.SuspendLayout();
			// 
			// PanelLeft
			// 
			this.PanelLeft.Controls.Add(this.lbl_yearmonth);
			this.PanelLeft.Controls.Add(this.pbr_structure);
			this.PanelLeft.Controls.Add(this.mtb_yearmonth);
			this.PanelLeft.Controls.Add(this.btn_CreateStructure);
			this.PanelLeft.Controls.Add(this.GrBox_Select_Components);
			this.PanelLeft.Controls.Add(this.LblTitle_Panel1);
			this.PanelLeft.Controls.Add(this.pb_structure);
			this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.PanelLeft.Location = new System.Drawing.Point(0, 0);
			this.PanelLeft.Name = "PanelLeft";
			this.PanelLeft.Size = new System.Drawing.Size(565, 663);
			this.PanelLeft.TabIndex = 0;
			// 
			// lbl_yearmonth
			// 
			this.lbl_yearmonth.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
			this.lbl_yearmonth.ForeColor = System.Drawing.Color.SlateBlue;
			this.lbl_yearmonth.Location = new System.Drawing.Point(29, 481);
			this.lbl_yearmonth.Name = "lbl_yearmonth";
			this.lbl_yearmonth.Size = new System.Drawing.Size(77, 23);
			this.lbl_yearmonth.TabIndex = 10;
			this.lbl_yearmonth.Text = "YearMonth:";
			// 
			// pbr_structure
			// 
			this.pbr_structure.Location = new System.Drawing.Point(29, 535);
			this.pbr_structure.Name = "pbr_structure";
			this.pbr_structure.Size = new System.Drawing.Size(528, 23);
			this.pbr_structure.TabIndex = 9;
			// 
			// mtb_yearmonth
			// 
			this.mtb_yearmonth.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
			this.mtb_yearmonth.Location = new System.Drawing.Point(112, 479);
			this.mtb_yearmonth.Mask = "000000";
			this.mtb_yearmonth.Name = "mtb_yearmonth";
			this.mtb_yearmonth.Size = new System.Drawing.Size(58, 25);
			this.mtb_yearmonth.TabIndex = 8;
			this.mtb_yearmonth.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Mtb_yearmonthMaskInputRejected);
			this.mtb_yearmonth.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mtb_yearmonthMouseClick);
			// 
			// btn_CreateStructure
			// 
			this.btn_CreateStructure.Location = new System.Drawing.Point(376, 564);
			this.btn_CreateStructure.Name = "btn_CreateStructure";
			this.btn_CreateStructure.Size = new System.Drawing.Size(181, 23);
			this.btn_CreateStructure.TabIndex = 7;
			this.btn_CreateStructure.Text = "Create Structure";
			this.btn_CreateStructure.UseVisualStyleBackColor = true;
			this.btn_CreateStructure.Click += new System.EventHandler(this.Btn_CreateStructureClick);
			// 
			// GrBox_Select_Components
			// 
			this.GrBox_Select_Components.Controls.Add(this.chbx_ADRS);
			this.GrBox_Select_Components.Controls.Add(this.chbx_MSODS108);
			this.GrBox_Select_Components.Controls.Add(this.chbx_MFA);
			this.GrBox_Select_Components.Controls.Add(this.chbx_MIM);
			this.GrBox_Select_Components.Controls.Add(this.chbx_MSODS33);
			this.GrBox_Select_Components.Controls.Add(this.chbx_PowerShell6);
			this.GrBox_Select_Components.Controls.Add(this.chbx_PowerShell7);
			this.GrBox_Select_Components.Controls.Add(this.chbx_PowerShell33);
			this.GrBox_Select_Components.Controls.Add(this.chbx_KeyVault);
			this.GrBox_Select_Components.Controls.Add(this.chbx_SSPR);
			this.GrBox_Select_Components.Controls.Add(this.chbx_MSA_Login);
			this.GrBox_Select_Components.Controls.Add(this.chbx_MSA_Account);
			this.GrBox_Select_Components.Controls.Add(this.chbx_MSA_AuthAndroid);
			this.GrBox_Select_Components.Controls.Add(this.chbx_MSA_AppRegPortal);
			this.GrBox_Select_Components.Controls.Add(this.chbx_MSA_AccountXbox);
			this.GrBox_Select_Components.Controls.Add(this.chbx_MSA_AccountWPWiz);
			this.GrBox_Select_Components.Controls.Add(this.chbx_ERM);
			this.GrBox_Select_Components.Controls.Add(this.chbx_MFAWinPhone);
			this.GrBox_Select_Components.Controls.Add(this.chbx_MFAiPhone25);
			this.GrBox_Select_Components.Controls.Add(this.chbx_MFAiPhone);
			this.GrBox_Select_Components.Controls.Add(this.chbx_MFAAndroid);
			this.GrBox_Select_Components.Controls.Add(this.chbx_MFAAgent);
			this.GrBox_Select_Components.Controls.Add(this.chbx_Rome);
			this.GrBox_Select_Components.Controls.Add(this.button3);
			this.GrBox_Select_Components.Controls.Add(this.btn_Invert);
			this.GrBox_Select_Components.Controls.Add(this.btn_ChekAll);
			this.GrBox_Select_Components.Controls.Add(this.btn_CheckAll);
			this.GrBox_Select_Components.Controls.Add(this.btn_UnchekAll);
			this.GrBox_Select_Components.Controls.Add(this.btn_UnCheckAll);
			this.GrBox_Select_Components.Controls.Add(this.checkBox25);
			this.GrBox_Select_Components.Controls.Add(this.chbx_IAMUX);
			this.GrBox_Select_Components.Controls.Add(this.chbx_PIM);
			this.GrBox_Select_Components.Controls.Add(this.chbx_Atlanta);
			this.GrBox_Select_Components.Controls.Add(this.chbx_Adallom);
			this.GrBox_Select_Components.Controls.Add(this.chbx_ESTS);
			this.GrBox_Select_Components.Controls.Add(this.chbx_MSA_AccountKC);
			this.GrBox_Select_Components.Controls.Add(this.chbx_ADConnectHealth);
			this.GrBox_Select_Components.Controls.Add(this.chbx_ADConnect);
			this.GrBox_Select_Components.Controls.Add(this.chbx_ADBillingExtension);
			this.GrBox_Select_Components.Controls.Add(this.chkbx_ADBilling);
			this.GrBox_Select_Components.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GrBox_Select_Components.ForeColor = System.Drawing.Color.SlateBlue;
			this.GrBox_Select_Components.Location = new System.Drawing.Point(8, 31);
			this.GrBox_Select_Components.MaximumSize = new System.Drawing.Size(561, 561);
			this.GrBox_Select_Components.MinimumSize = new System.Drawing.Size(561, 392);
			this.GrBox_Select_Components.Name = "GrBox_Select_Components";
			this.GrBox_Select_Components.Size = new System.Drawing.Size(561, 442);
			this.GrBox_Select_Components.TabIndex = 5;
			this.GrBox_Select_Components.TabStop = false;
			this.GrBox_Select_Components.Text = "Check components";
			// 
			// chbx_ADRS
			// 
			this.chbx_ADRS.Checked = true;
			this.chbx_ADRS.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_ADRS.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
			this.chbx_ADRS.Location = new System.Drawing.Point(6, 234);
			this.chbx_ADRS.Name = "chbx_ADRS";
			this.chbx_ADRS.Size = new System.Drawing.Size(104, 24);
			this.chbx_ADRS.TabIndex = 52;
			this.chbx_ADRS.Text = "ADRS (43)";
			this.chbx_ADRS.UseVisualStyleBackColor = true;
			// 
			// chbx_MSODS108
			// 
			this.chbx_MSODS108.Checked = true;
			this.chbx_MSODS108.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_MSODS108.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
			this.chbx_MSODS108.Location = new System.Drawing.Point(6, 386);
			this.chbx_MSODS108.Name = "chbx_MSODS108";
			this.chbx_MSODS108.Size = new System.Drawing.Size(104, 24);
			this.chbx_MSODS108.TabIndex = 51;
			this.chbx_MSODS108.Text = "MSODS (108)";
			this.chbx_MSODS108.UseVisualStyleBackColor = true;
			// 
			// chbx_MFA
			// 
			this.chbx_MFA.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
			this.chbx_MFA.Location = new System.Drawing.Point(374, 204);
			this.chbx_MFA.Name = "chbx_MFA";
			this.chbx_MFA.Size = new System.Drawing.Size(104, 24);
			this.chbx_MFA.TabIndex = 32;
			this.chbx_MFA.Text = "MFA (43)";
			this.chbx_MFA.UseVisualStyleBackColor = true;
			this.chbx_MFA.CheckedChanged += new System.EventHandler(this.Chbx_MFACheckedChanged);
			// 
			// chbx_MIM
			// 
			this.chbx_MIM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_MIM.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_MIM.Location = new System.Drawing.Point(374, 290);
			this.chbx_MIM.Name = "chbx_MIM";
			this.chbx_MIM.Size = new System.Drawing.Size(181, 24);
			this.chbx_MIM.TabIndex = 8;
			this.chbx_MIM.Text = "MIM (33)";
			this.chbx_MIM.UseVisualStyleBackColor = true;
			// 
			// chbx_MSODS33
			// 
			this.chbx_MSODS33.Checked = true;
			this.chbx_MSODS33.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_MSODS33.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
			this.chbx_MSODS33.Location = new System.Drawing.Point(6, 356);
			this.chbx_MSODS33.Name = "chbx_MSODS33";
			this.chbx_MSODS33.Size = new System.Drawing.Size(104, 24);
			this.chbx_MSODS33.TabIndex = 50;
			this.chbx_MSODS33.Text = "MSODS( 33)";
			this.chbx_MSODS33.UseVisualStyleBackColor = true;
			// 
			// chbx_PowerShell6
			// 
			this.chbx_PowerShell6.Checked = true;
			this.chbx_PowerShell6.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_PowerShell6.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
			this.chbx_PowerShell6.Location = new System.Drawing.Point(187, 24);
			this.chbx_PowerShell6.Name = "chbx_PowerShell6";
			this.chbx_PowerShell6.Size = new System.Drawing.Size(104, 24);
			this.chbx_PowerShell6.TabIndex = 49;
			this.chbx_PowerShell6.Text = "PowerShell (6)";
			this.chbx_PowerShell6.UseVisualStyleBackColor = true;
			// 
			// chbx_PowerShell7
			// 
			this.chbx_PowerShell7.Checked = true;
			this.chbx_PowerShell7.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_PowerShell7.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
			this.chbx_PowerShell7.Location = new System.Drawing.Point(187, 54);
			this.chbx_PowerShell7.Name = "chbx_PowerShell7";
			this.chbx_PowerShell7.Size = new System.Drawing.Size(104, 24);
			this.chbx_PowerShell7.TabIndex = 48;
			this.chbx_PowerShell7.Text = "PowerShell (7)";
			this.chbx_PowerShell7.UseVisualStyleBackColor = true;
			// 
			// chbx_PowerShell33
			// 
			this.chbx_PowerShell33.Checked = true;
			this.chbx_PowerShell33.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_PowerShell33.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
			this.chbx_PowerShell33.Location = new System.Drawing.Point(187, 84);
			this.chbx_PowerShell33.Name = "chbx_PowerShell33";
			this.chbx_PowerShell33.Size = new System.Drawing.Size(104, 24);
			this.chbx_PowerShell33.TabIndex = 47;
			this.chbx_PowerShell33.Text = "PowerShell (33)";
			this.chbx_PowerShell33.UseVisualStyleBackColor = true;
			// 
			// chbx_KeyVault
			// 
			this.chbx_KeyVault.Checked = true;
			this.chbx_KeyVault.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_KeyVault.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_KeyVault.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_KeyVault.Location = new System.Drawing.Point(6, 326);
			this.chbx_KeyVault.Name = "chbx_KeyVault";
			this.chbx_KeyVault.Size = new System.Drawing.Size(181, 24);
			this.chbx_KeyVault.TabIndex = 46;
			this.chbx_KeyVault.Text = "KeyVault (17)";
			this.chbx_KeyVault.UseVisualStyleBackColor = true;
			// 
			// chbx_SSPR
			// 
			this.chbx_SSPR.Checked = true;
			this.chbx_SSPR.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_SSPR.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_SSPR.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_SSPR.Location = new System.Drawing.Point(187, 384);
			this.chbx_SSPR.Name = "chbx_SSPR";
			this.chbx_SSPR.Size = new System.Drawing.Size(181, 24);
			this.chbx_SSPR.TabIndex = 45;
			this.chbx_SSPR.Text = "SSPR (107)";
			this.chbx_SSPR.UseVisualStyleBackColor = true;
			// 
			// chbx_MSA_Login
			// 
			this.chbx_MSA_Login.Checked = true;
			this.chbx_MSA_Login.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_MSA_Login.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_MSA_Login.Location = new System.Drawing.Point(187, 264);
			this.chbx_MSA_Login.Name = "chbx_MSA_Login";
			this.chbx_MSA_Login.Size = new System.Drawing.Size(181, 24);
			this.chbx_MSA_Login.TabIndex = 44;
			this.chbx_MSA_Login.Text = "MSA Login (108)";
			this.chbx_MSA_Login.UseVisualStyleBackColor = true;
			// 
			// chbx_MSA_Account
			// 
			this.chbx_MSA_Account.Checked = true;
			this.chbx_MSA_Account.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_MSA_Account.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_MSA_Account.Location = new System.Drawing.Point(187, 234);
			this.chbx_MSA_Account.Name = "chbx_MSA_Account";
			this.chbx_MSA_Account.Size = new System.Drawing.Size(181, 24);
			this.chbx_MSA_Account.TabIndex = 43;
			this.chbx_MSA_Account.Text = "MSA Account (108)";
			this.chbx_MSA_Account.UseVisualStyleBackColor = true;
			// 
			// chbx_MSA_AuthAndroid
			// 
			this.chbx_MSA_AuthAndroid.Checked = true;
			this.chbx_MSA_AuthAndroid.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_MSA_AuthAndroid.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_MSA_AuthAndroid.Location = new System.Drawing.Point(187, 174);
			this.chbx_MSA_AuthAndroid.Name = "chbx_MSA_AuthAndroid";
			this.chbx_MSA_AuthAndroid.Size = new System.Drawing.Size(181, 24);
			this.chbx_MSA_AuthAndroid.TabIndex = 42;
			this.chbx_MSA_AuthAndroid.Text = "MSA Auth Android (39)";
			this.chbx_MSA_AuthAndroid.UseVisualStyleBackColor = true;
			// 
			// chbx_MSA_AppRegPortal
			// 
			this.chbx_MSA_AppRegPortal.Checked = true;
			this.chbx_MSA_AppRegPortal.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_MSA_AppRegPortal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_MSA_AppRegPortal.Location = new System.Drawing.Point(187, 294);
			this.chbx_MSA_AppRegPortal.Name = "chbx_MSA_AppRegPortal";
			this.chbx_MSA_AppRegPortal.Size = new System.Drawing.Size(181, 24);
			this.chbx_MSA_AppRegPortal.TabIndex = 41;
			this.chbx_MSA_AppRegPortal.Text = "MSA AppRegPortal (17)";
			this.chbx_MSA_AppRegPortal.UseVisualStyleBackColor = true;
			// 
			// chbx_MSA_AccountXbox
			// 
			this.chbx_MSA_AccountXbox.Checked = true;
			this.chbx_MSA_AccountXbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_MSA_AccountXbox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_MSA_AccountXbox.Location = new System.Drawing.Point(187, 144);
			this.chbx_MSA_AccountXbox.Name = "chbx_MSA_AccountXbox";
			this.chbx_MSA_AccountXbox.Size = new System.Drawing.Size(181, 24);
			this.chbx_MSA_AccountXbox.TabIndex = 40;
			this.chbx_MSA_AccountXbox.Text = "MSA Account Xbox (21)";
			this.chbx_MSA_AccountXbox.UseVisualStyleBackColor = true;
			// 
			// chbx_MSA_AccountWPWiz
			// 
			this.chbx_MSA_AccountWPWiz.Checked = true;
			this.chbx_MSA_AccountWPWiz.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_MSA_AccountWPWiz.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_MSA_AccountWPWiz.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_MSA_AccountWPWiz.Location = new System.Drawing.Point(187, 204);
			this.chbx_MSA_AccountWPWiz.Name = "chbx_MSA_AccountWPWiz";
			this.chbx_MSA_AccountWPWiz.Size = new System.Drawing.Size(181, 24);
			this.chbx_MSA_AccountWPWiz.TabIndex = 39;
			this.chbx_MSA_AccountWPWiz.Text = "MSA AccountWPWiz (65)";
			this.chbx_MSA_AccountWPWiz.UseVisualStyleBackColor = true;
			// 
			// chbx_ERM
			// 
			this.chbx_ERM.Checked = true;
			this.chbx_ERM.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_ERM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_ERM.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_ERM.Location = new System.Drawing.Point(6, 294);
			this.chbx_ERM.Name = "chbx_ERM";
			this.chbx_ERM.Size = new System.Drawing.Size(181, 24);
			this.chbx_ERM.TabIndex = 38;
			this.chbx_ERM.Text = "ERM (17)";
			this.chbx_ERM.UseVisualStyleBackColor = true;
			// 
			// chbx_MFAWinPhone
			// 
			this.chbx_MFAWinPhone.Checked = true;
			this.chbx_MFAWinPhone.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_MFAWinPhone.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
			this.chbx_MFAWinPhone.Location = new System.Drawing.Point(374, 85);
			this.chbx_MFAWinPhone.Name = "chbx_MFAWinPhone";
			this.chbx_MFAWinPhone.Size = new System.Drawing.Size(125, 24);
			this.chbx_MFAWinPhone.TabIndex = 37;
			this.chbx_MFAWinPhone.Text = "MFA WinPhone (61)";
			this.chbx_MFAWinPhone.UseVisualStyleBackColor = true;
			// 
			// chbx_MFAiPhone25
			// 
			this.chbx_MFAiPhone25.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
			this.chbx_MFAiPhone25.Location = new System.Drawing.Point(374, 174);
			this.chbx_MFAiPhone25.Name = "chbx_MFAiPhone25";
			this.chbx_MFAiPhone25.Size = new System.Drawing.Size(125, 24);
			this.chbx_MFAiPhone25.TabIndex = 35;
			this.chbx_MFAiPhone25.Text = "MFA iPhone (25)";
			this.chbx_MFAiPhone25.UseVisualStyleBackColor = true;
			// 
			// chbx_MFAiPhone
			// 
			this.chbx_MFAiPhone.Checked = true;
			this.chbx_MFAiPhone.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_MFAiPhone.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
			this.chbx_MFAiPhone.Location = new System.Drawing.Point(374, 55);
			this.chbx_MFAiPhone.Name = "chbx_MFAiPhone";
			this.chbx_MFAiPhone.Size = new System.Drawing.Size(125, 24);
			this.chbx_MFAiPhone.TabIndex = 34;
			this.chbx_MFAiPhone.Text = "MFA iPhone (43)";
			this.chbx_MFAiPhone.UseVisualStyleBackColor = true;
			// 
			// chbx_MFAAndroid
			// 
			this.chbx_MFAAndroid.Checked = true;
			this.chbx_MFAAndroid.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_MFAAndroid.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
			this.chbx_MFAAndroid.Location = new System.Drawing.Point(374, 26);
			this.chbx_MFAAndroid.Name = "chbx_MFAAndroid";
			this.chbx_MFAAndroid.Size = new System.Drawing.Size(145, 24);
			this.chbx_MFAAndroid.TabIndex = 33;
			this.chbx_MFAAndroid.Text = "MFA Android (43)";
			this.chbx_MFAAndroid.UseVisualStyleBackColor = true;
			// 
			// chbx_MFAAgent
			// 
			this.chbx_MFAAgent.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
			this.chbx_MFAAgent.Location = new System.Drawing.Point(374, 234);
			this.chbx_MFAAgent.Name = "chbx_MFAAgent";
			this.chbx_MFAAgent.Size = new System.Drawing.Size(141, 24);
			this.chbx_MFAAgent.TabIndex = 31;
			this.chbx_MFAAgent.Text = "MFA Agent (17)";
			this.chbx_MFAAgent.UseVisualStyleBackColor = true;
			// 
			// chbx_Rome
			// 
			this.chbx_Rome.Checked = true;
			this.chbx_Rome.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_Rome.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
			this.chbx_Rome.Location = new System.Drawing.Point(6, 204);
			this.chbx_Rome.Name = "chbx_Rome";
			this.chbx_Rome.Size = new System.Drawing.Size(179, 24);
			this.chbx_Rome.TabIndex = 30;
			this.chbx_Rome.Text = "Azure Security Center (17)";
			this.chbx_Rome.UseVisualStyleBackColor = true;
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
			// btn_ChekAll
			// 
			this.btn_ChekAll.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_ChekAll.Location = new System.Drawing.Point(381, 320);
			this.btn_ChekAll.Name = "btn_ChekAll";
			this.btn_ChekAll.Size = new System.Drawing.Size(90, 30);
			this.btn_ChekAll.TabIndex = 28;
			this.btn_ChekAll.Text = "Check All";
			this.btn_ChekAll.UseVisualStyleBackColor = true;
			this.btn_ChekAll.Click += new System.EventHandler(this.Btn_ChekAllClick);
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
			// btn_UnchekAll
			// 
			this.btn_UnchekAll.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_UnchekAll.Location = new System.Drawing.Point(381, 356);
			this.btn_UnchekAll.Name = "btn_UnchekAll";
			this.btn_UnchekAll.Size = new System.Drawing.Size(90, 30);
			this.btn_UnchekAll.TabIndex = 27;
			this.btn_UnchekAll.Text = "Uncheck All";
			this.btn_UnchekAll.UseVisualStyleBackColor = true;
			this.btn_UnchekAll.Click += new System.EventHandler(this.Btn_UnchekAllClick);
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
			// checkBox25
			// 
			this.checkBox25.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox25.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox25.Location = new System.Drawing.Point(374, 264);
			this.checkBox25.Name = "checkBox25";
			this.checkBox25.Size = new System.Drawing.Size(175, 24);
			this.checkBox25.TabIndex = 24;
			this.checkBox25.Text = "AD Protection Center";
			this.checkBox25.UseVisualStyleBackColor = true;
			// 
			// chbx_IAMUX
			// 
			this.chbx_IAMUX.Checked = true;
			this.chbx_IAMUX.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_IAMUX.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_IAMUX.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_IAMUX.Location = new System.Drawing.Point(187, 324);
			this.chbx_IAMUX.Name = "chbx_IAMUX";
			this.chbx_IAMUX.Size = new System.Drawing.Size(181, 24);
			this.chbx_IAMUX.TabIndex = 11;
			this.chbx_IAMUX.Text = "IAMUX (108)";
			this.chbx_IAMUX.UseVisualStyleBackColor = true;
			// 
			// chbx_PIM
			// 
			this.chbx_PIM.Checked = true;
			this.chbx_PIM.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_PIM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_PIM.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_PIM.Location = new System.Drawing.Point(6, 264);
			this.chbx_PIM.Name = "chbx_PIM";
			this.chbx_PIM.Size = new System.Drawing.Size(181, 24);
			this.chbx_PIM.TabIndex = 9;
			this.chbx_PIM.Text = "PIM (17)";
			this.chbx_PIM.UseVisualStyleBackColor = true;
			// 
			// chbx_Atlanta
			// 
			this.chbx_Atlanta.Checked = true;
			this.chbx_Atlanta.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_Atlanta.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_Atlanta.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_Atlanta.Location = new System.Drawing.Point(6, 54);
			this.chbx_Atlanta.Name = "chbx_Atlanta";
			this.chbx_Atlanta.Size = new System.Drawing.Size(181, 24);
			this.chbx_Atlanta.TabIndex = 7;
			this.chbx_Atlanta.Text = "Atlanta (4)";
			this.chbx_Atlanta.UseVisualStyleBackColor = true;
			// 
			// chbx_Adallom
			// 
			this.chbx_Adallom.Checked = true;
			this.chbx_Adallom.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_Adallom.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_Adallom.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_Adallom.Location = new System.Drawing.Point(6, 26);
			this.chbx_Adallom.Name = "chbx_Adallom";
			this.chbx_Adallom.Size = new System.Drawing.Size(181, 24);
			this.chbx_Adallom.TabIndex = 6;
			this.chbx_Adallom.Text = "Adallom (41)";
			this.chbx_Adallom.UseVisualStyleBackColor = true;
			// 
			// chbx_ESTS
			// 
			this.chbx_ESTS.Checked = true;
			this.chbx_ESTS.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_ESTS.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_ESTS.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_ESTS.Location = new System.Drawing.Point(187, 354);
			this.chbx_ESTS.Name = "chbx_ESTS";
			this.chbx_ESTS.Size = new System.Drawing.Size(181, 24);
			this.chbx_ESTS.TabIndex = 5;
			this.chbx_ESTS.Text = "ESTS (107)";
			this.chbx_ESTS.UseVisualStyleBackColor = true;
			// 
			// chbx_MSA_AccountKC
			// 
			this.chbx_MSA_AccountKC.Checked = true;
			this.chbx_MSA_AccountKC.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_MSA_AccountKC.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_MSA_AccountKC.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_MSA_AccountKC.Location = new System.Drawing.Point(187, 114);
			this.chbx_MSA_AccountKC.Name = "chbx_MSA_AccountKC";
			this.chbx_MSA_AccountKC.Size = new System.Drawing.Size(181, 24);
			this.chbx_MSA_AccountKC.TabIndex = 4;
			this.chbx_MSA_AccountKC.Text = "MSA AccountKC (2)";
			this.chbx_MSA_AccountKC.UseVisualStyleBackColor = true;
			// 
			// chbx_ADConnectHealth
			// 
			this.chbx_ADConnectHealth.Checked = true;
			this.chbx_ADConnectHealth.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_ADConnectHealth.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_ADConnectHealth.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_ADConnectHealth.Location = new System.Drawing.Point(6, 175);
			this.chbx_ADConnectHealth.Name = "chbx_ADConnectHealth";
			this.chbx_ADConnectHealth.Size = new System.Drawing.Size(181, 24);
			this.chbx_ADConnectHealth.TabIndex = 3;
			this.chbx_ADConnectHealth.Text = "AD Connect Health (17)";
			this.chbx_ADConnectHealth.UseVisualStyleBackColor = true;
			// 
			// chbx_ADConnect
			// 
			this.chbx_ADConnect.Checked = true;
			this.chbx_ADConnect.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_ADConnect.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_ADConnect.Location = new System.Drawing.Point(6, 145);
			this.chbx_ADConnect.Name = "chbx_ADConnect";
			this.chbx_ADConnect.Size = new System.Drawing.Size(181, 24);
			this.chbx_ADConnect.TabIndex = 2;
			this.chbx_ADConnect.Text = "AD Connect (17)";
			this.chbx_ADConnect.UseVisualStyleBackColor = true;
			// 
			// chbx_ADBillingExtension
			// 
			this.chbx_ADBillingExtension.Checked = true;
			this.chbx_ADBillingExtension.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbx_ADBillingExtension.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbx_ADBillingExtension.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbx_ADBillingExtension.Location = new System.Drawing.Point(6, 115);
			this.chbx_ADBillingExtension.Name = "chbx_ADBillingExtension";
			this.chbx_ADBillingExtension.Size = new System.Drawing.Size(181, 24);
			this.chbx_ADBillingExtension.TabIndex = 1;
			this.chbx_ADBillingExtension.Text = "AD Billing Extension (17)";
			this.chbx_ADBillingExtension.UseVisualStyleBackColor = true;
			// 
			// chkbx_ADBilling
			// 
			this.chkbx_ADBilling.Checked = true;
			this.chkbx_ADBilling.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbx_ADBilling.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkbx_ADBilling.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkbx_ADBilling.Location = new System.Drawing.Point(6, 84);
			this.chkbx_ADBilling.Name = "chkbx_ADBilling";
			this.chkbx_ADBilling.Size = new System.Drawing.Size(180, 24);
			this.chkbx_ADBilling.TabIndex = 0;
			this.chkbx_ADBilling.Text = "AD Billing (16)";
			this.chkbx_ADBilling.UseVisualStyleBackColor = true;
			// 
			// LblTitle_Panel1
			// 
			this.LblTitle_Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblTitle_Panel1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTitle_Panel1.ForeColor = System.Drawing.Color.SlateBlue;
			this.LblTitle_Panel1.Location = new System.Drawing.Point(0, 0);
			this.LblTitle_Panel1.Name = "LblTitle_Panel1";
			this.LblTitle_Panel1.Size = new System.Drawing.Size(565, 663);
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
			// PanelRight
			// 
			this.PanelRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.PanelRight.Controls.Add(this.btn_export);
			this.PanelRight.Controls.Add(this.bar);
			this.PanelRight.Controls.Add(this.lbl_file);
			this.PanelRight.Controls.Add(this.lbl_component);
			this.PanelRight.Controls.Add(this.lbl_file_title);
			this.PanelRight.Controls.Add(this.lbl_component_title);
			this.PanelRight.Controls.Add(this.lbl_event);
			this.PanelRight.Controls.Add(this.listView1);
			this.PanelRight.Controls.Add(this.lbl_copyfiles);
			this.PanelRight.Controls.Add(this.pbr_CopyFiles);
			this.PanelRight.Controls.Add(this.btn_copyfiles);
			this.PanelRight.Location = new System.Drawing.Point(682, 0);
			this.PanelRight.Name = "PanelRight";
			this.PanelRight.Size = new System.Drawing.Size(580, 663);
			this.PanelRight.TabIndex = 1;
			// 
			// bar
			// 
			this.bar.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
			this.bar.ForeColor = System.Drawing.Color.Red;
			this.bar.Location = new System.Drawing.Point(459, 482);
			this.bar.Name = "bar";
			this.bar.Size = new System.Drawing.Size(100, 23);
			this.bar.TabIndex = 15;
			this.bar.Text = "*/* Components";
			// 
			// lbl_file
			// 
			this.lbl_file.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
			this.lbl_file.ForeColor = System.Drawing.Color.Red;
			this.lbl_file.Location = new System.Drawing.Point(139, 505);
			this.lbl_file.Name = "lbl_file";
			this.lbl_file.Size = new System.Drawing.Size(421, 23);
			this.lbl_file.TabIndex = 14;
			this.lbl_file.Text = "...";
			// 
			// lbl_component
			// 
			this.lbl_component.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
			this.lbl_component.ForeColor = System.Drawing.Color.Red;
			this.lbl_component.Location = new System.Drawing.Point(185, 482);
			this.lbl_component.Name = "lbl_component";
			this.lbl_component.Size = new System.Drawing.Size(374, 23);
			this.lbl_component.TabIndex = 13;
			this.lbl_component.Text = "...";
			// 
			// lbl_file_title
			// 
			this.lbl_file_title.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
			this.lbl_file_title.ForeColor = System.Drawing.Color.SlateBlue;
			this.lbl_file_title.Location = new System.Drawing.Point(31, 505);
			this.lbl_file_title.Name = "lbl_file_title";
			this.lbl_file_title.Size = new System.Drawing.Size(114, 23);
			this.lbl_file_title.TabIndex = 12;
			this.lbl_file_title.Text = "Processing the file: ";
			// 
			// lbl_component_title
			// 
			this.lbl_component_title.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
			this.lbl_component_title.ForeColor = System.Drawing.Color.SlateBlue;
			this.lbl_component_title.Location = new System.Drawing.Point(31, 482);
			this.lbl_component_title.Name = "lbl_component_title";
			this.lbl_component_title.Size = new System.Drawing.Size(221, 23);
			this.lbl_component_title.TabIndex = 11;
			this.lbl_component_title.Text = "Processing the component: ";
			// 
			// lbl_event
			// 
			this.lbl_event.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
			this.lbl_event.ForeColor = System.Drawing.Color.SlateBlue;
			this.lbl_event.Location = new System.Drawing.Point(31, 31);
			this.lbl_event.Name = "lbl_event";
			this.lbl_event.Size = new System.Drawing.Size(100, 23);
			this.lbl_event.TabIndex = 4;
			this.lbl_event.Text = "Event Log";
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(31, 57);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(537, 331);
			this.listView1.TabIndex = 3;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.List;
			// 
			// lbl_copyfiles
			// 
			this.lbl_copyfiles.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
			this.lbl_copyfiles.ForeColor = System.Drawing.Color.SlateBlue;
			this.lbl_copyfiles.Location = new System.Drawing.Point(231, 0);
			this.lbl_copyfiles.Name = "lbl_copyfiles";
			this.lbl_copyfiles.Size = new System.Drawing.Size(138, 23);
			this.lbl_copyfiles.TabIndex = 2;
			this.lbl_copyfiles.Text = "Copy Files Menu";
			this.lbl_copyfiles.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pbr_CopyFiles
			// 
			this.pbr_CopyFiles.Location = new System.Drawing.Point(31, 535);
			this.pbr_CopyFiles.Name = "pbr_CopyFiles";
			this.pbr_CopyFiles.Size = new System.Drawing.Size(528, 23);
			this.pbr_CopyFiles.TabIndex = 1;
			// 
			// btn_copyfiles
			// 
			this.btn_copyfiles.Location = new System.Drawing.Point(378, 564);
			this.btn_copyfiles.Name = "btn_copyfiles";
			this.btn_copyfiles.Size = new System.Drawing.Size(181, 23);
			this.btn_copyfiles.TabIndex = 0;
			this.btn_copyfiles.Text = "Copy Files";
			this.btn_copyfiles.UseVisualStyleBackColor = true;
			this.btn_copyfiles.Click += new System.EventHandler(this.Btn_copyfilesClick);
			// 
			// btn_export
			// 
			this.btn_export.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_export.ForeColor = System.Drawing.Color.SlateBlue;
			this.btn_export.Location = new System.Drawing.Point(486, 394);
			this.btn_export.Name = "btn_export";
			this.btn_export.Size = new System.Drawing.Size(82, 30);
			this.btn_export.TabIndex = 38;
			this.btn_export.Text = "Export to TXT";
			this.btn_export.UseVisualStyleBackColor = true;
			// 
			// AD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1262, 663);
			this.Controls.Add(this.PanelRight);
			this.Controls.Add(this.PanelLeft);
			this.Name = "AD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AD";
			this.Load += new System.EventHandler(this.ADLoad);
			this.PanelLeft.ResumeLayout(false);
			this.PanelLeft.PerformLayout();
			this.GrBox_Select_Components.ResumeLayout(false);
			this.PanelRight.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		
	}
}
