using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.Reflection;

internal abstract class FieldAccessorBase : IFieldAccessor
{
	private readonly Func<IMessage, object> getValueDelegate;

	private readonly FieldDescriptor descriptor;

	[NonSerialized]
	internal static GetString getString_0;

	public FieldDescriptor Descriptor => descriptor;

	internal FieldAccessorBase(PropertyInfo property, FieldDescriptor descriptor)
	{
		this.descriptor = descriptor;
		getValueDelegate = ReflectionUtil.CreateFuncIMessageObject(property.GetGetMethod());
	}

	public object GetValue(IMessage message)
	{
		return getValueDelegate(message);
	}

	public abstract void Clear(IMessage message);

	public abstract void SetValue(IMessage message, object value);

	static FieldAccessorBase()
	{
		Strings.CreateGetStringDelegate(typeof(FieldAccessorBase));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107400637), getString_0(107400632)).Replace(getString_0(107400595), getString_0(107400590)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107400585)))
		{
			throw new SecurityException(getString_0(107400560));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
