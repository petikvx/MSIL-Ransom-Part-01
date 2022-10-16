using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CallbackSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralDescriptor()
	{
	}
}
