using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using ns0;
using ns10;
using ns14;
using ns15;
using ns18;
using ns19;
using ns9;

namespace Newtonsoft.Json.Linq;

public class JProperty : Class176
{
	[DefaultMember("Item")]
	private class Class189 : IEnumerable<JToken>, IList<JToken>, ICollection<JToken>, IEnumerable
	{
		internal JToken? jtoken_0;

		int ICollection<JToken>.Count
		{
			get
			{
				if (jtoken_0 == null)
				{
					return 0;
				}
				return 1;
			}
		}

		bool ICollection<JToken>.IsReadOnly => false;

		JToken IList<JToken>.this[int index]
		{
			get
			{
				if (index != 0)
				{
					throw new IndexOutOfRangeException();
				}
				return jtoken_0;
			}
			set
			{
				if (index != 0)
				{
					throw new IndexOutOfRangeException();
				}
				jtoken_0 = value;
			}
		}

		IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
		{
			//yield-return decompiler failed: Method not found
			return new Class190(0)
			{
				class189_0 = this
			};
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return System_002ECollections_002EGeneric_002EIEnumerable_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EGetEnumerator();
		}

		public void Add(JToken item)
		{
			jtoken_0 = item;
		}

		void ICollection<JToken>.Clear()
		{
			jtoken_0 = null;
		}

		bool ICollection<JToken>.Contains(JToken item)
		{
			return jtoken_0 == item;
		}

		void ICollection<JToken>.CopyTo(JToken[] array, int arrayIndex)
		{
			if (jtoken_0 != null)
			{
				array[arrayIndex] = jtoken_0;
			}
		}

		bool ICollection<JToken>.Remove(JToken item)
		{
			if (jtoken_0 == item)
			{
				jtoken_0 = null;
				return true;
			}
			return false;
		}

		int IList<JToken>.IndexOf(JToken item)
		{
			if (jtoken_0 != item)
			{
				return -1;
			}
			return 0;
		}

		void IList<JToken>.Insert(int index, JToken item)
		{
			if (index == 0)
			{
				jtoken_0 = item;
			}
		}

		void IList<JToken>.RemoveAt(int index)
		{
			if (index == 0)
			{
				jtoken_0 = null;
			}
		}
	}

	private readonly Class189 class189_0 = new Class189();

	private readonly string string_0;

	protected override IList<JToken> ChildrenTokens => class189_0;

	public string Name
	{
		[DebuggerStepThrough]
		get
		{
			return string_0;
		}
	}

	public JToken Value
	{
		[DebuggerStepThrough]
		get
		{
			return class189_0.jtoken_0;
		}
		set
		{
			Class7.smethod_544((Class176)this);
			JToken jtoken_ = value ?? new Class179(null, JTokenType.Null);
			if (class189_0.jtoken_0 == null)
			{
				vmethod_13(0, jtoken_, bool_1: false);
			}
			else
			{
				vmethod_17(0, jtoken_);
			}
		}
	}

	public override JTokenType Type
	{
		[DebuggerStepThrough]
		get
		{
			return JTokenType.Property;
		}
	}

	public JProperty(JProperty other)
		: base(other)
	{
		string_0 = other.Name;
	}

	internal override JToken vmethod_16(int int_0)
	{
		if (int_0 != 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		return Value;
	}

	internal override void vmethod_17(int int_0, JToken? jtoken_2)
	{
		if (int_0 != 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (!Class7.smethod_454(Value, jtoken_2))
		{
			((JObject)base.Parent)?.method_18(this);
			base.vmethod_17(0, jtoken_2);
			((JObject)base.Parent)?.method_17(this);
		}
	}

	internal override bool vmethod_15(JToken? jtoken_2)
	{
		throw new JsonException("Cannot add or remove items from {0}.".smethod_1(CultureInfo.InvariantCulture, typeof(JProperty)));
	}

	internal override void vmethod_14(int int_0)
	{
		throw new JsonException("Cannot add or remove items from {0}.".smethod_1(CultureInfo.InvariantCulture, typeof(JProperty)));
	}

	internal override int vmethod_12(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return -1;
		}
		return class189_0.System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EIndexOf(jtoken_2);
	}

	internal override bool vmethod_13(int int_0, JToken? jtoken_2, bool bool_1)
	{
		if (jtoken_2 != null && jtoken_2!.Type == JTokenType.Comment)
		{
			return false;
		}
		if (Value != null)
		{
			throw new JsonException("{0} cannot have multiple values.".smethod_1(CultureInfo.InvariantCulture, typeof(JProperty)));
		}
		return base.vmethod_13(0, jtoken_2, bool_1: false);
	}

	internal override bool vmethod_20(JToken? jtoken_2)
	{
		return Value == jtoken_2;
	}

	internal override void vmethod_23(object object_2, Class194? class194_0)
	{
		JToken jToken = (object_2 as JProperty)?.Value;
		if (jToken != null && jToken.Type != JTokenType.Null)
		{
			Value = jToken;
		}
	}

	internal override void vmethod_18()
	{
		throw new JsonException("Cannot add or remove items from {0}.".smethod_1(CultureInfo.InvariantCulture, typeof(JProperty)));
	}

	internal override bool vmethod_1(JToken jtoken_2)
	{
		if (jtoken_2 is JProperty jProperty && string_0 == jProperty.Name)
		{
			return method_10(jProperty);
		}
		return false;
	}

	internal override JToken vmethod_0()
	{
		return new JProperty(this);
	}

	internal JProperty(string name)
	{
		Class113.smethod_0(name, "name");
		string_0 = name;
	}

	public JProperty(string name, params object[] content)
		: this(name, (object?)content)
	{
	}

	public JProperty(string name, object? content)
	{
		Class113.smethod_0(name, "name");
		string_0 = name;
		Value = (method_11(content) ? new Class177(content) : Class7.smethod_85(content));
	}

	public override void vmethod_5(Class38 class38_0, params Class9[] class9_0)
	{
		class38_0.vmethod_9(string_0);
		JToken value = Value;
		if (value != null)
		{
			value.vmethod_5(class38_0, class9_0);
		}
		else
		{
			class38_0.vmethod_17();
		}
	}

	internal override int vmethod_6()
	{
		return string_0.GetHashCode() ^ (Value?.vmethod_6() ?? 0);
	}
}
