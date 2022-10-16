using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TagContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagContext()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceSingleton()
	{
	}
}
