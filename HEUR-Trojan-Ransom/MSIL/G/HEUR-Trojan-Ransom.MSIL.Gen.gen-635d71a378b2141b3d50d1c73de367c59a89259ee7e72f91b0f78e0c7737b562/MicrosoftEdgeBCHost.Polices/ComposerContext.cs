using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ComposerContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerContext()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceSingleton()
	{
	}
}
