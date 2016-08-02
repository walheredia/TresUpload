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
		string[] src_lcode_2 = {"es", "ko"};
		string[] tgt_lcode_2 = {"es-ES", "ko-KR"};
		string[] src_lcode_4 = {"de-DE", "es-ES", "fr-FR", "ja-JP"};
		string[] tgt_lcode_4 = {"de-DE", "es-ES", "fr-FR", "ja-JP"};
		string[] src_lcode_6 = {"es", "fr", "it", "ja", "zh-HANS", "zh-HANT"};
		string[] tgt_lcode_6 = {"es-ES", "fr-FR", "it-IT", "ja-JP", "zh-CN", "zh-TW"};
		string[] src_lcode_7 = {"de", "es", "fr", "it", "ja", "zh-HANS", "zh-HANT"};
		string[] tgt_lcode_7 = {"de-DE", "es-ES", "fr-FR", "it-IT", "ja-JP", "zh-CN", "zh-TW"};
		string[] src_lcode_16 = {"da-DK","de-DE", "es-ES", "fr-FR", "it-IT", "ja-JP", "ko-KR","nb-NO", "nl-NL", "pl-PL", "pt-BR", "ru-RU", "sv-SE", "tr-TR", "zh-CN", "zh-TW"};
		string[] tgt_lcode_16 = {"da-DK","de-DE", "es-ES", "fr-FR", "it-IT", "ja-JP", "ko-KR","nb-NO", "nl-NL", "pl-PL", "pt-BR", "ru-RU", "sv-SE", "tr-TR", "zh-CN", "zh-TW"};
		string[] src_lcode2_17 = {"cs", "de", "es", "fr", "hu", "it", "ja", "ko", "nl", "pl", "pt-BR", "pt-PT", "ru", "sv", "tr", "zh-hans", "zh-hant"};
		string[] src_lcode_17 = {"cs-CZ", "de-DE", "es-ES", "fr-FR", "hu-HU", "it-IT", "ja-JP", "ko-KR", "nl-NL", "pl-PL", "pt-BR", "pt-PT", "ru-RU", "sv-SE", "tr-TR", "zh-CN", "zh-TW"};
		string[] tgt_lcode_17 = {"cs-CZ", "de-DE", "es-ES", "fr-FR", "hu-HU", "it-IT", "ja-JP", "ko-KR", "nl-NL", "pl-PL", "pt-BR", "pt-PT", "ru-RU", "sv-SE", "tr-TR", "zh-CN", "zh-TW"};
		string[] src_lcode_21 = {"da", "de", "en-gb", "es", "es-mx", "fi", "fr", "fr-ca", "it", "ja", "ko", "nb-no", "nl", "pl", "pt-br", "pt-pt", "ru", "sv", "tr", "zh-hans", "zh-hant"};
		string[] tgt_lcode_21 = {"da-DK", "de-DE", "en-gb", "es-ES", "es-mx", "fi-FI", "fr-FR", "fr-ca", "it-IT", "ja-JP", "ko-KR", "nb-no", "nl-NL", "pl-PL", "pt-br", "pt-pt", "ru-RU", "sv-SE", "tr-TR", "zh-CN", "zh-TW"};
		
		string[] src_lcode_33 = {"bg", "cs", "da", "de", "el", "es", "et", "fi", "fr", "hr", "hu", "it", "ja", "kk", "ko", "lt", "lv", "nl", "no", "pl", "pt-br", "pt-pt", "ro", "ru", "sk", "sl", "sr-latn-rs", "sv", "th", "tr", "uk", "zh-hans", "zh-hant"};
		string[] tgt_lcode_33 = {"bg-bg", "cs-cz", "da-dk", "de-de", "el-gr", "es-es", "et-ee", "fi-fi", "fr-fr", "hr-hr", "hu-hu", "it-it", "ja-jp", "kk-kz", "ko-kr", "lt-lt", "lv-lv", "nb-no", "nl-nl", "pl-pl", "pt-br", "pt-pt", "ro-ro", "ru-ru", "sk-sk", "sl-si", "sr-latn-rs", "sv-se", "th-th", "tr-tr", "uk-ua", "zh-cn", "zh-tw"};
		
		string[] src_lcode_35 = {"bg-BG", "cs-CZ", "da-DK", "de-DE", "el-GR", "es-ES", "et-EE", "fi-FI", "fr-FR", "hi-IN", "hr-HR", "hu-HU", "it-IT", "ja-JP", "ko-KR", "lt-LT", "lv-LV", "nb", "nb-NO", "nl-NL", "pl-PL", "pt-BR", "pt-PT", "ro-RO", "ru-RU", "sk-SK", "sl-SI", "sr-latn-CS", "sr-Latn-RS", "sv-SE", "th-TH", "tr-TR", "uk-UA", "zh-CN", "zh-TW"};
		string[] tgt_lcode_35 = {"bg-BG", "cs-CZ", "da-DK", "de-DE", "el-GR", "es-ES", "et-EE", "fi-FI", "fr-FR", "hi-IN", "hr-HR", "hu-HU", "it-IT", "ja-JP", "ko-KR", "lt-LT", "lv-LV", "nb", "nb-NO", "nl-NL", "pl-PL", "pt-BR", "pt-PT", "ro-RO", "ru-RU", "sk-SK", "sl-SI", "sr-latn-CS", "sr-Latn-RS", "sv-SE", "th-TH", "tr-TR", "uk-UA", "zh-CN", "zh-TW"};
		//"ar", "bg", "ca", "cs", "da", "de", "el", "en-gb", "es", "fi", "fil-ph", "fr", "he", "hi", "hr", "hu", "id", "it", "ja", "ko", "lt", "lv", "nb-no", "nl", "pl", "pt-br", "pt-pt", "ro", "ru", "sk", "sl", "sr-cyrl-rs", "sv", "th", "tr", "uk", "vi", "zh-hans", "zh-hant"
		string[] src_lcode_39 = {"ar", "bg", "ca", "cs", "da", "de", "el", "en-gb", "es", "fi", "fil-ph", "fr", "he", "hi", "hr", "hu", "id", "it", "ja", "ko", "lt", "lv", "nb-no", "nl", "pl", "pt-br", "pt-pt", "ro", "ru", "sk", "sl", "sr-cyrl-rs", "sv", "th", "tr", "uk", "vi", "zh-hans", "zh-hant"};
		string[] tgt_lcode_39 = {"ar-sa", "bg-bg", "ca-es", "cs-cz", "da-dk", "de-de", "el-gr", "en-gb", "es-es", "fil-ph", "fr-fr", "he-il", "hi-in", "hr-hr", "hu-hu", "id-id", "it-it", "ja-jp", "ko-kr", "lt-lt", "lv-lv", "nb-no", "nl-nl", "pl-pl", "pt-br", "pt-pt", "ro-ro", "ru-ru", "sk-sk", "sl-si", "sr-cyrl-rs", "sv-se", "sr-latn-rs", "th-th", "tr-tr", "uk-ua", "zh-cn", "zh-tw"};
		string[] src_lcode_41 = {"bg-BG", "ca-ES", "cs-CZ", "da-DK", "de-DE", "el-GR", "es-ES", "et-EE", "eu-ES", "fi-FI", "fr-FR", "gl-ES", "hi-IN", "hr-HR", "hu-HU", "id-ID", "it-IT", "ja-JP", "kk-KZ", "ko-KR", "lt-LT", "lv-LV", "ms-MY", "nb-NO", "nl-NL", "pl-PL", "pt-BR", "pt-PT", "ro-RO", "ru-RU", "sk-SK", "sl-SI", "sr-Cyrl-RS", "sr-Latn-RS", "sv-SE", "th-TH", "tr-TR", "uk-UA", "vi-VN", "zh-Hans", "zh-Hant"};
		string[] tgt_lcode_41 = {"bg-BG", "ca-ES", "cs-CZ", "da-DK", "de-DE", "el-GR", "es-ES", "et-EE", "eu-ES", "fi-FI", "fr-FR", "gl-ES", "hi-IN", "hr-HR", "hu-HU", "id-ID", "it-IT", "ja-JP", "kk-KZ", "ko-KR", "lt-LT", "lv-LV", "ms-MY", "nb-NO", "nl-NL", "pl-PL", "pt-BR", "pt-PT", "ro-RO", "ru-RU", "sk-SK", "sl-SI", "sr-Cyrl-RS", "sr-Latn-RS", "sv-SE", "th-TH", "tr-TR", "uk-UA", "vi-VN", "zh-CN", "zh-TW"};
		//"AR-SA", "BG", "CA", "CS", "DA", "DE", "EL", "ES", "ET", "EU", "FI", "FR", "GL", "HE", "HI", "HR", "HU", "ID", "IT", "JA", "KK", "KO", "LT", "LV", "MS", "NL", "NO", "PL", "PT", "PT-BR", "RO", "RU", "SK", "SL", "SR-CYRL-CS", "SR-LATN-CS", "SV", "TH", "TR", "UK", "VI", "ZH-HANS", "ZH-HANT"
		//"ar-sa", "bg-BG", "ca-ES", "cs-CZ", "da-DK", "de-DE", "el-GR", "es-ES", "et-EE", "fi-FI", "fr-FR", "gl-ES", "he-IL", "hi-IN", "hr-HR", "hu-HU", "id-ID", "it-IT", "ja-jp", "kk-KZ", "ko-KR", "lt-LT", "lv-LV", "ms-MY", "nb-NO", "nl-NL", "pl-PL", "pt-br", "pt-PT", "ro-RO", "ru-RU", "sk-SK", "sl-SI", "sr-cyrl-RS", "sr-latn-RS", "sv-SE"
		string[] src_lcode_43 = {"AR-SA", "BG", "CA", "CS", "DA", "DE", "EL", "ES", "ET", "EU", "FI", "FR", "GL", "HE", "HI", "HR", "HU", "ID", "IT", "JA", "KK", "KO", "LT", "LV", "MS", "NL", "NO", "PL", "PT", "PT-BR", "RO", "RU", "SK", "SL", "SR-CYRL-RS", "SR-LATN-RS", "SV", "TH", "TR", "UK", "VI", "ZH-HANS", "ZH-HANT"};
		string[] tgt_lcode_43 = {"ar-sa", "bg-BG", "ca-ES", "cs-CZ", "da-DK", "de-DE", "el-GR", "es-ES", "et-EE", "fi-FI", "fr-FR", "gl-ES", "he-IL", "hi-IN", "hr-HR", "hu-HU", "id-ID", "it-IT", "ja-jp", "kk-KZ", "ko-KR", "lt-LT", "lv-LV", "ms-MY", "nb-NO", "nl-NL", "pl-PL", "pt-br", "pt-PT", "ro-RO", "ru-RU", "sk-SK", "sl-SI", "sr-cyrl-RS", "sr-latn-RS", "sv-SE"};
		string[] src_lcode_65 = {"af", "am-ET", "ar", "az-latn-az", "be", "bg", "bn-IN", "ca", "cs", "da", "de", "el", "en-gb", "es", "es-mx", "et", "eu", "fa", "fi", "fil-ph", "fr", "fr-ca", "gl", "ha-latn-ng", "he", "hi", "hr", "hu", "id", "is", "it", "ja", "kk", "km-kh", "kn", "ko", "lo", "lt", "lv", "mk", "ml", "ms", "nb-no", "nl", "pl", "pt-br", "pt-pt", "ro", "ru", "sk", "sl", "sq", "sr-cyrl-rs", "sr-latn", "sv", "sw", "ta", "te", "th", "tr", "uk", "uz-latn-uz", "vi", "zh-hans", "zh-hant"};
		string[] tgt_lcode_65 = {"af-za", "am-et", "ar-sa", "az-latn-az", "be-by", "bg-bg", "bn-in", "ca-es", "cs-cz", "da-dk", "de-de", "el-gr", "en-gb", "es-es", "es-mx", "et-ee", "eu-es", "fa-ir", "fi-fi", "fil-ph", "fr-fr", "fr-ca", "gl-es", "ha-latn-ng", "he-il", "hi-in", "hr-hr", "hu-hu", "id-id", "is-is", "it-it", "ja-jp", "kk-kz", "km-kh", "kn-in", "ko-kr", "lo-la", "lt-lt", "lv-lv", "mk-mk", "ml-in", "ms-my", "nb-no", "nl-nl", "pl-pl", "pt-br", "pt-pt", "ro-ro", "ru-ru", "sk-sk", "sl-si", "sq-al", "sr-cyrl-rs", "sr-latn-rs", "sv-se", "sw-ke", "ta-in", "te-in", "th-th", "tr-tr", "uk-ua", "uz-latn-uz", "vi-vn", "zh-cn", "zh-tw"};
		string[] src_lcode_107 = {"af-ZA", "am-ET", "ar-SA", "as-IN", "az-latn-AZ", "be-BY", "bg-BG", "bn-BD", "bn-IN", "bs-Latn-BA", "ca-es", "ca-ES-valencia", "cs-CZ", "cy-gb", "da-DK", "de-DE", "el-GR", "en-GB", "es-ES", "es-MX", "et-EE", "eu-es", "fa-IR", "fi-FI", "fil-PH", "fr-CA", "fr-FR", "ga-IE", "gd-GB", "gl-ES", "gu-in", "ha-latn-NG", "he-IL", "hi-in", "hr-HR", "hu-HU", "hy-AM", "id-id", "ig-NG", "is-IS", "it-IT", "ja-JP", "ka-GE", "kk-KZ", "km-KH", "kn-IN", "kok-IN", "ko-KR", "ku-ARAB-IQ", "ky-KG", "lb-LU", "lo-LA", "lt-LT", "lv-LV", "mi-NZ", "mk-MK", "ml-IN", "mn-MN", "mr-in", "ms-my", "mt-MT", "nb-NO", "ne-NP", "nl-NL", "nn-NO", "nso-ZA", "or-IN", "pa-Arab-PK", "pa-IN", "pl-PL", "prs-AF", "pt-br", "pt-PT", "quz-PE", "ro-RO", "ru-RU", "rw-RW", "sd-Arab-PK", "si-LK", "sk-SK", "sl-SI", "sq-AL", "sr-Cyrl-BA", "sr-cyrl-RS", "sr-latn-RS", "sv-SE", "sw-KE", "ta-IN", "te-IN", "tg-Cyrl-TJ", "th-TH", "ti-ET", "tk-TM", "tn-ZA", "tr-TR", "tt-RU", "ug-CN", "uk-UA", "ur-PK", "uz-latn-UZ", "vi-vn", "wo-SN", "xh-ZA", "yo-NG", "zh-cn", "zh-tw", "zu-ZA"};
		string[] src_lcode2_107 = {"af", "am", "ar-SA", "as", "az", "be", "bg", "bn", "bn-IN", "bs", "ca", "ca-ES-valencia", "cs", "cy", "da", "de", "el", "en-GB", "es", "es-MX", "et", "eu", "fa", "fi", "fil", "fr-CA", "fr", "ga", "gd", "gl", "gu", "ha", "he", "hi", "hr", "hu", "hy", "id", "ig", "is", "it", "ja", "ka", "kk", "km", "kn", "kok", "ko", "ku-Arab", "ky", "lb", "lo", "lt", "lv", "mi", "mk", "ml", "mn", "mr", "ms", "mt", "no", "ne", "nl", "nn-NO", "nso", "or", "pa-Arab-PK", "pa-IN", "pl", "prs", "pt-BR", "pt", "quz", "ro", "ru", "rw", "sd", "si", "sk", "sl", "sq", "sr-cyrl-BA", "sr-cyrl-RS", "sr-Latn-RS", "sv", "sw", "ta", "te", "tg", "th", "ti", "tk", "tn", "tr", "tt", "ug", "uk", "ur", "uz", "vi", "wo", "xh", "yo", "zh-HANS", "zh-HANT", "zu"};
		string[] tgt_lcode_107 = {"af-ZA", "am-ET", "ar-SA", "as-IN", "az-latn-AZ", "be-BY", "bg-BG", "bn-BD", "bn-IN", "bs-Latn-BA", "ca-es", "ca-ES-valencia", "cs-CZ", "cy-gb", "da-DK", "de-DE", "el-GR", "en-GB", "es-ES", "es-MX", "et-EE", "eu-es", "fa-IR", "fi-FI", "fil-PH", "fr-CA", "fr-FR", "ga-IE", "gd-GB", "gl-ES", "gu-in", "ha-latn-NG", "he-IL", "hi-in", "hr-HR", "hu-HU", "hy-AM", "id-id", "ig-NG", "is-IS", "it-IT", "ja-JP", "ka-GE", "kk-KZ", "km-KH", "kn-IN", "kok-IN", "ko-KR", "ku-ARAB-IQ", "ky-KG", "lb-LU", "lo-LA", "lt-LT", "lv-LV", "mi-NZ", "mk-MK", "ml-IN", "mn-MN", "mr-in", "ms-my", "mt-MT", "nb-NO", "ne-NP", "nl-NL", "nn-NO", "nso-ZA", "or-IN", "pa-Arab-PK", "pa-IN", "pl-PL", "prs-AF", "pt-br", "pt-PT", "quz-PE", "ro-RO", "ru-RU", "rw-RW", "sd-Arab-PK", "si-LK", "sk-SK", "sl-SI", "sq-AL", "sr-Cyrl-BA", "sr-cyrl-RS", "sr-latn-RS", "sv-SE", "sw-KE", "ta-IN", "te-IN", "tg-Cyrl-TJ", "th-TH", "ti-ET", "tk-TM", "tn-ZA", "tr-TR", "tt-RU", "ug-CN", "uk-UA", "ur-PK", "uz-latn-UZ", "vi-vn", "wo-SN", "xh-ZA", "yo-NG", "zh-cn", "zh-tw", "zu-ZA"};
		
		string[] src_lcode_108 = {"af", "am-et", "ar", "as-in", "az-latn-az", "be", "bg", "bn-bd", "bn-in", "bs-latn-ba", "ca", "ca-es-valencia", "cs", "cy-gb", "da", "de", "el", "en-gb", "es", "es-mx", "et", "eu", "fa", "fi", "fil-ph", "fr", "fr-ca", "ga-ie", "gd", "gl", "gu", "ha-latn-ng", "he", "hi", "hr", "hu", "hy", "id", "ig-ng", "is", "it", "ja", "ka", "kk", "km-kh", "kn", "ko", "kok", "ku-arab", "ky", "lb-lu", "lo", "lt", "lv", "mi-nz", "mk", "ml", "mn", "mr", "ms", "mt-mt", "nb-no", "ne-np", "nl", "nn-no", "nso-za", "or-in", "pa", "pa-arab", "pl", "prs-af", "pt-br", "pt-pt", "quc", "quz-pe", "ro", "ru", "rw", "sd-arab", "si-lk", "sk", "sl", "sq", "sr-cyrl-ba", "sr-cyrl-rs", "sr-latn", "sv", "sw", "ta", "te", "tg-cyrl", "th", "ti", "tk-tm", "tn-za", "tr", "tt", "ug-arab", "uk", "ur", "uz-latn-uz", "vi", "wo", "xh-za", "yo-ng", "zh-hans", "zh-hant", "zu-za"};
		string[] tgt_lcode_108 = {"af-za", "am-et", "ar-sa", "as-in", "az-latn-az", "be-by", "bg-bg", "bn-bd", "bn-in", "bs-latn-ba", "ca-es", "ca-es-valencia", "cs-cz", "cy-gb", "da-dk", "de-de", "el-gr", "en-gb", "es-es", "es-mx", "et-ee", "eu-es", "fa-ir", "fi-fi", "fil-ph", "fr-fr", "fr-ca", "ga-ie", "gd-gb", "gl-es", "gu-in", "ha-latn-ng", "he-il", "hi-in", "hr-hr", "hu-hu", "hy-am", "id-id", "ig-ng", "is-is", "it-it", "ja-jp", "ka-ge", "kk-kz", "km-kh", "kn-in", "ko-kr", "kok-in", "ku-arab-iq", "ky-kg", "lb-lu", "lo-la", "lt-lt", "lv-lv", "mi-nz", "mk-mk", "ml-in", "mn-mn", "mr-in", "ms-my", "mt-mt", "nb-no", "ne-np", "nl-nl", "nn-no", "nso-za", "or-in", "pa-in", "pa-arab-pk", "pl-pl", "prs-af", "pt-br", "pt-pt", "quc-latn-gt", "quz-pe", "ro-ro", "ru-ru", "rw-rw", "sd-arab-pk", "si-lk", "sk-sk", "sl-si", "sq-al", "sr-cyrl-ba", "sr-cyrl-rs", "sr-latn-rs", "sv-se", "sw-ke", "ta-in", "te-in", "tg-cyrl-tj", "th-th", "ti-et", "tk-tm", "tn-za", "tr-tr", "tt-ru", "ug-arab", "uk-ua", "ur-pk", "uz-latn-uz", "vi-vn", "wo-sn", "xh-za", "yo-ng", "zh-cn", "zh-tw", "zu-za"};
		public static string tgt_files = "";
		public static string src_files = "";
		
		
		//public struct DateTime : IComparable, IFormattable, IConvertible, ISerializable, IComparable<DateTime>, IEquatable<DateTime>
		
		
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
				
				
				for (int i=0; i<tgt_lcode_2.Length; i++)
				{
					if (chbx_MSA_AccountKC.Checked)
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_2[i] + "/MSA/AccountKC/");
					}
					
					
				}
				
				
				
				for (int i=0; i<tgt_lcode_4.Length; i++)
				{
					if (chbx_Atlanta.Checked)
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_4[i] + "/Atlanta/");
					}
					
					
				}
				
				for (int i=0; i<tgt_lcode_6.Length; i++)
				{
					if (chbx_PowerShell6.Checked)
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_6[i] + "/PowerShell/");
					}
					
					
				}
				
				for (int i=0; i<tgt_lcode_7.Length; i++)
				{
					if (chbx_PowerShell7.Checked)
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_7[i] + "/PowerShell/");
					}
					
					
				}
				
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
					
					if(chbx_ERM.Checked)
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AD-ERM/");
					}
					if (chbx_MSA_AppRegPortal.Checked) 
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/MSA/AppRegPortal/");
					}
					if (chbx_KeyVault.Checked) 
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/KeyVault/");
					}
					
				}
				
				for (int i=0; i<tgt_lcode_21.Length; i++) 
				{
					if (chbx_MSA_AccountXbox.Checked) 
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_21[i] + "/MSA/AccountXBox/");
					}
				}
				
				for (int i=0; i<tgt_lcode_33.Length; i++) 
				{
					if (chbx_PowerShell33.Checked) 
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_33[i] + "/PowerShell/AdminConfig");
					}
					if (chbx_MSODS33.Checked) 
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_33[i] + "/MSODS");
					}
				}
				
				for (int i=0; i<tgt_lcode_39.Length; i++) 
				{
					if (chbx_MSA_AuthAndroid.Checked)
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_39[i] + "/MSA/AuthenticatorAndroid/");
					}
				}
				
				for (int i=0; i<tgt_lcode_41.Length; i++) 
				{
					
					if (chbx_Adallom.Checked) 
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_41[i] + "/Adallom/");
					}
					
					
				}
				for (int i=0; i<tgt_lcode_43.Length; i++) 
				{
					
					if (chbx_ADRS.Checked) 
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_43[i] + "/ADRS/");
					}
					
					
				}
				
				for (int i=0; i<tgt_lcode_65.Length; i++)
				{
					if (chbx_MSA_AccountWPWiz.Checked)
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_65[i] + "/MSA/AccountWPWiz/");
					}
					
					
				}
				
				for (int i=0; i<tgt_lcode_107.Length; i++) 
				{
					
					
					
					
					if (chbx_SSPR.Checked) 
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_107[i] + "/SSPR/");
					}
				}
				
				for (int i=0; i<tgt_lcode_108.Length; i++) 
				{
					
					if (chbx_ESTS.Checked) 
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_108[i] + "/EvoSTS/");
					}
					
					if (chbx_IAMUX.Checked)
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_108[i] + "/IAMUX/");
					}
					
					if (chbx_MSA_Account.Checked)
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_108[i] + "/MSA/Account/");
					}
					
					if (chbx_MSA_Login.Checked)
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_108[i] + "/MSA/Login");
					}
					if (chbx_MSODS108.Checked)
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_108[i] + "/MSODS");
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
					if(chbx_ERM.Checked)
					{
						ERM();
					}
					if(chbx_Atlanta.Checked)
					{
						Atlanta();
					}
					if(chbx_Adallom.Checked)
					{
						Adallom();
					}
					if(chbx_ESTS.Checked)
					{
						ESTS();
					}
					if(chbx_MIM.Checked)
					{
						MIM();
					}
					if(chbx_IAMUX.Checked)
					{
						IAMUX();
					}
					if(chbx_MSA_AccountKC.Checked)
					{
						MSAAccountKC();
					}
					if(chbx_MSA_AccountWPWiz.Checked)
					{
						MSAAccountWPWiz();
					}
					if(chbx_MSA_AccountXbox.Checked)
					{
						MSAAccountXBox();
					}
					if(chbx_MSA_AppRegPortal.Checked)
					{
						MSAAppRegPortal();
					}
					if(chbx_MSA_AuthAndroid.Checked)
					{
						MSAAuthAndroid();
					}
					if(chbx_MSA_Account.Checked)
					{
						MSAAccount();
						
					}
					if(chbx_MSA_Login.Checked)
					{
						MSALogin();
						
					}
					if(chbx_SSPR.Checked)
					{
						SSPR();						
					}
					if(chbx_KeyVault.Checked)
					{
						KeyVault();						
					}
					
					if(chbx_PowerShell33.Checked)
					{
						PowerShell33();						
					}
					if(chbx_PowerShell7.Checked)
					{
						PowerShell6();
						PowerShell7();
					}
					if(chbx_MSODS33.Checked)
					{
						MSODS33();
					}
					if(chbx_MSODS108.Checked)
					{
						MSODS108();
					}
					if(chbx_ADRS.Checked)
					{
						ADRS();
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
						string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_16[i] + "/Billing/";		        	
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
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/BillingExt/";		        	
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
		
		public void ERM()
		{
			for (int i = 0; i < src_lcode2_17.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD-ERM\OnGoing\master\AccessReviewsExtension\lba\cs\AccessReviewsExtension\lcl\Client\
					string srcpath = src_files + @"/AD-ERM/OnGoing/master/AccessReviewsExtension/lba/"+ src_lcode2_17[i] + "/AccessReviewsExtension/lcl/Client/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AD-ERM/";		        	
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
		
		public void Atlanta()
		{
			for (int i = 0; i < src_lcode_4.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD-Atlanta\OnGoing\SLvso\Projects\AD_Atlanta\Localization\LCL\de-DE\LocProject\lcl\Tri\Microsoft.Tri.Common\Localization\
					string srcpath = src_files + @"/AD-Atlanta/OnGoing/SLvso/Projects/AD_Atlanta/Localization/LCL/"+ src_lcode_4[i] + "/LocProject/lcl/Tri/Microsoft.Tri.Common/Localization/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_4[i] + "/Atlanta/";		        	
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
		
		public void Adallom()
		{
			for (int i = 0; i < src_lcode_41.Length; i++) 
				{
					
					//c:\Eliseo\TRES\07\Adallom\LCL\bg-BG\LocProject\lcl\resources\en-US\
					string srcpath = src_files + @"/AD_Adallom/Ongoing/SLVso/Projects/AD_Adallom/Localization/LCL/"+ src_lcode_41[i] + "/LocProject/lcl/resources/en-US/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_41[i] + "/Adallom/";		        	
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
		
		public void ESTS()
		{
			for (int i = 0; i < src_lcode_108.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD-EvoSTS\OnGoing\SLVSO\Projects\ESTS\Localization\LCL\af-ZA\LocProject\lcl\private\Product\
					string srcpath = src_files + @"/AD-EvoSTS/OnGoing/SLVSO/Projects/ESTS/Localization/LCL/"+ src_lcode_108[i] + "/LocProject/lcl/private/Product/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_108[i] + "/EvoSTS/";		        	
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
		
		public void MIM()
		{
			for (int i = 0; i < src_lcode_35.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD_MIM\OnGoing\sd\sources\localization\lba\
					string srcpath = src_files + @"/AD_MIM/OnGoing/sd/sources/localization/lba/"+ src_lcode_35[i];
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_35[i] + "/MIM/";		        	
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
		
		public void IAMUX()
		{
			for (int i = 0; i < src_lcode_108.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD-IAM-Services-AADUX\Weekly\master\AzurePortalWebsite\lba\de\AzurePortalWebsite\lcl\
					string srcpath = src_files + @"/AD-IAM-Services-AADUX/Weekly/master/AzurePortalWebsite/lba/"+ src_lcode_108[i] + "/AzurePortalWebsite/lcl/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_108[i] + "/IAMUX/";		        	
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
		
		public void MSAAccountKC()
		{
			for (int i = 0; i < src_lcode_2.Length; i++) 
				{
					
					//cc:\Eliseo\TRES\AD-MSA-Loc\OnGoing\master\AccountKC\lba\es\AccountKC\lcl\
					string srcpath = src_files + @"/AD-MSA-Loc/OnGoing/master/AccountKC/lba/"+ src_lcode_2[i] + "/AccountKC/lcl/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_2[i] + "/MSA/AccountKC/";		        	
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
		
		//MSAAccountWPWiz
		public void MSAAccountWPWiz()
		{
			for (int i = 0; i < src_lcode_65.Length; i++) 
				{
					
					//ccEliseo\TRES\AD-MSA-Loc\OnGoing\master\AccountWPWiz\lba\af\AccountWPWiz\lcl\
					string srcpath = src_files + @"/AD-MSA-Loc/OnGoing/master/AccountWPWiz/lba/"+ src_lcode_65[i] + "/AccountWPWiz/lcl/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_65[i] + "/MSA/AccountWPWiz/";		        	
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
		
		public void MSAAccountXBox()
		{
			for (int i = 0; i < src_lcode_21.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD-MSA-Loc\OnGoing\master\AccountXBox\lba\da\AccountXBox\lcl\
					string srcpath = src_files + @"/AD-MSA-Loc/OnGoing/master/AccountXBox/lba/"+ src_lcode_21[i] + "/AccountXBox/lcl/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_21[i] + "/MSA/AccountXBox/";		        	
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
		
		public void MSAAppRegPortal()
		{
			for (int i = 0; i < src_lcode2_17.Length; i++) 
				{
					
					//cc:\Eliseo\TRES\AD-MSA-Loc\OnGoing\master\AppRegPortal\lba\cs\AppRegPortal\lcl\
					string srcpath = src_files + @"/AD-MSA-Loc/OnGoing/master/AppRegPortal/lba/"+ src_lcode2_17[i] + "/AppRegPortal/lcl/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/MSA/AppRegPortal/";		        	
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
		
		//MSAAuthAndroid
		public void MSAAuthAndroid()
		{
			for (int i = 0; i < src_lcode_39.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD-MSA-Loc\OnGoing\master\Authenticator_Android\lba\ar\Authenticator_Android\lcl\
					string srcpath = src_files + @"/AD-MSA-Loc/OnGoing/master/Authenticator_Android/lba/"+ src_lcode_39[i] + "/Authenticator_Android/lcl/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_39[i] + "/MSA/AuthenticatorAndroid/";		        	
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
		
		public void MSALogin()
		{
			for (int i = 0; i < src_lcode_108.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD-MSA-Loc\OnGoing\master\Login\lba\af\Login\lcl\
					string srcpath = src_files + @"/AD-MSA-Loc/OnGoing/master/Login/lba/"+ src_lcode_108[i] + "/Login/lcl/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_108[i] + "/MSA/Login/";		        	
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
		
		public void MSAAccount()
		{
			for (int i = 0; i < src_lcode_108.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD-MSA-Loc\OnGoing\master\Account\lba\af\Account\lcl\
					string srcpath = src_files + @"/AD-MSA-Loc/OnGoing/master/Account/lba/"+ src_lcode_108[i] + "/Account/lcl/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_108[i] + "/MSA/Account/";		        	
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
		
		public void SSPR()
		{
			for (int i = 0; i < src_lcode2_107.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD-IAM-Services-PasswordReset\Ongoing\master\OneTimePasswordService\lba\de\OneTimePasswordService\lcl\
					string srcpath = src_files + @"/AD-IAM-Services-PasswordReset/Ongoing/master/OneTimePasswordService/lba/"+ src_lcode2_107[i] + "/OneTimePasswordService/lcl/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_107[i] + "/SSPR/";		        	
					string fileName;
					string destFile;				
			        string[] files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
	            	
	            	//c:\Eliseo\TRES\AD-IAM-Services-PasswordReset\Ongoing\master\PortalWebRole\lba\af\PortalWebRole\lcl\
					srcpath = src_files + @"/AD-IAM-Services-PasswordReset/Ongoing/master/PortalWebRole/lba/"+ src_lcode2_107[i] + "/PortalWebRole/lcl/";
					tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_107[i] + "/SSPR/";		        	
					
					files = System.IO.Directory.GetFiles(srcpath, "*.*", SearchOption.AllDirectories);
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
		
		public void KeyVault()
		{
			for (int i = 0; i < src_lcode_17.Length; i++) 
				{
					
					//c:\Eliseo\TRES\KeyVault\OnGoing\develop\KeyVaultExtension\lba\cs\KeyVaultExtension\lcl\Client\
					string srcpath = src_files + @"/KeyVault/OnGoing/develop/KeyVaultExtension/lba/"+ src_lcode2_17[i] + "/KeyVaultExtension/lcl/Client/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/KeyVault/";		        	
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
		
		public void PowerShell33()
		{
			for (int i = 0; i < src_lcode_33.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD_PowerShell\OnGoing\develop\adminconfig\lba\bg\adminconfig\lcl\
					string srcpath = src_files + @"/AD_PowerShell/OnGoing/develop/adminconfig/lba/"+ src_lcode_33[i] + "/adminconfig/lcl/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_33[i] + "/PowerShell/AdminConfig";		        	
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
		
		public void PowerShell6()
		{
			for (int i = 0; i < src_lcode_6.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD_PowerShell\OnGoing\develop\AzureAD.PowerShell.AutoGen\lba\de\AzureAD.PowerShell.AutoGen\lcl\
					string srcpath = src_files + @"/AD_PowerShell/OnGoing/develop/AzureAD16.PowerShell.AutoGen/lba/"+ src_lcode_6[i] + "/AzureAD16.PowerShell.AutoGen/lcl/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_6[i] + "/PowerShell/";		        	
					string fileName;
					string destFile;				
			        string[] files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
	            	
	            	//c:\Eliseo\TRES\AD_PowerShell\OnGoing\develop\AzureAD16.PowerShell.AutoGen\lba\es\AzureAD16.PowerShell.AutoGen\lcl\
					
				}
		}
		
		public void PowerShell7()
		{
			for (int i = 0; i < src_lcode_7.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD_PowerShell\OnGoing\develop\AzureAD.PowerShell.AutoGen\lba\de\AzureAD.PowerShell.AutoGen\lcl\
					string srcpath = src_files + @"/AD_PowerShell/OnGoing/develop/AzureAD.PowerShell.AutoGen/lba/"+ src_lcode_7[i] + "/AzureAD.PowerShell.AutoGen/lcl/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_7[i] + "/PowerShell/";		        	
					string fileName;
					string destFile;				
			        string[] files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
	            	
	            	
	            	
	            	//c:\Eliseo\TRES\AD_PowerShell\OnGoing\develop\AzureAD16.PowerShell.Custom\lba\de\AzureAD16.PowerShell.Custom\lcl\
	            	srcpath = src_files + @"/AD_PowerShell/OnGoing/develop/AzureAD16.PowerShell.Custom/lba/"+ src_lcode_7[i] + "/AzureAD16.PowerShell.Custom/lcl/";
					tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_7[i] + "/PowerShell/";		        	
					
									
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
	            	
	            	//c:\Eliseo\TRES\AD_PowerShell\OnGoing\develop\CommonLibrary\lba\de\CommonLibrary\lcl\
	            	srcpath = src_files + @"/AD_PowerShell/OnGoing/develop/CommonLibrary/lba/"+ src_lcode_7[i] + "/CommonLibrary/lcl/";
					tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_7[i] + "/PowerShell/";		        	
					
									
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
	            	
	            	//c:\Eliseo\TRES\AD_PowerShell\OnGoing\develop\commonLibrary_resources\lba\de\commonLibrary_resources\lcl\
	            	srcpath = src_files + @"/AD_PowerShell/OnGoing/develop/commonLibrary_resources/lba/"+ src_lcode_7[i] + "/commonLibrary_resources/lcl/";
					tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_7[i] + "/PowerShell/";		        	
					
									
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
	            	
	            	//c:\Eliseo\TRES\AD_PowerShell\OnGoing\develop\MSGraph.PowerShell.AutoGen\lba\de\MSGraph.PowerShell.AutoGen\lcl\
	            	srcpath = src_files + @"/AD_PowerShell/OnGoing/develop/MSGraph.PowerShell.AutoGen/lba/"+ src_lcode_7[i] + "/MSGraph.PowerShell.AutoGen/lcl/";
					tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_7[i] + "/PowerShell/";		        	
					
									
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
	            	
	            	//c:\Eliseo\TRES\AD_PowerShell\OnGoing\develop\MSGraphBeta.PowerShell.AutoGen\lba\de\MSGraphBeta.PowerShell.AutoGen\lcl\
	            	srcpath = src_files + @"/AD_PowerShell/OnGoing/develop/MSGraphBeta.PowerShell.AutoGen/lba/"+ src_lcode_7[i] + "/MSGraphBeta.PowerShell.AutoGen/lcl/";
					tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_7[i] + "/PowerShell/";		        	
					
									
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
	            	
	            	//c:\Eliseo\TRES\AD_PowerShell\OnGoing\develop\psmodule\lba\de\psmodule\lcl\
	            	srcpath = src_files + @"/AD_PowerShell/OnGoing/develop/psmodule/lba/"+ src_lcode_7[i] + "/psmodule/lcl/";
					tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_7[i] + "/PowerShell/";		        	
									
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
	            	
	            	//c:\Eliseo\TRES\AD_PowerShell\OnGoing\develop\psmodule_resources\lba\de\psmodule_resources\lcl\
	            	srcpath = src_files + @"/AD_PowerShell/OnGoing/develop/psmodule_resources/lba/"+ src_lcode_7[i] + "/psmodule_resources/lcl/";
					tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_7[i] + "/PowerShell/";		        	
									
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
	            	
	            	//c:\Eliseo\TRES\AD_PowerShell\OnGoing\develop\PSSnapin\lba\de\PSSnapin\lcl\
	            	srcpath = src_files + @"/AD_PowerShell/OnGoing/develop/PSSnapin/lba/"+ src_lcode_7[i] + "/PSSnapin/lcl/";
					tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_7[i] + "/PowerShell/";		        	
									
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
	            	
	            	//c:\Eliseo\TRES\AD_PowerShell\OnGoing\develop\pssnapin_resources\lba\de\pssnapin_resources\lcl\
	            	srcpath = src_files + @"/AD_PowerShell/OnGoing/develop/pssnapin_resources/lba/"+ src_lcode_7[i] + "/pssnapin_resources/lcl/";
					tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_7[i] + "/PowerShell/";		        	
									
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
				}
		}
		
		public void MSODS33()
		{
			for (int i = 0; i < src_lcode_33.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD-MSODS-Core\OnGoing\master\awslibrary\lba\bg\awslibrary\lcl\
					string srcpath = src_files + @"/AD-MSODS-Core/OnGoing/master/awslibrary/lba/"+ src_lcode_33[i] + "/awslibrary/lcl/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_33[i] + "/MSODS/";		        	
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
		public void MSODS108()
		{
			for (int i = 0; i < src_lcode_108.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD-MSODS-Core\OnGoing\master\AppPermissionContent\lba\af\AppPermissionContent\lcl\
					string srcpath = src_files + @"/AD-MSODS-Core/OnGoing/master/AppPermissionContent/lba/"+ src_lcode_108[i] + "/AppPermissionContent/lcl/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_108[i] + "/MSODS/";		        	
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
		public void ADRS()
		{
			for (int i = 0; i < src_lcode_43.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD-DRS-ADRS\DeviceRegistration\Lba\AR-SA\DeviceRegistration\lcl\
					string srcpath = src_files + @"/AD-DRS-ADRS/DeviceRegistration/Lba/"+ src_lcode_43[i] + "/DeviceRegistration/lcl/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_43[i] + "/ADRS/";		        	
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
		void ADLoad(object sender, EventArgs e)
		{
			string yearmonth;
			DateTime date1 = DateTime.Now;
			if(date1.Month >= 9)
			{
				yearmonth = date1.Year.ToString() + date1.Month.ToString();
				mtb_yearmonth.Text = yearmonth;
			} 
			else
			{
				yearmonth = date1.Year.ToString() + "0" + date1.Month.ToString();
				mtb_yearmonth.Text = yearmonth;
			}
			
			
		}
	
		}
	}

