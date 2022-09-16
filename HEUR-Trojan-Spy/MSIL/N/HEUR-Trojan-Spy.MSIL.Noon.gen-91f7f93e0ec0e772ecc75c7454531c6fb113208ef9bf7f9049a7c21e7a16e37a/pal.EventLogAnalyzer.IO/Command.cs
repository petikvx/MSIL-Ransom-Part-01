namespace pal.EventLogAnalyzer.IO;

public readonly struct Command
{
	public readonly CommandModel Format;

	public readonly object[] Args;

	public Command(in CommandModel f)
	{
		Format = f;
		Args = new object[0];
	}

	public Command(in CommandModel f, object arg1)
	{
		Format = f;
		Args = new object[1] { arg1 };
	}

	public Command(in CommandModel f, object arg1, object arg2)
	{
		Format = f;
		Args = new object[2] { arg1, arg2 };
	}

	public Command(in CommandModel f, object arg1, object arg2, object arg3)
	{
		Format = f;
		Args = new object[3] { arg1, arg2, arg3 };
	}

	public Command(in CommandModel f, object[] args)
	{
		Format = f;
		Args = args;
	}

	public override string ToString()
	{
		ushort type = Format.Type;
		return type + ": " + Args.ToExpandedString();
	}

	public static implicit operator ushort(in Command c)
	{
		return c.Format.Type;
	}
}
