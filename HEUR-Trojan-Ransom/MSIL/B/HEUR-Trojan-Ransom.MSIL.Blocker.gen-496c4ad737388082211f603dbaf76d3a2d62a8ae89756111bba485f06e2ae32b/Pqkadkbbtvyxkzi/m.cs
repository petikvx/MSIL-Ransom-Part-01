using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;

namespace Pqkadkbbtvyxkzi;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class m
{
	private static ResourceManager m_a;

	private static CultureInfo m_b;

	internal m()
	{
		_ = 4;
		if (false)
		{
		}
		base._002Ector();
	}

	internal static ResourceManager a()
	{
		if (m.m_a == null)
		{
			ResourceManager resourceManager = new ResourceManager("Pqkadkbbtvyxkzi.Properties.Resources", typeof(m).Assembly);
			if (8u != 0)
			{
				m.m_a = resourceManager;
			}
		}
		return m.m_a;
	}

	internal static CultureInfo a()
	{
		return m.m_b;
	}

	internal static void a(CultureInfo a)
	{
		if (true)
		{
			m.m_b = a;
		}
	}

	internal static Bitmap a()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)m.a().GetObject("_20_Meow", m.m_b);
	}

	internal static Bitmap b()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)m.a().GetObject("_21_Zip_it", m.m_b);
	}

	internal static Bitmap c()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)m.a().GetObject("_22_Annoyed", m.m_b);
	}

	internal static Bitmap d()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)m.a().GetObject("_23_Please", m.m_b);
	}

	internal static Bitmap e()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)m.a().GetObject("_24_Hay", m.m_b);
	}

	internal static byte[] a()
	{
		return (byte[])m.a().GetObject("basic_link_1", m.m_b);
	}
}
