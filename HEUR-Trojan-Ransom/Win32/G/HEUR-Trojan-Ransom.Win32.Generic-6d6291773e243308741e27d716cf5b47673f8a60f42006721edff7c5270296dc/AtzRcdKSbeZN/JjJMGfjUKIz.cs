using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace AtzRcdKSbeZN;

public class JjJMGfjUKIz : IEnumerable<string>, IEnumerable
{
	private Dictionary<ulong, VWKeLXnnElFS> nbmVkRUjzV;

	private Dictionary<ulong, VWKeLXnnElFS> rQwKEsntKTX;

	private readonly string AOqpCNAPEDfF;

	public int ycJWNjCWtgRy
	{
		get
		{
			AeteqMtZyJdt();
			return nbmVkRUjzV.Values.Count;
		}
	}

	public JjJMGfjUKIz(string EgoNJpDJtbkLgqTSHGW)
	{
		AOqpCNAPEDfF = EgoNJpDJtbkLgqTSHGW;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		AeteqMtZyJdt();
		List<string> list = new List<string>();
		foreach (VWKeLXnnElFS value in nbmVkRUjzV.Values)
		{
			list.Clear();
			VWKeLXnnElFS vWKeLXnnElFS = value;
			int num = -1;
			int num2;
			do
			{
				if (vWKeLXnnElFS.HOqcBeuVENElGsi != 0L)
				{
					list.Add(vWKeLXnnElFS.rvZOpHZlhDnGv);
				}
				vWKeLXnnElFS = (nbmVkRUjzV.ContainsKey(vWKeLXnnElFS.HOqcBeuVENElGsi) ? nbmVkRUjzV[vWKeLXnnElFS.HOqcBeuVENElGsi] : ((!rQwKEsntKTX.ContainsKey(vWKeLXnnElFS.HOqcBeuVENElGsi)) ? null : rQwKEsntKTX[vWKeLXnnElFS.HOqcBeuVENElGsi]));
				if (vWKeLXnnElFS == null)
				{
					break;
				}
				num = (num2 = num + 1);
			}
			while (num2 < 1000);
			if (list.Count != 0)
			{
				list.Reverse();
				yield return AOqpCNAPEDfF + '\\' + Path.Combine(list.ToArray());
			}
		}
	}

	private void AeteqMtZyJdt()
	{
		if (nbmVkRUjzV == null)
		{
			OurWxkqjeLlZjFC ourWxkqjeLlZjFC = new OurWxkqjeLlZjFC();
			ourWxkqjeLlZjFC.SQSBpaoscYlWesc(AOqpCNAPEDfF, null, out nbmVkRUjzV, out rQwKEsntKTX);
		}
	}
}
