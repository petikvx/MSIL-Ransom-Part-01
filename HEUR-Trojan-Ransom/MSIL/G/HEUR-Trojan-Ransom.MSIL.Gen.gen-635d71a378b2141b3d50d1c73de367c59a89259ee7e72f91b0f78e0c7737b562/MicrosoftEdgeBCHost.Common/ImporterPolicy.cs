using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ImporterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceField()
	{
	}
}
