using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SerializerBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerBridge()
	{
		WriterPropertyProducer.ResolveStub();
		NewAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewAdapter()
	{
	}
}
