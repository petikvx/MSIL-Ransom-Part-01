using Microsoft.VisualBasic.CompilerServices;

namespace com.daudus;

public class ArchiRelation
{
	private string pID;

	private string pType;

	private string pName;

	private string pDocumentation;

	private string pSource;

	private string pTarget;

	private string pGUIDEA;

	private int pRelationIDEA;

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

	public string Source
	{
		get
		{
			return pSource;
		}
		set
		{
			pSource = value;
		}
	}

	public string Target
	{
		get
		{
			return pTarget;
		}
		set
		{
			pTarget = value;
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

	public string RelationIDEA
	{
		get
		{
			return Conversions.ToString(pRelationIDEA);
		}
		set
		{
			pRelationIDEA = Conversions.ToInteger(value);
		}
	}

	public ArchiRelation(string ID, string Type, string Name, string Documentation, string Source, string Target)
	{
		pID = ID;
		pType = Type;
		pName = Name;
		pDocumentation = Documentation;
		pSource = Source;
		pTarget = Target;
	}
}
