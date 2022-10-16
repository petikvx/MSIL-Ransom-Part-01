using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RegProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegProperty()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceState()
	{
	}
}
