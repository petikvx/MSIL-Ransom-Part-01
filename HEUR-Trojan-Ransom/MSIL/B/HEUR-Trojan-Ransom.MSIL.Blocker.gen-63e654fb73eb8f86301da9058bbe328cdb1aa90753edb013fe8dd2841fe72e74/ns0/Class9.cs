using System;

namespace ns0;

internal sealed class Class9 : FtpStyleUriParser, Interface5
{
	public override bool vmethod_0(object object_0)
	{
		return base.Equals(object_0);
	}

	public override int vmethod_1()
	{
		return base.GetHashCode();
	}

	public override string vmethod_2()
	{
		return base.ToString();
	}

	protected override string vmethod_3(Uri uri_0, UriComponents uriComponents_0, UriFormat uriFormat_0)
	{
		return base.GetComponents(uri_0, uriComponents_0, uriFormat_0);
	}

	protected override void vmethod_4(Uri uri_0, out UriFormatException uriFormatException_0)
	{
		base.InitializeAndValidate(uri_0, out uriFormatException_0);
	}

	protected override bool vmethod_5(Uri uri_0, Uri uri_1)
	{
		return base.IsBaseOf(uri_0, uri_1);
	}

	protected override bool vmethod_6(Uri uri_0)
	{
		return base.IsWellFormedOriginalString(uri_0);
	}

	protected override UriParser vmethod_7()
	{
		return base.OnNewUri();
	}

	protected override void vmethod_8(string habqAuMZkSV8UxzowJvEb9zKE5qPQrCwxmbdnr4GO9mBH0jv16qDSsnQKbvL9HlKThWoRW4lh7B1aZO6DRle7Y1lQ6xw9o45mkdqKLk6tdc8NhkbPhb8STCFrxS1, int int_0)
	{
		base.OnRegister(habqAuMZkSV8UxzowJvEb9zKE5qPQrCwxmbdnr4GO9mBH0jv16qDSsnQKbvL9HlKThWoRW4lh7B1aZO6DRle7Y1lQ6xw9o45mkdqKLk6tdc8NhkbPhb8STCFrxS1, int_0);
	}

	protected override string vmethod_9(Uri uri_0, Uri uri_1, out UriFormatException uriFormatException_0)
	{
		return base.Resolve(uri_0, uri_1, out uriFormatException_0);
	}
}
