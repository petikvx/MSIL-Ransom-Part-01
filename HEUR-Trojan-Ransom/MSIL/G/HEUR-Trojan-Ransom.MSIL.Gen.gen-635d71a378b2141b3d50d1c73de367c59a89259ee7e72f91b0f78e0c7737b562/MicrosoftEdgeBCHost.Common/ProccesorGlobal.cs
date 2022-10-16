using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ProccesorGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceStrategy()
	{
	}
}
