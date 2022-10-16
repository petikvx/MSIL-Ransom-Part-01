using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RoleAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralProperty()
	{
	}
}
