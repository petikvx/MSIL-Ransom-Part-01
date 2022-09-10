using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[HideModuleName]
[StandardModule]
[CompilerGenerated]
internal sealed class Class6
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			bool flag = default(bool);
			ResourceManager object_ = default(ResourceManager);
			ResourceManager resourceManager = default(ResourceManager);
			try
			{
				if (flag = Delegate39.smethod_0(resourceManager_0, null))
				{
					object_ = (resourceManager_0 = Delegate54.smethod_0("RunIt.Resources", Delegate7.smethod_0(Delegate11.smethod_0(typeof(Class6).TypeHandle))));
				}
				resourceManager = resourceManager_0;
				return resourceManager;
			}
			catch (Exception exception_)
			{
				Class9.smethod_27(exception_, resourceManager, object_, flag);
				throw;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			CultureInfo cultureInfo = default(CultureInfo);
			try
			{
				cultureInfo = cultureInfo_0;
				return cultureInfo;
			}
			catch (Exception exception_)
			{
				Class9.smethod_25(exception_, cultureInfo);
				throw;
			}
		}
		set
		{
			try
			{
				cultureInfo_0 = value;
			}
			catch (Exception exception_)
			{
				Class9.smethod_25(exception_, value);
				throw;
			}
		}
	}

	internal static byte[] clean
	{
		get
		{
			object obj = default(object);
			byte[] array = default(byte[]);
			try
			{
				obj = Delegate26.smethod_0(Delegate31.smethod_0(Delegate118.smethod_0(), "clean", cultureInfo_0));
				array = (byte[])obj;
				return array;
			}
			catch (Exception exception_)
			{
				Class9.smethod_26(exception_, array, obj);
				throw;
			}
		}
	}
}
