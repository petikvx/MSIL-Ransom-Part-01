using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MappingClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingClass()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceItem()
	{
	}
}
