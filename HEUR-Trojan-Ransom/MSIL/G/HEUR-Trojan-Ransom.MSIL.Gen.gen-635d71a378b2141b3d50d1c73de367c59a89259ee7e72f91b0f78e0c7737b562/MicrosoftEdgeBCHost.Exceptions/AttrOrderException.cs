using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AttrOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfaceInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfaceInstance()
	{
	}
}
