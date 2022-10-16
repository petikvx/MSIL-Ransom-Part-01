using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FilterWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralIterator()
	{
	}
}
