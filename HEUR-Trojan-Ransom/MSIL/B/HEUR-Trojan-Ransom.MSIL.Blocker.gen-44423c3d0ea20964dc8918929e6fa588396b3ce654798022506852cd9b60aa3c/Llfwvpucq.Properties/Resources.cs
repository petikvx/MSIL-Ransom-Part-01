using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Llfwvpucq.Properties;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal class Resources
{
	private static ResourceManager m_Base;

	private static CultureInfo m_Advisor;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (m_Base == null)
			{
				m_Base = new ResourceManager("Llfwvpucq.Properties.Resources", typeof(Resources).Assembly);
			}
			return m_Base;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return m_Advisor;
		}
		set
		{
			m_Advisor = value;
		}
	}

	internal static byte[] file_sample_150kB => (byte[])ResourceManager.GetObject("file_sample_150kB", m_Advisor);

	internal Resources()
	{
	}
}
