using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;

namespace Aoqokdrczyacbwbdmvoylntk;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class f
{
	private static ResourceManager m_a;

	private static CultureInfo m_b;

	internal f()
	{
		_ = 4;
		if (7 == 0)
		{
		}
		base._002Ector();
	}

	internal static ResourceManager a()
	{
		if (f.m_a == null)
		{
			ResourceManager resourceManager = new ResourceManager("Aoqokdrczyacbwbdmvoylntk.Properties.Resources", typeof(f).Assembly);
			if (3u != 0)
			{
				f.m_a = resourceManager;
			}
		}
		return f.m_a;
	}

	internal static CultureInfo a()
	{
		return f.m_b;
	}

	internal static void a(CultureInfo a)
	{
		if (7u != 0)
		{
			f.m_b = a;
		}
	}

	internal static Bitmap a()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)f.a().GetObject("_20_Meow", f.m_b);
	}

	internal static Bitmap b()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)f.a().GetObject("_21_Zip_it", f.m_b);
	}

	internal static Bitmap c()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)f.a().GetObject("_22_Annoyed", f.m_b);
	}

	internal static Bitmap d()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)f.a().GetObject("_23_Please", f.m_b);
	}

	internal static Bitmap e()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)f.a().GetObject("_24_Hay", f.m_b);
	}

	internal static byte[] a()
	{
		return (byte[])f.a().GetObject("basic_link_1", f.m_b);
	}
}
