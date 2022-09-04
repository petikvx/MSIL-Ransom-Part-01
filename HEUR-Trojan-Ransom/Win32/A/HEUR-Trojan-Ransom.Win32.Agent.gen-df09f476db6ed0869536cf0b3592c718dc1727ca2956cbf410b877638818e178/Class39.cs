using System.Net;

internal class Class39 : Class34
{
	public Class39(GClass1 gclass1_1)
	{
		Class51.smethod_0();
		base._002Ector(gclass1_1);
	}

	public override WebRequest vmethod_0(out byte[] byte_0)
	{
		return method_0("GetExternalIPAddress", string.Empty, out byte_0);
	}
}
