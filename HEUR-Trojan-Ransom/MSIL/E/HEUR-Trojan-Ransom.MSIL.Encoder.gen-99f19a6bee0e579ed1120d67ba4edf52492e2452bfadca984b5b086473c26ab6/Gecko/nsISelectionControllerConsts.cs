namespace Gecko;

public class nsISelectionControllerConsts
{
	public const short SELECTION_NONE = 0;

	public const short SELECTION_NORMAL = 1;

	public const short SELECTION_SPELLCHECK = 2;

	public const short SELECTION_IME_RAWINPUT = 4;

	public const short SELECTION_IME_SELECTEDRAWTEXT = 8;

	public const short SELECTION_IME_CONVERTEDTEXT = 16;

	public const short SELECTION_IME_SELECTEDCONVERTEDTEXT = 32;

	public const short SELECTION_ACCESSIBILITY = 64;

	public const short SELECTION_FIND = 128;

	public const short SELECTION_URLSECONDARY = 256;

	public const short SELECTION_URLSTRIKEOUT = 512;

	public const short NUM_SELECTIONTYPES = 11;

	public const short SELECTION_ANCHOR_REGION = 0;

	public const short SELECTION_FOCUS_REGION = 1;

	public const short SELECTION_WHOLE_SELECTION = 2;

	public const short NUM_SELECTION_REGIONS = 3;

	public const short SELECTION_OFF = 0;

	public const short SELECTION_HIDDEN = 1;

	public const short SELECTION_ON = 2;

	public const short SELECTION_DISABLED = 3;

	public const short SELECTION_ATTENTION = 4;

	public const short SCROLL_SYNCHRONOUS = 2;

	public const short SCROLL_FIRST_ANCESTOR_ONLY = 4;

	public const short SCROLL_CENTER_VERTICALLY = 16;

	public const short SCROLL_OVERFLOW_HIDDEN = 32;

	public const short MOVE_LEFT = 0;

	public const short MOVE_RIGHT = 1;

	public const short MOVE_UP = 2;

	public const short MOVE_DOWN = 3;
}
