using System.Collections;
using System.Collections.Generic;

namespace lbBmsCGqmaavDk;

public class PeGGijSyohBfbV : IEnumerator
{
	private List<oBaGoFGSOWPojT> jnAmlNPgeTIe;

	private int AbApOeScVOi = -1;

	object IEnumerator.Current => jnAmlNPgeTIe[AbApOeScVOi];

	public PeGGijSyohBfbV(List<oBaGoFGSOWPojT> HmjMGABbINQs)
	{
		jnAmlNPgeTIe = HmjMGABbINQs;
	}

	bool IEnumerator.MoveNext()
	{
		AbApOeScVOi++;
		return AbApOeScVOi < jnAmlNPgeTIe.Count;
	}

	void IEnumerator.Reset()
	{
		AbApOeScVOi = -1;
	}
}
