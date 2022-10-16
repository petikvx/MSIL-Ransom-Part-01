using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RefObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefObject()
	{
		WriterPropertyProducer.ResolveStub();
		GetLiteralCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetLiteralCandidate()
	{
	}
}
