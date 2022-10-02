using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

public class STRCOMP
{
	public enum InputDataTypeClass
	{
		Compressed = 1,
		UnCompressed
	}

	private string _UnCompressed;

	private string _Compressed;

	private Encoding _TextEncoding;

	private string _PrefixForCompressedString;

	private string _SuffixForCompressedString;

	private string _Passphrase;

	private bool _CompressedGiven;

	public string UnCompressed
	{
		get
		{
			return _UnCompressed;
		}
		set
		{
			_UnCompressed = value;
			_CompressedGiven = false;
			Compress();
		}
	}

	public string Compressed
	{
		get
		{
			string text = _Compressed;
			if (text.Length > 0)
			{
				if (_PrefixForCompressedString.Length > 0)
				{
					text = _PrefixForCompressedString + text;
				}
				if (_SuffixForCompressedString.Length > 0)
				{
					text += _SuffixForCompressedString;
				}
			}
			return text;
		}
		set
		{
			string text = value;
			checked
			{
				if ((text.Length > 0) & (text.Length > _PrefixForCompressedString.Length + _SuffixForCompressedString.Length))
				{
					if (_PrefixForCompressedString.Length > 0)
					{
						text = value.Substring(_PrefixForCompressedString.Length, text.Length - _PrefixForCompressedString.Length);
					}
					if (_SuffixForCompressedString.Length > 0)
					{
						text = text.Substring(0, text.Length - _SuffixForCompressedString.Length);
					}
				}
				_Compressed = text;
				_CompressedGiven = true;
				Decompress();
			}
		}
	}

	public Encoding TextEncoding
	{
		get
		{
			return _TextEncoding;
		}
		set
		{
			_TextEncoding = value;
		}
	}

	public string Passphrase
	{
		get
		{
			return _Passphrase;
		}
		set
		{
			_Passphrase = value;
			if (_CompressedGiven)
			{
				if (_Compressed.Length > 0)
				{
					Decompress();
				}
				else
				{
					_UnCompressed = string.Empty;
				}
			}
			else if (_UnCompressed.Length > 0)
			{
				Compress();
			}
			else
			{
				_Compressed = string.Empty;
			}
		}
	}

	public static object Encode(string Input)
	{
		STRCOMP sTRCOMP = new STRCOMP(Encoding.UTF8);
		sTRCOMP.UnCompressed = Input;
		return sTRCOMP.Compressed;
	}

	public static object Decode(string Input)
	{
		STRCOMP sTRCOMP = new STRCOMP(Encoding.UTF8);
		sTRCOMP.Compressed = Input;
		return sTRCOMP.UnCompressed;
	}

	public STRCOMP()
	{
		_UnCompressed = string.Empty;
		_Compressed = string.Empty;
		_TextEncoding = Encoding.UTF8;
		_PrefixForCompressedString = string.Empty;
		_SuffixForCompressedString = string.Empty;
		_Passphrase = string.Empty;
		_CompressedGiven = false;
	}

	public STRCOMP(Encoding TextEncoding)
	{
		_UnCompressed = string.Empty;
		_Compressed = string.Empty;
		_TextEncoding = Encoding.UTF8;
		_PrefixForCompressedString = string.Empty;
		_SuffixForCompressedString = string.Empty;
		_Passphrase = string.Empty;
		_CompressedGiven = false;
		_TextEncoding = TextEncoding;
	}

	public STRCOMP(Encoding TextEncoding, string InputString, InputDataTypeClass InputDataType, string Passphrase = "", string PrefixForCompressedString = "", string SuffixForCompressedString = "")
	{
		_UnCompressed = string.Empty;
		_Compressed = string.Empty;
		_TextEncoding = Encoding.UTF8;
		_PrefixForCompressedString = string.Empty;
		_SuffixForCompressedString = string.Empty;
		_Passphrase = string.Empty;
		_CompressedGiven = false;
		_TextEncoding = TextEncoding;
		_PrefixForCompressedString = PrefixForCompressedString;
		_SuffixForCompressedString = SuffixForCompressedString;
		_Passphrase = Passphrase;
		checked
		{
			switch (InputDataType)
			{
			case InputDataTypeClass.Compressed:
			{
				string text = InputString;
				if ((text.Length > 0) & (text.Length > _PrefixForCompressedString.Length + _SuffixForCompressedString.Length))
				{
					if (_PrefixForCompressedString.Length > 0)
					{
						text = InputString.Substring(_PrefixForCompressedString.Length, text.Length - _PrefixForCompressedString.Length);
					}
					if (_SuffixForCompressedString.Length > 0)
					{
						text = text.Substring(0, text.Length - _SuffixForCompressedString.Length);
					}
				}
				_Compressed = text;
				_CompressedGiven = true;
				Decompress();
				break;
			}
			case InputDataTypeClass.UnCompressed:
				_UnCompressed = InputString;
				Compress();
				break;
			}
		}
	}

