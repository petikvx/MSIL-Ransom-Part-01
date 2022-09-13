namespace Ionic.Zlib;

internal sealed class StaticTree
{
	internal static readonly short[] lengthAndLiteralsTreeCodes;

	internal static readonly short[] distTreeCodes;

	internal static readonly StaticTree Literals;

	internal static readonly StaticTree Distances;

	internal static readonly StaticTree BitLengths;

	internal short[] treeCodes;

	internal int[] extraBits;

	internal int extraBase;

	internal int elems;

	internal int maxLength;

	private extern StaticTree(short[] treeCodes, int[] extraBits, int extraBase, int elems, int maxLength);

	static extern StaticTree();
}
