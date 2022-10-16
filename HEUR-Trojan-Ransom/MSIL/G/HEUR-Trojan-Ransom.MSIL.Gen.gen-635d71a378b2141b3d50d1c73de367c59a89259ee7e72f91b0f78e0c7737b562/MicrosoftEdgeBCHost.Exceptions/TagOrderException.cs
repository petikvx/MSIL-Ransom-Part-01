using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TagOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceCollection()
	{
	}
}
