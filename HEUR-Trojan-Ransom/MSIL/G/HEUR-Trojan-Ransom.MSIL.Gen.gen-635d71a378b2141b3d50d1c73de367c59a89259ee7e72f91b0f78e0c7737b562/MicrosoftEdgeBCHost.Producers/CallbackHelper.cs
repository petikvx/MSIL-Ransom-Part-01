using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CallbackHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackHelper()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralSerializer()
	{
	}
}
