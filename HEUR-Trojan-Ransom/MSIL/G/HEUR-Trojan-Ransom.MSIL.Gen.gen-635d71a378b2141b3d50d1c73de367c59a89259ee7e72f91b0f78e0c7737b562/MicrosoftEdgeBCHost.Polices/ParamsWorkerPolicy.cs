using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ParamsWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DefineInterfaceParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineInterfaceParam()
	{
	}
}
