using System.Threading;

namespace System.Runtime.Caching;

[Serializable]
internal struct SafeBitVector32
{
	private volatile int _data;

	internal bool this[int bit]
	{
		get
		{
			int data = _data;
			return (data & bit) == bit;
		}
		set
		{
			int data;
			int num;
			do
			{
				data = _data;
				int value2 = (value ? (data | bit) : (data & ~bit));
				num = Interlocked.CompareExchange(ref _data, value2, data);
			}
			while (num != data);
		}
	}

	internal bool ChangeValue(int bit, bool value)
	{
		int data;
		int num2;
		do
		{
			data = _data;
			int num = (value ? (data | bit) : (data & ~bit));
			if (data != num)
			{
				num2 = Interlocked.CompareExchange(ref _data, num, data);
				continue;
			}
			return false;
		}
		while (num2 != data);
		return true;
	}
}
