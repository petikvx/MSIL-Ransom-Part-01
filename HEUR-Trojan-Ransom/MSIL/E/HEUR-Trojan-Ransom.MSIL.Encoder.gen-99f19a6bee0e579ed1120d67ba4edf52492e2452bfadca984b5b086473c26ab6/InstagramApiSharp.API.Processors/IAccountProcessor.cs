using System;
using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Enums;

namespace InstagramApiSharp.API.Processors;

public interface IAccountProcessor
{
	Task<IResult<bool>> ChangePasswordAsync(string oldPassword, string newPassword);

	Task<IResult<InstaUserEdit>> ChangeProfilePictureAsync(byte[] pictureBytes);

	Task<IResult<InstaUserEdit>> ChangeProfilePictureAsync(Action<InstaUploaderProgress> progress, byte[] pictureBytes);

	Task<IResult<InstaUserEdit>> EditProfileAsync(string name, string biography, string url, string email, string phone, InstaGenderType? gender, string newUsername = null);

	Task<IResult<InstaRequestDownloadData>> GetRequestForDownloadAccountDataAsync(string email);

	Task<IResult<InstaRequestDownloadData>> GetRequestForDownloadAccountDataAsync(string email, string password);

	Task<IResult<InstaUserEdit>> GetRequestForEditProfileAsync();

	Task<IResult<InstaUserEdit>> RemoveProfilePictureAsync();

	Task<IResult<InstaUserShort>> SetAccountPrivateAsync();

	Task<IResult<InstaUserShort>> SetAccountPublicAsync();

	Task<IResult<InstaBiography>> SetBiographyAsync(string bio);

	Task<IResult<bool>> SetNameAndPhoneNumberAsync(string name, string phoneNumber = "");

	Task<IResult<InstaMedia>> UploadNametagAsync(InstaImage nametagImage);

	Task<IResult<bool>> AllowStoryMessageRepliesAsync(InstaMessageRepliesType repliesType);

	Task<IResult<bool>> AllowStorySharingAsync(bool allow = true);

	Task<IResult<InstaAccountCheck>> CheckUsernameAsync(string desiredUsername);

	Task<IResult<bool>> DisableSaveStoryToArchiveAsync();

	Task<IResult<bool>> DisableSaveStoryToGalleryAsync();

	Task<IResult<bool>> EnableSaveStoryToArchiveAsync();

	Task<IResult<bool>> EnableSaveStoryToGalleryAsync();

	Task<IResult<InstaStorySettings>> GetStorySettingsAsync();

	Task<IResult<bool>> DisableTwoFactorAuthenticationAsync();

	Task<IResult<InstaAccountSecuritySettings>> GetSecuritySettingsInfoAsync();

	Task<IResult<TwoFactorRegenBackupCodes>> RegenerateTwoFactorBackupCodesAsync();

	Task<IResult<InstaAccountConfirmEmail>> SendConfirmEmailAsync();

	Task<IResult<InstaAccountSendSms>> SendSmsCodeAsync(string phoneNumber);

	Task<IResult<bool>> VerifyEmailByVerificationUriAsync(Uri verificationUri);

	Task<IResult<InstaAccountTwoFactorSms>> SendTwoFactorEnableSmsAsync(string phoneNumber);

	Task<IResult<InstaAccountTwoFactor>> TwoFactorEnableAsync(string phoneNumber, string verificationCode);

	Task<IResult<InstaAccountVerifySms>> VerifySmsCodeAsync(string phoneNumber, string verificationCode);

	Task<IResult<bool>> EnablePresenceAsync();

	Task<IResult<bool>> DisablePresenceAsync();

	Task<IResult<InstaPresence>> GetPresenceOptionsAsync();

	Task<IResult<InstaUser>> SwitchToPersonalAccountAsync();

	Task<IResult<InstaBusinessUser>> SwitchToBusinessAccountAsync();
}
