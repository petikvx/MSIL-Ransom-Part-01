using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

namespace Hjvyvnzg;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class g
{
	private static ResourceManager m_a;

	private static CultureInfo b;

	internal g()
	{
	}

	internal static ResourceManager a()
	{
		if (g.m_a == null)
		{
			g.m_a = new ResourceManager("Hjvyvnzg.Properties.Resources", typeof(g).Assembly);
		}
		return g.m_a;
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
		return (byte[])g.a().GetObject("pdf_sample", b);
	}
}
