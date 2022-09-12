using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ns12;
using ns13;
using ns15;
using ns19;
using ns3;
using ns4;
using ns9;

namespace ns1;

internal abstract class Class176 : JToken, IEnumerable<JToken>, IList<JToken>, ICollection<JToken>, IList, ICollection, IEnumerable, ITypedList, IBindingList, INotifyCollectionChanged
{
	internal ListChangedEventHandler? listChangedEventHandler_0;

	internal AddingNewEventHandler? addingNewEventHandler_0;

	internal NotifyCollectionChangedEventHandler? notifyCollectionChangedEventHandler_0;

	private object? object_1;

	internal bool bool_0;

	protected abstract IList<JToken> ChildrenTokens { get; }

	public override bool HasValues => ChildrenTokens.Count > 0;

	public override JToken? First
	{
		get
		{
			IList<JToken> childrenTokens = ChildrenTokens;
			if (childrenTokens.Count <= 0)
			{
				return null;
			}
			return childrenTokens[0];
		}
	}

	public override JToken? Last
	{
		get
		{
			IList<JToken> childrenTokens = ChildrenTokens;
			int count = childrenTokens.Count;
			if (count <= 0)
			{
				return null;
			}
			return childrenTokens[count - 1];
		}
	}

	JToken IList<JToken>.this[int index]
	{
		get
		{
			return vmethod_16(index);
		}
		set
		{
			vmethod_17(index, value);
		}
	}

	bool ICollection<JToken>.IsReadOnly => false;

	bool IList.IsFixedSize => false;

	bool IList.IsReadOnly => false;

	object IList.this[int index]
	{
		get
		{
			return vmethod_16(index);
		}
		set
		{
			vmethod_17(index, Class131.smethod_47(value, this));
		}
	}

	public int Count => ChildrenTokens.Count;

	bool ICollection.IsSynchronized => false;

	object ICollection.SyncRoot
	{
		get
		{
			if (object_1 == null)
			{
				Interlocked.CompareExchange(ref object_1, new object(), null);
			}
			return object_1;
		}
	}

	bool IBindingList.AllowEdit => true;

	bool IBindingList.AllowNew => true;

	bool IBindingList.AllowRemove => true;

	bool IBindingList.IsSorted => false;

	ListSortDirection IBindingList.SortDirection => ListSortDirection.Ascending;

	PropertyDescriptor? IBindingList.SortProperty => null;

	bool IBindingList.SupportsChangeNotification => true;

	bool IBindingList.SupportsSearching => false;

	bool IBindingList.SupportsSorting => false;

	event ListChangedEventHandler IBindingList.ListChanged
	{
		add
		{
			listChangedEventHandler_0 = (ListChangedEventHandler)Delegate.Combine(listChangedEventHandler_0, value);
		}
		remove
		{
			listChangedEventHandler_0 = (ListChangedEventHandler)Delegate.Remove(listChangedEventHandler_0, value);
		}
	}

	public event AddingNewEventHandler AddingNew
	{
		add
		{
			addingNewEventHandler_0 = (AddingNewEventHandler)Delegate.Combine(addingNewEventHandler_0, value);
		}
		remove
		{
			addingNewEventHandler_0 = (AddingNewEventHandler)Delegate.Remove(addingNewEventHandler_0, value);
		}
	}

	event NotifyCollectionChangedEventHandler INotifyCollectionChanged.CollectionChanged
	{
		add
		{
			notifyCollectionChangedEventHandler_0 = (NotifyCollectionChangedEventHandler)Delegate.Combine(notifyCollectionChangedEventHandler_0, value);
		}
		remove
		{
			notifyCollectionChangedEventHandler_0 = (NotifyCollectionChangedEventHandler)Delegate.Remove(notifyCollectionChangedEventHandler_0, value);
		}
	}

	internal Class176()
	{
	}

	internal Class176(Class176 class176_1)
		: this()
	{
		Class112.smethod_0(class176_1, "other");
		int num = 0;
		foreach (JToken item in (IEnumerable<JToken>)class176_1)
		{
			method_15(num, item, bool_1: false);
			num++;
		}
		Class131.smethod_254((JToken)this, (JToken)this, (JToken)class176_1);
	}

	internal virtual IList<JToken> vmethod_8()
	{
		return new List<JToken>();
	}

	protected virtual void vmethod_9(AddingNewEventArgs addingNewEventArgs_0)
	{
		addingNewEventHandler_0?.Invoke(this, addingNewEventArgs_0);
	}

