using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PrototypeState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeState()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceTag()
	{
	}
}
