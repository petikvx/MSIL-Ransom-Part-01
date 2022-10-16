using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InstanceRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInterfaceParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInterfaceParameter()
	{
	}
}
