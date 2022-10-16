using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CandidateBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateBridge()
	{
		WriterPropertyProducer.ResolveStub();
		PushRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushRecord()
	{
	}
}
