using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

[ComVisible(true)]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[Guid("E402CB1F-6219-4C79-9EDF-1914D9589909")]
public class GClass7 : ICollection<string>, IEnumerable<string>, IEnumerable
{
	private readonly Class26<string> class26_0 = Delegate239.smethod_0();

	public string this[int index]
	{
		get
		{
			return (string)Class51.smethod_0(6517651, this, index);
		}
		set
		{
			Class51.smethod_0(6517681, this, index, value);
		}
	}

	public int Count => (int)Class51.smethod_0(6516835, this, null);

	public bool IsReadOnly => (bool)Class51.smethod_0(6516869, this, null);

	public void Add(string item)
	{
		Class51.smethod_0(6517723, this, item);
	}

	public void Clear()
	{
		Class51.smethod_0(6517753, this, null);
	}

	public bool Contains(string item)
	{
		return (bool)Class51.smethod_0(6516763, this, item);
	}

	public void CopyTo(string[] array, int arrayIndex)
	{
		Class51.smethod_0(6516793, this, array, arrayIndex);
	}

	public bool Remove(string item)
	{
		return (bool)Class51.smethod_0(6516903, this, item);
	}

	IEnumerator<string> IEnumerable<string>.GetEnumerator()
	{
		return (IEnumerator<string>)Class51.smethod_0(6516933, this, null);
	}

	public IEnumerator GetEnumerator()
	{
		return (IEnumerator)Class51.smethod_0(6516967, this, null);
	}

	internal void method_0(string string_0)
	{
		Class51.smethod_0(6516985, this, string_0);
	}

	internal void method_1()
	{
		Class51.smethod_0(6517031, this, null);
	}
}
