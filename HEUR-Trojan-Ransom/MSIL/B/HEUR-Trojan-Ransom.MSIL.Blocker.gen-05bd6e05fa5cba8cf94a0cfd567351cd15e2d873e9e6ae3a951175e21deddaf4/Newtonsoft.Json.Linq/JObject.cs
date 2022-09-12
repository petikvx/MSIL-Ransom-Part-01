using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using Newtonsoft.Json.Utilities;
using ns10;
using ns11;
using ns12;
using ns17;
using ns18;
using ns2;
using ns5;
using ns7;

namespace Newtonsoft.Json.Linq;

public class JObject : Class176, IDictionary<string, JToken>, IEnumerable, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, INotifyPropertyChanged, ICustomTypeDescriptor, INotifyPropertyChanging
{
	private class JObjectDynamicProxy : Class52<JObject>
	{
		public override bool vmethod_7(JObject jobject_0, GetMemberBinder getMemberBinder_0, out object? object_0)
		{
			object_0 = jobject_0[getMemberBinder_0.Name];
			return true;
		}

		public override bool vmethod_11(JObject jobject_0, SetMemberBinder setMemberBinder_0, object object_0)
		{
			JToken jToken = object_0 as JToken;
			if (jToken == null)
			{
				jToken = new Class179(object_0);
			}
			jobject_0[setMemberBinder_0.Name] = jToken;
			return true;
		}

		public override IEnumerable<string> vmethod_0(JObject jobject_0)
		{
			return from jproperty_0 in Class4.smethod_710(jobject_0)
				select jproperty_0.Name;
		}
	}

	internal readonly Class192 class192_0 = new Class192();

	[CompilerGenerated]
	private PropertyChangedEventHandler? propertyChangedEventHandler_0;

	[CompilerGenerated]
	private PropertyChangingEventHandler? propertyChangingEventHandler_0;

	protected override IList<JToken> ChildrenTokens => class192_0;

	public override JTokenType Type => JTokenType.Object;

	public override JToken? this[object object_2]
	{
		get
		{
			Class113.smethod_0(object_2, "key");
			if (!(object_2 is string key))
			{
				throw new ArgumentException("Accessed JObject values with invalid key value: {0}. Object property name expected.".smethod_1(CultureInfo.InvariantCulture, Class4.smethod_269(object_2)));
			}
			return this[key];
		}
		set
		{
			Class113.smethod_0(object_2, "key");
			if (!(object_2 is string key))
			{
				throw new ArgumentException("Set JObject values with invalid key value: {0}. Object property name expected.".smethod_1(CultureInfo.InvariantCulture, Class4.smethod_269(object_2)));
			}
			this[key] = value;
		}
	}

	JToken? IDictionary<string, JToken>.this[string key]
	{
		get
		{
			Class113.smethod_0(key, "propertyName");
			return Class4.smethod_187(this, key, StringComparison.Ordinal)?.Value;
		}
		set
		{
			JProperty jProperty = Class4.smethod_187(this, key, StringComparison.Ordinal);
			if (jProperty != null)
			{
				jProperty.Value = value;
				return;
			}
			vmethod_25(key);
			System_002ECollections_002EGeneric_002EIDictionary_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EAdd(key, value);
			vmethod_24(key);
		}
	}

	ICollection<string> IDictionary<string, JToken>.Keys => class192_0.Keys;

	ICollection<JToken?> IDictionary<string, JToken>.Values
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	bool ICollection<KeyValuePair<string, JToken>>.IsReadOnly => false;

	event PropertyChangedEventHandler? INotifyPropertyChanged.PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = propertyChangedEventHandler_0;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = propertyChangedEventHandler_0;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	event PropertyChangingEventHandler? INotifyPropertyChanging.PropertyChanging
	{
		[CompilerGenerated]
		add
		{
			PropertyChangingEventHandler propertyChangingEventHandler = propertyChangingEventHandler_0;
			PropertyChangingEventHandler propertyChangingEventHandler2;
			do
			{
				propertyChangingEventHandler2 = propertyChangingEventHandler;
				PropertyChangingEventHandler value2 = (PropertyChangingEventHandler)Delegate.Combine(propertyChangingEventHandler2, value);
				propertyChangingEventHandler = Interlocked.CompareExchange(ref propertyChangingEventHandler_0, value2, propertyChangingEventHandler2);
			}
			while ((object)propertyChangingEventHandler != propertyChangingEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangingEventHandler propertyChangingEventHandler = propertyChangingEventHandler_0;
			PropertyChangingEventHandler propertyChangingEventHandler2;
			do
			{
				propertyChangingEventHandler2 = propertyChangingEventHandler;
				PropertyChangingEventHandler value2 = (PropertyChangingEventHandler)Delegate.Remove(propertyChangingEventHandler2, value);
				propertyChangingEventHandler = Interlocked.CompareExchange(ref propertyChangingEventHandler_0, value2, propertyChangingEventHandler2);
			}
			while ((object)propertyChangingEventHandler != propertyChangingEventHandler2);
		}
	}

	public JObject()
	{
	}

	public JObject(JObject other)
		: base(other)
	{
	}

	public JObject(params object[] content)
		: this((object)content)
	{
	}

	public JObject(object content)
	{
		Add(content);
	}

	internal override bool vmethod_1(JToken jtoken_2)
	{
		if (!(jtoken_2 is JObject jObject))
		{
			return false;
		}
		return class192_0.method_3(jObject.class192_0);
	}

	internal override int vmethod_12(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return -1;
		}
		return class192_0.method_2(jtoken_2);
	}

