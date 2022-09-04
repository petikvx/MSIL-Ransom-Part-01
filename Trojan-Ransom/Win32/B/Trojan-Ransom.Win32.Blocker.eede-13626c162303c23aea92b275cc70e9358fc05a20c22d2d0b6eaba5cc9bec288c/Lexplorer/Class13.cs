using System;
using System.Collections.Generic;
using System.Xml;

namespace Lexplorer;

internal abstract class Class13
{
	public delegate bool ExecutionMethodDelegate(Class10 propertyBag, bool forced);

	private const string NODE_ATTRIBUTE_COMMAND = "C";

	private const string NODE_ATTRIBUTE_METHOD = "E";

	protected const string NODE_ATTRIBUTE_SET = "S";

	protected const string NODE_ATTRIBUTE_VALUE = "V";

	protected const string NODE_ATTRIBUTE_DELAY = "D";

	protected const string NODE_ATTRIBUTE_PRIVATE_MODE_ON_OFF = "P";

	private static Dictionary<string, Type> scriptCommandDictionary;

	protected Dictionary<string, ExecutionMethodDelegate> methodTable = new Dictionary<string, ExecutionMethodDelegate>();

	public string ExecutionMethodName { get; set; }

	public Class10 PropertyBag { get; set; }

	static Class13()
	{
		scriptCommandDictionary = new Dictionary<string, Type>();
		scriptCommandDictionary.Add("DELAY", typeof(Class15));
		scriptCommandDictionary.Add("SCREEN", typeof(Class21));
		scriptCommandDictionary.Add("BROWSER", typeof(Class14));
		scriptCommandDictionary.Add("MOUSE", typeof(Class20));
		scriptCommandDictionary.Add("KEYBOARD", typeof(Class17));
		scriptCommandDictionary.Add("LANGUAGE", typeof(Class18));
		scriptCommandDictionary.Add("SOUND", typeof(Class22));
		scriptCommandDictionary.Add("REPEAT", typeof(Class19));
		scriptCommandDictionary.Add("ENDREPEAT", typeof(Class16));
		scriptCommandDictionary.Add("REQUEST", typeof(ScriptCommandRequest));
	}

	public bool Execute(bool forced)
	{
		return methodTable[ExecutionMethodName.ToUpper()](PropertyBag, forced);
	}

	public static Class13 GetNewCommand(string name)
	{
		if (!scriptCommandDictionary.ContainsKey(name))
		{
			throw new ArgumentException($"Unknown command \"{name}\"");
		}
		return (Class13)Activator.CreateInstance(scriptCommandDictionary[name]);
	}

	public static Class13 ReadCommand(XmlNode node)
	{
		if (node.Attributes == null)
		{
			throw new ArgumentException("The node has no attributes. Couldn't create an object.");
		}
		XmlAttribute xmlAttribute = node.Attributes!["C"];
		if (xmlAttribute == null)
		{
			throw new ArgumentException(string.Format("The node has no \"{0}\" attribute."));
		}
		string value = xmlAttribute.Value;
		xmlAttribute = node.Attributes!["E"];
		string empty = string.Empty;
		if (xmlAttribute == null)
		{
			if (value.ToUpper() != "REPEAT" && value.ToUpper() != "ENDREPEAT")
			{
				throw new ArgumentException(string.Format("The node has no \"{0}\" attribute."));
			}
			empty = "EXECUTE";
		}
		else
		{
			empty = xmlAttribute.Value;
		}
		Class13 newCommand = GetNewCommand(value.ToUpper());
		newCommand.ExecutionMethodName = empty;
		newCommand.PropertyBag = GetProperties(node);
		return newCommand;
	}

	protected static Class10 GetProperties(XmlNode node)
	{
		Class10 @class = new Class10();
		foreach (XmlAttribute item in node.Attributes!)
		{
			if (item.Name != "C" && item.Name != "E")
			{
				@class.Add(item.Name, item.Value);
			}
		}
		return @class;
	}

	public override string ToString()
	{
		return "Abstract script command.";
	}
}
