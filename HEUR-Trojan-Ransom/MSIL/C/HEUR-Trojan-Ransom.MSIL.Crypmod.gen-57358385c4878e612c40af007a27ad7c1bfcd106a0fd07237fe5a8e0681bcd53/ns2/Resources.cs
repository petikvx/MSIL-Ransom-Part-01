using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns1;

namespace ns2;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal sealed class Resources
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 54)]
	private struct Struct0
	{
	}

	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	private static readonly Array array_0;

	private static readonly object object_0 = new char[27];

	private static readonly Array array_1;

	internal static byte byte_0/* Not supported: data(00) */;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (resourceManager_0 == null)
			{
				resourceManager_0 = new ResourceManager("piri.Properties.Resources", typeof(Resources).Assembly);
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return cultureInfo_0;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	internal Resources()
	{
	}

	static Resources()
	{
		char[] array = new char[8];
		array[7] = '㸅';
		array[2] = 'ᵥ';
		array[0] = '⁍';
		array[3] = '⧕';
		array[5] = '⯾';
		array[6] = '⹄';
		array[4] = '೨';
		array[1] = '㲰';
		array_1 = new string[4];
		array_0 = array;
	}

	static void smethod_0(object object_1, object object_2, object object_3)
	{
		//IL_001b: Incompatible stack heights: 1 vs 0
		try
		{
		}
		catch
		{
		}
		try
		{
		}
		finally
		{
			goto IL_0009;
		}
		IL_0014:
		try
		{
		}
		catch (object obj2)
		{
			while (obj2 != null)
			{
			}
		}
		_ = (char)Class1.smethod_4((byte[])/*Error near IL_0024: Stack underflow*/, (byte[])/*Error near IL_0024: Stack underflow*/);
		bool flag;
		while (checked((flag ? 1u : 0u) + (flag ? 1u : 0u)) != 0)
		{
		}
		try
		{
		}
		finally
		{
			try
			{
			}
			finally
			{
				byte b = b;
				b = 136;
				goto IL_0041;
			}
		}
		IL_0009:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
		do
		{
			flag = false;
		}
		while (flag = flag2);
		try
		{
		}
		finally
		{
			goto IL_0014;
		}
		IL_0041:
		while (true)
		{
		}
	}
}
