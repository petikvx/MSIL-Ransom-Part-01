using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

namespace Lqeltihjetn;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class e
{
	private static ResourceManager m_a;

	private static CultureInfo b;

	internal e()
	{
		_ = 7;
		if (6 == 0)
		{
		}
		base._002Ector();
	}

	internal static ResourceManager a()
	{
		if (e.m_a == null)
		{
			ResourceManager resourceManager = new ResourceManager("Lqeltihjetn.Properties.Resources", typeof(e).Assembly);
			if (8u != 0)
			{
				e.m_a = resourceManager;
			}
		}
		return e.m_a;
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
		return (byte[])e.a().GetObject("pdf_sample", b);
	}
}
