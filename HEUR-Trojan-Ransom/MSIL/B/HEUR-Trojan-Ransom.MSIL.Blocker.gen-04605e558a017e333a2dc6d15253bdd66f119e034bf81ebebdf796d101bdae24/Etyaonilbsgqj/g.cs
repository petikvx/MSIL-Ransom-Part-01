using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;

namespace Etyaonilbsgqj;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class g
{
	private static ResourceManager m_a;

	private static CultureInfo m_b;

	internal g()
	{
		_ = -1;
		if (-1 == 0)
		{
		}
		base._002Ector();
	}

	internal static ResourceManager a()
	{
		if (g.m_a == null)
		{
			ResourceManager resourceManager = new ResourceManager("Etyaonilbsgqj.Properties.Resources", typeof(g).Assembly);
			if (4u != 0)
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
		if (3u != 0)
		{
			g.m_b = a;
		}
	}

	internal static Bitmap a()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)g.a().GetObject("_20_Meow", g.m_b);
	}

	internal static Bitmap b()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)g.a().GetObject("_21_Zip_it", g.m_b);
	}

	internal static Bitmap c()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)g.a().GetObject("_22_Annoyed", g.m_b);
	}

	internal static Bitmap d()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)g.a().GetObject("_23_Please", g.m_b);
	}

	internal static Bitmap e()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)g.a().GetObject("_24_Hay", g.m_b);
	}

	internal static byte[] a()
	{
		return (byte[])g.a().GetObject("basic_link_1", g.m_b);
	}
}
