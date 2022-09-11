using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

[ComVisible(true)]
[Guid("2309282F-B89B-4F6B-AEB1-D3E1629B7033")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public class GClass6 : ICollection<GException2>, IEnumerable<GException2>, IEnumerable
{
	private readonly Class26<GException2> class26_0 = Delegate226.smethod_0();

	public GException2 this[int index]
	{
		get
		{
			return Delegate215.smethod_0(class26_0, index);
		}
		set
		{
			Delegate216.smethod_0(class26_0, index, value);
		}
	}

	public int Count => Delegate221.smethod_0(class26_0);

	public bool IsReadOnly => Delegate222.smethod_0(class26_0);

	public void Add(GException2 item)
	{
		Delegate217.smethod_0(class26_0, item);
	}

	public void Clear()
	{
		Delegate218.smethod_0(class26_0);
	}

	public bool Contains(GException2 item)
	{
		return Delegate219.smethod_0(class26_0, item);
	}

	public void CopyTo(GException2[] array, int arrayIndex)
	{
		Delegate220.smethod_0(class26_0, array, arrayIndex);
	}

	public bool Remove(GException2 item)
	{
		return Delegate223.smethod_0(class26_0, item);
	}

	IEnumerator<GException2> IEnumerable<GException2>.GetEnumerator()
	{
		return Delegate224.smethod_0(class26_0);
	}

	public IEnumerator GetEnumerator()
	{
		return Delegate224.smethod_0(class26_0);
	}

	internal void method_0(GException2 gexception2_0)
	{
		Delegate225.smethod_0(class26_0, gexception2_0);
	}
}
