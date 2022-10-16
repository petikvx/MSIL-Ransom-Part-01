using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ServiceWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateParameter()
	{
	}
}
