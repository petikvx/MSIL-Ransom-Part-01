using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ServerAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		MapInterfaceRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapInterfaceRules()
	{
	}
}
