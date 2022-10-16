using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CallbackContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackContext()
	{
		WriterPropertyProducer.ResolveStub();
		ViewInterfaceContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewInterfaceContainer()
	{
	}
}
