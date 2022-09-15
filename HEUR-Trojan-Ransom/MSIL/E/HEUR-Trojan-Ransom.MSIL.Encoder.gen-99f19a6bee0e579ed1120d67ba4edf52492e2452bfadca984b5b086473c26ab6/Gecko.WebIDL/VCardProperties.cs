using System.ComponentModel;

namespace Gecko.WebIDL;

public enum VCardProperties
{
	[Description("version")]
	version,
	[Description("fn")]
	fn,
	[Description("n")]
	n,
	[Description("photo")]
	photo,
	[Description("bday")]
	bday,
	[Description("adr")]
	adr,
	[Description("label")]
	label,
	[Description("tel")]
	tel,
	[Description("email")]
	email,
	[Description("mailer")]
	mailer,
	[Description("tz")]
	tz,
	[Description("geo")]
	geo,
	[Description("title")]
	title,
	[Description("role")]
	role,
	[Description("logo")]
	logo,
	[Description("agent")]
	agent,
	[Description("org")]
	org,
	[Description("note")]
	note,
	[Description("rev")]
	rev,
	[Description("sound")]
	sound,
	[Description("url")]
	url,
	[Description("uid")]
	uid,
	[Description("key")]
	key,
	[Description("nickname")]
	nickname,
	[Description("categories")]
	categories,
	[Description("proid")]
	proid,
	[Description("class")]
	@class,
	[Description("sort-string")]
	sortstring,
	[Description("x-irmc-call-datetime")]
	xirmccalldatetime,
	[Description("x-bt-speeddialkey")]
	xbtspeeddialkey,
	[Description("x-bt-uci")]
	xbtuci,
	[Description("x-bt-uid")]
	xbtuid
}