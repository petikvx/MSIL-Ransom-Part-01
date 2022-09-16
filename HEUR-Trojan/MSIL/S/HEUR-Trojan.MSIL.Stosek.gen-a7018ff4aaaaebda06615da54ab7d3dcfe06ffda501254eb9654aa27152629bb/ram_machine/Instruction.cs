using System.Collections.Generic;

namespace ram_machine;

internal abstract class Instruction
{
	public int line;

	public List<int> parameters;

	public Instruction()
	{
		line = -2;
		parameters = new List<int>();
	}

	public abstract int run(int[] tape);

	public abstract void setParameters(List<int> parameters);

	public new abstract string ToString();

	public void setLine(int line)
	{
		this.line = line;
	}
}
