namespace Gecko.WebIDL;

public class MozIcc : WebIDLBase
{
	public WebIDLUnion<nsISupports, nsISupports, nsISupports> IccInfo => GetProperty<WebIDLUnion<nsISupports, nsISupports, nsISupports>>("iccInfo");

	public IccCardState CardState => GetProperty<IccCardState>("cardState");

	public MozIcc(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void SendStkResponse(object command, object response)
	{
		CallVoidMethod("sendStkResponse", command, response);
	}

	public void SendStkMenuSelection(ushort itemIdentifier, bool helpRequested)
	{
		CallVoidMethod("sendStkMenuSelection", itemIdentifier, helpRequested);
	}

	public void SendStkTimerExpiration(object timer)
	{
		CallVoidMethod("sendStkTimerExpiration", timer);
	}

	public void SendStkEventDownload(object @event)
	{
		CallVoidMethod("sendStkEventDownload", @event);
	}

	public nsISupports GetCardLock(IccLockType lockType)
	{
		return CallMethod<nsISupports>("getCardLock", new object[1] { lockType });
	}

	public nsISupports UnlockCardLock()
	{
		return CallMethod<nsISupports>("unlockCardLock", new object[0]);
	}

	public nsISupports UnlockCardLock(object info)
	{
		return CallMethod<nsISupports>("unlockCardLock", new object[1] { info });
	}

	public nsISupports SetCardLock()
	{
		return CallMethod<nsISupports>("setCardLock", new object[0]);
	}

	public nsISupports SetCardLock(object info)
	{
		return CallMethod<nsISupports>("setCardLock", new object[1] { info });
	}

	public nsISupports GetCardLockRetryCount(IccLockType lockType)
	{
		return CallMethod<nsISupports>("getCardLockRetryCount", new object[1] { lockType });
	}

	public nsISupports ReadContacts(IccContactType contactType)
	{
		return CallMethod<nsISupports>("readContacts", new object[1] { contactType });
	}

	public nsISupports UpdateContact(IccContactType contactType, nsISupports contact)
	{
		return CallMethod<nsISupports>("updateContact", new object[2] { contactType, contact });
	}

	public nsISupports UpdateContact(IccContactType contactType, nsISupports contact, string pin2)
	{
		return CallMethod<nsISupports>("updateContact", new object[3] { contactType, contact, pin2 });
	}

	public nsISupports MatchMvno(IccMvnoType mvnoType, string matchData)
	{
		return CallMethod<nsISupports>("matchMvno", new object[2] { mvnoType, matchData });
	}

	public Promise<bool> GetServiceState(IccService service)
	{
		return CallMethod<Promise<bool>>("getServiceState", new object[1] { service });
	}
}
