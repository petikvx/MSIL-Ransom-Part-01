using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;

namespace Difnzhwh;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class c
{
	private static ResourceManager m_a;

	private static CultureInfo m_b;

	internal c()
	{
	}

	internal static ResourceManager a()
	{
		if (Difnzhwh.c.m_a == null)
		{
			Difnzhwh.c.m_a = new ResourceManager("Difnzhwh.Properties.Resources", typeof(c).Assembly);
		}
		return Difnzhwh.c.m_a;
	}

	internal static CultureInfo a()
	{
		return Difnzhwh.c.m_b;
	}

	internal static void a(CultureInfo a)
	{
		Difnzhwh.c.m_b = a;
	}

	internal static Bitmap a()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)Difnzhwh.c.a().GetObject("PhotoCamera", Difnzhwh.c.m_b);
	}

	internal static Bitmap b()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)Difnzhwh.c.a().GetObject("Private_1", Difnzhwh.c.m_b);
	}

	internal static Bitmap c()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)Difnzhwh.c.a().GetObject("Private_2", Difnzhwh.c.m_b);
	}

	internal static Bitmap d()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)Difnzhwh.c.a().GetObject("Web", Difnzhwh.c.m_b);
	}
}
