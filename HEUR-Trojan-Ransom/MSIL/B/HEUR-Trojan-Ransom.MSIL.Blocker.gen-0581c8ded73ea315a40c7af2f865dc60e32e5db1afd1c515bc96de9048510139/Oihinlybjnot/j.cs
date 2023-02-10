using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;

namespace Oihinlybjnot;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class j
{
	private static ResourceManager m_a;

	private static CultureInfo m_b;

	internal j()
	{
		_ = 7;
		if (7 == 0)
		{
		}
		base._002Ector();
	}

	internal static ResourceManager a()
	{
		if (j.m_a == null)
		{
			ResourceManager resourceManager = new ResourceManager("Oihinlybjnot.Properties.Resources", typeof(j).Assembly);
			if (7u != 0)
			{
				j.m_a = resourceManager;
			}
		}
		return j.m_a;
	}

	internal static CultureInfo a()
	{
		return j.m_b;
	}

	internal static void a(CultureInfo a)
	{
		if (uint.MaxValue != 0)
		{
			j.m_b = a;
		}
	}

	internal static Bitmap a()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)j.a().GetObject("_20_Meow", j.m_b);
	}

	internal static Bitmap b()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)j.a().GetObject("_21_Zip_it", j.m_b);
	}

	internal static Bitmap c()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)j.a().GetObject("_22_Annoyed", j.m_b);
	}

	internal static Bitmap d()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)j.a().GetObject("_23_Please", j.m_b);
	}

	internal static Bitmap e()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)j.a().GetObject("_24_Hay", j.m_b);
	}

	internal static byte[] a()
	{
		return (byte[])j.a().GetObject("basic_link_1", j.m_b);
	}
}
