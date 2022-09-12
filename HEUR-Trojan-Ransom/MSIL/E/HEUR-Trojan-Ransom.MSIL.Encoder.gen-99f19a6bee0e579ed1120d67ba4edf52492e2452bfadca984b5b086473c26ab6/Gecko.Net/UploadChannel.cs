using Gecko.IO;
using Gecko.Interop;

namespace Gecko.Net;

public sealed class UploadChannel
{
	private ComPtr<nsIUploadChannel> _uploadChannel;

	private nsIUploadChannel2 _uploadChannel2;

	public InputStream UploadStream => _uploadChannel.Instance.GetUploadStreamAttribute().Wrap(InputStream.Create);

	public bool UploadStreamHasHeaders => _uploadChannel2.GetUploadStreamHasHeadersAttribute();

	internal UploadChannel(nsIUploadChannel uploadChannel)
	{
		_uploadChannel = new ComPtr<nsIUploadChannel>(uploadChannel);
		_uploadChannel2 = (nsIUploadChannel2)uploadChannel;
	}

	public void SetUploadStream(InputStream stream, string contentType, long len)
	{
		nsString.Set(_uploadChannel.Instance.SetUploadStream, stream._inputStream, contentType, len);
	}

	public void ExplicitSetUploadStream(InputStream stream, string contentType, int len, string method, bool streamHasHeaders)
	{
		using nsACString aContentType = new nsACString(contentType);
		using nsACString aMethod = new nsACString(method);
		_uploadChannel2.ExplicitSetUploadStream(stream._inputStream, aContentType, len, aMethod, streamHasHeaders);
	}
}
