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
		
		string[] src_lcode_10_short = {"de", "es", "fr", "it", "ja", "ko", "pt-BR", "ru", "zh-HANS", "zh-HANT"};
	
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
				try {
					ESSO();
					PortalClassic();
					B2B();
				} catch (Exception ex) {
					MessageBox.Show(ex.Message);
					throw;
				}
				
				//for Files with EOL= 10
				
				
				
				pb_copyfiles.Value = 0;
				MessageBox.Show("Succesfully Done!");

			}					
		}
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
			listView1.Items.Add("Azure Portal (Classic) - Success - (92 lcl files per locate, 920 in total)");
		}
	}
}
