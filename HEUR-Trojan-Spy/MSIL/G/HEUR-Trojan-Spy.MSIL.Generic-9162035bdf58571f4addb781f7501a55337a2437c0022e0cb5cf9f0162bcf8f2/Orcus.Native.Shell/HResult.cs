namespace Orcus.Native.Shell;

internal enum HResult
{
	Ok = 0,
	False = 1,
	InvalidArguments = -2147024809,
	OutOfMemory = -2147024882,
	NoInterface = -2147467262,
	Fail = -2147467259,
	ElementNotFound = -2147023728,
	TypeElementNotFound = -2147319765,
	NoObject = -2147221019,
	Win32ErrorCanceled = 1223,
	Canceled = -2147023673,
	ResourceInUse = -2147024726,
	AccessDenied = -2147287035
}
