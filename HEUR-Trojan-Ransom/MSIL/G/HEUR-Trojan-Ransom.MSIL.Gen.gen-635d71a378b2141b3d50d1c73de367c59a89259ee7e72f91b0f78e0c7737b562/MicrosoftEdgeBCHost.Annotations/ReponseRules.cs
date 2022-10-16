using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ReponseRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseRules()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeTag()
	{
	}
}
