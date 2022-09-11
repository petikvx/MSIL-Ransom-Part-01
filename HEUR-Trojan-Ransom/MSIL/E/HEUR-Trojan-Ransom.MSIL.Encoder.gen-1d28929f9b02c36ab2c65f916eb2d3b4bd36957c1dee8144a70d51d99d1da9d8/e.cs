public class e : k
{
	public object a;

	public byte[] b;

	public e(i i_0)
	{
		this.a = i_0;
		b = ((i)this.a).b();
	}

	public unsafe void a(string string_0)
	{
		int num = 443;
		object byte_ = _003CModule_003E.a((object)this, (object)string_0);
		object object_ = ((i)this.a).a((byte[])byte_, b);
		_003CModule_003E.a((object)this, (object)string_0, object_);
		object obj = ((delegate*<string, string>)r.a[4])(string_0);
		object obj2 = (object)/*calli with instance method signature not supportd*/;
		try
		{
			((delegate*<string, string, void>)r.a[num - 437])(string_0, (string)obj2);
		}
		catch
		{
		}
		((delegate*<void>)r.a[num - 436])();
	}
}
