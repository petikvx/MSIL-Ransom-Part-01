using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RulesWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralIterator()
	{
	}
}
