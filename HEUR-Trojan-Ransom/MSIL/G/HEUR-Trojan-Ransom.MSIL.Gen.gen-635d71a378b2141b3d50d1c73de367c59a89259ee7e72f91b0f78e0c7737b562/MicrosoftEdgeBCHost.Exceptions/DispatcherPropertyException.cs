using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DispatcherPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		FlushLiteralSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushLiteralSchema()
	{
	}
}
