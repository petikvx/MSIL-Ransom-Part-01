using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class OrderProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderProperty()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceProccesor()
	{
	}
}
