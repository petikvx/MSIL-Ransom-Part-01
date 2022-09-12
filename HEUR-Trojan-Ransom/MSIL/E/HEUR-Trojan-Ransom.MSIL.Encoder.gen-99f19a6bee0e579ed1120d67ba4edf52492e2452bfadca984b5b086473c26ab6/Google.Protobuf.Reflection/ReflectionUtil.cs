using System;
using System.Reflection;

namespace Google.Protobuf.Reflection;

internal static class ReflectionUtil
{
	private interface IReflectionHelper
	{
		Func<IMessage, int> CreateFuncIMessageInt32(MethodInfo method);

		Action<IMessage> CreateActionIMessage(MethodInfo method);

		Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method);

		Action<IMessage, object> CreateActionIMessageObject(MethodInfo method);
	}

	private class ReflectionHelper<T1, T2> : IReflectionHelper
	{
		public Func<IMessage, int> CreateFuncIMessageInt32(MethodInfo method)
		{
			if (CanConvertEnumFuncToInt32Func)
			{
				Func<T1, int> del2 = (Func<T1, int>)method.CreateDelegate(typeof(Func<T1, int>));
				return (IMessage message) => del2((T1)message);
			}
			Func<T1, T2> del = (Func<T1, T2>)method.CreateDelegate(typeof(Func<T1, T2>));
			return (IMessage message) => (int)(object)del((T1)message);
		}

		public Action<IMessage> CreateActionIMessage(MethodInfo method)
		{
			Action<T1> del = (Action<T1>)method.CreateDelegate(typeof(Action<T1>));
			return delegate(IMessage message)
			{
				del((T1)message);
			};
		}

		public Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method)
		{
			Func<T1, T2> del = (Func<T1, T2>)method.CreateDelegate(typeof(Func<T1, T2>));
			return (IMessage message) => del((T1)message);
		}

		public Action<IMessage, object> CreateActionIMessageObject(MethodInfo method)
		{
			Action<T1, T2> del = (Action<T1, T2>)method.CreateDelegate(typeof(Action<T1, T2>));
			return delegate(IMessage message, object arg)
			{
				del((T1)message, (T2)arg);
			};
		}
	}

	public enum SampleEnum
	{
		X
	}

	internal static readonly Type[] EmptyTypes;

	private static bool CanConvertEnumFuncToInt32Func { get; }

	static ReflectionUtil()
	{
		EmptyTypes = new Type[0];
		CanConvertEnumFuncToInt32Func = CheckCanConvertEnumFuncToInt32Func();
		ForceInitialize<string>();
		ForceInitialize<int>();
		ForceInitialize<long>();
		ForceInitialize<uint>();
		ForceInitialize<ulong>();
		ForceInitialize<float>();
		ForceInitialize<double>();
		ForceInitialize<bool>();
		ForceInitialize<int?>();
		ForceInitialize<long?>();
		ForceInitialize<uint?>();
		ForceInitialize<ulong?>();
		ForceInitialize<float?>();
		ForceInitialize<double?>();
		ForceInitialize<bool?>();
		ForceInitialize<SampleEnum>();
		SampleEnumMethod();
	}

	internal static void ForceInitialize<T>()
	{
		new ReflectionHelper<IMessage, T>();
	}

	internal static Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method)
	{
		return GetReflectionHelper(method.DeclaringType, method.ReturnType).CreateFuncIMessageObject(method);
	}

	internal static Func<IMessage, int> CreateFuncIMessageInt32(MethodInfo method)
	{
		return GetReflectionHelper(method.DeclaringType, method.ReturnType).CreateFuncIMessageInt32(method);
	}

	internal static Action<IMessage, object> CreateActionIMessageObject(MethodInfo method)
	{
		return GetReflectionHelper(method.DeclaringType, method.GetParameters()[0].ParameterType).CreateActionIMessageObject(method);
	}

	internal static Action<IMessage> CreateActionIMessage(MethodInfo method)
	{
		return GetReflectionHelper(method.DeclaringType, typeof(object)).CreateActionIMessage(method);
	}

	private static IReflectionHelper GetReflectionHelper(Type t1, Type t2)
	{
		return (IReflectionHelper)Activator.CreateInstance(typeof(ReflectionHelper<, >).MakeGenericType(t1, t2));
	}

	private static bool CheckCanConvertEnumFuncToInt32Func()
	{
		try
		{
			typeof(ReflectionUtil).GetMethod("SampleEnumMethod")!.CreateDelegate(typeof(Func<int>));
			return true;
		}
		catch (ArgumentException)
		{
			return false;
		}
	}

	public static SampleEnum SampleEnumMethod()
	{
		return SampleEnum.X;
	}
}
