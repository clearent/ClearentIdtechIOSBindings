using System;
using CoreBluetooth;
using ExternalAccessory;
using Foundation;
using ObjCRuntime;

//using System;

//using UIKit;
//using Foundation;
//using ObjCRuntime;
//using CoreGraphics;

namespace ClearentIdtechIOSBindings
{

    // @interface APDUResponse
    [BaseType(typeof(NSObject))]
    interface APDUResponse
    {
        // -(void)clear;
        [Export("clear")]
        void Clear();

        // +(APDUResponse *)sharedController;
        [Static]
        [Export("sharedController")]
        APDUResponse SharedController();

        // @property unsigned char SW1;
        [Export("SW1")]
        byte SW1 {get; }

        // @property unsigned char SW2;
        [Export("SW2")]
        byte SW2 { get;}

        // @property int hasKSN;
        [Export("hasKSN")]
        int HasKSN {get; }

        // @property int hasEncryption;
        [Export("hasEncryption")]
        int HasEncryption { get;}

        // @property int apduLength;
        [Export("apduLength")]
        int ApduLength {get; }

        // @property (nonatomic, strong) int * response;
        [Export("response", ArgumentSemantic.Strong)]
        unsafe int Response {get; }

        // @property (nonatomic, strong) int * ksn;
        [Export("ksn", ArgumentSemantic.Strong)]
        unsafe int Ksn {get; }
    }

    // @interface IDTMSRData : NSObject
    [BaseType(typeof(NSObject))]
    interface IDTMSRData
    {
        // -(void)clear;
        [Export("clear")]
        void Clear();

        // +(IDTMSRData *)sharedController;
        [Static]
        [Export("sharedController")]
        IDTMSRData SharedController();

        // @property EVENT_MSR_Types event;
        [Export("event", ArgumentSemantic.Assign)]
        EVENT_MSR_Types Event { get; set; }

        // @property CAPTURE_ENCODE_TYPE captureEncodeType;
        [Export("captureEncodeType", ArgumentSemantic.Assign)]
        CaptureEncodeType CaptureEncodeType { get; set; }

        // @property CAPTURE_ENCRYPT_TYPE captureEncryptType;
        [Export("captureEncryptType", ArgumentSemantic.Assign)]
        CaptureEncryptType CaptureEncryptType { get; set; }

        // @property (nonatomic, strong) NSData * cardData;
        [Export("cardData", ArgumentSemantic.Strong)]
        NSData CardData { get; set; }

        // @property (nonatomic, strong) NSString * track1;
        [Export("track1", ArgumentSemantic.Strong)]
        string Track1 { get; set; }

        // @property (nonatomic, strong) NSString * track2;
        [Export("track2", ArgumentSemantic.Strong)]
        string Track2 { get; set; }

        // @property (nonatomic, strong) NSString * track3;
        [Export("track3", ArgumentSemantic.Strong)]
        string Track3 { get; set; }

        // @property int track1Length;
        [Export("track1Length")]
        int Track1Length { get; set; }

        // @property int track2Length;
        [Export("track2Length")]
        int Track2Length { get; set; }

        // @property int track3Length;
        [Export("track3Length")]
        int Track3Length { get; set; }

        // @property (nonatomic, strong) NSData * encTrack1;
        [Export("encTrack1", ArgumentSemantic.Strong)]
        NSData EncTrack1 { get; set; }

        // @property (nonatomic, strong) NSData * encTrack2;
        [Export("encTrack2", ArgumentSemantic.Strong)]
        NSData EncTrack2 { get; set; }

        // @property (nonatomic, strong) NSData * encTrack3;
        [Export("encTrack3", ArgumentSemantic.Strong)]
        NSData EncTrack3 { get; set; }

        // @property (nonatomic, strong) NSData * hashTrack1;
        [Export("hashTrack1", ArgumentSemantic.Strong)]
        NSData HashTrack1 { get; set; }

        // @property (nonatomic, strong) NSData * hashTrack2;
        [Export("hashTrack2", ArgumentSemantic.Strong)]
        NSData HashTrack2 { get; set; }

        // @property (nonatomic, strong) NSData * hashTrack3;
        [Export("hashTrack3", ArgumentSemantic.Strong)]
        NSData HashTrack3 { get; set; }

        // @property (nonatomic, strong) NSString * RSN;
        [Export("RSN", ArgumentSemantic.Strong)]
        string RSN { get; set; }

        // @property (nonatomic, strong) NSData * KSN;
        [Export("KSN", ArgumentSemantic.Strong)]
        NSData KSN { get; set; }

        // @property (nonatomic, strong) NSData * sessionID;
        [Export("sessionID", ArgumentSemantic.Strong)]
        NSData SessionID { get; set; }

        // @property unsigned char readStatus;
        [Export("readStatus")]
        byte ReadStatus { get; set; }

        // @property int errorCode;
        [Export("errorCode")]
        int ErrorCode { get; set; }

        // @property _Bool iccPresent;
        [Export("iccPresent")]
        bool IccPresent { get; set; }

        // @property (nonatomic, strong) NSDictionary * unencryptedTags;
        [Export("unencryptedTags", ArgumentSemantic.Strong)]
        NSDictionary UnencryptedTags { get; set; }

        // @property (nonatomic, strong) NSDictionary * encryptedTags;
        [Export("encryptedTags", ArgumentSemantic.Strong)]
        NSDictionary EncryptedTags { get; set; }

        // @property (nonatomic, strong) NSDictionary * maskedTags;
        [Export("maskedTags", ArgumentSemantic.Strong)]
        NSDictionary MaskedTags { get; set; }
    }

    // @interface IDTEMVData : NSObject
    [BaseType(typeof(NSObject))]
    interface IDTEMVData
    {
        // -(void)clear;
        [Export("clear")]
        void Clear();

        // +(IDTEMVData *)sharedController;
        [Static]
        [Export("sharedController")]
        IDTEMVData SharedController();

        // @property EMV_RESULT_CODE_Types resultCode;
        [Export("resultCode", ArgumentSemantic.Assign)]
        EMV_RESULT_CODE_Types ResultCode { get; set; }

        // @property EMV_RESULT_CODE_V2_Types resultCodeV2;
        [Export("resultCodeV2", ArgumentSemantic.Assign)]
        EMV_RESULT_CODE_V2_Types ResultCodeV2 { get; set; }

        // @property int encryptionMode;
        [Export("encryptionMode")]
        int EncryptionMode { get; set; }

        // @property int cardType;
        [Export("cardType")]
        int CardType { get; set; }

        // @property _Bool hasAdvise;
        [Export("hasAdvise")]
        bool HasAdvise { get; set; }

        // @property _Bool hasReversal;
        [Export("hasReversal")]
        bool HasReversal { get; set; }

        // @property (nonatomic, strong) NSDictionary * unencryptedTags;
        [Export("unencryptedTags", ArgumentSemantic.Strong)]
        NSDictionary UnencryptedTags { get; set; }

        // @property (nonatomic, strong) NSDictionary * encryptedTags;
        [Export("encryptedTags", ArgumentSemantic.Strong)]
        NSDictionary EncryptedTags { get; set; }

        // @property (nonatomic, strong) NSDictionary * maskedTags;
        [Export("maskedTags", ArgumentSemantic.Strong)]
        NSDictionary MaskedTags { get; set; }

        // @property (nonatomic, strong) NSData * KSN;
        [Export("KSN", ArgumentSemantic.Strong)]
        NSData KSN { get; set; }

        // @property (nonatomic, strong) IDTMSRData * cardData;
        [Export("cardData", ArgumentSemantic.Strong)]
        IDTMSRData CardData { get; set; }
    }

    // @interface IDTUtility : NSObject
    [BaseType(typeof(NSObject))]
    interface IDTUtility
    {
        // +(NSBundle *)frameworkBundle;
        [Static]
        [Export("frameworkBundle")]
        NSBundle FrameworkBundle { get; }

        // +(NSString *)dataToPrintableString:(NSData *)data;
        [Static]
        [Export("dataToPrintableString:")]
        string DataToPrintableString(NSData data);

        // +(NSString *)hexToString:(NSData *)data startByte:(int)start length:(int)len;
        [Static]
        [Export("hexToString:startByte:length:")]
        string HexToString(NSData data, int start, int len);

        // +(NSString *)dataToString:(NSData *)data startByte:(int)start length:(int)len;
        [Static]
        [Export("dataToString:startByte:length:")]
        string DataToString(NSData data, int start, int len);

        // +(NSString *)getSubString:(NSString *)str startPosition:(int)start length:(int)len;
        [Static]
        [Export("getSubString:startPosition:length:")]
        string GetSubString(string str, int start, int len);

        // +(unsigned int)hex2int:(NSString *)hex;
        [Static]
        [Export("hex2int:")]
        uint Hex2int(string hex);

        // +(NSData *)hexToData:(NSString *)str;
        [Static]
        [Export("hexToData:")]
        NSData HexToData(string str);

        // +(NSString *)dataToString:(NSData *)data;
        [Static]
        [Export("dataToString:")]
        string DataToString(NSData data);

        // +(NSData *)extendedHextoHex:(NSData *)data;
        [Static]
        [Export("extendedHextoHex:")]
        NSData ExtendedHextoHex(NSData data);

        // +(NSData *)stringToData:(NSString *)str;
        [Static]
        [Export("stringToData:")]
        NSData StringToData(string str);

        // +(NSString *)hexToString:(NSString *)str;
        [Static]
        [Export("hexToString:")]
        string HexToString(string str);

        // +(NSString *)dataToHexString:(NSData *)data;
        [Static]
        [Export("dataToHexString:")]
        string DataToHexString(NSData data);

        // +(NSData *)encodeTags:(NSMutableDictionary *)tags;
        [Static]
        [Export("encodeTags:")]
        NSData EncodeTags(NSMutableDictionary tags);

        // +(NSDictionary *)processTLV:(NSData *)param;
        [Static]
        [Export("processTLV:")]
        NSDictionary ProcessTLV(NSData param);

        // +(NSDictionary *)TLVtoDICT:(NSData *)param;
        [Static]
        [Export("TLVtoDICT:")]
        NSDictionary TLVtoDICT(NSData param);

        // +(NSDictionary *)TLVtoDICT_HEX_ASCII:(NSData *)param;
        [Static]
        [Export("TLVtoDICT_HEX_ASCII:")]
        NSDictionary TLVtoDICT_HEX_ASCII(NSData param);

        // +(NSData *)DICTotTLV:(NSDictionary *)tags;
        [Static]
        [Export("DICTotTLV:")]
        NSData DICTotTLV(NSDictionary tags);

        // +(NSString *)stringByPaddingTheLeftToLength:(NSString *)orig newLen:(NSUInteger)newLength withString:(NSString *)padString;
        [Static]
        [Export("stringByPaddingTheLeftToLength:newLen:withString:")]
        string StringByPaddingTheLeftToLength(string orig, nuint newLength, string padString);

        // +(NSString *)padLeftZeros:(NSString *)orig Length:(int)len;
        [Static]
        [Export("padLeftZeros:Length:")]
        string PadLeftZeros(string orig, int len);

        // +(NSString *)padRightZeros:(NSString *)orig Length:(int)len;
        [Static]
        [Export("padRightZeros:Length:")]
        string PadRightZeros(string orig, int len);

        // +(NSData *)shortToDataReverse:(short)val;
        [Static]
        [Export("shortToDataReverse:")]
        NSData ShortToDataReverse(short val);

        // +(NSData *)shortToData:(short)val;
        [Static]
        [Export("shortToData:")]
        NSData ShortToData(short val);

        // +(NSData *)longToData:(long)val;
        [Static]
        [Export("longToData:")]
        NSData LongToData(nint val);

        // +(NSData *)byteToData:(Byte)val;
        [Static]
        [Export("byteToData:")]
        NSData ByteToData(byte val);

        // +(NSData *)computeSHA1:(NSData *)data;
        [Static]
        [Export("computeSHA1:")]
        NSData ComputeSHA1(NSData data);

        // +(NSDictionary *)combineDictionaries:(NSDictionary *)source dest:(NSDictionary *)dest overwrite:(BOOL)overwrite;
        [Static]
        [Export("combineDictionaries:dest:overwrite:")]
        NSDictionary CombineDictionaries(NSDictionary source, NSDictionary dest, bool overwrite);

        // +(void)pause:(float)sec;
        [Static]
        [Export("pause:")]
        void Pause(float sec);

        // +(NSDictionary *)processTLVUnencrypted:(NSData *)param;
        [Static]
        [Export("processTLVUnencrypted:")]
        NSDictionary ProcessTLVUnencrypted(NSData param);

        // +(NSString *)dtv:(double)amt;
        [Static]
        [Export("dtv:")]
        string Dtv(double amt);
    }
   
    // @protocol UniPay_Delegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UniPay_Delegate
    {
        // @optional -(void)UniPay_EventFunctionAttachment;
        [Export("UniPay_EventFunctionAttachment")]
        void UniPay_EventFunctionAttachment();

        // @optional -(void)UniPay_EventFunctionDetachment;
        [Export("UniPay_EventFunctionDetachment")]
        void UniPay_EventFunctionDetachment();

        // @optional -(void)dataInOutMonitor:(NSData *)data incoming:(BOOL)isIncoming;
        [Export("dataInOutMonitor:incoming:")]
        void DataInOutMonitor(NSData data, bool isIncoming);

        // @optional -(void)UniPay_EventFunctionConnect:(Byte)nType;
        [Export("UniPay_EventFunctionConnect:")]
        void UniPay_EventFunctionConnect(byte nType);

        // @optional -(void)UniPay_EventFunctionMessage:(NSString *)someString;
        [Export("UniPay_EventFunctionMessage:")]
        void UniPay_EventFunctionMessage(string someString);

        // @optional -(void)UniPay_EventFunctionMSR:(Byte)nType card:(NSData *)cardData;
        [Export("UniPay_EventFunctionMSR:card:")]
        void UniPay_EventFunctionMSR(byte nType, NSData cardData);

        // @optional -(void)UniPay_EventFunctionICC:(Byte)nICC_Attached;
        [Export("UniPay_EventFunctionICC:")]
        void UniPay_EventFunctionICC(byte nICC_Attached);

        // @optional -(void)UniPay_ReceivedData:(NSData *)data;
        [Export("UniPay_ReceivedData:")]
        void UniPay_ReceivedData(NSData data);
    }

    // @protocol IDT_Device_Delegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IDT_Device_Delegate
    {
        // @optional -(void)deviceConnected;
        [Export("deviceConnected")]
        void DeviceConnected();

        // @optional -(void)deviceDisconnected;
        [Export("deviceDisconnected")]
        void DeviceDisconnected();

        // @optional -(void)plugStatusChange:(BOOL)deviceInserted;
        [Export("plugStatusChange:")]
        void PlugStatusChange(bool deviceInserted);

        // @optional -(void)dataInOutMonitor:(NSData *)data incoming:(BOOL)isIncoming;
        [Export("dataInOutMonitor:incoming:")]
        void DataInOutMonitor(NSData data, bool isIncoming);

        // @optional -(void)swipeMSRData:(IDTMSRData *)cardData;
        [Export("swipeMSRData:")]
        void SwipeMSRData(IDTMSRData cardData);

        // @optional -(void)deviceMessage:(NSString *)message;
        [Export("deviceMessage:")]
        void DeviceMessage(string message);

        // @optional -(void)bypassData:(NSData *)data;
        [Export("bypassData:")]
        void BypassData(NSData data);

        // @optional -(void)lcdDisplay:(int)mode lines:(NSArray *)lines;
        [Export("lcdDisplay:lines:")]
        //[Verify(StronglyTypedNSArray)]
        void LcdDisplay(int mode, NSString[] lines);

        // @optional -(void)pinRequest:(EMV_PIN_MODE_Types)mode key:(NSData *)key PAN:(NSData *)PAN startTO:(int)startTO intervalTO:(int)intervalTO language:(NSString *)language;
        [Export("pinRequest:key:PAN:startTO:intervalTO:language:")]
        void PinRequest(EMV_PIN_MODE_Types mode, NSData key, NSData PAN, int startTO, int intervalTO, string language);

        // @optional -(void)UniPay_EventFunctionICC:(Byte)nICC_Attached;
        [Export("UniPay_EventFunctionICC:")]
        void UniPay_EventFunctionICC(byte nICC_Attached);

        // @optional -(void)emvTransactionData:(IDTEMVData *)emvData errorCode:(int)error;
        [Export("emvTransactionData:errorCode:")]
        void EmvTransactionData(IDTEMVData emvData, int error);

        // @optional -(void)pinpadData:(NSData *)value keySN:(NSData *)KSN event:(EVENT_PINPAD_Types)event;
        [Export("pinpadData:keySN:event:")]
        void PinpadData(NSData value, NSData KSN, EVENT_PINPAD_Types @event);
    }

