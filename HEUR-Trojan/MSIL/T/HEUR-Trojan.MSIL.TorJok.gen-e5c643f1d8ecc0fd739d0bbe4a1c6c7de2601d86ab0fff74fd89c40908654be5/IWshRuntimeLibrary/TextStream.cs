using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[CoClass(typeof(TextStreamClass))]
[Guid("53BAD8C1-E718-11CF-893D-00A0C9054228")]
public interface TextStream : ITextStream
{
}
