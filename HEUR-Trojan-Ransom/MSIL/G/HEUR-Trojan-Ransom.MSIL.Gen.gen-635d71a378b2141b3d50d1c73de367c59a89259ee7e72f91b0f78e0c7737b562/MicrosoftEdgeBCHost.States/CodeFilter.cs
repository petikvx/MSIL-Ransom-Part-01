using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CodeFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeFilter()
	{
		WriterPropertyProducer.ResolveStub();
		ReadCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadCandidate()
	{
	}
}
