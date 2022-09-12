using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;

namespace Nysykwahqkpmeddn;

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
		if (Nysykwahqkpmeddn.c.m_a == null)
		{
			Nysykwahqkpmeddn.c.m_a = new ResourceManager("Nysykwahqkpmeddn.Properties.Resources", typeof(c).Assembly);
		}
		return Nysykwahqkpmeddn.c.m_a;
	}

	internal static CultureInfo a()
	{
		return Nysykwahqkpmeddn.c.m_b;
	}

	internal static void a(CultureInfo a)
	{
		Nysykwahqkpmeddn.c.m_b = a;
	}

	internal static Bitmap a()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)Nysykwahqkpmeddn.c.a().GetObject("PhotoCamera", Nysykwahqkpmeddn.c.m_b);
	}

	internal static Bitmap b()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)Nysykwahqkpmeddn.c.a().GetObject("Private_1", Nysykwahqkpmeddn.c.m_b);
	}

	internal static Bitmap c()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)Nysykwahqkpmeddn.c.a().GetObject("Private_2", Nysykwahqkpmeddn.c.m_b);
	}

	internal static Bitmap d()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)Nysykwahqkpmeddn.c.a().GetObject("Web", Nysykwahqkpmeddn.c.m_b);
	}
}
