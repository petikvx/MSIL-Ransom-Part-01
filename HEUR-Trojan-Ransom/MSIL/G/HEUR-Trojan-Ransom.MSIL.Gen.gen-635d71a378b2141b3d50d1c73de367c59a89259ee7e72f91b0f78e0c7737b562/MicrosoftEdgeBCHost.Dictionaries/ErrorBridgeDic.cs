using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ErrorBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInvocation()
	{
	}
}
