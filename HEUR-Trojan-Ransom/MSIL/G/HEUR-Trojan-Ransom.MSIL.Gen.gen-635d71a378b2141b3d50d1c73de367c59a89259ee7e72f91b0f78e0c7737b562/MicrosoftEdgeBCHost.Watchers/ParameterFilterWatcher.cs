using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ParameterFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CallStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallStruct()
	{
	}
}
