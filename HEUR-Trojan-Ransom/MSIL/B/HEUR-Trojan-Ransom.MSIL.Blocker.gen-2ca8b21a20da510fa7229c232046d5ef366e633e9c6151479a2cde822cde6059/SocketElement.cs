using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
public sealed class SocketElement
{
	public static NetTcpStyleUriParser CodeCompileUnit = new NetTcpStyleUriParser();

	public static RegexTree HTTP_REQUEST_INFO_TYPE = new RegexTree();

	public static BaseOverlappedAsyncResult HttpListener = new BaseOverlappedAsyncResult();

	public static DataCommand SmtpClient = new DataCommand();
}
