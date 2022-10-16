using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InfoFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoFilter()
	{
		WriterPropertyProducer.ResolveStub();
		InitCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitCandidate()
	{
	}
}
