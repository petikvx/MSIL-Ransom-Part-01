using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PolicyAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PopLiteralCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopLiteralCustomer()
	{
	}
}
