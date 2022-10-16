using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RulesUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceMap()
	{
	}
}
