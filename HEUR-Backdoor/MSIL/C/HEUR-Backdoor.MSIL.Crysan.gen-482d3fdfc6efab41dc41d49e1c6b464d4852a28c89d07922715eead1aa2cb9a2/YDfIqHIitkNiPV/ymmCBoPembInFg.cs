using System.Collections;
using System.Collections.Generic;

namespace YDfIqHIitkNiPV;

public class ymmCBoPembInFg : IEnumerator
{
	private List<UsnwLsVggjVevszVi> FERqDAusvgFrz;

	private int GgpitXfAPUqO = -1;

	object IEnumerator.Current => FERqDAusvgFrz[GgpitXfAPUqO];

	public ymmCBoPembInFg(List<UsnwLsVggjVevszVi> cOBQvNymtTCoc)
	{
		FERqDAusvgFrz = cOBQvNymtTCoc;
	}

	bool IEnumerator.MoveNext()
	{
		GgpitXfAPUqO++;
		return GgpitXfAPUqO < FERqDAusvgFrz.Count;
	}

	void IEnumerator.Reset()
	{
		GgpitXfAPUqO = -1;
	}
}
