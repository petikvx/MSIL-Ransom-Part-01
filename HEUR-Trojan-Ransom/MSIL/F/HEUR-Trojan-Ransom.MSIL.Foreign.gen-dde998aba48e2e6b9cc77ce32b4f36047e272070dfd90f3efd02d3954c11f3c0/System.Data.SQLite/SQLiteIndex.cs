using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public sealed class SQLiteIndex
{
	private SQLiteIndexInputs inputs;

	private SQLiteIndexOutputs outputs;

	[NonSerialized]
	internal static GetString _0099;

	public SQLiteIndexInputs Inputs => inputs;

	public SQLiteIndexOutputs Outputs => outputs;

	internal SQLiteIndex(int nConstraint, int nOrderBy)
	{
		inputs = new SQLiteIndexInputs(nConstraint, nOrderBy);
		outputs = new SQLiteIndexOutputs(nConstraint);
	}

	private static void SizeOfNative(out int sizeOfInfoType, out int sizeOfConstraintType, out int sizeOfOrderByType, out int sizeOfConstraintUsageType)
	{
		sizeOfInfoType = Marshal.SizeOf(typeof(UnsafeNativeMethods.sqlite3_index_info));
		sizeOfConstraintType = Marshal.SizeOf(typeof(UnsafeNativeMethods.sqlite3_index_constraint));
		sizeOfOrderByType = Marshal.SizeOf(typeof(UnsafeNativeMethods.sqlite3_index_orderby));
		sizeOfConstraintUsageType = Marshal.SizeOf(typeof(UnsafeNativeMethods.sqlite3_index_constraint_usage));
	}

	private static IntPtr AllocateAndInitializeNative(int nConstraint, int nOrderBy)
	{
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		IntPtr intPtr3 = IntPtr.Zero;
		IntPtr intPtr4 = IntPtr.Zero;
		IntPtr intPtr5 = IntPtr.Zero;
		try
		{
			SizeOfNative(out var sizeOfInfoType, out var sizeOfConstraintType, out var sizeOfOrderByType, out var sizeOfConstraintUsageType);
			if (sizeOfInfoType > 0 && sizeOfConstraintType > 0 && sizeOfOrderByType > 0 && sizeOfConstraintUsageType > 0)
			{
				intPtr2 = SQLiteMemory.Allocate(sizeOfInfoType);
				intPtr3 = SQLiteMemory.Allocate(sizeOfConstraintType * nConstraint);
				intPtr4 = SQLiteMemory.Allocate(sizeOfOrderByType * nOrderBy);
				intPtr5 = SQLiteMemory.Allocate(sizeOfConstraintUsageType * nConstraint);
				if (intPtr2 != IntPtr.Zero && intPtr3 != IntPtr.Zero && intPtr4 != IntPtr.Zero && intPtr5 != IntPtr.Zero)
				{
					int offset = 0;
					SQLiteMarshal.WriteInt32(intPtr2, offset, nConstraint);
					offset = SQLiteMarshal.NextOffsetOf(offset, 4, IntPtr.Size);
					SQLiteMarshal.WriteIntPtr(intPtr2, offset, intPtr3);
					offset = SQLiteMarshal.NextOffsetOf(offset, IntPtr.Size, 4);
					SQLiteMarshal.WriteInt32(intPtr2, offset, nOrderBy);
					offset = SQLiteMarshal.NextOffsetOf(offset, 4, IntPtr.Size);
					SQLiteMarshal.WriteIntPtr(intPtr2, offset, intPtr4);
					offset = SQLiteMarshal.NextOffsetOf(offset, IntPtr.Size, IntPtr.Size);
					SQLiteMarshal.WriteIntPtr(intPtr2, offset, intPtr5);
					intPtr = intPtr2;
				}
			}
		}
		finally
		{
			if (intPtr == IntPtr.Zero)
			{
				if (intPtr5 != IntPtr.Zero)
				{
					SQLiteMemory.Free(intPtr5);
					intPtr5 = IntPtr.Zero;
				}
				if (intPtr4 != IntPtr.Zero)
				{
					SQLiteMemory.Free(intPtr4);
					intPtr4 = IntPtr.Zero;
				}
				if (intPtr3 != IntPtr.Zero)
				{
					SQLiteMemory.Free(intPtr3);
					intPtr3 = IntPtr.Zero;
				}
				if (intPtr2 != IntPtr.Zero)
				{
					SQLiteMemory.Free(intPtr2);
					intPtr2 = IntPtr.Zero;
				}
			}
		}
		return intPtr;
	}

	private static void FreeNative(IntPtr pIndex)
	{
		if (!(pIndex == IntPtr.Zero))
		{
			int offset = 0;
			offset = SQLiteMarshal.NextOffsetOf(offset, 4, IntPtr.Size);
			IntPtr intPtr = SQLiteMarshal.ReadIntPtr(pIndex, offset);
			int offset2 = offset;
			offset = SQLiteMarshal.NextOffsetOf(offset, IntPtr.Size, 4);
			offset = SQLiteMarshal.NextOffsetOf(offset, 4, IntPtr.Size);
			IntPtr intPtr2 = SQLiteMarshal.ReadIntPtr(pIndex, offset);
			int offset3 = offset;
			offset = SQLiteMarshal.NextOffsetOf(offset, IntPtr.Size, IntPtr.Size);
			IntPtr intPtr3 = SQLiteMarshal.ReadIntPtr(pIndex, offset);
			int offset4 = offset;
			if (intPtr3 != IntPtr.Zero)
			{
				SQLiteMemory.Free(intPtr3);
				intPtr3 = IntPtr.Zero;
				SQLiteMarshal.WriteIntPtr(pIndex, offset4, intPtr3);
			}
			if (intPtr2 != IntPtr.Zero)
			{
				SQLiteMemory.Free(intPtr2);
				intPtr2 = IntPtr.Zero;
				SQLiteMarshal.WriteIntPtr(pIndex, offset3, intPtr2);
			}
			if (intPtr != IntPtr.Zero)
			{
				SQLiteMemory.Free(intPtr);
				intPtr = IntPtr.Zero;
				SQLiteMarshal.WriteIntPtr(pIndex, offset2, intPtr);
			}
			if (pIndex != IntPtr.Zero)
			{
				SQLiteMemory.Free(pIndex);
				pIndex = IntPtr.Zero;
			}
		}
	}

	internal static void FromIntPtr(IntPtr pIndex, bool includeOutput, ref SQLiteIndex index)
	{
		if (pIndex == IntPtr.Zero)
		{
			return;
		}
		int offset = 0;
		int num = SQLiteMarshal.ReadInt32(pIndex, offset);
		offset = SQLiteMarshal.NextOffsetOf(offset, 4, IntPtr.Size);
		IntPtr pointer = SQLiteMarshal.ReadIntPtr(pIndex, offset);
		offset = SQLiteMarshal.NextOffsetOf(offset, IntPtr.Size, 4);
		int num2 = SQLiteMarshal.ReadInt32(pIndex, offset);
		offset = SQLiteMarshal.NextOffsetOf(offset, 4, IntPtr.Size);
		IntPtr pointer2 = SQLiteMarshal.ReadIntPtr(pIndex, offset);
		IntPtr pointer3 = IntPtr.Zero;
		if (includeOutput)
		{
			offset = SQLiteMarshal.NextOffsetOf(offset, IntPtr.Size, IntPtr.Size);
			pointer3 = SQLiteMarshal.ReadIntPtr(pIndex, offset);
		}
		index = new SQLiteIndex(num, num2);
		SQLiteIndexInputs sQLiteIndexInputs = index.Inputs;
		if (sQLiteIndexInputs == null)
		{
			return;
		}
		SQLiteIndexConstraint[] constraints = sQLiteIndexInputs.Constraints;
		if (constraints == null)
		{
			return;
		}
		SQLiteIndexOrderBy[] orderBys = sQLiteIndexInputs.OrderBys;
		if (orderBys == null)
		{
			return;
		}
		Type typeFromHandle = typeof(UnsafeNativeMethods.sqlite3_index_constraint);
		int num3 = Marshal.SizeOf(typeFromHandle);
		for (int i = 0; i < num; i++)
		{
			IntPtr ptr = SQLiteMarshal.IntPtrForOffset(pointer, i * num3);
			UnsafeNativeMethods.sqlite3_index_constraint constraint = (UnsafeNativeMethods.sqlite3_index_constraint)Marshal.PtrToStructure(ptr, typeFromHandle);
			constraints[i] = new SQLiteIndexConstraint(constraint);
		}
		Type typeFromHandle2 = typeof(UnsafeNativeMethods.sqlite3_index_orderby);
		int num4 = Marshal.SizeOf(typeFromHandle2);
		for (int j = 0; j < num2; j++)
		{
			IntPtr ptr2 = SQLiteMarshal.IntPtrForOffset(pointer2, j * num4);
			UnsafeNativeMethods.sqlite3_index_orderby orderBy = (UnsafeNativeMethods.sqlite3_index_orderby)Marshal.PtrToStructure(ptr2, typeFromHandle2);
			orderBys[j] = new SQLiteIndexOrderBy(orderBy);
		}
		if (!includeOutput)
		{
			return;
		}
		SQLiteIndexOutputs sQLiteIndexOutputs = index.Outputs;
		if (sQLiteIndexOutputs == null)
		{
			return;
		}
		SQLiteIndexConstraintUsage[] constraintUsages = sQLiteIndexOutputs.ConstraintUsages;
		if (constraintUsages != null)
		{
			Type typeFromHandle3 = typeof(UnsafeNativeMethods.sqlite3_index_constraint_usage);
			int num5 = Marshal.SizeOf(typeFromHandle3);
			for (int k = 0; k < num; k++)
			{
				IntPtr ptr3 = SQLiteMarshal.IntPtrForOffset(pointer3, k * num5);
				UnsafeNativeMethods.sqlite3_index_constraint_usage constraintUsage = (UnsafeNativeMethods.sqlite3_index_constraint_usage)Marshal.PtrToStructure(ptr3, typeFromHandle3);
				constraintUsages[k] = new SQLiteIndexConstraintUsage(constraintUsage);
			}
			offset = SQLiteMarshal.NextOffsetOf(offset, IntPtr.Size, 4);
			sQLiteIndexOutputs.IndexNumber = SQLiteMarshal.ReadInt32(pIndex, offset);
			offset = SQLiteMarshal.NextOffsetOf(offset, 4, IntPtr.Size);
			sQLiteIndexOutputs.IndexString = SQLiteString.StringFromUtf8IntPtr(SQLiteMarshal.ReadIntPtr(pIndex, offset));
			offset = SQLiteMarshal.NextOffsetOf(offset, IntPtr.Size, 4);
			sQLiteIndexOutputs.NeedToFreeIndexString = SQLiteMarshal.ReadInt32(pIndex, offset);
			offset = SQLiteMarshal.NextOffsetOf(offset, 4, 4);
			sQLiteIndexOutputs.OrderByConsumed = SQLiteMarshal.ReadInt32(pIndex, offset);
			offset = SQLiteMarshal.NextOffsetOf(offset, 4, 8);
			sQLiteIndexOutputs.EstimatedCost = SQLiteMarshal.ReadDouble(pIndex, offset);
			offset = SQLiteMarshal.NextOffsetOf(offset, 8, 8);
			if (sQLiteIndexOutputs.CanUseEstimatedRows())
			{
				sQLiteIndexOutputs.EstimatedRows = SQLiteMarshal.ReadInt64(pIndex, offset);
			}
			offset = SQLiteMarshal.NextOffsetOf(offset, 8, 4);
			if (sQLiteIndexOutputs.CanUseIndexFlags())
			{
				sQLiteIndexOutputs.IndexFlags = (SQLiteIndexFlags)SQLiteMarshal.ReadInt32(pIndex, offset);
			}
			offset = SQLiteMarshal.NextOffsetOf(offset, 4, 8);
			if (sQLiteIndexOutputs.CanUseColumnsUsed())
			{
				sQLiteIndexOutputs.ColumnsUsed = SQLiteMarshal.ReadInt64(pIndex, offset);
			}
		}
	}

	internal static void ToIntPtr(SQLiteIndex index, IntPtr pIndex, bool includeInput)
	{
		if (index == null)
		{
			return;
		}
		SQLiteIndexOutputs sQLiteIndexOutputs = index.Outputs;
		if (sQLiteIndexOutputs == null)
		{
			return;
		}
		SQLiteIndexConstraintUsage[] constraintUsages = sQLiteIndexOutputs.ConstraintUsages;
		if (constraintUsages == null)
		{
			return;
		}
		SQLiteIndexInputs sQLiteIndexInputs = null;
		SQLiteIndexConstraint[] array = null;
		SQLiteIndexOrderBy[] array2 = null;
		if (includeInput)
		{
			sQLiteIndexInputs = index.Inputs;
			if (sQLiteIndexInputs == null)
			{
				return;
			}
			array = sQLiteIndexInputs.Constraints;
			if (array == null)
			{
				return;
			}
			array2 = sQLiteIndexInputs.OrderBys;
			if (array2 == null)
			{
				return;
			}
		}
		if (pIndex == IntPtr.Zero)
		{
			return;
		}
		int offset = 0;
		int num = SQLiteMarshal.ReadInt32(pIndex, offset);
		if ((includeInput && num != array.Length) || num != constraintUsages.Length)
		{
			return;
		}
		offset = SQLiteMarshal.NextOffsetOf(offset, 4, IntPtr.Size);
		if (includeInput)
		{
			IntPtr pointer = SQLiteMarshal.ReadIntPtr(pIndex, offset);
			int num2 = Marshal.SizeOf(typeof(UnsafeNativeMethods.sqlite3_index_constraint));
			for (int i = 0; i < num; i++)
			{
				UnsafeNativeMethods.sqlite3_index_constraint sqlite3_index_constraint = new UnsafeNativeMethods.sqlite3_index_constraint(array[i]);
				Marshal.StructureToPtr((object)sqlite3_index_constraint, SQLiteMarshal.IntPtrForOffset(pointer, i * num2), fDeleteOld: false);
			}
		}
		offset = SQLiteMarshal.NextOffsetOf(offset, IntPtr.Size, 4);
		int num3 = (includeInput ? SQLiteMarshal.ReadInt32(pIndex, offset) : 0);
		if (includeInput && num3 != array2.Length)
		{
			return;
		}
		offset = SQLiteMarshal.NextOffsetOf(offset, 4, IntPtr.Size);
		if (includeInput)
		{
			IntPtr pointer2 = SQLiteMarshal.ReadIntPtr(pIndex, offset);
			int num4 = Marshal.SizeOf(typeof(UnsafeNativeMethods.sqlite3_index_orderby));
			for (int j = 0; j < num3; j++)
			{
				UnsafeNativeMethods.sqlite3_index_orderby sqlite3_index_orderby = new UnsafeNativeMethods.sqlite3_index_orderby(array2[j]);
				Marshal.StructureToPtr((object)sqlite3_index_orderby, SQLiteMarshal.IntPtrForOffset(pointer2, j * num4), fDeleteOld: false);
			}
		}
		offset = SQLiteMarshal.NextOffsetOf(offset, IntPtr.Size, IntPtr.Size);
		IntPtr pointer3 = SQLiteMarshal.ReadIntPtr(pIndex, offset);
		int num5 = Marshal.SizeOf(typeof(UnsafeNativeMethods.sqlite3_index_constraint_usage));
		for (int k = 0; k < num; k++)
		{
			UnsafeNativeMethods.sqlite3_index_constraint_usage sqlite3_index_constraint_usage = new UnsafeNativeMethods.sqlite3_index_constraint_usage(constraintUsages[k]);
			Marshal.StructureToPtr((object)sqlite3_index_constraint_usage, SQLiteMarshal.IntPtrForOffset(pointer3, k * num5), fDeleteOld: false);
		}
		offset = SQLiteMarshal.NextOffsetOf(offset, IntPtr.Size, 4);
		SQLiteMarshal.WriteInt32(pIndex, offset, sQLiteIndexOutputs.IndexNumber);
		offset = SQLiteMarshal.NextOffsetOf(offset, 4, IntPtr.Size);
		SQLiteMarshal.WriteIntPtr(pIndex, offset, SQLiteString.Utf8IntPtrFromString(sQLiteIndexOutputs.IndexString));
		offset = SQLiteMarshal.NextOffsetOf(offset, IntPtr.Size, 4);
		int value = ((sQLiteIndexOutputs.NeedToFreeIndexString == 0) ? 1 : sQLiteIndexOutputs.NeedToFreeIndexString);
		SQLiteMarshal.WriteInt32(pIndex, offset, value);
		offset = SQLiteMarshal.NextOffsetOf(offset, 4, 4);
		SQLiteMarshal.WriteInt32(pIndex, offset, sQLiteIndexOutputs.OrderByConsumed);
		offset = SQLiteMarshal.NextOffsetOf(offset, 4, 8);
		if (sQLiteIndexOutputs.EstimatedCost.HasValue)
		{
			SQLiteMarshal.WriteDouble(pIndex, offset, sQLiteIndexOutputs.EstimatedCost.GetValueOrDefault());
		}
		offset = SQLiteMarshal.NextOffsetOf(offset, 8, 8);
		if (sQLiteIndexOutputs.CanUseEstimatedRows() && sQLiteIndexOutputs.EstimatedRows.HasValue)
		{
			SQLiteMarshal.WriteInt64(pIndex, offset, sQLiteIndexOutputs.EstimatedRows.GetValueOrDefault());
		}
		offset = SQLiteMarshal.NextOffsetOf(offset, 8, 4);
		if (sQLiteIndexOutputs.CanUseIndexFlags() && sQLiteIndexOutputs.IndexFlags.HasValue)
		{
			SQLiteMarshal.WriteInt32(pIndex, offset, (int)sQLiteIndexOutputs.IndexFlags.GetValueOrDefault());
		}
		offset = SQLiteMarshal.NextOffsetOf(offset, 4, 8);
		if (sQLiteIndexOutputs.CanUseColumnsUsed() && sQLiteIndexOutputs.ColumnsUsed.HasValue)
		{
			SQLiteMarshal.WriteInt64(pIndex, offset, sQLiteIndexOutputs.ColumnsUsed.GetValueOrDefault());
		}
	}

	static SQLiteIndex()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteIndex));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0099(107401374), _0099(107401337)), _0099(107401332), _0099(107401327)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0099(107401354)))
		{
			return;
		}
		throw new SecurityException(_0099(107401297));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
