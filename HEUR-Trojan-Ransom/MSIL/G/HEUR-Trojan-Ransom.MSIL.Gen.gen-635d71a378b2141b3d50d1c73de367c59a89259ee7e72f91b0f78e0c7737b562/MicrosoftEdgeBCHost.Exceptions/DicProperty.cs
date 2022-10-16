using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DicProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicProperty()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceAlgo()
	{
	}
}
