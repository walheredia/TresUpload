/*
 * Created by SharpDevelop.
 * User: walterh
 * Date: 5/4/2016
 * Time: 3:43 PM
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
	/// Description of AD.
	/// </summary>
	public partial class AD : Form
	{
		string[] src_lcode_16 = {"da-DK","de-DE", "es-ES", "fr-FR", "it-IT", "ja-JP", "ko-KR","nb-NO", "nl-NL", "pl-PL", "pt-BR", "ru-RU", "sv-SE", "tr-TR", "zh-CN", "zh-TW"};
		string[] tgt_lcode_16 = {"da-DK","de-DE", "es-ES", "fr-FR", "it-IT", "ja-JP", "ko-KR","nb-NO", "nl-NL", "pl-PL", "pt-BR", "ru-RU", "sv-SE", "tr-TR", "zh-CN", "zh-TW"};
		string[] src_lcode2_17 = {"cs", "de", "es", "fr", "hu", "it", "ja", "ko", "nl", "pl", "pt-BR", "pt-PT", "ru", "sv", "tr", "zh-hans", "zh-hant"};
		string[] src_lcode_17 = {"cs-CZ", "de-DE", "es-ES", "fr-FR", "hu-HU", "it-IT", "ja-JP", "ko-KR", "nl-NL", "pl-PL", "pt-BR", "pt-BT", "ru-RU", "sv-SE", "tr-TR", "zh-CN", "zh-TW"};
		string[] tgt_lcode_17 = {"cs-CZ", "de-DE", "es-ES", "fr-FR", "hu-HU", "it-IT", "ja-JP", "ko-KR", "nl-NL", "pl-PL", "pt-BR", "pt-BT", "ru-RU", "sv-SE", "tr-TR", "zh-CN", "zh-TW"};
		
		public static string tgt_files = "";
		public static string src_files = "";
		
		public AD()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//Cursor to the left
		void Mtb_yearmonthMouseClick(object sender, MouseEventArgs e)
		{
			mtb_yearmonth.SelectionStart = 0;
			mtb_yearmonth.SelectionStart = mtb_yearmonth.Text.Length;
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
		
		void Btn_ChekAllClick(object sender, EventArgs e)
		{
			foreach (Control c in this.GrBox_Select_Components.Controls) {                
                if(c is CheckBox) {
                    CheckBox chk;
                    chk = (CheckBox)c;
                    chk.Checked = true;                
                }
            }
		}
		
		void Btn_UnchekAllClick(object sender, EventArgs e)
		{
			foreach (Control c in this.GrBox_Select_Components.Controls) {                
                if(c is CheckBox) {
                    CheckBox chk;
                    chk = (CheckBox)c;
                    chk.Checked = false;                
                }
            }
		}
		
		void Btn_CreateStructureClick(object sender, EventArgs e)
		{
			fbd_createStructure.SelectedPath = "C:/Eliseo/TRES/Upload";
			MessageBox.Show(fbd_createStructure.SelectedPath.ToString());
			fbd_createStructure.Description="Please select the directory where you want to create the new structure";
			
			if (fbd_createStructure.ShowDialog()==DialogResult.OK)
			{
				Directory.SetCurrentDirectory(fbd_createStructure.SelectedPath.ToString());
				tgt_files=fbd_createStructure.SelectedPath.ToString();
				
				for (int i=0; i<tgt_lcode_16.Length; i++) 
				{
					if (chkbx_ADBilling.Checked) 
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_16[i] + "/Billing/");
					}
					
					
				}
				
				for (int i=0; i<tgt_lcode_17.Length; i++) 
				{
					
					if (chbx_ADBillingExtension.Checked) 
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/BillingExt/");
					}
					
					if (chbx_ADConnect.Checked)
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AADConnect/Microsoft.Azure.ActiveDirectory.Synchronization.Setup/");
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AADConnect/Microsoft.Online.Deployment.Framework/");
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AADConnect/Microsoft.Online.Deployment.OneADWizard/");
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AADConnect/Microsoft.Online.Deployment.Types/");
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AADConnect/Microsoft.Online.Deployment.PSModule/");
					}
					
					if (chbx_ADConnectHealth.Checked) 
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AADConnectHealth/");
					}
					
					if (chbx_PIM.Checked) 
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AD-PIM/API/");
					}
					
					if(chbx_Rome.Checked)
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AzureSecurityCenter/");
					}
					
				}
				
			}
		}
		void Btn_copyfilesClick(object sender, EventArgs e)
		{
			fbd_copyfiles.SelectedPath="C:/Eliseo/TRES/";
			fbd_copyfiles.Description="Please select the directory of the Source Files (Enlistment from SDW)";
			
			if (fbd_copyfiles.ShowDialog() == DialogResult.OK)
			{
				src_files = fbd_copyfiles.SelectedPath.ToString();
				
				
				try 
				{
					if(chkbx_ADBilling.Checked)
					{
						ADBilling();
					}
					if(chbx_PIM.Checked)
					{
						PIM();
					}
					if(chbx_ADBillingExtension.Checked)
					{
						ADBillingEx();
					}
					if(chbx_ADConnect.Checked)
					{
						AADConnect();
					}
					if(chbx_ADConnectHealth.Checked)
					{
						AADConnectHealth();
					}
					if(chbx_Rome.Checked)
					{
						Rome();
					}
					
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
					throw;
				}
				
			
				
				//for Files with EOL= 16
				
				//for files with EOL=17
				
			}
	
		}
		
		public void ADBilling()
		{
			for (int i = 0; i < src_lcode_16.Length; i++) 
				{
					
						//c:\Eliseo\TRES\AD-Billing\Ongoing\stage\Accounts.Resources\lba\da-dk\Accounts.Resources\lcl\
						string srcpath = src_files + @"/AD-Billing/Ongoing/stage/Accounts.Resources/lba/"+ src_lcode_16[i] + "/Accounts.Resources/lcl/";
						string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_16[i] + "/AD Billing/";		        	
						string fileName;
						string destFile;				
			            
						string[] files = System.IO.Directory.GetFiles(srcpath, "*.*", SearchOption.AllDirectories);
		            	// Copy the files and overwrite destination files if they already exist.
		            	foreach (string s in files)
		            	{
		                	// Use static Path methods to extract only the file name from the path.
		                	fileName = System.IO.Path.GetFileName(s);
		                	destFile = System.IO.Path.Combine(tgtpath, fileName);
		                	System.IO.File.Copy(s, destFile, true);
		            	}
					
					
			       
				}
		}
		
		public void ADBillingEx()
		{
			for (int i = 0; i < src_lcode2_17.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD-BillingExt\OnGoing\stage\AzureBillingExtension\lba\cs\AzureBillingExtension\lcl\
					string srcpath = src_files + @"/AD-BillingExt/Ongoing/stage/AzureBillingExtension/lba/"+ src_lcode2_17[i] + "/AzureBillingExtension/lcl/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AD Billing Extension/";		        	
					string fileName;
					string destFile;				
			        string[] files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
					
					//c:\Eliseo\TRES\AD-BillingExt\OnGoing\stage\BillingExtension\lba\cs\BillingExtension\lcl\Client\
			        srcpath = src_files + @"/AD-BillingExt/Ongoing/stage/BillingExtension/lba/"+ src_lcode2_17[i] + "/BillingExtension/lcl/Client/";
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
				}
		}
		
		public void PIM()
		{
			for (int i = 0; i < src_lcode2_17.Length; i++) 
				{
					
					
					string srcpath = src_files + @"/AD-PIM/OnGoing/master/PIM.Common/lba/"+ src_lcode2_17[i] + "/PIM.Common/lcl/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AD-PIM/";		        	
					string fileName;
					string destFile;				
			        string[] files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            		{
	                		fileName = System.IO.Path.GetFileName(s);
	                		destFile = System.IO.Path.Combine(tgtpath, fileName);
	                		System.IO.File.Copy(s, destFile, true);
	            		}
					
					//c:\Eliseo\TRES\AD-PIM\OnGoing\master\PIM.Common.DbManager\lba\cs\PIM.Common.DbManager\lcl\
			      	srcpath = src_files + @"/AD-PIM/OnGoing/master/PIM.Common.DbManager/lba/"+ src_lcode2_17[i] + "/PIM.Common.DbManager/lcl/";
									
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            		{
	                		fileName = System.IO.Path.GetFileName(s);
	                		destFile = System.IO.Path.Combine(tgtpath, fileName);
	                		System.IO.File.Copy(s, destFile, true);
	            		}
					
	            	//c:\Eliseo\TRES\AD-PIM\OnGoing\master\PIM.Extension\lba\cs\PIM.Extension\lcl\Client\
			      	srcpath = src_files + @"/AD-PIM/OnGoing/master/PIM.Extension/lba/"+ src_lcode2_17[i] + "/PIM.Extension/lcl/Client/";
									
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            		{
	                		fileName = System.IO.Path.GetFileName(s);
	                		destFile = System.IO.Path.Combine(tgtpath, fileName);
	                		System.IO.File.Copy(s, destFile, true);
	            		}
	            	
	            	//c:\Eliseo\TRES\AD-PIM\OnGoing\master\PIM.PSModule\lba\cs\PIM.PSModule\lcl\
			      	srcpath = src_files + @"/AD-PIM/OnGoing/master/PIM.PSModule/lba/"+ src_lcode2_17[i] + "/PIM.PSModule/lcl/";
									
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            		{
	                		fileName = System.IO.Path.GetFileName(s);
	                		destFile = System.IO.Path.Combine(tgtpath, fileName);
	                		System.IO.File.Copy(s, destFile, true);
	            		}
	            	
	            	//c:\Eliseo\TRES\AD-PIM\OnGoing\master\PIM.API\lba\cs\PIM.API\lcl\
	            	srcpath = src_files + @"/AD-PIM/OnGoing/master/PIM.API/lba/"+ src_lcode2_17[i] + "/PIM.API/lcl/";
					tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AD-PIM/API/";				
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            		{
	                		fileName = System.IO.Path.GetFileName(s);
	                		destFile = System.IO.Path.Combine(tgtpath, fileName);
	                		System.IO.File.Copy(s, destFile, true);
	            		}
				}
		}
		
		public void AADConnect()
		{
			for (int i = 0; i < src_lcode2_17.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD-IAM-HybridSync\Continuous\develop\Microsoft.Azure.ActiveDirectory.Synchronization.Setup\lba\cs\Microsoft.Azure.ActiveDirectory.Synchronization.Setup\lcl\
					string srcpath = src_files + @"/AD-IAM-HybridSync/Continuous/develop/Microsoft.Azure.ActiveDirectory.Synchronization.Setup/lba/"+ src_lcode2_17[i] + "/Microsoft.Azure.ActiveDirectory.Synchronization.Setup/lcl/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AADConnect/Microsoft.Azure.ActiveDirectory.Synchronization.Setup/";		        	
					string fileName;
					string destFile;				
			        string[] files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
					
	            	//c:\Eliseo\TRES\AD-IAM-HybridSync\Continuous\develop\Microsoft.Online.Deployment.Framework\lba\cs\Microsoft.Online.Deployment.Framework\lcl\
					srcpath = src_files + @"/AD-IAM-HybridSync/Continuous/develop/Microsoft.Online.Deployment.Framework/lba/"+ src_lcode2_17[i] + "/Microsoft.Online.Deployment.Framework/lcl/";
					tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AADConnect/Microsoft.Online.Deployment.Framework/";		        					
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
					
	            	
					srcpath = src_files + @"/AD-IAM-HybridSync/Continuous/develop/Microsoft.Online.Deployment.OneADWizard/lba/"+ src_lcode2_17[i] + "/Microsoft.Online.Deployment.OneADWizard/lcl/";
					tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AADConnect/Microsoft.Online.Deployment.OneADWizard/";		        					
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
	            	
	            	srcpath = src_files + @"/AD-IAM-HybridSync/Continuous/develop/Microsoft.Online.Deployment.PSModule/lba/"+ src_lcode2_17[i] + "/Microsoft.Online.Deployment.PSModule/lcl/";
					tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AADConnect/Microsoft.Online.Deployment.PSModule/";		        					
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
	            	
	            	srcpath = src_files + @"/AD-IAM-HybridSync/Continuous/develop/Microsoft.Online.Deployment.Types/lba/"+ src_lcode2_17[i] + "/Microsoft.Online.Deployment.Types/lcl/";
					tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AADConnect/Microsoft.Online.Deployment.Types/";		        					
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
				}
		}
		
		public void AADConnectHealth()
		{
			for (int i = 0; i < src_lcode2_17.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD-OneADHealth-Main\OnGoing\develop\AdHealthAdfsAgentSetupBundle\lba\cs\AdHealthAdfsAgentSetupBundle\lcl\theme\
					string srcpath = src_files + @"/AD-OneADHealth-Main/OnGoing/develop/AdHealthAdfsAgentSetupBundle/lba/"+ src_lcode2_17[i] + "/AdHealthAdfsAgentSetupBundle/lcl/theme/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AADConnectHealth/";		        	
					string fileName;
					string destFile;				
			        string[] files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
					
	            	//c:\Eliseo\TRES\AD-OneADHealth-Main\OnGoing\develop\AdHealthAgentConfigurationPowerShell\lba\cs\AdHealthAgentConfigurationPowerShell\lcl\
					srcpath = src_files + @"/AD-OneADHealth-Main/OnGoing/develop/AdHealthAgentConfigurationPowerShell/lba/"+ src_lcode2_17[i] + "/AdHealthAgentConfigurationPowerShell/lcl/";
					tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AADConnectHealth/";		        					
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
					
		            //c:\Eliseo\TRES\AD-OneADHealth-Main\OnGoing\develop\ADHealthExtension\lba\cs\ADHealthExtension\lcl\Client\
		            srcpath = src_files + @"/AD-OneADHealth-Main/OnGoing/develop/ADHealthExtension/lba/"+ src_lcode2_17[i] + "/ADHealthExtension/lcl/Client/";
					tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AADConnectHealth/";		        					
			        files = System.IO.Directory.GetFiles(srcpath, "*.*", SearchOption.AllDirectories);
		            	// Copy the files and overwrite destination files if they already exist.
		            	foreach (string s in files)
		            	{
		                	// Use static Path methods to extract only the file name from the path.
		                	fileName = System.IO.Path.GetFileName(s);
		                	destFile = System.IO.Path.Combine(tgtpath, fileName);
		                	System.IO.File.Copy(s, destFile, true);
		            	}
		            	
		            //c:\Eliseo\TRES\AD-OneADHealth-Main\OnGoing\develop\ADHealthMarketplacePackage\lba\cs\AdHealthMarketplacePackage\lcl\GalleryPackages\Strings
					srcpath = src_files + @"/AD-OneADHealth-Main/OnGoing/develop/ADHealthMarketplacePackage/lba/"+ src_lcode2_17[i] + "/AdHealthMarketplacePackage/lcl/GalleryPackages/Strings/";
					tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AADConnectHealth/";		        					
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
	            	
	            	//c:\Eliseo\TRES\AD-OneADHealth-Main\OnGoing\develop\Microsoft.Identity.Health.Common.DataAccess\lba\cs\Microsoft.Identity.Health.Common.DataAccess\lcl\TableData\
	            	srcpath = src_files + @"/AD-OneADHealth-Main/OnGoing/develop/Microsoft.Identity.Health.Common.DataAccess/lba/"+ src_lcode2_17[i] + "/Microsoft.Identity.Health.Common.DataAccess/lcl/TableData/";
					tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AADConnectHealth/";		        					
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
				}
		}
		
		public void Rome()
		{
			for (int i = 0; i < src_lcode2_17.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AzureSecurityCenter\OnGoing\master\SecurityDashboardExtension\lba\cs\SecurityDashboardExtension\lcl\Client\
					string srcpath = src_files + @"/AzureSecurityCenter/OnGoing/master/SecurityDashboardExtension/lba/"+ src_lcode2_17[i] + "/SecurityDashboardExtension/lcl/Client/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AzureSecurityCenter/";		        	
					string fileName;
					string destFile;				
			        string[] files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
					
					
				}
		}
		
		void Mtb_yearmonthMaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
	
		}
	
		}
	}

