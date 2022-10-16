using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class Client
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Client()
	{
		WriterPropertyProducer.ResolveStub();
		ReadEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadEvent()
	{
	}
}
