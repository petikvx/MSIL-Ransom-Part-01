namespace Gecko.WebIDL;

public class BluetoothMapRequestHandle : WebIDLBase
{
	public BluetoothMapRequestHandle(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise ReplyToFolderListing(int masId, string folders)
	{
		return CallMethod<Promise>("replyToFolderListing", new object[2] { masId, folders });
	}

	public Promise ReplyToMessagesListing(int masId, nsIDOMBlob messageslisting, bool newmessage, string timestamp, uint size)
	{
		return CallMethod<Promise>("replyToMessagesListing", new object[5] { masId, messageslisting, newmessage, timestamp, size });
	}

	public Promise ReplyToGetMessage(int masId, nsIDOMBlob bmessage)
	{
		return CallMethod<Promise>("replyToGetMessage", new object[2] { masId, bmessage });
	}

	public Promise ReplyToSetMessageStatus(int masId, bool status)
	{
		return CallMethod<Promise>("replyToSetMessageStatus", new object[2] { masId, status });
	}

	public Promise ReplyToSendMessage(int masId, string handleId, bool status)
	{
		return CallMethod<Promise>("replyToSendMessage", new object[3] { masId, handleId, status });
	}

	public Promise ReplyToMessageUpdate(int masId, bool status)
	{
		return CallMethod<Promise>("replyToMessageUpdate", new object[2] { masId, status });
	}
}
