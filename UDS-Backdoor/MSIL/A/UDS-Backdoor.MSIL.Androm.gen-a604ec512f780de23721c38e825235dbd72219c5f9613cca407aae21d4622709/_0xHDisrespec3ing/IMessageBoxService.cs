using Microsoft.Cct.Services;

namespace _0xHDisrespec3ing;

internal interface IMessageBoxService
{
	void ShowErrorMessageBox(string message);

	void ShowErrorMessageBox(WatError error, params object[] args);
}
