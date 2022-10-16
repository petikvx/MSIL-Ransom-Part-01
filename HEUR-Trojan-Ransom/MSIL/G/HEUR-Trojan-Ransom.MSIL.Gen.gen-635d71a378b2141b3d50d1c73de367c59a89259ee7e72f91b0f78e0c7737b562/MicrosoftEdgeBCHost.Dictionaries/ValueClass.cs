using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ValueClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueClass()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceReponse()
	{
	}
}
