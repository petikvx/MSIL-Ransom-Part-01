namespace Gecko.Net;

public class BaseHttpActivityObserver : nsIHttpActivityObserver
{
	internal bool _isRegistered;

	void nsIHttpActivityObserver.ObserveActivity(nsISupports httpChannel, uint activityType, uint activitySubtype, long timestamp, ulong extraSizeData, nsACStringBase extraStringData)
	{
		switch (activityType)
		{
		case 2u:
			HttpTransaction(httpChannel, activitySubtype, timestamp, extraSizeData, extraStringData);
			break;
		case 1u:
			SocketTransport(httpChannel, activitySubtype, timestamp, extraSizeData, extraStringData);
			break;
		}
	}

	protected virtual void SocketTransport(nsISupports httpChannel, uint activitySubtype, long timestamp, ulong extraSizeData, nsACStringBase extraStringData)
	{
	}

	protected virtual void HttpTransaction(nsISupports httpChannel, uint activitySubtype, long timestamp, ulong extraSizeData, nsACStringBase extraStringData)
	{
	}

	bool nsIHttpActivityObserver.GetIsActiveAttribute()
	{
		return true;
	}
}
