using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Zbawmbnkfyxecxwmbji.Properties;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal class Resources
{
	private static ResourceManager _Wrapper;

	private static CultureInfo _Visitor;

	private static Resources ReadThread;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			while (_Wrapper == null)
			{
				if (_003CModule_003E_007Bd068f09c_002D2c3d_002D4560_002Dba52_002Dc616a3f74e5e_007D.m_fca50798d9d744b995043644a9f68814 == 0)
				{
					switch (0)
					{
					case 1:
						continue;
					}
				}
				_Wrapper = new ResourceManager("Zbawmbnkfyxecxwmbji.Properties.Resources", typeof(Resources).Assembly);
				break;
			}
			return _Wrapper;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return _Visitor;
		}
		set
		{
			_Visitor = value;
		}
	}

	internal static byte[] Yurrvynnpzxmiozcprgtey => (byte[])ResourceManager.GetObject("Yurrvynnpzxmiozcprgtey", _Visitor);

	internal Resources()
	{
	}

	internal static bool FillThread()
	{
		return ReadThread == null;
	}

	internal static Resources SortThread()
	{
		return ReadThread;
	}
}
