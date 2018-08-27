//using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace ClearentIdtechIOSBindings
{
	
	[StructLayout (LayoutKind.Sequential)]
public struct ICCReaderStatus
{
    public int iccPower;

    public int cardSeated;

    public int latchClosed;

    public int cardPresent;

    public int magneticDataPresent;
}

[StructLayout (LayoutKind.Sequential)]
public struct PowerOnStructure
{
    public int sendIFS;

    public int explicitPPS;

    public int disableAutoPPS;

    public int disableResponseCheck;

    public unsafe byte* pps;

    public byte ppsLength;
}

[StructLayout (LayoutKind.Sequential)]
public struct CAKey
{
    public byte hashAlgorithm;

    public byte encryptionAlgorithm;

    public byte[] rid;

    public byte index;

    public byte exponentLength;

    public byte keyLength;

    public byte[] exponent;

    public byte[] key;
}

[StructLayout (LayoutKind.Sequential)]
public struct AIDEntry
{
    public byte[] aid;

    public byte aidLen;
}

[StructLayout (LayoutKind.Sequential)]
public struct MaskAndEncryption
{
    public byte prePANClear;

    public byte postPANClear;

    public byte maskChar;

    public byte displayExpDate;

    public byte baseKeyType;

    public byte encryptionType;

    public byte encryptionOption;

    public byte maskOption;
}

[StructLayout (LayoutKind.Sequential)]
public struct ApplicationID
{
    public byte[] acquirerIdentifier;

    public byte[] aid;

    public byte aidLen;

    public byte applicationSelectionIndicator;

    public byte[] applicationVersionNumber;

    public byte[] XAmount;

    public byte[] YAmount;

    public byte skipTACIACDefault;

    public byte tac;

    public byte floorlLimitChecking;

    public byte randomTransactionSelection;

    public byte velocitiyChecking;

    public byte[] tACDenial;

    public byte[] tACOnline;

    public byte[] tACDefault;

    public byte[] terminalFloorLimit;

    public byte targetPercentage;

    public byte[] thresholdValue;

    public byte maxTargetPercentage;

    public byte defaultTDOL;

    public byte[] tdolValue;

    public byte tdolLen;

    public byte defaultDDOL;

    public byte[] ddolValue;

    public byte ddolLen;

    public byte[] transactionCurrencyCode;

    public byte transactionCurrencyExponent;
}

[StructLayout (LayoutKind.Sequential)]
public struct TerminalData
{
    public byte[] terminalCountryCode;

    public byte provideCardholderConfirmation;

    public byte terminalType;

    public byte emvContact;

    public byte[] terminalCapabilities;

    public byte[] additionalTerminalCapabilities;

    public byte emvContactless;

    public byte magstripe;

    public byte pinTimeOut;

    public byte batchManaged;

    public byte adviceManaged;

    public byte pse;

    public byte autoRun;

    public byte[] predefinedAmount;

    public byte pinByPass;

    public byte referalManaged;

    public byte defaultTAC;

    public byte[] defaultTACDenial;

    public byte[] defaultTACOnline;

    public byte[] defaultTACDefault;

    public byte notRTS;

    public byte notVelocity;

    public byte cdaType;
}

[StructLayout (LayoutKind.Sequential)]
public struct CRLEntry
{
    public byte[] rid;

    public byte index;

    public byte[] serialNumber;
}

public enum CaptureEncodeType : uint
{
    Isoaba = 0,
    Aamva = 1,
    Other = 3,
    Raw = 4,
    JisIi = 5,
    JisI = 6,
    ManualEntry = 7
}

public enum CaptureEncryptType : uint
{
    Tdes = 0,
    Aes = 1,
    NoEncryption = 99
}

public enum PowerOnOption : uint
{
    IfsFlag = 1,
    ExplicitPpsFlag = 2,
    AutoPpsFlag = 64,
    IfsResponseCheckFlag = 128
}

public enum LanguageType : uint
{
    English = 1,
    Portuguese,
    Spanish,
    French
}

public enum PIN_KEY_Types : uint
{
    MKSK_extp = 0,
    DUKPT_extp = 1,
    MKSK_intl = 16,
    DUKPT_intl = 17,
    MKSK2_intl = 32,
    DUKPT2_intl = 33
}

public enum EVENT_PINPAD_Types : uint
{
    Unknown = 11,
    EncryptedPin,
    Numeric,
    Amount,
    Account,
    EncryptedData,
    Cancel,
    Timeout,
    FunctionKey,
    DataError,
    PanError,
    PinDukptMissing,
    PinDukptExhausted,
    DisplayMessageError
}

public enum IDT_DEVICE_Types : uint
{
    BtpayIos = 0,
    BtpayOsxBt,
    BtpayOsxUsb,
    UnipayIos,
    UnipayOsxUsb,
    UnipayiiIos,
    UnipayiiOsxUsb,
    ImagIos,
    Vp3300Ios,
    Vp3300OsxUsb,
    Unimag,
    BtmagIos,
    BtmagOsxBt,
    BtmagOsxUsb,
    UnipayiVIos,
    UnipayiVOsxUsb,
    Neo2Ios
}

public enum EVENT_MSR_Types : uint
{
    MsrUnknown = 31,
    MsrCardData,
    MsrCancelKey,
    MsrBackspaceKey,
    MsrEnterKey,
    MsrDataError,
    MsrIccStart,
    BtpayCardData,
    UnipayiiEmvNoIccMsrData,
    UnipayiiEmvFallbackData,
    UnipayKeyloading,
    MsrTimeout
}

public enum EVENT_CTLS_Types : uint
{
    EventActiveTransaction = 51
}

public enum UNIMAG_COMMAND_Types : uint
{
    DefaultGeneralSettings,
    EnableErrNotification,
    DisableErrNotification,
    EnableExpDate,
    DisableExpDate,
    ClearBuffer,
    ResetBaudRate
}

public enum ReturnCode : uint
{
    DoSuccess = 0,
    ErrDisconnect = 65281,
    ErrCmdResponse = 65282,
    ErrTimedout = 65283,
    ErrInvalidParameter = 65284,
    SdkBusyMsr = 65285,
    SdkBusyPinpad = 65286,
    SdkBusyCtls = 65287,
    ErrOther = 65288,
    Failed = 65289,
    NotAttached = 65290,
    MonoAudio = 65291,
    Connected = 65292,
    LowVolume = 65293,
    Canceled = 65294,
    InvalidStr = 65295,
    NoFile = 65296,
    InvalidFile = 65297,
    HostUnreachable = 65298,
    RkiFailure = 65299,
    SdkBusyCmd = 65300,
    EmvAuthorizationAccepted = 3584,
    EmvAuthorizationUnableToGoOnline = 3585,
    EmvAuthorizationTechnicalIssue = 3586,
    EmvAuthorizationDeclined = 3587,
    EmvAuthorizationIssuerReferral = 3588,
    EmvApproved = 3840,
    EmvDeclined = 3841,
    EmvGoOnline = 3842,
    EmvFailed = 3843,
    EmvSystemError = 3845,
    EmvNotAccepted = 3847,
    EmvFallback = 3850,
    EmvCancel = 3852,
    EmvTimeout = 3853,
    EmvOtherError = 3855,
    EmvOfflineApproved = 3856,
    EmvOfflineDeclined = 3857,
    EmvNewSelection = 3873,
    EmvNoAvailableApps = 3874,
    EmvNoTerminalFile = 3875,
    EmvNoCapkFile = 3876,
    EmvNoCrlEntry = 3877,
    BlockingDisabled = 4094,
    CommandUnavailable = 4095,
    NeoSuccess = 60928,
    NeoIncorrectHeaderTag = 60929,
    NeoUnknownCommand = 60930,
    NeoUnknownSubCommand = 60931,
    NeoCrcErrorInFrame = 60932,
    NeoIncorrectParameter = 60933,
    NeoParameterNotSupported = 60934,
    NeoMalFormattedData = 60935,
    NeoTimeout = 60936,
    NeoFailedNak = 60938,
    NeoCommandNotAllowed = 60939,
    NeoSubCommandNotAllowed = 60940,
    NeoBufferOverflow = 60941,
    NeoUserInterfaceEvent = 60942,
    NeoCommTypeNotSupported = 60945,
    NeoSecureInterfaceNotFunctional = 60946,
    NeoDataFieldNotMod8 = 60947,
    NeoPaddingUnexpected = 60948,
    NeoInvalidKeyType = 60949,
    NeoCannotRetrieveKey = 60950,
    NeoHashCodeError = 60951,
    NeoCannotStoreKey = 60952,
    NeoFrameTooLarge = 60953,
    NeoResendCommand = 60954,
    NeoEepromNotInitalized = 60955,
    NeoProblemEncodingApdu = 60956,
    NeoUnsupportedIndex = 60960,
    NeoUnexpectedSequenceCounter = 60961,
    NeoImproperBitmap = 60962,
    NeoRequestOnlineAuthorization = 60963,
    NeoRawDataReadSuccessful = 60964,
    NeoMessageNotAvailable = 60965,
    NeoVersionInformationMismatch = 60966,
    NeoNotSendingCommands = 60967,
    NeoTimeoutIlm = 60968,
    NeoIlmNotAvailable = 60969,
    NeoOtherLangNotSupported = 60970,
    NeoKeyError41 = 60993,
    NeoKeyError42 = 60994,
    NeoKeyError43 = 60995,
    NeoKeyError44 = 60996,
    NeoKeyError45 = 60997,
    NeoKeyError46 = 60998,
    NeoKeyError47 = 60999,
    NeoKeyError48 = 61000,
    NeoKeyError49 = 61001,
    NeoKeyError4a = 61002,
    NeoKeyError4b = 61003,
    NeoKeyError4c = 61004,
    NeoKeyError4d = 61005,
    NeoKeyError4e = 61006,
    NeoKeyError4f = 61007,
    NeoAutoSwitchOk = 61008,
    NeoAutoSwitchFailed = 61009,
    DataDoesNotExist = 61024,
    DataFull = 61025,
    WriteFlashError = 61026,
    OkNextCommand = 61027,
    CannotStartContactEmv = 61056,
    CtlsMsrCancelledByCardInsert = 61057,
    AcctDukptKeyNotExist = 61072,
    AcctDukptKeyExhausted = 61073,
    NoSerialNumber = 25088,
    InvalidCommand = 26880,
    NoAdminDukptKey = 21760,
    DukptKeyStop = 21761,
    DukptKeyKsnIsError = 21762,
    GetAuthCode1Failed = 21763,
    ValidateAuthCodeError = 21764,
    DecryptDataFailed = 21765,
    NotSupportNewKeyType = 21766,
    NewKeyIndexIsError = 21767,
    StepError = 21768,
    TimedOut = 21769,
    MacCheckingError = 21770,
    KeyUsageError = 21771,
    ModeOfUseError = 21772,
    AlgorithmError = 21773,
    OtherError = 21775,
    CannotAuthorizeRki = 32769,
    NoKeyInjectionEstablished = 33025,
    FailedToEncryptChallenge = 33026,
    ChallengeLengthIncorrect = 33027,
    IncorrectChallengeDataStep1 = 33028,
    ResponseLengthIncorrect = 33029,
    FirmwareRespondNakStep1 = 33030,
    KeyIdNotFoundInDb = 33281,
    KeySlotDoesNotExist = 33282,
    NoFutureKsiFromServer = 33283,
    NoTr31DataBlock = 33284,
    Tr31BlockLengthIncorrect = 33285,
    IncorrectChallengeDataStep2 = 33286,
    FirmwareRespondNakStep2 = 33287,
    NoKeyInjectionRecord = 33537,
    RkiFailed = 33538,
    IncorrectResponseForm = 33539,
    FirmwareRespondNakStep3 = 33540
}

public enum DUKPT_KEY_Type : uint
{
    Msr = 0,
    Icc = 1,
    Admin = 16,
    Pairing_PinPad = 32
}

public enum EMV_PIN_MODE_Types : uint
{
    Cancel = 0,
    OnlinePinDukpt = 1,
    OnlinePinMksk = 2,
    OfflinePin = 3
}

public enum EMV_RESULT_CODE_Types
{
    NoResponse = -1,
    Approved = 0,
    Declined = 1,
    GoOnline = 2,
    Failed = 3,
    SystemError = 5,
    NotAccept = 7,
    Fallback = 10,
    Cancel = 12,
    OtherError = 15,
    TimeOut = 13,
    OfflineApproved = 16,
    OfflineDeclined = 17,
    ReferralProcessing = 18,
    ErrorAppProcessing = 19,
    ErrorAppReading = 20,
    ErrorDataAuth = 21,
    ErrorProcessingRestrictions = 22,
    ErrorCvmProcessing = 23,
    ErrorRiskMgmt = 24,
    ErrorTermActionAnalysis = 25,
    ErrorCardActionAnalysis = 26,
    ErrorAppSelectionTimeout = 27,
    ErrorNoCardInserted = 28,
    ErrorAppSelecting = 29,
    ErrorReadingCardApp = 30,
    ErrorPowerCardError = 31,
    ErrorNoResultCodeProvidedForCompletion = 32,
    ApprovedWithAdviseNoReason = 33,
    ApprovedWithAdviseIaFailed = 34,
    ErrorAmountNotSpecified = 35,
    ErrorCardCompletion = 36,
    ErrorDataLenIncorrect = 37,
    CallYourBank = 38,
    NoIccOnCard = 39,
    NewSelection = 40,
    StartTransactionSuccess = 41
}

public enum EMV_RESULT_CODE_V2_Types
{
    NoResponse = -1,
    ApprovedOffline = 0,
    DeclinedOffline = 1,
    Approved = 2,
    Declined = 3,
    GoOnline = 4,
    CallYourBank = 5,
    NotAccepted = 6,
    UseMagstripe = 7,
    TimeOut = 8,
    StartTransSuccess = 16,
    MsrSuccess = 17,
    FileArgInvalid = 4097,
    FileOpenFailed = 4098,
    FileOperationFailed = 4099,
    MemoryNotEnough = 8193,
    SmartcardFail = 12289,
    SmartcardInitFailed = 12291,
    FallbackSituation = 12292,
    SmartcardAbsent = 12293,
    SmartcardTimeout = 12294,
    MsrCardError = 12295,
    ParsingTagsFailed = 20481,
    CardDataElementDuplicate = 20482,
    DataFormatIncorrect = 20483,
    AppNoTerm = 20484,
    AppNoMatching = 20485,
    AmandatoryObjectMissing = 20486,
    AppSelectionRetry = 20487,
    AmountErrorGet = 20488,
    CardRejected = 20489,
    AipNotReceived = 20496,
    AflNotReceivede = 20497,
    AflLenOutOfRange = 20498,
    SfiOutOfRange = 20499,
    AflIncorrect = 20500,
    ExpDateIncorrect = 20501,
    EffDateIncorrect = 20502,
    IssCodTblOutOfRange = 20503,
    CryptogramTypeIncorrect = 20504,
    PseByCardNotSupported = 20505,
    UserLanguageSelected = 20512,
    ServiceNotAllowed = 20513,
    NoTagFound = 20514,
    CardBlocked = 20515,
    LenIncorrect = 20516,
    CardComError = 20517,
    TscNotIncreased = 20518,
    HashIncorrect = 20519,
    ArcNotPresenced = 20520,
    ArcInvalid = 20521,
    CommNoOnline = 20528,
    TranTypeIncorrect = 20529,
    AppNoSupport = 20530,
    AppNotSelect = 20531,
    LangNotSelect = 20532,
    TermDataNotPresenced = 20533,
    CvmTypeUnknown = 24577,
    CvmAipNotSupported = 24578,
    CvmTag8eMissing = 24579,
    CvmTag8eFormatError = 24580,
    CvmCodeIsNotSupported = 24581,
    CvmCondCodeIsNotSupported = 24582,
    CvmNoMore = 24583,
    PinBypassedBefore = 24584
}

public enum EmvAuthorizationResult : uint
{
    Accepted = 0,
    UnableToGoOnline = 1,
    TechnicalIssue = 2,
    Declined = 3,
    IssuerReferal = 4
}

public enum UmReader : uint
{
    Unknown,
    UnimagOriginal,
    UnimagPro,
    UnimagIi,
    Shuttle
}
    //TODO DRh commented out the verifies..not sure if these will work
	//TODO I dont know if these are used but I was getting compile errors so I picked the first option referenced here : https://docs.microsoft.com/en-us/xamarin/ios/troubleshooting/mtouch-errors#MT5214
//static class CFunctions
//{
//    // NSString * UmReader_lookup (UmReader c);
//    [DllImport ("__Internal")]
//    //[Verify (PlatformInvoke)]
//    static extern NSString UmReader_lookup (UmReader c);

//    // NSString * UmRet_lookup (UmRet c);
//    [DllImport ("__Internal")]
//    //[Verify (PlatformInvoke)]
//    static extern NSString UmRet_lookup (UmRet c);

//    // NSString * RDStatus_lookup (RDStatus c);
//    [DllImport ("__Internal")]
//    //[Verify (PlatformInvoke)]
//    static extern NSString RDStatus_lookup (RDStatus c);
//}

public enum UmTask : uint
{
    None,
    Connect,
    Swipe,
    Cmd,
    FwUpdate
}

public enum UmRet : uint
{
    Success,
    NoReader,
    SdkBusy,
    MonoAudio,
    AlreadyConnected,
    LowVolume,
    NotConnected,
    NotApplicable,
    InvalidArg,
    UfInvalidStr,
    UfNoFile,
    UfInvalidFile
}

public enum UmUfCode : uint
{
    SendingBlock = 21,
    VerifyingChecksum = 30,
    ResendingBlock = 40,
    FailedToEnterBootloaderMode = 303,
    FailedToSendBlock = 305,
    FailedToVerifyChecksum = 306,
    Canceled = 307
}

    //DRH Changed this to a byte from nint
[Native]
public enum RDStatus : long
{
    Success,
    Failed,
    NotAttached,
    SdkBusy,
    MonoAudio,
    Connected,
    LowVolume,
    Disconnected,
    InvalidParameter,
    Canceled,
    Timedout
}

[StructLayout (LayoutKind.Sequential)]
public struct RDResult
{
    public RDStatus status;

    public NSMutableData data;
}

public enum Encryption_Type : uint
{
    Nokey = 48,
    Tdes,
    Aes
}

public enum PostPreamble : uint
{
    ReAmble = 2,
    OstAmble
}

public enum DecodingMethod : uint
{
    BothDirection = 49,
    HeadDirection,
    HeadAgainst,
    RawData
}

public enum KeyManagementType : uint
{
    Fixed = 48,
    Dukpt
}

public enum MagneticTrack : uint
{
    Track1 = 49,
    Track2,
    TRACK_1_and_2,
    Track3,
    TRACK_1_and_3,
    TRACK_2_and_3,
    All,
    Any1,
    Any2
}

public enum TrackID : uint
{
    Track1Id = 1,
    Track2Id,
    Track3Id
}

    //Clearent

	public enum ClockConfigurationErrorCode : uint
{
    ConfigurationSuccess,
    Failed
}

public enum ConfigurationErrorCode : uint
{
    TerminalMajor5cFailed,
    EmvConfigurationSuccess,
    MajorTagsRetrieveFailed,
    ContactMajorTagsUpdateFailed,
    CallFailed,
    JsonSerializationFailed,
    NoPayload,
    NoMobileDevice,
    ContactFailed,
    ContactCapksFailed
}

public enum supportedEmvEntryMode : uint
{
    FallbackSwipe = 80,
    NontechFallbackSwipe = 95,
    ContactlessEmv = 7,
    ContactlessMagneticSwipe = 91
}

public enum supportedNonEmvEntryMode : uint
{
    Swipe = 90
}


}
