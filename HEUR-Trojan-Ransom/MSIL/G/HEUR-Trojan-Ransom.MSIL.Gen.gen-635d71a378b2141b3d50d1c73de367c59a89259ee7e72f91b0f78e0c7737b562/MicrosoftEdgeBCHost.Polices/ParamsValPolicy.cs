using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ParamsValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DefineSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineSerializer()
	{
	}
}
