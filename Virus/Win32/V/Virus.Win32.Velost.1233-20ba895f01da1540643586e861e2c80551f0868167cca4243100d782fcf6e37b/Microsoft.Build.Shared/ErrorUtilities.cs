using System;

namespace Microsoft.Build.Shared;

internal static class ErrorUtilities
{
	private static void ThrowInternalError(bool showAssert, string unformattedMessage, params object[] args)
	{
		throw new InternalErrorException(ResourceUtilities.FormatString(unformattedMessage, args), showAssert);
	}

	internal static void VerifyThrowNoAssert(bool condition, string unformattedMessage)
	{
		if (!condition)
		{
			ThrowInternalError(showAssert: false, unformattedMessage, null);
		}
	}

	internal static void VerifyThrow(bool condition, string unformattedMessage)
	{
		if (!condition)
		{
			ThrowInternalError(showAssert: true, unformattedMessage, null);
		}
	}

	internal static void VerifyThrow(bool condition, string unformattedMessage, object arg0)
	{
		if (!condition)
		{
			ThrowInternalError(true, unformattedMessage, arg0);
		}
	}

	internal static void VerifyThrow(bool condition, string unformattedMessage, object arg0, object arg1)
	{
		if (!condition)
		{
			ThrowInternalError(true, unformattedMessage, arg0, arg1);
		}
	}

	internal static void VerifyThrow(bool condition, string unformattedMessage, object arg0, object arg1, object arg2)
	{
		if (!condition)
		{
			ThrowInternalError(true, unformattedMessage, arg0, arg1, arg2);
		}
	}

	internal static void VerifyThrow(bool condition, string unformattedMessage, object arg0, object arg1, object arg2, object arg3)
	{
		if (!condition)
		{
			ThrowInternalError(true, unformattedMessage, arg0, arg1, arg2, arg3);
		}
	}

	private static void ThrowInvalidOperation(string resourceName, params object[] args)
	{
		throw new InvalidOperationException(ResourceUtilities.FormatResourceString(resourceName, args));
	}

	internal static void VerifyThrowInvalidOperation(bool condition, string resourceName)
	{
		if (!condition)
		{
			ThrowInvalidOperation(resourceName, null);
		}
	}

	internal static void VerifyThrowInvalidOperation(bool condition, string resourceName, object arg0)
	{
		if (!condition)
		{
			ThrowInvalidOperation(resourceName, arg0);
		}
	}

	internal static void VerifyThrowInvalidOperation(bool condition, string resourceName, object arg0, object arg1)
	{
		if (!condition)
		{
			ThrowInvalidOperation(resourceName, arg0, arg1);
		}
	}

	internal static void VerifyThrowInvalidOperation(bool condition, string resourceName, object arg0, object arg1, object arg2)
	{
		if (!condition)
		{
			ThrowInvalidOperation(resourceName, arg0, arg1, arg2);
		}
	}

	private static void ThrowArgument(Exception innerException, string resourceName, params object[] args)
	{
		throw new ArgumentException(ResourceUtilities.FormatResourceString(resourceName, args), innerException);
	}

	internal static void VerifyThrowArgument(bool condition, string resourceName)
	{
		VerifyThrowArgument(condition, null, resourceName);
	}

	internal static void VerifyThrowArgument(bool condition, string resourceName, object arg0)
	{
		VerifyThrowArgument(condition, null, resourceName, arg0);
	}

	internal static void VerifyThrowArgument(bool condition, string resourceName, object arg0, object arg1)
	{
		VerifyThrowArgument(condition, null, resourceName, arg0, arg1);
	}

	internal static void VerifyThrowArgument(bool condition, Exception innerException, string resourceName)
	{
		if (!condition)
		{
			ThrowArgument(innerException, resourceName, null);
		}
	}

	internal static void VerifyThrowArgument(bool condition, Exception innerException, string resourceName, object arg0)
	{
		if (!condition)
		{
			ThrowArgument(innerException, resourceName, arg0);
		}
	}

	internal static void VerifyThrowArgument(bool condition, Exception innerException, string resourceName, object arg0, object arg1)
	{
		if (!condition)
		{
			ThrowArgument(innerException, resourceName, arg0, arg1);
		}
	}

	internal static void VerifyThrowArgumentOutOfRange(bool condition, string parameterName)
	{
		if (!condition)
		{
			throw new ArgumentOutOfRangeException(parameterName);
		}
	}

	internal static void VerifyThrowArgumentLength(string parameter, string parameterName)
	{
		VerifyThrowArgumentNull(parameter, parameterName);
		if (parameter.Length == 0)
		{
			throw new ArgumentException(ResourceUtilities.FormatResourceString("Shared.ParameterCannotHaveZeroLength", parameterName));
		}
	}

	internal static void VerifyThrowArgumentNull(object parameter, string parameterName)
	{
		if (parameter == null)
		{
			throw new ArgumentNullException(ResourceUtilities.FormatResourceString("Shared.ParameterCannotBeNull", parameterName), (Exception?)null);
		}
	}
}
