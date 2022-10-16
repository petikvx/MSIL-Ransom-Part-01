using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ListenerOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		DefineInterfaceProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineInterfaceProccesor()
	{
	}
}
