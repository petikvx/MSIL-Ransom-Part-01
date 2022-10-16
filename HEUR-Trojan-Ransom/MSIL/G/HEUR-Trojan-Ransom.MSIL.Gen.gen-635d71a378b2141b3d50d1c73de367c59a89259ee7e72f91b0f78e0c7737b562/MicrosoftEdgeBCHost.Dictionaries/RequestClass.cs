using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RequestClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestClass()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceObserver()
	{
	}
}
