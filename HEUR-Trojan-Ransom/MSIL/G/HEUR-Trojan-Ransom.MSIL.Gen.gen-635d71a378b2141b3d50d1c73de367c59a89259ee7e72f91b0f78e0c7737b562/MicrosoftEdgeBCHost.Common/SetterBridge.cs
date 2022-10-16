using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SetterBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterBridge()
	{
		WriterPropertyProducer.ResolveStub();
		StartQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartQueue()
	{
	}
}
