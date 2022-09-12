using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

namespace Pjgxxrqhqvbupdz;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class k
{
	private static ResourceManager m_a;

	private static CultureInfo b;

	internal k()
	{
	}

	internal static ResourceManager a()
	{
		if (k.m_a == null)
		{
			k.m_a = new ResourceManager("Pjgxxrqhqvbupdz.Properties.Resources", typeof(k).Assembly);
		}
		return k.m_a;
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
		return (byte[])k.a().GetObject("pdf_sample", b);
	}
}
