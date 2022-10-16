using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class Collection : Attribute, _003CModule_003E, Collection
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Collection()
	{
		WriterPropertyProducer.ResolveStub();
		SortIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortIssuer()
	{
	}
}
