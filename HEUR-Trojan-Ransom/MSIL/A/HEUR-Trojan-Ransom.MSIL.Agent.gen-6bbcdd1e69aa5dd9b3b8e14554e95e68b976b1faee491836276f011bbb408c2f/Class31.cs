using System;
using System.Runtime.CompilerServices;

internal class Class31 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.ce228b0c;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint uint_ = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 @struct = fdc40966_0.class58_0.method_0(uint_);
		if (!(@struct.c9550f69() is Interface1))
		{
			throw new ExecutionEngineException();
		}
		Struct3 struct3_ = ((Interface1)@struct.c9550f69()).bb331190(fdc40966_0, (f75d8d37)4);
		fdc40966_0.class58_0.b53f41f9(uint_, struct3_);
		enum0_0 = (Enum0)0;
	}
}
