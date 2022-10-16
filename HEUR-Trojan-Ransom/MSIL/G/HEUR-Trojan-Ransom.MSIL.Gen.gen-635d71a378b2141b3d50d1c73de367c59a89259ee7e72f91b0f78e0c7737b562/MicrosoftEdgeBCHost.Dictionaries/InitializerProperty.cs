using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InitializerProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerProperty()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceAttribute()
	{
	}
}
