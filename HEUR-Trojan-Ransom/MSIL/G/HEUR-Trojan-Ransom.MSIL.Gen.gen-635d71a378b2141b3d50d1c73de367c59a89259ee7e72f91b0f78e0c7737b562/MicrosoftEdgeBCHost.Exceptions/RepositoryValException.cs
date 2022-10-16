using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RepositoryValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryValException()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteDescriptor()
	{
	}
}
