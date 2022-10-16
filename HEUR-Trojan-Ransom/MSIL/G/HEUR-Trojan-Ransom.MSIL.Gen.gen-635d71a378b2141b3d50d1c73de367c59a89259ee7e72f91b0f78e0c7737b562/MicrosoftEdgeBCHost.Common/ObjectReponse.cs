using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ObjectReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectReponse()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceConsumer()
	{
	}
}
