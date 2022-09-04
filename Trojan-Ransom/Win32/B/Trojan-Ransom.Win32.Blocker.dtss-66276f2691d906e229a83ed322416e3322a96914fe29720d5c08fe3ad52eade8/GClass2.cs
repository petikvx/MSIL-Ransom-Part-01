using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

public class GClass2
{
	public enum GEnum0
	{
		const_0 = 1,
		const_1
	}

	internal string string_0;

	internal string string_1;

	internal Encoding encoding_0;

	internal string string_2;

	internal string string_3;

	internal string string_4;

	internal bool bool_0;

	public string UnCompressed
	{
		get
		{
			return string_0;
		}
		set
		{
			string text = (string_0 = value);
			bool_0 = false;
			method_0();
		}
	}

	public string Compressed
	{
		get
		{
			string text = string_1;
			if (text.Length > 0)
			{
				if (string_2.Length > 0)
				{
					text = string_2 + text;
				}
				if (string_3.Length > 0)
				{
					text += string_3;
				}
			}
			return text;
		}
		set
		{
			string text = value;
			checked
			{
				if ((text.Length > 0) & (text.Length > string_2.Length + string_3.Length))
				{
					if (string_2.Length > 0)
					{
						text = value.Substring(string_2.Length, text.Length - string_2.Length);
					}
					if (string_3.Length > 0)
					{
						text = text.Substring(0, text.Length - string_3.Length);
					}
				}
				string text2 = (string_1 = text);
				bool_0 = true;
				method_1();
			}
		}
	}

	public Encoding TextEncoding
	{
		get
		{
			return encoding_0;
		}
		set
		{
			Encoding encoding = (encoding_0 = value);
		}
	}

	public long UnCompressed_Size => string_0.Length;

	public long Compressed_Size => string_1.Length;

	public double Compression_Ratio
	{
		get
		{
			double result = 0.0;
			if ((string_1.Length > 0) & (string_0.Length > 0))
			{
				result = (double)string_1.Length / (double)string_0.Length;
				result = Math.Round(result, 2, MidpointRounding.AwayFromZero);
			}
			return result;
		}
	}

	public string PrefixForCompressedString
	{
		get
		{
			return string_2;
		}
		set
		{
			string text = (string_2 = value);
		}
	}

	public string SuffixForCompressedString
	{
		get
		{
			return string_3;
		}
		set
		{
			string text = (string_3 = value);
		}
	}

	public string Passphrase
	{
		get
		{
			return string_4;
		}
		set
		{
			string text = (string_4 = value);
			if (bool_0)
			{
				if (string_1.Length > 0)
				{
					method_1();
				}
				else
				{
					string text2 = (string_0 = string.Empty);
				}
			}
			else if (string_0.Length > 0)
			{
				method_0();
			}
			else
			{
				string text3 = (string_1 = string.Empty);
			}
		}
	}

	public GClass2()
	{
		string text = (string_0 = string.Empty);
		string text2 = (string_1 = string.Empty);
		Encoding encoding = (encoding_0 = Encoding.UTF8);
		string text3 = (string_2 = string.Empty);
		string text4 = (string_3 = string.Empty);
		string text5 = (string_4 = string.Empty);
		bool_0 = false;
	}

	public GClass2(Encoding encoding_1)
	{
		string text = (string_0 = string.Empty);
		string text2 = (string_1 = string.Empty);
		Encoding encoding = (encoding_0 = Encoding.UTF8);
		string text3 = (string_2 = string.Empty);
		string text4 = (string_3 = string.Empty);
		string text5 = (string_4 = string.Empty);
		bool_0 = false;
		Encoding encoding2 = (encoding_0 = encoding_1);
	}

