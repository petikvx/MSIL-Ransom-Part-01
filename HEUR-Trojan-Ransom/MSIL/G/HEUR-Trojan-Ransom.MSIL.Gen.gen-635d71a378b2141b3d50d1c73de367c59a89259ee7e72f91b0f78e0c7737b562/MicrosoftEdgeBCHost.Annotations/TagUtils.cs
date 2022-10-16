using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TagUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagUtils()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceCollection()
	{
	}
}
