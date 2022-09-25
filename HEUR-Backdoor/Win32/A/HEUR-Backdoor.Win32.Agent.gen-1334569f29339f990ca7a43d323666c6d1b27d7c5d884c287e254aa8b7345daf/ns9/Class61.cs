using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.ApplicationServices;

namespace ns9;

[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class Class61
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class62
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class62()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class63<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T gparam_0;

		[SpecialName]
		internal T method_0()
		{
			if (gparam_0 == null)
			{
				gparam_0 = new T();
			}
			return gparam_0;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class63()
		{
		}
	}

	private static readonly Class63<Class60> class63_0 = new Class63<Class60>();

	private static readonly Class63<Class59> class63_1 = new Class63<Class59>();

	private static readonly Class63<User> class63_2 = new Class63<User>();

	private static readonly Class63<Class62> class63_3 = new Class63<Class62>();

	[SpecialName]
	internal static Class60 smethod_0()
	{
		return class63_0.method_0();
	}
}
