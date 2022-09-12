using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;

namespace Kvpbvpfa;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class l
{
	private static ResourceManager m_a;

	private static CultureInfo m_b;

	internal l()
	{
	}

	internal static ResourceManager a()
	{
		if (l.m_a == null)
		{
			l.m_a = new ResourceManager("Kvpbvpfa.Properties.Resources", typeof(l).Assembly);
		}
		return l.m_a;
	}

	internal static CultureInfo a()
	{
		return l.m_b;
	}

	internal static void a(CultureInfo a)
	{
		l.m_b = a;
	}

	internal static Bitmap a()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)l.a().GetObject("_20_Meow", l.m_b);
	}

	internal static Bitmap b()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)l.a().GetObject("_21_Zip_it", l.m_b);
	}

	internal static Bitmap c()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)l.a().GetObject("_22_Annoyed", l.m_b);
	}

	internal static Bitmap d()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)l.a().GetObject("_23_Please", l.m_b);
	}

	internal static Bitmap e()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)l.a().GetObject("_24_Hay", l.m_b);
	}

	internal static byte[] a()
	{
		return (byte[])l.a().GetObject("basic_link_1", l.m_b);
	}
}
