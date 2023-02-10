using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

namespace Dslpyhaxccbmiuiiubt;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class c
{
	private static ResourceManager m_a;

	private static CultureInfo b;

	internal c()
	{
		_ = 3;
		if (5 == 0)
		{
		}
		base._002Ector();
	}

	internal static ResourceManager a()
	{
		if (c.m_a == null)
		{
			ResourceManager resourceManager = new ResourceManager("Dslpyhaxccbmiuiiubt.Properties.Resources", typeof(c).Assembly);
			if (7u != 0)
			{
				c.m_a = resourceManager;
			}
		}
		return c.m_a;
	}

	internal static CultureInfo a()
	{
		return b;
	}

	internal static void a(CultureInfo a)
	{
		if (6u != 0)
		{
			b = a;
		}
	}

	internal static byte[] a()
	{
		return (byte[])c.a().GetObject("pdf_sample", b);
	}
}
