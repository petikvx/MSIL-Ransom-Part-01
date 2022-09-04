using System;
using System.Runtime.CompilerServices;
using System.Threading;

internal class Class24 : IAsyncResult
{
	private object object_0;

	private AsyncCallback asyncCallback_0;

	private bool bool_0;

	private bool bool_1;

	private Exception exception_0;

	private ManualResetEvent manualResetEvent_0;

	public object AsyncState => object_0;

	WaitHandle IAsyncResult.AsyncWaitHandle => manualResetEvent_0;

	public bool CompletedSynchronously
	{
		get
		{
			return bool_0;
		}
		protected internal set
		{
			bool_0 = value;
		}
	}

	public bool IsCompleted
	{
		get
		{
			return bool_1;
		}
		protected internal set
		{
			bool_1 = value;
		}
	}

	public Class24(AsyncCallback asyncCallback_1, object object_1)
	{
		Class51.smethod_0();
		base._002Ector();
		asyncCallback_0 = asyncCallback_1;
		object_0 = object_1;
		manualResetEvent_0 = new ManualResetEvent(initialState: false);
	}

	[SpecialName]
	public ManualResetEvent method_0()
	{
		return manualResetEvent_0;
	}

	[SpecialName]
	public Exception method_3()
	{
		return exception_0;
	}

	public void method_4()
	{
		method_5(exception_0);
	}

	public void method_5(Exception exception_1)
	{
		exception_0 = exception_1;
		bool_1 = true;
		manualResetEvent_0.Set();
		if (asyncCallback_0 != null)
		{
			asyncCallback_0(this);
		}
	}
}
