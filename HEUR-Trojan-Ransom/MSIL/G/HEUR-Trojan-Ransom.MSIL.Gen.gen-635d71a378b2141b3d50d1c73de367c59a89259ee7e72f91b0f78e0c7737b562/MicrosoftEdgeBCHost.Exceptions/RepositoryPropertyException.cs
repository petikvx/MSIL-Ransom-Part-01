using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RepositoryPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralRequest()
	{
	}
}
