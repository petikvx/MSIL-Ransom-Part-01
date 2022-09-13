using System;
using Ionic.Zip;

public class GEventArgs5 : GEventArgs0
{
	private Exception exception_0;

	public Exception Exception_0 => exception_0;

	public string String_1 => base.GClass8_0.String_1;

	private GEventArgs5()
	{
	}

	internal static GEventArgs5 smethod_0(string string_1, GClass8 gclass8_1, Exception exception_1)
	{
		return new GEventArgs5
		{
			ZipProgressEventType_0 = ZipProgressEventType.Error_Saving,
			String_0 = string_1,
			GClass8_0 = gclass8_1,
			exception_0 = exception_1
		};
	}
}
