using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ParamsReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsReponse()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralManager()
	{
	}
}
