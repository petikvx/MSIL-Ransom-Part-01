using System.Collections;
using System.Collections.Generic;

namespace ns17;

public class GClass16 : IEnumerator
{
	private List<GClass18> list_0;

	private int int_0 = -1;

	object IEnumerator.Current => list_0[int_0];

	public GClass16(List<GClass18> list_1)
	{
		list_0 = list_1;
	}

	bool IEnumerator.MoveNext()
	{
		int_0++;
		return int_0 < list_0.Count;
	}

	void IEnumerator.Reset()
	{
		int_0 = -1;
	}
}
