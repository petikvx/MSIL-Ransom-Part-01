using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ServiceValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceValDic()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralAdvisor()
	{
	}
}
