using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ManagerAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralInitializer()
	{
	}
}