    // @interface IDT_Device : NSObject <EAAccessoryDelegate, NSStreamDelegate, UniPay_Delegate, CBCentralManagerDelegate, CBPeripheralDelegate>
    [BaseType(typeof(NSObject))]
    interface IDT_Device : IEAAccessoryDelegate, INSStreamDelegate, UniPay_Delegate, ICBCentralManagerDelegate, ICBPeripheralDelegate
    {
        // @property (nonatomic, strong) CBCentralManager * centralManager;
        [Export("centralManager", ArgumentSemantic.Strong)]
        CBCentralManager CentralManager { get; set; }

        // @property (nonatomic, strong) CBPeripheral * bleDevice;
        [Export("bleDevice", ArgumentSemantic.Strong)]
        CBPeripheral BleDevice { get; set; }

        [Wrap("WeakDelegate")]
        IDT_Device_Delegate Delegate { get; set; }

        // @property (strong) id<IDT_Device_Delegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Strong)]
        NSObject WeakDelegate { get; set; }

        // @property (strong) id<IDT_Device_Delegate> delegate2;
        [Export("delegate2", ArgumentSemantic.Strong)]
        IDT_Device_Delegate Delegate2 { get; set; }

        [Wrap("WeakBypassDelegate")]
        IDT_Device_Delegate BypassDelegate { get; set; }

        // @property (strong) id<IDT_Device_Delegate> bypassDelegate;
        [NullAllowed, Export("bypassDelegate", ArgumentSemantic.Strong)]
        NSObject WeakBypassDelegate { get; set; }

        // +(NSString *)SDK_version;
        [Static]
        [Export("SDK_version")]
        string SDK_version { get; }

        // +(IDT_Device *)sharedController;
        [Static]
        [Export("sharedController")]
        IDT_Device SharedController { get; }

        // +(void)bypassOutput:(_Bool)bypass;
        [Static]
        [Export("bypassOutput:")]
        void BypassOutput(bool bypass);

        // +(void)setDeviceType:(IDT_DEVICE_Types)deviceType;
        [Static]
        [Export("setDeviceType:")]
        void SetDeviceType(IDT_DEVICE_Types deviceType);

        // -(void)processBypassResponse:(NSData *)data;
        [Export("processBypassResponse:")]
        void ProcessBypassResponse(NSData data);

        // -(BOOL)open;
        [Export("open")]
        bool Open { get; }

        // -(void)close;
        [Export("close")]
        void Close();

        // -(void)destroy;
        [Export("destroy")]
        void Destroy();

        // -(_Bool)enableBLEDeviceSearch:(IDT_DEVICE_Types)type identifier:(NSUUID *)identifier;
        [Export("enableBLEDeviceSearch:identifier:")]
        bool EnableBLEDeviceSearch(IDT_DEVICE_Types type, NSUuid identifier);

        // -(NSString *)getBLEFriendlyName;
        [Export("getBLEFriendlyName")]
        string BLEFriendlyName { get; }

        // -(void)device_disconnectBLE;
        [Export("device_disconnectBLE")]
        void Device_disconnectBLE();

        // -(void)setBLEFriendlyName:(NSString *)friendlyName;
        [Export("setBLEFriendlyName:")]
        void SetBLEFriendlyName(string friendlyName);

        // -(_Bool)disableBLEDeviceSearch;
        [Export("disableBLEDeviceSearch")]
        bool DisableBLEDeviceSearch { get; }

        // -(NSUUID *)connectedBLEDevice;
        [Export("connectedBLEDevice")]
        NSUuid ConnectedBLEDevice { get; }

        // -(ReturnCode)getEMVL1Version:(NSString **)response;
        [Export("getEMVL1Version:")]
        ReturnCode GetEMVL1Version(out string response);

        // -(ReturnCode)getEMVL2Version:(NSString **)response;
        [Export("getEMVL2Version:")]
        ReturnCode GetEMVL2Version(out string response);

        // -(ReturnCode)getEMVKernelVersion:(NSString **)response;
        [Export("getEMVKernelVersion:")]
        ReturnCode GetEMVKernelVersion(out string response);

        // -(ReturnCode)activateTransaction:(NSMutableDictionary *)tags timeout:(int)timeout;
        [Export("activateTransaction:timeout:")]
        ReturnCode ActivateTransaction(NSMutableDictionary tags, int timeout);

        // -(ReturnCode)getAutoPollTransactionResults:(IDTEMVData **)result;
        [Export("getAutoPollTransactionResults:")]
        ReturnCode GetAutoPollTransactionResults(out IDTEMVData result);

        // -(ReturnCode)retrieveTransactionResult:(NSData *)tags retrievedTags:(NSDictionary **)retrievedTags;
        [Export("retrieveTransactionResult:retrievedTags:")]
        ReturnCode RetrieveTransactionResult(NSData tags, out NSDictionary retrievedTags);

        // -(ReturnCode)setBurstMode:(int)mode;
        [Export("setBurstMode:")]
        ReturnCode SetBurstMode(int mode);

        // -(ReturnCode)setPollMode:(int)mode;
        [Export("setPollMode:")]
        ReturnCode SetPollMode(int mode);

        // -(ReturnCode)cancelCTLSTransaction;
        [Export("cancelCTLSTransaction")]
        ReturnCode CancelCTLSTransaction();

        // -(ReturnCode)startEMVTransaction:(float)amount otherAmount:(float)amtOther timeout:(int)timeout transactionType:(unsigned char)type additionalTags:(NSMutableDictionary *)tags;
        [Export("startEMVTransaction:otherAmount:timeout:transactionType:additionalTags:")]
        ReturnCode StartEMVTransaction(float amount, float amtOther, int timeout, byte type, NSMutableDictionary tags);

        // -(ReturnCode)startTransaction:(double)amount amtOther:(double)amtOther type:(int)type timeout:(int)timeout tags:(NSData *)tags forceOnline:(BOOL)forceOnline fallback:(BOOL)fallback;
        [Export("startTransaction:amtOther:type:timeout:tags:forceOnline:fallback:")]
        ReturnCode StartTransaction(double amount, double amtOther, int type, int timeout, NSData tags, bool forceOnline, bool fallback);

        // -(ReturnCode)device_startTransaction:(double)amount amtOther:(double)amtOther type:(int)type timeout:(int)timeout tags:(NSData *)tags forceOnline:(BOOL)forceOnline fallback:(BOOL)fallback;
        [Export("device_startTransaction:amtOther:type:timeout:tags:forceOnline:fallback:")]
        ReturnCode Device_startTransaction(double amount, double amtOther, int type, int timeout, NSData tags, bool forceOnline, bool fallback);

        // -(ReturnCode)completeOnlineEMVTransaction:(EMV_AUTHORIZATION_RESULT)result hostResponseTags:(NSMutableDictionary *)tags responseTags:(IDTEMVData **)response;
        [Export("completeOnlineEMVTransaction:hostResponseTags:responseTags:")]
        ReturnCode CompleteOnlineEMVTransaction(EmvAuthorizationResult result, NSMutableDictionary tags, out IDTEMVData response);

        // -(ReturnCode)completeOnlineEMVTransaction:(BOOL)isSuccess hostResponseTags:(NSData *)tags;
        [Export("completeOnlineEMVTransaction:hostResponseTags:")]
        ReturnCode CompleteOnlineEMVTransaction(bool isSuccess, NSData tags);

        // -(ReturnCode)setCRL:(CRLEntry)key;
        [Export("setCRL:")]
        ReturnCode SetCRL(CRLEntry key);

        // -(ReturnCode)removeCRL:(CRLEntry)key;
        [Export("removeCRL:")]
        ReturnCode RemoveCRL(CRLEntry key);

        // -(ReturnCode)removeCRLUnit:(CRLEntry)key;
        [Export("removeCRLUnit:")]
        ReturnCode RemoveCRLUnit(CRLEntry key);

        // -(ReturnCode)retrieveCRLForRID:(NSString *)rid response:(NSArray **)response;
        [Export("retrieveCRLForRID:response:")]
        //[Verify(StronglyTypedNSArray)]
        ReturnCode RetrieveCRLForRID(string rid, out NSObject[] response);

        // -(ReturnCode)retrieveCRLList:(NSMutableArray **)response;
        [Export("retrieveCRLList:")]
        ReturnCode RetrieveCRLList(out NSMutableArray response);

        // -(ReturnCode)removeCRLList;
        [Export("removeCRLList")]
        ReturnCode RemoveCRLList();

        // -(ReturnCode)retrieveCAPK:(NSString *)rid index:(NSString *)index response:(CAKey **)response;
        [Export("retrieveCAPK:index:response:")]
        unsafe ReturnCode RetrieveCAPK(string rid, string index, CAKey response);

        // -(ReturnCode)setCRLEntries:(NSData *)data;
        [Export("setCRLEntries:")]
        ReturnCode SetCRLEntries(NSData data);

        // -(ReturnCode)retrieveCAPKFile:(NSString *)rid index:(NSString *)index response:(NSData **)response;
        [Export("retrieveCAPKFile:index:response:")]
        ReturnCode RetrieveCAPKFile(string rid, string index, ref IntPtr response);

        // -(ReturnCode)removeCAPK:(NSString *)rid index:(NSString *)index;
        [Export("removeCAPK:index:")]
        ReturnCode RemoveCAPK(string rid, string index);

        // -(ReturnCode)setCAPK:(CAKey)key;
        [Export("setCAPK:")]
        ReturnCode SetCAPK(CAKey key);

        // -(ReturnCode)retrieveCAPKList:(NSArray **)response;
        [Export("retrieveCAPKList:")]
        //[Verify(StronglyTypedNSArray)]
        ReturnCode RetrieveCAPKList(out NSObject[] response);

        // -(ReturnCode)retrieveTerminalData:(TerminalData **)response;
        [Export("retrieveTerminalData:")]
        unsafe ReturnCode RetrieveTerminalData(TerminalData response);

        // -(ReturnCode)removeTerminalData;
        [Export("removeTerminalData")]
        ReturnCode RemoveTerminalData();

        // -(ReturnCode)setTerminalData:(TerminalData)data;
        [Export("setTerminalData:")]
        ReturnCode SetTerminalData(TerminalData data);

        // -(ReturnCode)retrieveTerminalDataUniPay:(NSDictionary **)responseData;
        [Export("retrieveTerminalDataUniPay:")]
        ReturnCode RetrieveTerminalDataUniPay(out NSDictionary responseData);

        // -(ReturnCode)retrieveApplicationDataUniPay:(NSString *)AID response:(NSDictionary **)responseAID;
        [Export("retrieveApplicationDataUniPay:response:")]
        ReturnCode RetrieveApplicationDataUniPay(string AID, out NSDictionary responseAID);

        // -(ReturnCode)retrieveApplicationData:(NSString *)AID response:(ApplicationID **)responseAID;
        [Export("retrieveApplicationData:response:")]
        unsafe ReturnCode RetrieveApplicationData(string AID, ApplicationID responseAID);

        // -(ReturnCode)removeApplicationData:(NSString *)AID;
        [Export("removeApplicationData:")]
        ReturnCode RemoveApplicationData(string AID);

        // -(ReturnCode)setApplicationDataUniPay:(NSString *)aidName configData:(NSDictionary *)data;
        [Export("setApplicationDataUniPay:configData:")]
        ReturnCode SetApplicationDataUniPay(string aidName, NSDictionary data);

        // -(ReturnCode)setTerminalDataUniPay:(NSDictionary *)data;
        [Export("setTerminalDataUniPay:")]
        ReturnCode SetTerminalDataUniPay(NSDictionary data);

        // -(ReturnCode)setCAPKFile:(NSData *)file;
        [Export("setCAPKFile:")]
        ReturnCode SetCAPKFile(NSData file);

        // -(ReturnCode)setApplicationData:(ApplicationID)data;
        [Export("setApplicationData:")]
        ReturnCode SetApplicationData(ApplicationID data);

        // -(ReturnCode)retrieveAIDList:(NSArray **)response;
        [Export("retrieveAIDList:")]
        //[Verify(StronglyTypedNSArray)]
        ReturnCode RetrieveAIDList(out NSObject[] response);

        // -(void)stayConnected:(BOOL)stayConnected;
        [Export("stayConnected:")]
        void StayConnected(bool stayConnected);

        // -(ReturnCode)exchangeEncryptedAPDU:(NSData *)dataAPDU response:(APDUResponse **)response;
        [Export("exchangeEncryptedAPDU:response:")]
        ReturnCode ExchangeEncryptedAPDU(NSData dataAPDU, out APDUResponse response);

        // -(ReturnCode)exchangeAPDU:(NSData *)dataAPDU encrypted:(BOOL)encrypted ksn:(NSData *)ksn response:(APDUResponse **)response;
        [Export("exchangeAPDU:encrypted:ksn:response:")]
        ReturnCode ExchangeAPDU(NSData dataAPDU, bool encrypted, NSData ksn, out APDUResponse response);

        // -(ReturnCode)getAPDU_KSN:(NSData **)ksn;
        [Export("getAPDU_KSN:")]
        ReturnCode GetAPDU_KSN(ref IntPtr ksn);

        // -(ReturnCode)powerOffICC:(NSString **)error;
        [Export("powerOffICC:")]
        ReturnCode PowerOffICC(out string error);

        // -(ReturnCode)powerOnICC:(NSData **)response;
        [Export("powerOnICC:")]
        ReturnCode PowerOnICC(ref IntPtr response);

        // -(ReturnCode)powerOnICC:(PowerOnStructure)options response:(NSData **)response;
        [Export("powerOnICC:response:")]
        ReturnCode PowerOnICC(IntPtr options, out NSData response);

        // -(BOOL)setCmdTimeOutDuration:(float)nSecond;
        [Export("setCmdTimeOutDuration:")]
        bool SetCmdTimeOutDuration(float nSecond);

        // -(ReturnCode)sendDataCommand:(NSData *)cmd calcLRC:(BOOL)lrc response:(NSData **)response;
        [Export("sendDataCommand:calcLRC:response:")]
        ReturnCode SendDataCommand(NSData cmd, bool lrc, ref IntPtr response);

        // -(ReturnCode)getICCReaderStatus:(ICCReaderStatus **)readerStatus;
        [Export("getICCReaderStatus:")]
        unsafe ReturnCode GetICCReaderStatus(ICCReaderStatus readerStatus);

        // -(ReturnCode)setBluetoothAddress:(NSString *)address;
        [Export("setBluetoothAddress:")]
        ReturnCode SetBluetoothAddress(string address);

        // -(ReturnCode)rebootDevice;
        [Export("rebootDevice")]
        ReturnCode RebootDevice();

        // -(ReturnCode)clearDisplay:(int)option;
        [Export("clearDisplay:")]
        ReturnCode ClearDisplay(int option);

        // -(ReturnCode)backlightControl:(BOOL)turnON;
        [Export("backlightControl:")]
        ReturnCode BacklightControl(bool turnON);

        // -(ReturnCode)defaultSettingsPinPadUniPay;
        [Export("defaultSettingsPinPadUniPay")]
        ReturnCode DefaultSettingsPinPadUniPay();

        // -(ReturnCode)sendBeepUniPayII:(int)frequency duration:(int)duration;
        [Export("sendBeepUniPayII:duration:")]
        ReturnCode SendBeepUniPayII(int frequency, int duration);

        // -(ReturnCode)sendBeep:(unsigned short *)beep numberOfTones:(int)num;
        [Export("sendBeep:numberOfTones:")]
        unsafe ReturnCode SendBeep(ushort beep, int num);

        // -(ReturnCode)displayMessageUniPayII:(NSString *)message lineNumber:(int)line;
        [Export("displayMessageUniPayII:lineNumber:")]
        ReturnCode DisplayMessageUniPayII(string message, int line);

        // -(ReturnCode)savePromptUniPayII:(NSString *)message location:(int)location;
        [Export("savePromptUniPayII:location:")]
        ReturnCode SavePromptUniPayII(string message, int location);

        // -(ReturnCode)displayPromptUniPayII:(int)prompt lineNumber:(int)line;
        [Export("displayPromptUniPayII:lineNumber:")]
        ReturnCode DisplayPromptUniPayII(int prompt, int line);

