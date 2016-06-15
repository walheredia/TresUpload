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
		string[] target_langcode_17 = {"cs-CZ", "de-DE", "es-ES", "fr-FR", "hu-HU", "it-IT", "ja-JP", "ko-KR", "nl-NL", "pl-PL", "pt-BR", "pt-PT", "ru-RU", "sv-SE", "tr-TR", "zh-CN", "zh-TW"};
		string[] target_langcode_28 = {"ar-SA","cs-CZ", "da-DK", "de-DE", "el-GR", "es-ES", "fi-FI", "fr-FR", "he-IL", "hr-HR", "hu-HU", "it-IT", "ja-JP", "ko-KR", "ms-MY", "nb-NO", "nl-NL", "pl-PL", "pt-BR", "pt-PT", "ro-RO", "ru-RU", "sk-SK", "sv-SE", "th-TH", "tr-TR", "zh-CN", "zh-TW"};
		
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
			pb_structure.Maximum = target_langcode_17.Length;
			pb_structure.Value = 0;
			fbd_createStructure.SelectedPath = "C:/Users/v-wahere/Desktop/TresUpload";
			fbd_createStructure.Description = "Please select the directory where you want to create the new structure";
			fbd_createStructure.SelectedPath = "";
			fbd_createStructure.ShowDialog();
			if (fbd_createStructure.SelectedPath.ToString() != "") {
				Directory.SetCurrentDirectory(fbd_createStructure.SelectedPath.ToString());
				for (int i=0; i<target_langcode_17.Length; i++) {
					if (chkbx_SchedulerExtension.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/Azure Scheduler Extension/");
					}
					if (chkbx_SchedulerRP.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/Azure Scheduler RP/");
					}
					if (chkbx_RedisChacheRP.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/Azure Redis Cache RP/");
					}
					if (chkbx_RedisCacheExtension.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/Azure Redis Cache Extension/");
					}
					if (chkbx_ResourceProviderSDK.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/Azure Resource Provider SDK/");
					}
					if (chkbx_ResourceManager.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/Azure Resource Manager/");
					}
					if (chkbx_PortalFX.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/Azure Portal FX/");
					}
					if (chkbx_InsightNotRP.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/Azure Insight NotRP/");
					}
					if (chkbx_InsightEvtRP.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/Azure Insight EvtRP/");
					}
					if (chkbx_InsightMonRP.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/Azure Insight MonRP/");
					}
					if (chkbx_InsightCommon.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/Azure Insight Common/");
					}
					if (chkbx_StoreMarketplace.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/Azure Store Marketplace/");
					}
					if (chkbx_StoreExperience.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/Azure Store Experience/");
					}
					if (chkbx_PortalClassic.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/Azure Portal (Classic)/");
					}
					if (chkbx_InsightExtension.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/Azure Insight Extension/");
					}
					if (chkbx_WindowsAzurePack.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/Windows Azure Pack (Classic)/");
					}
					if (chkbx_B2B.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/AD B2B/");
					}
					if (chkbx_B2C.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/AD B2C/");
					}
					if (chkbx_IntuneMAMExtension.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/Microsoft Intune MAM Extension/");
					}
					if (chkbx_DocDB.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/DataInsight Azure DocDB/");
					}
					if (chkbx_AzureSearch.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/DataInsight Azure Search/");
					}
					if (chkbx_SQLDB.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/DataInsight Azure SQLDB/");
					}
					if (chkbx_RBAC.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/Role Based Access Control/");
					}
					if (chkbx_ADIAM.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/AD IAM/");
					}
					if (chkbx_ADProtectionCenter.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/AD Protection Center/");
					}
					if (chkbx_CloudAppDiscovery.Checked) {
						Directory.CreateDirectory("Azure/month/" + target_langcode_17[i] + "/Cloud App Discovery/");
					}
					pb_structure.Value = pb_structure.Value + 1;
				}
				MessageBox.Show("Directory Succesfully Created");
				pb_structure.Value = 0;
			}
			enable();
		}		
	}
}
