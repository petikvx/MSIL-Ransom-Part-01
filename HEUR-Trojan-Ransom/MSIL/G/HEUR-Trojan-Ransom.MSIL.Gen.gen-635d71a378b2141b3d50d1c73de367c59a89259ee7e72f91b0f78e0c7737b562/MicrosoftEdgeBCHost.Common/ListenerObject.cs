using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ListenerObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerObject()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralParameter()
	{
	}
}
