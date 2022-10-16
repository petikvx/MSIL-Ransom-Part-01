using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MessageGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfacePage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfacePage()
	{
	}
}
