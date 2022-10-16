using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ErrorOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfacePage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfacePage()
	{
	}
}
