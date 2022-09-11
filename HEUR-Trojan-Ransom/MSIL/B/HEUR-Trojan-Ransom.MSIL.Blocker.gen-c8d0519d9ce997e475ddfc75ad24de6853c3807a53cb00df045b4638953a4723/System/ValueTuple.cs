using System.Collections;
using System.Collections.Generic;
using System.Numerics.Hashing;
using System.Runtime.InteropServices;

namespace System;

[StructLayout(LayoutKind.Sequential, Size = 1)]
public struct ValueTuple : ITupleInternal, IStructuralEquatable, IStructuralComparable, IComparable, IEquatable<ValueTuple>, IComparable<ValueTuple>
{
	int ITupleInternal.Size => 0;

	public override bool Equals(object obj)
	{
		return obj is ValueTuple;
	}

	public bool Equals(ValueTuple other)
	{
		return true;
	}

	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		return other is ValueTuple;
	}

	int IComparable.CompareTo(object other)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is ValueTuple))
		{
			throw new ArgumentException(SR.ArgumentException_ValueTupleIncorrectType, "other");
		}
		return 0;
	}

	public int CompareTo(ValueTuple other)
	{
		return 0;
	}

	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is ValueTuple))
		{
			throw new ArgumentException(SR.ArgumentException_ValueTupleIncorrectType, "other");
		}
		return 0;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return 0;
	}

	int ITupleInternal.GetHashCode(IEqualityComparer comparer)
	{
		return 0;
	}

	public override string ToString()
	{
		return "()";
	}

	string ITupleInternal.ToStringEnd()
	{
		return ")";
	}

	public static ValueTuple Create()
	{
		return default(ValueTuple);
	}

	public static ValueTuple<T1> Create<T1>(T1 item1)
	{
		return new ValueTuple<T1>(item1);
	}

	public static (T1, T2) Create<T1, T2>(T1 item1, T2 item2)
	{
		return (item1, item2);
	}

	public static (T1, T2, T3) Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
	{
		return (item1, item2, item3);
	}

	public static (T1, T2, T3, T4) Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4)
	{
		return (item1, item2, item3, item4);
	}

	public static (T1, T2, T3, T4, T5) Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
	{
		return (item1, item2, item3, item4, item5);
	}

	public static (T1, T2, T3, T4, T5, T6) Create<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
	{
		return (item1, item2, item3, item4, item5, item6);
	}

	public static (T1, T2, T3, T4, T5, T6, T7) Create<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
	{
		return (item1, item2, item3, item4, item5, item6, item7);
	}

	public static (T1, T2, T3, T4, T5, T6, T7, T8) Create<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
	{
		return new ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8>>(item1, item2, item3, item4, item5, item6, item7, Create(item8));
	}

	internal static int CombineHashCodes(int h1, int h2)
	{
		return HashHelpers.Combine(h1, h2);
	}

	internal static int CombineHashCodes(int h1, int h2, int h3)
	{
		return CombineHashCodes(CombineHashCodes(h1, h2), h3);
	}

	internal static int CombineHashCodes(int h1, int h2, int h3, int h4)
	{
		return CombineHashCodes(CombineHashCodes(h1, h2, h3), h4);
	}

	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5)
	{
		return CombineHashCodes(CombineHashCodes(h1, h2, h3, h4), h5);
	}

	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6)
	{
		return CombineHashCodes(CombineHashCodes(h1, h2, h3, h4, h5), h6);
	}

	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7)
	{
		return CombineHashCodes(CombineHashCodes(h1, h2, h3, h4, h5, h6), h7);
	}

	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8)
	{
		return CombineHashCodes(CombineHashCodes(h1, h2, h3, h4, h5, h6, h7), h8);
	}
}
public struct ValueTuple<T1> : ITupleInternal, IStructuralEquatable, IStructuralComparable, IComparable, IEquatable<ValueTuple<T1>>, IComparable<ValueTuple<T1>>
{
	public T1 Item1;

	int ITupleInternal.Size => 1;

	public ValueTuple(T1 item1)
	{
		Item1 = item1;
	}

	public override bool Equals(object obj)
	{
		if (obj is ValueTuple<T1>)
		{
			return Equals((ValueTuple<T1>)obj);
		}
		return false;
	}

	public bool Equals(ValueTuple<T1> other)
	{
		return EqualityComparer<T1>.Default.Equals(Item1, other.Item1);
	}

	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		if (other != null && other is ValueTuple<T1> valueTuple)
		{
			return comparer.Equals(Item1, valueTuple.Item1);
		}
		return false;
	}

	int IComparable.CompareTo(object other)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is ValueTuple<T1> valueTuple))
		{
			throw new ArgumentException(SR.ArgumentException_ValueTupleIncorrectType, "other");
		}
		return Comparer<T1>.Default.Compare(Item1, valueTuple.Item1);
	}

	public int CompareTo(ValueTuple<T1> other)
	{
		return Comparer<T1>.Default.Compare(Item1, other.Item1);
	}

	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is ValueTuple<T1> valueTuple))
		{
			throw new ArgumentException(SR.ArgumentException_ValueTupleIncorrectType, "other");
		}
		return comparer.Compare(Item1, valueTuple.Item1);
	}

	public override int GetHashCode()
	{
		return EqualityComparer<T1>.Default.GetHashCode(Item1);
	}

	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return comparer.GetHashCode(Item1);
	}

	int ITupleInternal.GetHashCode(IEqualityComparer comparer)
	{
		return comparer.GetHashCode(Item1);
	}

	public override string ToString()
	{
		return "(" + Item1?.ToString() + ")";
	}

	string ITupleInternal.ToStringEnd()
	{
		return Item1?.ToString() + ")";
	}
}
[StructLayout(LayoutKind.Auto)]
public struct ValueTuple<T1, T2> : ITupleInternal, IStructuralEquatable, IStructuralComparable, IComparable, IEquatable<(T1, T2)>, IComparable<(T1, T2)>
{
	public T1 Item1;

	public T2 Item2;

	int ITupleInternal.Size => 2;

	public ValueTuple(T1 item1, T2 item2)
	{
		Item1 = item1;
		Item2 = item2;
	}

	public override bool Equals(object obj)
	{
		if (obj is(T1, T2))
		{
			return Equals(((T1, T2))obj);
		}
		return false;
	}

