using System.Collections;
using System.Collections.Generic;

namespace rgA69G;

public class Qvo7GYCkNi1w : IEnumerator
{
	private List<GClass0> a;

	private int b = -1;

	object IEnumerator.Current => a[b];

	public Qvo7GYCkNi1w(List<GClass0> DvrNWiXyglABg)
	{
		a = DvrNWiXyglABg;
	}

	bool IEnumerator.MoveNext()
	{
		b++;
		return b < a.Count;
	}

	void IEnumerator.Reset()
	{
		b = -1;
	}
}