        // -(ReturnCode)displayMessage:(NSString *)line1 line2:(NSString *)line2 line3:(NSString *)line3 line4:(NSString *)line4;
        [Export("displayMessage:line2:line3:line4:")]
        ReturnCode DisplayMessage(string line1, string line2, string line3, string line4);

        // -(ReturnCode)setIdleTimeForSleep:(int)seconds;
        [Export("setIdleTimeForSleep:")]
        ReturnCode SetIdleTimeForSleep(int seconds);

        // -(ReturnCode)enterSleepMode;
        [Export("enterSleepMode")]
        ReturnCode EnterSleepMode();

        // -(ReturnCode)getFirmwareVersion:(NSString **)response;
        [Export("getFirmwareVersion:")]
        ReturnCode GetFirmwareVersion(out string response);

        // -(ReturnCode)getModelNumber:(NSString **)response;
        [Export("getModelNumber:")]
        ReturnCode GetModelNumber(out string response);

        // -(ReturnCode)getKeyStatus:(NSData **)response;
        [Export("getKeyStatus:")]
        ReturnCode GetKeyStatus(ref IntPtr response);

        // -(ReturnCode)getBatteryVoltage:(NSString **)response;
        [Export("getBatteryVoltage:")]
        ReturnCode GetBatteryVoltage(out string response);

        // -(ReturnCode)getSerialNumber:(NSString **)response;
        [Export("getSerialNumber:")]
        ReturnCode GetSerialNumber(out string response);

        // -(ReturnCode)setSerialNumber:(NSString *)strSN;
        [Export("setSerialNumber:")]
        ReturnCode SetSerialNumber(string strSN);

        // -(ReturnCode)getInterfaceDeviceSN:(NSString **)response;
        [Export("getInterfaceDeviceSN:")]
        ReturnCode GetInterfaceDeviceSN(out string response);

        // -(ReturnCode)setInterfaceDeviceSN:(NSString *)sn;
        [Export("setInterfaceDeviceSN:")]
        ReturnCode SetInterfaceDeviceSN(string sn);

        // -(ReturnCode)getTerminalIdentification:(NSString **)response;
        [Export("getTerminalIdentification:")]
        ReturnCode GetTerminalIdentification(out string response);

        // -(ReturnCode)setTerminalIdentification:(NSString *)sn;
        [Export("setTerminalIdentification:")]
        ReturnCode SetTerminalIdentification(string sn);

        // -(ReturnCode)getDateTime:(NSString **)response;
        [Export("getDateTime:")]
        ReturnCode GetDateTime(out string response);

        // -(ReturnCode)getBCDMaskChar:(NSString **)response;
        [Export("getBCDMaskChar:")]
        ReturnCode GetBCDMaskChar(out string response);

        // -(ReturnCode)setBCDMaskChar:(char)mask;
        [Export("setBCDMaskChar:")]
        ReturnCode SetBCDMaskChar(sbyte mask);

        // -(ReturnCode)restoreDefaultSettings;
        [Export("restoreDefaultSettings")]
        ReturnCode RestoreDefaultSettings();

        // -(ReturnCode)getExpiryDateOption:(NSString **)response;
        [Export("getExpiryDateOption:")]
        ReturnCode GetExpiryDateOption(out string response);

        // -(ReturnCode)getASCIIMaskChar:(NSString **)response;
        [Export("getASCIIMaskChar:")]
        ReturnCode GetASCIIMaskChar(out string response);

        //DRH DUP ?
        // -(ReturnCode)setBCDMaskChar:(char)mask;
        //[Export("setBCDMaskChar:")]
        //ReturnCode SetBCDMaskChar(sbyte mask);

        // -(ReturnCode)setASCIIMaskChar:(char)mask;
        [Export("setASCIIMaskChar:")]
        ReturnCode SetASCIIMaskChar(sbyte mask);

        // -(ReturnCode)getPrePostFixPAN:(NSString **)response;
        [Export("getPrePostFixPAN:")]
        ReturnCode GetPrePostFixPAN(out string response);

        // -(ReturnCode)setPrePostFixPAN:(int)prefix postfix:(int)postfix;
        [Export("setPrePostFixPAN:postfix:")]
        ReturnCode SetPrePostFixPAN(int prefix, int postfix);

        // -(ReturnCode)getCardOption:(NSString **)response;
        [Export("getCardOption:")]
        ReturnCode GetCardOption(out string response);

        // -(ReturnCode)setCardOption:(int)option;
        [Export("setCardOption:")]
        ReturnCode SetCardOption(int option);

        // -(ReturnCode)getRKITimeout:(NSNumber **)response;
        [Export("getRKITimeout:")]
        ReturnCode GetRKITimeout(out NSNumber response);

        // -(ReturnCode)setRKITimeout:(int)seconds;
        [Export("setRKITimeout:")]
        ReturnCode SetRKITimeout(int seconds);

        // -(ReturnCode)getKSN:(int)keySlot ksn:(NSData **)ksn;
        [Export("getKSN:ksn:")]
        ReturnCode GetKSN(int keySlot, ref IntPtr ksn);

        // -(ReturnCode)setDateTime:(NSString *)date;
        [Export("setDateTime:")]
        ReturnCode SetDateTime(string date);

        // -(ReturnCode)cancelPin;
        [Export("cancelPin")]
        ReturnCode CancelPin();

        // -(ReturnCode)pin_capturePin:(int)type PAN:(NSString *)PAN minPIN:(int)minPIN maxPIN:(int)maxPIN message:(NSString *)message;
        [Export("pin_capturePin:PAN:minPIN:maxPIN:message:")]
        ReturnCode Pin_capturePin(int type, string PAN, int minPIN, int maxPIN, string message);

        // -(ReturnCode)pin_captureAmountInput:(int)minPIN maxPIN:(int)maxPIN message:(NSString *)message signature:(NSData *)signature;
        [Export("pin_captureAmountInput:maxPIN:message:signature:")]
        ReturnCode Pin_captureAmountInput(int minPIN, int maxPIN, string message, NSData signature);

        // -(ReturnCode)pin_captureNumericInput:(_Bool)mask minPIN:(int)minPIN maxPIN:(int)maxPIN message:(NSString *)message signature:(NSData *)signature;
        [Export("pin_captureNumericInput:minPIN:maxPIN:message:signature:")]
        ReturnCode Pin_captureNumericInput(bool mask, int minPIN, int maxPIN, string message, NSData signature);

        // -(ReturnCode)pin_captureFunctionKey;
        [Export("pin_captureFunctionKey")]
        ReturnCode Pin_captureFunctionKey();

        // -(ReturnCode)setNumericLength:(int)minLength maxLength:(int)maxLength;
        [Export("setNumericLength:maxLength:")]
        ReturnCode SetNumericLength(int minLength, int maxLength);

        // -(ReturnCode)setPinLength:(int)minLength maxLength:(int)maxLength;
        [Export("setPinLength:maxLength:")]
        ReturnCode SetPinLength(int minLength, int maxLength);

        // -(ReturnCode)getNumericLength:(NSData **)response;
        [Export("getNumericLength:")]
        ReturnCode GetNumericLength(ref IntPtr response);

        // -(ReturnCode)getPinLength:(NSData **)response;
        [Export("getPinLength:")]
        ReturnCode GetPinLength(ref IntPtr response);

        // -(ReturnCode)getPINpadStatus:(NSData **)response;
        [Export("getPINpadStatus:")]
        ReturnCode GetPINpadStatus(ref IntPtr response);

        // -(ReturnCode)setEncryptMSRFormat:(int)encryption;
        [Export("setEncryptMSRFormat:")]
        ReturnCode SetEncryptMSRFormat(int encryption);

        // -(ReturnCode)getEncryptMSRFormat:(NSString **)response;
        [Export("getEncryptMSRFormat:")]
        ReturnCode GetEncryptMSRFormat(out string response);

        // -(ReturnCode)setCardDataEncryptedAlgorithm:(int)encryption;
        [Export("setCardDataEncryptedAlgorithm:")]
        ReturnCode SetCardDataEncryptedAlgorithm(int encryption);

        // -(ReturnCode)getCardDataEncryptedAlgorithm:(NSString **)response;
        [Export("getCardDataEncryptedAlgorithm:")]
        ReturnCode GetCardDataEncryptedAlgorithm(out string response);

        // -(ReturnCode)setClearPANID:(int)digits;
        [Export("setClearPANID:")]
        ReturnCode SetClearPANID(int digits);

        // -(ReturnCode)setClearPANIDII:(int)digits;
        [Export("setClearPANIDII:")]
        ReturnCode SetClearPANIDII(int digits);

        // -(ReturnCode)getClearPANID:(NSString **)response;
        [Export("getClearPANID:")]
        ReturnCode GetClearPANID(out string response);

        // -(ReturnCode)getBacklightStatus:(NSString **)response;
        [Export("getBacklightStatus:")]
        ReturnCode GetBacklightStatus(out string response);

        // -(ReturnCode)setExpirationMask:(BOOL)masked;
        [Export("setExpirationMask:")]
        ReturnCode SetExpirationMask(bool masked);

        // -(ReturnCode)setExpirationMaskII:(BOOL)masked;
        [Export("setExpirationMaskII:")]
        ReturnCode SetExpirationMaskII(bool masked);

        // -(ReturnCode)getExpirationMask:(NSString **)response;
        [Export("getExpirationMask:")]
        ReturnCode GetExpirationMask(out string response);

        // -(ReturnCode)setSwipeEncryption:(int)encryption;
        [Export("setSwipeEncryption:")]
        ReturnCode SetSwipeEncryption(int encryption);

        // -(ReturnCode)getSwipeEncryption:(NSString **)response;
        [Export("getSwipeEncryption:")]
        ReturnCode GetSwipeEncryption(out string response);

        // -(ReturnCode)setSwipeForcedEncryptionOption:(BOOL)track1 track2:(BOOL)track2 track3:(BOOL)track3 track3card0:(BOOL)track3card0;
        [Export("setSwipeForcedEncryptionOption:track2:track3:track3card0:")]
        ReturnCode SetSwipeForcedEncryptionOption(bool track1, bool track2, bool track3, bool track3card0);

        // -(ReturnCode)getSwipeForcedEncryptionOption:(NSString **)response;
        [Export("getSwipeForcedEncryptionOption:")]
        ReturnCode GetSwipeForcedEncryptionOption(out string response);

        // -(ReturnCode)setSwipeMaskOption:(BOOL)track1 track2:(BOOL)track2 track3:(BOOL)track3;
        [Export("setSwipeMaskOption:track2:track3:")]
        ReturnCode SetSwipeMaskOption(bool track1, bool track2, bool track3);

        // -(ReturnCode)getSwipeMaskOption:(NSString **)response;
        [Export("getSwipeMaskOption:")]
        ReturnCode GetSwipeMaskOption(out string response);

        // -(ReturnCode)setKeyTypeForICCDUKPT:(int)encryption;
        [Export("setKeyTypeForICCDUKPT:")]
        ReturnCode SetKeyTypeForICCDUKPT(int encryption);

        // -(ReturnCode)getKeyTypeForICCDUKPT:(NSString **)response;
        [Export("getKeyTypeForICCDUKPT:")]
        ReturnCode GetKeyTypeForICCDUKPT(out string response);

        // -(ReturnCode)setKeyFormatForICCDUKPT:(int)encryption;
        [Export("setKeyFormatForICCDUKPT:")]
        ReturnCode SetKeyFormatForICCDUKPT(int encryption);

        // -(ReturnCode)getKeyFormatForICCDUKPT:(NSString **)response;
        [Export("getKeyFormatForICCDUKPT:")]
        ReturnCode GetKeyFormatForICCDUKPT(out string response);

        // -(ReturnCode)getEncryptedPIN:(NSString *)account keyType:(PIN_KEY_Types)type line1:(NSString *)line1 line2:(NSString *)line2 line3:(NSString *)line3;
        [Export("getEncryptedPIN:keyType:line1:line2:line3:")]
        ReturnCode GetEncryptedPIN(string account, PIN_KEY_Types type, string line1, string line2, string line3);

        // -(ReturnCode)startMSRSwipeWithDisplay:(NSString *)line1 line2:(NSString *)line2 line3:(NSString *)line3;
        [Export("startMSRSwipeWithDisplay:line2:line3:")]
        ReturnCode StartMSRSwipeWithDisplay(string line1, string line2, string line3);

        // -(ReturnCode)startMSRSwipe:(int)track;
        [Export("startMSRSwipe:")]
        ReturnCode StartMSRSwipe(int track);

        // -(ReturnCode)cancelMSRSwipe;
        [Export("cancelMSRSwipe")]
        ReturnCode CancelMSRSwipe();

        // -(NSString *)getResponseCodeString:(int)errorCode;
        [Export("getResponseCodeString:")]
        string GetResponseCodeString(int errorCode);

        // -(ReturnCode)getCardAccount:(int)minLength max:(int)maxLength line1:(NSString *)line1 line2:(NSString *)line2;
        [Export("getCardAccount:max:line1:line2:")]
        ReturnCode GetCardAccount(int minLength, int maxLength, string line1, string line2);

        // -(ReturnCode)getEncryptedData:(BOOL)lastPackage minLength:(int)minLength maxLength:(int)maxLength messageID:(int)mID language:(LANGUAGE_TYPE)lang;
        [Export("getEncryptedData:minLength:maxLength:messageID:language:")]
        ReturnCode GetEncryptedData(bool lastPackage, int minLength, int maxLength, int mID, LanguageType lang);

        // -(ReturnCode)getNumeric:(_Bool)maskInput minLength:(int)minLength maxLength:(int)maxLength messageID:(int)mID language:(LANGUAGE_TYPE)lang;
        [Export("getNumeric:minLength:maxLength:messageID:language:")]
        ReturnCode GetNumeric(bool maskInput, int minLength, int maxLength, int mID, LanguageType lang);

        // -(ReturnCode)getNumericUniPayII:(_Bool)maskInput messageID:(int)mID language:(LANGUAGE_TYPE)lang;
        [Export("getNumericUniPayII:messageID:language:")]
        ReturnCode GetNumericUniPayII(bool maskInput, int mID, LanguageType lang);

        // -(ReturnCode)getAmount:(int)minLength maxLength:(int)maxLength messageID:(int)mID language:(LANGUAGE_TYPE)lang;
        [Export("getAmount:maxLength:messageID:language:")]
        ReturnCode GetAmount(int minLength, int maxLength, int mID, LanguageType lang);

        // -(ReturnCode)uploadJPEG:(NSData *)picture;
        [Export("uploadJPEG:")]
        ReturnCode UploadJPEG(NSData picture);

        // -(ReturnCode)showJPEG:(int)X0 Y0:(int)Y0 X1:(int)X1 Y1:(int)Y1;
        [Export("showJPEG:Y0:X1:Y1:")]
        ReturnCode ShowJPEG(int X0, int Y0, int X1, int Y1);

        // -(BOOL)isAudioReaderConnected;
        [Export("isAudioReaderConnected")]
        bool IsAudioReaderConnected();

        // -(ReturnCode)connectToAudioReader;
        [Export("connectToAudioReader")]
        ReturnCode ConnectToAudioReader();

        // -(ReturnCode)cancelConnectToAudioReader;
        [Export("cancelConnectToAudioReader")]
        ReturnCode CancelConnectToAudioReader();

        // -(ReturnCode)setAudioVolume:(float)val;
        [Export("setAudioVolume:")]
        ReturnCode SetAudioVolume(float val);

        // -(void)cardInsertTimeout:(int)sec;
        [Export("cardInsertTimeout:")]
        void CardInsertTimeout(int sec);

        // -(ReturnCode)getTag:(NSString *)tagName tagData:(NSData **)data;
        [Export("getTag:tagData:")]
        ReturnCode GetTag(string tagName,ref IntPtr data);

        // -(ReturnCode)getAllTags:(NSDictionary **)data;
        [Export("getAllTags:")]
        ReturnCode GetAllTags(out NSDictionary data);

        // -(ReturnCode)getMaskAndEncryption:(MaskAndEncryption **)data;
        [Export("getMaskAndEncryption:")]
        unsafe ReturnCode GetMaskAndEncryption(MaskAndEncryption data);

        // -(ReturnCode)restoreMaskAndEncryptionDefaults;
        [Export("restoreMaskAndEncryptionDefaults")]
        ReturnCode RestoreMaskAndEncryptionDefaults();

        // -(ReturnCode)setPANMaskingCharacter:(char)maskChar;
        [Export("setPANMaskingCharacter:")]
        ReturnCode SetPANMaskingCharacter(sbyte maskChar);

