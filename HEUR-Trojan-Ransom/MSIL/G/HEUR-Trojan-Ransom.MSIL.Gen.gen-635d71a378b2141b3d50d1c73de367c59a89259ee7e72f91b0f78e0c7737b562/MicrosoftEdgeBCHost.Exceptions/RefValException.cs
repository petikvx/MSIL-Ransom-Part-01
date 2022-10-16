using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RefValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefValException()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveAttr()
	{
	}
}
