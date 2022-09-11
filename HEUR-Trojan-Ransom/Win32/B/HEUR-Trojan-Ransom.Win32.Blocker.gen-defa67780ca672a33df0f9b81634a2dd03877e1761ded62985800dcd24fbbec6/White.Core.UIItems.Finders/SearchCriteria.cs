using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.UIItems.Custom;
using White.Core.UIItems.WindowStripControls;

namespace White.Core.UIItems.Finders;

public class SearchCriteria
{
	private readonly SearchConditions conditions = new SearchConditions();

	private IndexCondition indexCondition = IndexCondition.NotSpecified;

	private Type customItemType;

	public static SearchCriteria All => new SearchCriteria();

	internal virtual Condition AutomationCondition => conditions.AutomationCondition;

	public virtual bool IsIndexed => indexCondition != IndexCondition.NotSpecified;

	public virtual Type CustomItemType => customItemType;

	internal virtual AutomationSearchCondition AutomationSearchCondition
	{
		get
		{
			AutomationSearchCondition automationSearchCondition = new AutomationSearchCondition();
			foreach (SearchCondition condition in conditions)
			{
				Condition automationCondition = condition.AutomationCondition;
				if (automationCondition != null)
				{
					automationSearchCondition.Add(automationCondition);
				}
			}
			return automationSearchCondition;
		}
	}

	private SearchCriteria()
	{
	}

	private SearchCriteria(SearchCondition searchCondition)
	{
		conditions.Add(searchCondition);
	}

	private SearchCriteria(IndexCondition searchCondition)
	{
		conditions.Add(searchCondition);
		indexCondition = searchCondition;
	}

	public static SearchCriteria ByText(string text)
	{
		return new SearchCriteria(SearchConditionFactory.CreateForName(text));
	}

	public static SearchCriteria Indexed(int zeroBasedIndex)
	{
		IndexCondition searchCondition = new IndexCondition(zeroBasedIndex);
		return new SearchCriteria(searchCondition);
	}

	public static SearchCriteria ByAutomationId(string identification)
	{
		return new SearchCriteria(SearchConditionFactory.CreateForAutomationId(identification));
	}

	public static SearchCriteria ByFramework(string framework)
	{
		return new SearchCriteria(SearchConditionFactory.CreateForFrameworkId(framework));
	}

	public static SearchCriteria ByControlType(ControlType controlType)
	{
		return new SearchCriteria(SearchConditionFactory.CreateForControlType(controlType));
	}

	public static SearchCriteria ByNativeProperty(AutomationProperty automationProperty, string value)
	{
		return new SearchCriteria(SearchConditionFactory.CreateForNativeProperty(automationProperty, value));
	}

	public static SearchCriteria ByNativeProperty(AutomationProperty automationProperty, bool value)
	{
		return new SearchCriteria(SearchConditionFactory.CreateForNativeProperty(automationProperty, value));
	}

	public static SearchCriteria ByControlType(Type testControlType)
	{
		SearchCriteria searchCriteria = new SearchCriteria(SearchConditionFactory.CreateForControlType(testControlType));
		searchCriteria.InferCustomItemType(testControlType);
		return searchCriteria;
	}

	internal virtual Condition AutomationConditionWith(PropertyCondition propertyCondition)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		Condition automationCondition = conditions.AutomationCondition;
		return (Condition)new AndCondition((Condition[])(object)new Condition[2]
		{
			automationCondition,
			(Condition)propertyCondition
		});
	}

	public virtual SearchCriteria AndIndex(int zeroBasedIndex)
	{
		indexCondition = new IndexCondition(zeroBasedIndex);
		conditions.Add(indexCondition);
		return this;
	}

	public virtual SearchCriteria AndByText(string text)
	{
		conditions.Insert(0, SearchConditionFactory.CreateForName(text));
		return this;
	}

	public virtual SearchCriteria AndOfFramework(string frameworkId)
	{
		conditions.Insert(0, SearchConditionFactory.CreateForFrameworkId(frameworkId));
		return this;
	}

	public virtual SearchCriteria NotIdentifiedByText(string name)
	{
		conditions.Insert(0, new NotCondition(SearchConditionFactory.CreateForName(name)));
		return this;
	}

	public virtual SearchCriteria AndControlType(Type testControlType)
	{
		InferCustomItemType(testControlType);
		conditions.Insert(0, SearchConditionFactory.CreateForControlType(testControlType));
		return this;
	}

	public virtual SearchCriteria AndControlType(ControlType controlType)
	{
		conditions.Insert(0, SearchConditionFactory.CreateForControlType(controlType));
		return this;
	}

	public virtual SearchCriteria AndAutomationId(string id)
	{
		conditions.Insert(0, SearchConditionFactory.CreateForAutomationId(id));
		return this;
	}

	public virtual SearchCriteria AndNativeProperty(AutomationProperty automationProperty, string value)
	{
		conditions.Insert(0, SearchConditionFactory.CreateForNativeProperty(automationProperty, value));
		return this;
	}

	public virtual SearchCriteria AndNativeProperty(AutomationProperty automationProperty, bool value)
	{
		conditions.Insert(0, SearchConditionFactory.CreateForNativeProperty(automationProperty, value));
		return this;
	}

	public virtual List<AutomationElement> Filter(List<AutomationElement> automationElements)
	{
		return conditions.Filter(automationElements);
	}

	public virtual IUIItem IndexedItem(UIItemCollection collection)
	{
		return indexCondition.Filter(collection);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(conditions.ToString());
		return stringBuilder.ToString();
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (!(obj is SearchCriteria searchCriteria))
		{
			return false;
		}
		foreach (SearchCondition condition in conditions)
		{
			if (!searchCriteria.conditions.Contains(condition))
			{
				return false;
			}
		}
		return indexCondition.Equals(searchCriteria.indexCondition);
	}

	public override int GetHashCode()
	{
		int num = 0;
		foreach (SearchCondition condition in conditions)
		{
			num += condition.GetHashCode();
		}
		return indexCondition.GetHashCode() + num;
	}

	public virtual bool AppliesTo(AutomationElement automationElement)
	{
		foreach (SearchCondition condition in conditions)
		{
			if (!condition.AppliesTo(automationElement))
			{
				return false;
			}
		}
		return true;
	}

	private void InferCustomItemType(Type testControlType)
	{
		customItemType = (typeof(CustomUIItem).IsAssignableFrom(testControlType) ? testControlType : null);
	}

	internal static SearchCriteria ForMenuBar(WindowsFramework framework)
	{
		SearchCriteria searchCriteria = new SearchCriteria(SearchConditionFactory.CreateForControlType(typeof(MenuBar), framework.ToString()));
		return searchCriteria.NotIdentifiedByText("System Menu Bar");
	}

	public virtual SearchCriteria Merge(SearchCriteria other)
	{
		SearchCondition searchCondition;
		foreach (SearchCondition condition in other.conditions)
		{
			searchCondition = condition;
			if (!conditions.Any((SearchCondition condition) => condition.OfSameType(searchCondition)))
			{
				conditions.Add(searchCondition);
			}
		}
		return this;
	}
}