        // -(ReturnCode)setPrePANClearDigits:(int)clearDigits;
        [Export("setPrePANClearDigits:")]
        ReturnCode SetPrePANClearDigits(int clearDigits);

        // -(ReturnCode)setPostPANClearDigits:(int)clearDigits;
        [Export("setPostPANClearDigits:")]
        ReturnCode SetPostPANClearDigits(int clearDigits);

        // -(ReturnCode)setExpMasking:(BOOL)mask;
        [Export("setExpMasking:")]
        ReturnCode SetExpMasking(bool mask);

        // -(ReturnCode)setMaskingOption:(char)maskOption;
        [Export("setMaskingOption:")]
        ReturnCode SetMaskingOption(sbyte maskOption);

        // -(ReturnCode)setEncryptionOption:(char)encOption;
        [Export("setEncryptionOption:")]
        ReturnCode SetEncryptionOption(sbyte encOption);

        // -(ReturnCode)getLanguageType:(NSUInteger **)response;
        [Export("getLanguageType:")]
        unsafe ReturnCode GetLanguageType(nuint response);

        // -(ReturnCode)setLanguageType:(LANGUAGE_TYPE)lang;
        [Export("setLanguageType:")]
        ReturnCode SetLanguageType(LanguageType lang);

        // -(ReturnCode)setPrePostPANCtrlData:(Byte)pre post:(Byte)post;
        [Export("setPrePostPANCtrlData:post:")]
        ReturnCode SetPrePostPANCtrlData(byte pre, byte post);

        // -(ReturnCode)getPrePostPANCtrlData:(Byte **)pre post:(Byte **)post;
        [Export("getPrePostPANCtrlData:post:")]
        unsafe ReturnCode GetPrePostPANCtrlData(byte pre, byte post);

        // -(ReturnCode)getASCIIMaskData:(NSString **)mask;
        [Export("getASCIIMaskData:")]
        ReturnCode GetASCIIMaskData(out string mask);

        // -(ReturnCode)setASCIIMaskData:(NSString *)mask;
        [Export("setASCIIMaskData:")]
        ReturnCode SetASCIIMaskData(string mask);

        // -(ReturnCode)getICCConnector:(NSUInteger **)response;
        [Export("getICCConnector:")]
        unsafe ReturnCode GetICCConnector(nuint response);

        // -(ReturnCode)setICCConnector:(int)connector;
        [Export("setICCConnector:")]
        ReturnCode SetICCConnector(int connector);

        // -(ReturnCode)getBCDMaskData:(NSUInteger **)response;
        [Export("getBCDMaskData:")]
        unsafe ReturnCode GetBCDMaskData(nuint response);

        // -(ReturnCode)setBCDMaskData:(int)mask;
        [Export("setBCDMaskData:")]
        ReturnCode SetBCDMaskData(int mask);

        // -(ReturnCode)setDefaultICCGroupSettings;
        [Export("setDefaultICCGroupSettings")]
        ReturnCode SetDefaultICCGroupSettings();

        // -(ReturnCode)getDUKPTKeyVariant:(NSUInteger **)response;
        [Export("getDUKPTKeyVariant:")]
        unsafe ReturnCode GetDUKPTKeyVariant(nuint response);

        // -(ReturnCode)setDUKPTKeyVariant:(int)type;
        [Export("setDUKPTKeyVariant:")]
        ReturnCode SetDUKPTKeyVariant(int type);

        // -(ReturnCode)getDUKPTKeyEncryption:(NSUInteger **)response;
        [Export("getDUKPTKeyEncryption:")]
        unsafe ReturnCode GetDUKPTKeyEncryption(nuint response);

        // -(ReturnCode)setDUKPTKeyEncryption:(int)type;
        [Export("setDUKPTKeyEncryption:")]
        ReturnCode SetDUKPTKeyEncryption(int type);

        // -(ReturnCode)getFunctionKeyUniPay:(NSString **)response;
        [Export("getFunctionKeyUniPay:")]
        ReturnCode GetFunctionKeyUniPay(out string response);

        // -(ReturnCode)getFunctionKey;
        [Export("getFunctionKey")]
        ReturnCode FunctionKey { get; }

        // -(_Bool)isConnected:(IDT_DEVICE_Types)device;
        [Export("isConnected:")]
        bool IsConnected(IDT_DEVICE_Types device);

        // -(_Bool)anyConnected;
        [Export("anyConnected")]
        bool AnyConnected();

        // -(ReturnCode)setICCNotification:(BOOL)turnON;
        [Export("setICCNotification:")]
        ReturnCode SetICCNotification(bool turnON);

        // -(void)minWaitTime:(float)time;
        [Export("minWaitTime:")]
        void MinWaitTime(float time);

        // -(IDT_DEVICE_Types)getCurrentDevice;
        [Export("getCurrentDevice")]
        IDT_DEVICE_Types CurrentDevice { get; }

        // -(ReturnCode)getNextKSN:(NSData **)response;
        [Export("getNextKSN:")]
        ReturnCode GetNextKSN(ref IntPtr response);

        // -(ReturnCode)sendUniMagCommand:(UNIMAG_COMMAND_Types)command;
        [Export("sendUniMagCommand:")]
        ReturnCode SendUniMagCommand(UNIMAG_COMMAND_Types command);

        // -(ReturnCode)sendIDGCommand:(unsigned char)command subCommand:(unsigned char)subCommand data:(NSData *)data response:(NSData **)response;
        [Export("sendIDGCommand:subCommand:data:response:")]
        ReturnCode SendIDGCommand(byte command, byte subCommand, NSData data, ref IntPtr response);

        // -(BOOL)deviceIsConnected;
        [Export("deviceIsConnected")]
        bool DeviceIsConnected();

        // -(NSString *)getFirmwareVersionExtendedUnipay;
        [Export("getFirmwareVersionExtendedUnipay")]
        string FirmwareVersionExtendedUnipay { get; }

        // -(NSArray *)getMultiAPDU;
        [Export("getMultiAPDU")]
        //[Verify(MethodToProperty), Verify(StronglyTypedNSArray)]
        NSObject[] MultiAPDU { get; }

        // -(void)disableAutoAuthenticateTransaction:(BOOL)disable;
        [Export("disableAutoAuthenticateTransaction:")]
        void DisableAutoAuthenticateTransaction(bool disable);

        // -(ReturnCode)authenticateTransaction:(NSData *)tags;
        [Export("authenticateTransaction:")]
        ReturnCode AuthenticateTransaction(NSData tags);

        // -(ReturnCode)getLevelAndBaud:(NSString **)response;
        [Export("getLevelAndBaud:")]
        ReturnCode GetLevelAndBaud(out string response);

        // -(ReturnCode)callbackResponseLCD:(int)mode selection:(unsigned char)selection;
        [Export("callbackResponseLCD:selection:")]
        ReturnCode CallbackResponseLCD(int mode, byte selection);

        // -(ReturnCode)callbackResponsePIN:(EMV_PIN_MODE_Types)mode KSN:(NSData *)KSN PIN:(NSData *)PIN;
        [Export("callbackResponsePIN:KSN:PIN:")]
        ReturnCode CallbackResponsePIN(EMV_PIN_MODE_Types mode, NSData KSN, NSData PIN);

        // -(ReturnCode)setTerminalMajorConfiguration:(int)configuration;
        [Export("setTerminalMajorConfiguration:")]
        ReturnCode SetTerminalMajorConfiguration(int configuration);

        // -(ReturnCode)getTerminalMajorConfiguration:(NSUInteger **)configuration;
        [Export("getTerminalMajorConfiguration:")]
        unsafe ReturnCode GetTerminalMajorConfiguration(nuint configuration);

        // -(void)assignDelegate2:(id<IDT_Device_Delegate>)del;
        [Export("assignDelegate2:")]
        void AssignDelegate2(IDT_Device_Delegate del);

        // -(void)assignBypassDelegate:(id<IDT_Device_Delegate>)del;
        [Export("assignBypassDelegate:")]
        void AssignBypassDelegate(IDT_Device_Delegate del);

        // -(ReturnCode)exchangeMultiAPDU:(NSArray *)dataAPDU response:(NSData **)response;
        [Export("exchangeMultiAPDU:response:")]
        //[Verify(StronglyTypedNSArray)]
        ReturnCode ExchangeMultiAPDU(NSObject[] dataAPDU, ref IntPtr response);

        // +(NSString *)getResourceBundleVersion;
        [Static]
        [Export("getResourceBundleVersion")]
        string ResourceBundleVersion { get; }

        // -(void)attemptConnect;
        [Export("attemptConnect")]
        void AttemptConnect();

        // -(void)loopCardCheck;
        [Export("loopCardCheck")]
        void LoopCardCheck();

        // -(ReturnCode)pingVivoTech;
        [Export("pingVivoTech")]
        ReturnCode PingVivoTech();

        // -(NSData *)grsiP2Command:(unsigned char)command statusCode:(unsigned char)status data:(NSData *)d1;
        [Export("grsiP2Command:statusCode:data:")]
        NSData GrsiP2Command(byte command, byte status, NSData d1);

        // -(ReturnCode)setPassThrough:(BOOL)enablePassThrough;
        [Export("setPassThrough:")]
        ReturnCode SetPassThrough(bool enablePassThrough);

        // -(NSMutableArray *)multiAPP:(NSArray *)AIDS;
        [Export("multiAPP:")]
        //[Verify(StronglyTypedNSArray)]
        NSMutableArray MultiAPP(NSString[] AIDS);

        // -(NSMutableArray *)multiFile:(NSArray *)apduArray;
        [Export("multiFile:")]
        //[Verify(StronglyTypedNSArray)]
        NSMutableArray MultiFile(NSString[] apduArray);

        // -(NSDictionary *)getEncryptedUniPayTags;
        [Export("getEncryptedUniPayTags")]
        NSDictionary EncryptedUniPayTags { get; }

        // -(NSDictionary *)getMaskedUniPayTags;
        [Export("getMaskedUniPayTags")]
        NSDictionary MaskedUniPayTags { get; }

        // -(ReturnCode)startRKI;
        [Export("startRKI")]
        ReturnCode StartRKI();

        // -(void)setEncryptedUniPay:(BOOL)isEncrypted;
        [Export("setEncryptedUniPay:")]
        void SetEncryptedUniPay(bool isEncrypted);

        // -(ReturnCode)loadDUKPTKey:(DUKPT_KEY_Type)type ksn:(NSString *)hexKSN initialKey:(NSString *)hexInitKey;
        [Export("loadDUKPTKey:ksn:initialKey:")]
        ReturnCode LoadDUKPTKey(DUKPT_KEY_Type type, string hexKSN, string hexInitKey);

        // +(IDTEMVData *)checkCID82:(IDTEMVData *)card;
        [Static]
        [Export("checkCID82:")]
        IDTEMVData CheckCID82(IDTEMVData card);

        // +(void)cancelM_APDU;
        [Static]
        [Export("cancelM_APDU")]
        void CancelM_APDU();

        // -(ReturnCode)ctls_getConfigurationGroup:(int)group response:(NSDictionary **)response;
        [Export("ctls_getConfigurationGroup:response:")]
        ReturnCode Ctls_getConfigurationGroup(int group, out NSDictionary response);

        // -(ReturnCode)ctls_removeAllCAPK;
        [Export("ctls_removeAllCAPK")]
        ReturnCode Ctls_removeAllCAPK();

        // -(ReturnCode)ctls_removeApplicationData:(NSString *)AID;
        [Export("ctls_removeApplicationData:")]
        ReturnCode Ctls_removeApplicationData(string AID);

        // -(ReturnCode)ctls_removeCAPK:(NSData *)capk;
        [Export("ctls_removeCAPK:")]
        ReturnCode Ctls_removeCAPK(NSData capk);

        // -(ReturnCode)ctls_removeConfigurationGroup:(int)group;
        [Export("ctls_removeConfigurationGroup:")]
        ReturnCode Ctls_removeConfigurationGroup(int group);

        // -(ReturnCode)ctls_retrieveAIDList:(NSArray **)response;
        [Export("ctls_retrieveAIDList:")]
        //[Verify(StronglyTypedNSArray)]
        ReturnCode Ctls_retrieveAIDList(out NSObject[] response);

        // -(ReturnCode)ctls_retrieveApplicationData:(NSString *)AID response:(NSDictionary **)response;
        [Export("ctls_retrieveApplicationData:response:")]
        ReturnCode Ctls_retrieveApplicationData(string AID, out NSDictionary response);

        // -(ReturnCode)ctls_retrieveCAPK:(NSData *)capk key:(NSData **)key;
        [Export("ctls_retrieveCAPK:key:")]
        ReturnCode Ctls_retrieveCAPK(NSData capk, ref IntPtr key);

        // -(ReturnCode)ctls_retrieveCAPKList:(NSArray **)keys;
        [Export("ctls_retrieveCAPKList:")]
        //[Verify(StronglyTypedNSArray)]
        ReturnCode Ctls_retrieveCAPKList(out NSString[] keys);

        // -(ReturnCode)ctls_retrieveTerminalData:(NSData **)tlv;
        [Export("ctls_retrieveTerminalData:")]
        ReturnCode Ctls_retrieveTerminalData(ref IntPtr tlv);

        // -(ReturnCode)ctls_setApplicationData:(NSData *)tlv;
        [Export("ctls_setApplicationData:")]
        ReturnCode Ctls_setApplicationData(NSData tlv);

        // -(ReturnCode)ctls_setCAPK:(NSData *)key;
        [Export("ctls_setCAPK:")]
        ReturnCode Ctls_setCAPK(NSData key);

        // -(ReturnCode)ctls_setConfigurationGroup:(NSData *)tlv;
        [Export("ctls_setConfigurationGroup:")]
        ReturnCode Ctls_setConfigurationGroup(NSData tlv);

        // -(ReturnCode)ctls_setTerminalData:(NSData *)tlv;
        [Export("ctls_setTerminalData:")]
        ReturnCode Ctls_setTerminalData(NSData tlv);

        // -(ReturnCode)ctls_startTransaction:(double)amount type:(int)type timeout:(int)timeout tags:(NSMutableDictionary *)tags;
        [Export("ctls_startTransaction:type:timeout:tags:")]
        ReturnCode Ctls_startTransaction(double amount, int type, int timeout, NSMutableDictionary tags);

        // -(ReturnCode)emv_cancelTransaction;
        [Export("emv_cancelTransaction")]
        ReturnCode Emv_cancelTransaction();

        // -(ReturnCode)device_cancelTransaction;
        [Export("device_cancelTransaction")]
        ReturnCode Device_cancelTransaction();

        // -(ReturnCode)felica_authentication:(NSData *)key;
        [Export("felica_authentication:")]
        ReturnCode Felica_authentication(NSData key);

        // -(ReturnCode)felica_readWithMac:(int)numBlocks blockList:(NSData *)blockList blocks:(NSData **)blocks;
        [Export("felica_readWithMac:blockList:blocks:")]
        ReturnCode Felica_readWithMac(int numBlocks, NSData blockList, ref IntPtr blocks);

        // -(ReturnCode)felica_writeWithMac:(int)blockNumber data:(NSData *)data;
        [Export("felica_writeWithMac:data:")]
        ReturnCode Felica_writeWithMac(int blockNumber, NSData data);

        // -(ReturnCode)felica_read:(NSData *)serviceCode numBlocks:(int)numBlocks blockList:(NSData *)blockList blocks:(NSData **)blocks;
        [Export("felica_read:numBlocks:blockList:blocks:")]
        ReturnCode Felica_read(NSData serviceCode, int numBlocks, NSData blockList, ref IntPtr blocks);

        // -(ReturnCode)felica_write:(NSData *)serviceCode blockList:(NSData *)blockList data:(NSData *)data statusFlag:(NSData **)statusFlag;
        [Export("felica_write:blockList:data:statusFlag:")]
        ReturnCode Felica_write(NSData serviceCode, NSData blockList, NSData data, ref IntPtr statusFlag);

        // -(ReturnCode)felica_nfcCommand:(NSData *)request response:(NSData **)response;
        [Export("felica_nfcCommand:response:")]
        ReturnCode Felica_nfcCommand(NSData request, ref IntPtr response);
    }

    // @protocol IDT_BTMag_Delegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IDT_BTMag_Delegate
    {
        // @optional -(void)deviceConnected;
        [Export("deviceConnected")]
        void DeviceConnected();

        // @optional -(void)deviceDisconnected;
        [Export("deviceDisconnected")]
        void DeviceDisconnected();

        // @optional -(void)dataInOutMonitor:(NSData *)data incoming:(BOOL)isIncoming;
        [Export("dataInOutMonitor:incoming:")]
        void DataInOutMonitor(NSData data, bool isIncoming);

        // @optional -(void)swipeMSRData:(IDTMSRData *)cardData;
        [Export("swipeMSRData:")]
        void SwipeMSRData(IDTMSRData cardData);
    }

