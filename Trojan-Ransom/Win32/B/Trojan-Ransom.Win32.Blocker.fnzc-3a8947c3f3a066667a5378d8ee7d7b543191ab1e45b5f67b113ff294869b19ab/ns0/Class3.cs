using System;
using System.Drawing;
using System.IO;
using System.Security;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace ns0;

internal sealed class Class3
{
	public static Bitmap smethod_0(string string_0)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		Stream stream = default(Stream);
		try
		{
			stream = Class21.smethod_4(SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_3(603, 515), Class37.smethod_3("SmartAssembly.License.Resources.", string_0, ".png", 746, 760), 51, 37);
			if (stream != null)
			{
				return new Bitmap(stream);
			}
			return null;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, stream, string_0);
			throw;
		}
	}

	[SecuritySafeCritical]
	static Class3()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static int smethod_1(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 104:
				return string_0.Length;
			}
		}
	}
}
