using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Text;
using Babble2ents;
using Dorso0atera0;
using Geologe8s;
using N1grophob1;
using ns4;
using ns5;

namespace Aste7isms;

public static class GClass1
{
	public static void smethod_0(Exception Morc8au, ILogger Cirr4strati)
	{
		No4retur4ables(Morc8au, Cirr4strati, Aden5mas: false);
	}

	public static void No4retur4ables(Exception exception_0, ILogger Slav2r2r, bool Aden5mas)
	{
		Exception ex = C7efs(exception_0);
		if (ex is ILogMessageException ex2)
		{
			ILogMessage message = ex2.AsLogMessage();
			Slav2r2r.Log(message);
		}
		else
		{
			Slav2r2r.Log(new Extra2agate(Te3timonie3.Error, Tro3hanter(ex)));
		}
		Te3timonie3 un1isguise = ((!Aden5mas && !Int3nsion.Anth0opology.S7uffbox) ? Te3timonie3.Verbose : Te3timonie3.Error);
		Slav2r2r.Log(Extra2agate.smethod_1(un1isguise, ex.ToString()));
	}

	public static string D1scomfort1ng(Exception Pe4n, bool Hom8no8d)
	{
		if (Pe4n == null)
		{
			throw new ArgumentNullException("exception");
		}
		if (Pe4n is AggregateException t5atc5y)
		{
			return Be66ers(t5atc5y);
		}
		if (Pe4n is TargetInvocationException sages)
		{
			return T2uncate(sages);
		}
		return Sp6r6z66n(smethod_1(Pe4n), Hom8no8d);
	}

	public static string Tro3hanter(Exception exception_0)
	{
		return D1scomfort1ng(exception_0, Hom8no8d: true);
	}

	public static string Be66ers(AggregateException T5atc5y)
	{
		if (T5atc5y == null)
		{
			throw new ArgumentNullException("exception");
		}
		return Sp6r6z66n(C2nfirmati2n(T5atc5y), C7ndel7s: true);
	}

	public static string T2uncate(TargetInvocationException Sages6)
	{
		if (Sages6 == null)
		{
			throw new ArgumentNullException("exception");
		}
		return Sp6r6z66n(Goldenne55e5(Sages6), C7ndel7s: true);
	}

	public static Exception C7efs(Exception Reass4mes)
	{
		if (Reass4mes == null)
		{
			throw new ArgumentNullException("exception");
		}
		if (Reass4mes.InnerException == null)
		{
			return Reass4mes;
		}
		if (!(Reass4mes is AggregateException) && !(Reass4mes is TargetInvocationException))
		{
			return Reass4mes;
		}
		return Reass4mes.GetBaseException();
	}

	private static IEnumerable<string> C2nfirmati2n(AggregateException Alm0giving0)
	{
		ReadOnlyCollection<Exception> innerExceptions = Alm0giving0.Flatten().InnerExceptions;
		if ((innerExceptions?.Count ?? 0) != 0)
		{
			foreach (Exception item in innerExceptions)
			{
				foreach (string item2 in smethod_1(item))
				{
					yield return item2;
				}
			}
		}
		else
		{
			yield return Alm0giving0.Message;
		}
	}

	private static IEnumerable<string> Goldenne55e5(TargetInvocationException Jigs2wn)
	{
		if (Jigs2wn.InnerException != null)
		{
			return smethod_1(Jigs2wn.InnerException);
		}
		return new string[1] { Jigs2wn.Message };
	}

	private static IEnumerable<string> smethod_1(Exception R1lat1r)
	{
		Exception current = R1lat1r;
		string previous = null;
		while (current != null)
		{
			if (current.Message != null && current.Message != previous)
			{
				previous = current.Message;
				yield return current.Message;
			}
			current = current.InnerException;
		}
	}

	private static IEnumerable<string> P3lpit3nt(string Yp5rit5)
	{
		using StringReader reader = new StringReader(Yp5rit5);
		string text;
		while ((text = reader.ReadLine()) != null)
		{
			yield return text;
		}
	}

	private static string Sp6r6z66n(IEnumerable<string> S4estas, bool C7ndel7s)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string S4esta in S4estas)
		{
			bool flag = C7ndel7s && stringBuilder.Length > 0;
			foreach (string item in P3lpit3nt(S4esta))
			{
				if (flag)
				{
					stringBuilder.Append("  ");
				}
				stringBuilder.AppendLine(item);
			}
		}
		return stringBuilder.ToString().TrimEnd(Array.Empty<char>());
	}
}
