using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ManagerValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerValException()
	{
		WriterPropertyProducer.ResolveStub();
		FillMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillMap()
	{
	}
}
