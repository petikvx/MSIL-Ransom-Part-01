using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;

namespace Yntmgnmjwxmbnwlr;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class k
{
	private static ResourceManager m_a;

	private static CultureInfo m_b;

	internal k()
	{
	}

	internal static ResourceManager a()
	{
		if (k.m_a == null)
		{
			k.m_a = new ResourceManager("Yntmgnmjwxmbnwlr.Properties.Resources", typeof(k).Assembly);
		}
		return k.m_a;
	}

	internal static CultureInfo a()
	{
		return k.m_b;
	}

	internal static void a(CultureInfo a)
	{
		k.m_b = a;
	}

	internal static Bitmap a()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)k.a().GetObject("venezuela_48x48_33138", k.m_b);
	}

	internal static Bitmap b()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)k.a().GetObject("vietnam_48x48_33148", k.m_b);
	}

	internal static Bitmap c()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)k.a().GetObject("virgin_48x48_33147", k.m_b);
	}

	internal static Bitmap d()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)k.a().GetObject("virgin_48x48_33149", k.m_b);
	}

	internal static Bitmap e()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)k.a().GetObject("wales_48x48_33158", k.m_b);
	}

	internal static Bitmap f()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)k.a().GetObject("wallis_48x48_33144", k.m_b);
	}

	internal static Bitmap g()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)k.a().GetObject("western_48x48_33139", k.m_b);
	}

	internal static Bitmap h()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)k.a().GetObject("yemen_48x48_33143", k.m_b);
	}

	internal static Bitmap i()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)k.a().GetObject("zambia_48x48_33146", k.m_b);
	}

	internal static Bitmap j()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)k.a().GetObject("zimbabwe_48x48_33150", k.m_b);
	}
}
