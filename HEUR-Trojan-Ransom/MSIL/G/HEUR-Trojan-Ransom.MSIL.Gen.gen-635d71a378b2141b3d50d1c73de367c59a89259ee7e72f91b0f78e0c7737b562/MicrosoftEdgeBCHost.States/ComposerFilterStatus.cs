using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ComposerFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceTokenizer()
	{
	}
}
