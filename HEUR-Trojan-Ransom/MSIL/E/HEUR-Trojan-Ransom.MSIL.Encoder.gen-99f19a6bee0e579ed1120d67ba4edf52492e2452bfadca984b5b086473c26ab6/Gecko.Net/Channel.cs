using System;
using Gecko.IO;

namespace Gecko.Net;

public class Channel : Request
{
	private nsIChannel _channel;

	public Uri OriginalUri
	{
		get
		{
			return Xpcom.TranslateUriAttribute(_channel.GetOriginalURIAttribute);
		}
		set
		{
			_channel.SetOriginalURIAttribute(IOService.CreateNsIUri(value.ToString()));
		}
	}

	public Uri Uri => Xpcom.TranslateUriAttribute(_channel.GetURIAttribute);

	public nsISupports Owner
	{
		get
		{
			return _channel.GetOwnerAttribute();
		}
		set
		{
			_channel.SetOwnerAttribute(value);
		}
	}

	public nsIInterfaceRequestor NotificationCallbacks
	{
		get
		{
			return _channel.GetNotificationCallbacksAttribute();
		}
		set
		{
			_channel.SetNotificationCallbacksAttribute(value);
		}
	}

	public nsISupports SecurityInfo => _channel.GetSecurityInfoAttribute();

	public string ContentType
	{
		get
		{
			return nsString.Get(_channel.GetContentTypeAttribute);
		}
		set
		{
			nsString.Set(_channel.SetContentTypeAttribute, value);
		}
	}

	public string ContentCharset
	{
		get
		{
			return nsString.Get(_channel.GetContentCharsetAttribute);
		}
		set
		{
			nsString.Set(_channel.SetContentCharsetAttribute, value);
		}
	}

	public long ContentLength
	{
		get
		{
			return _channel.GetContentLengthAttribute();
		}
		set
		{
			_channel.SetContentLengthAttribute(value);
		}
	}

	public uint ContentDisposition => _channel.GetContentDispositionAttribute();

	public string ContentDispositionFilename => nsString.Get(_channel.GetContentDispositionFilenameAttribute);

	public string ContentDispositionHeader => nsString.Get(_channel.GetContentDispositionHeaderAttribute);

	protected Channel(nsIChannel channel)
		: base(channel)
	{
		_channel = channel;
	}

	public static Channel CreateChannel(nsIChannel channel)
	{
		if (channel is nsIHttpChannel)
		{
			return new HttpChannel((nsIHttpChannel)channel);
		}
		if (!(channel is nsIJARChannel))
		{
		}
		if (!(channel is nsIViewSourceChannel))
		{
		}
		if (!(channel is nsIWyciwygChannel))
		{
		}
		return new Channel(channel);
	}

	public InputStream Open()
	{
		return InputStream.Create(_channel.Open());
	}
}
