using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PoolOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		DefineInterfaceContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineInterfaceContext()
	{
	}
}
