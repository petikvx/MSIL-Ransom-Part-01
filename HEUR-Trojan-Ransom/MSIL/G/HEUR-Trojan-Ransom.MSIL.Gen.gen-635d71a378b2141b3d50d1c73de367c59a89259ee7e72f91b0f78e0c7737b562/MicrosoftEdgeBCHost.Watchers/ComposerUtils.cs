using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ComposerUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerUtils()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceCollection()
	{
	}
}
