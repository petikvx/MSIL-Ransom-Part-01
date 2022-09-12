namespace Gecko;

public class GeckoResponse
{
	private nsIChannel Channel;

	private nsIHttpChannel HttpChannel;

	public string ContentType => (Channel == null) ? null : nsString.Get(Channel.GetContentTypeAttribute);

	public string ContentCharset => (Channel == null) ? null : nsString.Get(Channel.GetContentCharsetAttribute);

	public long ContentLength => (Channel == null) ? (-1L) : Channel.GetContentLengthAttribute();

	public string HttpRequestMethod => (HttpChannel == null) ? null : nsString.Get(HttpChannel.GetRequestMethodAttribute);

	public bool HttpRequestSucceeded => HttpChannel == null || HttpChannel.GetRequestSucceededAttribute();

	public int HttpResponseStatus => (int)((HttpChannel != null) ? HttpChannel.GetResponseStatusAttribute() : 0);

	public string HttpResponseStatusText => (HttpChannel == null) ? null : nsString.Get(HttpChannel.GetResponseStatusTextAttribute);

	internal GeckoResponse(nsIRequest request)
	{
		Channel = Xpcom.QueryInterface<nsIChannel>(request);
		HttpChannel = Xpcom.QueryInterface<nsIHttpChannel>(request);
	}
}
