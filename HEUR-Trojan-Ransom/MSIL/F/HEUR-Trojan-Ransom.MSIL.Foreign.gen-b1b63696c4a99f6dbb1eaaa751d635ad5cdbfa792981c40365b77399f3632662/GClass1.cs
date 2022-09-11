using System;
using EtNRnthSIEgQKrrHDHYiOMzAhqLo.Properties;

public class GClass1
{
	protected static byte[] byte_0;

	protected static byte[] byte_1;

	static GClass1()
	{
		DateTime dateTime = new DateTime(2019, 3, 1);
		if ((DateTime.Now - dateTime).TotalDays > 0.0)
		{
			throw new InvalidOperationException();
		}
		byte_0 = Resources.Byte_0;
		byte_1 = new byte[12]
		{
			111, 80, 79, 71, 33, 71, 94, 107, 49, 57,
			109, 111
		};
	}
}
