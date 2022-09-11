using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace White.Core.Bricks;

internal static class DelegateInvoker
{
	internal interface IActionInvokerWrapper
	{
		object Call(object[] args);
	}

	private delegate TReturn ActionInvoker<TArg0, TArg1, TArg2, TArg3, TArg4, TReturn>(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4);

	private delegate TReturn ActionInvoker<TArg0, TArg1, TArg2, TArg3, TReturn>(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3);

	private delegate TReturn ActionInvoker<TArg0, TArg1, TArg2, TReturn>(TArg0 arg0, TArg1 arg1, TArg2 arg2);

	private delegate TReturn ActionInvoker<TArg0, TArg1, TReturn>(TArg0 arg0, TArg1 arg1);

	private delegate TReturn ActionInvoker<TArg0, TReturn>(TArg0 arg0);

	private delegate TReturn ActionInvoker<TReturn>();

	private delegate void VoidActionInvoker<TArg0, TArg1, TArg2, TArg3, TArg4>(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4);

	private delegate void VoidActionInvoker<TArg0, TArg1, TArg2, TArg3>(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3);

	private delegate void VoidActionInvoker<TArg0, TArg1, TArg2>(TArg0 arg0, TArg1 arg1, TArg2 arg2);

	private delegate void VoidActionInvoker<TArg0, TArg1>(TArg0 arg0, TArg1 arg1);

	private delegate void VoidActionInvoker<TArg0>(TArg0 arg0);

	private delegate void VoidActionInvoker();

	private class ActionInvokerWrapper<TArg0, TArg1, TArg2, TArg3, TReturn> : IActionInvokerWrapper
	{
		private readonly ActionInvoker<TArg0, TArg1, TArg2, TArg3, TReturn> invoker;

		public ActionInvokerWrapper(ActionInvoker<TArg0, TArg1, TArg2, TArg3, TReturn> invoker)
		{
			this.invoker = invoker;
		}

		public object Call(object[] args)
		{
			TArg0 arg = Get<TArg0>(args[0]);
			TArg1 arg2 = Get<TArg1>(args[1]);
			TArg2 arg3 = Get<TArg2>(args[2]);
			TArg3 arg4 = Get<TArg3>(args[3]);
			TReturn val = invoker(arg, arg2, arg3, arg4);
			return val;
		}
	}

	private class ActionInvokerWrapper<TArg0, TArg1, TArg2, TReturn> : IActionInvokerWrapper
	{
		private readonly ActionInvoker<TArg0, TArg1, TArg2, TReturn> invoker;

		public ActionInvokerWrapper(ActionInvoker<TArg0, TArg1, TArg2, TReturn> invoker)
		{
			this.invoker = invoker;
		}

		public object Call(object[] args)
		{
			TArg0 arg = Get<TArg0>(args[0]);
			TArg1 arg2 = Get<TArg1>(args[1]);
			TArg2 arg3 = Get<TArg2>(args[2]);
			TReturn val = invoker(arg, arg2, arg3);
			return val;
		}
	}

	private class ActionInvokerWrapper<TArg0, TArg1, TReturn> : IActionInvokerWrapper
	{
		private readonly ActionInvoker<TArg0, TArg1, TReturn> invoker;

		public ActionInvokerWrapper(ActionInvoker<TArg0, TArg1, TReturn> invoker)
		{
			this.invoker = invoker;
		}

		public object Call(object[] args)
		{
			TArg0 arg = Get<TArg0>(args[0]);
			TArg1 arg2 = Get<TArg1>(args[1]);
			TReturn val = invoker(arg, arg2);
			return val;
		}
	}

	private class ActionInvokerWrapper<TArg0, TReturn> : IActionInvokerWrapper
	{
		private readonly ActionInvoker<TArg0, TReturn> invoker;

		public ActionInvokerWrapper(ActionInvoker<TArg0, TReturn> invoker)
		{
			this.invoker = invoker;
		}

		public object Call(object[] args)
		{
			TArg0 arg = Get<TArg0>(args[0]);
			TReturn val = invoker(arg);
			return val;
		}
	}

	private class ActionInvokerWrapper<TReturn> : IActionInvokerWrapper
	{
		private readonly ActionInvoker<TReturn> invoker;

		public ActionInvokerWrapper(ActionInvoker<TReturn> invoker)
		{
			this.invoker = invoker;
		}

		public object Call(object[] args)
		{
			TReturn val = invoker();
			return val;
		}
	}

	private class VoidActionInvokerWrapper<TArg0, TArg1, TArg2, TArg3> : IActionInvokerWrapper
	{
		private readonly VoidActionInvoker<TArg0, TArg1, TArg2, TArg3> invoker;

		public VoidActionInvokerWrapper(VoidActionInvoker<TArg0, TArg1, TArg2, TArg3> invoker)
		{
			this.invoker = invoker;
		}

		public object Call(object[] args)
		{
			TArg0 arg = Get<TArg0>(args[0]);
			TArg1 arg2 = Get<TArg1>(args[1]);
			TArg2 arg3 = Get<TArg2>(args[2]);
			TArg3 arg4 = Get<TArg3>(args[3]);
			invoker(arg, arg2, arg3, arg4);
			return null;
		}
	}

	private class VoidActionInvokerWrapper<TArg0, TArg1, TArg2> : IActionInvokerWrapper
	{
		private readonly VoidActionInvoker<TArg0, TArg1, TArg2> invoker;

		public VoidActionInvokerWrapper(VoidActionInvoker<TArg0, TArg1, TArg2> invoker)
		{
			this.invoker = invoker;
		}

		public object Call(object[] args)
		{
			TArg0 arg = Get<TArg0>(args[0]);
			TArg1 arg2 = Get<TArg1>(args[1]);
			TArg2 arg3 = Get<TArg2>(args[2]);
			invoker(arg, arg2, arg3);
			return null;
		}
	}

