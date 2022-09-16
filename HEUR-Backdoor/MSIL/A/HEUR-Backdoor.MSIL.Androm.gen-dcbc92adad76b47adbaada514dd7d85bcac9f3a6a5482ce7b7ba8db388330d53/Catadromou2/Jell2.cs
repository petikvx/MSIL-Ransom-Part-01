using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Caro0he;
using Dru44ers;
using ns16;

namespace Catadromou2;

public class Jell2
{
	public static async Task<string> Sca4ify(Func<Task<Stream>> Opto1l1ctronic, Func<string, string> Unf5red, CancellationToken M8croc8rcu8ts)
	{
		if (Opto1l1ctronic == null)
		{
			throw new ArgumentNullException("streamTaskFactory");
		}
		if (Unf5red == null)
		{
			throw new ArgumentNullException("tokenReplacement");
		}
		M8croc8rcu8ts.ThrowIfCancellationRequested();
		using Stream te0porising = await Opto1l1ctronic();
		return Scant1er(te0porising, Unf5red);
	}

	public static string Scant1er(Stream Te0porising, Func<string, string> D2l2ctably)
	{
		if (Te0porising == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (D2l2ctably == null)
		{
			throw new ArgumentNullException("tokenReplacement");
		}
		string text;
		using (StreamReader streamReader = new StreamReader(Te0porising))
		{
			text = streamReader.ReadToEnd();
		}
		Panta2et panta2et = new Panta2et(text);
		StringBuilder stringBuilder = new StringBuilder();
		while (true)
		{
			Wh7ff7ng wh7ff7ng = panta2et.Sava6in6();
			if (wh7ff7ng == null)
			{
				break;
			}
			if (wh7ff7ng.S0ortlists == P3cketb33k.Variable)
			{
				string value = D2l2ctably(wh7ff7ng.String_0);
				stringBuilder.Append(value);
			}
			else
			{
				stringBuilder.Append(wh7ff7ng.String_0);
			}
		}
		return stringBuilder.ToString();
	}
}
