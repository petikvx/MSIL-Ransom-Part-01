using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CodeBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SearchParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchParameter()
	{
	}
}