	public bool Equals((T1, T2) other)
	{
		if (EqualityComparer<T1>.Default.Equals(Item1, other.Item1))
		{
			return EqualityComparer<T2>.Default.Equals(Item2, other.Item2);
		}
		return false;
	}

	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		if (other != null && other is (T1, T2) tuple)
		{
			if (comparer.Equals(Item1, tuple.Item1))
			{
				return comparer.Equals(Item2, tuple.Item2);
			}
			return false;
		}
		return false;
	}

	int IComparable.CompareTo(object other)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is(T1, T2)))
		{
			throw new ArgumentException(SR.ArgumentException_ValueTupleIncorrectType, "other");
		}
		return CompareTo(((T1, T2))other);
	}

	public int CompareTo((T1, T2) other)
	{
		int num = Comparer<T1>.Default.Compare(Item1, other.Item1);
		if (num != 0)
		{
			return num;
		}
		return Comparer<T2>.Default.Compare(Item2, other.Item2);
	}

	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is (T1, T2) tuple))
		{
			throw new ArgumentException(SR.ArgumentException_ValueTupleIncorrectType, "other");
		}
		int num = comparer.Compare(Item1, tuple.Item1);
		if (num != 0)
		{
			return num;
		}
		return comparer.Compare(Item2, tuple.Item2);
	}

	public override int GetHashCode()
	{
		return ValueTuple.CombineHashCodes(EqualityComparer<T1>.Default.GetHashCode(Item1), EqualityComparer<T2>.Default.GetHashCode(Item2));
	}

	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return GetHashCodeCore(comparer);
	}

	private int GetHashCodeCore(IEqualityComparer comparer)
	{
		return ValueTuple.CombineHashCodes(comparer.GetHashCode(Item1), comparer.GetHashCode(Item2));
	}

	int ITupleInternal.GetHashCode(IEqualityComparer comparer)
	{
		return GetHashCodeCore(comparer);
	}

	public override string ToString()
	{
		return "(" + Item1?.ToString() + ", " + Item2?.ToString() + ")";
	}

	string ITupleInternal.ToStringEnd()
	{
		return Item1?.ToString() + ", " + Item2?.ToString() + ")";
	}
}
[StructLayout(LayoutKind.Auto)]
public struct ValueTuple<T1, T2, T3> : ITupleInternal, IStructuralEquatable, IStructuralComparable, IComparable, IEquatable<(T1, T2, T3)>, IComparable<(T1, T2, T3)>
{
	public T1 Item1;

	public T2 Item2;

	public T3 Item3;

	int ITupleInternal.Size => 3;

	public ValueTuple(T1 item1, T2 item2, T3 item3)
	{
		Item1 = item1;
		Item2 = item2;
		Item3 = item3;
	}

	public override bool Equals(object obj)
	{
		if (obj is(T1, T2, T3))
		{
			return Equals(((T1, T2, T3))obj);
		}
		return false;
	}

	public bool Equals((T1, T2, T3) other)
	{
		if (EqualityComparer<T1>.Default.Equals(Item1, other.Item1) && EqualityComparer<T2>.Default.Equals(Item2, other.Item2))
		{
			return EqualityComparer<T3>.Default.Equals(Item3, other.Item3);
		}
		return false;
	}

	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		if (other != null && other is (T1, T2, T3) tuple)
		{
			if (comparer.Equals(Item1, tuple.Item1) && comparer.Equals(Item2, tuple.Item2))
			{
				return comparer.Equals(Item3, tuple.Item3);
			}
			return false;
		}
		return false;
	}

	int IComparable.CompareTo(object other)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is(T1, T2, T3)))
		{
			throw new ArgumentException(SR.ArgumentException_ValueTupleIncorrectType, "other");
		}
		return CompareTo(((T1, T2, T3))other);
	}

	public int CompareTo((T1, T2, T3) other)
	{
		int num = Comparer<T1>.Default.Compare(Item1, other.Item1);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T2>.Default.Compare(Item2, other.Item2);
		if (num != 0)
		{
			return num;
		}
		return Comparer<T3>.Default.Compare(Item3, other.Item3);
	}

	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is (T1, T2, T3) tuple))
		{
			throw new ArgumentException(SR.ArgumentException_ValueTupleIncorrectType, "other");
		}
		int num = comparer.Compare(Item1, tuple.Item1);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item2, tuple.Item2);
		if (num != 0)
		{
			return num;
		}
		return comparer.Compare(Item3, tuple.Item3);
	}

	public override int GetHashCode()
	{
		return ValueTuple.CombineHashCodes(EqualityComparer<T1>.Default.GetHashCode(Item1), EqualityComparer<T2>.Default.GetHashCode(Item2), EqualityComparer<T3>.Default.GetHashCode(Item3));
	}

	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return GetHashCodeCore(comparer);
	}

	private int GetHashCodeCore(IEqualityComparer comparer)
	{
		return ValueTuple.CombineHashCodes(comparer.GetHashCode(Item1), comparer.GetHashCode(Item2), comparer.GetHashCode(Item3));
	}

	int ITupleInternal.GetHashCode(IEqualityComparer comparer)
	{
		return GetHashCodeCore(comparer);
	}

	public override string ToString()
	{
		return "(" + Item1?.ToString() + ", " + Item2?.ToString() + ", " + Item3?.ToString() + ")";
	}

	string ITupleInternal.ToStringEnd()
	{
		return Item1?.ToString() + ", " + Item2?.ToString() + ", " + Item3?.ToString() + ")";
	}
}
[StructLayout(LayoutKind.Auto)]
public struct ValueTuple<T1, T2, T3, T4> : ITupleInternal, IStructuralEquatable, IStructuralComparable, IComparable, IEquatable<(T1, T2, T3, T4)>, IComparable<(T1, T2, T3, T4)>
{
	public T1 Item1;

	public T2 Item2;

	public T3 Item3;

	public T4 Item4;

	int ITupleInternal.Size => 4;

