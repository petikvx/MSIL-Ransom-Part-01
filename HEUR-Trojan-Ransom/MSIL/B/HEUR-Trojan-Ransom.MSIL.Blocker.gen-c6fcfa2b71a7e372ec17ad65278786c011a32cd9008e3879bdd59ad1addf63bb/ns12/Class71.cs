using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;
using ns7;

namespace ns12;

internal static class Class71
{
	internal static class Class72
	{
		public const string string_0 = "Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string string_1 = "Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string string_2 = "Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string string_3 = "Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string string_4 = "Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		internal static object? object_0;

		internal static object? object_1;

		internal static Delegate1<object?, object?>? delegate1_0;

		internal static Delegate1<object?, object?>? delegate1_1;

		internal static bool bool_0;
	}

	public static IEnumerable<string> smethod_0(this IDynamicMetaObjectProvider idynamicMetaObjectProvider_0)
	{
		return idynamicMetaObjectProvider_0.GetMetaObject(Expression.Constant(idynamicMetaObjectProvider_0)).GetDynamicMemberNames();
	}
}
