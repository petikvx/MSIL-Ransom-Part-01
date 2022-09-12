namespace ICSharpCode.SharpZipLib.Core;

public interface INameTransform
{
	string TransformDirectory(string name);

	string TransformFile(string name);
}
