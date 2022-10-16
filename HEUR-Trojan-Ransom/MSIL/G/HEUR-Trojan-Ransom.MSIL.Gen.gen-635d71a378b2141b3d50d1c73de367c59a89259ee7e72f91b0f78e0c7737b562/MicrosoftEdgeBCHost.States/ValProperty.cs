using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ValProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValProperty()
	{
		WriterPropertyProducer.ResolveStub();
		MapInterfaceProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapInterfaceProccesor()
	{
	}
}
