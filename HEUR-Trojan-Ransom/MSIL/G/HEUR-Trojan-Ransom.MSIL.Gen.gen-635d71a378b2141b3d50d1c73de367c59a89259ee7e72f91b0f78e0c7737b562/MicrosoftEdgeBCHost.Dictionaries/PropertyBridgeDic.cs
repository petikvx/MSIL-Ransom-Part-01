using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PropertyBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		SetupToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupToken()
	{
	}
}
