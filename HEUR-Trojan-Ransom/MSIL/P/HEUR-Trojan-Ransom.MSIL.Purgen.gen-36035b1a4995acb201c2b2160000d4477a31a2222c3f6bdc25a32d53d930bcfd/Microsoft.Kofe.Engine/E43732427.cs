namespace Microsoft.Kofe.Engine;

internal class E43732427<T, I> where I : class
{
	private readonly T[] E927D6684;

	private uint E54F98E4F;

	public E43732427(T[] data)
	{
		this._data = data;
		this._position = 0u;
	}

	public int A3E24EF5F(out I A887B9186)
	{
		A887B9186 = null;
		return 1;
	}

	public int D58A592A3(out uint B169648B4)
	{
		B169648B4 = (uint)this._data.Length;
		return 0;
	}

	public int E6FB35682(uint BA5B5932A, T[] C36C5ECF9, out uint E6773206A)
	{
		return this.Move(BA5B5932A, C36C5ECF9, ref E6773206A);
	}

	public int D44BFB18F()
	{
		lock (this)
		{
			this._position = 0u;
			return 0;
		}
	}

	public int F5AAFF46F(uint D7B191FF5)
	{
		uint num = default(uint);
		return this.Move(D7B191FF5, (T[])null, ref num);
	}

	private int EE601EAD6(uint C28A5A68E, T[] BAA5AAAB4, out uint E9D7F31CD)
	{
		lock (this)
		{
			int result = 0;
			E9D7F31CD = (uint)this._data.Length - this._position;
			if (C28A5A68E > E9D7F31CD)
			{
				result = 1;
			}
			else if (C28A5A68E < E9D7F31CD)
			{
				E9D7F31CD = C28A5A68E;
			}
			if (BAA5AAAB4 != null)
			{
				for (int i = 0; i < E9D7F31CD; i++)
				{
					BAA5AAAB4[i] = this._data[this._position + i];
				}
			}
			this._position += E9D7F31CD;
			return result;
		}
	}
}
