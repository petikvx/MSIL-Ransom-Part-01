using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ExpressionFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceCandidate()
	{
	}
}
