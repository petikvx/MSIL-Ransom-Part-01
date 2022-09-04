using System;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[HideModuleName]
[StandardModule]
internal sealed class x
{
	private static ResourceManager m_a;

	private static CultureInfo m_b;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager a
	{
		get
		{
			if (object.ReferenceEquals(x.m_a, q.a))
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
				}
				ResourceManager resourceManager = (x.m_a = _003CModule_003E.a(n.a(182), Type.GetTypeFromHandle(p.a()).Assembly));
			}
			return x.m_a;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo b
	{
		get
		{
			return x.m_b;
		}
		set
		{
			x.m_b = value;
		}
	}

	internal static byte[] c
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(a.GetObject(n.a(211), x.m_b));
			return (byte[])objectValue;
		}
	}
}
