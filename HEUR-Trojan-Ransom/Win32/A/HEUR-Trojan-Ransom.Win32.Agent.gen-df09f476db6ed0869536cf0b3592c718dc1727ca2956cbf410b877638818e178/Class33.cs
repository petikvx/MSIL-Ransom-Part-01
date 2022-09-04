using System.Text;

internal static class Class33
{
	public static byte[] smethod_0()
	{
		string s = "M-SEARCH * HTTP/1.1\r\nHOST: 239.255.255.250:1900\r\nMAN: \"ssdp:discover\"\r\nMX: 3\r\nST: ssdp:all\r\n\r\n";
		return Encoding.ASCII.GetBytes(s);
	}
}
