using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class Reg
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Reg()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectIdentifier()
	{
	}
}
