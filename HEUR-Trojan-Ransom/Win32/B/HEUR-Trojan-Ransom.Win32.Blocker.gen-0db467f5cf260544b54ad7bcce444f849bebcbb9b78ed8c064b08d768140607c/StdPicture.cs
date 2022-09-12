using System.Runtime.InteropServices;
using stdole;

[ComImport]
[CoClass(typeof(StdPictureClass))]
[Guid("7BF80981-BF32-101A-8BBB-00AA00300CAB")]
public interface StdPicture : Picture
{
}
