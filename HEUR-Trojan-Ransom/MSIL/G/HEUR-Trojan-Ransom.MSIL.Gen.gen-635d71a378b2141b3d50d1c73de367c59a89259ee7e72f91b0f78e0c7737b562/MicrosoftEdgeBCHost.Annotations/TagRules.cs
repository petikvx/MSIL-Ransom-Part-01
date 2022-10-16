using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TagRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagRules()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectModel()
	{
	}
}
