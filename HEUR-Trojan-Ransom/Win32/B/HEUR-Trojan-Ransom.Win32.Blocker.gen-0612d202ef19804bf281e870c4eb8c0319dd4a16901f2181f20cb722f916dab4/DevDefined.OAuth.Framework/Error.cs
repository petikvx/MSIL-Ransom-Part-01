using System;
using System.IO;
using System.Net;
using DevDefined.OAuth.Provider;

namespace DevDefined.OAuth.Framework;

public static class Error
{
	public static Exception MissingRequiredOAuthParameter(IOAuthContext context, string parameterName)
	{
		OAuthException ex = new OAuthException(context, "parameter_absent", $"Missing required parameter : {parameterName}");
		ex.Report.ParametersAbsent.Add(parameterName);
		return ex;
	}

	public static Exception OAuthAuthenticationFailure(string errorMessage)
	{
		return new Exception($"OAuth authentication failed, message was: {errorMessage}");
	}

	public static Exception TokenCanNoLongerBeUsed(string token)
	{
		return new Exception($"Token \"{token}\" is no longer valid");
	}

	public static Exception FailedToParseResponse(string parameters)
	{
		return new Exception($"Failed to parse response string \"{parameters}\"");
	}

	public static Exception UnknownSignatureMethod(string signatureMethod)
	{
		return new Exception($"Unknown signature method \"{signatureMethod}\"");
	}

	public static Exception ForRsaSha1SignatureMethodYouMustSupplyAssymetricKeyParameter()
	{
		return new Exception("For the RSASSA-PKCS1-v1_5 signature method you must use the constructor which takes an additional AssymetricAlgorithm \"key\" parameter");
	}

	public static Exception RequestFailed(WebException innerException)
	{
		if (innerException.Response is HttpWebResponse httpWebResponse)
		{
			using StreamReader streamReader = new StreamReader(innerException.Response!.GetResponseStream());
			string text = streamReader.ReadToEnd();
			return new Exception($"Request for uri: {httpWebResponse.ResponseUri} failed.\r\nstatus code: {httpWebResponse.StatusCode}\r\nheaders: {httpWebResponse.Headers}\r\nbody:\r\n{text}", innerException);
		}
		return innerException;
	}

	public static Exception EmptyConsumerKey()
	{
		throw new Exception("Consumer key is null or empty");
	}

	public static Exception RequestMethodHasNotBeenAssigned(string parameter)
	{
		return new Exception($"The RequestMethod parameter \"{parameter}\" is null or empty.");
	}

	public static Exception FailedToValidateSignature(IOAuthContext context)
	{
		return new OAuthException(context, "signature_invalid", "Failed to validate signature");
	}

	public static Exception FailedToValidateBodyHash(IOAuthContext context)
	{
		return new OAuthException(context, "body_hash_invalid", "Failed to validate body hash");
	}

	public static Exception UnknownConsumerKey(IOAuthContext context)
	{
		return new OAuthException(context, "consumer_key_unknown", $"Unknown Consumer (Realm: {context.Realm}, Key: {context.ConsumerKey})");
	}

	public static Exception AlgorithmPropertyNotSetOnSigningContext()
	{
		return new Exception("Algorithm Property must be set on SingingContext when using an Assymetric encryption method such as RSA-SHA1");
	}

	public static Exception SuppliedTokenWasNotIssuedToThisConsumer(string expectedConsumerKey, string actualConsumerKey)
	{
		return new Exception($"Supplied token was not issued to this consumer, expected key: {expectedConsumerKey}, actual key: {actualConsumerKey}");
	}

	public static Exception AccessDeniedToProtectedResource(AccessOutcome outcome)
	{
		Uri arg = outcome.Context.GenerateUri();
		if (string.IsNullOrEmpty(outcome.AdditionalInfo))
		{
			return new AccessDeniedException(outcome, $"Access to resource \"{arg}\" was denied");
		}
		return new AccessDeniedException(outcome, $"Access to resource: {arg} was denied, additional info: {outcome.AdditionalInfo}");
	}

	public static Exception ConsumerHasNotBeenGrantedAccessYet(IOAuthContext context)
	{
		return new OAuthException(context, "permission_unknown", "The decision to give access to the consumer has yet to be made, please try again later.");
	}

	public static Exception ConsumerHasBeenDeniedAccess(IOAuthContext context)
	{
		return new OAuthException(context, "permission_denied", "The consumer was denied access to this resource.");
	}

	public static Exception CantBuildProblemReportWhenProblemEmpty()
	{
		return new Exception("Can't build problem report when \"Problem\" property is null or empty");
	}

	public static Exception NonceHasAlreadyBeenUsed(IOAuthContext context)
	{
		return new OAuthException(context, "nonce_used", $"The nonce value \"{context.Nonce}\" has already been used");
	}

	public static Exception ThisConsumerRequestHasAlreadyBeenSigned()
	{
		return new Exception("The consumer request for consumer \"{0}\" has already been signed");
	}

	public static Exception CallbackWasNotConfirmed()
	{
		return new Exception("Callback was not confirmed");
	}

	public static Exception RejectedRequiredOAuthParameter(IOAuthContext context, string parameter)
	{
		return new OAuthException(context, "parameter_rejected", $"The parameter \"{parameter}\" was rejected");
	}

	public static Exception UnknownToken(IOAuthContext context, string token)
	{
		return new OAuthException(context, "token_rejected", $"Unknown or previously rejected token \"{token}\"");
	}

	public static Exception UnknownToken(IOAuthContext context, string token, Exception exception)
	{
		return new OAuthException(context, "token_rejected", $"Unknown or previously rejected token \"{token}\"", exception);
	}

	public static Exception RequestForTokenMustNotIncludeTokenInContext(IOAuthContext context)
	{
		throw new OAuthException(context, "parameter_rejected", "When obtaining a request token, you must not supply the oauth_token parameter");
	}

	public static Exception ExperiencingIssueWithCreatingUriDueToMissingAppConfig(ArgumentNullException argumentException)
	{
		return new Exception("It appears this may be the first Uri constructed by this AppDomain, and you have no App.config or Web.config file - which has triggered an unusual edge case: see this blog post from more details - http://ayende.com/Blog/archive/2010/03/04/is-select-system.uri-broken.aspx", argumentException);
	}

	public static Exception EncounteredUnexpectedBodyHashInFormEncodedRequest(IOAuthContext context)
	{
		throw new OAuthException(context, "parameter_rejected", "Encountered unexpected oauth_body_hash value in form-encoded request");
	}

	public static Exception EmptyXAuthMode(IOAuthContext context)
	{
		throw new OAuthException(context, "parameter_absent", "The x_auth_mode parameter must be present");
	}

	public static Exception InvalidXAuthMode(IOAuthContext context)
	{
		throw new OAuthException(context, "parameter_rejected", "The x_auth_mode parameter is invalid");
	}

	public static Exception EmptyXAuthUsername(IOAuthContext context)
	{
		throw new OAuthException(context, "parameter_absent", "The x_auth_username parameter must be present");
	}

	public static Exception EmptyXAuthPassword(IOAuthContext context)
	{
		throw new OAuthException(context, "parameter_absent", "The x_auth_password parameter must be present");
	}

	public static Exception FailedXAuthAuthentication(IOAuthContext context)
	{
		throw new OAuthException(context, "parameter_rejected", "Authentication failed with the specified username and password");
	}
}
