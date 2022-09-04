using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;

namespace ns0;

internal sealed class Class5
{
	private static string string_0;

	private static string string_1;

	private static byte[] byte_0;

	private static Hashtable hashtable_0;

	private static bool bool_0;

	private static int int_0;

	static Class5()
	{
		Assembly executingAssembly = default(Assembly);
		Stream manifestResourceStream = default(Stream);
		int num = default(int);
		byte[] array = default(byte[]);
		try
		{
			string_0 = "1";
			string_1 = "52";
			byte_0 = null;
			if (4u != 0)
			{
				if (7u != 0)
				{
					hashtable_0 = null;
				}
				bool_0 = false;
				goto IL_0037;
			}
			goto IL_00be;
			IL_0037:
			if (1 == 0)
			{
				goto IL_003a;
			}
			int_0 = 0;
			goto IL_00be;
			IL_003a:
			hashtable_0 = new Hashtable();
			goto IL_0091;
			IL_0091:
			int_0 = Convert.ToInt32(string_1);
			executingAssembly = Assembly.GetExecutingAssembly();
			if (8u != 0)
			{
				manifestResourceStream = executingAssembly.GetManifestResourceStream("{fc34bc44-532c-4317-9ebc-6effe1079e5d}");
				try
				{
					num = Convert.ToInt32(manifestResourceStream.Length);
					array = new byte[num];
					manifestResourceStream.Read(array, 0, num);
					byte_0 = Class8.smethod_1(array);
					do
					{
						array = null;
						manifestResourceStream.Close();
					}
					while (6 == 0);
				}
				finally
				{
					((IDisposable)manifestResourceStream)?.Dispose();
				}
			}
			if (0 == 0)
			{
				return;
			}
			goto IL_0037;
			IL_00be:
			if (string_0 == "1")
			{
				bool_0 = true;
				goto IL_003a;
			}
			goto IL_0091;
		}
		catch (Exception cO_)
		{
			Class29.smethod_4(cO_, executingAssembly, manifestResourceStream, num, array);
			throw;
		}
	}

	public static string smethod_0(int CO_)
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
			CO_ -= int_0;
			if (!bool_0)
			{
				goto IL_002a;
			}
			text = (string)hashtable_0[CO_];
			goto IL_0099;
			IL_0099:
			if (0 == 0)
			{
				if (text != null)
				{
					return text;
				}
				goto IL_002a;
			}
			goto IL_009c;
			IL_002a:
			if (2 == 0)
			{
				goto IL_0030;
			}
			if (0 == 0)
			{
				num = 0;
				num2 = CO_;
				num3 = byte_0[num2++];
				goto IL_009c;
			}
			string result;
			return result;
			IL_0030:
			num = num3;
			if (num == 0)
			{
				return string.Empty;
			}
			goto IL_0038;
			IL_0038:
			try
			{
				array = Convert.FromBase64String(Encoding.UTF8.GetString(byte_0, num2, num));
				text2 = string.Intern(Encoding.UTF8.GetString(array, 0, array.Length));
				if (bool_0)
				{
					try
					{
						hashtable_0.Add(CO_, text2);
					}
					catch
					{
					}
				}
				text3 = text2;
			}
			catch
			{
				text3 = null;
			}
			if (6u != 0)
			{
				return text3;
			}
			goto IL_0099;
			IL_009c:
			if ((num3 & 0x80) == 0)
			{
				goto IL_0030;
			}
			if ((num3 & 0x40) == 0)
			{
				num = ((num3 & 0x3F) << 8) + byte_0[num2++];
			}
			else
			{
				int num4 = num3 & 0x1F;
				do
				{
					num4 = (num4 << 24) + (byte_0[num2++] << 16) + (byte_0[num2++] << 8);
				}
				while (5 == 0);
				num = num4 + byte_0[num2++];
			}
			goto IL_0038;
		}
		catch (Exception cO_)
		{
			Class29.smethod_8(cO_, text, num, num2, num3, array, text2, text3, CO_);
			throw;
		}
	}
}
