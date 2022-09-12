using System.Collections.Generic;

public sealed class GClass5<T> : GInterface6<T> where T : GInterface7
{
	private int int_0;

	private List<T> list_0;

	public GClass5(int int_1)
	{
		list_0 = new List<T>();
		int_0 = int_1;
	}

	public IEnumerable<GInterface7> imethod_0()
	{
		IEnumerable<GInterface7> result = default(IEnumerable<GInterface7>);
		return result;
	}

	public void imethod_1(GInterface12<T> ginterface12_0)
	{
		list_0 = new List<T>(ginterface12_0.imethod_0(this));
	}

	public bool imethod_5(T gparam_0)
	{
		if (imethod_4() == int_0)
		{
			return false;
		}
		list_0.Add(gparam_0);
		return true;
	}

	public int imethod_4()
	{
		return list_0.Count;
	}

	public int imethod_2()
	{
		return int_0;
	}

	public T imethod_3(T gparam_0)
	{
		return list_0.Remove(gparam_0) ? gparam_0 : default(T);
	}
}
