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
using System.Collections.Generic;
using System.IO;

namespace TresUpload
{
	/// <summary>
	/// Description of Azure.
	/// </summary>
	public partial class Azure : Form
	{
		string[] tgt_lcode_8 = {"de-DE", "es-ES", "fr-FR", "it-IT", "ja-JP", "ko-KR", "zh-CN", "zh-TW"};
		string[] tgt_lcode_10 = {"de-DE", "es-ES", "fr-FR", "it-IT", "ja-JP", "ko-KR", "pt-BR", "ru-RU", "zh-CN", "zh-TW"};
		string[] tgt_lcode_13 = {"cs-CZ", "de-DE", "es-ES", "fr-FR", "it-IT", "ja-JP", "ko-KR", "pl-PL", "pt-BR", "ru-RU", "tr-TR", "zh-CN", "zh-TW"};
		string[] tgt_lcode_17 = {"cs-CZ", "de-DE", "es-ES", "fr-FR", "hu-HU", "it-IT", "ja-JP", "ko-KR", "nl-NL", "pl-PL", "pt-BR", "pt-PT", "ru-RU", "sv-SE", "tr-TR", "zh-CN", "zh-TW"};
		string[] tgt_lcode_28 = {"ar-SA","cs-CZ", "da-DK", "de-DE", "el-GR", "es-ES", "fi-FI", "fr-FR", "he-IL", "hr-HR", "hu-HU", "it-IT", "ja-JP", "ko-KR", "ms-MY", "nb-NO", "nl-NL", "pl-PL", "pt-BR", "pt-PT", "ro-RO", "ru-RU", "sk-SK", "sv-SE", "th-TH", "tr-TR", "zh-CN", "zh-TW"};
		string[] tgt_lcode_43 = {"ar-SA", "bg-BG", "ca-ES", "cs-CZ", "da-DK", "de-DE", "el-GR", "es-ES", "et-EE", "eu-ES", "fi-FI", "fr-FR", "gl-ES", "he-IL", "hi-IN", "hr-HR", "hu-HU", "id-ID", "it-IT", "ja-JP", "kk-KZ", "ko-KR", "lt-LT", "lv-LV", "ms-MY", "nb-NO", "nl-NL", "pl-PL", "pt-BR", "pt-PT", "ro-RO", "ru-RU", "sk-SK", "sl-SI", "sr-Cyrl-RS", "sr-Latn-RS", "sv-SE", "th-TH", "tr-TR", "uk-UA", "vi-VN", "zh-CN", "zh-TW"};
		
		string[] src_lcode_8 = {"DE", "ES", "FR", "IT", "JA", "KO", "CN", "TW"};
		string[] src_lcode_10 = {"de-DE", "es-ES", "fr-FR", "it-IT", "ja-JP", "ko-KR", "pt-BR", "ru-RU", "zh-CN", "zh-TW"};
		string[] src_lcode_13 = {"cs-CZ", "de-DE", "es-ES", "fr-FR", "it-IT", "ja-JP", "ko-KR", "pl-PL", "pt-BR", "ru-RU", "tr-TR", "zh-CN", "zh-TW"};
		string[] src_lcode_17 = {"cs-CZ", "de-DE", "es-ES", "fr-FR", "hu-HU", "it-IT", "ja-JP", "ko-KR", "nl-NL", "pl-PL", "pt-BR", "pt-PT", "ru-RU", "sv-SE", "tr-TR", "zh-CN", "zh-TW"};
		string[] src_lcode_28 = {"ar-SA","cs-CZ", "da-DK", "de-DE", "el-GR", "es-ES", "fi-FI", "fr-FR", "he-IL", "hr-HR", "hu-HU", "it-IT", "ja-JP", "ko-KR", "ms-MY", "nb-NO", "nl-NL", "pl-PL", "pt-BR", "pt-PT", "ro-RO", "ru-RU", "sk-SK", "sv-SE", "th-TH", "tr-TR", "zh-CN", "zh-TW"};
		string[] src_lcode_43 = {"ar-SA", "bg-BG", "ca-ES", "cs-CZ", "da-DK", "de-DE", "el-GR", "es-ES", "et-EE", "eu-ES", "fi-FI", "fr-FR", "gl-ES", "he-IL", "hi-IN", "hr-HR", "hu-HU", "id-ID", "it-IT", "ja-JP", "kk-KZ", "ko-KR", "lt-LT", "lv-LV", "ms-MY", "nb-NO", "nl-NL", "pl-PL", "pt-BR", "pt-PT", "ro-RO", "ru-RU", "sk-SK", "sl-SI", "sr-Cyrl-RS", "sr-Latn-RS", "sv-SE", "th-TH", "tr-TR", "uk-UA", "vi-VN", "zh-CN", "zh-TW"};
		
