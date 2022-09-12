namespace Gecko.WebIDL;

public class CharacterData : WebIDLBase
{
	public string Data
	{
		get
		{
			return GetProperty<string>("data");
		}
		set
		{
			SetProperty("data", value);
		}
	}

	public uint Length => GetProperty<uint>("length");

	public CharacterData(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public string SubstringData(uint offset, uint count)
	{
		return CallMethod<string>("substringData", new object[2] { offset, count });
	}

	public void AppendData(string data)
	{
		CallVoidMethod("appendData", data);
	}

	public void InsertData(uint offset, string data)
	{
		CallVoidMethod("insertData", offset, data);
	}

	public void DeleteData(uint offset, uint count)
	{
		CallVoidMethod("deleteData", offset, count);
	}

	public void ReplaceData(uint offset, uint count, string data)
	{
		CallVoidMethod("replaceData", offset, count, data);
	}
}
