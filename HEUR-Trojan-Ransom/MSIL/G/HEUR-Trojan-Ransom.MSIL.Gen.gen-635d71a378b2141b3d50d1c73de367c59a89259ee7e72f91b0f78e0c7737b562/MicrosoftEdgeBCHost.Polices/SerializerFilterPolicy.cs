using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SerializerFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CalcCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcCode()
	{
	}
}