	protected virtual void vmethod_10(ListChangedEventArgs listChangedEventArgs_0)
	{
		ListChangedEventHandler listChangedEventHandler = listChangedEventHandler_0;
		if (listChangedEventHandler != null)
		{
			bool_0 = true;
			try
			{
				listChangedEventHandler(this, listChangedEventArgs_0);
			}
			finally
			{
				bool_0 = false;
			}
		}
	}

	protected virtual void vmethod_11(NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_0)
	{
		NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler = notifyCollectionChangedEventHandler_0;
		if (notifyCollectionChangedEventHandler != null)
		{
			bool_0 = true;
			try
			{
				notifyCollectionChangedEventHandler(this, notifyCollectionChangedEventArgs_0);
			}
			finally
			{
				bool_0 = false;
			}
		}
	}

	internal bool method_10(Class176 class176_1)
	{
		if (class176_1 == this)
		{
			return true;
		}
		IList<JToken> childrenTokens = ChildrenTokens;
		IList<JToken> childrenTokens2 = class176_1.ChildrenTokens;
		if (childrenTokens.Count != childrenTokens2.Count)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < childrenTokens.Count)
			{
				if (!childrenTokens[num].vmethod_1(childrenTokens2[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public override Struct6<JToken> vmethod_3()
	{
		return new Struct6<JToken>(ChildrenTokens);
	}

	public override IEnumerable<T?> vmethod_4<T>()
	{
		return ChildrenTokens.smethod_14<JToken, T>();
	}

	internal bool method_11([Attribute1(true)] object? object_2)
	{
		if (object_2 is IEnumerable && !(object_2 is string) && !(object_2 is JToken))
		{
			return !(object_2 is byte[]);
		}
		return false;
	}

	internal abstract int vmethod_12(JToken? jtoken_2);

	internal virtual bool vmethod_13(int int_0, JToken? jtoken_2, bool bool_1)
	{
		IList<JToken> childrenTokens = ChildrenTokens;
		if (int_0 > childrenTokens.Count)
		{
			throw new ArgumentOutOfRangeException("index", "Index must be within the bounds of the List.");
		}
		Class131.smethod_497(this);
		jtoken_2 = Class131.smethod_427(jtoken_2, bool_1, this);
		JToken jToken = ((int_0 == 0) ? null : childrenTokens[int_0 - 1]);
		JToken jToken2 = ((int_0 == childrenTokens.Count) ? null : childrenTokens[int_0]);
		vmethod_22(jtoken_2, null);
		jtoken_2!.Parent = this;
		jtoken_2!.Previous = jToken;
		if (jToken != null)
		{
			jToken.Next = jtoken_2;
		}
		jtoken_2!.Next = jToken2;
		if (jToken2 != null)
		{
			jToken2.Previous = jtoken_2;
		}
		childrenTokens.Insert(int_0, jtoken_2);
		if (listChangedEventHandler_0 != null)
		{
			vmethod_10(new ListChangedEventArgs(ListChangedType.ItemAdded, int_0));
		}
		if (notifyCollectionChangedEventHandler_0 != null)
		{
			vmethod_11(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, jtoken_2, int_0));
		}
		return true;
	}

	internal virtual void vmethod_14(int int_0)
	{
		IList<JToken> childrenTokens = ChildrenTokens;
		if (int_0 < 0)
		{
			throw new ArgumentOutOfRangeException("index", "Index is less than 0.");
		}
		if (int_0 >= childrenTokens.Count)
		{
			throw new ArgumentOutOfRangeException("index", "Index is equal to or greater than Count.");
		}
		Class131.smethod_497(this);
		JToken jToken = childrenTokens[int_0];
		JToken jToken2 = ((int_0 == 0) ? null : childrenTokens[int_0 - 1]);
		JToken jToken3 = ((int_0 == childrenTokens.Count - 1) ? null : childrenTokens[int_0 + 1]);
		if (jToken2 != null)
		{
			jToken2.Next = jToken3;
		}
		if (jToken3 != null)
		{
			jToken3.Previous = jToken2;
		}
		jToken.Parent = null;
		jToken.Previous = null;
		jToken.Next = null;
		childrenTokens.RemoveAt(int_0);
		if (listChangedEventHandler_0 != null)
		{
			vmethod_10(new ListChangedEventArgs(ListChangedType.ItemDeleted, int_0));
		}
		if (notifyCollectionChangedEventHandler_0 != null)
		{
			vmethod_11(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, jToken, int_0));
		}
	}

	internal virtual bool vmethod_15(JToken? jtoken_2)
	{
		if (jtoken_2 != null)
		{
			int num = vmethod_12(jtoken_2);
			if (num >= 0)
			{
				vmethod_14(num);
				return true;
			}
		}
		return false;
	}

	internal virtual JToken vmethod_16(int int_0)
	{
		return ChildrenTokens[int_0];
	}

	internal virtual void vmethod_17(int int_0, JToken? jtoken_2)
	{
		IList<JToken> childrenTokens = ChildrenTokens;
		if (int_0 < 0)
		{
			throw new ArgumentOutOfRangeException("index", "Index is less than 0.");
		}
		if (int_0 >= childrenTokens.Count)
		{
			throw new ArgumentOutOfRangeException("index", "Index is equal to or greater than Count.");
		}
		JToken jToken = childrenTokens[int_0];
		if (!Class131.smethod_292(jToken, jtoken_2))
		{
			Class131.smethod_497(this);
			jtoken_2 = Class131.smethod_427(jtoken_2, bool_0: false, this);
			vmethod_22(jtoken_2, jToken);
			JToken jToken2 = ((int_0 == 0) ? null : childrenTokens[int_0 - 1]);
			JToken jToken3 = ((int_0 == childrenTokens.Count - 1) ? null : childrenTokens[int_0 + 1]);
			jtoken_2!.Parent = this;
			jtoken_2!.Previous = jToken2;
			if (jToken2 != null)
			{
				jToken2.Next = jtoken_2;
			}
			jtoken_2!.Next = jToken3;
			if (jToken3 != null)
			{
				jToken3.Previous = jtoken_2;
			}
			childrenTokens[int_0] = jtoken_2;
			jToken.Parent = null;
			jToken.Previous = null;
			jToken.Next = null;
			if (listChangedEventHandler_0 != null)
			{
				vmethod_10(new ListChangedEventArgs(ListChangedType.ItemChanged, int_0));
			}
			if (notifyCollectionChangedEventHandler_0 != null)
			{
				vmethod_11(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, jtoken_2, jToken, int_0));
			}
		}
	}

	internal virtual void vmethod_18()
	{
		Class131.smethod_497(this);
		IList<JToken> childrenTokens = ChildrenTokens;
		foreach (JToken item in childrenTokens)
		{
			item.Parent = null;
			item.Previous = null;
			item.Next = null;
		}
		childrenTokens.Clear();
		if (listChangedEventHandler_0 != null)
		{
			vmethod_10(new ListChangedEventArgs(ListChangedType.Reset, -1));
		}
		if (notifyCollectionChangedEventHandler_0 != null)
		{
			vmethod_11(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
		}
	}

	internal virtual void vmethod_19(JToken jtoken_2, JToken jtoken_3)
	{
		if (jtoken_2 != null && jtoken_2.Parent == this)
		{
			int int_ = vmethod_12(jtoken_2);
			vmethod_17(int_, jtoken_3);
		}
	}

	internal virtual bool vmethod_20(JToken? jtoken_2)
	{
		return vmethod_12(jtoken_2) != -1;
	}

	internal virtual void vmethod_21(Array array_0, int int_0)
	{
		if (array_0 == null)
		{
			throw new ArgumentNullException("array");
		}
		if (int_0 < 0)
		{
			throw new ArgumentOutOfRangeException("arrayIndex", "arrayIndex is less than 0.");
		}
		if (int_0 >= array_0.Length && int_0 != 0)
		{
			throw new ArgumentException("arrayIndex is equal to or greater than the length of array.");
		}
		if (Count > array_0.Length - int_0)
		{
			throw new ArgumentException("The number of elements in the source JObject is greater than the available space from arrayIndex to the end of the destination array.");
		}
		int num = 0;
		foreach (JToken childrenToken in ChildrenTokens)
		{
			array_0.SetValue(childrenToken, int_0 + num);
			num++;
		}
	}

	internal virtual void vmethod_22(JToken jtoken_2, JToken? jtoken_3)
	{
		Class112.smethod_0(jtoken_2, "o");
		if (jtoken_2.Type == JTokenType.Property)
		{
			throw new ArgumentException("Can not add {0} to {1}.".smethod_2(CultureInfo.InvariantCulture, jtoken_2.GetType(), GetType()));
		}
	}

	public virtual void Add(object? content)
	{
		method_15(ChildrenTokens.Count, content, bool_1: false);
	}

	internal bool method_12(object? object_2)
	{
		return method_15(ChildrenTokens.Count, object_2, bool_1: false);
	}

	internal void method_13(JToken jtoken_2)
	{
		method_15(ChildrenTokens.Count, jtoken_2, bool_1: true);
	}

	public void method_14(object? object_2)
	{
		method_15(0, object_2, bool_1: false);
	}

	internal bool method_15(int int_0, object? object_2, bool bool_1)
	{
		if (method_11(object_2))
		{
			IEnumerable obj = (IEnumerable)object_2;
			int num = int_0;
			foreach (object item in obj)
			{
				method_15(num, item, bool_1);
				num++;
			}
			return true;
		}
		JToken jtoken_ = Class131.smethod_61(object_2);
		return vmethod_13(int_0, jtoken_, bool_1);
	}

	internal abstract void vmethod_23(object object_2, Class194? class194_0);

	internal static JProperty? smethod_36(Class28 class28_0, Class193? class193_0, Interface1? interface1_0, Class176 class176_1)
	{
		Enum29 @enum = class193_0?.enum29_0 ?? Enum29.const_0;
		JObject jobject_ = (JObject)class176_1;
		string text = class28_0.Value!.ToString();
		JProperty jProperty = Class131.smethod_517(jobject_, text, StringComparison.Ordinal);
		if (jProperty != null)
		{
			switch (@enum)
			{
			case Enum29.const_1:
				return null;
			case Enum29.const_2:
				throw Class131.smethod_303(class28_0, "Property with the name '{0}' already exists in the current JSON object.".smethod_1(CultureInfo.InvariantCulture, text));
			}
		}
		JProperty jProperty2 = new JProperty(text);
		jProperty2.method_5(interface1_0, class193_0);
		if (jProperty == null)
		{
			class176_1.Add(jProperty2);
		}
		else
		{
			Class131.smethod_22((JToken)jProperty, (JToken)jProperty2);
		}
		return jProperty2;
	}

	internal int method_16()
	{
		int num = 0;
		foreach (JToken childrenToken in ChildrenTokens)
		{
			num ^= childrenToken.vmethod_6();
		}
		return num;
	}

	string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
	{
		return string.Empty;
	}

	PropertyDescriptorCollection? ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
	{
		return (First as ICustomTypeDescriptor)?.GetProperties();
	}

	int IList<JToken>.IndexOf(JToken item)
	{
		return vmethod_12(item);
	}

	void IList<JToken>.Insert(int index, JToken item)
	{
		vmethod_13(index, item, bool_1: false);
	}

	void IList<JToken>.RemoveAt(int index)
	{
		vmethod_14(index);
	}

	void ICollection<JToken>.Add(JToken item)
	{
		Add(item);
	}

	void ICollection<JToken>.Clear()
	{
		vmethod_18();
	}

	bool ICollection<JToken>.Contains(JToken item)
	{
		return vmethod_20(item);
	}

	void ICollection<JToken>.CopyTo(JToken[] array, int arrayIndex)
	{
		vmethod_21(array, arrayIndex);
	}

	bool ICollection<JToken>.Remove(JToken item)
	{
		return vmethod_15(item);
	}

	int IList.Add(object value)
	{
		Add(Class131.smethod_47(value, this));
		return Count - 1;
	}

	void IList.Clear()
	{
		vmethod_18();
	}

	bool IList.Contains(object value)
	{
		return vmethod_20(Class131.smethod_47(value, this));
	}

	int IList.IndexOf(object value)
	{
		return vmethod_12(Class131.smethod_47(value, this));
	}

	void IList.Insert(int index, object value)
	{
		vmethod_13(index, Class131.smethod_47(value, this), bool_1: false);
	}

	void IList.Remove(object value)
	{
		vmethod_15(Class131.smethod_47(value, this));
	}

	void IList.RemoveAt(int index)
	{
		vmethod_14(index);
	}

	void ICollection.CopyTo(Array array, int index)
	{
		vmethod_21(array, index);
	}

	void IBindingList.AddIndex(PropertyDescriptor property)
	{
	}

	object IBindingList.AddNew()
	{
		AddingNewEventArgs addingNewEventArgs = new AddingNewEventArgs();
		vmethod_9(addingNewEventArgs);
		if (addingNewEventArgs.NewObject == null)
		{
			throw new JsonException("Could not determine new value to add to '{0}'.".smethod_1(CultureInfo.InvariantCulture, GetType()));
		}
		if (!(addingNewEventArgs.NewObject is JToken jToken))
		{
			throw new JsonException("New item to be added to collection must be compatible with {0}.".smethod_1(CultureInfo.InvariantCulture, typeof(JToken)));
		}
		Add(jToken);
		return jToken;
	}

	void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
	{
		throw new NotSupportedException();
	}

	int IBindingList.Find(PropertyDescriptor property, object key)
	{
		throw new NotSupportedException();
	}

	void IBindingList.RemoveIndex(PropertyDescriptor property)
	{
	}

	void IBindingList.RemoveSort()
	{
		throw new NotSupportedException();
	}
}
