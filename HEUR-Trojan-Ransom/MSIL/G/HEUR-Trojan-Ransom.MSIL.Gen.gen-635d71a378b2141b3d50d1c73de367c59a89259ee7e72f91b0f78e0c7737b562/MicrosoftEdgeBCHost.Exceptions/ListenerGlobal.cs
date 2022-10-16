using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ListenerGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceComposer()
	{
	}
}
