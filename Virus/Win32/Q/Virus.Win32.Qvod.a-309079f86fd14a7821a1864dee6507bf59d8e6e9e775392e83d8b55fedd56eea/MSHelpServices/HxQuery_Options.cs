using System.Runtime.InteropServices;

namespace MSHelpServices;

[Guid("314111E0-A502-11D2-BBCA-00C04F8EC294")]
public enum HxQuery_Options
{
	HxQuery_FullTextSearch_Enable_Stemming = 2,
	HxQuery_FullTextSearch_ReturnRanking = 256,
	HxQuery_FullTextSearch_SearchPrevious = 4,
	HxQuery_FullTextSearch_Title_Only = 1,
	HxQuery_FullTextSearch_Wildcard_Preserve = 128,
	HxQuery_KeywordSearch_CaseSensitive = 10,
	HxQuery_No_Option = 0
}
