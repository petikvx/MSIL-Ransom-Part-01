using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ContainerPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralTask()
	{
	}
}
