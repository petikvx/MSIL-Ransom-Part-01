using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json.Linq;
using ns1;
using ns12;
using ns13;
using ns3;
using ns9;

namespace ns5;

internal class Class177 : Class176, IEnumerable<JToken>, IList<JToken>, ICollection<JToken>, IEnumerable
{
	private readonly List<JToken> list_0 = new List<JToken>();

	protected override IList<JToken> ChildrenTokens => list_0;

	public override JTokenType Type => JTokenType.Array;

	public override JToken? this[object object_2]
	{
		get
		{
			Class112.smethod_0(object_2, "key");
			if (!(object_2 is int))
			{
				throw new ArgumentException("Accessed JArray values with invalid key value: {0}. Int32 array index expected.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_575(object_2)));
			}
			return vmethod_16((int)object_2);
		}
		set
		{
			Class112.smethod_0(object_2, "key");
			if (!(object_2 is int))
			{
				throw new ArgumentException("Set JArray values with invalid key value: {0}. Int32 array index expected.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_575(object_2)));
			}
			vmethod_17((int)object_2, value);
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

	public Class177()
	{
	}

	public Class177(Class177 class177_0)
		: base(class177_0)
	{
	}

	public Class177(params object[] object_2)
		: this((object)object_2)
	{
	}

	public Class177(object object_2)
	{
		Add(object_2);
	}

	internal override bool vmethod_1(JToken jtoken_2)
	{
		if (jtoken_2 is Class177 class176_)
		{
			return method_10(class176_);
		}
		return false;
	}

	internal override JToken vmethod_0()
	{
		return new Class177(this);
	}

	public override void vmethod_5(Class37 class37_0, params Class8[] class8_0)
	{
		class37_0.vmethod_5();
		for (int i = 0; i < list_0.Count; i++)
		{
			list_0[i].vmethod_5(class37_0, class8_0);
		}
		class37_0.vmethod_6();
	}

	internal override int vmethod_12(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return -1;
		}
		return list_0.smethod_8(jtoken_2);
	}

	internal override void vmethod_23(object object_2, Class194? class194_0)
	{
		IEnumerable enumerable = ((method_11(object_2) || object_2 is Class177) ? ((IEnumerable)object_2) : null);
		if (enumerable != null)
		{
			Class131.smethod_116((Class176)this, enumerable, class194_0);
		}
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

	IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
	{
		return vmethod_3().System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator();
	}

	public void Add(JToken item)
	{
		Add((object?)item);
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

	internal override int vmethod_6()
	{
		return method_16();
	}
}
