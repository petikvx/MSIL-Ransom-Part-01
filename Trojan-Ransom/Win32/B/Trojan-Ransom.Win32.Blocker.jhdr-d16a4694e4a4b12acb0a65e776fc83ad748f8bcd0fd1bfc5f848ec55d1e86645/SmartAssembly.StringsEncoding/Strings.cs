using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.Zip;

namespace SmartAssembly.StringsEncoding;

public class Strings
{
	private static readonly string string_0;

	private static readonly string string_1;

	private static readonly byte[] byte_0;

	private static readonly Hashtable hashtable_0;

	private static readonly bool bool_0;

	private static readonly int int_0;

	public static string Get(int stringID)
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
			stringID -= int_0;
			if (bool_0)
			{
				text = (string)hashtable_0[stringID];
				if (text != null)
				{
					return text;
				}
			}
			num = 0;
			num2 = stringID;
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
						hashtable_0.Add(stringID, text2);
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
		catch (Exception exception)
		{
			StackFrameHelper.CreateException8(exception, text, num, num2, num3, array, text2, text3, stringID);
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
			string_0 = "0";
			string_1 = "207";
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
			manifestResourceStream = executingAssembly.GetManifestResourceStream("{fd359725-5e72-47e7-a35c-bd45972b6fcf}");
			try
			{
				num = Convert.ToInt32(manifestResourceStream.Length);
				array = new byte[num];
				manifestResourceStream.Read(array, 0, num);
				byte_0 = SimpleZip.Unzip(array);
				array = null;
				manifestResourceStream.Close();
			}
			finally
			{
				((IDisposable)manifestResourceStream)?.Dispose();
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, executingAssembly, manifestResourceStream, num, array);
			throw;
		}
	}
}
