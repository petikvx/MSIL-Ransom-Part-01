namespace Gecko.WebIDL;

public class DataTransfer : WebIDLBase
{
	public string DropEffect
	{
		get
		{
			return GetProperty<string>("dropEffect");
		}
		set
		{
			SetProperty("dropEffect", value);
		}
	}

	public string EffectAllowed
	{
		get
		{
			return GetProperty<string>("effectAllowed");
		}
		set
		{
			SetProperty("effectAllowed", value);
		}
	}

	public nsISupports Types => GetProperty<nsISupports>("types");

	public nsISupports Files => GetProperty<nsISupports>("files");

	public uint MozItemCount => GetProperty<uint>("mozItemCount");

	public string MozCursor
	{
		get
		{
			return GetProperty<string>("mozCursor");
		}
		set
		{
			SetProperty("mozCursor", value);
		}
	}

	public bool MozUserCancelled => GetProperty<bool>("mozUserCancelled");

	public nsIDOMNode MozSourceNode => GetProperty<nsIDOMNode>("mozSourceNode");

	public DataTransfer(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void SetDragImage(nsIDOMElement image, int x, int y)
	{
		CallVoidMethod("setDragImage", image, x, y);
	}

	public string GetData(string format)
	{
		return CallMethod<string>("getData", new object[1] { format });
	}

	public void SetData(string format, string data)
	{
		CallVoidMethod("setData", format, data);
	}

	public void ClearData()
	{
		CallVoidMethod("clearData");
	}

	public void ClearData(string format)
	{
		CallVoidMethod("clearData", format);
	}

	public Promise<WebIDLUnion<nsISupports, nsISupports>> GetFilesAndDirectories()
	{
		return CallMethod<Promise<WebIDLUnion<nsISupports, nsISupports>>>("getFilesAndDirectories", new object[0]);
	}

	public void AddElement(nsIDOMElement element)
	{
		CallVoidMethod("addElement", element);
	}

	public nsISupports MozTypesAt(uint index)
	{
		return CallMethod<nsISupports>("mozTypesAt", new object[1] { index });
	}

	public void MozClearDataAt(string format, uint index)
	{
		CallVoidMethod("mozClearDataAt", format, index);
	}

	public void MozSetDataAt(string format, object data, uint index)
	{
		CallVoidMethod("mozSetDataAt", format, data, index);
	}

	public object MozGetDataAt(string format, uint index)
	{
		return CallMethod<object>("mozGetDataAt", new object[2] { format, index });
	}
}
