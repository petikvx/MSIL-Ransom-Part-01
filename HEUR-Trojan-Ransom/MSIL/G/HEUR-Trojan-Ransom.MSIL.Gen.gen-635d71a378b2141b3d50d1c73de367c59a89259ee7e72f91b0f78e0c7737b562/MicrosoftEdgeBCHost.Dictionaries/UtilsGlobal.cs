using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class UtilsGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceListener()
	{
	}
}
