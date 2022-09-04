using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;
using ns3;
using ns7;

namespace ns9;

internal sealed class Class15
{
	private static string string_0;

	private static string string_1;

	private static byte[] byte_0;

	private static Hashtable hashtable_0;

	private static bool bool_0;

	private static int int_0;

	[Attribute2]
	[Attribute1]
	public static string smethod_0(int int_1)
	{
		string text = default(string);
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		byte[] array = default(byte[]);
		string text2 = default(string);
		string text3 = default(string);
		try
		{
			int_1 -= int_0;
			if (bool_0)
			{
				text = (string)hashtable_0[int_1];
				if (text != null)
				{
					return text;
				}
			}
			num = 0;
			num2 = int_1;
			num3 = byte_0[num2++];
			if (((uint)num3 & 0x80u) != 0)
			{
				num = ((((uint)num3 & 0x40u) != 0) ? (((num3 & 0x1F) << 24) + (byte_0[num2++] << 16) + (byte_0[num2++] << 8) + byte_0[num2++]) : (((num3 & 0x3F) << 8) + byte_0[num2++]));
			}
			else
			{
				num = num3;
				if (num == 0)
				{
					return string.Empty;
				}
			}
			try
			{
				array = Convert.FromBase64String(Encoding.UTF8.GetString(byte_0, num2, num));
				text2 = string.Intern(Encoding.UTF8.GetString(array, 0, array.Length));
				if (bool_0)
				{
					try
					{
						hashtable_0.Add(int_1, text2);
					}
					catch
					{
					}
				}
				text3 = text2;
				return text3;
			}
			catch
			{
				text3 = null;
				return text3;
			}
		}
		catch (Exception exception_)
		{
			Class38.smethod_8(exception_, text, num, num2, num3, array, text2, text3, int_1);
			throw;
		}
	}

	static Class15()
	{
		Assembly executingAssembly = default(Assembly);
		Stream manifestResourceStream = default(Stream);
		int num = default(int);
		byte[] array = default(byte[]);
		try
		{
			string_0 = "1";
			string_1 = "32";
			byte_0 = null;
			hashtable_0 = null;
			bool_0 = false;
			int_0 = 0;
			if (string_0 == "1")
			{
				bool_0 = true;
				hashtable_0 = new Hashtable();
			}
			int_0 = Convert.ToInt32(string_1);
			executingAssembly = Assembly.GetExecutingAssembly();
			manifestResourceStream = executingAssembly.GetManifestResourceStream("{7bde69c8-e8d0-4086-8f57-029abd9c0d30}");
			try
			{
				num = Convert.ToInt32(manifestResourceStream.Length);
				array = new byte[num];
				manifestResourceStream.Read(array, 0, num);
				byte_0 = Class18.smethod_1(array);
				array = null;
				manifestResourceStream.Close();
			}
			finally
			{
				((IDisposable)manifestResourceStream)?.Dispose();
			}
		}
		catch (Exception exception_)
		{
			Class38.smethod_4(exception_, executingAssembly, manifestResourceStream, num, array);
			throw;
		}
	}
}