	public GClass2(Encoding encoding_1, string string_5, GEnum0 genum0_0, string string_6 = "", string string_7 = "", string string_8 = "")
	{
		string text = (string_0 = string.Empty);
		string text2 = (string_1 = string.Empty);
		Encoding encoding = (encoding_0 = Encoding.UTF8);
		string text3 = (string_2 = string.Empty);
		string text4 = (string_3 = string.Empty);
		string text5 = (string_4 = string.Empty);
		bool_0 = false;
		Encoding encoding2 = (encoding_0 = encoding_1);
		string text6 = (string_2 = string_7);
		string text7 = (string_3 = string_8);
		string text8 = (string_4 = string_6);
		checked
		{
			switch (genum0_0)
			{
			case GEnum0.const_0:
			{
				string text10 = string_5;
				if ((text10.Length > 0) & (text10.Length > string_2.Length + string_3.Length))
				{
					if (string_2.Length > 0)
					{
						text10 = string_5.Substring(string_2.Length, text10.Length - string_2.Length);
					}
					if (string_3.Length > 0)
					{
						text10 = text10.Substring(0, text10.Length - string_3.Length);
					}
				}
				string text11 = (string_1 = text10);
				bool_0 = true;
				method_1();
				break;
			}
			case GEnum0.const_1:
			{
				string text9 = (string_0 = string_5);
				method_0();
				break;
			}
			}
		}
	}

	private void method_0()
	{
		if (string_0.Length == 0)
		{
			string text = (string_1 = string.Empty);
			return;
		}
		string text2 = string.Empty;
		try
		{
			byte[] bytes = encoding_0.GetBytes(string_0);
			MemoryStream memoryStream = new MemoryStream();
			GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress);
			gZipStream.Write(bytes, 0, bytes.Length);
			gZipStream.Close();
			byte[] inArray = ((string_4.Length <= 0) ? memoryStream.ToArray() : method_2(memoryStream.ToArray()));
			text2 = Convert.ToBase64String(inArray);
			memoryStream.Close();
			gZipStream.Dispose();
			memoryStream.Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string text3 = (string_1 = text2);
		}
	}

	private void method_1()
	{
		if (string_1.Length == 0)
		{
			string text = (string_0 = string.Empty);
			return;
		}
		string text2 = string.Empty;
		checked
		{
			try
			{
				byte[] buffer = ((string_4.Length <= 0) ? Convert.FromBase64String(string_1) : method_3(Convert.FromBase64String(string_1)));
				MemoryStream memoryStream = new MemoryStream(buffer);
				GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
				byte[] array = new byte[4];
				memoryStream.Position = memoryStream.Length - 5L;
				memoryStream.Read(array, 0, 4);
				int num = BitConverter.ToInt32(array, 0);
				memoryStream.Position = 0L;
				byte[] array2 = new byte[num - 1 + 1];
				gZipStream.Read(array2, 0, num);
				gZipStream.Dispose();
				memoryStream.Dispose();
				text2 = encoding_0.GetString(array2);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			finally
			{
				string text3 = (string_0 = text2);
			}
		}
	}

	private byte[] method_2(byte[] byte_0)
	{
		try
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.Key = method_4();
			rijndaelManaged.IV = method_5();
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.FlushFinalBlock();
			byte[] result = memoryStream.ToArray();
			cryptoStream.Close();
			memoryStream.Close();
			cryptoStream.Dispose();
			memoryStream.Dispose();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			byte[] result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private byte[] method_3(byte[] byte_0)
	{
		checked
		{
			try
			{
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.KeySize = 256;
				rijndaelManaged.Key = method_4();
				rijndaelManaged.IV = method_5();
				MemoryStream memoryStream = new MemoryStream(byte_0);
				CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
				byte[] array = new byte[byte_0.Length + 1];
				int num = cryptoStream.Read(array, 0, byte_0.Length);
				cryptoStream.Close();
				memoryStream.Close();
				cryptoStream.Dispose();
				memoryStream.Dispose();
				byte[] array2 = new byte[num + 1];
				Array.Copy(array, array2, num);
				return array2;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				byte[] array2 = null;
				ProjectData.ClearProjectError();
				return array2;
			}
		}
	}

	private byte[] method_4()
	{
		SHA256Managed sHA256Managed = new SHA256Managed();
		string text = Convert.ToBase64String(sHA256Managed.ComputeHash(encoding_0.GetBytes(string_4)));
		string s = Passphrase + text;
		return sHA256Managed.ComputeHash(encoding_0.GetBytes(s));
	}

	private byte[] method_5()
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = Convert.ToBase64String(mD5CryptoServiceProvider.ComputeHash(encoding_0.GetBytes(string_4)));
		string s = Passphrase + text;
		return mD5CryptoServiceProvider.ComputeHash(encoding_0.GetBytes(s));
	}
}
