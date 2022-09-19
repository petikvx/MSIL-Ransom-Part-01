using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Microsoft.Win32.TaskScheduler;

internal static class XmlSerializationHelper
{
	public delegate bool PropertyConversionHandler(PropertyInfo pi, object obj, ref object value);

	private static object GetDefaultValue(PropertyInfo prop)
	{
		object[] customAttributes = prop.GetCustomAttributes(typeof(DefaultValueAttribute), inherit: true);
		if (customAttributes.Length > 0)
		{
			DefaultValueAttribute defaultValueAttribute = (DefaultValueAttribute)customAttributes[0];
			return defaultValueAttribute.Value;
		}
		if (prop.PropertyType.IsValueType)
		{
			return Activator.CreateInstance(prop.PropertyType);
		}
		return null;
	}

	private static bool GetPropertyValue(object obj, string property, ref object outVal)
	{
		if (obj != null)
		{
			PropertyInfo property2 = obj.GetType().GetProperty(property);
			if ((object)property2 != null)
			{
				outVal = property2.GetValue(obj, null);
				return true;
			}
		}
		return false;
	}

	private static bool GetAttributeValue(Type objType, Type attrType, string property, bool inherit, ref object outVal)
	{
		object[] customAttributes = objType.GetCustomAttributes(attrType, inherit);
		if (customAttributes.Length > 0)
		{
			return GetPropertyValue(customAttributes[0], property, ref outVal);
		}
		return false;
	}

	private static bool GetAttributeValue(PropertyInfo propInfo, Type attrType, string property, bool inherit, ref object outVal)
	{
		Attribute customAttribute = Attribute.GetCustomAttribute(propInfo, attrType, inherit);
		return GetPropertyValue(customAttribute, property, ref outVal);
	}

	private static bool IsStandardType(Type type)
	{
		if (!type.IsPrimitive && (object)type != typeof(DateTime) && (object)type != typeof(DateTimeOffset) && (object)type != typeof(decimal) && (object)type != typeof(Guid) && (object)type != typeof(TimeSpan) && (object)type != typeof(string))
		{
			return type.IsEnum;
		}
		return true;
	}

