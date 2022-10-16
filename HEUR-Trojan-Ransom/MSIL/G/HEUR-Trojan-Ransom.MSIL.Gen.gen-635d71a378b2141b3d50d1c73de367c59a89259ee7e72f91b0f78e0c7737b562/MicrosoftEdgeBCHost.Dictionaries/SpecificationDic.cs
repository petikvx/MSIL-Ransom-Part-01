using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SpecificationDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationDic()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeLiteralDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeLiteralDatabase()
	{
	}
}
