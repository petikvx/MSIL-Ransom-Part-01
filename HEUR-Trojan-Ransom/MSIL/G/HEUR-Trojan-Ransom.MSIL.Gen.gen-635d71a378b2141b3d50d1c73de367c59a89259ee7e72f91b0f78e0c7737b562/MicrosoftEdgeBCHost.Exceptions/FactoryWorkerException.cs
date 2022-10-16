using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FactoryWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateListener()
	{
	}
}
