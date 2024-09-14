// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: authentication_service.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace bgs.protocol.authentication.v1
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ModuleLoadRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"module_handle", IsRequired = true)]
        public global::bgs.protocol.ContentHandle ModuleHandle { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"message")]
        public byte[] Message
        {
            get => __pbn__Message;
            set => __pbn__Message = value;
        }
        public bool ShouldSerializeMessage() => __pbn__Message != null;
        public void ResetMessage() => __pbn__Message = null;
        private byte[] __pbn__Message;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ModuleNotification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(2, Name = @"module_id")]
        public int ModuleId
        {
            get => __pbn__ModuleId.GetValueOrDefault();
            set => __pbn__ModuleId = value;
        }
        public bool ShouldSerializeModuleId() => __pbn__ModuleId != null;
        public void ResetModuleId() => __pbn__ModuleId = null;
        private int? __pbn__ModuleId;

        [global::ProtoBuf.ProtoMember(3, Name = @"result")]
        public uint Result
        {
            get => __pbn__Result.GetValueOrDefault();
            set => __pbn__Result = value;
        }
        public bool ShouldSerializeResult() => __pbn__Result != null;
        public void ResetResult() => __pbn__Result = null;
        private uint? __pbn__Result;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ModuleMessageRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"module_id", IsRequired = true)]
        public int ModuleId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"message")]
        public byte[] Message
        {
            get => __pbn__Message;
            set => __pbn__Message = value;
        }
        public bool ShouldSerializeMessage() => __pbn__Message != null;
        public void ResetMessage() => __pbn__Message = null;
        private byte[] __pbn__Message;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LogonRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"program")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Program
        {
            get => __pbn__Program ?? "";
            set => __pbn__Program = value;
        }
        public bool ShouldSerializeProgram() => __pbn__Program != null;
        public void ResetProgram() => __pbn__Program = null;
        private string __pbn__Program;

        [global::ProtoBuf.ProtoMember(2, Name = @"platform")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Platform
        {
            get => __pbn__Platform ?? "";
            set => __pbn__Platform = value;
        }
        public bool ShouldSerializePlatform() => __pbn__Platform != null;
        public void ResetPlatform() => __pbn__Platform = null;
        private string __pbn__Platform;

        [global::ProtoBuf.ProtoMember(3, Name = @"locale")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Locale
        {
            get => __pbn__Locale ?? "";
            set => __pbn__Locale = value;
        }
        public bool ShouldSerializeLocale() => __pbn__Locale != null;
        public void ResetLocale() => __pbn__Locale = null;
        private string __pbn__Locale;

        [global::ProtoBuf.ProtoMember(4, Name = @"email")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Email
        {
            get => __pbn__Email ?? "";
            set => __pbn__Email = value;
        }
        public bool ShouldSerializeEmail() => __pbn__Email != null;
        public void ResetEmail() => __pbn__Email = null;
        private string __pbn__Email;

        [global::ProtoBuf.ProtoMember(5, Name = @"version")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Version
        {
            get => __pbn__Version ?? "";
            set => __pbn__Version = value;
        }
        public bool ShouldSerializeVersion() => __pbn__Version != null;
        public void ResetVersion() => __pbn__Version = null;
        private string __pbn__Version;

        [global::ProtoBuf.ProtoMember(6, Name = @"application_version")]
        public int ApplicationVersion
        {
            get => __pbn__ApplicationVersion.GetValueOrDefault();
            set => __pbn__ApplicationVersion = value;
        }
        public bool ShouldSerializeApplicationVersion() => __pbn__ApplicationVersion != null;
        public void ResetApplicationVersion() => __pbn__ApplicationVersion = null;
        private int? __pbn__ApplicationVersion;

        [global::ProtoBuf.ProtoMember(7, Name = @"public_computer")]
        public bool PublicComputer
        {
            get => __pbn__PublicComputer.GetValueOrDefault();
            set => __pbn__PublicComputer = value;
        }
        public bool ShouldSerializePublicComputer() => __pbn__PublicComputer != null;
        public void ResetPublicComputer() => __pbn__PublicComputer = null;
        private bool? __pbn__PublicComputer;

        [global::ProtoBuf.ProtoMember(10, Name = @"allow_logon_queue_notifications")]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool AllowLogonQueueNotifications
        {
            get => __pbn__AllowLogonQueueNotifications ?? false;
            set => __pbn__AllowLogonQueueNotifications = value;
        }
        public bool ShouldSerializeAllowLogonQueueNotifications() => __pbn__AllowLogonQueueNotifications != null;
        public void ResetAllowLogonQueueNotifications() => __pbn__AllowLogonQueueNotifications = null;
        private bool? __pbn__AllowLogonQueueNotifications;

        [global::ProtoBuf.ProtoMember(11, Name = @"web_client_verification")]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool WebClientVerification
        {
            get => __pbn__WebClientVerification ?? false;
            set => __pbn__WebClientVerification = value;
        }
        public bool ShouldSerializeWebClientVerification() => __pbn__WebClientVerification != null;
        public void ResetWebClientVerification() => __pbn__WebClientVerification = null;
        private bool? __pbn__WebClientVerification;

        [global::ProtoBuf.ProtoMember(12, Name = @"cached_web_credentials")]
        public byte[] CachedWebCredentials
        {
            get => __pbn__CachedWebCredentials;
            set => __pbn__CachedWebCredentials = value;
        }
        public bool ShouldSerializeCachedWebCredentials() => __pbn__CachedWebCredentials != null;
        public void ResetCachedWebCredentials() => __pbn__CachedWebCredentials = null;
        private byte[] __pbn__CachedWebCredentials;

        [global::ProtoBuf.ProtoMember(14, Name = @"user_agent")]
        [global::System.ComponentModel.DefaultValue("")]
        public string UserAgent
        {
            get => __pbn__UserAgent ?? "";
            set => __pbn__UserAgent = value;
        }
        public bool ShouldSerializeUserAgent() => __pbn__UserAgent != null;
        public void ResetUserAgent() => __pbn__UserAgent = null;
        private string __pbn__UserAgent;

        [global::ProtoBuf.ProtoMember(15, Name = @"device_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DeviceId
        {
            get => __pbn__DeviceId ?? "";
            set => __pbn__DeviceId = value;
        }
        public bool ShouldSerializeDeviceId() => __pbn__DeviceId != null;
        public void ResetDeviceId() => __pbn__DeviceId = null;
        private string __pbn__DeviceId;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LogonResult : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"error_code", IsRequired = true)]
        public uint ErrorCode { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"account_id")]
        public global::bgs.protocol.EntityId AccountId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"game_account_id")]
        public global::System.Collections.Generic.List<global::bgs.protocol.EntityId> GameAccountIds { get; } = new global::System.Collections.Generic.List<global::bgs.protocol.EntityId>();

        [global::ProtoBuf.ProtoMember(4, Name = @"email")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Email
        {
            get => __pbn__Email ?? "";
            set => __pbn__Email = value;
        }
        public bool ShouldSerializeEmail() => __pbn__Email != null;
        public void ResetEmail() => __pbn__Email = null;
        private string __pbn__Email;

        [global::ProtoBuf.ProtoMember(5, Name = @"available_region")]
        public uint[] AvailableRegions { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"connected_region")]
        public uint ConnectedRegion
        {
            get => __pbn__ConnectedRegion.GetValueOrDefault();
            set => __pbn__ConnectedRegion = value;
        }
        public bool ShouldSerializeConnectedRegion() => __pbn__ConnectedRegion != null;
        public void ResetConnectedRegion() => __pbn__ConnectedRegion = null;
        private uint? __pbn__ConnectedRegion;

        [global::ProtoBuf.ProtoMember(7, Name = @"battle_tag")]
        [global::System.ComponentModel.DefaultValue("")]
        public string BattleTag
        {
            get => __pbn__BattleTag ?? "";
            set => __pbn__BattleTag = value;
        }
        public bool ShouldSerializeBattleTag() => __pbn__BattleTag != null;
        public void ResetBattleTag() => __pbn__BattleTag = null;
        private string __pbn__BattleTag;

        [global::ProtoBuf.ProtoMember(8, Name = @"geoip_country")]
        [global::System.ComponentModel.DefaultValue("")]
        public string GeoipCountry
        {
            get => __pbn__GeoipCountry ?? "";
            set => __pbn__GeoipCountry = value;
        }
        public bool ShouldSerializeGeoipCountry() => __pbn__GeoipCountry != null;
        public void ResetGeoipCountry() => __pbn__GeoipCountry = null;
        private string __pbn__GeoipCountry;

        [global::ProtoBuf.ProtoMember(9, Name = @"session_key")]
        public byte[] SessionKey
        {
            get => __pbn__SessionKey;
            set => __pbn__SessionKey = value;
        }
        public bool ShouldSerializeSessionKey() => __pbn__SessionKey != null;
        public void ResetSessionKey() => __pbn__SessionKey = null;
        private byte[] __pbn__SessionKey;

        [global::ProtoBuf.ProtoMember(10, Name = @"restricted_mode")]
        public bool RestrictedMode
        {
            get => __pbn__RestrictedMode.GetValueOrDefault();
            set => __pbn__RestrictedMode = value;
        }
        public bool ShouldSerializeRestrictedMode() => __pbn__RestrictedMode != null;
        public void ResetRestrictedMode() => __pbn__RestrictedMode = null;
        private bool? __pbn__RestrictedMode;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GenerateSSOTokenRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"program", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public uint Program
        {
            get => __pbn__Program.GetValueOrDefault();
            set => __pbn__Program = value;
        }
        public bool ShouldSerializeProgram() => __pbn__Program != null;
        public void ResetProgram() => __pbn__Program = null;
        private uint? __pbn__Program;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GenerateSSOTokenResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"sso_id")]
        public byte[] SsoId
        {
            get => __pbn__SsoId;
            set => __pbn__SsoId = value;
        }
        public bool ShouldSerializeSsoId() => __pbn__SsoId != null;
        public void ResetSsoId() => __pbn__SsoId = null;
        private byte[] __pbn__SsoId;

        [global::ProtoBuf.ProtoMember(2, Name = @"sso_secret")]
        public byte[] SsoSecret
        {
            get => __pbn__SsoSecret;
            set => __pbn__SsoSecret = value;
        }
        public bool ShouldSerializeSsoSecret() => __pbn__SsoSecret != null;
        public void ResetSsoSecret() => __pbn__SsoSecret = null;
        private byte[] __pbn__SsoSecret;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LogonUpdateRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"error_code", IsRequired = true)]
        public uint ErrorCode { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LogonQueueUpdateRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"position", IsRequired = true)]
        public uint Position { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"estimated_time", IsRequired = true)]
        public ulong EstimatedTime { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"eta_deviation_in_sec", IsRequired = true)]
        public ulong EtaDeviationInSec { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class AccountSettingsNotification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"licenses")]
        public global::System.Collections.Generic.List<global::bgs.protocol.account.v1.AccountLicense> Licenses { get; } = new global::System.Collections.Generic.List<global::bgs.protocol.account.v1.AccountLicense>();

        [global::ProtoBuf.ProtoMember(2, Name = @"is_using_rid")]
        public bool IsUsingRid
        {
            get => __pbn__IsUsingRid.GetValueOrDefault();
            set => __pbn__IsUsingRid = value;
        }
        public bool ShouldSerializeIsUsingRid() => __pbn__IsUsingRid != null;
        public void ResetIsUsingRid() => __pbn__IsUsingRid = null;
        private bool? __pbn__IsUsingRid;

        [global::ProtoBuf.ProtoMember(3, Name = @"is_playing_from_igr")]
        public bool IsPlayingFromIgr
        {
            get => __pbn__IsPlayingFromIgr.GetValueOrDefault();
            set => __pbn__IsPlayingFromIgr = value;
        }
        public bool ShouldSerializeIsPlayingFromIgr() => __pbn__IsPlayingFromIgr != null;
        public void ResetIsPlayingFromIgr() => __pbn__IsPlayingFromIgr = null;
        private bool? __pbn__IsPlayingFromIgr;

        [global::ProtoBuf.ProtoMember(4, Name = @"can_receive_voice")]
        public bool CanReceiveVoice
        {
            get => __pbn__CanReceiveVoice.GetValueOrDefault();
            set => __pbn__CanReceiveVoice = value;
        }
        public bool ShouldSerializeCanReceiveVoice() => __pbn__CanReceiveVoice != null;
        public void ResetCanReceiveVoice() => __pbn__CanReceiveVoice = null;
        private bool? __pbn__CanReceiveVoice;

        [global::ProtoBuf.ProtoMember(5, Name = @"can_send_voice")]
        public bool CanSendVoice
        {
            get => __pbn__CanSendVoice.GetValueOrDefault();
            set => __pbn__CanSendVoice = value;
        }
        public bool ShouldSerializeCanSendVoice() => __pbn__CanSendVoice != null;
        public void ResetCanSendVoice() => __pbn__CanSendVoice = null;
        private bool? __pbn__CanSendVoice;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ServerStateChangeRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"state", IsRequired = true)]
        public uint State { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"event_time", IsRequired = true)]
        public ulong EventTime { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class VersionInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"number")]
        public uint Number
        {
            get => __pbn__Number.GetValueOrDefault();
            set => __pbn__Number = value;
        }
        public bool ShouldSerializeNumber() => __pbn__Number != null;
        public void ResetNumber() => __pbn__Number = null;
        private uint? __pbn__Number;

        [global::ProtoBuf.ProtoMember(2, Name = @"patch")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Patch
        {
            get => __pbn__Patch ?? "";
            set => __pbn__Patch = value;
        }
        public bool ShouldSerializePatch() => __pbn__Patch != null;
        public void ResetPatch() => __pbn__Patch = null;
        private string __pbn__Patch;

        [global::ProtoBuf.ProtoMember(3, Name = @"is_optional")]
        public bool IsOptional
        {
            get => __pbn__IsOptional.GetValueOrDefault();
            set => __pbn__IsOptional = value;
        }
        public bool ShouldSerializeIsOptional() => __pbn__IsOptional != null;
        public void ResetIsOptional() => __pbn__IsOptional = null;
        private bool? __pbn__IsOptional;

        [global::ProtoBuf.ProtoMember(4, Name = @"kick_time")]
        public ulong KickTime
        {
            get => __pbn__KickTime.GetValueOrDefault();
            set => __pbn__KickTime = value;
        }
        public bool ShouldSerializeKickTime() => __pbn__KickTime != null;
        public void ResetKickTime() => __pbn__KickTime = null;
        private ulong? __pbn__KickTime;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class VersionInfoNotification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"version_info")]
        public VersionInfo VersionInfo { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MemModuleLoadRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"handle", IsRequired = true)]
        public global::bgs.protocol.ContentHandle Handle { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"key", IsRequired = true)]
        public byte[] Key { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"input", IsRequired = true)]
        public byte[] Input { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MemModuleLoadResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"data", IsRequired = true)]
        public byte[] Data { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SelectGameAccountRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"game_account_id", IsRequired = true)]
        public global::bgs.protocol.EntityId GameAccountId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GameAccountSelectedRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"game_account_id")]
        public global::bgs.protocol.EntityId GameAccountId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GenerateWebCredentialsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"program", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public uint Program
        {
            get => __pbn__Program.GetValueOrDefault();
            set => __pbn__Program = value;
        }
        public bool ShouldSerializeProgram() => __pbn__Program != null;
        public void ResetProgram() => __pbn__Program = null;
        private uint? __pbn__Program;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GenerateWebCredentialsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"web_credentials")]
        public byte[] WebCredentials
        {
            get => __pbn__WebCredentials;
            set => __pbn__WebCredentials = value;
        }
        public bool ShouldSerializeWebCredentials() => __pbn__WebCredentials != null;
        public void ResetWebCredentials() => __pbn__WebCredentials = null;
        private byte[] __pbn__WebCredentials;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class VerifyWebCredentialsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"web_credentials")]
        public byte[] WebCredentials
        {
            get => __pbn__WebCredentials;
            set => __pbn__WebCredentials = value;
        }
        public bool ShouldSerializeWebCredentials() => __pbn__WebCredentials != null;
        public void ResetWebCredentials() => __pbn__WebCredentials = null;
        private byte[] __pbn__WebCredentials;

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