	private class VoidActionInvokerWrapper<TArg0, TArg1> : IActionInvokerWrapper
	{
		private readonly VoidActionInvoker<TArg0, TArg1> invoker;

		public VoidActionInvokerWrapper(VoidActionInvoker<TArg0, TArg1> invoker)
		{
			this.invoker = invoker;
		}

		public object Call(object[] args)
		{
			TArg0 arg = Get<TArg0>(args[0]);
			TArg1 arg2 = Get<TArg1>(args[1]);
			invoker(arg, arg2);
			return null;
		}
	}

	private class VoidActionInvokerWrapper<TArg0> : IActionInvokerWrapper
	{
		private readonly VoidActionInvoker<TArg0> invoker;

		public VoidActionInvokerWrapper(VoidActionInvoker<TArg0> invoker)
		{
			this.invoker = invoker;
		}

		public object Call(object[] args)
		{
			TArg0 arg = Get<TArg0>(args[0]);
			invoker(arg);
			return null;
		}
	}

	private class VoidActionInvokerWrapper : IActionInvokerWrapper
	{
		private readonly VoidActionInvoker invoker;

		public VoidActionInvokerWrapper(VoidActionInvoker invoker)
		{
			this.invoker = invoker;
		}

		public object Call(object[] args)
		{
			invoker();
			return null;
		}
	}

	private static readonly Type[] invokerTypes = new Type[6]
	{
		typeof(ActionInvoker<, , , , , >),
		typeof(ActionInvoker<, , , , >),
		typeof(ActionInvoker<, , , >),
		typeof(ActionInvoker<, , >),
		typeof(ActionInvoker<, >),
		typeof(ActionInvoker<>)
	};

	private static readonly Type[] invokerWrapperTypes = new Type[5]
	{
		typeof(ActionInvokerWrapper<, , , , >),
		typeof(ActionInvokerWrapper<, , , >),
		typeof(ActionInvokerWrapper<, , >),
		typeof(ActionInvokerWrapper<, >),
		typeof(ActionInvokerWrapper<>)
	};

	private static readonly Type[] voidInvokerTypes = new Type[6]
	{
		typeof(VoidActionInvoker<, , , , >),
		typeof(VoidActionInvoker<, , , >),
		typeof(VoidActionInvoker<, , >),
		typeof(VoidActionInvoker<, >),
		typeof(VoidActionInvoker<>),
		typeof(VoidActionInvoker)
	};

	private static readonly Type[] voidInvokerWrapperTypes = new Type[5]
	{
		typeof(VoidActionInvokerWrapper<, , , >),
		typeof(VoidActionInvokerWrapper<, , >),
		typeof(VoidActionInvokerWrapper<, >),
		typeof(VoidActionInvokerWrapper<>),
		typeof(VoidActionInvokerWrapper)
	};

	private static T Get<T>(object o)
	{
		if (o == null)
		{
			return default(T);
		}
		return (T)o;
	}

	public static IActionInvokerWrapper CreateInvoker(object target, MethodInfo method)
	{
		if (method.ReturnType == typeof(void))
		{
			return CreateReturnVoidInvoker(target, method);
		}
		List<Type> parameterTypes = new List<Type>();
		parameterTypes.AddRange(from x in method.GetParameters()
			select x.ParameterType);
		parameterTypes.Add(method.ReturnType);
		Type type = invokerTypes.SingleOrDefault((Type x) => x.GetGenericArguments().Length == parameterTypes.Count);
		if (type == null)
		{
			throw new ArgumentException($"Could not create an invoker for the method '{method}'. This type of method is not supported. Try reducing the number of arguments in action.");
		}
		type = type.MakeGenericType(parameterTypes.ToArray());
		Type type2 = invokerWrapperTypes.SingleOrDefault((Type x) => x.GetGenericArguments().Length == parameterTypes.Count);
		if (type2 == null)
		{
			throw new ArgumentException($"Could not create an invoker for the method '{method}'. This type of method is not supported. Try reducing the number of arguments in action.");
		}
		type2 = type2.MakeGenericType(parameterTypes.ToArray());
		Delegate @delegate = Delegate.CreateDelegate(type, target, method);
		object obj = Activator.CreateInstance(type2, @delegate);
		return (IActionInvokerWrapper)obj;
	}

	private static IActionInvokerWrapper CreateReturnVoidInvoker(object target, MethodInfo method)
	{
		List<Type> parameterTypes = new List<Type>();
		parameterTypes.AddRange(from x in method.GetParameters()
			select x.ParameterType);
		Type type = voidInvokerTypes.SingleOrDefault((Type x) => x.GetGenericArguments().Length == parameterTypes.Count);
		if (type == null)
		{
			throw new ArgumentException($"Could not create an invoker for the method '{method}'. This type of method is not supported. Try reducing the number of arguments in action.");
		}
		if (parameterTypes.Count > 0)
		{
			type = type.MakeGenericType(parameterTypes.ToArray());
		}
		Type type2 = voidInvokerWrapperTypes.SingleOrDefault((Type x) => x.GetGenericArguments().Length == parameterTypes.Count);
		if (type2 == null)
		{
			throw new ArgumentException($"Could not create an invoker for the method '{method}'. This type of method is not supported. Try reducing the number of arguments in action.");
		}
		if (parameterTypes.Count > 0)
		{
			type2 = type2.MakeGenericType(parameterTypes.ToArray());
		}
		Delegate @delegate = Delegate.CreateDelegate(type, target, method);
		object obj = Activator.CreateInstance(type2, @delegate);
		return (IActionInvokerWrapper)obj;
	}
}
