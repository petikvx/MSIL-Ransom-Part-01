using AjScript.Language;

namespace AjScript;

public class Predicates
{
	public static bool IsFalse(object obj)
	{
		if (obj == null)
		{
			return true;
		}
		if (obj == Undefined.Instance)
		{
			return true;
		}
		if (obj is bool)
		{
			return !(bool)obj;
		}
		if (obj is int)
		{
			return (int)obj == 0;
		}
		if (obj is string)
		{
			return string.IsNullOrEmpty((string)obj);
		}
		if (obj is long)
		{
			return (long)obj == 0L;
		}
		if (obj is short)
		{
			return (short)obj == 0;
		}
		if (obj is double)
		{
			return (double)obj == 0.0;
		}
		if (obj is float)
		{
			return (float)obj == 0f;
		}
		return false;
	}

	public static bool IsTrue(object obj)
	{
		return !IsFalse(obj);
	}
}