    // @protocol IDT_BTPay_Delegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IDT_BTPay_Delegate
    {
        // @optional -(void)deviceConnected;
        [Export("deviceConnected")]
        void DeviceConnected();

        // @optional -(void)deviceDisconnected;
        [Export("deviceDisconnected")]
        void DeviceDisconnected();

        // @optional -(void)dataInOutMonitor:(NSData *)data incoming:(BOOL)isIncoming;
        [Export("dataInOutMonitor:incoming:")]
        void DataInOutMonitor(NSData data, bool isIncoming);

        // @optional -(void)swipeMSRData:(IDTMSRData *)cardData;
        [Export("swipeMSRData:")]
        void SwipeMSRData(IDTMSRData cardData);

        // @optional -(void)emvTransactionData:(IDTEMVData *)emvData errorCode:(int)error;
        [Export("emvTransactionData:errorCode:")]
        void EmvTransactionData(IDTEMVData emvData, int error);

        // @optional -(void)pinpadData:(NSData *)value keySN:(NSData *)KSN event:(EVENT_PINPAD_Types)event;
        [Export("pinpadData:keySN:event:")]
        void PinpadData(NSData value, NSData KSN, EVENT_PINPAD_Types @event);
    }

    // @protocol IDT_NEO2_Delegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IDT_NEO2_Delegate
    {
        // @optional -(void)deviceConnected;
        [Export("deviceConnected")]
        void DeviceConnected();

        // @optional -(void)deviceDisconnected;
        [Export("deviceDisconnected")]
        void DeviceDisconnected();

        // @optional -(void)dataInOutMonitor:(NSData *)data incoming:(BOOL)isIncoming;
        [Export("dataInOutMonitor:incoming:")]
        void DataInOutMonitor(NSData data, bool isIncoming);

        // @optional -(void)swipeMSRData:(IDTMSRData *)cardData;
        [Export("swipeMSRData:")]
        void SwipeMSRData(IDTMSRData cardData);

        // @optional -(void)deviceMessage:(NSString *)message;
        [Export("deviceMessage:")]
        void DeviceMessage(string message);

        // @optional -(void)pinpadData:(NSData *)value keySN:(NSData *)KSN event:(EVENT_PINPAD_Types)event;
        [Export("pinpadData:keySN:event:")]
        void PinpadData(NSData value, NSData KSN, EVENT_PINPAD_Types @event);

        // @optional -(void)lcdDisplay:(int)mode lines:(NSArray *)lines;
        [Export("lcdDisplay:lines:")]
        //[Verify(StronglyTypedNSArray)]
        void LcdDisplay(int mode, NSString[] lines);

        // @optional -(void)emvTransactionData:(IDTEMVData *)emvData errorCode:(int)error;
        [Export("emvTransactionData:errorCode:")]
        void EmvTransactionData(IDTEMVData emvData, int error);
    }


    // @protocol IDT_UniMag_Delegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IDT_UniMag_Delegate
    {
        // @optional -(void)deviceConnected;
        [Export("deviceConnected")]
        void DeviceConnected();

        // @optional -(void)deviceDisconnected;
        [Export("deviceDisconnected")]
        void DeviceDisconnected();

        // @optional -(void)plugStatusChange:(BOOL)deviceInserted;
        [Export("plugStatusChange:")]
        void PlugStatusChange(bool deviceInserted);

        // @optional -(void)dataInOutMonitor:(NSData *)data incoming:(BOOL)isIncoming;
        [Export("dataInOutMonitor:incoming:")]
        void DataInOutMonitor(NSData data, bool isIncoming);

        // @optional -(void)swipeMSRData:(IDTMSRData *)cardData;
        [Export("swipeMSRData:")]
        void SwipeMSRData(IDTMSRData cardData);

        // @optional -(void)deviceMessage:(NSString *)message;
        [Export("deviceMessage:")]
        void DeviceMessage(string message);
    }

   
    // @protocol IDT_UniPay_Delegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IDT_UniPay_Delegate
    {
        // @optional -(void)deviceConnected;
        [Export("deviceConnected")]
        void DeviceConnected();

        // @optional -(void)deviceDisconnected;
        [Export("deviceDisconnected")]
        void DeviceDisconnected();

        // @optional -(void)plugStatusChange:(BOOL)deviceInserted;
        [Export("plugStatusChange:")]
        void PlugStatusChange(bool deviceInserted);

        // @optional -(void)dataInOutMonitor:(NSData *)data incoming:(BOOL)isIncoming;
        [Export("dataInOutMonitor:incoming:")]
        void DataInOutMonitor(NSData data, bool isIncoming);

        // @optional -(void)swipeMSRData:(IDTMSRData *)cardData;
        [Export("swipeMSRData:")]
        void SwipeMSRData(IDTMSRData cardData);

        // @optional -(void)deviceMessage:(NSString *)message;
        [Export("deviceMessage:")]
        void DeviceMessage(string message);

        // @optional -(void)eventFunctionICC:(Byte)nICC_Attached;
        [Export("eventFunctionICC:")]
        void EventFunctionICC(byte nICC_Attached);
    }

    // @protocol IDT_UniPayI_V_Delegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IDT_UniPayI_V_Delegate
    {
        // @optional -(void)deviceConnected;
        [Export("deviceConnected")]
        void DeviceConnected();

        // @optional -(void)deviceDisconnected;
        [Export("deviceDisconnected")]
        void DeviceDisconnected();

        // @optional -(void)plugStatusChange:(BOOL)deviceInserted;
        [Export("plugStatusChange:")]
        void PlugStatusChange(bool deviceInserted);

        // @optional -(void)dataInOutMonitor:(NSData *)data incoming:(BOOL)isIncoming;
        [Export("dataInOutMonitor:incoming:")]
        void DataInOutMonitor(NSData data, bool isIncoming);

        // @optional -(void)swipeMSRData:(IDTMSRData *)cardData;
        [Export("swipeMSRData:")]
        void SwipeMSRData(IDTMSRData cardData);

        // @optional -(void)deviceMessage:(NSString *)message;
        [Export("deviceMessage:")]
        void DeviceMessage(string message);

        // @optional -(void)lcdDisplay:(int)mode lines:(NSArray *)lines;
        [Export("lcdDisplay:lines:")]
        //[Verify(StronglyTypedNSArray)]
        void LcdDisplay(int mode, NSString[] lines);

        // @optional -(void)pinRequest:(EMV_PIN_MODE_Types)mode key:(NSData *)key PAN:(NSData *)PAN startTO:(int)startTO intervalTO:(int)intervalTO language:(NSString *)language;
        [Export("pinRequest:key:PAN:startTO:intervalTO:language:")]
        void PinRequest(EMV_PIN_MODE_Types mode, NSData key, NSData PAN, int startTO, int intervalTO, string language);

        // @optional -(void)emvTransactionData:(IDTEMVData *)emvData errorCode:(int)error;
        [Export("emvTransactionData:errorCode:")]
        void EmvTransactionData(IDTEMVData emvData, int error);
    }

    // @protocol IDT_VP3300_Delegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IDT_VP3300_Delegate
    {
        // @optional -(void)deviceConnected;
        [Export("deviceConnected")]
        void DeviceConnected();

        // @optional -(void)deviceDisconnected;
        [Export("deviceDisconnected")]
        void DeviceDisconnected();

        // @optional -(void)plugStatusChange:(BOOL)deviceInserted;
        [Export("plugStatusChange:")]
        void PlugStatusChange(bool deviceInserted);

        // @optional -(void)dataInOutMonitor:(NSData *)data incoming:(BOOL)isIncoming;
        [Export("dataInOutMonitor:incoming:")]
        void DataInOutMonitor(NSData data, bool isIncoming);

        // @optional -(void)swipeMSRData:(IDTMSRData *)cardData;
        [Export("swipeMSRData:")]
        void SwipeMSRData(IDTMSRData cardData);

        // @optional -(void)deviceMessage:(NSString *)message;
        [Export("deviceMessage:")]
        void DeviceMessage(string message);

        // @optional -(void)bypassData:(NSData *)data;
        [Export("bypassData:")]
        void BypassData(NSData data);

        // @optional -(void)lcdDisplay:(int)mode lines:(NSArray *)lines;
        [Export("lcdDisplay:lines:")]
        //[Verify(StronglyTypedNSArray)]
        void LcdDisplay(int mode, NSString[] lines);

        // @optional -(void)pinRequest:(EMV_PIN_MODE_Types)mode key:(NSData *)key PAN:(NSData *)PAN startTO:(int)startTO intervalTO:(int)intervalTO language:(NSString *)language;
        [Export("pinRequest:key:PAN:startTO:intervalTO:language:")]
        void PinRequest(EMV_PIN_MODE_Types mode, NSData key, NSData PAN, int startTO, int intervalTO, string language);

        // @optional -(void)emvTransactionData:(IDTEMVData *)emvData errorCode:(int)error;
        [Export("emvTransactionData:errorCode:")]
        void EmvTransactionData(IDTEMVData emvData, int error);
    }

    // @interface IDT_VP3300 : NSObject <IDT_Device_Delegate>
    [BaseType(typeof(NSObject))]
    interface IDT_VP3300 : IDT_Device_Delegate
    {
        [Wrap("WeakDelegate")]
        IDT_VP3300_Delegate Delegate { get; set; }

        // @property (strong) id<IDT_VP3300_Delegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Strong)]
        NSObject WeakDelegate { get; set; }

        [Wrap("WeakBypassDelegate")]
        IDT_VP3300_Delegate BypassDelegate { get; set; }

        // @property (strong) id<IDT_VP3300_Delegate> bypassDelegate;
        [NullAllowed, Export("bypassDelegate", ArgumentSemantic.Strong)]
        NSObject WeakBypassDelegate { get; set; }

        // +(NSString *)SDK_version;
        [Static]
        [Export("SDK_version")]
        string SDK_version();

        // +(IDT_VP3300 *)sharedController;
        [Static]
        [Export("sharedController")]
        IDT_VP3300 SharedController();

        // -(void)close;
        [Export("close")]
        void Close();

        // -(void)device_connectToUSB;
        [Export("device_connectToUSB")]
        void Device_connectToUSB();

        // -(void)device_disconnectBLE;
        [Export("device_disconnectBLE")]
        void Device_disconnectBLE();

        // -(ReturnCode)ctls_cancelTransaction;
        [Export("ctls_cancelTransaction")]
        ReturnCode Ctls_cancelTransaction();

        // -(ReturnCode)emv_cancelTransaction;
        [Export("emv_cancelTransaction")]
        ReturnCode Emv_cancelTransaction();

        // -(ReturnCode)device_cancelTransaction;
        [Export("device_cancelTransaction")]
        ReturnCode Device_cancelTransaction();

        // -(ReturnCode)ctls_getConfigurationGroup:(int)group response:(NSDictionary **)response;
        [Export("ctls_getConfigurationGroup:response:")]
        ReturnCode Ctls_getConfigurationGroup(int group, out NSDictionary response);

        // -(void)processBypassResponse:(NSData *)data;
        [Export("processBypassResponse:")]
        void ProcessBypassResponse(NSData data);

        // -(void)assignBypassDelegate:(id<IDT_VP3300_Delegate>)del;
        [Export("assignBypassDelegate:")]
        void AssignBypassDelegate(IDT_VP3300_Delegate del);

        // -(ReturnCode)ctls_removeAllCAPK;
        [Export("ctls_removeAllCAPK")]
        ReturnCode Ctls_removeAllCAPK();

        // -(ReturnCode)ctls_removeApplicationData:(NSString *)AID;
        [Export("ctls_removeApplicationData:")]
        ReturnCode Ctls_removeApplicationData(string AID);

        // -(ReturnCode)ctls_removeCAPK:(NSData *)capk;
        [Export("ctls_removeCAPK:")]
        ReturnCode Ctls_removeCAPK(NSData capk);

        // -(ReturnCode)ctls_removeConfigurationGroup:(int)group;
        [Export("ctls_removeConfigurationGroup:")]
        ReturnCode Ctls_removeConfigurationGroup(int group);

        // -(ReturnCode)ctls_retrieveAIDList:(NSArray **)response;
        [Export("ctls_retrieveAIDList:")]
        //[Verify(StronglyTypedNSArray)]
        ReturnCode Ctls_retrieveAIDList(out NSObject[] response);

        // -(ReturnCode)ctls_retrieveApplicationData:(NSString *)AID response:(NSDictionary **)response;
        [Export("ctls_retrieveApplicationData:response:")]
        ReturnCode Ctls_retrieveApplicationData(string AID, out NSDictionary response);

        // -(ReturnCode)ctls_retrieveCAPK:(NSData *)capk key:(NSData **)key;
        [Export("ctls_retrieveCAPK:key:")]
        ReturnCode Ctls_retrieveCAPK(NSData capk, ref IntPtr key);

        // -(ReturnCode)ctls_retrieveCAPKList:(NSArray **)keys;
        [Export("ctls_retrieveCAPKList:")]
        //[Verify(StronglyTypedNSArray)]
        ReturnCode Ctls_retrieveCAPKList(out NSString[] keys);

        // -(ReturnCode)ctls_retrieveTerminalData:(NSData **)tlv;
        [Export("ctls_retrieveTerminalData:")]
        ReturnCode Ctls_retrieveTerminalData(ref IntPtr tlv);

        // -(ReturnCode)ctls_setApplicationData:(NSData *)tlv;
        [Export("ctls_setApplicationData:")]
        ReturnCode Ctls_setApplicationData(NSData tlv);

        // -(ReturnCode)ctls_setCAPK:(NSData *)key;
        [Export("ctls_setCAPK:")]
        ReturnCode Ctls_setCAPK(NSData key);

        // -(ReturnCode)ctls_setConfigurationGroup:(NSData *)tlv;
        [Export("ctls_setConfigurationGroup:")]
        ReturnCode Ctls_setConfigurationGroup(NSData tlv);

        // -(ReturnCode)ctls_setTerminalData:(NSData *)tlv;
        [Export("ctls_setTerminalData:")]
        ReturnCode Ctls_setTerminalData(NSData tlv);

        // -(ReturnCode)ctls_startTransaction:(double)amount type:(int)type timeout:(int)timeout tags:(NSMutableDictionary *)tags;
        [Export("ctls_startTransaction:type:timeout:tags:")]
        ReturnCode Ctls_startTransaction(double amount, int type, int timeout, NSMutableDictionary tags);

        //TODO Drh Is this really a duplicate ????
        // -(ReturnCode)ctls_startTransaction;
        //[Export("ctls_startTransaction")]
        ////[Verify(MethodToProperty)]
        //ReturnCode Ctls_startTransaction { get; }

        // -(ReturnCode)device_cancelConnectToAudioReader;
        [Export("device_cancelConnectToAudioReader")]
        ReturnCode Device_cancelConnectToAudioReader();

        // -(ReturnCode)device_connectToAudioReader;
        [Export("device_connectToAudioReader")]
        ReturnCode Device_connectToAudioReader();

        // -(ReturnCode)device_getFirmwareVersion:(NSString **)response;
        [Export("device_getFirmwareVersion:")]
        ReturnCode Device_getFirmwareVersion(out string response);

        // -(_Bool)device_enableBLEDeviceSearch:(NSUUID *)identifier;
        [Export("device_enableBLEDeviceSearch:")]
        bool Device_enableBLEDeviceSearch(NSUuid identifier);

        // -(NSString *)device_getBLEFriendlyName;
        [Export("device_getBLEFriendlyName")]
        string Device_getBLEFriendlyName();

        // -(void)device_setBLEFriendlyName:(NSString *)friendlyName;
        [Export("device_setBLEFriendlyName:")]
        void Device_setBLEFriendlyName(string friendlyName);

        // -(_Bool)device_disableBLEDeviceSearch;
        [Export("device_disableBLEDeviceSearch")]
        bool Device_disableBLEDeviceSearch();

        // -(NSUUID *)device_connectedBLEDevice;
        [Export("device_connectedBLEDevice")]
        NSUuid Device_connectedBLEDevice();

        // -(BOOL)device_isAudioReaderConnected;
        [Export("device_isAudioReaderConnected")]
        bool Device_isAudioReaderConnected();

