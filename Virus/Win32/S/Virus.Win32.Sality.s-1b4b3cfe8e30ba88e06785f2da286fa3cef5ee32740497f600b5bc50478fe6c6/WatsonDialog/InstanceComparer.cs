using System.Collections;
using System.Collections.Generic;

namespace WatsonDialog;

internal class InstanceComparer : IComparer<Instance>
{
	private IComparer m_comparer;

	private bool m_descending = true;

	private int m_column;

	internal bool Descending
	{
		set
		{
			m_descending = value;
		}
	}

	internal int Column
	{
		set
		{
			m_column = value;
		}
	}

	internal InstanceComparer(IComparer comp)
	{
		m_comparer = comp;
	}

	private static bool ValidateData(Instance a)
	{
		return a != null;
	}

	private static int GetOtherColumn(int col)
	{
		return col switch
		{
			0 => 1, 
			1 => 0, 
			_ => col, 
		};
	}

	private int CompareField(Instance a, Instance b, int col)
	{
		if (ValidateData(a) && ValidateData(b))
		{
			return col switch
			{
				0 => m_comparer.Compare(a.instanceName, b.instanceName), 
				1 => m_comparer.Compare(a.instanceType, b.instanceType), 
				_ => 0, 
			};
		}
		return 0;
	}

	public int Compare(Instance instA, Instance instB)
	{
		if (object.ReferenceEquals(instA, instB))
		{
			return 0;
		}
		if (instA.IsAgnostic && instB.IsAgnostic)
		{
			if (!instA.isWow)
			{
				return -1;
			}
			return 1;
		}
		if (!instA.IsAgnostic && !instB.IsAgnostic)
		{
			int num = CompareField(instA, instB, m_column);
			if (num == 0)
			{
				num = CompareField(instA, instB, GetOtherColumn(m_column));
			}
			return (m_descending ? 1 : (-1)) * num;
		}
		if (!instA.IsAgnostic)
		{
			return 1;
		}
		return -1;
	}

	public bool Equals(Instance instA, Instance instB)
	{
		return Compare(instA, instB) == 0;
	}

	public int GetHashCode(Instance a)
	{
		ValidateData(a);
		return a.GetHashCode();
	}
}
