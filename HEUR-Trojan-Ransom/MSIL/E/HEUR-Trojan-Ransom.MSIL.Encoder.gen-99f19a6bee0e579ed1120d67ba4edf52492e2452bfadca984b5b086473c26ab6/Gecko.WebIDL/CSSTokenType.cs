using System.ComponentModel;

namespace Gecko.WebIDL;

public enum CSSTokenType
{
	[Description("whitespace")]
	whitespace,
	[Description("comment")]
	comment,
	[Description("ident")]
	ident,
	[Description("function")]
	function,
	[Description("at")]
	at,
	[Description("id")]
	id,
	[Description("hash")]
	hash,
	[Description("number")]
	number,
	[Description("dimension")]
	dimension,
	[Description("percentage")]
	percentage,
	[Description("string")]
	@string,
	[Description("bad_string")]
	bad_string,
	[Description("url")]
	url,
	[Description("bad_url")]
	bad_url,
	[Description("symbol")]
	symbol,
	[Description("includes")]
	includes,
	[Description("dashmatch")]
	dashmatch,
	[Description("beginsmatch")]
	beginsmatch,
	[Description("endsmatch")]
	endsmatch,
	[Description("containsmatch")]
	containsmatch,
	[Description("urange")]
	urange,
	[Description("htmlcomment")]
	htmlcomment
}
