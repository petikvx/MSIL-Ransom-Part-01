using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CandidateContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateContext()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceRequest()
	{
	}
}
