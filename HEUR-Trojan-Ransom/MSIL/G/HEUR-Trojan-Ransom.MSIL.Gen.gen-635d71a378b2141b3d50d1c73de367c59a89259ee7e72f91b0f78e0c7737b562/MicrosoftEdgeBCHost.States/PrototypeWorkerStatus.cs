using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PrototypeWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralCreator()
	{
	}
}
