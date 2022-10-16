using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InfoOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceService()
	{
	}
}
