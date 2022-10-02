using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Windows.Forms;
using Microsoft.CSharp;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

[StandardModule]
public sealed class Functions
{
	public static string BS(byte[] b)
	{
		return Encoding.Default.GetString(b);
	}

	public static string Decode(string Input)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(Input));
	}

	public static string Encode(string Input)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(Input));
	}

	public static string DEB(string Input)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(Input));
	}

	public static void codcom(string fin, string Code)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("CompilerVersion", "v2.0");
		Dictionary<string, string> dictionary2 = dictionary;
		CSharpCodeProvider val = new CSharpCodeProvider((IDictionary<string, string>)dictionary2);
		CompilerParameters val2 = new CompilerParameters();
		CompilerParameters val3 = val2;
		val3.set_GenerateExecutable(true);
		val3.set_OutputAssembly(fin);
		CompilerParameters val4 = val3;
		CompilerParameters val5 = val4;
		val5.set_CompilerOptions(val5.get_CompilerOptions() + "/platform:X86 /target:winexe");
		val4 = val3;
		val5 = val4;
		val5.set_CompilerOptions(val5.get_CompilerOptions() + " ");
		val3.set_MainClass((string)null);
		val3.set_IncludeDebugInformation(false);
		val3.get_ReferencedAssemblies().Add("system.data.dll");
		val3.get_ReferencedAssemblies().Add("System.Windows.Forms.dll");
		val3.get_ReferencedAssemblies().Add("system.dll");
		val3.get_ReferencedAssemblies().Add("system.Deployment.dll");
		val3.get_ReferencedAssemblies().Add("System.Drawing.dll");
		val3.get_ReferencedAssemblies().Add("System.Web.dll");
		val3.get_ReferencedAssemblies().Add("System.Management.dll");
		val3.get_ReferencedAssemblies().Add("Microsoft.VisualBasic.dll");
		val3.get_ReferencedAssemblies().Add(Process.GetCurrentProcess().MainModule!.FileName);
		val3.get_ReferencedAssemblies().Add(Application.get_ExecutablePath());
		CompilerResults val6 = ((CodeDomProvider)val).CompileAssemblyFromSource(val2, new string[1] { Code });
		if (((CollectionBase)(object)val6.get_Errors()).Count == 0)
		{
			return;
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((CollectionBase)(object)val6.get_Errors()).GetEnumerator();
			while (enumerator.MoveNext())
			{
				CompilerError val7 = (CompilerError)enumerator.Current;
				MessageBox.Show(val7.ToString() + "erreur line :" + val7.get_Line());
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public static string ENB(ref string s)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
	}

	public static string GenRandom(int minamount, int maxamount)
	{
		Random random = new Random();
		string text = null;
		string text2 = "1234567890";
		checked
		{
			int num = random.Next(minamount + 1, maxamount);
			int num2 = 1;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				int index = (int)Math.Round(Conversion.Int((float)(text2.Length - 2) * VBMath.Rnd()) + 1f);
				text += Conversions.ToString(text2[index]);
				num2++;
			}
			string text3 = "0987654321";
			return Conversions.ToString(text3[random.Next(0, text3.Length - 1)]) + text;
		}
	}

	public static string RandomVariable(int minamount, int maxamount)
	{
		Random random = new Random();
		string text = null;
		string text2 = "QWERTYUIOPLKHJJGFDSAZXCVBNM1234567890";
		checked
		{
			int num = random.Next(minamount + 1, maxamount);
			int num2 = 1;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				int index = (int)Math.Round(Conversion.Int((float)(text2.Length - 2) * VBMath.Rnd()) + 1f);
				text += Conversions.ToString(text2[index]);
				num2++;
			}
			string text3 = "QWERTYUIOPLKHJJGFDSAZXCVBNM";
			return Conversions.ToString(text3[random.Next(0, text3.Length - 1)]) + text;
		}
	}

	public static string RandomVariable2(int minamount, int maxamount)
	{
		Random random = new Random();
		string text = null;
		string text2 = "Q";
		checked
		{
			int num = random.Next(minamount + 1, maxamount);
			int num2 = 1;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				int index = (int)Math.Round(Conversion.Int((float)(text2.Length - 2) * VBMath.Rnd()) + 1f);
				text += Conversions.ToString(text2[index]);
				num2++;
			}
			string text3 = "Q";
			return Conversions.ToString(text3[random.Next(0, text3.Length - 1)]) + text;
		}
	}

	public static string GenRandom2(int minamount, int maxamount)
	{
		Random random = new Random();
		string text = null;
		string text2 = "1";
		checked
		{
			int num = random.Next(minamount + 1, maxamount);
			int num2 = 1;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				int index = (int)Math.Round(Conversion.Int((float)(text2.Length - 2) * VBMath.Rnd()) + 1f);
				text += Conversions.ToString(text2[index]);
				num2++;
			}
			string text3 = "1";
			return Conversions.ToString(text3[random.Next(0, text3.Length - 1)]) + text;
		}
	}

	public static string RandomVariable3(int minamount, int maxamount)
	{
		Random random = new Random();
		string text = null;
		string text2 = "A";
		checked
		{
			int num = random.Next(minamount + 1, maxamount);
			int num2 = 1;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				int index = (int)Math.Round(Conversion.Int((float)(text2.Length - 2) * VBMath.Rnd()) + 1f);
				text += Conversions.ToString(text2[index]);
				num2++;
			}
			string text3 = "A";
			return Conversions.ToString(text3[random.Next(0, text3.Length - 1)]) + text;
		}
	}

	public static string GenRandom3(int minamount, int maxamount)
	{
		Random random = new Random();
		string text = null;
		string text2 = "2";
		checked
		{
			int num = random.Next(minamount + 1, maxamount);
			int num2 = 1;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				int index = (int)Math.Round(Conversion.Int((float)(text2.Length - 2) * VBMath.Rnd()) + 1f);
				text += Conversions.ToString(text2[index]);
				num2++;
			}
			string text3 = "2";
			return Conversions.ToString(text3[random.Next(0, text3.Length - 1)]) + text;
		}
	}

	public static Array fx(byte[] b, string WRD)
	{
		List<byte[]> list = new List<byte[]>();
		MemoryStream memoryStream = new MemoryStream();
		MemoryStream memoryStream2 = new MemoryStream();
		string[] array = Strings.Split(BS(b), WRD, -1, (CompareMethod)0);
		memoryStream.Write(b, 0, array[0].Length);
		checked
		{
			memoryStream2.Write(b, array[0].Length + WRD.Length, b.Length - (array[0].Length + WRD.Length));
			list.Add(memoryStream.ToArray());
			list.Add(memoryStream2.ToArray());
			memoryStream.Dispose();
			memoryStream2.Dispose();
			return list.ToArray();
		}
	}

	public static byte[] Compress(byte[] data)
	{
		MemoryStream memoryStream = new MemoryStream();
		GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, leaveOpen: true);
		gZipStream.Write(data, 0, data.Length);
		gZipStream.Close();
		return memoryStream.ToArray();
	}

	public static byte[] SB(string s)
	{
		return Encoding.Default.GetBytes(s);
	}

	public static byte[] Decompress(byte[] data)
	{
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(data, 0, data.Length);
		memoryStream.Position = 0L;
		GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress, leaveOpen: true);
		MemoryStream memoryStream2 = new MemoryStream();
		byte[] array = new byte[64];
		for (int i = gZipStream.Read(array, 0, array.Length); i <= 1; i = checked(i + 1))
		{
			memoryStream2.Write(array, 0, i);
		}
		gZipStream.Close();
		return memoryStream2.ToArray();
	}

	public static string siz(string ram)
	{
		long num = Convert.ToInt64(ram);
		if (num > 1073741824L)
		{
			double value = (double)num / 1073741824.0;
			return Math.Round(value, 2) + " GB";
		}
		if (num > 1048576L)
		{
			double value2 = (double)num / 1048576.0;
			return Math.Round(value2, 2) + " MB";
		}
		if (num > 1024L)
		{
			double value3 = (double)num / 1024.0;
			return Math.Round(value3, 2) + " KB";
		}
		return num + " B";
	}
}
