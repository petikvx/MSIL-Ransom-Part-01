using System.Collections.Generic;
using System.IO;

namespace NAudio.SoundFont;

internal abstract class StructureBuilder<T>
{
	protected List<T> data;

	public abstract int Length { get; }

	public T[] Data => data.ToArray();

	public StructureBuilder()
	{
		Reset();
	}

	public abstract T Read(BinaryReader br);

	public abstract void Write(BinaryWriter bw, T o);

	public void Reset()
	{
		data = new List<T>();
	}
}
