using System.Collections.Generic;
using System.Windows.Automation;

namespace White.Core.AutomationElementSearch;

public class ElementSearchResult
{
	private bool many;

	private readonly List<AutomationElement> elements = new List<AutomationElement>();

	public virtual bool AllResultsFound
	{
		get
		{
			if (!many)
			{
				return elements.Count >= 1;
			}
			return false;
		}
	}

	public virtual List<AutomationElement> Elements => elements;

	private ElementSearchResult()
	{
	}

	public static ElementSearchResult ForMany()
	{
		ElementSearchResult elementSearchResult = new ElementSearchResult();
		elementSearchResult.many = true;
		return elementSearchResult;
	}

	public static ElementSearchResult ForOne()
	{
		ElementSearchResult elementSearchResult = new ElementSearchResult();
		elementSearchResult.many = false;
		return elementSearchResult;
	}

	public virtual void Add(AutomationElement element)
	{
		elements.Add(element);
	}
}
