using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;

namespace Uzkacndhaisbzdtglfsivlbl;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class e
{
	private static ResourceManager m_a;

	private static CultureInfo m_b;

	internal e()
	{
	}

	internal static ResourceManager a()
	{
		if (e.m_a == null)
		{
			e.m_a = new ResourceManager("Uzkacndhaisbzdtglfsivlbl.Properties.Resources", typeof(e).Assembly);
		}
		return e.m_a;
	}

	internal static CultureInfo a()
	{
		return e.m_b;
	}

	internal static void a(CultureInfo a)
	{
		e.m_b = a;
	}

	internal static Bitmap a()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)e.a().GetObject("PhotoCamera", e.m_b);
	}

	internal static Bitmap b()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)e.a().GetObject("Private_1", e.m_b);
	}

	internal static Bitmap c()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)e.a().GetObject("Private_2", e.m_b);
	}

	internal static Bitmap d()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)e.a().GetObject("Web", e.m_b);
	}
}
