using System.Runtime.CompilerServices;
using System.Threading;
using di1mqJMz;

namespace CCfpfC7h;

internal class QRIS1m6s
{
	public delegate void Delegate4();

	[CompilerGenerated]
	private Delegate4 CLNVUsrq;

	public event Delegate4 UAYjGD8k
	{
		[CompilerGenerated]
		add
		{
			Delegate4 @delegate = CLNVUsrq;
			Delegate4 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate4 value2 = (Delegate4)FFXb5i9i.PcI4tKMj(delegate2, value, 32722);
				@delegate = Interlocked.CompareExchange(ref CLNVUsrq, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		[CompilerGenerated]
		remove
		{
			Delegate4 @delegate = CLNVUsrq;
			Delegate4 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate4 value2 = (Delegate4)FFXb5i9i.PcI4tKMj(delegate2, value, 32723);
				@delegate = Interlocked.CompareExchange(ref CLNVUsrq, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	public void aUytqsyR()
	{
		CLNVUsrq?.Invoke();
	}
}
