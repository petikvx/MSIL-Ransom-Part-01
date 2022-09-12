using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;

namespace Mimcegcptnenxtzt;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class g
{
	private static ResourceManager m_a;

	private static CultureInfo m_b;

	internal g()
	{
	}

	internal static ResourceManager a()
	{
		if (g.m_a == null)
		{
			g.m_a = new ResourceManager("Mimcegcptnenxtzt.Properties.Resources", typeof(g).Assembly);
		}
		return g.m_a;
	}

	internal static CultureInfo a()
	{
		return g.m_b;
	}

	internal static void a(CultureInfo a)
	{
		g.m_b = a;
	}

	internal static Bitmap a()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)g.a().GetObject("PhotoCamera", g.m_b);
	}

	internal static Bitmap b()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)g.a().GetObject("Private_1", g.m_b);
	}

	internal static Bitmap c()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)g.a().GetObject("Private_2", g.m_b);
	}

	internal static Bitmap d()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)g.a().GetObject("Web", g.m_b);
	}
}
