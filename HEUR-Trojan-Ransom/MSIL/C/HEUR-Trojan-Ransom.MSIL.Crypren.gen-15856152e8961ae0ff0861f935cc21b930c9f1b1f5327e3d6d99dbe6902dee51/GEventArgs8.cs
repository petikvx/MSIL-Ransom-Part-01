using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
[Guid("802FCEF7-E1D3-4205-B171-87A3724E85FA")]
public sealed class GEventArgs8 : GEventArgs4
{
	[CompilerGenerated]
	private DateTime dateTime_0;

	internal const string string_1 = "touch";

	public DateTime DateTime_0
	{
		[CompilerGenerated]
		get
		{
			return dateTime_0;
		}
		[CompilerGenerated]
		private set
		{
			dateTime_0 = value;
		}
	}

	private GEventArgs8()
	{
	}

	internal static GEventArgs8 smethod_2(Class27 class27_0)
	{
		GEventArgs8 gEventArgs = Delegate542.smethod_0();
		Class28 @class = Delegate35.smethod_0(class27_0);
		try
		{
			string s = default(string);
			while (Delegate43.smethod_0(@class, (Enum10)0) ? true : false)
			{
				if (Delegate36.smethod_0(@class, "filename", ref s) || 1 == 0)
				{
					Delegate37.smethod_0(gEventArgs, s);
				}
				else if (Delegate36.smethod_0(@class, "modification", ref s) || 1 == 0)
				{
					Delegate543.smethod_0(gEventArgs, XmlConvert.ToDateTime(s, XmlDateTimeSerializationMode.Local));
				}
				else if (Delegate40.smethod_0(@class) || 1 == 0)
				{
					Delegate42.smethod_0(gEventArgs, Delegate41.smethod_0(@class));
				}
			}
			return gEventArgs;
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}
}
