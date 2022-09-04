using System.Net;

internal class Class36 : Class34
{
	private string string_0;

	private EndPoint endPoint_0;

	public Class36(string string_1, EndPoint endPoint_1)
	{
		Class51.smethod_0();
		base._002Ector(null);
		string.IsNullOrEmpty(string_1);
		string_0 = string_1;
		endPoint_0 = endPoint_1;
	}

	public override WebRequest vmethod_0(out byte[] byte_0)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://" + endPoint_0.ToString() + string_0);
		httpWebRequest.Headers.Add("ACCEPT-LANGUAGE", "en");
		httpWebRequest.Method = "GET";
		byte_0 = new byte[0];
		return httpWebRequest;
	}
}
