using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Mini.My.Resources;

[CompilerGenerated]
[StandardModule]
[HideModuleName]
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
			_ = 0;
			bool flag = default(bool);
			if (m4n2Q8wFRmui9rLQENM())
			{
				flag = htaSFbwVO84ovUPFhxi(resourceMan, null);
			}
			if (flag)
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("Mini.Resources", N9kdbIwvED2NYGITNyB(typeof(Resources).TypeHandle).Assembly));
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

	internal static bool htaSFbwVO84ovUPFhxi(object object_0, object object_1)
	{
		return object.ReferenceEquals(object_0, object_1);
	}

	internal static Type N9kdbIwvED2NYGITNyB(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static bool m4n2Q8wFRmui9rLQENM()
	{
		return true;
	}

	internal static bool ap6AOCwqAlj6ScK4Ett()
	{
		return false;
	}
}
