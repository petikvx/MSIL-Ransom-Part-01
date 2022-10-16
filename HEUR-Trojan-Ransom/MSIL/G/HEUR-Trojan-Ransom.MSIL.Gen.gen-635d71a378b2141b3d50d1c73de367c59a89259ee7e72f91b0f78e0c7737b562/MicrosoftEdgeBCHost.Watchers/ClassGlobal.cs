using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ClassGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceSchema()
	{
	}
}
