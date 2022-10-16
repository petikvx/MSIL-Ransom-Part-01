using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MapOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceCode()
	{
	}
}
