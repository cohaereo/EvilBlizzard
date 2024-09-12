// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: voice_types.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace bgs.protocol
{

    [global::ProtoBuf.ProtoContract()]
    public partial class VoiceCredentials : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"voice_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string VoiceId
        {
            get => __pbn__VoiceId ?? "";
            set => __pbn__VoiceId = value;
        }
        public bool ShouldSerializeVoiceId() => __pbn__VoiceId != null;
        public void ResetVoiceId() => __pbn__VoiceId = null;
        private string __pbn__VoiceId;

        [global::ProtoBuf.ProtoMember(2, Name = @"token")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Token
        {
            get => __pbn__Token ?? "";
            set => __pbn__Token = value;
        }
        public bool ShouldSerializeToken() => __pbn__Token != null;
        public void ResetToken() => __pbn__Token = null;
        private string __pbn__Token;

        [global::ProtoBuf.ProtoMember(3, Name = @"url")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Url
        {
            get => __pbn__Url ?? "";
            set => __pbn__Url = value;
        }
        public bool ShouldSerializeUrl() => __pbn__Url != null;
        public void ResetUrl() => __pbn__Url = null;
        private string __pbn__Url;

        [global::ProtoBuf.ProtoMember(4, Name = @"join_type")]
        [global::System.ComponentModel.DefaultValue(VoiceJoinType.VoiceJoinNormal)]
        public VoiceJoinType JoinType
        {
            get => __pbn__JoinType ?? VoiceJoinType.VoiceJoinNormal;
            set => __pbn__JoinType = value;
        }
        public bool ShouldSerializeJoinType() => __pbn__JoinType != null;
        public void ResetJoinType() => __pbn__JoinType = null;
        private VoiceJoinType? __pbn__JoinType;

        [global::ProtoBuf.ProtoMember(5, Name = @"mute_reason")]
        [global::System.ComponentModel.DefaultValue(VoiceMuteReason.VoiceMuteReasonNone)]
        public VoiceMuteReason MuteReason
        {
            get => __pbn__MuteReason ?? VoiceMuteReason.VoiceMuteReasonNone;
            set => __pbn__MuteReason = value;
        }
        public bool ShouldSerializeMuteReason() => __pbn__MuteReason != null;
        public void ResetMuteReason() => __pbn__MuteReason = null;
        private VoiceMuteReason? __pbn__MuteReason;

    }

    [global::ProtoBuf.ProtoContract()]
    public enum VoiceJoinType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"VOICE_JOIN_NORMAL")]
        VoiceJoinNormal = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"VOICE_JOIN_MUTED")]
        VoiceJoinMuted = 1,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum VoiceMuteReason
    {
        [global::ProtoBuf.ProtoEnum(Name = @"VOICE_MUTE_REASON_NONE")]
        VoiceMuteReasonNone = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"VOICE_MUTE_REASON_PARENTAL_CONTROL_LISTEN_ONLY")]
        VoiceMuteReasonParentalControlListenOnly = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"VOICE_MUTE_REASON_REQUESTED")]
        VoiceMuteReasonRequested = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"VOICE_MUTE_REASON_SQUELCHED")]
        VoiceMuteReasonSquelched = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum VoiceProviderVersion
    {
        [global::ProtoBuf.ProtoEnum(Name = @"VOICE_PROVIDER_V4")]
        VoiceProviderV4 = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"VOICE_PROVIDER_V5")]
        VoiceProviderV5 = 1,
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
