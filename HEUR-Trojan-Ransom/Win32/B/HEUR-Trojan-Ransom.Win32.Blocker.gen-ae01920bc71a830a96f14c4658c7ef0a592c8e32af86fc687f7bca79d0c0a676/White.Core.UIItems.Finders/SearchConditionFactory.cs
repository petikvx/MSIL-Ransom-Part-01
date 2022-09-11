using System;
using System.Windows.Automation;
using White.Core.Mappings;
using White.Core.UIItems.Custom;

namespace White.Core.UIItems.Finders;

public static class SearchConditionFactory
{
	public static SimpleSearchCondition CreateForControlType(ControlType controlType)
	{
		return new SimpleSearchCondition(delegate(AutomationElement automationElement)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			AutomationElementInformation current = automationElement.get_Current();
			return ((AutomationElementInformation)(ref current)).get_ControlType();
		}, new ControlTypeProperty(controlType, "ControlType"));
	}

	public static SimpleSearchCondition CreateForControlType(Type testControlType)
	{
		ControlType controlType = (testControlType.IsCustomType() ? CustomControlTypeMapping.ControlType(testControlType) : ControlDictionary.Instance.GetControlType(testControlType));
		return CreateForControlType(controlType);
	}

	public static SimpleSearchCondition CreateForControlType(Type testControlType, string frameworkId)
	{
		ControlType controlType = (testControlType.IsCustomType() ? CustomControlTypeMapping.ControlType(testControlType) : ControlDictionary.Instance.GetControlType(testControlType, frameworkId));
		return CreateForControlType(controlType);
	}

	public static SearchCondition CreateForFrameworkId(string frameworkId)
	{
		return new SimpleSearchCondition(delegate(AutomationElement automationElement)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			AutomationElementInformation current = automationElement.get_Current();
			return ((AutomationElementInformation)(ref current)).get_FrameworkId();
		}, new AutomationElementProperty(frameworkId, "FrameworkId", AutomationElement.FrameworkIdProperty));
	}

	public static SearchCondition CreateForAutomationId(string id)
	{
		return new SimpleSearchCondition(delegate(AutomationElement automationElement)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			AutomationElementInformation current = automationElement.get_Current();
			return ((AutomationElementInformation)(ref current)).get_AutomationId();
		}, new AutomationElementProperty(id, "AutomationId", AutomationElement.AutomationIdProperty));
	}

	public static SearchCondition CreateForName(string name)
	{
		return new SimpleSearchCondition(delegate(AutomationElement automationElement)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			AutomationElementInformation current = automationElement.get_Current();
			return ((AutomationElementInformation)(ref current)).get_Name();
		}, new AutomationElementProperty(name, "Name", AutomationElement.NameProperty));
	}

	public static SearchCondition CreateForClassName(string className)
	{
		return new SimpleSearchCondition(delegate(AutomationElement automationElement)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			AutomationElementInformation current = automationElement.get_Current();
			return ((AutomationElementInformation)(ref current)).get_ClassName();
		}, new AutomationElementProperty(className, "ClassName", AutomationElement.ClassNameProperty));
	}

	public static SearchCondition CreateForNativeProperty(AutomationProperty automationProperty, string value)
	{
		AutomationElementProperty automationElementProperty = new AutomationElementProperty(value, ((AutomationIdentifier)automationProperty).get_ProgrammaticName(), automationProperty);
		return new SimpleSearchCondition((AutomationElement automationElement) => automationElement.GetCurrentPropertyValue(automationProperty), automationElementProperty);
	}

	public static SearchCondition CreateForNativeProperty(AutomationProperty automationProperty, bool value)
	{
		AutomationElementProperty automationElementProperty = new AutomationElementProperty(value, ((AutomationIdentifier)automationProperty).get_ProgrammaticName(), automationProperty);
		return new SimpleSearchCondition((AutomationElement automationElement) => automationElement.GetCurrentPropertyValue(automationProperty), automationElementProperty);
	}
}
