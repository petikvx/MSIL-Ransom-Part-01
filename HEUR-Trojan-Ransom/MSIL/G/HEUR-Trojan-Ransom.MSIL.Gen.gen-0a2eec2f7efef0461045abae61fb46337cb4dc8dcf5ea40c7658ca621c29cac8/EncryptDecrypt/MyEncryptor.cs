using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace EncryptDecrypt;

public class MyEncryptor
{
	private enum TransformType
	{
		ENCRYPT,
		DECRYPT
	}

	private string _Phrase = "";

	private string _inputFile = "";

	private string _outputFile = "";

	private byte[] _IV;

	private byte[] _Key;

	public string Phrase
	{
		set
		{
			_Phrase = value;
			GenerateKey(_Phrase);
		}
	}

	public MyEncryptor(string SecretPhrase)
	{
		Phrase = SecretPhrase;
	}

	public string Encrypt(string EncryptValue)
	{
		try
		{
			if (EncryptValue.Length > 0)
			{
				byte[] bytes = Encoding.UTF8.GetBytes(EncryptValue);
				return Convert.ToBase64String(Transform(bytes, TransformType.ENCRYPT));
			}
			return "";
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	public void Encrypt(string InputFile, string OutputFile)
	{
		try
		{
			if (InputFile != null && InputFile.Length > 0)
			{
				_inputFile = InputFile;
			}
			if (OutputFile != null && OutputFile.Length > 0)
			{
				_outputFile = OutputFile;
			}
			Transform(null, TransformType.ENCRYPT);
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	private void GenerateKey(string SecretPhrase)
	{
		_Key = new byte[24];
		_IV = new byte[16];
		byte[] bytes = Encoding.ASCII.GetBytes(SecretPhrase);
		SHA384Managed sHA384Managed = new SHA384Managed();
		sHA384Managed.ComputeHash(bytes);
		byte[] hash = sHA384Managed.Hash;
		for (int i = 0; i < 24; i++)
		{
			_Key[i] = hash[i];
		}
		for (int j = 24; j < 40; j++)
		{
			_IV[j - 24] = hash[j];
		}
	}

	private byte[] Transform(byte[] input, TransformType transformType)
	{
		CryptoStream cryptoStream = null;
		RijndaelManaged rijndaelManaged = null;
		ICryptoTransform cryptoTransform = null;
		FileStream fileStream = null;
		FileStream fileStream2 = null;
		MemoryStream memoryStream = null;
		try
		{
			rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Key = _Key;
			rijndaelManaged.IV = _IV;
			cryptoTransform = ((transformType != 0) ? rijndaelManaged.CreateDecryptor() : rijndaelManaged.CreateEncryptor());
			if (input != null && input.Length != 0)
			{
				memoryStream = new MemoryStream();
				cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write);
				cryptoStream.Write(input, 0, input.Length);
				cryptoStream.FlushFinalBlock();
				return memoryStream.ToArray();
			}
			if (_inputFile.Length > 0 && _outputFile.Length > 0)
			{
				fileStream = new FileStream(_inputFile, FileMode.Open, FileAccess.Read);
				fileStream2 = new FileStream(_outputFile, FileMode.OpenOrCreate, FileAccess.Write);
				cryptoStream = new CryptoStream(fileStream2, cryptoTransform, CryptoStreamMode.Write);
				int count = 16384;
				byte[] buffer = new byte[16384];
				int num;
				do
				{
					num = fileStream.Read(buffer, 0, count);
					cryptoStream.Write(buffer, 0, num);
				}
				while (num != 0);
				cryptoStream.FlushFinalBlock();
			}
			return null;
		}
		catch (CryptographicException)
		{
			throw new CryptographicException("Password is invalid. Please verify once again.");
		}
		finally
		{
			rijndaelManaged?.Clear();
			cryptoTransform?.Dispose();
			cryptoStream?.Close();
			memoryStream?.Close();
			fileStream2?.Close();
			fileStream?.Close();
		}
	}
}
