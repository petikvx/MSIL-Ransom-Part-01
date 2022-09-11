using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.Collections;

public static class ProtobufEqualityComparers
{
	private sealed class BitwiseDoubleEqualityComparerImpl : EqualityComparer<double>
	{
		[NonSerialized]
		internal static GetString getString_0;

		public override bool Equals(double x, double y)
		{
			return BitConverter.DoubleToInt64Bits(x) == BitConverter.DoubleToInt64Bits(y);
		}

		public override int GetHashCode(double obj)
		{
			return BitConverter.DoubleToInt64Bits(obj).GetHashCode();
		}

		static BitwiseDoubleEqualityComparerImpl()
		{
			Strings.CreateGetStringDelegate(typeof(BitwiseDoubleEqualityComparerImpl));
			bool bool_ = false;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107400774), getString_0(107400769)).Replace(getString_0(107400732), getString_0(107400727)));
			if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107400722)))
			{
				throw new SecurityException(getString_0(107400697));
			}
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
	}

	private sealed class BitwiseSingleEqualityComparerImpl : EqualityComparer<float>
	{
		public override bool Equals(float x, float y)
		{
			return BitConverter.DoubleToInt64Bits(x) == BitConverter.DoubleToInt64Bits(y);
		}

		public override int GetHashCode(float obj)
		{
			return BitConverter.DoubleToInt64Bits(obj).GetHashCode();
		}
	}

	private sealed class BitwiseNullableDoubleEqualityComparerImpl : EqualityComparer<double?>
	{
		[NonSerialized]
		internal static GetString getString_0;

		public override bool Equals(double? x, double? y)
		{
			if (!x.HasValue && !y.HasValue)
			{
				return true;
			}
			if (x.HasValue && y.HasValue)
			{
				return BitwiseDoubleEqualityComparer.Equals(x.Value, y.Value);
			}
			return false;
		}

		public override int GetHashCode(double? obj)
		{
			if (obj.HasValue)
			{
				return BitwiseDoubleEqualityComparer.GetHashCode(obj.Value);
			}
			return 293864;
		}

		static BitwiseNullableDoubleEqualityComparerImpl()
		{
			Strings.CreateGetStringDelegate(typeof(BitwiseNullableDoubleEqualityComparerImpl));
			bool bool_ = false;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107400775), getString_0(107400770)).Replace(getString_0(107400733), getString_0(107400728)));
			if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107400723)))
			{
				throw new SecurityException(getString_0(107400698));
			}
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
	}

	private sealed class BitwiseNullableSingleEqualityComparerImpl : EqualityComparer<float?>
	{
		public override bool Equals(float? x, float? y)
		{
			if (!x.HasValue && !y.HasValue)
			{
				return true;
			}
			if (x.HasValue && y.HasValue)
			{
				return BitwiseSingleEqualityComparer.Equals(x.Value, y.Value);
			}
			return false;
		}

		public override int GetHashCode(float? obj)
		{
			if (obj.HasValue)
			{
				return BitwiseSingleEqualityComparer.GetHashCode(obj.Value);
			}
			return 293864;
		}
	}

	public static EqualityComparer<double> BitwiseDoubleEqualityComparer { get; } = new BitwiseDoubleEqualityComparerImpl();


	public static EqualityComparer<float> BitwiseSingleEqualityComparer { get; } = new BitwiseSingleEqualityComparerImpl();


	public static EqualityComparer<double?> BitwiseNullableDoubleEqualityComparer { get; } = new BitwiseNullableDoubleEqualityComparerImpl();


	public static EqualityComparer<float?> BitwiseNullableSingleEqualityComparer { get; } = new BitwiseNullableSingleEqualityComparerImpl();


	public static EqualityComparer<T> GetEqualityComparer<T>()
	{
		if (!(typeof(T) == typeof(double)))
		{
			if (!(typeof(T) == typeof(float)))
			{
				if (!(typeof(T) == typeof(double?)))
				{
					if (!(typeof(T) == typeof(float?)))
					{
						return EqualityComparer<T>.Default;
					}
					return (EqualityComparer<T>)(object)BitwiseNullableSingleEqualityComparer;
				}
				return (EqualityComparer<T>)(object)BitwiseNullableDoubleEqualityComparer;
			}
			return (EqualityComparer<T>)(object)BitwiseSingleEqualityComparer;
		}
		return (EqualityComparer<T>)(object)BitwiseDoubleEqualityComparer;
	}
}
