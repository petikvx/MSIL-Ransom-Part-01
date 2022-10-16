using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ValGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		NewInterfaceListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInterfaceListener()
	{
	}
}
