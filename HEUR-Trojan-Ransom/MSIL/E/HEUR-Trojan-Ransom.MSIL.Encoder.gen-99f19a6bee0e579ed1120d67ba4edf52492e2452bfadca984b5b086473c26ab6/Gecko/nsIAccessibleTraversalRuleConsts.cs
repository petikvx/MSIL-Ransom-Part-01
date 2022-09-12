namespace Gecko;

public class nsIAccessibleTraversalRuleConsts
{
	public const ushort FILTER_IGNORE = 0;

	public const ushort FILTER_MATCH = 1;

	public const ushort FILTER_IGNORE_SUBTREE = 2;

	public const ulong PREFILTER_INVISIBLE = 1uL;

	public const ulong PREFILTER_OFFSCREEN = 2uL;

	public const ulong PREFILTER_NOT_FOCUSABLE = 4uL;

	public const ulong PREFILTER_ARIA_HIDDEN = 8uL;

	public const ulong PREFILTER_TRANSPARENT = 16uL;
}
