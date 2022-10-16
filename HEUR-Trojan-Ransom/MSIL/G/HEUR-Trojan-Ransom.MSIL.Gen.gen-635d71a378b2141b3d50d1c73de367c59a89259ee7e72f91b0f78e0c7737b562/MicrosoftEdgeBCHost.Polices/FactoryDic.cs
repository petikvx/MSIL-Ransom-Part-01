using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FactoryDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryDic()
	{
		WriterPropertyProducer.ResolveStub();
		SetLiteralAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetLiteralAnnotation()
	{
	}
}
