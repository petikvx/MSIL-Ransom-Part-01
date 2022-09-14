using Microsoft.VisualBasic.CompilerServices;

namespace com.daudus;

public class ArchiProperty
{
	private string pID;

	private string pKey;

	private string pValue;

	private string pGUIDEA;

	private int pTagValueIDEA;

	public string ID
	{
		get
		{
			return pID;
		}
		set
		{
			pID = value;
		}
	}

	public string Key
	{
		get
		{
			return pKey;
		}
		set
		{
			pKey = value;
		}
	}

	public string Value
	{
		get
		{
			return pValue;
		}
		set
		{
			pValue = value;
		}
	}

	public string GUIDEA
	{
		get
		{
			return pGUIDEA;
		}
		set
		{
			pGUIDEA = value;
		}
	}

	public string TagValueIDEA
	{
		get
		{
			return Conversions.ToString(pTagValueIDEA);
		}
		set
		{
			pTagValueIDEA = Conversions.ToInteger(value);
		}
	}

	public ArchiProperty(string ID, string Key, string Value)
	{
		pID = ID;
		pKey = Key;
		pValue = Value;
	}
}
