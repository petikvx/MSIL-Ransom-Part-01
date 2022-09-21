using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;

namespace Stihcpdaboumyasclt.Exceptions;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal sealed class StubModelException
{
	private static ResourceManager m_Adapter;

	private static CultureInfo m_Attribute;

	internal StubModelException()
	{
	}

	internal static ResourceManager PublishInitializer()
	{
		if (m_Adapter == null)
		{
			m_Adapter = new ResourceManager("Stihcpdaboumyasclt.Properties.Resources", typeof(StubModelException).Assembly);
		}
		return m_Adapter;
	}

	internal static CultureInfo DefineInitializer()
	{
		return m_Attribute;
	}

	internal static void CloneInitializer(CultureInfo value)
	{
		m_Attribute = value;
	}

	internal static Bitmap IncludeInitializer()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)PublishInitializer().GetObject("_20_Meow", m_Attribute);
	}

	internal static Bitmap MoveInitializer()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)PublishInitializer().GetObject("_21_Zip_it", m_Attribute);
	}

	internal static Bitmap OrderInitializer()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)PublishInitializer().GetObject("_22_Annoyed", m_Attribute);
	}

	internal static Bitmap RemoveInitializer()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)PublishInitializer().GetObject("Bitcoin_svg", m_Attribute);
	}

	internal static Bitmap DestroyInitializer()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)PublishInitializer().GetObject("settings_32__1_", m_Attribute);
	}
}
