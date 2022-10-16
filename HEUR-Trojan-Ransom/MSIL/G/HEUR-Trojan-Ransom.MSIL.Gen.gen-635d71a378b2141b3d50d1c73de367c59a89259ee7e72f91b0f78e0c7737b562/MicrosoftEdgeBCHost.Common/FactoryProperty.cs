using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class FactoryProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryProperty()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceBridge()
	{
	}
}
