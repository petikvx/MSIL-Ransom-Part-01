using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MethodRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceCreator()
	{
	}
}