        // -(ReturnCode)device_getAutoPollTransactionResults:(IDTEMVData **)result;
        [Export("device_getAutoPollTransactionResults:")]
        ReturnCode Device_getAutoPollTransactionResults(out IDTEMVData result);

        // -(NSString *)device_getResponseCodeString:(int)errorCode;
        [Export("device_getResponseCodeString:")]
        string Device_getResponseCodeString(int errorCode);

        // -(_Bool)device_isConnected:(IDT_DEVICE_Types)device;
        [Export("device_isConnected:")]
        bool Device_isConnected(IDT_DEVICE_Types device);

        // -(ReturnCode)device_sendIDGCommand:(unsigned char)command subCommand:(unsigned char)subCommand data:(NSData *)data response:(NSData **)response;
        [Export("device_sendIDGCommand:subCommand:data:response:")]
        ReturnCode Device_sendIDGCommand(byte command, byte subCommand, NSData data, ref IntPtr response);

        // -(ReturnCode)device_setAudioVolume:(float)val;
        [Export("device_setAudioVolume:")]
        ReturnCode Device_setAudioVolume(float val);

        // -(ReturnCode)device_setPassThrough:(BOOL)enablePassThrough;
        [Export("device_setPassThrough:")]
        ReturnCode Device_setPassThrough(bool enablePassThrough);

        // -(ReturnCode)device_setBurstMode:(int)mode;
        [Export("device_setBurstMode:")]
        ReturnCode Device_setBurstMode(int mode);

        // -(ReturnCode)device_setPollMode:(int)mode;
        [Export("device_setPollMode:")]
        ReturnCode Device_setPollMode(int mode);

        // -(ReturnCode)device_startRKI;
        [Export("device_startRKI")]
        ReturnCode Device_startRKI();

        // -(ReturnCode)emv_authenticateTransaction:(NSData *)tags;
        [Export("emv_authenticateTransaction:")]
        ReturnCode Emv_authenticateTransaction(NSData tags);

        // -(ReturnCode)emv_callbackResponseLCD:(int)mode selection:(unsigned char)selection;
        [Export("emv_callbackResponseLCD:selection:")]
        ReturnCode Emv_callbackResponseLCD(int mode, byte selection);

        // -(ReturnCode)emv_callbackResponsePIN:(EMV_PIN_MODE_Types)mode KSN:(NSData *)KSN PIN:(NSData *)PIN;
        [Export("emv_callbackResponsePIN:KSN:PIN:")]
        ReturnCode Emv_callbackResponsePIN(EMV_PIN_MODE_Types mode, NSData KSN, NSData PIN);

        // -(ReturnCode)emv_completeOnlineEMVTransaction:(BOOL)isSuccess hostResponseTags:(NSData *)tags;
        [Export("emv_completeOnlineEMVTransaction:hostResponseTags:")]
        ReturnCode Emv_completeOnlineEMVTransaction(bool isSuccess, NSData tags);

        // -(void)emv_disableAutoAuthenticateTransaction:(BOOL)disable;
        [Export("emv_disableAutoAuthenticateTransaction:")]
        void Emv_disableAutoAuthenticateTransaction(bool disable);

        // -(ReturnCode)emv_getEMVL2Version:(NSString **)response;
        [Export("emv_getEMVL2Version:")]
        ReturnCode Emv_getEMVL2Version(out string response);

        // -(ReturnCode)emv_removeApplicationData:(NSString *)AID;
        [Export("emv_removeApplicationData:")]
        ReturnCode Emv_removeApplicationData(string AID);

        // -(ReturnCode)emv_removeCAPK:(NSString *)rid index:(NSString *)index;
        [Export("emv_removeCAPK:index:")]
        ReturnCode Emv_removeCAPK(string rid, string index);

        // -(ReturnCode)emv_setTerminalMajorConfiguration:(int)configuration;
        [Export("emv_setTerminalMajorConfiguration:")]
        ReturnCode Emv_setTerminalMajorConfiguration(int configuration);

        // -(ReturnCode)emv_getTerminalMajorConfiguration:(NSUInteger **)configuration;
        [Export("emv_getTerminalMajorConfiguration:")]
        unsafe ReturnCode Emv_getTerminalMajorConfiguration(nuint configuration);

        // -(ReturnCode)emv_removeCRLList;
        [Export("emv_removeCRLList")]
        ReturnCode Emv_removeCRLList();

        // -(ReturnCode)emv_removeTerminalData;
        [Export("emv_removeTerminalData")]
        ReturnCode Emv_removeTerminalData();

        // -(ReturnCode)emv_retrieveAIDList:(NSArray **)response;
        [Export("emv_retrieveAIDList:")]
        //[Verify(StronglyTypedNSArray)]
        ReturnCode Emv_retrieveAIDList(out NSObject[] response);

        // -(ReturnCode)emv_retrieveApplicationData:(NSString *)AID response:(NSDictionary **)responseAID;
        [Export("emv_retrieveApplicationData:response:")]
        ReturnCode Emv_retrieveApplicationData(string AID, out NSDictionary responseAID);

        // -(ReturnCode)emv_retrieveCAPK:(NSString *)rid index:(NSString *)index response:(CAKey **)response;
        [Export("emv_retrieveCAPK:index:response:")]
        unsafe ReturnCode Emv_retrieveCAPK(string rid, string index, CAKey response);

        // -(ReturnCode)emv_retrieveCAPKFile:(NSString *)rid index:(NSString *)index response:(NSData **)response;
        [Export("emv_retrieveCAPKFile:index:response:")]
        ReturnCode Emv_retrieveCAPKFile(string rid, string index, ref IntPtr response);

        // -(ReturnCode)emv_retrieveCAPKList:(NSArray **)response;
        [Export("emv_retrieveCAPKList:")]
        //[Verify(StronglyTypedNSArray)]
        ReturnCode Emv_retrieveCAPKList(out NSObject[] response);

        // -(ReturnCode)emv_retrieveCRLList:(NSMutableArray **)response;
        [Export("emv_retrieveCRLList:")]
        ReturnCode Emv_retrieveCRLList(out NSMutableArray response);

        // -(ReturnCode)emv_retrieveTerminalData:(NSDictionary **)responseData;
        [Export("emv_retrieveTerminalData:")]
        ReturnCode Emv_retrieveTerminalData(out NSDictionary responseData);

        // -(ReturnCode)emv_retrieveTransactionResult:(NSData *)tags retrievedTags:(NSDictionary **)retrievedTags;
        [Export("emv_retrieveTransactionResult:retrievedTags:")]
        ReturnCode Emv_retrieveTransactionResult(NSData tags, out NSDictionary retrievedTags);

        // -(ReturnCode)emv_setApplicationData:(NSString *)aidName configData:(NSDictionary *)data;
        [Export("emv_setApplicationData:configData:")]
        ReturnCode Emv_setApplicationData(string aidName, NSDictionary data);

        // -(ReturnCode)emv_setCAPK:(CAKey)key;
        [Export("emv_setCAPK:")]
        ReturnCode Emv_setCAPK(CAKey key);

        // -(ReturnCode)emv_setCAPKFile:(NSData *)file;
        [Export("emv_setCAPKFile:")]
        ReturnCode Emv_setCAPKFile(NSData file);

        // -(ReturnCode)emv_setCRLEntries:(NSData *)data;
        [Export("emv_setCRLEntries:")]
        ReturnCode Emv_setCRLEntries(NSData data);

        // -(ReturnCode)emv_setTerminalData:(NSDictionary *)data;
        [Export("emv_setTerminalData:")]
        ReturnCode Emv_setTerminalData(NSDictionary data);

        // -(ReturnCode)emv_startTransaction:(double)amount amtOther:(double)amtOther type:(int)type timeout:(int)timeout tags:(NSData *)tags forceOnline:(BOOL)forceOnline fallback:(BOOL)fallback;
        [Export("emv_startTransaction:amtOther:type:timeout:tags:forceOnline:fallback:")]
        ReturnCode Emv_startTransaction(double amount, double amtOther, int type, int timeout, NSData tags, bool forceOnline, bool fallback);

        // -(ReturnCode)config_getSerialNumber:(NSString **)response;
        [Export("config_getSerialNumber:")]
        ReturnCode Config_getSerialNumber(out string response);

        // -(ReturnCode)icc_exchangeAPDU:(NSData *)dataAPDU response:(APDUResponse **)response;
        [Export("icc_exchangeAPDU:response:")]
        ReturnCode Icc_exchangeAPDU(NSData dataAPDU, out APDUResponse response);

        // -(ReturnCode)icc_getICCReaderStatus:(ICCReaderStatus **)readerStatus;
        [Export("icc_getICCReaderStatus:")]
        unsafe ReturnCode Icc_getICCReaderStatus(ICCReaderStatus readerStatus);

        // -(ReturnCode)icc_powerOnICC:(NSData **)response;
        [Export("icc_powerOnICC:")]
        ReturnCode Icc_powerOnICC(ref IntPtr response);

        // -(ReturnCode)icc_powerOffICC:(NSString **)error;
        [Export("icc_powerOffICC:")]
        ReturnCode Icc_powerOffICC(out string error);

        // -(ReturnCode)msr_cancelMSRSwipe;
        [Export("msr_cancelMSRSwipe")]
        ReturnCode Msr_cancelMSRSwipe();

        // -(ReturnCode)msr_startMSRSwipe;
        [Export("msr_startMSRSwipe")]
        ReturnCode Msr_startMSRSwipe();

        // -(_Bool)isConnected;
        [Export("isConnected")]
        bool IsConnected();

        // -(ReturnCode)device_startTransaction:(double)amount amtOther:(double)amtOther type:(int)type timeout:(int)timeout tags:(NSData *)tags forceOnline:(BOOL)forceOnline fallback:(BOOL)fallback;
        [Export("device_startTransaction:amtOther:type:timeout:tags:forceOnline:fallback:")]
        ReturnCode Device_startTransaction(double amount, double amtOther, int type, int timeout, NSData tags, bool forceOnline, bool fallback);
    }

    // @protocol IDT_iMag_Delegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IDT_iMag_Delegate
    {
        // @optional -(void)deviceConnected;
        [Export("deviceConnected")]
        void DeviceConnected();

        // @optional -(void)deviceDisconnected;
        [Export("deviceDisconnected")]
        void DeviceDisconnected();

        // @optional -(void)dataInOutMonitor:(NSData *)data incoming:(BOOL)isIncoming;
        [Export("dataInOutMonitor:incoming:")]
        void DataInOutMonitor(NSData data, bool isIncoming);

        // @optional -(void)swipeMSRData:(IDTMSRData *)cardData;
        [Export("swipeMSRData:")]
        void SwipeMSRData(IDTMSRData cardData);
    }

    //Clearent

// @interface ClearentClockConfigurator : NSObject
    [BaseType(typeof(NSObject))]
    interface ClearentClockConfigurator
    {
        // @property (nonatomic) int * sharedController;
        [Export("sharedController", ArgumentSemantic.Assign)]
        IDT_VP3300 SharedController { get; set; }

        // -(id)initWithIdtechSharedController:(id)sharedController;
        [Export("initWithIdtechSharedController:")]
        IntPtr Constructor(NSObject sharedController);

        // -(int)initClock;
        [Export("initClock")]
        int InitClock();

        // -(NSData *)getClockDateAsYYYYMMDD;
        [Export("getClockDateAsYYYYMMDD")]
        NSData ClockDateAsYYYYMMDD { get; }

        // -(NSData *)getClockTimeAsHHMM;
        [Export("getClockTimeAsHHMM")]
        NSData ClockTimeAsHHMM { get; }
    }

    // @interface ClearentConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    interface ClearentConfiguration
    {
        // @property (getter = isValid, assign) BOOL valid;
        [Export("valid")]
        bool Valid { [Bind("isValid")] get; set; }

        // @property (nonatomic) NSDictionary * rawJson;
        [Export("rawJson", ArgumentSemantic.Assign)]
        NSDictionary RawJson { get; set; }

        // @property (nonatomic) NSDictionary * contactAids;
        [Export("contactAids", ArgumentSemantic.Assign)]
        NSDictionary ContactAids { get; set; }

        // @property (nonatomic) NSDictionary * publicKeys;
        [Export("publicKeys", ArgumentSemantic.Assign)]
        NSDictionary PublicKeys { get; set; }

        // -(id)initWithJson:(NSDictionary *)rawJson;
        [Export("initWithJson:")]
        IntPtr Constructor(NSDictionary rawJson);
    }

    // @interface ClearentEmvConfigurator : NSObject
    [BaseType(typeof(NSObject))]
    interface ClearentEmvConfigurator
    {
        // @property (nonatomic) int * sharedController;
        [Export("sharedController", ArgumentSemantic.Assign)]
        IDT_VP3300 SharedController { get; set; }

        // -(id)initWithIdtechSharedController:(id)sharedController;
        [Export("initWithIdtechSharedController:")]
        IntPtr Constructor(NSObject sharedController);

        // -(NSString *)configure:(ClearentConfiguration *)clearentConfiguration;
        [Export("configure:")]
        string Configure(ClearentConfiguration clearentConfiguration);
    }

    // @interface ClearentConfigurator : NSObject
    [BaseType(typeof(NSObject))]
    interface ClearentConfigurator
    {
        // @property (nonatomic) NSString * baseUrl;
        [Export("baseUrl")]
        string BaseUrl { get; set; }

        // @property (nonatomic) NSString * publicKey;
        [Export("publicKey")]
        string PublicKey { get; set; }

        // @property (nonatomic) SEL selector;
        [Export("selector", ArgumentSemantic.Assign)]
        Selector Selector { get; set; }

        // @property (nonatomic) id callbackObject;
        [Export("callbackObject", ArgumentSemantic.Assign)]
        NSObject CallbackObject { get; set; }

        // @property (getter = isConfigured, assign) BOOL configured;
        [Export("configured")]
        bool Configured { [Bind("isConfigured")] get; set; }

        // @property (nonatomic) int * sharedController;
        [Export("sharedController", ArgumentSemantic.Assign)]
        IDT_VP3300 SharedController { get; set; }

        // -(id)init:(NSString *)clearentBaseUrl publicKey:(NSString *)publicKey callbackObject:(id)callbackObject withSelector:(SEL)selector sharedController:(id)sharedController;
        [Export("init:publicKey:callbackObject:withSelector:sharedController:")]
        IntPtr Constructor(string clearentBaseUrl, string publicKey, NSObject callbackObject, Selector selector, NSObject sharedController);

        // -(void)configure:(NSString *)kernelVersion deviceSerialNumber:(NSString *)deviceSerialNumber;
        [Export("configure:deviceSerialNumber:")]
        void Configure(string kernelVersion, string deviceSerialNumber);

        // -(void)configure:(NSDictionary *)jsonConfiguration;
        [Export("configure:")]
        void Configure(NSDictionary jsonConfiguration);

        // -(void)notify:(NSString *)message;
        [Export("notify:")]
        void Notify(string message);
    }

    // typedef void (^ClearentConfigFetcherResponse)(NSDictionary *);
    delegate void ClearentConfigFetcherResponse(NSDictionary arg0);

    // typedef void (^ClearentConfigFetcherTaskCompletionHandler)(NSData *, NSURLResponse *, NSError *);
    delegate void ClearentConfigFetcherTaskCompletionHandler(NSData arg0, NSUrlResponse arg1, NSError arg2);

    // @interface ClearentConfigFetcher : NSObject
    [BaseType(typeof(NSObject))]
    interface ClearentConfigFetcher
    {
        // @property (nonatomic) NSURLSession * session;
        [Export("session", ArgumentSemantic.Assign)]
        NSUrlSession Session { get; set; }

        // @property (nonatomic) NSString * baseUrl;
        [Export("baseUrl")]
        string BaseUrl { get; set; }

        // @property (nonatomic) NSString * publicKey;
        [Export("publicKey")]
        string PublicKey { get; set; }

        // @property (nonatomic) NSString * deviceSerialNumber;
        [Export("deviceSerialNumber")]
        string DeviceSerialNumber { get; set; }

        // @property (nonatomic) NSString * kernelVersion;
        [Export("kernelVersion")]
        string KernelVersion { get; set; }

        // -(id)init:(NSURLSession *)session baseUrl:(NSString *)baseUrl deviceSerialNumber:(NSString *)deviceSerialNumber kernelVersion:(NSString *)kernelVersion publicKey:(NSString *)publicKey;
        [Export("init:baseUrl:deviceSerialNumber:kernelVersion:publicKey:")]
        IntPtr Constructor(NSUrlSession session, string baseUrl, string deviceSerialNumber, string kernelVersion, string publicKey);

