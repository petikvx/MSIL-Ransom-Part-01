using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AttributeValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceDic()
	{
	}
}
