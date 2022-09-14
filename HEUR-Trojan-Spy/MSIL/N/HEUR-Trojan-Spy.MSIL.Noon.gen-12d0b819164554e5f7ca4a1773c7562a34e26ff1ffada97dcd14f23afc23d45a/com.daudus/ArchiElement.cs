using Microsoft.VisualBasic.CompilerServices;

namespace com.daudus;

public class ArchiElement
{
	private string pID;

	private string pType;

	private string pName;

	private string pDocumentation;

	private string pGUIDEA;

	private int pElementIDEA;

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

	public string Type
	{
		get
		{
			return pType;
		}
		set
		{
			pType = value;
		}
	}

	public string Name
	{
		get
		{
			return pName;
		}
		set
		{
			pName = value;
		}
	}

	public string Documentation
	{
		get
		{
			return pDocumentation;
		}
		set
		{
			pDocumentation = value;
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

	public string ElementIDEA
	{
		get
		{
			return Conversions.ToString(pElementIDEA);
		}
		set
		{
			pElementIDEA = Conversions.ToInteger(value);
		}
	}

	public ArchiElement(string ID, string Type, string Name, string Documentation)
	{
		pID = ID;
		pType = Type;
		pName = Name;
		pDocumentation = Documentation;
	}

	public string[] toStringArray()
	{
		return new string[4] { ID, Type, Name, Documentation };
	}
}
