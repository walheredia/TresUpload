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
		string[] src_lcode_10 = {"de-DE", "es-ES", "fr-FR", "it-IT", "ja-JP", "ko-KR", "pt-BR", "ru-RU", "zh-HANS", "zh-HANT"};
		string[] src_lcode_13 = {"cs-CZ", "de-DE", "es-ES", "fr-FR", "it-IT", "ja-JP", "ko-KR", "pl-PL", "pt-BR", "ru-RU", "tr-TR", "zh-CN", "zh-TW"};
		string[] src_lcode_17 = {"cs-CZ", "de-DE", "es-ES", "fr-FR", "hu-HU", "it-IT", "ja-JP", "ko-KR", "nl-NL", "pl-PL", "pt-BR", "pt-PT", "ru-RU", "sv-SE", "tr-TR", "zh-CN", "zh-TW"};
		string[] src_lcode_28 = {"ar-SA","cs-CZ", "da-DK", "de-DE", "el-GR", "es-ES", "fi-FI", "fr-FR", "he-IL", "hr-HR", "hu-HU", "it-IT", "ja-JP", "ko-KR", "ms-MY", "nb-NO", "nl-NL", "pl-PL", "pt-BR", "pt-PT", "ro-RO", "ru-RU", "sk-SK", "sv-SE", "th-TH", "tr-TR", "zh-CN", "zh-TW"};
		string[] src_lcode_43 = {"ar-SA", "bg-BG", "ca-ES", "cs-CZ", "da-DK", "de-DE", "el-GR", "es-ES", "et-EE", "eu-ES", "fi-FI", "fr-FR", "gl-ES", "he-IL", "hi-IN", "hr-HR", "hu-HU", "id-ID", "it-IT", "ja-JP", "kk-KZ", "ko-KR", "lt-LT", "lv-LV", "ms-MY", "nb-NO", "nl-NL", "pl-PL", "pt-BR", "pt-PT", "ro-RO", "ru-RU", "sk-SK", "sl-SI", "sr-Cyrl-RS", "sr-Latn-RS", "sv-SE", "th-TH", "tr-TR", "uk-UA", "vi-VN", "zh-CN", "zh-TW"};
		
		string[] src_lcode_17_short = {"cs", "de", "es", "fr", "hu", "it", "ja", "ko", "nl", "pl", "pt-BR", "pt-PT", "ru", "sv", "tr", "zh-hans", "zh-hant"};
		string[] src_lcode_17_short_pt = {"cs", "de", "es", "fr", "hu", "it", "ja", "ko", "nl", "pl", "pt-BR", "pt", "ru", "sv", "tr", "zh-hans", "zh-hant"};
		string[] src_lcode_10_short = {"de", "es", "fr", "it", "ja", "ko", "pt-BR", "ru", "zh-HANS", "zh-HANT"};
	
		public static string tgt_files = "";
		public static string src_files = "";
		
		public Azure(){
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}		
		void Mtb_yearmonthMouseClick(object sender, MouseEventArgs e){
			mtb_yearmonth.SelectionStart = 0;
			mtb_yearmonth.SelectionStart = mtb_yearmonth.Text.Length;
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
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_10[i] + "/AD B2B/Resources/");
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
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Scheduler RP/Scheduler.Common/");
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Scheduler RP/Scheduler.Data/");
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Scheduler RP/Scheduler.Web/");
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Scheduler RP/Scheduler.Worker/");
					}
					if (chkbx_PortalFX.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Portal FX/");
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Portal FX/ResourceGroup/");
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Portal FX/SecurityAadPortal/");
						
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Portal FX/Website/CoBrand/");
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Portal FX/Website/SignIn/");
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Portal FX/Website/TokenAuthorize/");
					}
					if (chkbx_StoreMarketplace.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Store Marketplace/");
					}
					if (chkbx_StoreExperience.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Store Experience/");
					}
					if (chkbx_InsightExtension.Checked) {
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Insight Extension/GalleryTemplates/");
						Directory.CreateDirectory("Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Insight Extension/Insights/ServerResources/");
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
				
				try {
					if (chkbx_ESSO.Checked) {
						ESSO();
					}
					if (chkbx_PortalClassic.Checked) {
						PortalClassic();
					}
					if (chkbx_B2B.Checked) {
						B2B();
					}
					if (chkbx_DBOLEDB.Checked) {
						OLEDB();
					}
					if (chkbx_StoreMarketplace.Checked) {
						StoreMarketPlace();
					}
					if (chkbx_StoreExperience.Checked) {
						StoreExperience();
					}
					if (chkbx_PortalFX.Checked) {
						PortalFX();
					}
					if (chkbx_InsightExtension.Checked) {
						InsightExtension();
					}
					if (chkbx_IntuneMAMExtension.Checked) {
						IntuneMAMExtension();
					}
					if (chkbx_SQLDB.Checked) {
						DataInsightSQLDB();
					}
					if (chkbx_DocDB.Checked) {
						DataInsightDocDB();
					}
					if (chkbx_AzureSearch.Checked) {
						DataInsightAzureSearch();
					}
					if (chkbx_RBAC.Checked) {
						RBAC();
					}
					if (chkbx_ADIAM.Checked) {
						ADIAM();
					}
					if (chkbx_ADProtectionCenter.Checked) {
						ProtectionCenter();
					}
					if (chkbx_CloudAppDiscovery.Checked) {
						CloudAppDiscovery();
					}
					if (chkbx_SchedulerRP.Checked) {
						SchedulerRP();
					}
					if (chkbx_SchedulerExtension.Checked) {
						SchedulerExtension();
					}
					if (chkbx_B2C.Checked) {
						B2C();
					}
				} catch (Exception ex) {
					MessageBox.Show(ex.Message);
					throw;
				}				
				
				
				pb_copyfiles.Value = 0;
				MessageBox.Show("Succesfully Done!");

			}					
		}
		//EOL=8
		public void ESSO(){
		    for (int i = 0; i < src_lcode_8.Length; i++) {
				string srcpath = src_files + @"/Windows Server OOBs/ESSO/V10/Alternative/"+ src_lcode_8[i] + "/tgt/";
				string tgtpath = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_8[i] + "/Microsoft Enterprise Single Sign On/";		        	
				string fileName;
				string destFile;
		        string[] files = System.IO.Directory.GetFiles(srcpath);
	            foreach (string s in files){
	                fileName = System.IO.Path.GetFileName(s);
	                destFile = System.IO.Path.Combine(tgtpath, fileName);
	                System.IO.File.Copy(s, destFile, true);
	            }
		    pb_copyfiles.Value = pb_copyfiles.Value + 1;        
			}
			listView1.Items.Add("Microsoft Enterprise Single Sign On - Success - (56 lcl files per locate, 448 in total)");
		}
		//EOL=10
		public void PortalClassic(){
			for (int i = 0; i < src_lcode_10.Length; i++) {
				string srcpath = src_files + @"/azure/Azure_Portal_vCurrent/OnGoing/AuxPortal_n_f5/auxportal/Localization/LCL/"+ src_lcode_10[i] + "/";
				string tgtpath = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_10[i] + "/Azure Portal (Classic)/";		        	
				string fileName;
				string destFile;				
		        string[] files = System.IO.Directory.GetFiles(srcpath, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files){
	                fileName = System.IO.Path.GetFileName(s);
	                destFile = System.IO.Path.Combine(tgtpath, fileName);
	                System.IO.File.Copy(s, destFile, true);
	            }
		    pb_copyfiles.Value = pb_copyfiles.Value + 1;   
			}
			listView1.Items.Add("Azure Portal (Classic) - Success - (92 lcl files per locate, 920 in total)");
		}
		//EOL=10
		public void B2B(){
			for (int i = 0; i < src_lcode_10_short.Length; i++) {
				string srcpath = src_files + @"/Active Directory/AD-B2B/OnGoing/master/B2BLocCommon/lba/"+ src_lcode_10_short[i] + "/B2BLocCommon/lcl/";
				string tgtpath = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_10[i] + "/AD B2B/";		        	
				string fileName;
				string destFile;				
		        string[] files = System.IO.Directory.GetFiles(srcpath, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files){
	                fileName = System.IO.Path.GetFileName(s);
	                destFile = System.IO.Path.Combine(tgtpath, fileName);
	                System.IO.File.Copy(s, destFile, true);
	            }
		        
		        string srcpath1 = src_files + @"/Active Directory/AD-B2B/OnGoing/master/B2BLocEmailWorker/lba/"+ src_lcode_10_short[i] + "/B2BLocEmailWorker/lcl/";
				string tgtpath1 = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_10[i] + "/AD B2B/";
		        string srcfile1 = System.IO.Path.Combine(srcpath1, "EmailTemplate.html.lcl");
	        	string dstfile1 = System.IO.Path.Combine(tgtpath1, "EmailTemplate.html.lcl");
	        	System.IO.File.Copy(srcfile1, dstfile1, true);
	        	
	        	string srcpath2 = src_files + @"/Active Directory/AD-B2B/OnGoing/master/B2BLocEmailWorker/lba/"+ src_lcode_10_short[i] + "/B2BLocEmailWorker/lcl/Resources/";
				string tgtpath2 = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_10[i] + "/AD B2B/Resources/";
		        string srcfile2 = System.IO.Path.Combine(srcpath2, "EmailTemplate.html.lcl");
	        	string dstfile2 = System.IO.Path.Combine(tgtpath2, "EmailTemplate.html.lcl");
	        	System.IO.File.Copy(srcfile2, dstfile2, true);
	        	
	        	string srcpath3 = src_files + @"/Active Directory/AD-B2B/OnGoing/master/B2BLocRedeemPortalWebRole/lba/"+ src_lcode_10_short[i] + "/B2BLocRedeemPortalWebRole/lcl/";
				string tgtpath3 = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_10[i] + "/AD B2B/";		        	
				string fileName3;
				string destFile3;				
		        string[] files3 = System.IO.Directory.GetFiles(srcpath3, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files3){
	                fileName3 = System.IO.Path.GetFileName(s);
	                destFile3 = System.IO.Path.Combine(tgtpath3, fileName3);
	                System.IO.File.Copy(s, destFile3, true);
	            }
		        
		    pb_copyfiles.Value = pb_copyfiles.Value + 1;   
			}
			listView1.Items.Add("AD B2B - Success - (8 lcl files per locate, 80 in total)");
		}
		//EOL=13
		public void OLEDB(){
		    for (int i = 0; i < src_lcode_13.Length; i++) {
				string srcpath = src_files + @"/Windows Server OOBs/DB2OLEDB/V10/Alternative/"+ src_lcode_13[i] + "/lcl/";
				string tgtpath = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_13[i] + "/Microsoft OLE DB Provider for DB2/";		        	
				string fileName;
				string destFile;
		        string[] files = System.IO.Directory.GetFiles(srcpath, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files){
	                fileName = System.IO.Path.GetFileName(s);
	                destFile = System.IO.Path.Combine(tgtpath, fileName);
	                System.IO.File.Copy(s, destFile, true);
	            }
		    pb_copyfiles.Value = pb_copyfiles.Value + 1;        
			}
			listView1.Items.Add("Microsoft OLE DB Provider for DB2 - Success - (31 lcl files per locate, 403 in total)");
		}
		//EOL=17
		public void StoreMarketPlace(){
		    for (int i = 0; i < src_lcode_17_short.Length; i++) {
				string srcpath = src_files + @"/azure/AzureUX-Store/Ongoing/dev/GalleryService.Client/lba/"+ src_lcode_17_short[i] + "/GalleryService.Client/lcl/";
				string tgtpath = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Store Marketplace/";		        	
				string fileName;
				string destFile;
		        string[] files = System.IO.Directory.GetFiles(srcpath, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files){
	                fileName = System.IO.Path.GetFileName(s);
	                destFile = System.IO.Path.Combine(tgtpath, fileName);
	                System.IO.File.Copy(s, destFile, true);
	            }
		    pb_copyfiles.Value = pb_copyfiles.Value + 1;        
			}
			listView1.Items.Add("Azure Store Marketplace - Success - (1 lcl file per locate, 17 in total)");
		}
		//EOL=17
		public void StoreExperience(){
		    for (int i = 0; i < src_lcode_17_short.Length; i++) {
				string srcpath = src_files + @"/azure/AzureUX-StoreExperience/Ongoing/dev/GalleryService.Client/lba/"+ src_lcode_17_short[i] + "/GalleryService.Client/lcl/";
				string tgtpath = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Store Experience/";		        	
				string fileName;
				string destFile;
		        string[] files = System.IO.Directory.GetFiles(srcpath, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files){
	                fileName = System.IO.Path.GetFileName(s);
	                destFile = System.IO.Path.Combine(tgtpath, fileName);
	                System.IO.File.Copy(s, destFile, true);
	            }
		    pb_copyfiles.Value = pb_copyfiles.Value + 1;        
			}
			listView1.Items.Add("Azure Store Experience - Success - (3 lcl file per locate, 51 in total)");
		}
		//EOL=17
		public void PortalFX(){
		    for (int i = 0; i < src_lcode_17_short.Length; i++) {
				string srcpath = src_files + @"/azure/AzureUX_PortalFX/OnGoing/dev/AzureHubsExtension/lba/"+ src_lcode_17_short[i] + "/AzureHubsExtension/lcl/";
				string tgtpath = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Portal FX/";		        	
				string fileName;
				string destFile;
		        string[] files = System.IO.Directory.GetFiles(srcpath, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files){
	                fileName = System.IO.Path.GetFileName(s);
	                destFile = System.IO.Path.Combine(tgtpath, fileName);
	                System.IO.File.Copy(s, destFile, true);
	            }
		        
		        string srcpath1 = src_files + @"/azure/AzureUX_PortalFX/OnGoing/dev/CreateFromTemplate/lba/"+ src_lcode_17_short[i] + "/CreateFromTemplate/lcl/";
				string tgtpath1 = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Portal FX/";		        	
				string fileName1;
				string destFile1;
		        string[] files1 = System.IO.Directory.GetFiles(srcpath1, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files1){
	                fileName1 = System.IO.Path.GetFileName(s);
	                destFile1 = System.IO.Path.Combine(tgtpath1, fileName1);
	                System.IO.File.Copy(s, destFile1, true);
	            }
		        
		        string srcpath2 = src_files + @"/azure/AzureUX_PortalFX/OnGoing/dev/Framework/lba/"+ src_lcode_17_short[i] + "/Framework/lcl/";
				string tgtpath2 = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Portal FX/";		        	
				string fileName2;
				string destFile2;
		        string[] files2 = System.IO.Directory.GetFiles(srcpath2, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files2){
	                fileName2 = System.IO.Path.GetFileName(s);
	                destFile2 = System.IO.Path.Combine(tgtpath2, fileName2);
	                System.IO.File.Copy(s, destFile2, true);
	            }
		        
		        string srcpath3 = src_files + @"/azure/AzureUX_PortalFX/OnGoing/dev/HubsExtension/lba/"+ src_lcode_17_short[i] + "/HubsExtension/lcl/";
				string tgtpath3 = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Portal FX/";		        	
				string fileName3;
				string destFile3;
		        string[] files3 = System.IO.Directory.GetFiles(srcpath3, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files3){
	                fileName3 = System.IO.Path.GetFileName(s);
	                destFile3 = System.IO.Path.Combine(tgtpath3, fileName3);
	                System.IO.File.Copy(s, destFile3, true);
	            }
		        
		        string srcpath4 = src_files + @"/azure/AzureUX_PortalFX/OnGoing/dev/ResourceGroup/lba/"+ src_lcode_17_short[i] + "/ResourceGroup/lcl/";
				string tgtpath4 = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Portal FX/ResourceGroup/";		        	
				string fileName4;
				string destFile4;
		        string[] files4 = System.IO.Directory.GetFiles(srcpath4, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files4){
	                fileName4 = System.IO.Path.GetFileName(s);
	                destFile4 = System.IO.Path.Combine(tgtpath4, fileName4);
	                System.IO.File.Copy(s, destFile4, true);
	            }
		        
		        string srcpath5 = src_files + @"/azure/AzureUX_PortalFX/OnGoing/dev/SecurityAadPortal/lba/"+ src_lcode_17_short[i] + "/SecurityAadPortal/lcl/";
				string tgtpath5 = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Portal FX/SecurityAadPortal/";		        	
				string fileName5;
				string destFile5;
		        string[] files5 = System.IO.Directory.GetFiles(srcpath5, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files5){
	                fileName5 = System.IO.Path.GetFileName(s);
	                destFile5 = System.IO.Path.Combine(tgtpath5, fileName5);
	                System.IO.File.Copy(s, destFile5, true);
	            }
		        
		        string srcpath6 = src_files + @"/azure/AzureUX_PortalFX/OnGoing/dev/Website/lba/"+ src_lcode_17_short[i] + "/Website/lcl/Resources/CoBrand/";
				string tgtpath6 = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Portal FX/Website/CoBrand/";		        	
				string fileName6;
				string destFile6;
		        string[] files6 = System.IO.Directory.GetFiles(srcpath6, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files6){
	                fileName6 = System.IO.Path.GetFileName(s);
	                destFile6 = System.IO.Path.Combine(tgtpath6, fileName6);
	                System.IO.File.Copy(s, destFile6, true);
	            }
		        
		        string srcpath7 = src_files + @"/azure/AzureUX_PortalFX/OnGoing/dev/Website/lba/"+ src_lcode_17_short[i] + "/Website/lcl/Resources/SignIn/";
				string tgtpath7 = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Portal FX/Website/SignIn/";		        	
				string fileName7;
				string destFile7;
		        string[] files7 = System.IO.Directory.GetFiles(srcpath7, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files7){
	                fileName7 = System.IO.Path.GetFileName(s);
	                destFile7 = System.IO.Path.Combine(tgtpath7, fileName7);
	                System.IO.File.Copy(s, destFile7, true);
	            }
		        
		        string srcpath8 = src_files + @"/azure/AzureUX_PortalFX/OnGoing/dev/Website/lba/"+ src_lcode_17_short[i] + "/Website/lcl/Resources/TokenAuthorize/";
				string tgtpath8 = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Portal FX/Website/TokenAuthorize/";		        	
				string fileName8;
				string destFile8;
		        string[] files8 = System.IO.Directory.GetFiles(srcpath8, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files8){
	                fileName8 = System.IO.Path.GetFileName(s);
	                destFile8 = System.IO.Path.Combine(tgtpath8, fileName8);
	                System.IO.File.Copy(s, destFile8, true);
	            }
		        
		        string srcpath9 = src_files + @"/azure/AzureUX_PortalFX/OnGoing/dev/Website/lba/"+ src_lcode_17_short[i] + "/Website/lcl/TypeScript/";
				string tgtpath9 = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Portal FX/Website/";		        	
				string fileName9;
				string destFile9;
		        string[] files9 = System.IO.Directory.GetFiles(srcpath9, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files9){
	                fileName9 = System.IO.Path.GetFileName(s);
	                destFile9 = System.IO.Path.Combine(tgtpath9, fileName9);
	                System.IO.File.Copy(s, destFile9, true);
	            }
		        
		    pb_copyfiles.Value = pb_copyfiles.Value + 1;        
			}
			listView1.Items.Add("Azure Portal FX - Success - (39 lcl file per locate, 663 in total)");
		}
		//EOL=17
		public void InsightExtension(){
		    for (int i = 0; i < src_lcode_17_short.Length; i++) {
				string srcpath = src_files + @"/azure/AzureUX-PortalExp/OnGoing/dev/EMA/lba/"+ src_lcode_17_short[i] + "/EMA/lcl/";
				string tgtpath = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Insight Extension/";		        	
				string fileName;
				string destFile;
		        string[] files = System.IO.Directory.GetFiles(srcpath, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files){
	                fileName = System.IO.Path.GetFileName(s);
	                destFile = System.IO.Path.Combine(tgtpath, fileName);
	                System.IO.File.Copy(s, destFile, true);
	            }
		        
		        string srcpath1 = src_files + @"/azure/AzureUX-PortalExp/OnGoing/dev/ExtensionCore/lba/"+ src_lcode_17_short[i] + "/ExtensionCore/lcl/";
				string tgtpath1 = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Insight Extension/";		        	
				string fileName1;
				string destFile1;
		        string[] files1 = System.IO.Directory.GetFiles(srcpath1, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files1){
	                fileName1 = System.IO.Path.GetFileName(s);
	                destFile1 = System.IO.Path.Combine(tgtpath1, fileName1);
	                System.IO.File.Copy(s, destFile1, true);
	            }
		        
		        string srcpath2 = src_files + @"/azure/AzureUX-PortalExp/OnGoing/dev/GalleryTemplates/lba/"+ src_lcode_17_short[i] + "/GalleryTemplates/lcl/";
				string tgtpath2 = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Insight Extension/GalleryTemplates/";		        	
				string fileName2;
				string destFile2;
		        string[] files2 = System.IO.Directory.GetFiles(srcpath2, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files2){
	                fileName2 = System.IO.Path.GetFileName(s);
	                destFile2 = System.IO.Path.Combine(tgtpath2, fileName2);
	                System.IO.File.Copy(s, destFile2, true);
	            }
		        
		        string srcpath3 = src_files + @"/azure/AzureUX-PortalExp/OnGoing/dev/Insights/lba/"+ src_lcode_17_short[i] + "/Insights/lcl/Client";
				string tgtpath3 = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Insight Extension/";		        	
				string fileName3;
				string destFile3;
		        string[] files3 = System.IO.Directory.GetFiles(srcpath3, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files3){
	                fileName3 = System.IO.Path.GetFileName(s);
	                destFile3 = System.IO.Path.Combine(tgtpath3, fileName3);
	                System.IO.File.Copy(s, destFile3, true);
	            }
		        
		        string srcpath4 = src_files + @"/azure/AzureUX-PortalExp/OnGoing/dev/Insights/lba/"+ src_lcode_17_short[i] + "/Insights/lcl/ServerResources/";
				string tgtpath4 = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Insight Extension/Insights/ServerResources/";		        	
				string fileName4;
				string destFile4;
		        string[] files4 = System.IO.Directory.GetFiles(srcpath4, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files4){
	                fileName4 = System.IO.Path.GetFileName(s);
	                destFile4 = System.IO.Path.Combine(tgtpath4, fileName4);
	                System.IO.File.Copy(s, destFile4, true);
	            }
		        
		    pb_copyfiles.Value = pb_copyfiles.Value + 1;        
			}
			listView1.Items.Add("Azure Insight Extension - Success - (18 lcl file per locate, 306 in total)");
		}
		//EOL=17
		public void IntuneMAMExtension(){
			for (int i = 0; i < src_lcode_17.Length; i++) {
				string srcpath = src_files + @"/Windows Intune/AzureUIExtension/Monthly/AzureUIExtension_CnE_TFS/Loc/LBA/"+ src_lcode_17[i] + "/AzureUIExtension/lcl/";
				string tgtpath = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Microsoft Intune MAM Extension/";		        	
				string fileName;
				string destFile;				
		        string[] files = System.IO.Directory.GetFiles(srcpath, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files){
	                fileName = System.IO.Path.GetFileName(s);
	                destFile = System.IO.Path.Combine(tgtpath, fileName);
	                System.IO.File.Copy(s, destFile, true);
	            }
		    pb_copyfiles.Value = pb_copyfiles.Value + 1;   
			}
			listView1.Items.Add("Microsoft Intune MAM Extension - Success - (2 lcl files per locate, 34 in total)");
		}
		//EOL=17
		public void DataInsightSQLDB(){
			for (int i = 0; i < src_lcode_17.Length; i++) {
				string srcpath = src_files + @"/DataInsight_Azure/DataInsight_Azure/RTW/SQLAzureDB/Source/LOC/LCL/"+ src_lcode_17[i] + "/LCL/";
				string tgtpath = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/DataInsight Azure SQLDB/";		        	
				string fileName;
				string destFile;				
		        string[] files = System.IO.Directory.GetFiles(srcpath, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files){
	                fileName = System.IO.Path.GetFileName(s);
	                destFile = System.IO.Path.Combine(tgtpath, fileName);
	                System.IO.File.Copy(s, destFile, true);
	            }
		    pb_copyfiles.Value = pb_copyfiles.Value + 1;   
			}
			listView1.Items.Add("DataInsight Azure SQLDB - Success - (2 lcl files per locate, 34 in total)");
		}
		//EOL=17
		public void DataInsightDocDB(){
			for (int i = 0; i < src_lcode_17.Length; i++) {
				string srcpath = src_files + @"/DataInsight_Azure/DataInsight_Azure/RTW/DocDB_IbizaProd/Product/Loc/LCL/"+ src_lcode_17[i] + "/LCL/";
				string tgtpath = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/DataInsight Azure DocDB/";		        	
				string fileName;
				string destFile;				
		        string[] files = System.IO.Directory.GetFiles(srcpath, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files){
	                fileName = System.IO.Path.GetFileName(s);
	                destFile = System.IO.Path.Combine(tgtpath, fileName);
	                System.IO.File.Copy(s, destFile, true);
	            }
		    pb_copyfiles.Value = pb_copyfiles.Value + 1;   
			}
			listView1.Items.Add("DataInsight Azure DocDB - Success - (4 lcl files per locate, 68 in total)");
		}
		//EOL=17
		public void DataInsightAzureSearch(){
			for (int i = 0; i < src_lcode_17.Length; i++) {
				string srcpath = src_files + @"/DataInsight_Azure/DataInsight_Azure/RTW/AzureSearch/Product/Loc/LCL/"+ src_lcode_17[i] + "/LCL/";
				string tgtpath = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/DataInsight Azure Search/";		        	
				string fileName;
				string destFile;				
		        string[] files = System.IO.Directory.GetFiles(srcpath, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files){
	                fileName = System.IO.Path.GetFileName(s);
	                destFile = System.IO.Path.Combine(tgtpath, fileName);
	                System.IO.File.Copy(s, destFile, true);
	            }
		    pb_copyfiles.Value = pb_copyfiles.Value + 1;   
			}
			listView1.Items.Add("DataInsight Azure Search - Success - (2 lcl files per locate, 34 in total)");
		}
		//EOL=17
		public void RBAC(){
			for (int i = 0; i < src_lcode_17_short_pt.Length; i++) {
				string srcpath = src_files + @"/Active Directory/IAM-Services-ADIUX/OnGoing/master/PortalExtension/Lba/"+ src_lcode_17_short_pt[i] + "/PortalExtension/lcl/";
				string tgtpath = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Role Based Access Control/";		        	
				string fileName;
				string destFile;				
		        string[] files = System.IO.Directory.GetFiles(srcpath, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files){
	                fileName = System.IO.Path.GetFileName(s);
	                destFile = System.IO.Path.Combine(tgtpath, fileName);
	                System.IO.File.Copy(s, destFile, true);
	            }
		    pb_copyfiles.Value = pb_copyfiles.Value + 1;   
			}
			listView1.Items.Add("Role Based Access Control - Success - (1 lcl files per locate, 17 in total)");
		}
		//EOL=17
		public void ADIAM(){
			for (int i = 0; i < src_lcode_17_short_pt.Length; i++) {
				string srcpath = src_files + @"/AAPT/Microsoft_AAD_IAM/ongoing/AzExt_Microsoft_AAD_IAM/ADExtension/lba/"+ src_lcode_17_short_pt[i] + "/ADExtension/lcl/Client/";
				string tgtpath = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AD IAM/";		        	
				string fileName;
				string destFile;				
		        string[] files = System.IO.Directory.GetFiles(srcpath, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files){
	                fileName = System.IO.Path.GetFileName(s);
	                destFile = System.IO.Path.Combine(tgtpath, fileName);
	                System.IO.File.Copy(s, destFile, true);
	            }
		    pb_copyfiles.Value = pb_copyfiles.Value + 1;   
			}
			listView1.Items.Add("AD IAM - Success - (10 lcl files per locate, 170 in total)");
		}
		//EOL=17
		public void ProtectionCenter(){
			for (int i = 0; i < src_lcode_17_short.Length; i++) {
				string srcpath = src_files + @"/AAPT/AD_Serres_Protection center_cloudapp discovery/Ongoing/master/ProtectionCenter/lba/"+ src_lcode_17_short[i] + "/ProtectionCenter/lcl/";
				string tgtpath = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AD Protection Center/";		        	
				string fileName;
				string destFile;				
		        string[] files = System.IO.Directory.GetFiles(srcpath, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files){
	                fileName = System.IO.Path.GetFileName(s);
	                destFile = System.IO.Path.Combine(tgtpath, fileName);
	                System.IO.File.Copy(s, destFile, true);
	            }
		    pb_copyfiles.Value = pb_copyfiles.Value + 1;   
			}
			listView1.Items.Add("AD Protection Center - (9 lcl files per locate, 153 in total)");
		}
		//EOL=17
		public void CloudAppDiscovery(){
			for (int i = 0; i < src_lcode_17_short.Length; i++) {
				string srcpath = src_files + @"/AAPT/AD_Serres_Protection center_cloudapp discovery/Ongoing/master/CloudAppDiscovery/lba/"+ src_lcode_17_short[i] + "/CloudAppDiscovery/lcl/";
				string tgtpath = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Cloud App Discovery/";		        	
				string fileName;
				string destFile;				
		        string[] files = System.IO.Directory.GetFiles(srcpath, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files){
	                fileName = System.IO.Path.GetFileName(s);
	                destFile = System.IO.Path.Combine(tgtpath, fileName);
	                System.IO.File.Copy(s, destFile, true);
	            }
		    pb_copyfiles.Value = pb_copyfiles.Value + 1;   
			}
			listView1.Items.Add("Cloud App Discovery - (3 lcl files per locate, 51 in total)");
		}
		//EOL=17
		public void SchedulerRP(){
		    for (int i = 0; i < src_lcode_17_short.Length; i++) {
				string srcpath = src_files + @"/azure/AzureUX_Scheduler/OnGoing/master/Scheduler.Common/lba/"+ src_lcode_17_short[i] + "/Scheduler.Common/lcl/";
				string tgtpath = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Scheduler RP/Scheduler.Common/";		        	
				string fileName;
				string destFile;
		        string[] files = System.IO.Directory.GetFiles(srcpath, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files){
	                fileName = System.IO.Path.GetFileName(s);
	                destFile = System.IO.Path.Combine(tgtpath, fileName);
	                System.IO.File.Copy(s, destFile, true);
	            }
		        
		        string srcpath1 = src_files + @"/azure/AzureUX_Scheduler/OnGoing/master/Scheduler.Data/lba/"+ src_lcode_17_short[i] + "/Scheduler.Data/lcl/";
				string tgtpath1 = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Scheduler RP/Scheduler.Data/";		        	
				string fileName1;
				string destFile1;
		        string[] files1 = System.IO.Directory.GetFiles(srcpath1, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files1){
	                fileName1 = System.IO.Path.GetFileName(s);
	                destFile1 = System.IO.Path.Combine(tgtpath1, fileName1);
	                System.IO.File.Copy(s, destFile1, true);
	            }
		        
		        string srcpath2 = src_files + @"/azure/AzureUX_Scheduler/OnGoing/master/Scheduler.Web/lba/"+ src_lcode_17_short[i] + "/Scheduler.Web/lcl/";
				string tgtpath2 = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Scheduler RP/Scheduler.Web/";		        	
				string fileName2;
				string destFile2;
		        string[] files2 = System.IO.Directory.GetFiles(srcpath2, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files2){
	                fileName2 = System.IO.Path.GetFileName(s);
	                destFile2 = System.IO.Path.Combine(tgtpath2, fileName2);
	                System.IO.File.Copy(s, destFile2, true);
	            }
		        
		        string srcpath3 = src_files + @"/azure/AzureUX_Scheduler/OnGoing/master/Scheduler.Worker/lba/"+ src_lcode_17_short[i] + "/Scheduler.Worker/lcl/";
				string tgtpath3 = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Scheduler RP/Scheduler.Worker/";		        	
				string fileName3;
				string destFile3;
		        string[] files3 = System.IO.Directory.GetFiles(srcpath3, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files3){
	                fileName3 = System.IO.Path.GetFileName(s);
	                destFile3 = System.IO.Path.Combine(tgtpath3, fileName3);
	                System.IO.File.Copy(s, destFile3, true);
	            }
		        
		    pb_copyfiles.Value = pb_copyfiles.Value + 1;        
			}
			listView1.Items.Add("Azure Scheduler RP - Success - (4 lcl file per locate, 68 in total)");
		}
		//EOL=17
		public void SchedulerExtension(){
			for (int i = 0; i < src_lcode_17.Length; i++) {
				string srcpath = src_files + @"/azure/AzureUX-SchedulerUX-FE/OnGoing/SLVso/Projects/AzureUX-SchedulerUX-FE/Localization/LCL/"+ src_lcode_17[i] + "/LocProject/lcl/src/SchedulerExtension/Client/Resources/";
				string tgtpath = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/Azure Scheduler Extension/";		        	
				string fileName;
				string destFile;				
		        string[] files = System.IO.Directory.GetFiles(srcpath, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files){
	                fileName = System.IO.Path.GetFileName(s);
	                destFile = System.IO.Path.Combine(tgtpath, fileName);
	                System.IO.File.Copy(s, destFile, true);
	            }
		    pb_copyfiles.Value = pb_copyfiles.Value + 1;   
			}
			listView1.Items.Add("Azure Scheduler Extension - (1 lcl file per locate, 17 in total)");
		}
		//EOL=28
		public void B2C(){
			for (int i = 0; i < src_lcode_28.Length; i++) {
				string srcpath = src_files + @"/AAPT/B2C_CPIM/Ongoing/B2C_CPIM/LBA/"+ src_lcode_28[i] + "/";
				string tgtpath = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_28[i] + "/AD B2C/";		        	
				string fileName;
				string destFile;				
		        string[] files = System.IO.Directory.GetFiles(srcpath, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files){
	                fileName = System.IO.Path.GetFileName(s);
	                destFile = System.IO.Path.Combine(tgtpath, fileName);
	                System.IO.File.Copy(s, destFile, true);
	            }
		    pb_copyfiles.Value = pb_copyfiles.Value + 1;   
			}
			listView1.Items.Add("AD B2C - (247 files copied in total)");
		}
		//EOL=43
		public void HISConnectors(){
			for (int i = 0; i < src_lcode_43.Length; i++) {
				string srcpath = src_files + @"/Windows Server OOBs/HIS_CONNECTORS/Semi Quarterly/Alternative/"+ src_lcode_43[i] + "/";
				string tgtpath = tgt_files + @"/Azure/" + mtb_yearmonth.Text + "/" + tgt_lcode_43[i] + "/HIS Connectors/";		        	
				string fileName;
				string destFile;				
		        string[] files = System.IO.Directory.GetFiles(srcpath, "*.*", SearchOption.AllDirectories);
	            foreach (string s in files){
	                fileName = System.IO.Path.GetFileName(s);
	                destFile = System.IO.Path.Combine(tgtpath, fileName);
	                System.IO.File.Copy(s, destFile, true);
	            }
		    pb_copyfiles.Value = pb_copyfiles.Value + 1;   
			}
			listView1.Items.Add("HIS Connectors - (9 lcl file per locate, 387 in total)");
		}
		
	}
}
