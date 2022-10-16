using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class Account
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Account()
	{
		WriterPropertyProducer.ResolveStub();
		CheckIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckIdentifier()
	{
	}
}
