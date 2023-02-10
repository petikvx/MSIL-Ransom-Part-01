using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;

namespace Hvpwtdkzrumtxtcaxpktml;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class h
{
	private static ResourceManager m_a;

	private static CultureInfo m_b;

	internal h()
	{
		_ = 6;
		if (1 == 0)
		{
		}
		base._002Ector();
	}

	internal static ResourceManager a()
	{
		if (h.m_a == null)
		{
			ResourceManager resourceManager = new ResourceManager("Hvpwtdkzrumtxtcaxpktml.Properties.Resources", typeof(h).Assembly);
			if (uint.MaxValue != 0)
			{
				h.m_a = resourceManager;
			}
		}
		return h.m_a;
	}

	internal static CultureInfo a()
	{
		return h.m_b;
	}

	internal static void a(CultureInfo a)
	{
		if (5u != 0)
		{
			h.m_b = a;
		}
	}

	internal static Bitmap a()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)h.a().GetObject("_20_Meow", h.m_b);
	}

	internal static Bitmap b()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)h.a().GetObject("_21_Zip_it", h.m_b);
	}

	internal static Bitmap c()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)h.a().GetObject("_22_Annoyed", h.m_b);
	}

	internal static Bitmap d()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)h.a().GetObject("_23_Please", h.m_b);
	}

	internal static Bitmap e()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)h.a().GetObject("_24_Hay", h.m_b);
	}

	internal static byte[] a()
	{
		return (byte[])h.a().GetObject("basic_link_1", h.m_b);
	}
}
