using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IdentifierWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralSpecification()
	{
	}
}
