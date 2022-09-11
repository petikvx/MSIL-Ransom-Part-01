using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

[ComVisible(true)]
[Guid("0285917B-581A-4F6F-9A9D-1C34ABFB4E38")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public class GClass8 : ICollection<GEventArgs7>, IEnumerable<GEventArgs7>, IEnumerable
{
	private readonly Class26<GEventArgs7> class26_0 = Delegate251.smethod_0();

	public GEventArgs7 this[int index]
	{
		get
		{
			return Delegate240.smethod_0(class26_0, index);
		}
		set
		{
			Delegate241.smethod_0(class26_0, index, value);
		}
	}

	public int Count => Delegate246.smethod_0(class26_0);

	public bool IsReadOnly => Delegate247.smethod_0(class26_0);

	public void Add(GEventArgs7 item)
	{
		Delegate242.smethod_0(class26_0, item);
	}

	public void Clear()
	{
		Delegate243.smethod_0(class26_0);
	}

	public bool Contains(GEventArgs7 item)
	{
		return Delegate244.smethod_0(class26_0, item);
	}

	public void CopyTo(GEventArgs7[] array, int arrayIndex)
	{
		Delegate245.smethod_0(class26_0, array, arrayIndex);
	}

	public bool Remove(GEventArgs7 item)
	{
		return Delegate248.smethod_0(class26_0, item);
	}

	IEnumerator<GEventArgs7> IEnumerable<GEventArgs7>.GetEnumerator()
	{
		return Delegate249.smethod_0(class26_0);
	}

	public IEnumerator GetEnumerator()
	{
		return Delegate249.smethod_0(class26_0);
	}

	internal void method_0(GEventArgs7 geventArgs7_0)
	{
		Delegate250.smethod_0(class26_0, geventArgs7_0);
	}
}
