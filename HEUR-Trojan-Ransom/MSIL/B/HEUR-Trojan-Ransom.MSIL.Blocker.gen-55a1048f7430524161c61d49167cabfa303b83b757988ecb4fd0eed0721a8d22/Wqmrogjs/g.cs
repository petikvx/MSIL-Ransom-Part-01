using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;

namespace Wqmrogjs;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class g
{
	private static ResourceManager m_a;

	private static CultureInfo m_b;

	internal g()
	{
		_ = -1;
		if (2 == 0)
		{
		}
		base._002Ector();
	}

	internal static ResourceManager a()
	{
		if (g.m_a == null)
		{
			ResourceManager resourceManager = new ResourceManager("Wqmrogjs.Properties.Resources", typeof(g).Assembly);
			if (7u != 0)
			{
				g.m_a = resourceManager;
			}
		}
		return g.m_a;
	}

	internal static CultureInfo a()
	{
		return g.m_b;
	}

	internal static void a(CultureInfo a)
	{
		if (8u != 0)
		{
			g.m_b = a;
		}
	}

	internal static string a()
	{
		return g.a().GetString("LU_LMU", g.m_b);
	}

	internal static Bitmap a()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)g.a().GetObject("pepeLaugh", g.m_b);
	}

	internal static Bitmap b()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)g.a().GetObject("TriHard", g.m_b);
	}
}
