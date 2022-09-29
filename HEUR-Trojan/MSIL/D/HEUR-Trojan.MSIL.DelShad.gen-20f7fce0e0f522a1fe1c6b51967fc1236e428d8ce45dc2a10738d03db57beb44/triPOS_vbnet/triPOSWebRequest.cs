namespace triPOS_vbnet;

public class triPOSWebRequest
{
	private string m_Headers;

	public string Headers
	{
		get
		{
			return m_Headers;
		}
		set
		{
			m_Headers = value;
		}
	}

	public HttpResponseMessage DotriPOSRequest(string json, string url, string developerKey, string developerSecret, string contentType)
	{
		HttpResponseMessage result = default(HttpResponseMessage);
		return result;
	}
}
