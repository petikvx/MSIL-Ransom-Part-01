using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MessageContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageContext()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceVisitor()
	{
	}
}
