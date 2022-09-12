using System.Security.Cryptography;

namespace ExciteRAN;

internal delegate Rfc2898DeriveBytes MethodDictionary(byte[], byte[], int);
