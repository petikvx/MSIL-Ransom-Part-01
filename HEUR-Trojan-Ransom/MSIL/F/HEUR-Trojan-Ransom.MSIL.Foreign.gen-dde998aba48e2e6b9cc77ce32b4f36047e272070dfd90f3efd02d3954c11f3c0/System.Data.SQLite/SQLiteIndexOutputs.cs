namespace System.Data.SQLite;

public sealed class SQLiteIndexOutputs
{
	private SQLiteIndexConstraintUsage[] constraintUsages;

	private int indexNumber;

	private string indexString;

	private int needToFreeIndexString;

	private int orderByConsumed;

	private double? estimatedCost;

	private long? estimatedRows;

	private SQLiteIndexFlags? indexFlags;

	private long? columnsUsed;

	public SQLiteIndexConstraintUsage[] ConstraintUsages => constraintUsages;

	public int IndexNumber
	{
		get
		{
			return indexNumber;
		}
		set
		{
			indexNumber = value;
		}
	}

	public string IndexString
	{
		get
		{
			return indexString;
		}
		set
		{
			indexString = value;
		}
	}

	public int NeedToFreeIndexString
	{
		get
		{
			return needToFreeIndexString;
		}
		set
		{
			needToFreeIndexString = value;
		}
	}

	public int OrderByConsumed
	{
		get
		{
			return orderByConsumed;
		}
		set
		{
			orderByConsumed = value;
		}
	}

	public double? EstimatedCost
	{
		get
		{
			return estimatedCost;
		}
		set
		{
			estimatedCost = value;
		}
	}

	public long? EstimatedRows
	{
		get
		{
			return estimatedRows;
		}
		set
		{
			estimatedRows = value;
		}
	}

	public SQLiteIndexFlags? IndexFlags
	{
		get
		{
			return indexFlags;
		}
		set
		{
			indexFlags = value;
		}
	}

	public long? ColumnsUsed
	{
		get
		{
			return columnsUsed;
		}
		set
		{
			columnsUsed = value;
		}
	}

	internal SQLiteIndexOutputs(int nConstraint)
	{
		constraintUsages = new SQLiteIndexConstraintUsage[nConstraint];
		for (int i = 0; i < nConstraint; i++)
		{
			constraintUsages[i] = new SQLiteIndexConstraintUsage();
		}
	}

	public bool CanUseEstimatedRows()
	{
		if (UnsafeNativeMethods.sqlite3_libversion_number() >= 3008002)
		{
			return true;
		}
		return false;
	}

	public bool CanUseIndexFlags()
	{
		if (UnsafeNativeMethods.sqlite3_libversion_number() >= 3009000)
		{
			return true;
		}
		return false;
	}

	public bool CanUseColumnsUsed()
	{
		if (UnsafeNativeMethods.sqlite3_libversion_number() >= 3010000)
		{
			return true;
		}
		return false;
	}
}
