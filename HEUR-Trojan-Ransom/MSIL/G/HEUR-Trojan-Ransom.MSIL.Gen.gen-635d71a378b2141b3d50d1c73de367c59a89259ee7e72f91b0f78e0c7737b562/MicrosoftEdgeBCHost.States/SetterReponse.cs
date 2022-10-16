using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SetterReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterReponse()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralConnection()
	{
	}
}
