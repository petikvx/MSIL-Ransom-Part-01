using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConfigOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceVisitor()
	{
	}
}
