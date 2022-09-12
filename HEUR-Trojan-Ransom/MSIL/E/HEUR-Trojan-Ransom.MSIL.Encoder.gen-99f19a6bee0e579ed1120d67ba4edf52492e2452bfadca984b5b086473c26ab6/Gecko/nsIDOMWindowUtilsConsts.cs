namespace Gecko;

public class nsIDOMWindowUtilsConsts
{
	public const long MODIFIER_ALT = 1L;

	public const long MODIFIER_CONTROL = 2L;

	public const long MODIFIER_SHIFT = 4L;

	public const long MODIFIER_META = 8L;

	public const long MODIFIER_ALTGRAPH = 16L;

	public const long MODIFIER_CAPSLOCK = 32L;

	public const long MODIFIER_FN = 64L;

	public const long MODIFIER_FNLOCK = 128L;

	public const long MODIFIER_NUMLOCK = 256L;

	public const long MODIFIER_SCROLLLOCK = 512L;

	public const long MODIFIER_SYMBOL = 1024L;

	public const long MODIFIER_SYMBOLLOCK = 2048L;

	public const long MODIFIER_OS = 4096L;

	public const ulong WHEEL_EVENT_CAUSED_BY_NO_LINE_OR_PAGE_DELTA_DEVICE = 1uL;

	public const ulong WHEEL_EVENT_CAUSED_BY_PIXEL_ONLY_DEVICE = 1uL;

	public const ulong WHEEL_EVENT_CAUSED_BY_MOMENTUM = 2uL;

	public const ulong WHEEL_EVENT_CUSTOMIZED_BY_USER_PREFS = 4uL;

	public const ulong WHEEL_EVENT_EXPECTED_OVERFLOW_DELTA_X_ZERO = 16uL;

	public const ulong WHEEL_EVENT_EXPECTED_OVERFLOW_DELTA_X_POSITIVE = 32uL;

	public const ulong WHEEL_EVENT_EXPECTED_OVERFLOW_DELTA_X_NEGATIVE = 64uL;

	public const ulong WHEEL_EVENT_EXPECTED_OVERFLOW_DELTA_Y_ZERO = 256uL;

	public const ulong WHEEL_EVENT_EXPECTED_OVERFLOW_DELTA_Y_POSITIVE = 512uL;

	public const ulong WHEEL_EVENT_EXPECTED_OVERFLOW_DELTA_Y_NEGATIVE = 1024uL;

	public const ulong KEY_FLAG_PREVENT_DEFAULT = 1uL;

	public const ulong KEY_FLAG_NOT_SYNTHESIZED_FOR_TESTS = 2uL;

	public const ulong KEY_FLAG_LOCATION_STANDARD = 16uL;

	public const ulong KEY_FLAG_LOCATION_LEFT = 32uL;

	public const ulong KEY_FLAG_LOCATION_RIGHT = 64uL;

	public const ulong KEY_FLAG_LOCATION_NUMPAD = 128uL;

	public const ulong MOUSESCROLL_PREFER_WIDGET_AT_POINT = 1uL;

	public const ulong MOUSESCROLL_SCROLL_LINES = 2uL;

	public const ulong MOUSESCROLL_WIN_SCROLL_LPARAM_NOT_NULL = 65536uL;

	public const long TOUCH_HOVER = 1L;

	public const long TOUCH_CONTACT = 2L;

	public const long TOUCH_REMOVE = 4L;

	public const long TOUCH_CANCEL = 8L;

	public const ulong IME_STATUS_DISABLED = 0uL;

	public const ulong IME_STATUS_ENABLED = 1uL;

	public const ulong IME_STATUS_PASSWORD = 2uL;

	public const ulong IME_STATUS_PLUGIN = 3uL;

	public const ulong QUERY_CONTENT_FLAG_USE_NATIVE_LINE_BREAK = 0uL;

	public const ulong QUERY_CONTENT_FLAG_USE_XP_LINE_BREAK = 1uL;

	public const ulong QUERY_SELECTED_TEXT = 3200uL;

	public const ulong QUERY_TEXT_CONTENT = 3201uL;

	public const ulong QUERY_CARET_RECT = 3203uL;

	public const ulong QUERY_TEXT_RECT = 3204uL;

	public const ulong QUERY_EDITOR_RECT = 3205uL;

	public const ulong QUERY_CHARACTER_AT_POINT = 3208uL;

	public const ulong SELECTION_SET_FLAG_USE_NATIVE_LINE_BREAK = 0uL;

	public const ulong SELECTION_SET_FLAG_USE_XP_LINE_BREAK = 1uL;

	public const ulong SELECTION_SET_FLAG_REVERSE = 2uL;

	public const ulong SELECT_CHARACTER = 0uL;

	public const ulong SELECT_CLUSTER = 1uL;

	public const ulong SELECT_WORD = 2uL;

	public const ulong SELECT_LINE = 3uL;

	public const ulong SELECT_BEGINLINE = 4uL;

	public const ulong SELECT_ENDLINE = 5uL;

	public const ulong SELECT_PARAGRAPH = 6uL;

	public const ulong SELECT_WORDNOSPACE = 7uL;

	public const ulong AGENT_SHEET = 0uL;

	public const ulong USER_SHEET = 1uL;

	public const ulong AUTHOR_SHEET = 2uL;
}
