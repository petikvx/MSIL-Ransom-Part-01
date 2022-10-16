using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ContainerSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralAttribute()
	{
	}
}
