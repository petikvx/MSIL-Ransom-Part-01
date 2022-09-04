using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
[HideModuleName]
internal sealed class x
{
	private static ResourceManager m_a;

	private static CultureInfo m_b;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager a
	{
		get
		{
			if (object.ReferenceEquals(x.m_a, null))
			{
				ResourceManager resourceManager = (x.m_a = _003CModule_003E.a("nPub.Resources", typeof(x).Assembly));
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
			object objectValue = RuntimeHelpers.GetObjectValue(a.GetObject("nPub", x.m_b));
			return (byte[])objectValue;
		}
	}
}
