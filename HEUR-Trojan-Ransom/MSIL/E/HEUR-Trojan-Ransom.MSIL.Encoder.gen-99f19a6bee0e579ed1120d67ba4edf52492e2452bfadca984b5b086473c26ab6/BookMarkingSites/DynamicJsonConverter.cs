using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace BookMarkingSites;

public sealed class DynamicJsonConverter : JavaScriptConverter
{
	private sealed class DynamicJsonObject : DynamicObject
	{
		private readonly IDictionary<string, object> _dictionary;

		public DynamicJsonObject(IDictionary<string, object> dictionary)
		{
			if (dictionary == null)
			{
				throw new ArgumentNullException("dictionary");
			}
			_dictionary = dictionary;
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder("{");
			ToString(stringBuilder);
			return stringBuilder.ToString();
		}

		private void ToString(StringBuilder sb)
		{
			bool flag = true;
			foreach (KeyValuePair<string, object> item in _dictionary)
			{
				if (!flag)
				{
					sb.Append(",");
				}
				flag = false;
				object value = item.Value;
				string key = item.Key;
				if (value is string)
				{
					sb.AppendFormat("{0}:\"{1}\"", key, value);
				}
				else if (value is IDictionary<string, object>)
				{
					new DynamicJsonObject((IDictionary<string, object>)value).ToString(sb);
				}
				else if (value is ArrayList)
				{
					sb.Append(key + ":[");
					bool flag2 = true;
					foreach (object item2 in (ArrayList)value)
					{
						if (!flag2)
						{
							sb.Append(",");
						}
						flag2 = false;
						if (item2 is IDictionary<string, object>)
						{
							new DynamicJsonObject((IDictionary<string, object>)item2).ToString(sb);
						}
						else if (item2 is string)
						{
							sb.AppendFormat("\"{0}\"", item2);
						}
						else
						{
							sb.AppendFormat("{0}", item2);
						}
					}
					sb.Append("]");
				}
				else
				{
					sb.AppendFormat("{0}:{1}", key, value);
				}
			}
			sb.Append("}");
		}

		public override bool TryGetMember(GetMemberBinder binder, out object result)
		{
			if (!_dictionary.TryGetValue(binder.Name, out result))
			{
				result = null;
				return true;
			}
			if (result is IDictionary<string, object> dictionary)
			{
				result = new DynamicJsonObject(dictionary);
				return true;
			}
			if (result is ArrayList arrayList && arrayList.Count > 0)
			{
				if (arrayList[0] is IDictionary<string, object>)
				{
					result = new List<object>(from IDictionary<string, object> x in arrayList
						select new DynamicJsonObject(x));
				}
				else
				{
					result = new List<object>(arrayList.Cast<object>());
				}
			}
			return true;
		}
	}

	public override IEnumerable<Type> SupportedTypes => new ReadOnlyCollection<Type>(new List<Type>(new Type[1] { typeof(object) }));

	public override object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		return (type == typeof(object)) ? new DynamicJsonObject(dictionary) : null;
	}

	public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
	{
		throw new NotImplementedException();
	}
}
