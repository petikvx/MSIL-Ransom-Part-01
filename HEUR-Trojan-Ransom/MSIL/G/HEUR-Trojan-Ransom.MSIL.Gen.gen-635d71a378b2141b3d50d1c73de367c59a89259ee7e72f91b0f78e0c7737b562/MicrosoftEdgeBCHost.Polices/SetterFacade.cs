using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SetterFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterFacade()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralBase()
	{
	}
}
