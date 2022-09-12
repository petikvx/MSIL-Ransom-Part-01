using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Atsthjjfumvdxjgbafdfm.Properties;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal class Resources
{
	private static ResourceManager dispatcher;

	private static CultureInfo _Reg;

	private static Resources ListFacade;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (dispatcher != null)
			{
				goto IL_0057;
			}
			int num = 2;
			if (_003CModule_003E_007B3d727352_002D7f25_002D48af_002D8725_002Df05974804181_007D.m_d1e931ba3fdf4964853b7e7e307c9e70.m_34dd61b9ba834e3cb9a3946671a2ce74 != 0)
			{
				goto IL_001e;
			}
			goto IL_0070;
			IL_0070:
			ResourceManager result = default(ResourceManager);
			return result;
			IL_0057:
			result = dispatcher;
			num = 0;
			if (_003CModule_003E_007B3d727352_002D7f25_002D48af_002D8725_002Df05974804181_007D.m_d1e931ba3fdf4964853b7e7e307c9e70.m_139f1deda80b4cba89d4df0556a2442f != 0)
			{
				goto IL_001e;
			}
			goto IL_0070;
			IL_001e:
			ResourceManager resourceManager = default(ResourceManager);
			switch (num)
			{
			case 2:
				resourceManager = new ResourceManager("Atsthjjfumvdxjgbafdfm.Properties.Resources", VisitFacade(typeof(Resources).TypeHandle).Assembly);
				goto case 3;
			case 3:
				dispatcher = resourceManager;
				goto IL_0057;
			}
			goto IL_0070;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return _Reg;
		}
		set
		{
			_Reg = value;
		}
	}

	internal Resources()
	{
	}

	internal static bool DeleteFacade()
	{
		return ListFacade == null;
	}

	internal static Resources AssetFacade()
	{
		return ListFacade;
	}

	internal static Type VisitFacade(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
