using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CreatorProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorProperty()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceDecorator()
	{
	}
}
