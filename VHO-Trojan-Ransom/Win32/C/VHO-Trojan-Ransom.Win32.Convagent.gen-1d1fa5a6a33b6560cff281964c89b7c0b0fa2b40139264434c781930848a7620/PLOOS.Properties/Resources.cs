using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace PLOOS.Properties;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
internal class Resources
{
	private static ResourceManager HHefekiqh;

	private static CultureInfo oaEHEn46A;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager YpL0CNG66
	{
		get
		{
			aE6xwa8WRpXctl0GE4();
			if (sAALRFcQSEw7QcsFhW() || sLtdWjXR0XJMxvw9lH(HHefekiqh, null))
			{
				ResourceManager resourceManager = (HHefekiqh = new ResourceManager("PLOOS.Properties.Resources", vI1lJvY8KJSbqJBlLA(typeof(Resources).TypeHandle).Assembly));
			}
			return HHefekiqh;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo wIpWOnGrv
	{
		get
		{
			return oaEHEn46A;
		}
		set
		{
			oaEHEn46A = value;
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal Resources()
	{
		e0ekY3v1Vdsec9XATa(this);
	}

	internal static void e0ekY3v1Vdsec9XATa(object object_0)
	{
		object_0._002Ector();
	}

	internal static bool sLtdWjXR0XJMxvw9lH(object object_0, object object_1)
	{
		return object.ReferenceEquals(object_0, object_1);
	}

	internal static Type vI1lJvY8KJSbqJBlLA(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static bool aE6xwa8WRpXctl0GE4()
	{
		return true;
	}

	internal static bool sAALRFcQSEw7QcsFhW()
	{
		return false;
	}
}
