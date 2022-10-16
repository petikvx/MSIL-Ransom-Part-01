using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SpecificationFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralState()
	{
	}
}
