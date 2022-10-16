using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ComposerValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceObject()
	{
	}
}
