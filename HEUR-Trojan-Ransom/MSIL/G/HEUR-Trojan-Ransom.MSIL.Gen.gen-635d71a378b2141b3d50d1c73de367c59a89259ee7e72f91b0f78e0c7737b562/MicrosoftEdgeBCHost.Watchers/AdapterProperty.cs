using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AdapterProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterProperty()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceProccesor()
	{
	}
}
