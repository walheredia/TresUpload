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
using System.Threading;

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
		string[] tgt_lcode_39 = {"ar-sa", "bg-bg", "ca-es", "cs-cz", "da-dk", "de-de", "el-gr", "en-gb", "es-es", "fi-FI", "fil-ph", "fr-fr", "he-il", "hi-in", "hr-hr", "hu-hu", "id-id", "it-it", "ja-jp", "ko-kr", "lt-lt", "lv-lv", "nb-no", "nl-nl", "pl-pl", "pt-br", "pt-pt", "ro-ro", "ru-ru", "sk-sk", "sl-si", "sr-cyrl-rs", "sv-se", "sr-latn-rs", "th-th", "tr-tr", "uk-ua", "zh-cn", "zh-tw"};
		string[] src_lcode_41 = {"bg-BG", "ca-ES", "cs-CZ", "da-DK", "de-DE", "el-GR", "es-ES", "et-EE", "eu-ES", "fi-FI", "fr-FR", "gl-ES", "hi-IN", "hr-HR", "hu-HU", "id-ID", "it-IT", "ja-JP", "kk-KZ", "ko-KR", "lt-LT", "lv-LV", "ms-MY", "nb-NO", "nl-NL", "pl-PL", "pt-BR", "pt-PT", "ro-RO", "ru-RU", "sk-SK", "sl-SI", "sr-Cyrl-RS", "sr-Latn-RS", "sv-SE", "th-TH", "tr-TR", "uk-UA", "vi-VN", "zh-Hans", "zh-Hant"};
		string[] tgt_lcode_41 = {"bg-BG", "ca-ES", "cs-CZ", "da-DK", "de-DE", "el-GR", "es-ES", "et-EE", "eu-ES", "fi-FI", "fr-FR", "gl-ES", "hi-IN", "hr-HR", "hu-HU", "id-ID", "it-IT", "ja-JP", "kk-KZ", "ko-KR", "lt-LT", "lv-LV", "ms-MY", "nb-NO", "nl-NL", "pl-PL", "pt-BR", "pt-PT", "ro-RO", "ru-RU", "sk-SK", "sl-SI", "sr-Cyrl-RS", "sr-Latn-RS", "sv-SE", "th-TH", "tr-TR", "uk-UA", "vi-VN", "zh-CN", "zh-TW"};
		//"AR-SA", "BG", "CA", "CS", "DA", "DE", "EL", "ES", "ET", "EU", "FI", "FR", "GL", "HE", "HI", "HR", "HU", "ID", "IT", "JA", "KK", "KO", "LT", "LV", "MS", "NL", "NO", "PL", "PT", "PT-BR", "RO", "RU", "SK", "SL", "SR-CYRL-CS", "SR-LATN-CS", "SV", "TH", "TR", "UK", "VI", "ZH-HANS", "ZH-HANT"
		//"ar-sa", "bg-BG", "ca-ES", "cs-CZ", "da-DK", "de-DE", "el-GR", "es-ES", "et-EE", "fi-FI", "fr-FR", "gl-ES", "he-IL", "hi-IN", "hr-HR", "hu-HU", "id-ID", "it-IT", "ja-jp", "kk-KZ", "ko-KR", "lt-LT", "lv-LV", "ms-MY", "nb-NO", "nl-NL", "pl-PL", "pt-br", "pt-PT", "ro-RO", "ru-RU", "sk-SK", "sl-SI", "sr-cyrl-RS", "sr-latn-RS", "sv-SE"
		string[] src_lcode_43 = {"AR-SA", "BG", "CA", "CS", "DA", "DE", "EL", "ES", "ET", "EU", "FI", "FR", "GL", "HE", "HI", "HR", "HU", "ID", "IT", "JA", "KK", "KO", "LT", "LV", "MS", "NL", "NO", "PL", "PT", "PT-BR", "RO", "RU", "SK", "SL", "SR-CYRL-RS", "SR-LATN-RS", "SV", "TH", "TR", "UK", "VI", "ZH-HANS", "ZH-HANT"};
		string[] src_lcode2_43 = {"ar-sa", "bg-BG", "ca-ES", "cs-CZ", "da-DK", "de-DE", "el-GR", "es-ES", "et-EE", "fi-FI", "fr-FR", "gl-ES", "he-IL", "hi-IN", "hr-HR", "hu-HU", "id-ID", "it-IT", "ja-jp", "kk-KZ", "ko-KR", "lt-LT", "lv-LV", "ms-MY", "nb-NO", "nl-NL", "pl-PL", "pt-br", "pt-PT", "ro-RO", "ru-RU", "sk-SK", "sl-SI", "sr-cyrl-RS", "sr-latn-RS", "sv-SE","th-TH", "tr-TR", "uk-UA", "vi-VN", "zh-CN", "zh-TW"};
		string[] tgt_lcode_43 = {"ar-sa", "bg-BG", "ca-ES", "cs-CZ", "da-DK", "de-DE", "el-GR", "es-ES", "et-EE", "fi-FI", "fr-FR", "gl-ES", "he-IL", "hi-IN", "hr-HR", "hu-HU", "id-ID", "it-IT", "ja-jp", "kk-KZ", "ko-KR", "lt-LT", "lv-LV", "ms-MY", "nb-NO", "nl-NL", "pl-PL", "pt-br", "pt-PT", "ro-RO", "ru-RU", "sk-SK", "sl-SI", "sr-cyrl-RS", "sr-latn-RS", "sv-SE","th-TH", "tr-TR", "uk-UA", "vi-VN", "zh-CN", "zh-TW"};
		string[] src_lcode_61 = {"af", "am-et", "ar", "az-latn-az", "be", "bg", "bn-bd", "ca", "cs", "da", "de", "el", "es", "et", "eu", "fa", "fi", "fil-ph", "fr", "gl", "ha-latn-ng", "he", "hi", "hr", "hu", "id", "is", "it", "ja", "kk", "km-kh", "kn", "ko", "lo", "lt", "lv", "mk", "ml", "ms", "nb-NO", "nl", "pl", "pt-BR", "pt-PT", "ro", "ru", "sk", "sl", "sq", "sr-Latn-RS", "sv", "sw", "ta", "te", "th", "tr", "uk", "uz-latn-uz", "vi", "zh-HANS", "zh-HANT"};
		string[] tgt_lcode_61 = {"af-za", "am-et", "ar-sa", "az-latn-az", "be-by", "bg-bg", "bn-bd", "ca-es", "cs-cz", "da-dk", "de-de", "el-gr", "es-es", "et-ee", "eu-es", "fa-ir", "fi-fi", "fil-ph", "fr-fr", "gl-es", "ha-latn-ng", "he-il", "hi-in", "hr-hr", "hu-hu", "id-id", "is-is", "it-it", "ja-jp", "kk-kz", "km-kh", "kn-in", "ko-kr", "lo-la", "lt-lt", "lv-lv", "mk-mk", "ml-in", "ms-my", "nb-NO", "nl-nl", "pl-pl", "pt-BR", "pt-PT", "ro-ro", "ru-ru", "sk-sk", "sl-si", "sq-al", "sr-Latn-RS", "sv-se", "sw-ke", "ta-in", "te-in", "th-th", "tr-tr", "uk-ua", "uz-latn-uz", "vi-vn", "zh-cn", "zh-tw"};
		string[] src_lcode_65 = {"af", "am-ET", "ar", "az-latn-az", "be", "bg", "bn-IN", "ca", "cs", "da", "de", "el", "en-gb", "es", "es-mx", "et", "eu", "fa", "fi", "fil-ph", "fr", "fr-ca", "gl", "ha-latn-ng", "he", "hi", "hr", "hu", "id", "is", "it", "ja", "kk", "km-kh", "kn", "ko", "lo", "lt", "lv", "mk", "ml", "ms", "nb-no", "nl", "pl", "pt-br", "pt-pt", "ro", "ru", "sk", "sl", "sq", "sr-cyrl-rs", "sr-latn", "sv", "sw", "ta", "te", "th", "tr", "uk", "uz-latn-uz", "vi", "zh-hans", "zh-hant"};
		string[] tgt_lcode_65 = {"af-za", "am-et", "ar-sa", "az-latn-az", "be-by", "bg-bg", "bn-in", "ca-es", "cs-cz", "da-dk", "de-de", "el-gr", "en-gb", "es-es", "es-mx", "et-ee", "eu-es", "fa-ir", "fi-fi", "fil-ph", "fr-fr", "fr-ca", "gl-es", "ha-latn-ng", "he-il", "hi-in", "hr-hr", "hu-hu", "id-id", "is-is", "it-it", "ja-jp", "kk-kz", "km-kh", "kn-in", "ko-kr", "lo-la", "lt-lt", "lv-lv", "mk-mk", "ml-in", "ms-my", "nb-no", "nl-nl", "pl-pl", "pt-br", "pt-pt", "ro-ro", "ru-ru", "sk-sk", "sl-si", "sq-al", "sr-cyrl-rs", "sr-latn-rs", "sv-se", "sw-ke", "ta-in", "te-in", "th-th", "tr-tr", "uk-ua", "uz-latn-uz", "vi-vn", "zh-cn", "zh-tw"};
		string[] src_lcode_107 = {"af-ZA", "am-ET", "ar-SA", "as-IN", "az-latn-AZ", "be-BY", "bg-BG", "bn-BD", "bn-IN", "bs-Latn-BA", "ca-es", "ca-ES-valencia", "cs-CZ", "cy-gb", "da-DK", "de-DE", "el-GR", "en-GB", "es-ES", "es-MX", "et-EE", "eu-es", "fa-IR", "fi-FI", "fil-PH", "fr-CA", "fr-FR", "ga-IE", "gd-GB", "gl-ES", "gu-in", "ha-latn-NG", "he-IL", "hi-in", "hr-HR", "hu-HU", "hy-AM", "id-id", "ig-NG", "is-IS", "it-IT", "ja-JP", "ka-GE", "kk-KZ", "km-KH", "kn-IN", "kok-IN", "ko-KR", "ku-ARAB-IQ", "ky-KG", "lb-LU", "lo-LA", "lt-LT", "lv-LV", "mi-NZ", "mk-MK", "ml-IN", "mn-MN", "mr-in", "ms-my", "mt-MT", "nb-NO", "ne-NP", "nl-NL", "nn-NO", "nso-ZA", "or-IN", "pa-Arab-PK", "pa-IN", "pl-PL", "prs-AF", "pt-br", "pt-PT", "quz-PE", "ro-RO", "ru-RU", "rw-RW", "sd-Arab-PK", "si-LK", "sk-SK", "sl-SI", "sq-AL", "sr-Cyrl-BA", "sr-cyrl-RS", "sr-latn-RS", "sv-SE", "sw-KE", "ta-IN", "te-IN", "tg-Cyrl-TJ", "th-TH", "ti-ET", "tk-TM", "tn-ZA", "tr-TR", "tt-RU", "ug-CN", "uk-UA", "ur-PK", "uz-latn-UZ", "vi-vn", "wo-SN", "xh-ZA", "yo-NG", "zh-cn", "zh-tw", "zu-ZA"};
		string[] src_lcode2_107 = {"af", "am", "ar-SA", "as", "az", "be", "bg", "bn", "bn-IN", "bs", "ca", "ca-ES-valencia", "cs", "cy", "da", "de", "el", "en-GB", "es", "es-MX", "et", "eu", "fa", "fi", "fil", "fr", "fr-CA", "ga", "gd", "gl", "gu", "ha", "he", "hi", "hr", "hu", "hy", "id", "ig", "is", "it", "ja", "ka", "kk", "km", "kn","ko", "kok", "ku-Arab", "ky", "lb", "lo", "lt", "lv", "mi", "mk", "ml", "mn", "mr", "ms", "mt", "ne", "nl", "nn-NO", "no", "nso", "or", "pa-Arab-PK", "pa-IN", "pl", "prs", "pt", "pt-BR", "quz", "ro", "ru", "rw", "sd", "si", "sk", "sl", "sq", "sr-cyrl-BA", "sr-cyrl-CS", "sr-Latn-CS", "sv", "sw", "ta", "te", "tg", "th", "ti", "tk", "tn", "tr", "tt", "ug", "uk", "ur", "uz", "vi", "wo", "xh", "yo", "zh-HANS", "zh-HANT", "zu"};
		string[] tgt_lcode_107 = {"af-ZA", "am-ET", "ar-SA", "as-IN", "az-latn-AZ", "be-BY", "bg-BG", "bn-BD", "bn-IN", "bs-Latn-BA", "ca-es", "ca-ES-valencia", "cs-CZ", "cy-gb", "da-DK", "de-DE", "el-GR", "en-GB", "es-ES", "es-MX", "et-EE", "eu-es", "fa-IR", "fi-FI", "fil-PH", "fr-FR", "fr-CA", "ga-IE", "gd-GB", "gl-ES", "gu-in", "ha-latn-NG", "he-IL", "hi-in", "hr-HR", "hu-HU", "hy-AM", "id-id", "ig-NG", "is-IS", "it-IT", "ja-JP", "ka-GE", "kk-KZ", "km-KH", "kn-IN", "ko-KR", "kok-IN", "ku-ARAB-IQ", "ky-KG", "lb-LU", "lo-LA", "lt-LT", "lv-LV", "mi-NZ", "mk-MK", "ml-IN", "mn-MN", "mr-in", "ms-my", "mt-MT", "ne-NP", "nl-NL", "nn-NO", "nb-NO", "nso-ZA", "or-IN", "pa-Arab-PK", "pa-IN", "pl-PL", "prs-AF", "pt-PT", "pt-br", "quz-PE", "ro-RO", "ru-RU", "rw-RW", "sd-Arab-PK", "si-LK", "sk-SK", "sl-SI", "sq-AL", "sr-Cyrl-BA", "sr-cyrl-RS", "sr-latn-RS", "sv-SE", "sw-KE", "ta-IN", "te-IN", "tg-Cyrl-TJ", "th-TH", "ti-ET", "tk-TM", "tn-ZA", "tr-TR", "tt-RU", "ug-CN", "uk-UA", "ur-PK", "uz-latn-UZ", "vi-vn", "wo-SN", "xh-ZA", "yo-NG", "zh-cn", "zh-tw", "zu-ZA"};
		
		string[] src_lcode_108 = {"af", "am-et", "ar", "as-in", "az-latn-az", "be", "bg", "bn-bd", "bn-IN", "bs-latn-ba", "ca", "ca-es-valencia", "cs", "cy-gb", "da", "de", "el", "en-gb", "es", "es-mx", "et", "eu", "fa", "fi", "fil-ph", "fr", "fr-ca", "ga-ie", "gd", "gl", "gu", "ha-latn-ng", "he", "hi", "hr", "hu", "hy", "id", "ig-ng", "is", "it", "ja", "ka", "kk", "km-kh", "kn", "ko", "kok", "ku-arab", "ky", "lb-lu", "lo", "lt", "lv", "mi-nz", "mk", "ml", "mn", "mr", "ms", "mt-mt", "ne-np", "nl", "nn-NO", "nb-no", "nso-za", "or-in", "pa-arab", "pa", "pl", "prs-af", "pt-pt", "pt-br", "quc", "quz-pe", "ro", "ru", "rw", "sd-arab", "si-lk", "sk", "sl", "sq", "sr-cyrl-ba", "sr-cyrl-rs", "sr-latn", "sv", "sw", "ta", "te", "tg-cyrl", "th", "ti", "tk-tm", "tn-za", "tr", "tt", "ug-arab", "uk", "ur", "uz-latn-uz", "vi", "wo", "xh-za", "yo-ng", "zh-hans", "zh-hant", "zu-za"};
		string[] tgt_lcode_108 = {"af-za", "am-et", "ar-sa", "as-in", "az-latn-az", "be-by", "bg-bg", "bn-bd", "bn-in", "bs-latn-ba", "ca-es", "ca-es-valencia", "cs-cz", "cy-gb", "da-dk", "de-de", "el-gr", "en-gb", "es-es", "es-mx", "et-ee", "eu-es", "fa-ir", "fi-fi", "fil-ph", "fr-fr", "fr-ca", "ga-ie", "gd-gb", "gl-es", "gu-in", "ha-latn-ng", "he-il", "hi-in", "hr-hr", "hu-hu", "hy-am", "id-id", "ig-ng", "is-is", "it-it", "ja-jp", "ka-ge", "kk-kz", "km-kh", "kn-in", "ko-kr", "kok-in", "ku-arab-iq", "ky-kg", "lb-lu", "lo-la", "lt-lt", "lv-lv", "mi-nz", "mk-mk", "ml-in", "mn-mn", "mr-in", "ms-my", "mt-mt", "ne-np", "nl-nl", "nn-no", "nb-no", "nso-za", "or-in", "pa-arab-pk", "pa-in", "pl-pl", "prs-af", "pt-pt", "pt-br", "quc-latn-gt", "quz-pe", "ro-ro", "ru-ru", "rw-rw", "sd-arab-pk", "si-lk", "sk-sk", "sl-si", "sq-al", "sr-cyrl-ba", "sr-cyrl-rs", "sr-latn-rs", "sv-se", "sw-ke", "ta-in", "te-in", "tg-cyrl-tj", "th-th", "ti-et", "tk-tm", "tn-za", "tr-tr", "tt-ru", "ug-CN", "uk-ua", "ur-pk", "uz-latn-uz", "vi-vn", "wo-sn", "xh-za", "yo-ng", "zh-cn", "zh-tw", "zu-za"};
		
		string[] src_lcode2_108 = {"af", "am", "ar-SA", "as", "az", "be", "bg", "bn", "bn-IN", "bs", "ca", "ca-es-valencia", "cs", "cy", "da", "de", "el", "en-gb", "es", "es-mx", "et", "eu", "fa", "fi", "fil", "fr", "fr-ca", "ga", "gd", "gl", "gu", "ha", "he", "hi", "hr", "hu", "hy", "id", "ig", "is", "it", "ja", "ka", "kk", "km", "kn", "ko", "kok", "ku-arab", "ky", "lb", "lo", "lt", "lv", "mi", "mk", "ml", "mn", "mr", "ms", "mt", "ne", "nl", "nn-NO", "no", "nso", "or", "pa-arab-pk", "pa-IN", "pl", "prs", "pt", "pt-br", "quc", "quz", "ro", "ru", "rw", "sd", "si", "sk", "sl", "sq", "sr-cyrl-ba", "sr-cyrl-rs", "sr-latn-RS", "sv", "sw", "ta", "te", "tg", "th", "ti", "tk", "tn", "tr", "tt", "ug", "uk", "ur", "uz", "vi", "wo", "xh", "yo", "zh-hans", "zh-hant", "zu"};
		
		int total = 0;
		
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
			disable();
			listView1.Items.Clear();
			fbd_createStructure.SelectedPath = "C:/Eliseo/TRES/Upload";
			//MessageBox.Show(fbd_createStructure.SelectedPath.ToString());
			pbr_structure.Maximum = 20;//tgt_lcode_2.Length + tgt_lcode_4.Length + tgt_lcode_6.Length + tgt_lcode_7.Length + tgt_lcode_16.Length + tgt_lcode_17.Length + tgt_lcode_21.Length + tgt_lcode_33.Length + tgt_lcode_35.Length + tgt_lcode_39.Length + tgt_lcode_41.Length + tgt_lcode_43.Length + tgt_lcode_61.Length + tgt_lcode_65.Length + tgt_lcode_107.Length + tgt_lcode_108.Length ;
			pbr_structure.Value = 0;
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
					pbr_structure.Value = pb_structure.Value + 1;
					
				}
				
				
				
				for (int i=0; i<tgt_lcode_4.Length; i++)
				{
					if (chbx_Atlanta.Checked)
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_4[i] + "/Atlanta/");
					}
					pbr_structure.Value = pb_structure.Value + 1;
					
				}
				
				for (int i=0; i<tgt_lcode_6.Length; i++)
				{
					if (chbx_PowerShell6.Checked)
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_6[i] + "/PowerShell/");
					}
					pbr_structure.Value = pb_structure.Value + 1;
					
				}
				
				for (int i=0; i<tgt_lcode_7.Length; i++)
				{
					if (chbx_PowerShell7.Checked)
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_7[i] + "/PowerShell/");
					}
					pbr_structure.Value = pb_structure.Value + 1;
					
				}
				
				for (int i=0; i<tgt_lcode_16.Length; i++)
				{
					if (chkbx_ADBilling.Checked) 
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_16[i] + "/Billing/");
					}
					pbr_structure.Value = pb_structure.Value + 1;
					
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
					pbr_structure.Value = pb_structure.Value + 1;
				}
				
				for (int i=0; i<tgt_lcode_21.Length; i++) 
				{
					if (chbx_MSA_AccountXbox.Checked) 
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_21[i] + "/MSA/AccountXBox/");
					}
					pbr_structure.Value = pb_structure.Value + 1;
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
					pbr_structure.Value = pb_structure.Value + 1;
				}
				
				for (int i=0; i<tgt_lcode_39.Length; i++) 
				{
					if (chbx_MSA_AuthAndroid.Checked)
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_39[i] + "/MSA/AuthenticatorAndroid/");
					}
					pbr_structure.Value = pb_structure.Value + 1;
				}
				
				for (int i=0; i<tgt_lcode_41.Length; i++) 
				{
					
					if (chbx_Adallom.Checked) 
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_41[i] + "/Adallom/");
					}
					pbr_structure.Value = pb_structure.Value + 1;
					
					
				}
				for (int i=0; i<tgt_lcode_43.Length; i++) 
				{
					
					if (chbx_ADRS.Checked) 
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_43[i] + "/ADRS/");
					}
					if(chbx_MFA.Checked)
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_43[i] + "/MFA/");
					}
					if(chbx_MFAAndroid.Checked)
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_43[i] + "/MFAPhoneAppAndroid/");
					}
					//MFAPhoneAppiPhone
					if(chbx_MFAiPhone.Checked)
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_43[i] + "/MFAPhoneAppiPhone/");
					}
					pbr_structure.Value = pb_structure.Value + 1;
					
				}
				
				for (int i=0; i<tgt_lcode_61.Length; i++) 
				{
					
					
					if (chbx_MFAWinPhone.Checked) 
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_61[i] + "/MFAPhoneAppWinPhone/");
					}
					pbr_structure.Value = pb_structure.Value + 1;
				}
				
				for (int i=0; i<tgt_lcode_65.Length; i++)
				{
					if (chbx_MSA_AccountWPWiz.Checked)
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_65[i] + "/MSA/AccountWPWiz/");
					}
					pbr_structure.Value = pb_structure.Value + 1;
					
				}
				
				for (int i=0; i<tgt_lcode_107.Length; i++) 
				{
					
					if (chbx_SSPR.Checked) 
					{
						Directory.CreateDirectory("ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_107[i] + "/SSPR/");
					}
					pbr_structure.Value = pb_structure.Value + 1;
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
					pbr_structure.Value = pb_structure.Value + 1;
				}
				
			}
			enable();
			
		}
		void Btn_copyfilesClick(object sender, EventArgs e)
		{
			int contador = 0;
			foreach (Control c in this.GrBox_Select_Components.Controls) {
                if(c is CheckBox) {
                    CheckBox chk;
                    chk = (CheckBox)c;
                    if (chk.Checked == true) {
                    	contador = contador + 1;
                    }                    
                }
            }
			total = contador;
			pbr_CopyFiles.Maximum = contador;
			pbr_CopyFiles.Value = 0;			
			
			//Creando Delegado
			ThreadStart delegado = new ThreadStart(RunProcess);
			//Creando instancia del hilo
		
			Thread hilo = new Thread(delegado);
			hilo.SetApartmentState(ApartmentState.STA);
			//Se inicia el hilo
			hilo.Start();
			
		}
		
		private void RunProcess()
		{
			int flag = 0;
			fbd_copyfiles.SelectedPath="C:/Eliseo/TRES/";
			fbd_copyfiles.Description="Please select the directory of the Source Files (Enlistment from SDW)";
			
			if (fbd_copyfiles.ShowDialog() == DialogResult.OK)
			{
				src_files = fbd_copyfiles.SelectedPath.ToString();
				
				
				try 
				{
					if(chkbx_ADBilling.Checked)
					{
						
						lbl_component.Text = "AD Billing";
						ADBilling();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";						
					}
					if(chbx_PIM.Checked)
					{
						
						lbl_component.Text = "PIM";
						PIM();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					if(chbx_ADBillingExtension.Checked)
					{
						
						lbl_component.Text = "AD Billing Extension";
						ADBillingEx();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					if(chbx_ADConnect.Checked)
					{
						
						lbl_component.Text = "AAD Connect";
						AADConnect();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					if(chbx_ADConnectHealth.Checked)
					{
						
						lbl_component.Text = "AAD Connect Health";
						AADConnectHealth();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					if(chbx_Rome.Checked)
					{
						
						lbl_component.Text = "Rome";
						Rome();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					if(chbx_ERM.Checked)
					{
						
						lbl_component.Text = "ERM";
						ERM();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					if(chbx_Atlanta.Checked)
					{
						
						lbl_component.Text = "Atlanta";
						Atlanta();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					if(chbx_Adallom.Checked)
					{
						
						lbl_component.Text = "Adallom";
						Adallom();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					if(chbx_ESTS.Checked)
					{
						
						lbl_component.Text = "ESTS";
						ESTS();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					if(chbx_MIM.Checked)
					{
						
						lbl_component.Text = "MIM";
						MIM();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					if(chbx_IAMUX.Checked)
					{
						
						lbl_component.Text = "IAMUX";
						IAMUX();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					if(chbx_MSA_AccountKC.Checked)
					{
						
						lbl_component.Text = "MSA Account KC";
						MSAAccountKC();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					if(chbx_MSA_AccountWPWiz.Checked)
					{
						
						lbl_component.Text = "MSA Account WPWiz";
						MSAAccountWPWiz();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					if(chbx_MSA_AccountXbox.Checked)
					{
						
						lbl_component.Text = "MSA Accoutn XBOX";
						MSAAccountXBox();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					if(chbx_MSA_AppRegPortal.Checked)
					{
						
						lbl_component.Text = "MSA App Reg Portal";
						MSAAppRegPortal();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					if(chbx_MSA_AuthAndroid.Checked)
					{
						
						lbl_component.Text = "MSA Authenticator Androi";
						MSAAuthAndroid();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					if(chbx_MSA_Account.Checked)
					{
						
						lbl_component.Text = "MSA Account";
						MSAAccount();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
						
					}
					if(chbx_MSA_Login.Checked)
					{
						
						lbl_component.Text = "MSA Login";
						MSALogin();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
						
					}
					if(chbx_SSPR.Checked)
					{
						
						lbl_component.Text = "SSPR";
						SSPR();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";						
					}
					if(chbx_KeyVault.Checked)
					{
						
						lbl_component.Text = "Key Vault";
						KeyVault();	
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";						
					}
					
					if(chbx_PowerShell33.Checked)
					{
						
						lbl_component.Text = "PowerShell 33";
						PowerShell33();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";						
					}
					if(chbx_PowerShell7.Checked)
					{
						
						lbl_component.Text = "PowerShell 7";
						PowerShell6();
						PowerShell7();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					if(chbx_MSODS33.Checked)
					{
						
						lbl_component.Text = "MSODS 33";
						MSODS33();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					if(chbx_MSODS108.Checked)
					{
						
						lbl_component.Text = "MSODS";
						MSODS108();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					if(chbx_ADRS.Checked)
					{	
						lbl_component.Text = "ADRS";
						ADRS();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					/*if(chbx_MFA.Checked)
					{
						MFA();
					}*/
					if(chbx_MFAAndroid.Checked)
					{
						
						lbl_component.Text = "MFA Authenticator Android";
						MFAAndroid();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					if(chbx_MFAiPhone.Checked)
					{
						
						lbl_component.Text = "MFA Authenticator iPhone";
						MFAiPhone();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					if(chbx_MFAWinPhone.Checked)
					{
						
						lbl_component.Text = "MFA Authenticator WinPhone";
						MFAWinPhone();
						pbr_CopyFiles.Value = pbr_CopyFiles.Value + 1;
						flag = flag + 1;
						bar.Text = flag.ToString() + "/" + total.ToString() + " Processed components";
					}
					MessageBox.Show("Succesfully Done!");
					
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
					throw;
				}
				
				pbr_CopyFiles.Value = 0;
				lbl_component.Text = "...";
				lbl_file.Text = "...";
				bar.Text = "*/* Components";
				
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
		                	lbl_file.Text = fileName;
		            	}
			       
				}
			
			listView1.Items.Add("AD Billing - Success - (2 lcl files per locate, 32 in total)");
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
	                	lbl_file.Text = fileName;
	            	}
					
					//c:\Eliseo\TRES\AD-BillingExt\OnGoing\stage\BillingExtension\lba\cs\BillingExtension\lcl\Client\
			        srcpath = src_files + @"/AD-BillingExt/Ongoing/stage/BillingExtension/lba/"+ src_lcode2_17[i] + "/BillingExtension/lcl/Client/";
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	                	lbl_file.Text = fileName;
	            	}
				}
			listView1.Items.Add("AD Billing Extension - Success - (X lcl files per locate, X in total)");
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
	                		lbl_file.Text = fileName;
	            		}
					
					//c:\Eliseo\TRES\AD-PIM\OnGoing\master\PIM.Common.DbManager\lba\cs\PIM.Common.DbManager\lcl\
			      	srcpath = src_files + @"/AD-PIM/OnGoing/master/PIM.Common.DbManager/lba/"+ src_lcode2_17[i] + "/PIM.Common.DbManager/lcl/";
									
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            		{
	                		fileName = System.IO.Path.GetFileName(s);
	                		destFile = System.IO.Path.Combine(tgtpath, fileName);
	                		System.IO.File.Copy(s, destFile, true);
	                		lbl_file.Text = fileName;
	            		}
					
	            	//c:\Eliseo\TRES\AD-PIM\OnGoing\master\PIM.Extension\lba\cs\PIM.Extension\lcl\Client\
			      	srcpath = src_files + @"/AD-PIM/OnGoing/master/PIM.Extension/lba/"+ src_lcode2_17[i] + "/PIM.Extension/lcl/Client/";
									
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            		{
	                		fileName = System.IO.Path.GetFileName(s);
	                		destFile = System.IO.Path.Combine(tgtpath, fileName);
	                		System.IO.File.Copy(s, destFile, true);
	                		lbl_file.Text = fileName;
	            		}
	            	
	            	//c:\Eliseo\TRES\AD-PIM\OnGoing\master\PIM.PSModule\lba\cs\PIM.PSModule\lcl\
			      	srcpath = src_files + @"/AD-PIM/OnGoing/master/PIM.PSModule/lba/"+ src_lcode2_17[i] + "/PIM.PSModule/lcl/";
									
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            		{
	                		fileName = System.IO.Path.GetFileName(s);
	                		destFile = System.IO.Path.Combine(tgtpath, fileName);
	                		System.IO.File.Copy(s, destFile, true);
	                		lbl_file.Text = fileName;
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
	                		lbl_file.Text = fileName;
	            		}
				}
			listView1.Items.Add("PIM - Success - (X lcl files per locate, X in total)");
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
	                	lbl_file.Text = fileName;
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
	                	lbl_file.Text = fileName;
	            	}
					
	            	
					srcpath = src_files + @"/AD-IAM-HybridSync/Continuous/develop/Microsoft.Online.Deployment.OneADWizard/lba/"+ src_lcode2_17[i] + "/Microsoft.Online.Deployment.OneADWizard/lcl/";
					tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AADConnect/Microsoft.Online.Deployment.OneADWizard/";		        					
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	                	lbl_file.Text = fileName;
	            	}
	            	
	            	srcpath = src_files + @"/AD-IAM-HybridSync/Continuous/develop/Microsoft.Online.Deployment.PSModule/lba/"+ src_lcode2_17[i] + "/Microsoft.Online.Deployment.PSModule/lcl/";
					tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AADConnect/Microsoft.Online.Deployment.PSModule/";		        					
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	                	lbl_file.Text = fileName;
	            	}
	            	
	            	srcpath = src_files + @"/AD-IAM-HybridSync/Continuous/develop/Microsoft.Online.Deployment.Types/lba/"+ src_lcode2_17[i] + "/Microsoft.Online.Deployment.Types/lcl/";
					tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_17[i] + "/AADConnect/Microsoft.Online.Deployment.Types/";		        					
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	                	lbl_file.Text = fileName;
	            	}
				}
			listView1.Items.Add("AAD Connect - Success - (X lcl files per locate, X in total)");
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
	                	lbl_file.Text = fileName;
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
	                	lbl_file.Text = fileName;
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
		                	lbl_file.Text = fileName;
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
	                	lbl_file.Text = fileName;
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
	                	lbl_file.Text = fileName;
	            	}
				}
			listView1.Items.Add("AAD Connect Health - Success - (X lcl files per locate, X in total)");
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
	                	lbl_file.Text = fileName;
	            	}
					
					
				}
			listView1.Items.Add("Rome - Success - (X lcl files per locate, X in total)");
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
		                	lbl_file.Text = fileName;
		            	}
					
					
				}
			listView1.Items.Add("ERM - Success - (X lcl files per locate, X in total)");
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
	                	lbl_file.Text = fileName;
	            	}
					
					
				}
			listView1.Items.Add("Atlanta - Success - (X lcl files per locate, X in total)");
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
	                	lbl_file.Text = fileName;
	            	}
					
					
				}
			listView1.Items.Add("Adallom - Success - (X lcl files per locate, X in total)");
		}
		
		public void ESTS()
		{
			for (int i = 0; i < src_lcode_108.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD-EvoSTS\OnGoing\SLVSO\Projects\ESTS\Localization\LCL\af-ZA\LocProject\lcl\private\Product\
					string srcpath = src_files + @"/AD-EvoSTS/OnGoing/SLVSO/Projects/ESTS/Localization/LCL/"+ tgt_lcode_108[i] + "/LocProject/lcl/private/Product/";
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
		                	lbl_file.Text = fileName;
		            	}
					
				}
			listView1.Items.Add("ESTS - Success - (X lcl files per locate, X in total)");
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
		                	lbl_file.Text = fileName;
		            	}
					
				}
			listView1.Items.Add("MIM - Success - (X lcl files per locate, X in total)");
		}
		
		public void IAMUX()
		{
			for (int i = 0; i < src_lcode_108.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD-IAM-Services-AADUX\Weekly\master\AzurePortalWebsite\lba\de\AzurePortalWebsite\lcl\
					string srcpath = src_files + @"/AD-IAM-Services-AADUX/Weekly/master/AzurePortalWebsite/lba/"+ src_lcode2_108[i] + "/AzurePortalWebsite/lcl/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_108[i] + "/IAMUX/";		        	
					string fileName;
					string destFile;				
			        string[] files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	                	lbl_file.Text = fileName;
	            	}
					
				}
			listView1.Items.Add("IAMUX - Success - (X lcl files per locate, X in total)");
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
	                	lbl_file.Text = fileName;
	            	}
					
				}
			listView1.Items.Add("MSA Account KC - Success - (X lcl files per locate, X in total)");
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
	                	lbl_file.Text = fileName;
	            	}
					
				}
			listView1.Items.Add("MSA Account WPWiz - Success - (X lcl files per locate, X in total)");
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
	                	lbl_file.Text = fileName;
	            	}
					
				}
			listView1.Items.Add("MSA Account XBOX - Success - (X lcl files per locate, X in total)");
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
	                	lbl_file.Text = fileName;
	            	}
					
				}
			listView1.Items.Add("MSA App Reg Portal - Success - (X lcl files per locate, X in total)");
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
	                	lbl_file.Text = fileName;
	            	}
					
				}
			listView1.Items.Add("MSA Authenticator Android - Success - (X lcl files per locate, X in total)");
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
	                	lbl_file.Text = fileName;
	            	}
					
				}
			listView1.Items.Add("MSA Login - Success - (X lcl files per locate, X in total)");
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
	                	lbl_file.Text = fileName;
	            	}
					
				}
			listView1.Items.Add("MSA Account - Success - (X lcl files per locate, X in total)");
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
	                	lbl_file.Text = fileName;
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
		                	lbl_file.Text = fileName;
		            	}
				}
			listView1.Items.Add("SSPR - Success - (X lcl files per locate, X in total)");
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
		                	lbl_file.Text = fileName;
		            	}
					
				}
			listView1.Items.Add("Key Vault - Success - (X lcl files per locate, X in total)");
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
	                	lbl_file.Text = fileName;
	            	}
					
				}
			listView1.Items.Add("PowerShell 33 - Success - (X lcl files per locate, X in total)");
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
	                	lbl_file.Text = fileName;
	            	}
	            	
	            	//c:\Eliseo\TRES\AD_PowerShell\OnGoing\develop\AzureAD16.PowerShell.AutoGen\lba\es\AzureAD16.PowerShell.AutoGen\lcl\
					
				}
			listView1.Items.Add("PowerShell 6 - Success - (X lcl files per locale, X in total)");
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
	                	lbl_file.Text = fileName;
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
	                	lbl_file.Text = fileName;
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
	                	lbl_file.Text = fileName;
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
	                	lbl_file.Text = fileName;
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
	                	lbl_file.Text = fileName;
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
	                	lbl_file.Text = fileName;
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
	                	lbl_file.Text = fileName;
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
	                	lbl_file.Text = fileName;
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
	                	lbl_file.Text = fileName;
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
	                	lbl_file.Text = fileName;
	            	}
				}
			listView1.Items.Add("PowerShell 7 - Success - (X lcl files per locale, X in total)");
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
	                	lbl_file.Text = fileName;
	            	}
	            	
					
				}
			listView1.Items.Add("MSODS 33 - Success - (X lcl files per locale, X in total)");
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
	                	lbl_file.Text = fileName;
	            	}
	            	
					
				}
			listView1.Items.Add("MSODS - Success - (X lcl files per locale, X in total)");
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
	                	lbl_file.Text = fileName;
	            	}
	            	
					
				}
			listView1.Items.Add("ADRS - Success - (X lcl files per locale, X in total)");
		}
		
		public void MFAAndroid()
		{
			for (int i = 0; i < src_lcode2_43.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD_MFAApp_Android\OnGoing\SLVso\Projects\AD_MFAApp_Android\Localization\LCL\ar-SA\LocProject\lcl\PhoneFactor\app\src\main\res\values\
					string srcpath = src_files + @"/AD_MFAApp_Android/OnGoing/SLVso/Projects/AD_MFAApp_Android/Localization/LCL/"+ src_lcode2_43[i] + "/LocProject/lcl/PhoneFactor/app/src/main/res/values/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_43[i] + "/MFAPhoneAppAndroid/";		        	
					string fileName;
					string destFile;				
			        string[] files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	                	lbl_file.Text = fileName;
	            	}
	            	
	            	//c:\LegoSD\Active Directory\AD_MFAApp_Android\OnGoing\SLVso\Projects\AD_MFAApp_Android\Localization\LCL\bg-BG\LocProject\lcl\
	            	//srcpath = src_files + @"/AD_MFAApp_Android/OnGoing/SLVso/Projects/AD_MFAApp_Android/Localization/LCL/"+ src_lcode2_43[i] + "/LocProject/lcl/PhoneFactor/";
					/*tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_43[i] + "/MFAPhoneAppAndroid/";		        	
				
			        files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}*/
					
				}
			listView1.Items.Add("MFA Authenticator Android - Success - (X lcl files per locale, X in total)");
		}
		
		public void MFAiPhone()
		{
			for (int i = 0; i < src_lcode2_43.Length; i++) 
				{
					//MFAPhoneAppiPhone
					//c:\Eliseo\TRES\AD_MFAApp_iPhone\OnGoing\SLVso\Projects\AD_MFAApp_iPhone\Localization\LCL\ar-SA\LocProject\lcl\PhoneFactor\en.lproj\
					string srcpath = src_files + @"/AD_MFAApp_iPhone/OnGoing/SLVso/Projects/AD_MFAApp_iPhone/Localization/LCL/"+ src_lcode2_43[i] + "/LocProject/lcl/PhoneFactor/en.lproj/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_43[i] + "/MFAPhoneAppiPhone/";		        	
					string fileName;
					string destFile;				
			        string[] files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	                	lbl_file.Text = fileName;
	            	}
	            	
					
				}
			listView1.Items.Add("MFA Authenticator iPhone - Success - (X lcl files per locale, X in total)");
		}
		
		public void MFAWinPhone()
		{
			for (int i = 0; i < src_lcode_61.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD_MFAApp_WinPhone\OnGoing\master\app\lba\af\app\lcl\Strings\en-US\
					string srcpath = src_files + @"/AD_MFAApp_WinPhone/OnGoing/master/app/lba/"+ src_lcode_61[i] + "/app/lcl/Strings/en-US/";
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_61[i] + "/MFAPhoneAppWinPhone/";		        	
					string fileName;
					string destFile;				
			        string[] files = System.IO.Directory.GetFiles(srcpath);
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	                	lbl_file.Text = fileName;
	            	}
	            	
					
				}
			listView1.Items.Add("MFA Authenticator WinPhone - Success - (X lcl files per locale, X in total)");
		}
		
		void Btn_exportClick(object sender, EventArgs e)
		{
			string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();
            if (listView1.Items.Count==0) {
            	MessageBox.Show("We have nothing to export :) ");
            }else{
            	sfd.Title = "Event Log Export";
	            sfd.Filter = "Text File (.txt) | *.txt";
	
	            if (sfd.ShowDialog() == DialogResult.OK)
	            {
	                filename = sfd.FileName.ToString();
	                if (filename != "")
	                {
	                    using (StreamWriter sw = new StreamWriter(filename))
	                    {
	                        foreach (ListViewItem item in listView1.Items)
	                        {
	                            sw.WriteLine(item.Text);
				                for (int i = 1; i < item.SubItems.Count; i++)
				                {
				                    sw.WriteLine(item.SubItems[i].Text);
				                }
	                        }
	                    }
	                }
	            }	
            }
		}
		
		/*public void MFA()
		{
			for (int i = 0; i < src_lcode2_43.Length; i++) 
				{
					
					//c:\Eliseo\TRES\AD_MFA\OnGoing\PhoneFactor_LocHolder\private\lba\ar-SA\
					string srcpath = src_files + @"/AD_MFA/OnGoing/PhoneFactor_LocHolder/private/lba/"+ src_lcode2_43[i];
					string tgtpath = tgt_files + @"/ActiveDirectory/" + mtb_yearmonth.Text + "/" + tgt_lcode_43[i] + "/MFA/";		        	
					string fileName;
					string destFile;				
			        string[] files = System.IO.Directory.get
	            	foreach (string s in files)
	            	{
	                	fileName = System.IO.Path.GetFileName(s);
	                	destFile = System.IO.Path.Combine(tgtpath, fileName);
	                	System.IO.File.Copy(s, destFile, true);
	            	}
	            	
					
				}
		}*/
		
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
		void Chbx_MFACheckedChanged(object sender, EventArgs e)
		{
	
		}
	
		}
	}

