using System.Runtime.CompilerServices;
using System.Threading.Tasks;

internal static class Class3
{
	private static string string_0;

	private static string string_1;

	[AsyncStateMachine(typeof(Struct0))]
	internal static Task smethod_0(string string_2)
	{
		if (1 == 0)
		{
		}
		int num = 1268;
		int num2 = num;
		num = 1268;
		switch (num2 == num)
		{
		default:
		{
			if (0 == 0)
			{
			}
			num = 0;
			Struct0 stateMachine = default(Struct0);
			stateMachine.string_0 = string_2;
			stateMachine.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			stateMachine.int_0 = -1;
			AsyncTaskMethodBuilder asyncTaskMethodBuilder_ = stateMachine.asyncTaskMethodBuilder_0;
			asyncTaskMethodBuilder_.Start(ref stateMachine);
			return stateMachine.asyncTaskMethodBuilder_0.Task;
		}
		}
	}

	static Class3()
	{
		int num = -13189;
		int num2 = num;
		num = -13189;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		num = 0;
		string_0 = "c4977d72e27db96115417e498b443276";
		string_1 = "45324f7f92fdc762fba53e09befcefba";
	}
}
