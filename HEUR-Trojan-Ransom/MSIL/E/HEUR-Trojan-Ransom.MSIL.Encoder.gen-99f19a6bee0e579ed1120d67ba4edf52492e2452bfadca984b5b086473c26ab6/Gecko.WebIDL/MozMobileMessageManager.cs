namespace Gecko.WebIDL;

public class MozMobileMessageManager : WebIDLBase
{
	public MozMobileMessageManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetSegmentInfoForText(string text)
	{
		return CallMethod<nsISupports>("getSegmentInfoForText", new object[1] { text });
	}

	public nsISupports Send(string number, string text)
	{
		return CallMethod<nsISupports>("send", new object[2] { number, text });
	}

	public nsISupports Send(string number, string text, object sendParameters)
	{
		return CallMethod<nsISupports>("send", new object[3] { number, text, sendParameters });
	}

	public nsISupports[] Send(string[] numbers, string text)
	{
		return CallMethod<nsISupports[]>("send", new object[2] { numbers, text });
	}

	public nsISupports[] Send(string[] numbers, string text, object sendParameters)
	{
		return CallMethod<nsISupports[]>("send", new object[3] { numbers, text, sendParameters });
	}

	public nsISupports SendMMS()
	{
		return CallMethod<nsISupports>("sendMMS", new object[0]);
	}

	public nsISupports SendMMS(object parameters)
	{
		return CallMethod<nsISupports>("sendMMS", new object[1] { parameters });
	}

	public nsISupports SendMMS(object parameters, object sendParameters)
	{
		return CallMethod<nsISupports>("sendMMS", new object[2] { parameters, sendParameters });
	}

	public nsISupports GetMessage(int id)
	{
		return CallMethod<nsISupports>("getMessage", new object[1] { id });
	}

	public nsISupports Delete(int id)
	{
		return CallMethod<nsISupports>("delete", new object[1] { id });
	}

	public nsISupports Delete(nsISupports message)
	{
		return CallMethod<nsISupports>("delete", new object[1] { message });
	}

	public nsISupports Delete(WebIDLUnion<int, nsISupports, nsISupports> @params)
	{
		return CallMethod<nsISupports>("delete", new object[1] { @params });
	}

	public nsISupports GetMessages()
	{
		return CallMethod<nsISupports>("getMessages", new object[0]);
	}

	public nsISupports GetMessages(object filter)
	{
		return CallMethod<nsISupports>("getMessages", new object[1] { filter });
	}

	public nsISupports GetMessages(object filter, bool reverse)
	{
		return CallMethod<nsISupports>("getMessages", new object[2] { filter, reverse });
	}

	public nsISupports MarkMessageRead(int id, bool read)
	{
		return CallMethod<nsISupports>("markMessageRead", new object[2] { id, read });
	}

	public nsISupports MarkMessageRead(int id, bool read, bool sendReadReport)
	{
		return CallMethod<nsISupports>("markMessageRead", new object[3] { id, read, sendReadReport });
	}

	public nsISupports GetThreads()
	{
		return CallMethod<nsISupports>("getThreads", new object[0]);
	}

	public nsISupports RetrieveMMS(int id)
	{
		return CallMethod<nsISupports>("retrieveMMS", new object[1] { id });
	}

	public nsISupports RetrieveMMS(nsISupports message)
	{
		return CallMethod<nsISupports>("retrieveMMS", new object[1] { message });
	}

	public Promise<object> GetSmscAddress()
	{
		return CallMethod<Promise<object>>("getSmscAddress", new object[0]);
	}

	public Promise<object> GetSmscAddress(uint serviceId)
	{
		return CallMethod<Promise<object>>("getSmscAddress", new object[1] { serviceId });
	}

	public Promise SetSmscAddress()
	{
		return CallMethod<Promise>("setSmscAddress", new object[0]);
	}

	public Promise SetSmscAddress(object smscAddress)
	{
		return CallMethod<Promise>("setSmscAddress", new object[1] { smscAddress });
	}

	public Promise SetSmscAddress(object smscAddress, uint serviceId)
	{
		return CallMethod<Promise>("setSmscAddress", new object[2] { smscAddress, serviceId });
	}
}
