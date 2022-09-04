using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using ns3;
using ns9;

namespace ns10;

internal sealed class Class61
{
	public static Bitmap smethod_0(string string_0)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		Stream manifestResourceStream = default(Stream);
		Bitmap val = default(Bitmap);
		try
		{
			try
			{
				manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Class15.smethod_0(955957) + string_0 + Class15.smethod_0(951460));
				val = ((manifestResourceStream == null) ? ((Bitmap)null) : new Bitmap(manifestResourceStream));
				return val;
			}
			catch
			{
				val = null;
				return val;
			}
		}
		catch (Exception exception_)
		{
			Class38.smethod_3(exception_, manifestResourceStream, val, string_0);
			throw;
		}
	}
}