		public static string tgt_files = "";
		public static string src_files = "";
		
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
		void Btn_CheckAllClick(object sender, EventArgs e) {
			foreach (Control c in this.GrBox_Select_Components.Controls) {                
                if(c is CheckBox) {
                    CheckBox chk;
                    chk = (CheckBox)c;
                    chk.Checked = true;                
                }
            }
		}
		void Btn_UnCheckAllClick(object sender, EventArgs e) {
			foreach (Control c in this.GrBox_Select_Components.Controls) {                
                if(c is CheckBox) {
                    CheckBox chk;
                    chk = (CheckBox)c;
                    chk.Checked = false;                
                }
            }
		}
		void Button1Click(object sender, EventArgs e) {
			foreach (Control c in this.GrBox_Select_Components.Controls) {                
                if(c is CheckBox) {
                    CheckBox chk;
                    chk = (CheckBox)c;
                    if (chk.Checked == true) {
                    	chk.Checked = false;
                    }
                    else {	
                    	chk.Checked = true;
                    }
                }
            }
		}
		
		//Function to disable all Checkbox
		void disable() {
			foreach (Control c in this.GrBox_Select_Components.Controls) {                
                if(c is CheckBox)  {
                    CheckBox chk;
                    chk = (CheckBox)c;
                    chk.Enabled = false;
                }
            }
		}
		
		//Function to enable all checkbox
		void enable() {
			foreach (Control c in this.GrBox_Select_Components.Controls) {                
                if(c is CheckBox) {
                    CheckBox chk;
                    chk = (CheckBox)c;
                    chk.Enabled = true;
                }
            }
		}
		
