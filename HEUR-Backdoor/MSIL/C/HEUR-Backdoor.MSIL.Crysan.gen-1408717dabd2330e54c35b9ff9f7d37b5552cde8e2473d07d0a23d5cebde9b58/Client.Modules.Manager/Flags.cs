namespace Client.Modules.Manager;

internal sealed class Flags
{
	public static string GetFlag(string c)
	{
		return c switch
		{
			"AD" => "\ud83c\udde6\ud83c\udde9", 
			"AE" => "\ud83c\udde6\ud83c\uddea", 
			"AF" => "\ud83c\udde6\ud83c\uddeb", 
			"AG" => "\ud83c\udde6\ud83c\uddec", 
			"AI" => "\ud83c\udde6\ud83c\uddee", 
			"AL" => "\ud83c\udde6\ud83c\uddf1", 
			"AM" => "\ud83c\udde6\ud83c\uddf2", 
			"AO" => "\ud83c\udde6\ud83c\uddf4", 
			"AQ" => "\ud83c\udde6\ud83c\uddf6", 
			"AR" => "\ud83c\udde6\ud83c\uddf7", 
			"AS" => "\ud83c\udde6\ud83c\uddf8", 
			"AT" => "\ud83c\udde6\ud83c\uddf9", 
			"AU" => "\ud83c\udde6\ud83c\uddfa", 
			"AW" => "\ud83c\udde6\ud83c\uddfc", 
			"AX" => "\ud83c\udde6\ud83c\uddfd", 
			"AZ" => "\ud83c\udde6\ud83c\uddff", 
			"BA" => "\ud83c\udde7\ud83c\udde6", 
			"BB" => "\ud83c\udde7\ud83c\udde7", 
			"BD" => "\ud83c\udde7\ud83c\udde9", 
			"BE" => "\ud83c\udde7\ud83c\uddea", 
			"BF" => "\ud83c\udde7\ud83c\uddeb", 
			"BG" => "\ud83c\udde7\ud83c\uddec", 
			"BH" => "\ud83c\udde7\ud83c\udded", 
			"BI" => "\ud83c\udde7\ud83c\uddee", 
			"BJ" => "\ud83c\udde7\ud83c\uddef", 
			"BL" => "\ud83c\udde7\ud83c\uddf1", 
			"BM" => "\ud83c\udde7\ud83c\uddf2", 
			"BN" => "\ud83c\udde7\ud83c\uddf3", 
			"BO" => "\ud83c\udde7\ud83c\uddf4", 
			"BQ" => "\ud83c\udde7\ud83c\uddf6", 
			"BR" => "\ud83c\udde7\ud83c\uddf7", 
			"BS" => "\ud83c\udde7\ud83c\uddf8", 
			"BT" => "\ud83c\udde7\ud83c\uddf9", 
			"BV" => "\ud83c\udde7\ud83c\uddfb", 
			"BW" => "\ud83c\udde7\ud83c\uddfc", 
			"BY" => "\ud83c\udde7\ud83c\uddfe", 
			"BZ" => "\ud83c\udde7\ud83c\uddff", 
			"CA" => "\ud83c\udde8\ud83c\udde6", 
			"CC" => "\ud83c\udde8\ud83c\udde8", 
			"CD" => "\ud83c\udde8\ud83c\udde9", 
			"CF" => "\ud83c\udde8\ud83c\uddeb", 
			"CG" => "\ud83c\udde8\ud83c\uddec", 
			"CH" => "\ud83c\udde8\ud83c\udded", 
			"CI" => "\ud83c\udde8\ud83c\uddee", 
			"CK" => "\ud83c\udde8\ud83c\uddf0", 
			"CL" => "\ud83c\udde8\ud83c\uddf1", 
			"CM" => "\ud83c\udde8\ud83c\uddf2", 
			"CN" => "\ud83c\udde8\ud83c\uddf3", 
			"CO" => "\ud83c\udde8\ud83c\uddf4", 
			"CR" => "\ud83c\udde8\ud83c\uddf7", 
			"CU" => "\ud83c\udde8\ud83c\uddfa", 
			"CV" => "\ud83c\udde8\ud83c\uddfb", 
			"CW" => "\ud83c\udde8\ud83c\uddfc", 
			"CX" => "\ud83c\udde8\ud83c\uddfd", 
			"CY" => "\ud83c\udde8\ud83c\uddfe", 
			"CZ" => "\ud83c\udde8\ud83c\uddff", 
			"DE" => "\ud83c\udde9\ud83c\uddea", 
			"DJ" => "\ud83c\udde9\ud83c\uddef", 
			"DK" => "\ud83c\udde9\ud83c\uddf0", 
			"DM" => "\ud83c\udde9\ud83c\uddf2", 
			"DO" => "\ud83c\udde9\ud83c\uddf4", 
			"DZ" => "\ud83c\udde9\ud83c\uddff", 
			"EC" => "\ud83c\uddea\ud83c\udde8", 
			"EE" => "\ud83c\uddea\ud83c\uddea", 
			"EG" => "\ud83c\uddea\ud83c\uddec", 
			"EH" => "\ud83c\uddea\ud83c\udded", 
			"ER" => "\ud83c\uddea\ud83c\uddf7", 
			"ES" => "\ud83c\uddea\ud83c\uddf8", 
			"ET" => "\ud83c\uddea\ud83c\uddf9", 
			"FI" => "\ud83c\uddeb\ud83c\uddee", 
			"FJ" => "\ud83c\uddeb\ud83c\uddef", 
			"FK" => "\ud83c\uddeb\ud83c\uddf0", 
			"FM" => "\ud83c\uddeb\ud83c\uddf2", 
			"FO" => "\ud83c\uddeb\ud83c\uddf4", 
			"FR" => "\ud83c\uddeb\ud83c\uddf7", 
			"GA" => "\ud83c\uddec\ud83c\udde6", 
			"GB" => "\ud83c\uddec\ud83c\udde7", 
			"GD" => "\ud83c\uddec\ud83c\udde9", 
			"GE" => "\ud83c\uddec\ud83c\uddea", 
			"GF" => "\ud83c\uddec\ud83c\uddeb", 
			"GG" => "\ud83c\uddec\ud83c\uddec", 
			"GH" => "\ud83c\uddec\ud83c\udded", 
			"GI" => "\ud83c\uddec\ud83c\uddee", 
			"GL" => "\ud83c\uddec\ud83c\uddf1", 
			"GM" => "\ud83c\uddec\ud83c\uddf2", 
			"GN" => "\ud83c\uddec\ud83c\uddf3", 
			"GP" => "\ud83c\uddec\ud83c\uddf5", 
			"GQ" => "\ud83c\uddec\ud83c\uddf6", 
			"GR" => "\ud83c\uddec\ud83c\uddf7", 
			"GS" => "\ud83c\uddec\ud83c\uddf8", 
			"GT" => "\ud83c\uddec\ud83c\uddf9", 
			"GU" => "\ud83c\uddec\ud83c\uddfa", 
			"GW" => "\ud83c\uddec\ud83c\uddfc", 
			"GY" => "\ud83c\uddec\ud83c\uddfe", 
			"HK" => "\ud83c\udded\ud83c\uddf0", 
			"HM" => "\ud83c\udded\ud83c\uddf2", 
			"HN" => "\ud83c\udded\ud83c\uddf3", 
			"HR" => "\ud83c\udded\ud83c\uddf7", 
			"HT" => "\ud83c\udded\ud83c\uddf9", 
			"HU" => "\ud83c\udded\ud83c\uddfa", 
			"ID" => "\ud83c\uddee\ud83c\udde9", 
			"IE" => "\ud83c\uddee\ud83c\uddea", 
			"IL" => "\ud83c\uddee\ud83c\uddf1", 
			"IM" => "\ud83c\uddee\ud83c\uddf2", 
			"IN" => "\ud83c\uddee\ud83c\uddf3", 
			"IO" => "\ud83c\uddee\ud83c\uddf4", 
			"IQ" => "\ud83c\uddee\ud83c\uddf6", 
			"IR" => "\ud83c\uddee\ud83c\uddf7", 
			"IS" => "\ud83c\uddee\ud83c\uddf8", 
			"IT" => "\ud83c\uddee\ud83c\uddf9", 
			"JE" => "\ud83c\uddef\ud83c\uddea", 
			"JM" => "\ud83c\uddef\ud83c\uddf2", 
			"JO" => "\ud83c\uddef\ud83c\uddf4", 
			"JP" => "\ud83c\uddef\ud83c\uddf5", 
			"KE" => "\ud83c\uddf0\ud83c\uddea", 
			"KG" => "\ud83c\uddf0\ud83c\uddec", 
			"KH" => "\ud83c\uddf0\ud83c\udded", 
			"KI" => "\ud83c\uddf0\ud83c\uddee", 
			"KM" => "\ud83c\uddf0\ud83c\uddf2", 
			"KN" => "\ud83c\uddf0\ud83c\uddf3", 
			"KP" => "\ud83c\uddf0\ud83c\uddf5", 
			"KR" => "\ud83c\uddf0\ud83c\uddf7", 
			"KW" => "\ud83c\uddf0\ud83c\uddfc", 
			"KY" => "\ud83c\uddf0\ud83c\uddfe", 
			"KZ" => "\ud83c\uddf0\ud83c\uddff", 
			"LA" => "\ud83c\uddf1\ud83c\udde6", 
			"LB" => "\ud83c\uddf1\ud83c\udde7", 
			"LC" => "\ud83c\uddf1\ud83c\udde8", 
			"LI" => "\ud83c\uddf1\ud83c\uddee", 
			"LK" => "\ud83c\uddf1\ud83c\uddf0", 
			"LR" => "\ud83c\uddf1\ud83c\uddf7", 
			"LS" => "\ud83c\uddf1\ud83c\uddf8", 
			"LT" => "\ud83c\uddf1\ud83c\uddf9", 
			"LU" => "\ud83c\uddf1\ud83c\uddfa", 
			"LV" => "\ud83c\uddf1\ud83c\uddfb", 
			"LY" => "\ud83c\uddf1\ud83c\uddfe", 
			"MA" => "\ud83c\uddf2\ud83c\udde6", 
			"MC" => "\ud83c\uddf2\ud83c\udde8", 
			"MD" => "\ud83c\uddf2\ud83c\udde9", 
			"ME" => "\ud83c\uddf2\ud83c\uddea", 
			"MF" => "\ud83c\uddf2\ud83c\uddeb", 
			"MG" => "\ud83c\uddf2\ud83c\uddec", 
			"MH" => "\ud83c\uddf2\ud83c\udded", 
			"MK" => "\ud83c\uddf2\ud83c\uddf0", 
			"ML" => "\ud83c\uddf2\ud83c\uddf1", 
			"MM" => "\ud83c\uddf2\ud83c\uddf2", 
			"MN" => "\ud83c\uddf2\ud83c\uddf3", 
			"MO" => "\ud83c\uddf2\ud83c\uddf4", 
			"MP" => "\ud83c\uddf2\ud83c\uddf5", 
			"MQ" => "\ud83c\uddf2\ud83c\uddf6", 
			"MR" => "\ud83c\uddf2\ud83c\uddf7", 
			"MS" => "\ud83c\uddf2\ud83c\uddf8", 
			"MT" => "\ud83c\uddf2\ud83c\uddf9", 
			"MU" => "\ud83c\uddf2\ud83c\uddfa", 
			"MV" => "\ud83c\uddf2\ud83c\uddfb", 
			"MW" => "\ud83c\uddf2\ud83c\uddfc", 
			"MX" => "\ud83c\uddf2\ud83c\uddfd", 
			"MY" => "\ud83c\uddf2\ud83c\uddfe", 
			"MZ" => "\ud83c\uddf2\ud83c\uddff", 
			"NA" => "\ud83c\uddf3\ud83c\udde6", 
			"NC" => "\ud83c\uddf3\ud83c\udde8", 
			"NE" => "\ud83c\uddf3\ud83c\uddea", 
			"NF" => "\ud83c\uddf3\ud83c\uddeb", 
			"NG" => "\ud83c\uddf3\ud83c\uddec", 
			"NI" => "\ud83c\uddf3\ud83c\uddee", 
			"NL" => "\ud83c\uddf3\ud83c\uddf1", 
			"NO" => "\ud83c\uddf3\ud83c\uddf4", 
			"NP" => "\ud83c\uddf3\ud83c\uddf5", 
			"NR" => "\ud83c\uddf3\ud83c\uddf7", 
			"NU" => "\ud83c\uddf3\ud83c\uddfa", 
			"NZ" => "\ud83c\uddf3\ud83c\uddff", 
			"OM" => "\ud83c\uddf4\ud83c\uddf2", 
			"PA" => "\ud83c\uddf5\ud83c\udde6", 
			"PE" => "\ud83c\uddf5\ud83c\uddea", 
			"PF" => "\ud83c\uddf5\ud83c\uddeb", 
			"PG" => "\ud83c\uddf5\ud83c\uddec", 
			"PH" => "\ud83c\uddf5\ud83c\udded", 
			"PK" => "\ud83c\uddf5\ud83c\uddf0", 
			"PL" => "\ud83c\uddf5\ud83c\uddf1", 
			"PM" => "\ud83c\uddf5\ud83c\uddf2", 
			"PN" => "\ud83c\uddf5\ud83c\uddf3", 
			"PR" => "\ud83c\uddf5\ud83c\uddf7", 
			"PS" => "\ud83c\uddf5\ud83c\uddf8", 
			"PT" => "\ud83c\uddf5\ud83c\uddf9", 
			"PW" => "\ud83c\uddf5\ud83c\uddfc", 
			"PY" => "\ud83c\uddf5\ud83c\uddfe", 
			"QA" => "\ud83c\uddf6\ud83c\udde6", 
			"RE" => "\ud83c\uddf7\ud83c\uddea", 
			"RO" => "\ud83c\uddf7\ud83c\uddf4", 
			"RS" => "\ud83c\uddf7\ud83c\uddf8", 
			"RU" => "\ud83c\uddf7\ud83c\uddfa", 
			"RW" => "\ud83c\uddf7\ud83c\uddfc", 
			"SA" => "\ud83c\uddf8\ud83c\udde6", 
			"SB" => "\ud83c\uddf8\ud83c\udde7", 
			"SC" => "\ud83c\uddf8\ud83c\udde8", 
			"SD" => "\ud83c\uddf8\ud83c\udde9", 
			"SE" => "\ud83c\uddf8\ud83c\uddea", 
			"SG" => "\ud83c\uddf8\ud83c\uddec", 
			"SH" => "\ud83c\uddf8\ud83c\udded", 
			"SI" => "\ud83c\uddf8\ud83c\uddee", 
			"SJ" => "\ud83c\uddf8\ud83c\uddef", 
			"SK" => "\ud83c\uddf8\ud83c\uddf0", 
			"SL" => "\ud83c\uddf8\ud83c\uddf1", 
			"SM" => "\ud83c\uddf8\ud83c\uddf2", 
			"SN" => "\ud83c\uddf8\ud83c\uddf3", 
			"SO" => "\ud83c\uddf8\ud83c\uddf4", 
			"SR" => "\ud83c\uddf8\ud83c\uddf7", 
			"SS" => "\ud83c\uddf8\ud83c\uddf8", 
			"ST" => "\ud83c\uddf8\ud83c\uddf9", 
			"SV" => "\ud83c\uddf8\ud83c\uddfb", 
			"SX" => "\ud83c\uddf8\ud83c\uddfd", 
			"SY" => "\ud83c\uddf8\ud83c\uddfe", 
			"SZ" => "\ud83c\uddf8\ud83c\uddff", 
			"TC" => "\ud83c\uddf9\ud83c\udde8", 
			"TD" => "\ud83c\uddf9\ud83c\udde9", 
			"TF" => "\ud83c\uddf9\ud83c\uddeb", 
			"TG" => "\ud83c\uddf9\ud83c\uddec", 
			"TH" => "\ud83c\uddf9\ud83c\udded", 
			"TJ" => "\ud83c\uddf9\ud83c\uddef", 
			"TK" => "\ud83c\uddf9\ud83c\uddf0", 
			"TL" => "\ud83c\uddf9\ud83c\uddf1", 
			"TM" => "\ud83c\uddf9\ud83c\uddf2", 
			"TN" => "\ud83c\uddf9\ud83c\uddf3", 
			"TO" => "\ud83c\uddf9\ud83c\uddf4", 
			"TR" => "\ud83c\uddf9\ud83c\uddf7", 
			"TT" => "\ud83c\uddf9\ud83c\uddf9", 
			"TV" => "\ud83c\uddf9\ud83c\uddfb", 
			"TW" => "\ud83c\uddf9\ud83c\uddfc", 
			"TZ" => "\ud83c\uddf9\ud83c\uddff", 
			"UA" => "\ud83c\uddfa\ud83c\udde6", 
			"UG" => "\ud83c\uddfa\ud83c\uddec", 
			"UM" => "\ud83c\uddfa\ud83c\uddf2", 
			"US" => "\ud83c\uddfa\ud83c\uddf8", 
			"UY" => "\ud83c\uddfa\ud83c\uddfe", 
			"UZ" => "\ud83c\uddfa\ud83c\uddff", 
			"VA" => "\ud83c\uddfb\ud83c\udde6", 
			"VC" => "\ud83c\uddfb\ud83c\udde8", 
			"VE" => "\ud83c\uddfb\ud83c\uddea", 
			"VG" => "\ud83c\uddfb\ud83c\uddec", 
			"VI" => "\ud83c\uddfb\ud83c\uddee", 
			"VN" => "\ud83c\uddfb\ud83c\uddf3", 
			"VU" => "\ud83c\uddfb\ud83c\uddfa", 
			"WF" => "\ud83c\uddfc\ud83c\uddeb", 
			"WS" => "\ud83c\uddfc\ud83c\uddf8", 
			"XK" => "\ud83c\uddfd\ud83c\uddf0", 
			"YE" => "\ud83c\uddfe\ud83c\uddea", 
			"YT" => "\ud83c\uddfe\ud83c\uddf9", 
			"ZA" => "\ud83c\uddff\ud83c\udde6", 
			"ZM" => "\ud83c\uddff\ud83c\uddf2", 
			_ => "\ud83c\udff3", 
		};
	}
}