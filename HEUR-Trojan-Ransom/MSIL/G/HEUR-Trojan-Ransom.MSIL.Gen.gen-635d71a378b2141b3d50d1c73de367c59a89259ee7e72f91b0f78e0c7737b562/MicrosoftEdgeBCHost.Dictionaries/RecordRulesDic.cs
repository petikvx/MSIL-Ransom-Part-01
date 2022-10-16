using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RecordRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterfaceModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterfaceModel()
	{
	}
}
