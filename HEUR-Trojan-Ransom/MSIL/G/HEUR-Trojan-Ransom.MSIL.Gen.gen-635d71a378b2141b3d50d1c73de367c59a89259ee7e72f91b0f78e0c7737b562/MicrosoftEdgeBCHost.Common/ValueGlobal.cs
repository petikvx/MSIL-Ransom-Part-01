using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ValueGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceComposer()
	{
	}
}
