using System;
using System.Collections;

namespace Org.BouncyCastle.Utilities.Collections;

public class UnmodifiableListProxy : UnmodifiableList
{
	private readonly IList l;

	public override int Count => l.Count;

	public override bool IsFixedSize => l.IsFixedSize;

	public override bool IsSynchronized => l.IsSynchronized;

	public override object SyncRoot => l.SyncRoot;

	public UnmodifiableListProxy(IList l)
	{
		this.l = l;
	}

	public override bool Contains(object o)
	{
		return l.Contains(o);
	}

	public override void CopyTo(Array array, int index)
	{
		l.CopyTo(array, index);
	}

	public override IEnumerator GetEnumerator()
	{
		return l.GetEnumerator();
	}

	public override int IndexOf(object o)
	{
		return l.IndexOf(o);
	}

	protected override object GetValue(int i)
	{
		return l[i];
	}
}
