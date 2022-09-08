using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace lDGzIQtUhAc;

public class anEOIYMImR : IEnumerable<string>, IEnumerable
{
	private Dictionary<ulong, FQjZRyaCEZhgul> zQBmIUdGCsbxBI;

	private Dictionary<ulong, FQjZRyaCEZhgul> bDxQudTCZjakxD;

	private readonly string QhkhGGCUaJt;

	public int oDtkeEvVxvFupQ
	{
		get
		{
			DUDlKmWEQgazw();
			return zQBmIUdGCsbxBI.Values.Count;
		}
	}

	public anEOIYMImR(string OCQhysmrXpLne)
	{
		QhkhGGCUaJt = OCQhysmrXpLne;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		DUDlKmWEQgazw();
		List<string> list = new List<string>();
		foreach (FQjZRyaCEZhgul value in zQBmIUdGCsbxBI.Values)
		{
			list.Clear();
			FQjZRyaCEZhgul fQjZRyaCEZhgul = value;
			int num = -1;
			int num3;
			do
			{
				if (fQjZRyaCEZhgul.RXunVtZjltU != 0L)
				{
					list.Add(fQjZRyaCEZhgul.CJyLygOmEsxy);
				}
				fQjZRyaCEZhgul = (zQBmIUdGCsbxBI.ContainsKey(fQjZRyaCEZhgul.RXunVtZjltU) ? zQBmIUdGCsbxBI[fQjZRyaCEZhgul.RXunVtZjltU] : ((!bDxQudTCZjakxD.ContainsKey(fQjZRyaCEZhgul.RXunVtZjltU)) ? null : bDxQudTCZjakxD[fQjZRyaCEZhgul.RXunVtZjltU]));
				if (fQjZRyaCEZhgul != null)
				{
					int num2;
					num = (num2 = num + 1);
					num3 = ((num2 < 1000) ? 1 : 0);
				}
				else
				{
					num3 = 0;
				}
			}
			while (num3 != 0);
			if (list.Count != 0)
			{
				list.Reverse();
				yield return QhkhGGCUaJt + '\\' + Path.Combine(list.ToArray());
			}
		}
	}

	private void DUDlKmWEQgazw()
	{
		if (zQBmIUdGCsbxBI == null)
		{
			fKDKvCIpwZXoyDo fKDKvCIpwZXoyDo2 = new fKDKvCIpwZXoyDo();
			fKDKvCIpwZXoyDo2.ZkTiGJrClka(QhkhGGCUaJt, null, out zQBmIUdGCsbxBI, out bDxQudTCZjakxD);
		}
	}
}
