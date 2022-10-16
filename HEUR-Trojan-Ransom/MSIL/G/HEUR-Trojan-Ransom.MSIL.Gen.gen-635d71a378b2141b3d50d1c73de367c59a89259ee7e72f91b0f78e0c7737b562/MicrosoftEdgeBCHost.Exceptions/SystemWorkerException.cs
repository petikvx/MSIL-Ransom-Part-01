using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SystemWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		ReadPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadPublisher()
	{
	}
}
