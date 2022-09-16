using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace F0;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[CompilerGenerated]
internal class h8
{
	private static ResourceManager pG;

	private static CultureInfo po;

	private static h8 OQ;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager Od
	{
		get
		{
			int num = 1;
			while (true)
			{
				bool flag = pG == null;
				int num2 = 0;
				if (!Dw())
				{
					num2 = num;
				}
				switch (num2)
				{
				case 1:
					continue;
				}
				if (flag)
				{
					ResourceManager resourceManager = (pG = new ResourceManager("F0.h8", HK(typeof(h8).TypeHandle).Assembly));
				}
				return pG;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo N5
	{
		get
		{
			return po;
		}
		set
		{
			po = value;
		}
	}

	internal h8()
	{
		Rg.XRF6rz();
		base._002Ector();
	}

	[SpecialName]
	internal static byte[] s4()
	{
		object @object = Od.GetObject(sE.znu(0), po);
		return (byte[])@object;
	}

	internal static bool Dw()
	{
		return OQ == null;
	}

	internal static h8 iY()
	{
		return OQ;
	}

	internal static Type HK(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
