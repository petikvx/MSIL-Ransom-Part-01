using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp21.Properties;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal class Resources
{
	private static ResourceManager m_Adapter;

	private static CultureInfo rule;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (m_Adapter == null)
			{
				ResourceManager resourceManager = (m_Adapter = new ResourceManager("WindowsFormsApp21.Properties.Resources", typeof(Resources).Assembly));
			}
			return m_Adapter;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return rule;
		}
		set
		{
			rule = value;
		}
	}

	internal static byte[] Pateorjiciuekihq
	{
		get
		{
			object @object = ResourceManager.GetObject("Pateorjiciuekihq", rule);
			return (byte[])@object;
		}
	}

	internal Resources()
	{
	}
}
