using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SchemaWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		FillModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillModel()
	{
	}
}
