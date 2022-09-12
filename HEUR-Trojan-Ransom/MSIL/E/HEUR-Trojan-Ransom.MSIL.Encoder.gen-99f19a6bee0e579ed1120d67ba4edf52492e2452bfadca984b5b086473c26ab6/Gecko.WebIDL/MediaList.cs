namespace Gecko.WebIDL;

public class MediaList : WebIDLBase
{
	public string MediaText
	{
		get
		{
			return GetProperty<string>("mediaText");
		}
		set
		{
			SetProperty("mediaText", value);
		}
	}

	public uint Length => GetProperty<uint>("length");

	public MediaList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void DeleteMedium(string oldMedium)
	{
		CallVoidMethod("deleteMedium", oldMedium);
	}

	public void AppendMedium(string newMedium)
	{
		CallVoidMethod("appendMedium", newMedium);
	}
}