	public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4)
	{
		Item1 = item1;
		Item2 = item2;
		Item3 = item3;
		Item4 = item4;
	}

	public override bool Equals(object obj)
	{
		if (obj is(T1, T2, T3, T4))
		{
			return Equals(((T1, T2, T3, T4))obj);
		}
		return false;
	}

	public bool Equals((T1, T2, T3, T4) other)
	{
		if (EqualityComparer<T1>.Default.Equals(Item1, other.Item1) && EqualityComparer<T2>.Default.Equals(Item2, other.Item2) && EqualityComparer<T3>.Default.Equals(Item3, other.Item3))
		{
			return EqualityComparer<T4>.Default.Equals(Item4, other.Item4);
		}
		return false;
	}

	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		if (other != null && other is (T1, T2, T3, T4) tuple)
		{
			if (comparer.Equals(Item1, tuple.Item1) && comparer.Equals(Item2, tuple.Item2) && comparer.Equals(Item3, tuple.Item3))
			{
				return comparer.Equals(Item4, tuple.Item4);
			}
			return false;
		}
		return false;
	}

	int IComparable.CompareTo(object other)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is(T1, T2, T3, T4)))
		{
			throw new ArgumentException(SR.ArgumentException_ValueTupleIncorrectType, "other");
		}
		return CompareTo(((T1, T2, T3, T4))other);
	}

	public int CompareTo((T1, T2, T3, T4) other)
	{
		int num = Comparer<T1>.Default.Compare(Item1, other.Item1);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T2>.Default.Compare(Item2, other.Item2);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T3>.Default.Compare(Item3, other.Item3);
		if (num != 0)
		{
			return num;
		}
		return Comparer<T4>.Default.Compare(Item4, other.Item4);
	}

	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is (T1, T2, T3, T4) tuple))
		{
			throw new ArgumentException(SR.ArgumentException_ValueTupleIncorrectType, "other");
		}
		int num = comparer.Compare(Item1, tuple.Item1);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item2, tuple.Item2);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item3, tuple.Item3);
		if (num != 0)
		{
			return num;
		}
		return comparer.Compare(Item4, tuple.Item4);
	}

	public override int GetHashCode()
	{
		return ValueTuple.CombineHashCodes(EqualityComparer<T1>.Default.GetHashCode(Item1), EqualityComparer<T2>.Default.GetHashCode(Item2), EqualityComparer<T3>.Default.GetHashCode(Item3), EqualityComparer<T4>.Default.GetHashCode(Item4));
	}

	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return GetHashCodeCore(comparer);
	}

	private int GetHashCodeCore(IEqualityComparer comparer)
	{
		return ValueTuple.CombineHashCodes(comparer.GetHashCode(Item1), comparer.GetHashCode(Item2), comparer.GetHashCode(Item3), comparer.GetHashCode(Item4));
	}

	int ITupleInternal.GetHashCode(IEqualityComparer comparer)
	{
		return GetHashCodeCore(comparer);
	}

	public override string ToString()
	{
		return "(" + Item1?.ToString() + ", " + Item2?.ToString() + ", " + Item3?.ToString() + ", " + Item4?.ToString() + ")";
	}

	string ITupleInternal.ToStringEnd()
	{
		return Item1?.ToString() + ", " + Item2?.ToString() + ", " + Item3?.ToString() + ", " + Item4?.ToString() + ")";
	}
}
[StructLayout(LayoutKind.Auto)]
public struct ValueTuple<T1, T2, T3, T4, T5> : ITupleInternal, IStructuralEquatable, IStructuralComparable, IComparable, IEquatable<(T1, T2, T3, T4, T5)>, IComparable<(T1, T2, T3, T4, T5)>
{
	public T1 Item1;

	public T2 Item2;

	public T3 Item3;

	public T4 Item4;

	public T5 Item5;

	int ITupleInternal.Size => 5;

	public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
	{
		Item1 = item1;
		Item2 = item2;
		Item3 = item3;
		Item4 = item4;
		Item5 = item5;
	}

	public override bool Equals(object obj)
	{
		if (obj is(T1, T2, T3, T4, T5))
		{
			return Equals(((T1, T2, T3, T4, T5))obj);
		}
		return false;
	}

	public bool Equals((T1, T2, T3, T4, T5) other)
	{
		if (EqualityComparer<T1>.Default.Equals(Item1, other.Item1) && EqualityComparer<T2>.Default.Equals(Item2, other.Item2) && EqualityComparer<T3>.Default.Equals(Item3, other.Item3) && EqualityComparer<T4>.Default.Equals(Item4, other.Item4))
		{
			return EqualityComparer<T5>.Default.Equals(Item5, other.Item5);
		}
		return false;
	}

	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		if (other != null && other is (T1, T2, T3, T4, T5) tuple)
		{
			if (comparer.Equals(Item1, tuple.Item1) && comparer.Equals(Item2, tuple.Item2) && comparer.Equals(Item3, tuple.Item3) && comparer.Equals(Item4, tuple.Item4))
			{
				return comparer.Equals(Item5, tuple.Item5);
			}
			return false;
		}
		return false;
	}

	int IComparable.CompareTo(object other)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is(T1, T2, T3, T4, T5)))
		{
			throw new ArgumentException(SR.ArgumentException_ValueTupleIncorrectType, "other");
		}
		return CompareTo(((T1, T2, T3, T4, T5))other);
	}

	public int CompareTo((T1, T2, T3, T4, T5) other)
	{
		int num = Comparer<T1>.Default.Compare(Item1, other.Item1);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T2>.Default.Compare(Item2, other.Item2);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T3>.Default.Compare(Item3, other.Item3);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T4>.Default.Compare(Item4, other.Item4);
		if (num != 0)
		{
			return num;
		}
		return Comparer<T5>.Default.Compare(Item5, other.Item5);
	}

	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is (T1, T2, T3, T4, T5) tuple))
		{
			throw new ArgumentException(SR.ArgumentException_ValueTupleIncorrectType, "other");
		}
		int num = comparer.Compare(Item1, tuple.Item1);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item2, tuple.Item2);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item3, tuple.Item3);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item4, tuple.Item4);
		if (num != 0)
		{
			return num;
		}
		return comparer.Compare(Item5, tuple.Item5);
	}

	public override int GetHashCode()
	{
		return ValueTuple.CombineHashCodes(EqualityComparer<T1>.Default.GetHashCode(Item1), EqualityComparer<T2>.Default.GetHashCode(Item2), EqualityComparer<T3>.Default.GetHashCode(Item3), EqualityComparer<T4>.Default.GetHashCode(Item4), EqualityComparer<T5>.Default.GetHashCode(Item5));
	}

	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return GetHashCodeCore(comparer);
	}

	private int GetHashCodeCore(IEqualityComparer comparer)
	{
		return ValueTuple.CombineHashCodes(comparer.GetHashCode(Item1), comparer.GetHashCode(Item2), comparer.GetHashCode(Item3), comparer.GetHashCode(Item4), comparer.GetHashCode(Item5));
	}

	int ITupleInternal.GetHashCode(IEqualityComparer comparer)
	{
		return GetHashCodeCore(comparer);
	}

	public override string ToString()
	{
		return "(" + Item1?.ToString() + ", " + Item2?.ToString() + ", " + Item3?.ToString() + ", " + Item4?.ToString() + ", " + Item5?.ToString() + ")";
	}

	string ITupleInternal.ToStringEnd()
	{
		return Item1?.ToString() + ", " + Item2?.ToString() + ", " + Item3?.ToString() + ", " + Item4?.ToString() + ", " + Item5?.ToString() + ")";
	}
}
[StructLayout(LayoutKind.Auto)]
public struct ValueTuple<T1, T2, T3, T4, T5, T6> : ITupleInternal, IStructuralEquatable, IStructuralComparable, IComparable, IEquatable<(T1, T2, T3, T4, T5, T6)>, IComparable<(T1, T2, T3, T4, T5, T6)>
{
	public T1 Item1;

