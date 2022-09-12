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

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
[HideModuleName]
[StandardModule]
internal sealed class Class19
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
				if (flag = object.ReferenceEquals(resourceManager_0, null))
				{
					object_ = (resourceManager_0 = new ResourceManager("WindowsApplication1.Resources", typeof(Class19).Assembly));
				}
				resourceManager = resourceManager_0;
				return resourceManager;
			}
			catch (Exception exception_)
			{
				Class11.smethod_24(exception_, resourceManager, object_, flag);
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
				Class11.smethod_22(exception_, cultureInfo);
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
				Class11.smethod_22(exception_, value);
				throw;
			}
		}
	}
}
