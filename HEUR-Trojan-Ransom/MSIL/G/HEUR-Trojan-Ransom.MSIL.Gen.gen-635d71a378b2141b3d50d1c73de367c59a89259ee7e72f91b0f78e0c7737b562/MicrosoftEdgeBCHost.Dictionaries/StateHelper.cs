using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StateHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateHelper()
	{
		WriterPropertyProducer.ResolveStub();
		GetLiteralInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetLiteralInvocation()
	{
	}
}
