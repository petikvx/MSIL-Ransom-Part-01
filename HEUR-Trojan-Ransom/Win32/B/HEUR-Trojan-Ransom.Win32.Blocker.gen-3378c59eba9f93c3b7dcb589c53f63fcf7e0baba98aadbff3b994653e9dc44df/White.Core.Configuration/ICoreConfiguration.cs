using System.IO;
using White.Core.Bricks;
using White.Core.UIItems;

namespace White.Core.Configuration;

public interface ICoreConfiguration
{
	int BusyTimeout { get; set; }

	bool WaitBasedOnHourGlass { get; set; }

	DynamicProxyInterceptors Interceptors { get; }

	DirectoryInfo WorkSessionLocation { get; set; }

	int UIAutomationZeroWindowBugTimeout { get; set; }

	int PopupTimeout { get; set; }

	int TooltipWaitTime { get; set; }

	int SuggestionListTimeout { get; set; }

	DateFormat DefaultDateFormat { get; set; }

	int DragStepCount { get; }

	bool InProc { get; set; }

	bool ComboBoxItemsPopulatedWithoutDropDownOpen { get; set; }

	IWaitHook AdditionalWaitHook { get; set; }

	int MaxElementSearchDepth { get; set; }

	bool RawElementBasedSearch { get; set; }

	int DoubleClickInterval { get; set; }

	bool MoveMouseToGetStatusOfHourGlass { get; set; }
}
