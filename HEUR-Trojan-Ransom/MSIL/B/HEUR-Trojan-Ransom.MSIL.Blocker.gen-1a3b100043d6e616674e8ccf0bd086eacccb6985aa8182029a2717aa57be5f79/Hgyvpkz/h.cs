using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

namespace Hgyvpkz;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal sealed class h
{
	private static ResourceManager m_a;

	private static CultureInfo b;

	internal h()
	{
	}

	internal static ResourceManager a()
	{
		if (h.m_a == null)
		{
			h.m_a = new ResourceManager("Hgyvpkz.Properties.Resources", typeof(h).Assembly);
		}
		return h.m_a;
	}

	internal static CultureInfo a()
	{
		return b;
	}

	internal static void a(CultureInfo a)
	{
		b = a;
	}
}
