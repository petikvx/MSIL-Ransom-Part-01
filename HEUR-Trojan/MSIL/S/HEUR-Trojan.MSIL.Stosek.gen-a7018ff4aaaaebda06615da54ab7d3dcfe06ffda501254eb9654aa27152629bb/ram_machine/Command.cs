using System.ComponentModel;

namespace ram_machine;

internal class Command
{
	public CommandType Type { get; set; }

	public int Position { get; set; }

	public int? Arg1 { get; set; }

	public int? Arg2 { get; set; }

	public int? Arg3 { get; set; }

	public override string ToString()
	{
		string text = ((Arg1.HasValue || Arg2.HasValue || Arg3.HasValue) ? Command.smethod_0("{0} {1} {2}", (object)(Arg1.HasValue ? Arg1.Value.ToString() : string.Empty), (object)(Arg2.HasValue ? Arg2.Value.ToString() : string.Empty), (object)(Arg3.HasValue ? Arg3.Value.ToString() : string.Empty)) : string.Empty);
		if (!Command.smethod_1(text))
		{
			text = Command.smethod_2("Parametry: ", text);
		}
		return Type switch
		{
			CommandType.AssignValue => Command.smethod_2("Przypisz wartość: Mi <-- 1 ", text), 
			CommandType.Add => Command.smethod_2("Dodaj: Mi <-- Mj + Mk ", text), 
			CommandType.Substract => Command.smethod_2("Odejmij: Mi <-- Mj - Mk ", text), 
			CommandType.Divide => Command.smethod_2("Podziel: Mi <-- floor(Mi/2) ", text), 
			CommandType.CopyValue => Command.smethod_2("Kopiuj wartość: M[i] <-- M[M[j]] ", text), 
			CommandType.CopyValue2 => Command.smethod_2("Kopiuj wartość 2: M[M[i]] <-- M[j] ", text), 
			CommandType.GotoIf => Command.smethod_2("Idź do: goto m if Mi > 0 ", text), 
			CommandType.Halt => "STOP", 
			_ => throw Command.smethod_3(), 
		};
	}

	public Instruction Translate()
	{
		return null;
	}

	public int NumberOfArguments()
	{
		return Type switch
		{
			CommandType.AssignValue => 2, 
			CommandType.Add => 3, 
			CommandType.Substract => 3, 
			CommandType.Divide => 1, 
			CommandType.CopyValue => 2, 
			CommandType.CopyValue2 => 2, 
			CommandType.GotoIf => 2, 
			CommandType.Halt => 0, 
			_ => throw Command.smethod_3(), 
		};
	}

	static string smethod_0(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}

	static bool smethod_1(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	static string smethod_2(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static InvalidEnumArgumentException smethod_3()
	{
		return new InvalidEnumArgumentException();
	}
}
