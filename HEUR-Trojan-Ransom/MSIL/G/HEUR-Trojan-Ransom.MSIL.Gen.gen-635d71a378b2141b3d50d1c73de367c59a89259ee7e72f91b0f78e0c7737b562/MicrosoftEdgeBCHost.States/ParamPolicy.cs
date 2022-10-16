using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ParamPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceProcess()
	{
	}
}
