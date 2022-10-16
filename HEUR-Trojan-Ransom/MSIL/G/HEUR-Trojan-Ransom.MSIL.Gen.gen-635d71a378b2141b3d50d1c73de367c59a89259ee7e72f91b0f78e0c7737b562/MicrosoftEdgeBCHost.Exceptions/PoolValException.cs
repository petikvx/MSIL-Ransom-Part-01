using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PoolValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolValException()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyMapper()
	{
	}
}
