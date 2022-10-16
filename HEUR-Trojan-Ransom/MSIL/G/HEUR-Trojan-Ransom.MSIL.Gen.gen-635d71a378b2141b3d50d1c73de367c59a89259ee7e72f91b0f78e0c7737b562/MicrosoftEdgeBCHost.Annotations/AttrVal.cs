using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AttrVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrVal()
	{
		WriterPropertyProducer.ResolveStub();
		StartUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartUtils()
	{
	}
}
