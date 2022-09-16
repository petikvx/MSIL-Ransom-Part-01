using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace _0xHPre7ocalic;

[SuppressMessage("Microsoft.StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Not documenting the obvious")]
internal interface ICertificateStore
{
	X509Certificate2Collection Certificates { get; }

	X509Certificate2 CreateAndInstallLegacyCertificate(string distinguishedNameString, string friendlyName);

	void Add(X509Certificate2 certificate);

	void Close();

	void Open(OpenFlags flags);
}
