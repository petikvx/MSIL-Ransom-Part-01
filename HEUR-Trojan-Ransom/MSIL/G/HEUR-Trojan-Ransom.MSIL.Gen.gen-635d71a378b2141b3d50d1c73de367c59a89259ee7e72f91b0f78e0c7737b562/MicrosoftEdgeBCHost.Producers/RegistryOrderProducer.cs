using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RegistryOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceVisitor()
	{
	}
}
