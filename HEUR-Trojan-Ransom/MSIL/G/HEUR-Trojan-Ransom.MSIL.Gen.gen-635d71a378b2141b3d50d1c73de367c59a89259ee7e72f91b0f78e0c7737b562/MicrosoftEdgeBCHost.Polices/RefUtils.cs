using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RefUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefUtils()
	{
		WriterPropertyProducer.ResolveStub();
		MoveInterfaceVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveInterfaceVal()
	{
	}
}
