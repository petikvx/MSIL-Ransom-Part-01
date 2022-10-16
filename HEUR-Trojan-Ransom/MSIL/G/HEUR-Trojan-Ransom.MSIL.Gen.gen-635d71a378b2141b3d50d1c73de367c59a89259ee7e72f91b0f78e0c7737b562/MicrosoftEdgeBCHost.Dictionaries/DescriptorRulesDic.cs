using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DescriptorRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceDatabase()
	{
	}
}
