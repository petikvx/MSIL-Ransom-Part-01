using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DicRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicRules()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteTag()
	{
	}
}
