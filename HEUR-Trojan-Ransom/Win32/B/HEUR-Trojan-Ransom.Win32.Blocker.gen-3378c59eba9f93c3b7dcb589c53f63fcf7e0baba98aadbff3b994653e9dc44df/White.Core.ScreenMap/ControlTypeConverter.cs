using System;
using System.Reflection;
using System.Windows.Automation;
using System.Xml;
using Xstream.Core;

namespace White.Core.ScreenMap;

public class ControlTypeConverter : IConverter
{
	private const string controlTypeAlias = "controlType";

	private static readonly Type type = typeof(ControlType);

	public virtual void Register(IMarshalContext context)
	{
		context.RegisterConverter(type, (IConverter)(object)this);
		context.Alias("controlType", type);
	}

	public virtual void ToXml(object value, FieldInfo field, XmlTextWriter xml, IMarshalContext context)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		context.WriteStartTag(type, field, xml);
		xml.WriteString(((AutomationIdentifier)(ControlType)value).get_Id().ToString());
		context.WriteEndTag(type, field, xml);
	}

	public virtual object FromXml(object parent, FieldInfo field, Type type, XmlNode xml, IMarshalContext context)
	{
		int num = int.Parse(xml.InnerText);
		return ControlType.LookupById(num);
	}
}
