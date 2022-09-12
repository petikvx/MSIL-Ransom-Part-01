namespace System;

internal static class Extensions
{
	internal static void Validate<T>(this T[] buffer, int offset, int length)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", "cannot be null");
		}
		if (offset < 0 || length < 0 || offset + length > buffer.Length)
		{
			throw new ArgumentException($"invalid offset/length combination: {offset}/{length}");
		}
	}
}
