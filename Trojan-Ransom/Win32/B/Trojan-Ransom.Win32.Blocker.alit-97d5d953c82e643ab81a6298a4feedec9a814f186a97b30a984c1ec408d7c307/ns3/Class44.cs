using System;
using System.Net;
using System.Reflection;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using ns0;
using ns5;
using ns7;
using ns8;

namespace ns3;

internal abstract class Class44
{
	public const string string_0 = "{1fe9e38e-05cc-46a3-ae48-6cda8fb62056}";

	public const string string_1 = "{395edd3b-130e-4160-bb08-6931086cea46}";

	private static readonly bool bool_0 = Convert.ToBoolean("False");

	internal static readonly string string_2 = "1";

	internal static Class44 class44_0;

	internal IWebProxy iwebProxy_0;

	internal EventHandler eventHandler_0;

	internal Delegate3 delegate3_0;

	internal static Class44 Handler
	{
		get
		{
			if (class44_0 == null)
			{
				Type[] types = Assembly.GetExecutingAssembly().GetTypes();
				foreach (Type type in types)
				{
					if ((object)type == null || (object)type.BaseType == null || (object)type.BaseType != typeof(Class44))
					{
						continue;
					}
					try
					{
						class44_0 = (Class44)Activator.CreateInstance(type, nonPublic: true);
						if (class44_0 != null)
						{
							break;
						}
					}
					catch
					{
					}
				}
			}
			return class44_0;
		}
	}

	public event EventHandler DebuggerLaunched
	{
		add
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event Delegate3 SendingReportFeedback
	{
		add
		{
			Delegate3 @delegate = delegate3_0;
			Delegate3 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate3 value2 = (Delegate3)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate3_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		remove
		{
			Delegate3 @delegate = delegate3_0;
			Delegate3 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate3 value2 = (Delegate3)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate3_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	protected abstract void vmethod_0(EventArgs1 e);

	protected abstract void vmethod_1(EventArgs0 e);

	protected abstract void vmethod_2(EventArgs2 e);

	protected virtual Guid vmethod_3()
	{
		return Guid.Empty;
	}

	internal bool method_0(SecurityException exception)
	{
		EventArgs2 eventArgs = new EventArgs2(exception);
		vmethod_2(eventArgs);
		if (eventArgs.bool_1)
		{
			return false;
		}
		if (!eventArgs.bool_0)
		{
			Application.Exit();
		}
		return true;
	}

	[Attribute10("Unhandled Exception Encountered")]
	internal unsafe void method_1(Exception exception, bool canContinue, bool manuallyReported)
	{
		void* ptr = stackalloc byte[5];
		Type type = exception.GetType();
		if (type.Name == "UnhandledException" && type.Namespace == "SmartAssembly.SmartExceptionsCore")
		{
			exception = (Exception)type.GetField("PreviousException")!.GetValue(exception);
		}
		((byte*)ptr)[4] = 1;
		if (exception == null || exception is ThreadAbortException)
		{
			return;
		}
		try
		{
			Class35 @class = new Class35(vmethod_3(), exception, iwebProxy_0);
			@class.SendingReportFeedback += new Delegate3(this, (nint)(delegate*<Class44, object, EventArgs3, void>)(&Class32.smethod_103));
			@class.DebuggerLaunched += new EventHandler(this, (nint)(delegate*<Class44, object, EventArgs, void>)(&Class32.smethod_128));
			@class.FatalException += method_2;
			EventArgs1 eventArgs = new EventArgs1(@class, exception);
			if (Class32.smethod_11() != null)
			{
				eventArgs.bool_0 = true;
			}
			if (!canContinue)
			{
				eventArgs.bool_2 = false;
				eventArgs.bool_3 = false;
			}
			else if (manuallyReported || bool_0)
			{
				eventArgs.bool_2 = false;
				eventArgs.bool_3 = true;
			}
			vmethod_0(eventArgs);
			((byte*)ptr)[4] = ((!eventArgs.bool_3) ? ((byte)1) : ((byte)0));
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception fatalException)
		{
			vmethod_1(new EventArgs0(fatalException));
		}
		if (((byte*)ptr)[4] == 0)
		{
			return;
		}
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		*(int*)ptr = 0;
		while (*(int*)ptr < assemblies.Length)
		{
			Assembly assembly = assemblies[*(int*)ptr];
			try
			{
				string fullName = assembly.FullName;
				if (fullName.EndsWith("31bf3856ad364e35") && fullName.StartsWith("PresentationFramework,"))
				{
					object obj = assembly.GetType("System.Windows.Application")!.GetProperty("Current")!.GetGetMethod()!.Invoke(null, null);
					obj.GetType().GetMethod("Shutdown", new Type[0])!.Invoke(obj, null);
				}
			}
			catch
			{
			}
			(*(int*)ptr)++;
		}
		try
		{
			Application.Exit();
		}
		catch
		{
			try
			{
				Environment.Exit(0);
			}
			catch
			{
			}
		}
	}

	private void method_2(object sender, EventArgs0 e)
	{
		vmethod_1(e);
	}
}
