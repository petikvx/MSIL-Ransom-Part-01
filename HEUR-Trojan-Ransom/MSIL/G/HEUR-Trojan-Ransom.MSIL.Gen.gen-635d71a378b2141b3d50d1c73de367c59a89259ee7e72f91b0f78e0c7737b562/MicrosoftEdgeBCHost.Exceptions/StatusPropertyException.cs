using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class StatusPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralProxy()
	{
	}
}
