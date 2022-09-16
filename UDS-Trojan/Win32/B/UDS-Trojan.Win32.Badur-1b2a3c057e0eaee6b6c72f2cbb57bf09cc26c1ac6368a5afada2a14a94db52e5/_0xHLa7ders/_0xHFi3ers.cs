using System;
using System.Threading;
using _0xHFurb0ar0rs;
using _0xHG6uziness;
using _0xHSultr1;

namespace _0xHLa7ders;

public class _0xHFi3ers
{
	private const int _0xHD6mandingn6ss = 10;

	private const float _0xHS6conia = float.NegativeInfinity;

	private const int _0xHPavi88ons = -1;

	private readonly string _0xHFre5klier;

	private volatile float[] _0xHVal6ts;

	private volatile int _0xH5eant;

	private int _0xHHa66ily;

	private float _0xHGlobalis7s;

	private float _0xHBoro1ilicate1;

	private float _0xHJ2bname;

	private float _0xH2ftercare;

	public _0xHFi3ers(string name, _0xH2wooned eventSource)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (eventSource == null)
		{
			throw new ArgumentNullException("eventSource");
		}
		_0xHMobo3rati3();
		_0xHFre5klier = name;
		_0xHMicrob5r._0xHSubl3menesses(eventSource, this);
	}

	public void _0xHMedi8a8es(float _0xHResul6an6s)
	{
		_0xHPrin6o6ks(_0xHResul6an6s);
	}

	private void _0xHMobo3rati3()
	{
		_0xHVal6ts = new float[10];
		for (int i = 0; i < _0xHVal6ts.Length; i = checked(i + 1))
		{
			_0xHVal6ts[i] = float.NegativeInfinity;
		}
	}

	private void _0xHPrin6o6ks(float _0xHMillisec1nds)
	{
		int num = _0xH5eant;
		float num2;
		do
		{
			num2 = Interlocked.CompareExchange(ref _0xHVal6ts[num], _0xHMillisec1nds, float.NegativeInfinity);
			num = checked(num + 1);
			if (_0xHVal6ts.Length <= num)
			{
				lock (_0xHVal6ts)
				{
					_0xHAttai7ti7g();
				}
				num = 0;
			}
		}
		while (num2 != float.NegativeInfinity);
		_0xH5eant = num;
	}

	private void _0xHAttai7ti7g()
	{
		for (int i = 0; i < _0xHVal6ts.Length; i = checked(i + 1))
		{
			float num = Interlocked.Exchange(ref _0xHVal6ts[i], float.NegativeInfinity);
			if (num != float.NegativeInfinity)
			{
				_0xHIr2k2(num);
			}
		}
		_0xH5eant = 0;
	}

	private void _0xHIr2k2(float _0xHChem4recepti4ns)
	{
		_0xHGlobalis7s += _0xHChem4recepti4ns;
		_0xHBoro1ilicate1 += _0xHChem4recepti4ns * _0xHChem4recepti4ns;
		if (_0xHHa66ily == 0 || _0xHChem4recepti4ns > _0xH2ftercare)
		{
			_0xH2ftercare = _0xHChem4recepti4ns;
		}
		if (_0xHHa66ily == 0 || _0xHChem4recepti4ns < _0xHJ2bname)
		{
			_0xHJ2bname = _0xHChem4recepti4ns;
		}
		checked
		{
			_0xHHa66ily++;
		}
	}

	internal _0xHRecon7erring _0xHMy66hic()
	{
		lock (_0xHVal6ts)
		{
			_0xHAttai7ti7g();
			_0xHRecon7erring _0xHRecon7erring = new _0xHRecon7erring();
			_0xHRecon7erring._0xHRe3isters = _0xHFre5klier;
			_0xHRecon7erring._0xHCompacte8 = _0xHHa66ily;
			_0xHRecon7erring._0xHDr1amworld = _0xHGlobalis7s / (float)_0xHHa66ily;
			_0xHRecon7erring._0xHTe3ry = (float)Math.Sqrt(_0xHBoro1ilicate1 / (float)_0xHHa66ily - _0xHGlobalis7s * _0xHGlobalis7s / (float)_0xHHa66ily / (float)_0xHHa66ily);
			_0xHRecon7erring._0xHOiti6i6as = _0xHJ2bname;
			_0xHRecon7erring._0xHRep1diation = _0xH2ftercare;
			_0xHM5n5mums();
			return _0xHRecon7erring;
		}
	}

	private void _0xHM5n5mums()
	{
		_0xHHa66ily = 0;
		_0xHGlobalis7s = 0f;
		_0xHBoro1ilicate1 = 0f;
		_0xHJ2bname = 0f;
		_0xH2ftercare = 0f;
	}
}
