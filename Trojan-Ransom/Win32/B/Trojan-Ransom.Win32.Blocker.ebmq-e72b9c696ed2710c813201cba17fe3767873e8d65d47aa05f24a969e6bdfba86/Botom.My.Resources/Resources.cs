using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Botom.My.Resources;

[HideModuleName]
[CompilerGenerated]
[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
internal sealed class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			hEeuYJ66RW7EGHxTl1E();
			if (nN1sMs6qoNXQcMSl5P4() || IC0RGI6SupGuSoYAIqK(resourceMan, null))
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("Botom.Resources", eGQytw6CELOBNv7qnwL(typeof(Resources).TypeHandle).Assembly));
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static byte[] A
	{
		get
		{
			object obj = AiBLYG6aXvOaZEJsadG(NaYUDM65QpNDwonbsNF(Sw105o6MCK6UoWme4ol(), "A", resourceCulture));
			return (byte[])obj;
		}
	}

	internal static bool IC0RGI6SupGuSoYAIqK(object object_0, object object_1)
	{
		return object.ReferenceEquals(object_0, object_1);
	}

	internal static Type eGQytw6CELOBNv7qnwL(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static bool hEeuYJ66RW7EGHxTl1E()
	{
		return true;
	}

	internal static bool nN1sMs6qoNXQcMSl5P4()
	{
		return false;
	}

	internal static object Sw105o6MCK6UoWme4ol()
	{
		return ResourceManager;
	}

	internal static object NaYUDM65QpNDwonbsNF(object object_0, object object_1, object object_2)
	{
		return ((ResourceManager)object_0).GetObject((string)object_1, (CultureInfo?)object_2);
	}

	internal static object AiBLYG6aXvOaZEJsadG(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}
}
