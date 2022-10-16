using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ManagerWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeMap()
	{
	}
}
