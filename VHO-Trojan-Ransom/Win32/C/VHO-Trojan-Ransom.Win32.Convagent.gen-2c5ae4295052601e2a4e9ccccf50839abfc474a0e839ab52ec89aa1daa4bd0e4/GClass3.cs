using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

public class GClass3
{
	public interface GInterface0
	{
		void SetupFunctions(IntPtr objectAddress);
	}

	public abstract class GClass4<TNativeFunctions> : GInterface0
	{
		protected IntPtr intptr_0;

		protected TNativeFunctions gparam_0;

		private readonly Dictionary<IntPtr, Delegate> dictionary_0 = new Dictionary<IntPtr, Delegate>();

		public override string ToString()
		{
			return $"Steam Interface<{typeof(TNativeFunctions)}> #{intptr_0.ToInt32():X8}";
		}

		public void SetupFunctions(IntPtr objectAddress)
		{
			intptr_0 = objectAddress;
			IntPtr ptr = Marshal.ReadIntPtr(intptr_0);
			gparam_0 = (TNativeFunctions)Marshal.PtrToStructure(ptr, typeof(TNativeFunctions));
		}

		protected Delegate method_0<TDelegate>(IntPtr intptr_1)
		{
			Delegate @delegate;
			if (!dictionary_0.ContainsKey(intptr_1))
			{
				@delegate = Marshal.GetDelegateForFunctionPointer(intptr_1, typeof(TDelegate));
				dictionary_0[intptr_1] = @delegate;
			}
			else
			{
				@delegate = dictionary_0[intptr_1];
			}
			return @delegate;
		}

		protected TDelegate method_1<TDelegate>(IntPtr intptr_1) where TDelegate : class
		{
			return (TDelegate)(object)method_0<TDelegate>(intptr_1);
		}
	}

	[DefaultMember("Item")]
	internal class Class0
	{
		private ulong ulong_0;

		public Class0(ulong value)
		{
			ulong_0 = value;
		}

		[SpecialName]
		public ulong method_0()
		{
			return ulong_0;
		}

		[SpecialName]
		public void method_1(ulong ulong_1)
		{
			ulong_0 = ulong_1;
		}

		[SpecialName]
		public ulong method_2(uint uint_0, ulong ulong_1)
		{
			return (ulong_0 >> (int)(ushort)uint_0) & ulong_1;
		}

		[SpecialName]
		public void method_3(uint uint_0, ulong ulong_1, ulong ulong_2)
		{
			ulong_0 = (ulong_0 & ~(ulong_1 << (int)(ushort)uint_0)) | ((ulong_2 & ulong_1) << (int)(ushort)uint_0);
		}
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	internal class InterfaceVersionAttribute : Attribute
	{
		[CompilerGenerated]
		private string string_0;

		[SpecialName]
		[CompilerGenerated]
		public string method_0()
		{
			return string_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_1(string string_1)
		{
			string_0 = string_1;
		}

		public InterfaceVersionAttribute(string versionIdentifier)
		{
			method_1(versionIdentifier);
		}
	}

	public static string smethod_0(string string_0)
	{
		return Encoding.UTF8.GetString(Encoding.Default.GetBytes(string_0));
	}

	public static TClass smethod_1<TClass>(IntPtr intptr_0) where TClass : GInterface0, new()
	{
		if (intptr_0 == IntPtr.Zero)
		{
			return default(TClass);
		}
		TClass result = new TClass();
		result.SetupFunctions(intptr_0);
		return result;
	}
}
