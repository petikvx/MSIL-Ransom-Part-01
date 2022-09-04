using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns0;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
internal sealed class Class7
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
				if (!(flag = !object.ReferenceEquals(resourceManager_0, null)))
				{
					object_ = (resourceManager_0 = new ResourceManager("ns0.Class7", typeof(Class7).Assembly));
				}
				resourceManager = resourceManager_0;
				return resourceManager;
			}
			catch (Exception exception_)
			{
				Class9.smethod_23(exception_, object_, resourceManager, flag);
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
				Class9.smethod_21(exception_, cultureInfo);
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
				Class9.smethod_21(exception_, value);
				throw;
			}
		}
	}

	internal static string String1
	{
		get
		{
			string @string = default(string);
			try
			{
				@string = ResourceManager.GetString("String1", cultureInfo_0);
				return @string;
			}
			catch (Exception exception_)
			{
				Class9.smethod_21(exception_, @string);
				throw;
			}
		}
	}

	internal Class7()
	{
	}
}
