using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace aHIHEJJDItp;

public class tIliaSnEsIleoe : IEnumerable<string>, IEnumerable
{
	private Dictionary<ulong, hQgegBUtUPxP> agfqtFvfhwZFK;

	private Dictionary<ulong, hQgegBUtUPxP> cZoOxbbPVwJ;

	private readonly string NNjfDzzYdeSty;

	public int LqnaWBnZrpV
	{
		get
		{
			VzUlAmQeMz();
			return agfqtFvfhwZFK.Values.Count;
		}
	}

	public tIliaSnEsIleoe(string kmVEusmMiI)
	{
		NNjfDzzYdeSty = kmVEusmMiI;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		VzUlAmQeMz();
		List<string> list = new List<string>();
		foreach (hQgegBUtUPxP value in agfqtFvfhwZFK.Values)
		{
			list.Clear();
			hQgegBUtUPxP hQgegBUtUPxP2 = value;
			int num = -1;
			int num2;
			do
			{
				if (hQgegBUtUPxP2.SIpqTjUQsyFUD != 0L)
				{
					list.Add(hQgegBUtUPxP2.BfXxdkfxUKO);
				}
				hQgegBUtUPxP2 = (agfqtFvfhwZFK.ContainsKey(hQgegBUtUPxP2.SIpqTjUQsyFUD) ? agfqtFvfhwZFK[hQgegBUtUPxP2.SIpqTjUQsyFUD] : ((!cZoOxbbPVwJ.ContainsKey(hQgegBUtUPxP2.SIpqTjUQsyFUD)) ? null : cZoOxbbPVwJ[hQgegBUtUPxP2.SIpqTjUQsyFUD]));
				if (hQgegBUtUPxP2 == null)
				{
					break;
				}
				num = (num2 = num + 1);
			}
			while (num2 < 1000);
			if (list.Count != 0)
			{
				list.Reverse();
				yield return NNjfDzzYdeSty + '\\' + Path.Combine(list.ToArray());
			}
		}
	}

	private void VzUlAmQeMz()
	{
		if (agfqtFvfhwZFK == null)
		{
			tvZewxrGkJhFBiv tvZewxrGkJhFBiv2 = new tvZewxrGkJhFBiv();
			tvZewxrGkJhFBiv2.fOEHuFJGbysHO(NNjfDzzYdeSty, null, out agfqtFvfhwZFK, out cZoOxbbPVwJ);
		}
	}
}
