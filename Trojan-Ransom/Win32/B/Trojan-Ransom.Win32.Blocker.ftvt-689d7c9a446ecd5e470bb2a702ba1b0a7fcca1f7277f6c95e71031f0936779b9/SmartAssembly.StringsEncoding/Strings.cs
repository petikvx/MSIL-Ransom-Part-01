using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.Zip;

namespace SmartAssembly.StringsEncoding;

public sealed class Strings
{
	[NonSerialized]
	internal static GetString getString_0;

	private static string MustUseCache;

	private static string OffsetValue;

	private static byte[] bytes;

	private static Hashtable hashtable;

	private static bool cacheStrings;

	private static int offset;

	public static string Get(int int_0)
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
			int_0 -= offset;
			if (cacheStrings)
			{
				text = (string)hashtable[int_0];
				if (text != null)
				{
					return text;
				}
			}
			num = 0;
			num2 = int_0;
			num3 = bytes[num2++];
			if (((uint)num3 & 0x80u) != 0)
			{
				num = ((((uint)num3 & 0x40u) != 0) ? (((num3 & 0x1F) << 24) + (bytes[num2++] << 16) + (bytes[num2++] << 8) + bytes[num2++]) : (((num3 & 0x3F) << 8) + bytes[num2++]));
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
				array = Convert.FromBase64String(Encoding.UTF8.GetString(bytes, num2, num));
				text2 = string.Intern(Encoding.UTF8.GetString(array, 0, array.Length));
				if (cacheStrings)
				{
					try
					{
						hashtable.Add(int_0, text2);
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
			StackFrameHelper.CreateException8(exception_, text, num, num2, num3, array, text2, text3, int_0);
			throw;
		}
	}

	static Strings()
	{
		Assembly executingAssembly = default(Assembly);
		Stream manifestResourceStream = default(Stream);
		int num = default(int);
		byte[] array = default(byte[]);
		try
		{
			SmartAssembly.HouseOfCards.Strings.CreateGetStringDelegate(typeof(Strings));
			MustUseCache = "1";
			OffsetValue = "252";
			bytes = null;
			hashtable = null;
			cacheStrings = false;
			offset = 0;
			if (MustUseCache == "1")
			{
				cacheStrings = true;
				hashtable = new Hashtable();
			}
			offset = Convert.ToInt32(OffsetValue);
			executingAssembly = Assembly.GetExecutingAssembly();
			manifestResourceStream = executingAssembly.GetManifestResourceStream("{8b296023-0af9-4988-b7a0-0ba22330d2e5}");
			try
			{
				num = Convert.ToInt32(manifestResourceStream.Length);
				array = new byte[checked((uint)num)];
				manifestResourceStream.Read(array, 0, num);
				bytes = SimpleZip.Unzip(array);
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
			StackFrameHelper.CreateException4(exception_, executingAssembly, manifestResourceStream, num, array);
			throw;
		}
	}
}
