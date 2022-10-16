using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AttrBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrBridge()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeGlobal()
	{
	}
}
