using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

namespace WindowsFormsApp25;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class c
{
	private static ResourceManager m_a;

	private static CultureInfo b;

	internal c()
	{
	}

	internal static ResourceManager a()
	{
		if (c.m_a == null)
		{
			c.m_a = new ResourceManager("WindowsFormsApp25.Properties.Resources", typeof(c).Assembly);
		}
		return c.m_a;
	}

	internal static CultureInfo a()
	{
		return b;
	}

	internal static void a(CultureInfo a)
	{
		b = a;
	}

	internal static byte[] a()
	{
		return (byte[])c.a().GetObject("Egtchnltoaqjsbvqykmbc", b);
	}
}