        // -(void)fetchConfiguration:(ClearentConfigFetcherResponse)callback;
        [Export("fetchConfiguration:")]
        void FetchConfiguration(ClearentConfigFetcherResponse callback);

        // -(NSMutableURLRequest *)createNSMutableURLRequest;
        [Export("createNSMutableURLRequest")]
        NSMutableUrlRequest CreateNSMutableURLRequest();

        // -(NSString *)createTargetUrl;
        [Export("createTargetUrl")]
        string CreateTargetUrl();
    }

    // @protocol Clearent_Public_IDTech_VP3300_Delegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface Clearent_Public_IDTech_VP3300_Delegate
    {
        // @required -(void)successfulTransactionToken:(NSString *)jsonString;
        [Abstract]
        [Export("successfulTransactionToken:")]
        void SuccessfulTransactionToken(string jsonString);

        // @optional -(void)deviceConnected;
        [Export("deviceConnected")]
        void DeviceConnected();

        // @optional -(void)deviceDisconnected;
        [Export("deviceDisconnected")]
        void DeviceDisconnected();

        // @optional -(void)plugStatusChange:(BOOL)deviceInserted;
        [Export("plugStatusChange:")]
        void PlugStatusChange(bool deviceInserted);

        // @optional -(void)deviceMessage:(NSString *)message;
        [Export("deviceMessage:")]
        void DeviceMessage(string message);

        // @optional -(void)lcdDisplay:(int)mode lines:(NSArray *)lines;
        [Export("lcdDisplay:lines:")]
        //[Verify(StronglyTypedNSArray)]
        void LcdDisplay(int mode, NSString[] lines);

        // @optional -(void)dataInOutMonitor:(NSData *)data incoming:(BOOL)isIncoming;
        [Export("dataInOutMonitor:incoming:")]
        void DataInOutMonitor(NSData data, bool isIncoming);

        // @optional -(void)bypassData:(NSData *)data;
        [Export("bypassData:")]
        void BypassData(NSData data);
    }

    // @interface ClearentTransactionTokenRequest : NSObject
    [BaseType(typeof(NSObject))]
    interface ClearentTransactionTokenRequest
    {
        // @property (nonatomic) NSString * tlv;
        [Export("tlv")]
        string Tlv { get; set; }

        // @property (nonatomic) BOOL encrypted;
        [Export("encrypted")]
        bool Encrypted { get; set; }

        // @property (nonatomic) BOOL emv;
        [Export("emv")]
        bool Emv { get; set; }

        // @property (nonatomic) NSString * firmwareVersion;
        [Export("firmwareVersion")]
        string FirmwareVersion { get; set; }

        // @property (nonatomic) NSString * deviceSerialNumber;
        [Export("deviceSerialNumber")]
        string DeviceSerialNumber { get; set; }

        // @property (nonatomic) NSString * kernelVersion;
        [Export("kernelVersion")]
        string KernelVersion { get; set; }

        // @property (nonatomic) NSString * track2Data;
        [Export("track2Data")]
        string Track2Data { get; set; }

        // @property (nonatomic) NSString * applicationPreferredNameTag9F12;
        [Export("applicationPreferredNameTag9F12")]
        string ApplicationPreferredNameTag9F12 { get; set; }

        // -(NSString *)asJson;
        [Export("asJson")]
        string AsJson();

        // -(NSDictionary *)asDictionary;
        [Export("asDictionary")]
        NSDictionary AsDictionary();
    }

    // @interface ClearentDelegate : NSObject
    [BaseType(typeof(NSObject))]
    interface ClearentDelegate
    {
        // @property (nonatomic) NSString * firmwareVersion;
        [Export("firmwareVersion")]
        string FirmwareVersion { get; set; }

        // @property (nonatomic) NSString * deviceSerialNumber;
        [Export("deviceSerialNumber")]
        string DeviceSerialNumber { get; set; }

        // @property (nonatomic) NSString * kernelVersion;
        [Export("kernelVersion")]
        string KernelVersion { get; set; }

        // @property (nonatomic) NSString * baseUrl;
        [Export("baseUrl")]
        string BaseUrl { get; set; }

        // @property (nonatomic) NSString * publicKey;
        [Export("publicKey")]
        string PublicKey { get; set; }

        [Wrap("WeakPublicDelegate")]
        Clearent_Public_IDTech_VP3300_Delegate PublicDelegate { get; set; }

        // @property (nonatomic) id<Clearent_Public_IDTech_VP3300_Delegate> publicDelegate;
        [NullAllowed, Export("publicDelegate", ArgumentSemantic.Assign)]
        NSObject WeakPublicDelegate { get; set; }

        // @property (nonatomic) ClearentConfigurator * clearentConfigurator;
        [Export("clearentConfigurator", ArgumentSemantic.Assign)]
        ClearentConfigurator ClearentConfigurator { get; set; }

        // -(id)init:(id<Clearent_Public_IDTech_VP3300_Delegate>)publicDelegate clearentBaseUrl:(NSString *)clearentBaseUrl publicKey:(NSString *)publicKey;
        [Export("init:clearentBaseUrl:publicKey:")]
        IntPtr Constructor(Clearent_Public_IDTech_VP3300_Delegate publicDelegate, string clearentBaseUrl, string publicKey);

        // -(ClearentTransactionTokenRequest *)createClearentTransactionTokenRequest:(id)emvData;
        [Export("createClearentTransactionTokenRequest:")]
        ClearentTransactionTokenRequest CreateClearentTransactionTokenRequest(NSObject emvData);

        // -(void)createTransactionToken:(ClearentTransactionTokenRequest *)clearentTransactionTokenRequest;
        [Export("createTransactionToken:")]
        void CreateTransactionToken(ClearentTransactionTokenRequest clearentTransactionTokenRequest);

        // -(void)deviceConnected;
        [Export("deviceConnected")]
        void DeviceConnected();

        // -(void)deviceMessage:(NSString *)message;
        [Export("deviceMessage:")]
        void DeviceMessage(string message);

        // -(ClearentTransactionTokenRequest *)createClearentTransactionToken:(BOOL)emv encrypted:(BOOL)encrypted track2Data:(NSString *)track2Data;
        [Export("createClearentTransactionToken:encrypted:track2Data:")]
        ClearentTransactionTokenRequest CreateClearentTransactionToken(bool emv, bool encrypted, string track2Data);

        // -(void)startFallbackSwipe;
        [Export("startFallbackSwipe")]
        void StartFallbackSwipe();
    }

    // @protocol Clearent_Device <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface Clearent_Device
    {
        // @required -(void)close;
        [Abstract]
        [Export("close")]
        void Close();

        // @required -(void)device_connectToUSB;
        [Abstract]
        [Export("device_connectToUSB")]
        void Device_connectToUSB();

        // @required -(id)ctls_cancelTransaction;
        [Abstract]
        [Export("ctls_cancelTransaction")]
        ReturnCode Ctls_cancelTransaction();

        // @required -(id)ctls_startTransaction;
        [Abstract]
        [Export("ctls_startTransaction")]
        ReturnCode Ctls_startTransaction();

        // @required -(id)device_cancelConnectToAudioReader;
        [Abstract]
        [Export("device_cancelConnectToAudioReader")]
        ReturnCode Device_cancelConnectToAudioReader();

        // @required -(id)device_connectToAudioReader;
        [Abstract]
        [Export("device_connectToAudioReader")]
        ReturnCode Device_connectToAudioReader();

        // @required -(id)device_getFirmwareVersion:(NSString **)response;
        [Abstract]
        [Export("device_getFirmwareVersion:")]
        ReturnCode Device_getFirmwareVersion(out string response);

        // @required -(_Bool)device_enableBLEDeviceSearch:(id)type identifier:(NSUUID *)identifier;
        [Abstract]
        [Export("device_enableBLEDeviceSearch:identifier:")]
        bool Device_enableBLEDeviceSearch(NSObject type, NSUuid identifier);

        // @required -(_Bool)device_disableBLEDeviceSearch;
        [Abstract]
        [Export("device_disableBLEDeviceSearch")]
        bool Device_disableBLEDeviceSearch();

        // @required -(NSUUID *)device_connectedBLEDevice;
        [Abstract]
        [Export("device_connectedBLEDevice")]
        NSUuid Device_connectedBLEDevice();

        // @required -(BOOL)device_isAudioReaderConnected;
        [Abstract]
        [Export("device_isAudioReaderConnected")]
        bool Device_isAudioReaderConnected();

        // @required -(NSString *)device_getResponseCodeString:(int)errorCode;
        [Abstract]
        [Export("device_getResponseCodeString:")]
        string Device_getResponseCodeString(int errorCode);

        // @required -(_Bool)device_isConnected:(id)device;
        [Abstract]
        [Export("device_isConnected:")]
        bool Device_isConnected(NSObject device);

        // @required -(id)device_sendIDGCommand:(unsigned char)command subCommand:(unsigned char)subCommand data:(NSData *)data response:(NSData **)response;
        [Abstract]
        [Export("device_sendIDGCommand:subCommand:data:response:")]
        ReturnCode Device_sendIDGCommand(byte command, byte subCommand, NSData data, ref IntPtr response);

        // @required -(id)device_setAudioVolume:(float)val;
        [Abstract]
        [Export("device_setAudioVolume:")]
        ReturnCode Device_setAudioVolume(float val);

        // @required -(id)device_setPassThrough:(BOOL)enablePassThrough;
        [Abstract]
        [Export("device_setPassThrough:")]
        ReturnCode Device_setPassThrough(bool enablePassThrough);

        // @required -(id)device_startRKI;
        [Abstract]
        [Export("device_startRKI")]
        ReturnCode Device_startRKI();

        // @required -(id)emv_authenticateTransaction:(NSData *)tags;
        [Abstract]
        [Export("emv_authenticateTransaction:")]
        ReturnCode Emv_authenticateTransaction(NSData tags);

        // @required -(id)emv_callbackResponseLCD:(int)mode selection:(unsigned char)selection;
        [Abstract]
        [Export("emv_callbackResponseLCD:selection:")]
        ReturnCode Emv_callbackResponseLCD(int mode, byte selection);

        // @required -(id)emv_completeOnlineEMVTransaction:(BOOL)isSuccess hostResponseTags:(NSData *)tags;
        [Abstract]
        [Export("emv_completeOnlineEMVTransaction:hostResponseTags:")]
        ReturnCode Emv_completeOnlineEMVTransaction(bool isSuccess, NSData tags);

        // @required -(void)emv_disableAutoAuthenticateTransaction:(BOOL)disable;
        [Abstract]
        [Export("emv_disableAutoAuthenticateTransaction:")]
        void Emv_disableAutoAuthenticateTransaction(bool disable);

        // @required -(id)emv_getEMVL2Version:(NSString **)response;
        [Abstract]
        [Export("emv_getEMVL2Version:")]
        ReturnCode Emv_getEMVL2Version(out string response);

        // @required -(id)emv_removeApplicationData:(NSString *)AID;
        [Abstract]
        [Export("emv_removeApplicationData:")]
        ReturnCode Emv_removeApplicationData(string AID);

        // @required -(id)emv_removeCAPK:(NSString *)rid index:(NSString *)index;
        [Abstract]
        [Export("emv_removeCAPK:index:")]
        ReturnCode Emv_removeCAPK(string rid, string index);

        // @required -(id)emv_removeCRLList;
        [Abstract]
        [Export("emv_removeCRLList")]
        ReturnCode Emv_removeCRLList();

        // @required -(id)emv_removeTerminalData;
        [Abstract]
        [Export("emv_removeTerminalData")]
        ReturnCode Emv_removeTerminalData();

        // @required -(id)emv_retrieveAIDList:(NSArray **)response;
        [Abstract]
        [Export("emv_retrieveAIDList:")]
        // [Verify(StronglyTypedNSArray)]
        ReturnCode Emv_retrieveAIDList(out NSObject[] response);

        // @required -(id)emv_retrieveApplicationData:(NSString *)AID response:(NSDictionary **)responseAID;
        [Abstract]
        [Export("emv_retrieveApplicationData:response:")]
        ReturnCode Emv_retrieveApplicationData(string AID, out NSDictionary responseAID);

        // @required -(id)emv_retrieveCAPK:(NSString *)rid index:(NSString *)index response:(id)response;
        [Abstract]
        [Export("emv_retrieveCAPK:index:response:")]
        ReturnCode Emv_retrieveCAPK(string rid, string index, NSObject response);

        // @required -(id)emv_retrieveCAPKFile:(NSString *)rid index:(NSString *)index response:(NSData **)response;
        [Abstract]
        [Export("emv_retrieveCAPKFile:index:response:")]
        ReturnCode Emv_retrieveCAPKFile(string rid, string index, ref IntPtr response);

        // @required -(id)emv_retrieveCAPKList:(NSArray **)response;
        [Abstract]
        [Export("emv_retrieveCAPKList:")]
        // [Verify(StronglyTypedNSArray)]
        ReturnCode Emv_retrieveCAPKList(out NSObject[] response);

        // @required -(id)emv_retrieveCRLList:(NSMutableArray **)response;
        [Abstract]
        [Export("emv_retrieveCRLList:")]
        ReturnCode Emv_retrieveCRLList(out NSMutableArray response);

        // @required -(id)emv_retrieveTerminalData:(NSDictionary **)responseData;
        [Abstract]
        [Export("emv_retrieveTerminalData:")]
        ReturnCode Emv_retrieveTerminalData(out NSDictionary responseData);

        // @required -(id)emv_retrieveTransactionResult:(NSData *)tags retrievedTags:(NSDictionary **)retrievedTags;
        [Abstract]
        [Export("emv_retrieveTransactionResult:retrievedTags:")]
        ReturnCode Emv_retrieveTransactionResult(NSData tags, out NSDictionary retrievedTags);

        // @required -(id)emv_setApplicationData:(NSString *)aidName configData:(NSDictionary *)data;
        [Abstract]
        [Export("emv_setApplicationData:configData:")]
        ReturnCode Emv_setApplicationData(string aidName, NSDictionary data);

        // @required -(id)emv_setCAPK:(id)key;
        [Abstract]
        [Export("emv_setCAPK:")]
        ReturnCode Emv_setCAPK(NSObject key);

        // @required -(id)emv_setCAPKFile:(NSData *)file;
        [Abstract]
        [Export("emv_setCAPKFile:")]
        ReturnCode Emv_setCAPKFile(NSData file);

        // @required -(id)emv_setCRLEntries:(NSData *)data;
        [Abstract]
        [Export("emv_setCRLEntries:")]
        ReturnCode Emv_setCRLEntries(NSData data);

        // @required -(id)emv_setTerminalData:(NSDictionary *)data;
        [Abstract]
        [Export("emv_setTerminalData:")]
        ReturnCode Emv_setTerminalData(NSDictionary data);

        // @required -(id)emv_startTransaction:(double)amount amtOther:(double)amtOther type:(int)type timeout:(int)timeout tags:(NSData *)tags forceOnline:(BOOL)forceOnline fallback:(BOOL)fallback;
        [Abstract]
        [Export("emv_startTransaction:amtOther:type:timeout:tags:forceOnline:fallback:")]
        ReturnCode Emv_startTransaction(double amount, double amtOther, int type, int timeout, NSData tags, bool forceOnline, bool fallback);

        // @required -(id)config_getSerialNumber:(NSString **)response;
        [Abstract]
        [Export("config_getSerialNumber:")]
        ReturnCode Config_getSerialNumber(out string response);

        // @required -(id)icc_exchangeAPDU:(NSData *)dataAPDU response:(APDUResponse **)response;
        [Abstract]
        [Export("icc_exchangeAPDU:response:")]
        ReturnCode Icc_exchangeAPDU(NSData dataAPDU, out APDUResponse response);

        // @required -(id)icc_getICCReaderStatus:(id)readerStatus;
        [Abstract]
        [Export("icc_getICCReaderStatus:")]
        ReturnCode Icc_getICCReaderStatus(NSObject readerStatus);

        // @required -(id)icc_powerOnICC:(NSData **)response;
        [Abstract]
        [Export("icc_powerOnICC:")]
        ReturnCode Icc_powerOnICC(ref IntPtr response);

        // @required -(id)icc_powerOffICC:(NSString **)error;
        [Abstract]
        [Export("icc_powerOffICC:")]
        ReturnCode Icc_powerOffICC(out string error);

        // @required -(id)msr_cancelMSRSwipe;
        [Abstract]
        [Export("msr_cancelMSRSwipe")]
        ReturnCode Msr_cancelMSRSwipe();

        // @required -(id)msr_startMSRSwipe;
        [Abstract]
        [Export("msr_startMSRSwipe")]
        ReturnCode Msr_startMSRSwipe();

        // @required -(_Bool)isConnected;
        [Abstract]
        [Export("isConnected")]
        bool IsConnected();
    }