	internal override bool vmethod_13(int int_0, JToken? jtoken_2, bool bool_1)
	{
		if (jtoken_2 != null && jtoken_2!.Type == JTokenType.Comment)
		{
			return false;
		}
		return base.vmethod_13(int_0, jtoken_2, bool_1);
	}

	internal override void vmethod_22(JToken jtoken_2, JToken? jtoken_3)
	{
		Class113.smethod_0(jtoken_2, "o");
		if (jtoken_2.Type != JTokenType.Property)
		{
			throw new ArgumentException("Can not add {0} to {1}.".smethod_2(CultureInfo.InvariantCulture, jtoken_2.GetType(), GetType()));
		}
		JProperty jProperty = (JProperty)jtoken_2;
		if (jtoken_3 != null)
		{
			JProperty jProperty2 = (JProperty)jtoken_3;
			if (jProperty.Name == jProperty2.Name)
			{
				return;
			}
		}
		if (Class4.smethod_327(class192_0, jProperty.Name, ref jtoken_3))
		{
			throw new ArgumentException("Can not add property {0} to {1}. Property with the same name already exists on object.".smethod_2(CultureInfo.InvariantCulture, jProperty.Name, GetType()));
		}
	}

	internal override void vmethod_23(object object_2, Class194? class194_0)
	{
		if (!(object_2 is JObject jObject))
		{
			return;
		}
		using IEnumerator<KeyValuePair<string, JToken>> enumerator = jObject.System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EGetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<string, JToken> current = enumerator.Current;
			JProperty jProperty = Class4.smethod_187(this, current.Key, class194_0?.stringComparison_0 ?? StringComparison.Ordinal);
			if (jProperty == null)
			{
				System_002ECollections_002EGeneric_002EIDictionary_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EAdd(current.Key, current.Value);
			}
			else if (current.Value != null)
			{
				if (jProperty.Value is Class176 @class && @class.Type == current.Value.Type)
				{
					Class4.smethod_720(@class, (object?)current.Value, class194_0);
				}
				else if (!Class4.smethod_30(current.Value) || (class194_0 != null && class194_0!.enum32_0 == Enum32.flag_1))
				{
					jProperty.Value = current.Value;
				}
			}
		}
	}

	internal void method_17(JProperty jproperty_0)
	{
		vmethod_24(jproperty_0.Name);
		if (listChangedEventHandler_0 != null)
		{
			vmethod_10(new ListChangedEventArgs(ListChangedType.ItemChanged, vmethod_12(jproperty_0)));
		}
		if (notifyCollectionChangedEventHandler_0 != null)
		{
			vmethod_11(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, jproperty_0, jproperty_0, vmethod_12(jproperty_0)));
		}
	}

	internal void method_18(JProperty jproperty_0)
	{
		vmethod_25(jproperty_0.Name);
	}

	internal override JToken vmethod_0()
	{
		return new JObject(this);
	}

	public override void vmethod_5(Class38 class38_0, params Class9[] class9_0)
	{
		class38_0.vmethod_3();
		for (int i = 0; i < class192_0.Count; i++)
		{
			class192_0[i].vmethod_5(class38_0, class9_0);
		}
		class38_0.vmethod_4();
	}

	public JToken? method_19(string? string_0)
	{
		return method_20(string_0, StringComparison.Ordinal);
	}

	public JToken? method_20(string? string_0, StringComparison stringComparison_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		return Class4.smethod_187(this, string_0, stringComparison_0)?.Value;
	}

	void IDictionary<string, JToken>.Add(string key, JToken? value)
	{
		Add(new JProperty(key, value));
	}

	bool IDictionary<string, JToken>.ContainsKey(string key)
	{
		Class113.smethod_0(key, "propertyName");
		return Class4.smethod_263(key, class192_0);
	}

	bool IDictionary<string, JToken>.Remove(string key)
	{
		JProperty jProperty = Class4.smethod_187(this, key, StringComparison.Ordinal);
		if (jProperty == null)
		{
			return false;
		}
		Class4.smethod_450((JToken)jProperty);
		return true;
	}

	bool IDictionary<string, JToken>.TryGetValue(string key, [Attribute1(true)] out JToken? value)
	{
		JProperty jProperty = Class4.smethod_187(this, key, StringComparison.Ordinal);
		if (jProperty == null)
		{
			value = null;
			return false;
		}
		value = jProperty.Value;
		return true;
	}

	void ICollection<KeyValuePair<string, JToken>>.Add(KeyValuePair<string, JToken?> item)
	{
		Add(new JProperty(item.Key, item.Value));
	}

	void ICollection<KeyValuePair<string, JToken>>.Clear()
	{
		Class4.smethod_402((Class176)this);
	}

	bool ICollection<KeyValuePair<string, JToken>>.Contains(KeyValuePair<string, JToken?> item)
	{
		JProperty jProperty = Class4.smethod_187(this, item.Key, StringComparison.Ordinal);
		if (jProperty == null)
		{
			return false;
		}
		return jProperty.Value == item.Value;
	}

	void ICollection<KeyValuePair<string, JToken>>.CopyTo(KeyValuePair<string, JToken?>[] array, int arrayIndex)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (arrayIndex < 0)
		{
			throw new ArgumentOutOfRangeException("arrayIndex", "arrayIndex is less than 0.");
		}
		if (arrayIndex >= array.Length && arrayIndex != 0)
		{
			throw new ArgumentException("arrayIndex is equal to or greater than the length of array.");
		}
		if (base.Count > array.Length - arrayIndex)
		{
			throw new ArgumentException("The number of elements in the source JObject is greater than the available space from arrayIndex to the end of the destination array.");
		}
		int num = 0;
		foreach (JProperty item in class192_0)
		{
			array[arrayIndex + num] = new KeyValuePair<string, JToken>(item.Name, item.Value);
			num++;
		}
	}

	bool ICollection<KeyValuePair<string, JToken>>.Remove(KeyValuePair<string, JToken?> item)
	{
		if (!((ICollection<KeyValuePair<string, JToken>>)this).Contains(item))
		{
			return false;
		}
		((IDictionary<string, JToken>)this).Remove(item.Key);
		return true;
	}

	internal override int vmethod_6()
	{
		return method_16();
	}

	IEnumerator<KeyValuePair<string, JToken?>> IEnumerable<KeyValuePair<string, JToken>>.GetEnumerator()
	{
		//yield-return decompiler failed: Method not found
		return new Class188(0)
		{
			jobject_0 = this
		};
	}

	protected virtual void vmethod_24(string string_0)
	{
		propertyChangedEventHandler_0?.Invoke(this, new PropertyChangedEventArgs(string_0));
	}

	protected virtual void vmethod_25(string string_0)
	{
		propertyChangingEventHandler_0?.Invoke(this, new PropertyChangingEventArgs(string_0));
	}

	PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
	{
		return ((ICustomTypeDescriptor)this).GetProperties((Attribute[]?)null);
	}

	PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
	{
		PropertyDescriptor[] array = new PropertyDescriptor[base.Count];
		int num = 0;
		using (IEnumerator<KeyValuePair<string, JToken>> enumerator = System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EGetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				array[num] = new Class191(enumerator.Current.Key);
				num++;
			}
		}
		return new PropertyDescriptorCollection(array);
	}

	AttributeCollection ICustomTypeDescriptor.GetAttributes()
	{
		return AttributeCollection.Empty;
	}

	string? ICustomTypeDescriptor.GetClassName()
	{
		return null;
	}

	string? ICustomTypeDescriptor.GetComponentName()
	{
		return null;
	}

	TypeConverter ICustomTypeDescriptor.GetConverter()
	{
		return new TypeConverter();
	}

	EventDescriptor? ICustomTypeDescriptor.GetDefaultEvent()
	{
		return null;
	}

	PropertyDescriptor? ICustomTypeDescriptor.GetDefaultProperty()
	{
		return null;
	}

	object? ICustomTypeDescriptor.GetEditor(Type editorBaseType)
	{
		return null;
	}

	EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
	{
		return EventDescriptorCollection.Empty;
	}

	EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
	{
		return EventDescriptorCollection.Empty;
	}

	object? ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
	{
		if (pd is Class191)
		{
			return this;
		}
		return null;
	}

	protected override DynamicMetaObject vmethod_7(Expression expression_0)
	{
		return new DynamicProxyMetaObject<JObject>(expression_0, this, new JObjectDynamicProxy());
	}
}
