using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PrototypeWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		CallStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallStrategy()
	{
	}
}