		void Btn_CreateStructureClick(object sender, EventArgs e) {
			disable();
			pb_structure.Maximum = tgt_lcode_8.Length + tgt_lcode_10.Length + tgt_lcode_13.Length + tgt_lcode_17.Length + tgt_lcode_28.Length + tgt_lcode_43.Length;
			pb_structure.Value = 0;
			fbd_createStructure.SelectedPath = "C:/Users/v-wahere/Desktop/TresUpload";
			fbd_createStructure.Description = "Please select the directory where you want to create the new structure";
			if (fbd_createStructure.ShowDialog() == DialogResult.OK) {
				Directory.SetCurrentDirectory(fbd_createStructure.SelectedPath.ToString());
				tgt_files=fbd_createStructure.SelectedPath.ToString();
				for (int i=0; i<tgt_lcode_8.Length; i++) {
					if (chkbx_ESSO.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_8[i] + "/Microsoft Enterprise Single Sign On/");
					}
					pb_structure.Value = pb_structure.Value + 1;
				}
				for (int i=0; i<tgt_lcode_10.Length; i++) {
					if (chkbx_PortalClassic.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_10[i] + "/Azure Portal (Classic)/");
					}
					if (chkbx_B2B.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_10[i] + "/AD B2B/");
					}
					pb_structure.Value = pb_structure.Value + 1;
				}
				for (int i=0; i<tgt_lcode_13.Length; i++) {
					if (chkbx_DBOLEDB.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_13[i] + "/Microsoft OLE DB Provider for DB2/");
					}
					pb_structure.Value = pb_structure.Value + 1;
				}
				for (int i=0; i<tgt_lcode_17.Length; i++) {
					if (chkbx_SchedulerExtension.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Scheduler Extension/");
					}
					if (chkbx_SchedulerRP.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Scheduler RP/");
					}
					if (chkbx_PortalFX.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Portal FX/");
					}
					if (chkbx_StoreMarketplace.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Store Marketplace/");
					}
					if (chkbx_StoreExperience.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Store Experience/");
					}
					if (chkbx_InsightExtension.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Insight Extension/");
					}
					if (chkbx_IntuneMAMExtension.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Microsoft Intune MAM Extension/");
					}
					if (chkbx_DocDB.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/DataInsight Azure DocDB/");
					}
					if (chkbx_AzureSearch.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/DataInsight Azure Search/");
					}
					if (chkbx_SQLDB.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/DataInsight Azure SQLDB/");
					}
					if (chkbx_RBAC.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Role Based Access Control/");
					}
					if (chkbx_ADIAM.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AD IAM/");
					}
					if (chkbx_ADProtectionCenter.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AD Protection Center/");
					}
					if (chkbx_CloudAppDiscovery.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Cloud App Discovery/");
					}
					pb_structure.Value = pb_structure.Value + 1;
				}
				for (int i=0; i<tgt_lcode_28.Length; i++) {
					if (chkbx_B2C.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_28[i] + "/AD B2C/");
					}
					pb_structure.Value = pb_structure.Value + 1;
				}
				for (int i=0; i<tgt_lcode_43.Length; i++) {
					if (chkbx_HisConnectors.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_43[i] + "/HIS Connectors/");
					}
					pb_structure.Value = pb_structure.Value + 1;
				}
				MessageBox.Show("Directory Succesfully Created");
				pb_structure.Value = 0;
			}
			enable();
		}
		void LblTitle_Panel1Click(object sender, EventArgs e)
		{
	
		}
		void AzureLoad(object sender, EventArgs e)
		{
	
		}
		
		void Btn_copyfilesClick(object sender, EventArgs e)
		{
			pb_copyfiles.Maximum = tgt_lcode_8.Length + tgt_lcode_10.Length + tgt_lcode_13.Length + tgt_lcode_17.Length + tgt_lcode_28.Length + tgt_lcode_43.Length;
			pb_copyfiles.Value = 0;
			fbd_copyfiles.SelectedPath="C:\\sd_enlist";
			fbd_copyfiles.Description="Please select the directory of the Source Files (Enlistment from SDW)";
			if (fbd_copyfiles.ShowDialog() == DialogResult.OK) {
				src_files = fbd_copyfiles.SelectedPath.ToString();
				//for Files with EOL= 8
				for (int i = 0; i < src_lcode_8.Length; i++) {
					string srcpath = src_files + @"/Windows Server OOBs/ESSO/V10/Alternative/"+ src_lcode_8[i] + "/tgt/";
					string tgtpath = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_8[i] + "/Microsoft Enterprise Single Sign On/";
		        	
					string srcfile1 = System.IO.Path.Combine(srcpath, "ComponentUpdater.dll.lcl");
		        	string dstfile1 = System.IO.Path.Combine(tgtpath, "ComponentUpdater.dll.lcl");
		        	System.IO.File.Copy(srcfile1, dstfile1, true);
		        	string srcfile2 = System.IO.Path.Combine(srcpath, "ComponentUpdaterUI.dll.lcl");
		        	string dstfile2 = System.IO.Path.Combine(tgtpath, "ComponentUpdaterUI.dll.lcl");
		        	System.IO.File.Copy(srcfile2, dstfile2, true);
		        	string srcfile3 = System.IO.Path.Combine(srcpath, "ConfigFrameworkHelper.dll.lcl");
		        	string dstfile3 = System.IO.Path.Combine(tgtpath, "ConfigFrameworkHelper.dll.lcl");
		        	System.IO.File.Copy(srcfile3, dstfile3, true);
		        	string srcfile4 = System.IO.Path.Combine(srcpath, "ConfigFrameworkHelperUI.dll.lcl");
		        	string dstfile4 = System.IO.Path.Combine(tgtpath, "ConfigFrameworkHelperUI.dll.lcl");
		        	System.IO.File.Copy(srcfile4, dstfile4, true);
		        	string srcfile5 = System.IO.Path.Combine(srcpath, "Configuration.exe.lcl");
		        	string dstfile5 = System.IO.Path.Combine(tgtpath, "Configuration.exe.lcl");
		        	System.IO.File.Copy(srcfile5, dstfile5, true);
		        	string srcfile6 = System.IO.Path.Combine(srcpath, "ENTSSO.exe.lcl");
		        	string dstfile6 = System.IO.Path.Combine(tgtpath, "ENTSSO.exe.lcl");
		        	System.IO.File.Copy(srcfile6, dstfile6, true);
		        	string srcfile7 = System.IO.Path.Combine(srcpath, "FeatureControls.dll.lcl");
		        	string dstfile7 = System.IO.Path.Combine(tgtpath, "FeatureControls.dll.lcl");
		        	System.IO.File.Copy(srcfile7, dstfile7, true);
		        	string srcfile8 = System.IO.Path.Combine(srcpath, "HtmlLite.dll.lcl");
		        	string dstfile8 = System.IO.Path.Combine(tgtpath, "HtmlLite.dll.lcl");
		        	System.IO.File.Copy(srcfile8, dstfile8, true);
		        	string srcfile9 = System.IO.Path.Combine(srcpath, "ImportExport.dll.lcl");
		        	string dstfile9 = System.IO.Path.Combine(tgtpath, "ImportExport.dll.lcl");
		        	System.IO.File.Copy(srcfile9, dstfile9, true);
		        	string srcfile10 = System.IO.Path.Combine(srcpath, "InfoCache.dll.lcl");
		        	string dstfile10 = System.IO.Path.Combine(tgtpath, "InfoCache.dll.lcl");
		        	System.IO.File.Copy(srcfile10, dstfile10, true);
		        	string srcfile11 = System.IO.Path.Combine(srcpath, "Microsoft.BizTalk.Interop.SSOClient.dll.lcl");
		        	string dstfile11 = System.IO.Path.Combine(tgtpath, "Microsoft.BizTalk.Interop.SSOClient.dll.lcl");
		        	System.IO.File.Copy(srcfile11, dstfile11, true);
		        	string srcfile12 = System.IO.Path.Combine(srcpath, "Microsoft.EnterpriseSingleSignOn.AdminMMC.dll.lcl");
		        	string dstfile12 = System.IO.Path.Combine(tgtpath, "Microsoft.EnterpriseSingleSignOn.AdminMMC.dll.lcl");
		        	System.IO.File.Copy(srcfile12, dstfile12, true);
		        	string srcfile13 = System.IO.Path.Combine(srcpath, "Microsoft.EnterpriseSingleSignOn.AppsMMC.dll.lcl");
		        	string dstfile13 = System.IO.Path.Combine(tgtpath, "Microsoft.EnterpriseSingleSignOn.AppsMMC.dll.lcl");
		        	System.IO.File.Copy(srcfile13, dstfile13, true);
		        	string srcfile14 = System.IO.Path.Combine(srcpath, "Microsoft.EnterpriseSingleSignOn.Interop.dll.lcl");
		        	string dstfile14 = System.IO.Path.Combine(tgtpath, "Microsoft.EnterpriseSingleSignOn.Interop.dll.lcl");
		        	System.IO.File.Copy(srcfile14, dstfile14, true);
		        	string srcfile15 = System.IO.Path.Combine(srcpath, "Microsoft.EnterpriseSingleSignOn.ManagementAgent.dll.lcl");
		        	string dstfile15 = System.IO.Path.Combine(tgtpath, "Microsoft.EnterpriseSingleSignOn.ManagementAgent.dll.lcl");
		        	System.IO.File.Copy(srcfile15, dstfile15, true);
		        	string srcfile16 = System.IO.Path.Combine(srcpath, "Microsoft.EnterpriseSingleSignOn.PassSyncMMC.dll.lcl");
		        	string dstfile16 = System.IO.Path.Combine(tgtpath, "Microsoft.EnterpriseSingleSignOn.PassSyncMMC.dll.lcl");
		        	System.IO.File.Copy(srcfile16, dstfile16, true);
		        	string srcfile17 = System.IO.Path.Combine(srcpath, "Microsoft.EnterpriseSingleSignOn.Pluggable.dll.lcl");
		        	string dstfile17 = System.IO.Path.Combine(tgtpath, "Microsoft.EnterpriseSingleSignOn.Pluggable.dll.lcl");
		        	System.IO.File.Copy(srcfile17, dstfile17, true);
		        	string srcfile18 = System.IO.Path.Combine(srcpath, "Microsoft.EnterpriseSingleSignOn.ServersMMC.dll.lcl");
		        	string dstfile18 = System.IO.Path.Combine(tgtpath, "Microsoft.EnterpriseSingleSignOn.ServersMMC.dll.lcl");
		        	System.IO.File.Copy(srcfile18, dstfile18, true);
		        	string srcfile19 = System.IO.Path.Combine(srcpath, "Microsoft.EnterpriseSingleSignOn.StartMMC.exe.lcl");
		        	string dstfile19 = System.IO.Path.Combine(tgtpath, "Microsoft.EnterpriseSingleSignOn.StartMMC.exe.lcl");
		        	System.IO.File.Copy(srcfile19, dstfile19, true);
		        	string srcfile20 = System.IO.Path.Combine(srcpath, "Microsoft.EnterpriseSingleSignOn.SystemMMC.dll.lcl");
		        	string dstfile20 = System.IO.Path.Combine(tgtpath, "Microsoft.EnterpriseSingleSignOn.SystemMMC.dll.lcl");
		        	System.IO.File.Copy(srcfile20, dstfile20, true);
		        	string srcfile21 = System.IO.Path.Combine(srcpath, "Microsoft.EnterpriseSingleSignOn.UI1.dll.lcl");
		        	string dstfile21 = System.IO.Path.Combine(tgtpath, "Microsoft.EnterpriseSingleSignOn.UI1.dll.lcl");
		        	System.IO.File.Copy(srcfile21, dstfile21, true);
		        	string srcfile22 = System.IO.Path.Combine(srcpath, "Microsoft.EnterpriseSingleSignOn.UI2.dll.lcl");
		        	string dstfile22 = System.IO.Path.Combine(tgtpath, "Microsoft.EnterpriseSingleSignOn.UI2.dll.lcl");
		        	System.IO.File.Copy(srcfile22, dstfile22, true);
		        	string srcfile23 = System.IO.Path.Combine(srcpath, "Microsoft.ExceptionMessageBoxCopy.dll.lcl");
		        	string dstfile23 = System.IO.Path.Combine(tgtpath, "Microsoft.ExceptionMessageBoxCopy.dll.lcl");
		        	System.IO.File.Copy(srcfile23, dstfile23, true);
		        	string srcfile24 = System.IO.Path.Combine(srcpath, "Setup.exe.lcl");
		        	string dstfile24 = System.IO.Path.Combine(tgtpath, "Setup.exe.lcl");
		        	System.IO.File.Copy(srcfile24, dstfile24, true);
		        	string srcfile25 = System.IO.Path.Combine(srcpath, "SetupUI.dll.lcl");
		        	string dstfile25 = System.IO.Path.Combine(tgtpath, "SetupUI.dll.lcl");
		        	System.IO.File.Copy(srcfile25, dstfile25, true);
		        	string srcfile26 = System.IO.Path.Combine(srcpath, "SSOAdmin.dll.lcl");
		        	string dstfile26 = System.IO.Path.Combine(tgtpath, "SSOAdmin.dll.lcl");
		        	System.IO.File.Copy(srcfile26, dstfile26, true);
		        	string srcfile27 = System.IO.Path.Combine(srcpath, "SSOAdminServer.dll.lcl");
		        	string dstfile27 = System.IO.Path.Combine(tgtpath, "SSOAdminServer.dll.lcl");
		        	System.IO.File.Copy(srcfile27, dstfile27, true);
		        	string srcfile28 = System.IO.Path.Combine(srcpath, "ssoclient.exe.lcl");
		        	string dstfile28 = System.IO.Path.Combine(tgtpath, "ssoclient.exe.lcl");
		        	System.IO.File.Copy(srcfile28, dstfile28, true);
		        	string srcfile29 = System.IO.Path.Combine(srcpath, "ssoclientUI.dll.lcl");
		        	string dstfile29 = System.IO.Path.Combine(tgtpath, "ssoclientUI.dll.lcl");
		        	System.IO.File.Copy(srcfile29, dstfile29, true);
		        	string srcfile30 = System.IO.Path.Combine(srcpath, "SSOClientUI.exe.lcl");
		        	string dstfile30 = System.IO.Path.Combine(tgtpath, "SSOClientUI.exe.lcl");
		        	System.IO.File.Copy(srcfile30, dstfile30, true);
		        	string srcfile31 = System.IO.Path.Combine(srcpath, "ssoconfig.exe.lcl");
		        	string dstfile31 = System.IO.Path.Combine(tgtpath, "ssoconfig.exe.lcl");
		        	System.IO.File.Copy(srcfile31, dstfile31, true);
		        	string srcfile32 = System.IO.Path.Combine(srcpath, "SSOConfigOM.dll.lcl");
		        	string dstfile32 = System.IO.Path.Combine(tgtpath, "SSOConfigOM.dll.lcl");
		        	System.IO.File.Copy(srcfile32, dstfile32, true);
		        	string srcfile33 = System.IO.Path.Combine(srcpath, "SSOConfigStore.dll.lcl");
		        	string dstfile33 = System.IO.Path.Combine(tgtpath, "SSOConfigStore.dll.lcl");
		        	System.IO.File.Copy(srcfile33, dstfile33, true);
		        	string srcfile34 = System.IO.Path.Combine(srcpath, "ssoconfigUI.dll.lcl");
		        	string dstfile34 = System.IO.Path.Combine(tgtpath, "ssoconfigUI.dll.lcl");
		        	System.IO.File.Copy(srcfile34, dstfile34, true);
		        	string srcfile35 = System.IO.Path.Combine(srcpath, "SSOCSServer.dll.lcl");
		        	string dstfile35 = System.IO.Path.Combine(tgtpath, "SSOCSServer.dll.lcl");
		        	System.IO.File.Copy(srcfile35, dstfile35, true);
		        	string srcfile36 = System.IO.Path.Combine(srcpath, "SSOCSTX.dll.lcl");
		        	string dstfile36 = System.IO.Path.Combine(tgtpath, "SSOCSTX.dll.lcl");
		        	System.IO.File.Copy(srcfile36, dstfile36, true);
		        	string srcfile37 = System.IO.Path.Combine(srcpath, "SSOLookup.dll.lcl");
		        	string dstfile37 = System.IO.Path.Combine(tgtpath, "SSOLookup.dll.lcl");
		        	System.IO.File.Copy(srcfile37, dstfile37, true);
		        	string srcfile38 = System.IO.Path.Combine(srcpath, "SSOLookupServer.dll.lcl");
		        	string dstfile38 = System.IO.Path.Combine(tgtpath, "SSOLookupServer.dll.lcl");
		        	System.IO.File.Copy(srcfile38, dstfile38, true);
		        	string srcfile39 = System.IO.Path.Combine(srcpath, "ssomanage.exe.lcl");
		        	string dstfile39 = System.IO.Path.Combine(tgtpath, "ssomanage.exe.lcl");
		        	System.IO.File.Copy(srcfile39, dstfile39, true);
		        	string srcfile40 = System.IO.Path.Combine(srcpath, "ssomanageUI.dll.lcl");
		        	string dstfile40 = System.IO.Path.Combine(tgtpath, "ssomanageUI.dll.lcl");
		        	System.IO.File.Copy(srcfile40, dstfile40, true);
		        	string srcfile41 = System.IO.Path.Combine(srcpath, "SSOMapper.dll.lcl");
		        	string dstfile41 = System.IO.Path.Combine(tgtpath, "SSOMapper.dll.lcl");
		        	System.IO.File.Copy(srcfile41, dstfile41, true);
		        	string srcfile42 = System.IO.Path.Combine(srcpath, "SSOMappingServer.dll.lcl");
		        	string dstfile42 = System.IO.Path.Combine(tgtpath, "SSOMappingServer.dll.lcl");
		        	System.IO.File.Copy(srcfile42, dstfile42, true);
		        	string srcfile43 = System.IO.Path.Combine(srcpath, "SSOMessage.dll.lcl");
		        	string dstfile43 = System.IO.Path.Combine(tgtpath, "SSOMessage.dll.lcl");
		        	System.IO.File.Copy(srcfile43, dstfile43, true);
		        	string srcfile44 = System.IO.Path.Combine(srcpath, "SSOPerfCounters.dll.lcl");
		        	string dstfile44 = System.IO.Path.Combine(tgtpath, "SSOPerfCounters.dll.lcl");
		        	System.IO.File.Copy(srcfile44, dstfile44, true);
		        	string srcfile45 = System.IO.Path.Combine(srcpath, "SSOPerfMonExt.dll.lcl");
		        	string dstfile45 = System.IO.Path.Combine(tgtpath, "SSOPerfMonExt.dll.lcl");
		        	System.IO.File.Copy(srcfile45, dstfile45, true);
		        	string srcfile46 = System.IO.Path.Combine(srcpath, "SSOPS.exe.lcl");
		        	string dstfile46 = System.IO.Path.Combine(tgtpath, "SSOPS.exe.lcl");
		        	System.IO.File.Copy(srcfile46, dstfile46, true);
		        	string srcfile47 = System.IO.Path.Combine(srcpath, "SSOPSAdmin.dll.lcl");
		        	string dstfile47 = System.IO.Path.Combine(tgtpath, "SSOPSAdmin.dll.lcl");
		        	System.IO.File.Copy(srcfile47, dstfile47, true);
		        	string srcfile48 = System.IO.Path.Combine(srcpath, "SSOPSHelper.dll.lcl");
		        	string dstfile48 = System.IO.Path.Combine(tgtpath, "SSOPSHelper.dll.lcl");
		        	System.IO.File.Copy(srcfile48, dstfile48, true);
		        	string srcfile49 = System.IO.Path.Combine(srcpath, "SSOPSServer.dll.lcl");
		        	string dstfile49 = System.IO.Path.Combine(tgtpath, "SSOPSServer.dll.lcl");
		        	System.IO.File.Copy(srcfile49, dstfile49, true);
		        	string srcfile50 = System.IO.Path.Combine(srcpath, "SSOPSUI.dll.lcl");
		        	string dstfile50 = System.IO.Path.Combine(tgtpath, "SSOPSUI.dll.lcl");
		        	System.IO.File.Copy(srcfile50, dstfile50, true);
		        	string srcfile51 = System.IO.Path.Combine(srcpath, "SSOServerCfg.dll.lcl");
		        	string dstfile51 = System.IO.Path.Combine(tgtpath, "SSOServerCfg.dll.lcl");
		        	System.IO.File.Copy(srcfile51, dstfile51, true);
		        	string srcfile52 = System.IO.Path.Combine(srcpath, "SSOServerCfgUI.dll.lcl");
		        	string dstfile52 = System.IO.Path.Combine(tgtpath, "SSOServerCfgUI.dll.lcl");
		        	System.IO.File.Copy(srcfile52, dstfile52, true);
		        	string srcfile53 = System.IO.Path.Combine(srcpath, "SSOSetupHook.dll.lcl");
		        	string dstfile53 = System.IO.Path.Combine(tgtpath, "SSOSetupHook.dll.lcl");
		        	System.IO.File.Copy(srcfile53, dstfile53, true);
		        	string srcfile54 = System.IO.Path.Combine(srcpath, "SSOSetupHookUI.dll.lcl");
		        	string dstfile54 = System.IO.Path.Combine(tgtpath, "SSOSetupHookUI.dll.lcl");
		        	System.IO.File.Copy(srcfile54, dstfile54, true);
		        	string srcfile55 = System.IO.Path.Combine(srcpath, "SSOSQL.dll.lcl");
		        	string dstfile55 = System.IO.Path.Combine(tgtpath, "SSOSQL.dll.lcl");		        	
		        	System.IO.File.Copy(srcfile55, dstfile55, true);
		        	string srcfile56 = System.IO.Path.Combine(srcpath, "SSOSS.dll.lcl");
		        	string dstfile56 = System.IO.Path.Combine(tgtpath, "SSOSS.dll.lcl");		        	
		        	System.IO.File.Copy(srcfile56, dstfile56, true);
		        	
		        	pb_copyfiles.Value = pb_copyfiles.Value + 1;
				}
				listView1.Items.Add("Microsoft Enterprise Single Sign On - Success - (56 lcl files per locate, 448 in total)");
				pb_copyfiles.Value = 0;
				MessageBox.Show("Succesfully Done!");

			}			
		}		
	}
}
