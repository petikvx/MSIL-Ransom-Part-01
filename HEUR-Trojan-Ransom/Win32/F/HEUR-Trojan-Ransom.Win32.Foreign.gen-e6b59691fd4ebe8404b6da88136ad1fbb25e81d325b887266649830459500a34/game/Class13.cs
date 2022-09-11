namespace game;

internal class Class13 : Interface0, Interface1, Interface2
{
	private Class2 class2_0;

	private Class5 class5_0;

	public bool Boolean_3 => class2_0.Boolean_3 || class5_0.Boolean_3;

	public int Int32_1 => class2_0.Boolean_4 ? class5_0.Int32_2 : class2_0.Int32_2;

	public bool Boolean_4 => !Boolean_5 && !Boolean_3;

	public bool Boolean_5 => class2_0.Boolean_4 && class5_0.Boolean_4;

	public Class10 Class10_1 => class2_0.Boolean_4 ? class5_0.Class10_1 : class2_0.Class10_1;

	public Class13(Class8 class8_0)
	{
		class2_0 = new Class2(class8_0);
		class5_0 = new Class5(class8_0);
	}

	public void vmethod_0(int int_0)
	{
		if (!class2_0.Boolean_4)
		{
			class2_0.vmethod_1(int_0);
		}
		else
		{
			class5_0.vmethod_1(int_0);
		}
	}

	public void vmethod_1()
	{
		class2_0.vmethod_0();
		class5_0.vmethod_0();
	}
}
