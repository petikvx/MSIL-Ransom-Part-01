namespace Gecko.DOM;

public class DomCharacterData : GeckoNode
{
	private nsIDOMCharacterData _domCharacterData;

	public string Data
	{
		get
		{
			return nsString.Get(_domCharacterData.GetDataAttribute);
		}
		set
		{
			nsString.Set(_domCharacterData.SetDataAttribute, value);
		}
	}

	public uint Length => _domCharacterData.GetLengthAttribute();

	internal DomCharacterData(nsIDOMCharacterData domCharacterData)
		: base(domCharacterData)
	{
		_domCharacterData = domCharacterData;
	}

	public string SubstringData(uint offset, uint count)
	{
		return nsString.Get(_domCharacterData.SubstringData, offset, count);
	}

	public void AppendData(string arg)
	{
		nsString.Set(_domCharacterData.AppendData, arg);
	}

	public void InsertData(uint offset, string arg)
	{
		nsString.Set(_domCharacterData.InsertData, offset, arg);
	}

	public void DeleteData(uint offset, uint count)
	{
		_domCharacterData.DeleteData(offset, count);
	}

	public void ReplaceData(uint offset, uint count, string arg)
	{
		nsString.Set(_domCharacterData.ReplaceData, offset, count, arg);
	}
}
