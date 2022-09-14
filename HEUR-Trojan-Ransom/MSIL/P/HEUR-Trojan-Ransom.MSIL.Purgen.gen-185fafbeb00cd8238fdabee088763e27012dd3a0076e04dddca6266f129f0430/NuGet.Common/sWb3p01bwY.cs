using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

namespace NuGet.Common;

public class sWb3p01bwY : ICredentials
{
	[CompilerGenerated]
	private sealed class bvipFBA9pk
	{
		public string nvjQ9lgLO8;

		internal bool ZN7HhdQF1a(string ddRJkPVtXt)
		{
			return StringComparer.OrdinalIgnoreCase.Equals(ddRJkPVtXt, nvjQ9lgLO8);
		}
	}

	[CompilerGenerated]
	private readonly IReadOnlyList<string> _3N8UfxwZ7C;

	[CompilerGenerated]
	private readonly NetworkCredential _69YfYBHYzc;

	public IReadOnlyList<string> t4IG2K4bwS
	{
		[CompilerGenerated]
		get
		{
			return _3N8UfxwZ7C;
		}
	}

	public NetworkCredential z3SwWo4tNK
	{
		[CompilerGenerated]
		get
		{
			return _69YfYBHYzc;
		}
	}

	public sWb3p01bwY(NetworkCredential innerCredential, IEnumerable<string> authTypes)
	{
		if (innerCredential == null)
		{
			throw new ArgumentNullException("innerCredential");
		}
		if (authTypes == null)
		{
			throw new ArgumentNullException("authTypes");
		}
		_69YfYBHYzc = innerCredential;
		_3N8UfxwZ7C = new List<string>(authTypes);
	}

	public NetworkCredential oJXT66zLCi(Uri bJ0L1cHqHJ, string dvdY6xEAOq)
	{
		if (dvdY6xEAOq != null && t4IG2K4bwS.Any() && !t4IG2K4bwS.Any((string ddRJkPVtXt) => StringComparer.OrdinalIgnoreCase.Equals(ddRJkPVtXt, dvdY6xEAOq)))
		{
			return null;
		}
		return z3SwWo4tNK.GetCredential(bJ0L1cHqHJ, dvdY6xEAOq);
	}
}
