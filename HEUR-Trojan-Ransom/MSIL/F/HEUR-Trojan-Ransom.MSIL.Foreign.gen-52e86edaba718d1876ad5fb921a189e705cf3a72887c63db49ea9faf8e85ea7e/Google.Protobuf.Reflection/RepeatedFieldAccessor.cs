using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.Reflection;

internal sealed class RepeatedFieldAccessor : FieldAccessorBase
{
	[NonSerialized]
	internal static GetString getString_1;

	internal RepeatedFieldAccessor(PropertyInfo property, FieldDescriptor descriptor)
		: base(property, descriptor)
	{
	}

	public override void Clear(IMessage message)
	{
		((IList)GetValue(message)).Clear();
	}

	public override void SetValue(IMessage message, object value)
	{
		throw new InvalidOperationException(getString_1(107471785));
	}

	static RepeatedFieldAccessor()
	{
		Strings.CreateGetStringDelegate(typeof(RepeatedFieldAccessor));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_1(107400730), getString_1(107400725)).Replace(getString_1(107400688), getString_1(107400683)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_1(107400678)))
		{
			throw new SecurityException(getString_1(107400653));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
