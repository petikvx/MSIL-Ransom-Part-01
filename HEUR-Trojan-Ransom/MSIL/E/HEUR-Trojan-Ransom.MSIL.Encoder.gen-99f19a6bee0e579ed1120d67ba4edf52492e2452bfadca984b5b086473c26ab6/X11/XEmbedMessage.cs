namespace X11;

internal enum XEmbedMessage
{
	EmbeddedNotify = 0,
	WindowActivate = 1,
	WindowDeactivate = 2,
	RequestFocus = 3,
	FocusIn = 4,
	FocusOut = 5,
	FocusNext = 6,
	FocusPrev = 7,
	ModalityOn = 10,
	ModalityOff = 11,
	RegisterAccelerator = 12,
	UnregisterAccelerator = 13,
	ActivateAccelerator = 14
}
