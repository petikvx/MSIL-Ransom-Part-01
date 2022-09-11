namespace ns1;

public interface IInternalConfigRoot
{
	bool IsDesignTime { get; }

	void imethod_0(IInternalConfigHost iinternalConfigHost_0, bool bool_0);

	object imethod_1(string string_0, string string_1);

	string imethod_2(string string_0);

	IInternalConfigRecord imethod_3(string string_0);

	IInternalConfigRecord imethod_4(string string_0);

	void imethod_5(string string_0);
}
