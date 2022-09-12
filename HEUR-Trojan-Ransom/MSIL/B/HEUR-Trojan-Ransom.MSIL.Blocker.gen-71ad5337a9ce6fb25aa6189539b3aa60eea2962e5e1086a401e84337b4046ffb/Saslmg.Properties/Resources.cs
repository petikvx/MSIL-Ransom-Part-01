using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Saslmg.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager m_Val;

	private static CultureInfo _Token;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (m_Val == null)
			{
				ResourceManager resourceManager = (m_Val = new ResourceManager("Saslmg.Properties.Resources", typeof(Resources).Assembly));
			}
			return m_Val;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return _Token;
		}
		set
		{
			_Token = value;
		}
	}

	internal static byte[] Koahpsxuujlptp
	{
		get
		{
			object @object = ResourceManager.GetObject("Koahpsxuujlptp", _Token);
			return (byte[])@object;
		}
	}

	internal Resources()
	{
	}
}
