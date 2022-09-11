using DevDefined.OAuth.Framework;

namespace DevDefined.OAuth.Storage.Basic;

public interface ITokenRepository<T> where T : TokenBase
{
	T GetToken(string token);

	void SaveToken(T token);
}
