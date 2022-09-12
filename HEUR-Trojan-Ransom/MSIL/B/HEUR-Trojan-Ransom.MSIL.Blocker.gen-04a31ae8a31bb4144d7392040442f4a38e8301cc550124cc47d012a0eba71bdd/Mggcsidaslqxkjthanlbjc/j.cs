using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

namespace Mggcsidaslqxkjthanlbjc;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class j
{
	private static ResourceManager m_a;

	private static CultureInfo b;

	internal j()
	{
	}

	internal static ResourceManager a()
	{
		if (j.m_a == null)
		{
			j.m_a = new ResourceManager("Mggcsidaslqxkjthanlbjc.Properties.Resources", typeof(j).Assembly);
		}
		return j.m_a;
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
