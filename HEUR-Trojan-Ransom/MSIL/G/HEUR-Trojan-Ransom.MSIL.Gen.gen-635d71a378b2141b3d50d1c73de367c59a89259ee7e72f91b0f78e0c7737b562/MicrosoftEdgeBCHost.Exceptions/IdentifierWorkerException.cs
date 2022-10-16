using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class IdentifierWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		FindProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindProxy()
	{
	}
}
