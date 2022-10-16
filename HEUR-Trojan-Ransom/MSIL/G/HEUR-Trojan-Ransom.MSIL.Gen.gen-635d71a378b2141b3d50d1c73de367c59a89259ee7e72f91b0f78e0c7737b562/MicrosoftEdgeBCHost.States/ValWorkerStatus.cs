using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ValWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralIterator()
	{
	}
}