	public T2 Item2;

	public T3 Item3;

	public T4 Item4;

	public T5 Item5;

	public T6 Item6;

	int ITupleInternal.Size => 6;

	public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
	{
		Item1 = item1;
		Item2 = item2;
		Item3 = item3;
		Item4 = item4;
		Item5 = item5;
		Item6 = item6;
	}

	public override bool Equals(object obj)
	{
		if (obj is(T1, T2, T3, T4, T5, T6))
		{
			return Equals(((T1, T2, T3, T4, T5, T6))obj);
		}
		return false;
	}

	public bool Equals((T1, T2, T3, T4, T5, T6) other)
	{
		if (EqualityComparer<T1>.Default.Equals(Item1, other.Item1) && EqualityComparer<T2>.Default.Equals(Item2, other.Item2) && EqualityComparer<T3>.Default.Equals(Item3, other.Item3) && EqualityComparer<T4>.Default.Equals(Item4, other.Item4) && EqualityComparer<T5>.Default.Equals(Item5, other.Item5))
		{
			return EqualityComparer<T6>.Default.Equals(Item6, other.Item6);
		}
		return false;
	}

	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		if (other != null && other is (T1, T2, T3, T4, T5, T6) tuple)
		{
			if (comparer.Equals(Item1, tuple.Item1) && comparer.Equals(Item2, tuple.Item2) && comparer.Equals(Item3, tuple.Item3) && comparer.Equals(Item4, tuple.Item4) && comparer.Equals(Item5, tuple.Item5))
			{
				return comparer.Equals(Item6, tuple.Item6);
			}
			return false;
		}
		return false;
	}

	int IComparable.CompareTo(object other)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is(T1, T2, T3, T4, T5, T6)))
		{
			throw new ArgumentException(SR.ArgumentException_ValueTupleIncorrectType, "other");
		}
		return CompareTo(((T1, T2, T3, T4, T5, T6))other);
	}

	public int CompareTo((T1, T2, T3, T4, T5, T6) other)
	{
		int num = Comparer<T1>.Default.Compare(Item1, other.Item1);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T2>.Default.Compare(Item2, other.Item2);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T3>.Default.Compare(Item3, other.Item3);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T4>.Default.Compare(Item4, other.Item4);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T5>.Default.Compare(Item5, other.Item5);
		if (num != 0)
		{
			return num;
		}
		return Comparer<T6>.Default.Compare(Item6, other.Item6);
	}

	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is (T1, T2, T3, T4, T5, T6) tuple))
		{
			throw new ArgumentException(SR.ArgumentException_ValueTupleIncorrectType, "other");
		}
		int num = comparer.Compare(Item1, tuple.Item1);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item2, tuple.Item2);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item3, tuple.Item3);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item4, tuple.Item4);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item5, tuple.Item5);
		if (num != 0)
		{
			return num;
		}
		return comparer.Compare(Item6, tuple.Item6);
	}

	public override int GetHashCode()
	{
		return ValueTuple.CombineHashCodes(EqualityComparer<T1>.Default.GetHashCode(Item1), EqualityComparer<T2>.Default.GetHashCode(Item2), EqualityComparer<T3>.Default.GetHashCode(Item3), EqualityComparer<T4>.Default.GetHashCode(Item4), EqualityComparer<T5>.Default.GetHashCode(Item5), EqualityComparer<T6>.Default.GetHashCode(Item6));
	}

	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return GetHashCodeCore(comparer);
	}

	private int GetHashCodeCore(IEqualityComparer comparer)
	{
		return ValueTuple.CombineHashCodes(comparer.GetHashCode(Item1), comparer.GetHashCode(Item2), comparer.GetHashCode(Item3), comparer.GetHashCode(Item4), comparer.GetHashCode(Item5), comparer.GetHashCode(Item6));
	}

	int ITupleInternal.GetHashCode(IEqualityComparer comparer)
	{
		return GetHashCodeCore(comparer);
	}

	public override string ToString()
	{
		return "(" + Item1?.ToString() + ", " + Item2?.ToString() + ", " + Item3?.ToString() + ", " + Item4?.ToString() + ", " + Item5?.ToString() + ", " + Item6?.ToString() + ")";
	}

	string ITupleInternal.ToStringEnd()
	{
		return Item1?.ToString() + ", " + Item2?.ToString() + ", " + Item3?.ToString() + ", " + Item4?.ToString() + ", " + Item5?.ToString() + ", " + Item6?.ToString() + ")";
	}
}
[StructLayout(LayoutKind.Auto)]
public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7> : ITupleInternal, IStructuralEquatable, IStructuralComparable, IComparable, IEquatable<(T1, T2, T3, T4, T5, T6, T7)>, IComparable<(T1, T2, T3, T4, T5, T6, T7)>
{
	public T1 Item1;

	public T2 Item2;

	public T3 Item3;

	public T4 Item4;

	public T5 Item5;

	public T6 Item6;

	public T7 Item7;

	int ITupleInternal.Size => 7;

	public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
	{
		Item1 = item1;
		Item2 = item2;
		Item3 = item3;
		Item4 = item4;
		Item5 = item5;
		Item6 = item6;
		Item7 = item7;
	}

	public override bool Equals(object obj)
	{
		if (obj is(T1, T2, T3, T4, T5, T6, T7))
		{
			return Equals(((T1, T2, T3, T4, T5, T6, T7))obj);
		}
		return false;
	}

	public bool Equals((T1, T2, T3, T4, T5, T6, T7) other)
	{
		if (EqualityComparer<T1>.Default.Equals(Item1, other.Item1) && EqualityComparer<T2>.Default.Equals(Item2, other.Item2) && EqualityComparer<T3>.Default.Equals(Item3, other.Item3) && EqualityComparer<T4>.Default.Equals(Item4, other.Item4) && EqualityComparer<T5>.Default.Equals(Item5, other.Item5) && EqualityComparer<T6>.Default.Equals(Item6, other.Item6))
		{
			return EqualityComparer<T7>.Default.Equals(Item7, other.Item7);
		}
		return false;
	}

	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		if (other != null && other is (T1, T2, T3, T4, T5, T6, T7) tuple)
		{
			if (comparer.Equals(Item1, tuple.Item1) && comparer.Equals(Item2, tuple.Item2) && comparer.Equals(Item3, tuple.Item3) && comparer.Equals(Item4, tuple.Item4) && comparer.Equals(Item5, tuple.Item5) && comparer.Equals(Item6, tuple.Item6))
			{
				return comparer.Equals(Item7, tuple.Item7);
			}
			return false;
		}
		return false;
	}

	int IComparable.CompareTo(object other)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is(T1, T2, T3, T4, T5, T6, T7)))
		{
			throw new ArgumentException(SR.ArgumentException_ValueTupleIncorrectType, "other");
		}
		return CompareTo(((T1, T2, T3, T4, T5, T6, T7))other);
	}

	public int CompareTo((T1, T2, T3, T4, T5, T6, T7) other)
	{
		int num = Comparer<T1>.Default.Compare(Item1, other.Item1);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T2>.Default.Compare(Item2, other.Item2);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T3>.Default.Compare(Item3, other.Item3);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T4>.Default.Compare(Item4, other.Item4);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T5>.Default.Compare(Item5, other.Item5);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T6>.Default.Compare(Item6, other.Item6);
		if (num != 0)
		{
			return num;
		}
		return Comparer<T7>.Default.Compare(Item7, other.Item7);
	}

	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is (T1, T2, T3, T4, T5, T6, T7) tuple))
		{
			throw new ArgumentException(SR.ArgumentException_ValueTupleIncorrectType, "other");
		}
		int num = comparer.Compare(Item1, tuple.Item1);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item2, tuple.Item2);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item3, tuple.Item3);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item4, tuple.Item4);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item5, tuple.Item5);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item6, tuple.Item6);
		if (num != 0)
		{
			return num;
		}
		return comparer.Compare(Item7, tuple.Item7);
	}

	public override int GetHashCode()
	{
		return ValueTuple.CombineHashCodes(EqualityComparer<T1>.Default.GetHashCode(Item1), EqualityComparer<T2>.Default.GetHashCode(Item2), EqualityComparer<T3>.Default.GetHashCode(Item3), EqualityComparer<T4>.Default.GetHashCode(Item4), EqualityComparer<T5>.Default.GetHashCode(Item5), EqualityComparer<T6>.Default.GetHashCode(Item6), EqualityComparer<T7>.Default.GetHashCode(Item7));
	}

	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return GetHashCodeCore(comparer);
	}

	private int GetHashCodeCore(IEqualityComparer comparer)
	{
		return ValueTuple.CombineHashCodes(comparer.GetHashCode(Item1), comparer.GetHashCode(Item2), comparer.GetHashCode(Item3), comparer.GetHashCode(Item4), comparer.GetHashCode(Item5), comparer.GetHashCode(Item6), comparer.GetHashCode(Item7));
	}

	int ITupleInternal.GetHashCode(IEqualityComparer comparer)
	{
		return GetHashCodeCore(comparer);
	}

	public override string ToString()
	{
		return "(" + Item1?.ToString() + ", " + Item2?.ToString() + ", " + Item3?.ToString() + ", " + Item4?.ToString() + ", " + Item5?.ToString() + ", " + Item6?.ToString() + ", " + Item7?.ToString() + ")";
	}

	string ITupleInternal.ToStringEnd()
	{
		return Item1?.ToString() + ", " + Item2?.ToString() + ", " + Item3?.ToString() + ", " + Item4?.ToString() + ", " + Item5?.ToString() + ", " + Item6?.ToString() + ", " + Item7?.ToString() + ")";
	}
}
[StructLayout(LayoutKind.Auto)]
public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> : ITupleInternal, IStructuralEquatable, IStructuralComparable, IComparable, IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>> where TRest : struct
{
	public T1 Item1;

	public T2 Item2;

	public T3 Item3;

	public T4 Item4;

	public T5 Item5;

	public T6 Item6;

	public T7 Item7;

	public TRest Rest;

	int ITupleInternal.Size
	{
		get
		{
			if ((object)Rest is ITupleInternal tupleInternal)
			{
				return 7 + tupleInternal.Size;
			}
			return 8;
		}
	}

	public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest)
	{
		if (!(rest is ITupleInternal))
		{
			throw new ArgumentException(SR.ArgumentException_ValueTupleLastArgumentNotAValueTuple);
		}
		Item1 = item1;
		Item2 = item2;
		Item3 = item3;
		Item4 = item4;
		Item5 = item5;
		Item6 = item6;
		Item7 = item7;
		Rest = rest;
	}

	public override bool Equals(object obj)
	{
		if (obj is ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>)
		{
			return Equals((ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>)obj);
		}
		return false;
	}

	public bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other)
	{
		if (EqualityComparer<T1>.Default.Equals(Item1, other.Item1) && EqualityComparer<T2>.Default.Equals(Item2, other.Item2) && EqualityComparer<T3>.Default.Equals(Item3, other.Item3) && EqualityComparer<T4>.Default.Equals(Item4, other.Item4) && EqualityComparer<T5>.Default.Equals(Item5, other.Item5) && EqualityComparer<T6>.Default.Equals(Item6, other.Item6) && EqualityComparer<T7>.Default.Equals(Item7, other.Item7))
		{
			return EqualityComparer<TRest>.Default.Equals(Rest, other.Rest);
		}
		return false;
	}

	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		if (other != null && other is ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> valueTuple)
		{
			if (comparer.Equals(Item1, valueTuple.Item1) && comparer.Equals(Item2, valueTuple.Item2) && comparer.Equals(Item3, valueTuple.Item3) && comparer.Equals(Item4, valueTuple.Item4) && comparer.Equals(Item5, valueTuple.Item5) && comparer.Equals(Item6, valueTuple.Item6) && comparer.Equals(Item7, valueTuple.Item7))
			{
				return comparer.Equals(Rest, valueTuple.Rest);
			}
			return false;
		}
		return false;
	}

	int IComparable.CompareTo(object other)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>))
		{
			throw new ArgumentException(SR.ArgumentException_ValueTupleIncorrectType, "other");
		}
		return CompareTo((ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>)other);
	}

	public int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other)
	{
		int num = Comparer<T1>.Default.Compare(Item1, other.Item1);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T2>.Default.Compare(Item2, other.Item2);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T3>.Default.Compare(Item3, other.Item3);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T4>.Default.Compare(Item4, other.Item4);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T5>.Default.Compare(Item5, other.Item5);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T6>.Default.Compare(Item6, other.Item6);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T7>.Default.Compare(Item7, other.Item7);
		if (num != 0)
		{
			return num;
		}
		return Comparer<TRest>.Default.Compare(Rest, other.Rest);
	}

	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> valueTuple))
		{
			throw new ArgumentException(SR.ArgumentException_ValueTupleIncorrectType, "other");
		}
		int num = comparer.Compare(Item1, valueTuple.Item1);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item2, valueTuple.Item2);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item3, valueTuple.Item3);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item4, valueTuple.Item4);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item5, valueTuple.Item5);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item6, valueTuple.Item6);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item7, valueTuple.Item7);
		if (num != 0)
		{
			return num;
		}
		return comparer.Compare(Rest, valueTuple.Rest);
	}

	public override int GetHashCode()
	{
		if (!((object)Rest is ITupleInternal tupleInternal))
		{
			return ValueTuple.CombineHashCodes(EqualityComparer<T1>.Default.GetHashCode(Item1), EqualityComparer<T2>.Default.GetHashCode(Item2), EqualityComparer<T3>.Default.GetHashCode(Item3), EqualityComparer<T4>.Default.GetHashCode(Item4), EqualityComparer<T5>.Default.GetHashCode(Item5), EqualityComparer<T6>.Default.GetHashCode(Item6), EqualityComparer<T7>.Default.GetHashCode(Item7));
		}
		int size = tupleInternal.Size;
		if (size >= 8)
		{
			return tupleInternal.GetHashCode();
		}
		switch (8 - size)
		{
		default:
			return -1;
		case 1:
			return ValueTuple.CombineHashCodes(EqualityComparer<T7>.Default.GetHashCode(Item7), tupleInternal.GetHashCode());
		case 2:
			return ValueTuple.CombineHashCodes(EqualityComparer<T6>.Default.GetHashCode(Item6), EqualityComparer<T7>.Default.GetHashCode(Item7), tupleInternal.GetHashCode());
		case 3:
			return ValueTuple.CombineHashCodes(EqualityComparer<T5>.Default.GetHashCode(Item5), EqualityComparer<T6>.Default.GetHashCode(Item6), EqualityComparer<T7>.Default.GetHashCode(Item7), tupleInternal.GetHashCode());
		case 4:
			return ValueTuple.CombineHashCodes(EqualityComparer<T4>.Default.GetHashCode(Item4), EqualityComparer<T5>.Default.GetHashCode(Item5), EqualityComparer<T6>.Default.GetHashCode(Item6), EqualityComparer<T7>.Default.GetHashCode(Item7), tupleInternal.GetHashCode());
		case 5:
			return ValueTuple.CombineHashCodes(EqualityComparer<T3>.Default.GetHashCode(Item3), EqualityComparer<T4>.Default.GetHashCode(Item4), EqualityComparer<T5>.Default.GetHashCode(Item5), EqualityComparer<T6>.Default.GetHashCode(Item6), EqualityComparer<T7>.Default.GetHashCode(Item7), tupleInternal.GetHashCode());
		case 6:
			return ValueTuple.CombineHashCodes(EqualityComparer<T2>.Default.GetHashCode(Item2), EqualityComparer<T3>.Default.GetHashCode(Item3), EqualityComparer<T4>.Default.GetHashCode(Item4), EqualityComparer<T5>.Default.GetHashCode(Item5), EqualityComparer<T6>.Default.GetHashCode(Item6), EqualityComparer<T7>.Default.GetHashCode(Item7), tupleInternal.GetHashCode());
		case 7:
		case 8:
			return ValueTuple.CombineHashCodes(EqualityComparer<T1>.Default.GetHashCode(Item1), EqualityComparer<T2>.Default.GetHashCode(Item2), EqualityComparer<T3>.Default.GetHashCode(Item3), EqualityComparer<T4>.Default.GetHashCode(Item4), EqualityComparer<T5>.Default.GetHashCode(Item5), EqualityComparer<T6>.Default.GetHashCode(Item6), EqualityComparer<T7>.Default.GetHashCode(Item7), tupleInternal.GetHashCode());
		}
	}

	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return GetHashCodeCore(comparer);
	}

	private int GetHashCodeCore(IEqualityComparer comparer)
	{
		if (!((object)Rest is ITupleInternal tupleInternal))
		{
			return ValueTuple.CombineHashCodes(comparer.GetHashCode(Item1), comparer.GetHashCode(Item2), comparer.GetHashCode(Item3), comparer.GetHashCode(Item4), comparer.GetHashCode(Item5), comparer.GetHashCode(Item6), comparer.GetHashCode(Item7));
		}
		int size = tupleInternal.Size;
		if (size >= 8)
		{
			return tupleInternal.GetHashCode(comparer);
		}
		switch (8 - size)
		{
		default:
			return -1;
		case 1:
			return ValueTuple.CombineHashCodes(comparer.GetHashCode(Item7), tupleInternal.GetHashCode(comparer));
		case 2:
			return ValueTuple.CombineHashCodes(comparer.GetHashCode(Item6), comparer.GetHashCode(Item7), tupleInternal.GetHashCode(comparer));
		case 3:
			return ValueTuple.CombineHashCodes(comparer.GetHashCode(Item5), comparer.GetHashCode(Item6), comparer.GetHashCode(Item7), tupleInternal.GetHashCode(comparer));
		case 4:
			return ValueTuple.CombineHashCodes(comparer.GetHashCode(Item4), comparer.GetHashCode(Item5), comparer.GetHashCode(Item6), comparer.GetHashCode(Item7), tupleInternal.GetHashCode(comparer));
		case 5:
			return ValueTuple.CombineHashCodes(comparer.GetHashCode(Item3), comparer.GetHashCode(Item4), comparer.GetHashCode(Item5), comparer.GetHashCode(Item6), comparer.GetHashCode(Item7), tupleInternal.GetHashCode(comparer));
		case 6:
			return ValueTuple.CombineHashCodes(comparer.GetHashCode(Item2), comparer.GetHashCode(Item3), comparer.GetHashCode(Item4), comparer.GetHashCode(Item5), comparer.GetHashCode(Item6), comparer.GetHashCode(Item7), tupleInternal.GetHashCode(comparer));
		case 7:
		case 8:
			return ValueTuple.CombineHashCodes(comparer.GetHashCode(Item1), comparer.GetHashCode(Item2), comparer.GetHashCode(Item3), comparer.GetHashCode(Item4), comparer.GetHashCode(Item5), comparer.GetHashCode(Item6), comparer.GetHashCode(Item7), tupleInternal.GetHashCode(comparer));
		}
	}

	int ITupleInternal.GetHashCode(IEqualityComparer comparer)
	{
		return GetHashCodeCore(comparer);
	}

	public override string ToString()
	{
		string[] obj;
		T1 val;
		object obj2;
		if (!((object)Rest is ITupleInternal tupleInternal))
		{
			obj = new string[17]
			{
				"(", null, null, null, null, null, null, null, null, null,
				null, null, null, null, null, null, null
			};
			ref T1 reference = ref Item1;
			val = default(T1);
			if (val == null)
			{
				val = reference;
				reference = ref val;
				if (val == null)
				{
					obj2 = null;
					goto IL_005d;
				}
			}
			obj2 = reference.ToString();
			goto IL_005d;
		}
		string[] obj3 = new string[16]
		{
			"(", null, null, null, null, null, null, null, null, null,
			null, null, null, null, null, null
		};
		ref T1 reference2 = ref Item1;
		val = default(T1);
		object obj4;
		if (val == null)
		{
			val = reference2;
			reference2 = ref val;
			if (val == null)
			{
				obj4 = null;
				goto IL_0262;
			}
		}
		obj4 = reference2.ToString();
		goto IL_0262;
		IL_02e2:
		object obj5;
		obj3[5] = (string)obj5;
		obj3[6] = ", ";
		ref T4 reference3 = ref Item4;
		T4 val2 = default(T4);
		object obj6;
		if (val2 == null)
		{
			val2 = reference3;
			reference3 = ref val2;
			if (val2 == null)
			{
				obj6 = null;
				goto IL_0325;
			}
		}
		obj6 = reference3.ToString();
		goto IL_0325;
		IL_03f3:
		object obj7;
		obj3[13] = (string)obj7;
		obj3[14] = ", ";
		obj3[15] = tupleInternal.ToStringEnd();
		return string.Concat(obj3);
		IL_03ae:
		object obj8;
		obj3[11] = (string)obj8;
		obj3[12] = ", ";
		ref T7 reference4 = ref Item7;
		T7 val3 = default(T7);
		if (val3 == null)
		{
			val3 = reference4;
			reference4 = ref val3;
			if (val3 == null)
			{
				obj7 = null;
				goto IL_03f3;
			}
		}
		obj7 = reference4.ToString();
		goto IL_03f3;
		IL_0120:
		object obj9;
		obj[7] = (string)obj9;
		obj[8] = ", ";
		ref T5 reference5 = ref Item5;
		T5 val4 = default(T5);
		object obj10;
		if (val4 == null)
		{
			val4 = reference5;
			reference5 = ref val4;
			if (val4 == null)
			{
				obj10 = null;
				goto IL_0164;
			}
		}
		obj10 = reference5.ToString();
		goto IL_0164;
		IL_005d:
		obj[1] = (string)obj2;
		obj[2] = ", ";
		ref T2 reference6 = ref Item2;
		T2 val5 = default(T2);
		object obj11;
		if (val5 == null)
		{
			val5 = reference6;
			reference6 = ref val5;
			if (val5 == null)
			{
				obj11 = null;
				goto IL_009d;
			}
		}
		obj11 = reference6.ToString();
		goto IL_009d;
		IL_0164:
		obj[9] = (string)obj10;
		obj[10] = ", ";
		ref T6 reference7 = ref Item6;
		T6 val6 = default(T6);
		object obj12;
		if (val6 == null)
		{
			val6 = reference7;
			reference7 = ref val6;
			if (val6 == null)
			{
				obj12 = null;
				goto IL_01a9;
			}
		}
		obj12 = reference7.ToString();
		goto IL_01a9;
		IL_02a2:
		object obj13;
		obj3[3] = (string)obj13;
		obj3[4] = ", ";
		ref T3 reference8 = ref Item3;
		T3 val7 = default(T3);
		if (val7 == null)
		{
			val7 = reference8;
			reference8 = ref val7;
			if (val7 == null)
			{
				obj5 = null;
				goto IL_02e2;
			}
		}
		obj5 = reference8.ToString();
		goto IL_02e2;
		IL_01ee:
		object obj14;
		obj[13] = (string)obj14;
		obj[14] = ", ";
		obj[15] = Rest.ToString();
		obj[16] = ")";
		return string.Concat(obj);
		IL_009d:
		obj[3] = (string)obj11;
		obj[4] = ", ";
		ref T3 reference9 = ref Item3;
		val7 = default(T3);
		object obj15;
		if (val7 == null)
		{
			val7 = reference9;
			reference9 = ref val7;
			if (val7 == null)
			{
				obj15 = null;
				goto IL_00dd;
			}
		}
		obj15 = reference9.ToString();
		goto IL_00dd;
		IL_0325:
		obj3[7] = (string)obj6;
		obj3[8] = ", ";
		ref T5 reference10 = ref Item5;
		val4 = default(T5);
		object obj16;
		if (val4 == null)
		{
			val4 = reference10;
			reference10 = ref val4;
			if (val4 == null)
			{
				obj16 = null;
				goto IL_0369;
			}
		}
		obj16 = reference10.ToString();
		goto IL_0369;
		IL_01a9:
		obj[11] = (string)obj12;
		obj[12] = ", ";
		ref T7 reference11 = ref Item7;
		val3 = default(T7);
		if (val3 == null)
		{
			val3 = reference11;
			reference11 = ref val3;
			if (val3 == null)
			{
				obj14 = null;
				goto IL_01ee;
			}
		}
		obj14 = reference11.ToString();
		goto IL_01ee;
		IL_0262:
		obj3[1] = (string)obj4;
		obj3[2] = ", ";
		ref T2 reference12 = ref Item2;
		val5 = default(T2);
		if (val5 == null)
		{
			val5 = reference12;
			reference12 = ref val5;
			if (val5 == null)
			{
				obj13 = null;
				goto IL_02a2;
			}
		}
		obj13 = reference12.ToString();
		goto IL_02a2;
		IL_00dd:
		obj[5] = (string)obj15;
		obj[6] = ", ";
		ref T4 reference13 = ref Item4;
		val2 = default(T4);
		if (val2 == null)
		{
			val2 = reference13;
			reference13 = ref val2;
			if (val2 == null)
			{
				obj9 = null;
				goto IL_0120;
			}
		}
		obj9 = reference13.ToString();
		goto IL_0120;
		IL_0369:
		obj3[9] = (string)obj16;
		obj3[10] = ", ";
		ref T6 reference14 = ref Item6;
		val6 = default(T6);
		if (val6 == null)
		{
			val6 = reference14;
			reference14 = ref val6;
			if (val6 == null)
			{
				obj8 = null;
				goto IL_03ae;
			}
		}
		obj8 = reference14.ToString();
		goto IL_03ae;
	}

	string ITupleInternal.ToStringEnd()
	{
		string[] array;
		T1 val;
		object obj;
		if (!((object)Rest is ITupleInternal tupleInternal))
		{
			array = new string[16];
			ref T1 reference = ref Item1;
			val = default(T1);
			if (val == null)
			{
				val = reference;
				reference = ref val;
				if (val == null)
				{
					obj = null;
					goto IL_0055;
				}
			}
			obj = reference.ToString();
			goto IL_0055;
		}
		string[] array2 = new string[15];
		ref T1 reference2 = ref Item1;
		val = default(T1);
		object obj2;
		if (val == null)
		{
			val = reference2;
			reference2 = ref val;
			if (val == null)
			{
				obj2 = null;
				goto IL_0251;
			}
		}
		obj2 = reference2.ToString();
		goto IL_0251;
		IL_02d1:
		object obj3;
		array2[4] = (string)obj3;
		array2[5] = ", ";
		ref T4 reference3 = ref Item4;
		T4 val2 = default(T4);
		object obj4;
		if (val2 == null)
		{
			val2 = reference3;
			reference3 = ref val2;
			if (val2 == null)
			{
				obj4 = null;
				goto IL_0314;
			}
		}
		obj4 = reference3.ToString();
		goto IL_0314;
		IL_03e1:
		object obj5;
		array2[12] = (string)obj5;
		array2[13] = ", ";
		array2[14] = tupleInternal.ToStringEnd();
		return string.Concat(array2);
		IL_039c:
		object obj6;
		array2[10] = (string)obj6;
		array2[11] = ", ";
		ref T7 reference4 = ref Item7;
		T7 val3 = default(T7);
		if (val3 == null)
		{
			val3 = reference4;
			reference4 = ref val3;
			if (val3 == null)
			{
				obj5 = null;
				goto IL_03e1;
			}
		}
		obj5 = reference4.ToString();
		goto IL_03e1;
		IL_0118:
		object obj7;
		array[6] = (string)obj7;
		array[7] = ", ";
		ref T5 reference5 = ref Item5;
		T5 val4 = default(T5);
		object obj8;
		if (val4 == null)
		{
			val4 = reference5;
			reference5 = ref val4;
			if (val4 == null)
			{
				obj8 = null;
				goto IL_015b;
			}
		}
		obj8 = reference5.ToString();
		goto IL_015b;
		IL_0055:
		array[0] = (string)obj;
		array[1] = ", ";
		ref T2 reference6 = ref Item2;
		T2 val5 = default(T2);
		object obj9;
		if (val5 == null)
		{
			val5 = reference6;
			reference6 = ref val5;
			if (val5 == null)
			{
				obj9 = null;
				goto IL_0095;
			}
		}
		obj9 = reference6.ToString();
		goto IL_0095;
		IL_015b:
		array[8] = (string)obj8;
		array[9] = ", ";
		ref T6 reference7 = ref Item6;
		T6 val6 = default(T6);
		object obj10;
		if (val6 == null)
		{
			val6 = reference7;
			reference7 = ref val6;
			if (val6 == null)
			{
				obj10 = null;
				goto IL_01a0;
			}
		}
		obj10 = reference7.ToString();
		goto IL_01a0;
		IL_0291:
		object obj11;
		array2[2] = (string)obj11;
		array2[3] = ", ";
		ref T3 reference8 = ref Item3;
		T3 val7 = default(T3);
		if (val7 == null)
		{
			val7 = reference8;
			reference8 = ref val7;
			if (val7 == null)
			{
				obj3 = null;
				goto IL_02d1;
			}
		}
		obj3 = reference8.ToString();
		goto IL_02d1;
		IL_01e5:
		object obj12;
		array[12] = (string)obj12;
		array[13] = ", ";
		array[14] = Rest.ToString();
		array[15] = ")";
		return string.Concat(array);
		IL_0095:
		array[2] = (string)obj9;
		array[3] = ", ";
		ref T3 reference9 = ref Item3;
		val7 = default(T3);
		object obj13;
		if (val7 == null)
		{
			val7 = reference9;
			reference9 = ref val7;
			if (val7 == null)
			{
				obj13 = null;
				goto IL_00d5;
			}
		}
		obj13 = reference9.ToString();
		goto IL_00d5;
		IL_0314:
		array2[6] = (string)obj4;
		array2[7] = ", ";
		ref T5 reference10 = ref Item5;
		val4 = default(T5);
		object obj14;
		if (val4 == null)
		{
			val4 = reference10;
			reference10 = ref val4;
			if (val4 == null)
			{
				obj14 = null;
				goto IL_0357;
			}
		}
		obj14 = reference10.ToString();
		goto IL_0357;
		IL_01a0:
		array[10] = (string)obj10;
		array[11] = ", ";
		ref T7 reference11 = ref Item7;
		val3 = default(T7);
		if (val3 == null)
		{
			val3 = reference11;
			reference11 = ref val3;
			if (val3 == null)
			{
				obj12 = null;
				goto IL_01e5;
			}
		}
		obj12 = reference11.ToString();
		goto IL_01e5;
		IL_0251:
		array2[0] = (string)obj2;
		array2[1] = ", ";
		ref T2 reference12 = ref Item2;
		val5 = default(T2);
		if (val5 == null)
		{
			val5 = reference12;
			reference12 = ref val5;
			if (val5 == null)
			{
				obj11 = null;
				goto IL_0291;
			}
		}
		obj11 = reference12.ToString();
		goto IL_0291;
		IL_00d5:
		array[4] = (string)obj13;
		array[5] = ", ";
		ref T4 reference13 = ref Item4;
		val2 = default(T4);
		if (val2 == null)
		{
			val2 = reference13;
			reference13 = ref val2;
			if (val2 == null)
			{
				obj7 = null;
				goto IL_0118;
			}
		}
		obj7 = reference13.ToString();
		goto IL_0118;
		IL_0357:
		array2[8] = (string)obj14;
		array2[9] = ", ";
		ref T6 reference14 = ref Item6;
		val6 = default(T6);
		if (val6 == null)
		{
			val6 = reference14;
			reference14 = ref val6;
			if (val6 == null)
			{
				obj6 = null;
				goto IL_039c;
			}
		}
		obj6 = reference14.ToString();
		goto IL_039c;
	}
}
