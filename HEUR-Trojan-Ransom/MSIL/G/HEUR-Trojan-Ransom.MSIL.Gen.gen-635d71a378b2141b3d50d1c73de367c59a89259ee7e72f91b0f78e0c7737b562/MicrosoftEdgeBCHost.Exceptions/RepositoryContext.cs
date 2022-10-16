using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RepositoryContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryContext()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceRequest()
	{
	}
}
