using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ContextObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextObject()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralOrder()
	{
	}
}
