using System;
using System.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.Reflection;

public sealed class OneofAccessor
{
	private readonly Func<IMessage, int> caseDelegate;

	private readonly Action<IMessage> clearDelegate;

	private OneofDescriptor descriptor;

	[NonSerialized]
	internal static GetString getString_0;

	public OneofDescriptor Descriptor => descriptor;

	internal OneofAccessor(PropertyInfo caseProperty, MethodInfo clearMethod, OneofDescriptor descriptor)
	{
		if (!caseProperty.CanRead)
		{
			throw new ArgumentException(getString_0(107471934));
		}
		this.descriptor = descriptor;
		caseDelegate = ReflectionUtil.CreateFuncIMessageT<int>(caseProperty.GetGetMethod());
		this.descriptor = descriptor;
		clearDelegate = ReflectionUtil.CreateActionIMessage(clearMethod);
	}

	public void Clear(IMessage message)
	{
		clearDelegate(message);
	}

	public FieldDescriptor GetCaseFieldDescriptor(IMessage message)
	{
		int num = caseDelegate(message);
		if (num > 0)
		{
			return descriptor.ContainingType.FindFieldByNumber(num);
		}
		return null;
	}

	static OneofAccessor()
	{
		Strings.CreateGetStringDelegate(typeof(OneofAccessor));
	}
}