	private static bool HasMembers(object obj)
	{
		if (obj is IXmlSerializable)
		{
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
				((IXmlSerializable)obj).WriteXml(xmlTextWriter);
				xmlTextWriter.Flush();
				return memoryStream.Length > 0L;
			}
		}
		PropertyInfo[] properties = obj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
		PropertyInfo[] array = properties;
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				PropertyInfo propertyInfo = array[num];
				if (!Attribute.IsDefined(propertyInfo, typeof(XmlIgnoreAttribute), inherit: false))
				{
					object value = propertyInfo.GetValue(obj, null);
					if (!value.Equals(GetDefaultValue(propertyInfo)))
					{
						if (IsStandardType(propertyInfo.PropertyType))
						{
							break;
						}
						if (HasMembers(value))
						{
							return true;
						}
					}
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static string GetPropertyElementName(PropertyInfo pi)
	{
		object outVal = null;
		string result = pi.Name;
		if (GetAttributeValue(pi, typeof(XmlElementAttribute), "ElementName", inherit: false, ref outVal))
		{
			result = outVal.ToString();
		}
		else if (GetAttributeValue(pi.PropertyType, typeof(XmlRootAttribute), "ElementName", inherit: true, ref outVal))
		{
			result = outVal.ToString();
		}
		return result;
	}

	public static bool WriteProperty(XmlWriter writer, PropertyInfo pi, object obj, PropertyConversionHandler handler = null)
	{
		if (Attribute.IsDefined(pi, typeof(XmlIgnoreAttribute), inherit: false))
		{
			return false;
		}
		object value = pi.GetValue(obj, null);
		object defaultValue = GetDefaultValue(pi);
		if ((value == null && defaultValue == null) || (value != null && value.Equals(defaultValue)))
		{
			return false;
		}
		Type type = pi.PropertyType;
		if (handler != null && handler(pi, obj, ref value))
		{
			type = value.GetType();
		}
		bool flag = IsStandardType(type);
		bool flag2 = pi.CanRead && pi.CanWrite;
		if (pi.CanRead)
		{
			_ = pi.CanWrite;
		}
		string propertyElementName = GetPropertyElementName(pi);
		if (flag && flag2)
		{
			string text = null;
			if (type.IsEnum)
			{
				if (Attribute.IsDefined(type, typeof(FlagsAttribute), inherit: false))
				{
					text = Convert.ChangeType(value, Enum.GetUnderlyingType(type))!.ToString();
				}
				else
				{
					text = value.ToString();
				}
			}
			else
			{
				text = type.FullName switch
				{
					"System.Boolean" => XmlConvert.ToString((bool)value), 
					"System.Byte" => XmlConvert.ToString((byte)value), 
					"System.Char" => XmlConvert.ToString((char)value), 
					"System.DateTime" => XmlConvert.ToString((DateTime)value, XmlDateTimeSerializationMode.RoundtripKind), 
					"System.DateTimeOffset" => XmlConvert.ToString((DateTimeOffset)value), 
					"System.Decimal" => XmlConvert.ToString((decimal)value), 
					"System.Double" => XmlConvert.ToString((double)value), 
					"System.Single" => XmlConvert.ToString((float)value), 
					"System.Guid" => XmlConvert.ToString((Guid)value), 
					"System.Int16" => XmlConvert.ToString((short)value), 
					"System.Int32" => XmlConvert.ToString((int)value), 
					"System.Int64" => XmlConvert.ToString((long)value), 
					"System.SByte" => XmlConvert.ToString((sbyte)value), 
					"System.TimeSpan" => XmlConvert.ToString((TimeSpan)value), 
					"System.UInt16" => XmlConvert.ToString((ushort)value), 
					"System.UInt32" => XmlConvert.ToString((uint)value), 
					"System.UInt64" => XmlConvert.ToString((ulong)value), 
					_ => (value == null) ? string.Empty : value.ToString(), 
				};
				if (text != null)
				{
					writer.WriteElementString(propertyElementName, text);
				}
			}
		}
		else if (!flag)
		{
			WriteObject(writer, value);
		}
		return false;
	}

	public static void WriteObjectProperties(XmlWriter writer, object obj, PropertyConversionHandler handler = null)
	{
		PropertyInfo[] properties = obj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
		foreach (PropertyInfo pi in properties)
		{
			WriteProperty(writer, pi, obj, handler);
		}
	}

	public static void WriteObject(XmlWriter writer, object obj, PropertyConversionHandler handler = null)
	{
		if (obj == null)
		{
			return;
		}
		object outVal = null;
		string localName = (GetAttributeValue(obj.GetType(), typeof(XmlRootAttribute), "ElementName", inherit: true, ref outVal) ? outVal.ToString() : obj.GetType().Name);
		string ns = (GetAttributeValue(obj.GetType(), typeof(XmlRootAttribute), "Namespace", inherit: true, ref outVal) ? outVal.ToString() : null);
		if (HasMembers(obj))
		{
			writer.WriteStartElement(localName, ns);
			if (obj is IXmlSerializable)
			{
				((IXmlSerializable)obj).WriteXml(writer);
			}
			else
			{
				WriteObjectProperties(writer, obj, handler);
			}
			writer.WriteEndElement();
		}
	}

	public static void ReadObjectProperties(XmlReader reader, object obj, PropertyConversionHandler handler = null)
	{
		PropertyInfo[] properties = obj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
		Dictionary<string, PropertyInfo> dictionary = new Dictionary<string, PropertyInfo>(properties.Length);
		PropertyInfo[] array = properties;
		foreach (PropertyInfo propertyInfo in array)
		{
			if (!Attribute.IsDefined(propertyInfo, typeof(XmlIgnoreAttribute), inherit: false))
			{
				dictionary.Add(GetPropertyElementName(propertyInfo), propertyInfo);
			}
		}
		while (reader.MoveToContent() == XmlNodeType.Element)
		{
			if (dictionary.TryGetValue(reader.LocalName, out var value))
			{
				if (IsStandardType(value.PropertyType))
				{
					object obj2 = null;
					obj2 = ((!value.PropertyType.IsEnum) ? reader.ReadElementContentAs(value.PropertyType, null) : Enum.Parse(value.PropertyType, reader.ReadElementContentAsString()));
					handler?.Invoke(value, obj, ref obj2);
					value.SetValue(obj, obj2, null);
				}
				else
				{
					ReadObject(reader, value.GetValue(obj, null));
				}
			}
			else
			{
				reader.Skip();
				reader.MoveToContent();
			}
		}
	}

	public static void ReadObject(XmlReader reader, object obj, PropertyConversionHandler handler = null)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		reader.MoveToContent();
		if (obj is IXmlSerializable)
		{
			((IXmlSerializable)obj).ReadXml(reader);
			return;
		}
		object outVal = null;
		string text = (GetAttributeValue(obj.GetType(), typeof(XmlRootAttribute), "ElementName", inherit: true, ref outVal) ? outVal.ToString() : obj.GetType().Name);
		if (reader.LocalName != text)
		{
			throw new XmlException("XML element name does not match object.");
		}
		if (!reader.IsEmptyElement)
		{
			reader.ReadStartElement();
			reader.MoveToContent();
			ReadObjectProperties(reader, obj, handler);
			reader.ReadEndElement();
		}
		else
		{
			reader.Skip();
		}
	}

	public static void ReadObjectFromXmlText(string xml, object obj, PropertyConversionHandler handler = null)
	{
		using StringReader input = new StringReader(xml);
		using XmlReader xmlReader = XmlReader.Create(input);
		xmlReader.MoveToContent();
		ReadObject(xmlReader, obj, handler);
	}

	public static string WriteObjectToXmlText(object obj, PropertyConversionHandler handler = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		using (XmlWriter writer = XmlWriter.Create(stringBuilder, new XmlWriterSettings
		{
			Indent = true
		}))
		{
			WriteObject(writer, obj, handler);
		}
		return stringBuilder.ToString();
	}
}
