using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MessageWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageWorker()
	{
		WriterPropertyProducer.ResolveStub();
		ReadCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadCallback()
	{
	}
}
