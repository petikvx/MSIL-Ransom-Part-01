using White.Core.UIItems;

namespace White.Core.Configuration;

public interface IWaitHook
{
	void WaitFor(UIItemContainer uiItemContainer);
}