	private void Compress()
	{
		if (_UnCompressed.Length == 0)
		{
			_Compressed = string.Empty;
			return;
		}
		string compressed = string.Empty;
		try
		{
			byte[] bytes = _TextEncoding.GetBytes(_UnCompressed);
			MemoryStream memoryStream = new MemoryStream();
			GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress);
			gZipStream.Write(bytes, 0, bytes.Length);
			gZipStream.Close();
			byte[] inArray = ((_Passphrase.Length <= 0) ? memoryStream.ToArray() : Encrypt(memoryStream.ToArray()));
			compressed = Convert.ToBase64String(inArray);
			memoryStream.Close();
			gZipStream.Dispose();
			memoryStream.Dispose();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		finally
		{
			_Compressed = compressed;
		}
	}

	private void Decompress()
	{
		if (_Compressed.Length == 0)
		{
			_UnCompressed = string.Empty;
			return;
		}
		string unCompressed = string.Empty;
		checked
		{
			try
			{
				byte[] buffer = ((_Passphrase.Length <= 0) ? Convert.FromBase64String(_Compressed) : Decrypt(Convert.FromBase64String(_Compressed)));
				MemoryStream memoryStream = new MemoryStream(buffer);
				GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
				byte[] array = new byte[4];
				memoryStream.Position = memoryStream.Length - 5L;
				memoryStream.Read(array, 0, 4);
				int num = BitConverter.ToInt32(array, 0);
				memoryStream.Position = 0L;
				byte[] array2 = new byte[num - 1 + 1 - 1 + 1];
				gZipStream.Read(array2, 0, num);
				gZipStream.Dispose();
				memoryStream.Dispose();
				unCompressed = _TextEncoding.GetString(array2);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception projectError = ex;
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			finally
			{
				_UnCompressed = unCompressed;
			}
		}
	}

	private byte[] Encrypt(byte[] PlainData)
	{
		byte[] result;
		try
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.Key = Encryption_Key();
			rijndaelManaged.IV = Encryption_IV();
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(PlainData, 0, PlainData.Length);
			cryptoStream.FlushFinalBlock();
			result = memoryStream.ToArray();
			cryptoStream.Close();
			memoryStream.Close();
			cryptoStream.Dispose();
			memoryStream.Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = null;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private byte[] Decrypt(byte[] EncData)
	{
		checked
		{
			byte[] array2;
			try
			{
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.KeySize = 256;
				rijndaelManaged.Key = Encryption_Key();
				rijndaelManaged.IV = Encryption_IV();
				MemoryStream memoryStream = new MemoryStream(EncData);
				CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
				byte[] array = new byte[EncData.Length + 1 - 1 + 1];
				int num = cryptoStream.Read(array, 0, EncData.Length);
				cryptoStream.Close();
				memoryStream.Close();
				cryptoStream.Dispose();
				memoryStream.Dispose();
				array2 = new byte[num + 1 - 1 + 1];
				Array.Copy(array, array2, num);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				array2 = null;
				ProjectData.ClearProjectError();
			}
			return array2;
		}
	}

	private byte[] Encryption_Key()
	{
		SHA256Managed sHA256Managed = new SHA256Managed();
		string text = Convert.ToBase64String(sHA256Managed.ComputeHash(_TextEncoding.GetBytes(_Passphrase)));
		string s = Passphrase + text;
		return sHA256Managed.ComputeHash(_TextEncoding.GetBytes(s));
	}

	private byte[] Encryption_IV()
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = Convert.ToBase64String(mD5CryptoServiceProvider.ComputeHash(_TextEncoding.GetBytes(_Passphrase)));
		string s = Passphrase + text;
		return mD5CryptoServiceProvider.ComputeHash(_TextEncoding.GetBytes(s));
	}
}
