using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParamRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceModel()
	{
	}
}
