using System.Collections;
using System.Collections.Generic;

namespace DiceRoller;

public class StandardRolls : IEnumerable
{
	private class StandardRollEnumerator : IEnumerator
	{
		public object Current
		{
			get
			{
				object result = default(object);
				return result;
			}
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	private List<StandardRoll> m_standardRolls;

	public StandardRolls()
	{
		m_standardRolls = new List<StandardRoll>();
	}

	public IEnumerator GetEnumerator()
	{
		IEnumerator result = default(IEnumerator);
		return result;
	}
}
