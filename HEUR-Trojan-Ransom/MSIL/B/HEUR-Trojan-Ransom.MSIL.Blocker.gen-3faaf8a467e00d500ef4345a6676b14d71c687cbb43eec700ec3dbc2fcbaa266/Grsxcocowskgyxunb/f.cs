using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

namespace Grsxcocowskgyxunb;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class f
{
	private static ResourceManager m_a;

	private static CultureInfo b;

	internal f()
	{
		_ = 7;
		if (7 == 0)
		{
		}
		base._002Ector();
	}

	internal static ResourceManager a()
	{
		if (f.m_a == null)
		{
			ResourceManager resourceManager = new ResourceManager("Grsxcocowskgyxunb.Properties.Resources", typeof(f).Assembly);
			if (0 == 0)
			{
				f.m_a = resourceManager;
			}
		}
		return f.m_a;
	}

	internal static CultureInfo a()
	{
		return b;
	}

	internal static void a(CultureInfo a)
	{
		if (true)
		{
			b = a;
		}
	}

	internal static byte[] a()
	{
		return (byte[])f.a().GetObject("pdf_sample", b);
	}
}
