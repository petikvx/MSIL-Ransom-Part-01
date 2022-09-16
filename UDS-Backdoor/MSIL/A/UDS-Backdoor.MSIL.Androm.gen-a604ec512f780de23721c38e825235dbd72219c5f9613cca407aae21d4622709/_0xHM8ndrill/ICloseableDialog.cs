namespace _0xHM8ndrill;

internal interface ICloseableDialog
{
	bool? DialogResult { get; }

	bool? ShowModal();

	void CloseDialog(bool dialogResult);
}
