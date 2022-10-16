using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class GlobalState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalState()
	{
		WriterPropertyProducer.ResolveStub();
		CloneInterfaceRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneInterfaceRecord()
	{
	}
}
