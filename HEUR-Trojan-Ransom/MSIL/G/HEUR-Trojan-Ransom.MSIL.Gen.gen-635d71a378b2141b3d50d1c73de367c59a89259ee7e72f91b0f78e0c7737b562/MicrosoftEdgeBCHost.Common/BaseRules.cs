using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class BaseRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseRules()
	{
		WriterPropertyProducer.ResolveStub();
		PatchContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchContext()
	{
	}
}
