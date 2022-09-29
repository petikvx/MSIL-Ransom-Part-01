using System.Collections;
using System.Collections.Generic;

namespace MlfWmjHrDtM;

public class zwYyzCRfIl : IEnumerator
{
	private List<BkiLYFLOLaOffh> ukkISmsyEsB;

	private int VrgepZWXNX = -1;

	object IEnumerator.Current => ukkISmsyEsB[VrgepZWXNX];

	public zwYyzCRfIl(List<BkiLYFLOLaOffh> dXoCdDjHEY)
	{
		ukkISmsyEsB = dXoCdDjHEY;
	}

	bool IEnumerator.MoveNext()
	{
		VrgepZWXNX++;
		return VrgepZWXNX < ukkISmsyEsB.Count;
	}

	void IEnumerator.Reset()
	{
		VrgepZWXNX = -1;
	}
}
