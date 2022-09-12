namespace Gecko;

public enum AccessibleTextBoundary
{
	TextOffsetEndOfText = -1,
	TextOffsetCaret = -2,
	BoundaryChar = 0,
	BoundaryWordStart = 1,
	BoundaryWordEnd = 2,
	BoundarySentenceStart = 3,
	BoundarySentenceEnd = 4,
	BoundaryLineStart = 5,
	BoundaryLineEnd = 6
}
