using System;
using System.IO;

namespace ns1;

internal static class Class0
{
	private const int int_0 = 1024;

	internal const int int_1 = 1104;

	internal const int int_2 = 1106;

	internal const int int_3 = 1105;

	internal const int int_4 = 1107;

	internal const int int_5 = 1108;

	internal const int int_6 = 1109;

	internal const int int_7 = 1110;

	internal const int int_8 = 1111;

	internal const int int_9 = 1112;

	internal const int int_10 = 1113;

	public static IntPtr smethod_0(string string_0)
	{
		IntPtr intptr_ = IntPtr.Zero;
		string text = smethod_2(ref intptr_);
		if (text != null)
		{
			try
			{
				FileStream fileStream = new FileStream(text, FileMode.Create, FileAccess.Write);
				StreamWriter streamWriter = new StreamWriter(fileStream);
				streamWriter.WriteLine(string_0);
				streamWriter.Dispose();
				fileStream.Dispose();
				return intptr_;
			}
			catch
			{
				return IntPtr.Zero;
			}
		}
		return intptr_;
	}

	public static string smethod_1(IntPtr intptr_0)
	{
		string result = null;
		if (intptr_0 != IntPtr.Zero)
		{
			string path = smethod_2(ref intptr_0);
			if (File.Exists(path))
			{
				try
				{
					FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
					StreamReader streamReader = new StreamReader(fileStream);
					result = streamReader.ReadToEnd();
					streamReader.Dispose();
					fileStream.Dispose();
					return result;
				}
				catch
				{
					return null;
				}
			}
		}
		return result;
	}

	private static string smethod_2(ref IntPtr intptr_0)
	{
		string result = null;
		string environmentVariable = Environment.GetEnvironmentVariable(" ");
		if (environmentVariable != null)
		{
			if (intptr_0 == IntPtr.Zero)
			{
				Random random = new Random(DateTime.Now.Millisecond);
				intptr_0 = new IntPtr(random.Next());
			}
			result = environmentVariable + "\\ " + intptr_0 + ". ";
		}
		return result;
	}
}
