using System.Collections.Generic;

public sealed class GClass3<T> : GInterface8<T> where T : GInterface7
{
	protected Queue<T> queue_0;

	public GClass3(IEnumerable<T> ienumerable_0)
	{
		queue_0 = new Queue<T>();
		queue_0 = new Queue<T>(ienumerable_0);
	}

	public int imethod_4()
	{
		return queue_0.Count;
	}

	public T imethod_2()
	{
		return (imethod_4() > 0) ? queue_0.Dequeue() : default(T);
	}

	public void imethod_3(T gparam_0)
	{
		queue_0.Enqueue(gparam_0);
	}

	public IEnumerable<GInterface7> imethod_0()
	{
		IEnumerable<GInterface7> result = default(IEnumerable<GInterface7>);
		return result;
	}

	public void imethod_1(GInterface12<T> ginterface12_0)
	{
		queue_0 = new Queue<T>(ginterface12_0.imethod_0(this));
	}
}
