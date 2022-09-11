using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

[ComVisible(true)]
[Guid("574FF430-FD40-41F9-9A04-971D3CF844B7")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public class GClass5 : ICollection<GEventArgs6>, IEnumerable<GEventArgs6>, IEnumerable
{
	private readonly Class26<GEventArgs6> class26_0 = Delegate214.smethod_0();

	public GEventArgs6 this[int index]
	{
		get
		{
			return (GEventArgs6)Class51.smethod_0(6517263, this, index);
		}
		set
		{
			Class51.smethod_0(6517293, this, index, value);
		}
	}

	public int Count => (int)Class51.smethod_0(6517471, this, null);

	public bool IsReadOnly => (bool)Class51.smethod_0(6517489, this, null);

	public void Add(GEventArgs6 item)
	{
		Class51.smethod_0(6517335, this, item);
	}

	public void Clear()
	{
		Class51.smethod_0(6517365, this, null);
	}

	public bool Contains(GEventArgs6 item)
	{
		return (bool)Class51.smethod_0(6517399, this, item);
	}

	public void CopyTo(GEventArgs6[] array, int arrayIndex)
	{
		Class51.smethod_0(6517429, this, array, arrayIndex);
	}

	public bool Remove(GEventArgs6 item)
	{
		return (bool)Class51.smethod_0(6517523, this, item);
	}

	IEnumerator<GEventArgs6> IEnumerable<GEventArgs6>.GetEnumerator()
	{
		return (IEnumerator<GEventArgs6>)Class51.smethod_0(6517553, this, null);
	}

	public IEnumerator GetEnumerator()
	{
		return (IEnumerator)Class51.smethod_0(6517587, this, null);
	}

	internal void method_0(GEventArgs6 geventArgs6_0)
	{
		Class51.smethod_0(6517621, this, geventArgs6_0);
	}
}