    // @interface Clearent_VP3300 : NSObject
    [BaseType(typeof(NSObject))]
    interface Clearent_VP3300
    {
        [Wrap("WeakClearentDelegate")]
        ClearentDelegate ClearentDelegate { get; set; }

        // @property (nonatomic) ClearentDelegate * clearentDelegate;
        [NullAllowed, Export("clearentDelegate", ArgumentSemantic.Assign)]
        NSObject WeakClearentDelegate { get; set; }

        // @property (nonatomic) SEL callBackSelector;
        [Export("callBackSelector", ArgumentSemantic.Assign)]
        Selector CallBackSelector { get; set; }

        // -(void)init:(id<Clearent_Public_IDTech_VP3300_Delegate>)publicDelegate clearentBaseUrl:(NSString *)clearentBaseUrl publicKey:(NSString *)publicKey;
        [Export("init:clearentBaseUrl:publicKey:")]
        void Init(Clearent_Public_IDTech_VP3300_Delegate publicDelegate, string clearentBaseUrl, string publicKey);

        // -(NSString *)SDK_version;
        [Export("SDK_version")]
        string SDK_version();

        // -(void)close;
        [Export("close")]
        void Close();

        // -(void)device_connectToUSB;
        [Export("device_connectToUSB")]
        void Device_connectToUSB();

        // -(void)device_disconnectBLE;
        [Export("device_disconnectBLE")]
        void Device_disconnectBLE();

        // -(id)ctls_cancelTransaction;
        [Export("ctls_cancelTransaction")]
        ReturnCode Ctls_cancelTransaction();

        // -(id)emv_cancelTransaction;
        [Export("emv_cancelTransaction")]
        ReturnCode Emv_cancelTransaction();

        // -(id)device_cancelTransaction;
        [Export("device_cancelTransaction")]
        ReturnCode Device_cancelTransaction();

        // -(id)ctls_getConfigurationGroup:(int)group response:(NSDictionary **)response;
        [Export("ctls_getConfigurationGroup:response:")]
        ReturnCode Ctls_getConfigurationGroup(int group, out NSDictionary response);

        // -(void)processBypassResponse:(NSData *)data;
        [Export("processBypassResponse:")]
        void ProcessBypassResponse(NSData data);

        // -(void)assignBypassDelegate:(id)del;
        [Export("assignBypassDelegate:")]
        void AssignBypassDelegate(NSObject del);

        // -(id)ctls_removeAllCAPK;
        [Export("ctls_removeAllCAPK")]
        ReturnCode Ctls_removeAllCAPK();

        // -(id)ctls_removeApplicationData:(NSString *)AID;
        [Export("ctls_removeApplicationData:")]
        ReturnCode Ctls_removeApplicationData(string AID);

        // -(id)ctls_removeCAPK:(NSData *)capk;
        [Export("ctls_removeCAPK:")]
        ReturnCode Ctls_removeCAPK(NSData capk);

        // -(id)ctls_removeConfigurationGroup:(int)group;
        [Export("ctls_removeConfigurationGroup:")]
        ReturnCode Ctls_removeConfigurationGroup(int group);

        // -(id)ctls_retrieveAIDList:(NSArray **)response;
        [Export("ctls_retrieveAIDList:")]
        //  [Verify(StronglyTypedNSArray)]
        ReturnCode Ctls_retrieveAIDList(out NSObject[] response);

        // -(id)ctls_retrieveApplicationData:(NSString *)AID response:(NSDictionary **)response;
        [Export("ctls_retrieveApplicationData:response:")]
        ReturnCode Ctls_retrieveApplicationData(string AID, out NSDictionary response);

        // -(id)ctls_retrieveCAPK:(NSData *)capk key:(NSData **)key;
        [Export("ctls_retrieveCAPK:key:")]
        ReturnCode Ctls_retrieveCAPK(NSData capk, ref IntPtr key);

        // -(id)ctls_retrieveCAPKList:(NSArray **)keys;
        [Export("ctls_retrieveCAPKList:")]
        //  [Verify(StronglyTypedNSArray)]
        ReturnCode Ctls_retrieveCAPKList(out NSObject[] keys);

        // -(id)ctls_retrieveTerminalData:(NSData **)tlv;
        [Export("ctls_retrieveTerminalData:")]
        ReturnCode Ctls_retrieveTerminalData(ref IntPtr tlv);

        // -(id)ctls_setApplicationData:(NSData *)tlv;
        [Export("ctls_setApplicationData:")]
        ReturnCode Ctls_setApplicationData(NSData tlv);

        // -(id)ctls_setCAPK:(NSData *)key;
        [Export("ctls_setCAPK:")]
        ReturnCode Ctls_setCAPK(NSData key);

        // -(id)ctls_setConfigurationGroup:(NSData *)tlv;
        [Export("ctls_setConfigurationGroup:")]
        ReturnCode Ctls_setConfigurationGroup(NSData tlv);

        // -(id)ctls_setTerminalData:(NSData *)tlv;
        [Export("ctls_setTerminalData:")]
        ReturnCode Ctls_setTerminalData(NSData tlv);

        // -(id)ctls_startTransaction:(double)amount type:(int)type timeout:(int)timeout tags:(NSMutableDictionary *)tags;
        [Export("ctls_startTransaction:type:timeout:tags:")]
        ReturnCode Ctls_startTransaction(double amount, int type, int timeout, NSMutableDictionary tags);

        //Dup
        // -(id)ctls_startTransaction;
        //[Export("ctls_startTransaction")]
        // [Verify(MethodToProperty)]
        // NSObject Ctls_startTransaction { get; }

        // -(id)device_cancelConnectToAudioReader;
        [Export("device_cancelConnectToAudioReader")]
        ReturnCode Device_cancelConnectToAudioReader();

        // -(id)device_connectToAudioReader;
        [Export("device_connectToAudioReader")]
        ReturnCode Device_connectToAudioReader();

        // -(id)device_getFirmwareVersion:(NSString **)response;
        [Export("device_getFirmwareVersion:")]
        ReturnCode Device_getFirmwareVersion(out string response);

        // -(_Bool)device_enableBLEDeviceSearch:(NSUUID *)identifier;
        [Export("device_enableBLEDeviceSearch:")]
        bool Device_enableBLEDeviceSearch(NSUuid identifier);

        // -(NSString *)device_getBLEFriendlyName;
        [Export("device_getBLEFriendlyName")]
        string Device_getBLEFriendlyName();

        // -(void)device_setBLEFriendlyName:(NSString *)friendlyName;
        [Export("device_setBLEFriendlyName:")]
        void Device_setBLEFriendlyName(string friendlyName);

        // -(_Bool)device_disableBLEDeviceSearch;
        [Export("device_disableBLEDeviceSearch")]
        bool Device_disableBLEDeviceSearch();

        // -(NSUUID *)device_connectedBLEDevice;
        [Export("device_connectedBLEDevice")]
        NSUuid Device_connectedBLEDevice();

        // -(BOOL)device_isAudioReaderConnected;
        [Export("device_isAudioReaderConnected")]
        bool Device_isAudioReaderConnected();

        // -(id)device_getAutoPollTransactionResults:(id)result;
        [Export("device_getAutoPollTransactionResults:")]
        ReturnCode Device_getAutoPollTransactionResults(NSObject result);

        // -(NSString *)device_getResponseCodeString:(int)errorCode;
        [Export("device_getResponseCodeString:")]
        string Device_getResponseCodeString(int errorCode);

        // -(_Bool)device_isConnected:(id)device;
        [Export("device_isConnected:")]
        bool Device_isConnected(NSObject device);

        // -(id)device_sendIDGCommand:(unsigned char)command subCommand:(unsigned char)subCommand data:(NSData *)data response:(NSData **)response;
        [Export("device_sendIDGCommand:subCommand:data:response:")]
        ReturnCode Device_sendIDGCommand(byte command, byte subCommand, NSData data, ref IntPtr response);

        // -(id)device_setAudioVolume:(float)val;
        [Export("device_setAudioVolume:")]
        ReturnCode Device_setAudioVolume(float val);

        // -(id)device_setPassThrough:(BOOL)enablePassThrough;
        [Export("device_setPassThrough:")]
        ReturnCode Device_setPassThrough(bool enablePassThrough);

        // -(id)device_setBurstMode:(int)mode;
        [Export("device_setBurstMode:")]
        ReturnCode Device_setBurstMode(int mode);

        // -(id)device_setPollMode:(int)mode;
        [Export("device_setPollMode:")]
        ReturnCode Device_setPollMode(int mode);

        // -(id)device_startRKI;
        [Export("device_startRKI")]
        ReturnCode Device_startRKI();

        // -(id)emv_authenticateTransaction:(NSData *)tags;
        [Export("emv_authenticateTransaction:")]
        ReturnCode Emv_authenticateTransaction(NSData tags);

        // -(id)emv_callbackResponseLCD:(int)mode selection:(unsigned char)selection;
        [Export("emv_callbackResponseLCD:selection:")]
        ReturnCode Emv_callbackResponseLCD(int mode, byte selection);

        // -(id)emv_callbackResponsePIN:(id)mode KSN:(NSData *)KSN PIN:(NSData *)PIN;
        [Export("emv_callbackResponsePIN:KSN:PIN:")]
        ReturnCode Emv_callbackResponsePIN(NSObject mode, NSData KSN, NSData PIN);

        // -(id)emv_completeOnlineEMVTransaction:(BOOL)isSuccess hostResponseTags:(NSData *)tags;
        [Export("emv_completeOnlineEMVTransaction:hostResponseTags:")]
        ReturnCode Emv_completeOnlineEMVTransaction(bool isSuccess, NSData tags);

        // -(void)emv_disableAutoAuthenticateTransaction:(BOOL)disable;
        [Export("emv_disableAutoAuthenticateTransaction:")]
        void Emv_disableAutoAuthenticateTransaction(bool disable);

        // -(id)emv_getEMVL2Version:(NSString **)response;
        [Export("emv_getEMVL2Version:")]
        ReturnCode Emv_getEMVL2Version(out string response);

        // -(id)emv_removeApplicationData:(NSString *)AID;
        [Export("emv_removeApplicationData:")]
        ReturnCode Emv_removeApplicationData(string AID);

        // -(id)emv_removeCAPK:(NSString *)rid index:(NSString *)index;
        [Export("emv_removeCAPK:index:")]
        ReturnCode Emv_removeCAPK(string rid, string index);

        // -(id)emv_setTerminalMajorConfiguration:(int)configuration;
        [Export("emv_setTerminalMajorConfiguration:")]
        ReturnCode Emv_setTerminalMajorConfiguration(int configuration);

        // -(id)emv_getTerminalMajorConfiguration:(NSUInteger **)configuration;
        [Export("emv_getTerminalMajorConfiguration:")]
        unsafe ReturnCode Emv_getTerminalMajorConfiguration(nuint configuration);

        // -(id)emv_removeCRLList;
        [Export("emv_removeCRLList")]
        ReturnCode Emv_removeCRLList();

        // -(id)emv_removeTerminalData;
        [Export("emv_removeTerminalData")]
        ReturnCode Emv_removeTerminalData();

        // -(id)emv_retrieveAIDList:(NSArray **)response;
        [Export("emv_retrieveAIDList:")]
        //  [Verify(StronglyTypedNSArray)]
        ReturnCode Emv_retrieveAIDList(out NSObject[] response);

        // -(id)emv_retrieveApplicationData:(NSString *)AID response:(NSDictionary **)responseAID;
        [Export("emv_retrieveApplicationData:response:")]
        ReturnCode Emv_retrieveApplicationData(string AID, out NSDictionary responseAID);

        // -(id)emv_retrieveCAPK:(NSString *)rid index:(NSString *)index response:(id)response;
        [Export("emv_retrieveCAPK:index:response:")]
        ReturnCode Emv_retrieveCAPK(string rid, string index, NSObject response);

        // -(id)emv_retrieveCAPKFile:(NSString *)rid index:(NSString *)index response:(NSData **)response;
        [Export("emv_retrieveCAPKFile:index:response:")]
        ReturnCode Emv_retrieveCAPKFile(string rid, string index, ref IntPtr response);

        // -(id)emv_retrieveCAPKList:(NSArray **)response;
        [Export("emv_retrieveCAPKList:")]
        //    [Verify(StronglyTypedNSArray)]
        ReturnCode Emv_retrieveCAPKList(out NSObject[] response);

        // -(id)emv_retrieveCRLList:(NSMutableArray **)response;
        [Export("emv_retrieveCRLList:")]
        ReturnCode Emv_retrieveCRLList(out NSMutableArray response);

        // -(id)emv_retrieveTerminalData:(NSDictionary **)responseData;
        [Export("emv_retrieveTerminalData:")]
        ReturnCode Emv_retrieveTerminalData(out NSDictionary responseData);

        // -(id)emv_retrieveTransactionResult:(NSData *)tags retrievedTags:(NSDictionary **)retrievedTags;
        [Export("emv_retrieveTransactionResult:retrievedTags:")]
        ReturnCode Emv_retrieveTransactionResult(NSData tags, out NSDictionary retrievedTags);

        // -(id)emv_setApplicationData:(NSString *)aidName configData:(NSDictionary *)data;
        [Export("emv_setApplicationData:configData:")]
        ReturnCode Emv_setApplicationData(string aidName, NSDictionary data);

        // -(id)emv_setCAPK:(id)key;
        [Export("emv_setCAPK:")]
        ReturnCode Emv_setCAPK(NSObject key);

        // -(id)emv_setCAPKFile:(NSData *)file;
        [Export("emv_setCAPKFile:")]
        ReturnCode Emv_setCAPKFile(NSData file);

        // -(id)emv_setCRLEntries:(NSData *)data;
        [Export("emv_setCRLEntries:")]
        ReturnCode Emv_setCRLEntries(NSData data);

        // -(id)emv_setTerminalData:(NSDictionary *)data;
        [Export("emv_setTerminalData:")]
        ReturnCode Emv_setTerminalData(NSDictionary data);

        // -(id)emv_startTransaction:(double)amount amtOther:(double)amtOther type:(int)type timeout:(int)timeout tags:(NSData *)tags forceOnline:(BOOL)forceOnline fallback:(BOOL)fallback;
        [Export("emv_startTransaction:amtOther:type:timeout:tags:forceOnline:fallback:")]
        ReturnCode Emv_startTransaction(double amount, double amtOther, int type, int timeout, NSData tags, bool forceOnline, bool fallback);

        // -(id)config_getSerialNumber:(NSString **)response;
        [Export("config_getSerialNumber:")]
        ReturnCode Config_getSerialNumber(out string response);

        // -(id)icc_exchangeAPDU:(NSData *)dataAPDU response:(APDUResponse **)response;
        [Export("icc_exchangeAPDU:response:")]
        ReturnCode Icc_exchangeAPDU(NSData dataAPDU, out APDUResponse response);

        // -(id)icc_getICCReaderStatus:(id)readerStatus;
        [Export("icc_getICCReaderStatus:")]
        ReturnCode Icc_getICCReaderStatus(NSObject readerStatus);

        // -(id)icc_powerOnICC:(NSData **)response;
        [Export("icc_powerOnICC:")]
        ReturnCode Icc_powerOnICC(ref IntPtr response);

        // -(id)icc_powerOffICC:(NSString **)error;
        [Export("icc_powerOffICC:")]
        ReturnCode Icc_powerOffICC(out string error);

        // -(id)msr_cancelMSRSwipe;
        [Export("msr_cancelMSRSwipe")]
        ReturnCode Msr_cancelMSRSwipe();

        // -(id)msr_startMSRSwipe;
        [Export("msr_startMSRSwipe")]
        ReturnCode Msr_startMSRSwipe();

        // -(_Bool)isConnected;
        [Export("isConnected")]
        bool IsConnected();

        // -(id)device_startTransaction:(double)amount amtOther:(double)amtOther type:(int)type timeout:(int)timeout tags:(NSData *)tags forceOnline:(BOOL)forceOnline fallback:(BOOL)fallback;
        [Export("device_startTransaction:amtOther:type:timeout:tags:forceOnline:fallback:")]
        ReturnCode Device_startTransaction(double amount, double amtOther, int type, int timeout, NSData tags, bool forceOnline, bool fallback);
    }

}
