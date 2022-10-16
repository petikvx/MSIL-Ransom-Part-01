using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StateFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateFacade()
	{
		WriterPropertyProducer.ResolveStub();
		ReadLiteralPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadLiteralPolicy()
	{
	}
}
