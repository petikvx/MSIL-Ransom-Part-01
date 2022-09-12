using System;

namespace Gecko.WebIDL;

public class MozNFCTag : WebIDLBase
{
	public NFCTechType[] TechList => GetProperty<NFCTechType[]>("techList");

	public IntPtr Id => GetProperty<IntPtr>("id");

	public NFCTagType Type => GetProperty<NFCTagType>("type");

	public int? MaxNDEFSize => GetProperty<int?>("maxNDEFSize");

	public bool? IsReadOnly => GetProperty<bool?>("isReadOnly");

	public bool? IsFormatable => GetProperty<bool?>("isFormatable");

	public bool? CanBeMadeReadOnly => GetProperty<bool?>("canBeMadeReadOnly");

	public bool IsLost => GetProperty<bool>("isLost");

	public string Session
	{
		get
		{
			return GetProperty<string>("session");
		}
		set
		{
			SetProperty("session", value);
		}
	}

	public MozNFCTag(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports[]> ReadNDEF()
	{
		return CallMethod<Promise<nsISupports[]>>("readNDEF", new object[0]);
	}

	public Promise WriteNDEF(nsISupports[] records)
	{
		return CallMethod<Promise>("writeNDEF", records);
	}

	public Promise MakeReadOnly()
	{
		return CallMethod<Promise>("makeReadOnly", new object[0]);
	}

	public Promise Format()
	{
		return CallMethod<Promise>("format", new object[0]);
	}

	public WebIDLUnion<nsISupports, nsISupports> SelectTech(NFCTechType tech)
	{
		return CallMethod<WebIDLUnion<nsISupports, nsISupports>>("selectTech", new object[1] { tech });
	}

	public void NotifyLost()
	{
		CallVoidMethod("notifyLost");
	}

	public Promise<IntPtr> Transceive(NFCTechType tech, IntPtr command)
	{
		return CallMethod<Promise<IntPtr>>("transceive", new object[2] { tech, command });
	}
}
