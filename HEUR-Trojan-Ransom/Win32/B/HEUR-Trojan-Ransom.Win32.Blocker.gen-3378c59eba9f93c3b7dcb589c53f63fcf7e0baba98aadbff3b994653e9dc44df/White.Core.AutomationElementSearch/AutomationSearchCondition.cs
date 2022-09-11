using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Automation;

namespace White.Core.AutomationElementSearch;

public class AutomationSearchCondition
{
	private readonly List<Condition> conditions = new List<Condition>();

	private static readonly Dictionary<string, Func<AutomationElementInformation, object, bool>> valueMatchers;

	public static AutomationSearchCondition All
	{
		get
		{
			AutomationSearchCondition automationSearchCondition = new AutomationSearchCondition();
			automationSearchCondition.conditions.Add(Condition.TrueCondition);
			return automationSearchCondition;
		}
	}

	public virtual Condition Condition
	{
		get
		{
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			if (conditions.Count == 1)
			{
				return conditions[0];
			}
			if (conditions.Count == 0)
			{
				return Condition.TrueCondition;
			}
			return (Condition)new AndCondition(conditions.ToArray());
		}
	}

	static AutomationSearchCondition()
	{
		valueMatchers = new Dictionary<string, Func<AutomationElementInformation, object, bool>>();
		valueMatchers[((AutomationIdentifier)AutomationElement.NameProperty).get_ProgrammaticName()] = (AutomationElementInformation information, object value) => ((AutomationElementInformation)(ref information)).get_Name().Equals(value);
		valueMatchers[((AutomationIdentifier)AutomationElement.AutomationIdProperty).get_ProgrammaticName()] = (AutomationElementInformation information, object value) => ((AutomationElementInformation)(ref information)).get_AutomationId().Equals(value);
		valueMatchers[((AutomationIdentifier)AutomationElement.ClassNameProperty).get_ProgrammaticName()] = (AutomationElementInformation information, object value) => ((AutomationElementInformation)(ref information)).get_ClassName().Equals(value);
		valueMatchers[((AutomationIdentifier)AutomationElement.ProcessIdProperty).get_ProgrammaticName()] = (AutomationElementInformation information, object value) => ((AutomationElementInformation)(ref information)).get_ProcessId().ToString().Equals(value.ToString());
		valueMatchers[((AutomationIdentifier)AutomationElement.ControlTypeProperty).get_ProgrammaticName()] = (AutomationElementInformation information, object value) => ((AutomationIdentifier)((AutomationElementInformation)(ref information)).get_ControlType()).get_Id().Equals(value);
	}

	public AutomationSearchCondition(Condition condition)
	{
		conditions.Add(condition);
	}

	public AutomationSearchCondition()
	{
	}

	public static AutomationSearchCondition ByName(string name)
	{
		AutomationSearchCondition automationSearchCondition = new AutomationSearchCondition();
		automationSearchCondition.OfName(name);
		return automationSearchCondition;
	}

	public virtual AutomationSearchCondition OfName(string name)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		conditions.Add((Condition)new PropertyCondition(AutomationElement.NameProperty, (object)name));
		return this;
	}

	public static AutomationSearchCondition ByAutomationId(string id)
	{
		AutomationSearchCondition automationSearchCondition = new AutomationSearchCondition();
		automationSearchCondition.WithAutomationId(id);
		return automationSearchCondition;
	}

	public virtual AutomationSearchCondition WithAutomationId(string id)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		conditions.Add((Condition)new PropertyCondition(AutomationElement.AutomationIdProperty, (object)id));
		return this;
	}

	public static AutomationSearchCondition ByControlType(ControlType controlType)
	{
		AutomationSearchCondition automationSearchCondition = new AutomationSearchCondition();
		automationSearchCondition.OfControlType(controlType);
		return automationSearchCondition;
	}

	public virtual AutomationSearchCondition OfControlType(ControlType controlType)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		conditions.Add((Condition)new PropertyCondition(AutomationElement.ControlTypeProperty, (object)controlType));
		return this;
	}

	public virtual AutomationSearchCondition WithProcessId(int processId)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		conditions.Add((Condition)new PropertyCondition(AutomationElement.ProcessIdProperty, (object)processId));
		return this;
	}

	public override string ToString()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		StringBuilder stringBuilder = new StringBuilder();
		foreach (PropertyCondition condition in conditions)
		{
			PropertyCondition val = condition;
			stringBuilder.AppendFormat("{0}:{1}", ((AutomationIdentifier)val.get_Property()).get_ProgrammaticName(), val.get_Value());
		}
		return stringBuilder.ToString();
	}

	public static AutomationSearchCondition ByClassName(string className)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		AutomationSearchCondition automationSearchCondition = new AutomationSearchCondition();
		automationSearchCondition.conditions.Add((Condition)new PropertyCondition(AutomationElement.ClassNameProperty, (object)className));
		return automationSearchCondition;
	}

	public static string ToString(AutomationSearchCondition[] conditions)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (AutomationSearchCondition automationSearchCondition in conditions)
		{
			stringBuilder.AppendLine(automationSearchCondition.ToString());
		}
		return stringBuilder.ToString();
	}

	public virtual bool Satisfies(AutomationElement element)
	{
		return Satisfies(element, conditions.ToArray(), and: true);
	}

	private bool Satisfies(AutomationElement element, Condition[] testConditions, bool and)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		while (true)
		{
			if (num < testConditions.Length)
			{
				Condition val = testConditions[num];
				if (!(val is AndCondition) || Satisfies(element, ((AndCondition)val).GetConditions(), and: true))
				{
					if (!(val is OrCondition) || Satisfies(element, ((OrCondition)val).GetConditions(), and: false))
					{
						if (val is PropertyCondition)
						{
							bool flag;
							if (!(flag = valueMatchers[((AutomationIdentifier)((PropertyCondition)val).get_Property()).get_ProgrammaticName()](element.get_Current(), ((PropertyCondition)val).get_Value())) && and)
							{
								return false;
							}
							if (flag && !and)
							{
								break;
							}
						}
						num++;
						continue;
					}
					return false;
				}
				return false;
			}
			return true;
		}
		return true;
	}

	public virtual void Add(Condition condition)
	{
		conditions.Add(condition);
	}

	public static AutomationSearchCondition GetWindowWithTitleBarSearchCondition(int processId)
	{
		return GetWindowSearchCondition(processId, ControlType.Window);
	}

	public static AutomationSearchCondition GetWindowSearchCondition(int processId, ControlType controlType)
	{
		AutomationSearchCondition automationSearchCondition = ByControlType(controlType);
		if (processId > 0)
		{
			automationSearchCondition.WithProcessId(processId);
		}
		return automationSearchCondition;
	}
}
