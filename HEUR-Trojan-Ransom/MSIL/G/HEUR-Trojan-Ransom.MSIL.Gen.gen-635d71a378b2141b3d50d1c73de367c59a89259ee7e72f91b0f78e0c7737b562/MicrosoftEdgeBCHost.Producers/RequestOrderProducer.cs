using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RequestOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceVisitor()
	{
	}
}
