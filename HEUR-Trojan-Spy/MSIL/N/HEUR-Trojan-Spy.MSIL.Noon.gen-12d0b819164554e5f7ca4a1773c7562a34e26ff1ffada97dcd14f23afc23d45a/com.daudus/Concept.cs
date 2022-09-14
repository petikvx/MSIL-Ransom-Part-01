using Microsoft.VisualBasic.CompilerServices;

namespace com.daudus;

internal class Concept
{
	private string pConceptDescription;

	private string pConceptName;

	private string pConceptType;

	private string pApplication;

	public string Application
	{
		get
		{
			return pApplication;
		}
		set
		{
			pApplication = value;
		}
	}

	public object ConceptName
	{
		get
		{
			return pConceptName;
		}
		set
		{
			pConceptName = Conversions.ToString(value);
		}
	}

	public object ConceptType
	{
		get
		{
			return pConceptType;
		}
		set
		{
			pConceptType = Conversions.ToString(value);
		}
	}

	public object ConceptDescription
	{
		get
		{
			return pConceptDescription;
		}
		set
		{
			pConceptDescription = Conversions.ToString(value);
		}
	}

	public Concept(string ConceptName, string ConceptType, string ConceptDescription, string application)
	{
		pConceptDescription = ConceptDescription;
		pConceptName = ConceptName;
		pConceptType = ConceptType;
		pApplication = application;
	}
}
