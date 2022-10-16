using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParamsFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsFacade()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralItem()
	{
	}
}
