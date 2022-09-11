using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
[Guid("39AA3D00-578C-49AF-B3E4-16CE26C710C6")]
public class GClass4 : ICollection<GClass15>, IEnumerable<GClass15>, IEnumerable
{
	private readonly Class26<GClass15> class26_0 = Delegate202.smethod_0();

	public GClass15 this[int index]
	{
		get
		{
			return Delegate191.smethod_0(class26_0, index);
		}
		set
		{
			Delegate192.smethod_0(class26_0, index, value);
		}
	}

	public int Count => Delegate197.smethod_0(class26_0);

	public bool IsReadOnly => Delegate198.smethod_0(class26_0);

	public void Add(GClass15 item)
	{
		Delegate193.smethod_0(class26_0, item);
	}

	public void Clear()
	{
		Delegate194.smethod_0(class26_0);
	}

	public bool Contains(GClass15 item)
	{
		return Delegate195.smethod_0(class26_0, item);
	}

	public void CopyTo(GClass15[] array, int arrayIndex)
	{
		Delegate196.smethod_0(class26_0, array, arrayIndex);
	}

	public bool Remove(GClass15 item)
	{
		return Delegate199.smethod_0(class26_0, item);
	}

	IEnumerator<GClass15> IEnumerable<GClass15>.GetEnumerator()
	{
		return Delegate200.smethod_0(class26_0);
	}

	public IEnumerator GetEnumerator()
	{
		return Delegate200.smethod_0(class26_0);
	}

	internal void method_0(GClass15 gclass15_0)
	{
		Delegate201.smethod_0(class26_0, gclass15_0);
	}
}
