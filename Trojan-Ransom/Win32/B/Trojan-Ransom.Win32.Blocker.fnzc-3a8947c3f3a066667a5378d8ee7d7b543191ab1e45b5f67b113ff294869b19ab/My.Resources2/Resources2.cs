using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Security;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;
using ns0;

namespace My.Resources2;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class Resources2
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			ResourceManager o = default(ResourceManager);
			try
			{
				if (UsageReportSender.smethod_6(resourceManager_0, null, 138, 152))
				{
					o = (resourceManager_0 = new ResourceManager("bankingcal.Resources", Class21.smethod_3(Class26.smethod_1(typeof(Resources2).TypeHandle, 658, 694), 903, 965)));
				}
				return resourceManager_0;
			}
			catch (Exception exception)
			{
				ResourceManager o2 = default(ResourceManager);
				StackFrameHelper.CreateException2(exception, o2, o);
				throw;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			try
			{
				return cultureInfo_0;
			}
			catch (Exception exception)
			{
				CultureInfo o = default(CultureInfo);
				StackFrameHelper.CreateException1(exception, o);
				throw;
			}
		}
		set
		{
			try
			{
				cultureInfo_0 = value;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, value);
				throw;
			}
		}
	}

	[SecuritySafeCritical]
	static Resources2()
	{
		Class32.smethod_1();
	}
}
