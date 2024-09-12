// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: report_types.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace bgs.protocol.report.v2
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ReportItem : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"message_id")]
        public global::bgs.protocol.MessageId MessageId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class UserOptions : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"target_id")]
        public global::bgs.protocol.account.v1.AccountId TargetId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"type")]
        [global::System.ComponentModel.DefaultValue(IssueType.IssueTypeSpam)]
        public IssueType Type
        {
            get => __pbn__Type ?? IssueType.IssueTypeSpam;
            set => __pbn__Type = value;
        }
        public bool ShouldSerializeType() => __pbn__Type != null;
        public void ResetType() => __pbn__Type = null;
        private IssueType? __pbn__Type;

        [global::ProtoBuf.ProtoMember(3, Name = @"source")]
        [global::System.ComponentModel.DefaultValue(UserSource.UserSourceOther)]
        public UserSource Source
        {
            get => __pbn__Source ?? UserSource.UserSourceOther;
            set => __pbn__Source = value;
        }
        public bool ShouldSerializeSource() => __pbn__Source != null;
        public void ResetSource() => __pbn__Source = null;
        private UserSource? __pbn__Source;

        [global::ProtoBuf.ProtoMember(4, Name = @"item")]
        public ReportItem Item { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ClubOptions : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"club_id")]
        public ulong ClubId
        {
            get => __pbn__ClubId.GetValueOrDefault();
            set => __pbn__ClubId = value;
        }
        public bool ShouldSerializeClubId() => __pbn__ClubId != null;
        public void ResetClubId() => __pbn__ClubId = null;
        private ulong? __pbn__ClubId;

        [global::ProtoBuf.ProtoMember(2, Name = @"stream_id")]
        public ulong StreamId
        {
            get => __pbn__StreamId.GetValueOrDefault();
            set => __pbn__StreamId = value;
        }
        public bool ShouldSerializeStreamId() => __pbn__StreamId != null;
        public void ResetStreamId() => __pbn__StreamId = null;
        private ulong? __pbn__StreamId;

        [global::ProtoBuf.ProtoMember(3, Name = @"type")]
        [global::System.ComponentModel.DefaultValue(IssueType.IssueTypeSpam)]
        public IssueType Type
        {
            get => __pbn__Type ?? IssueType.IssueTypeSpam;
            set => __pbn__Type = value;
        }
        public bool ShouldSerializeType() => __pbn__Type != null;
        public void ResetType() => __pbn__Type = null;
        private IssueType? __pbn__Type;

        [global::ProtoBuf.ProtoMember(4, Name = @"source")]
        [global::System.ComponentModel.DefaultValue(ClubSource.ClubSourceOther)]
        public ClubSource Source
        {
            get => __pbn__Source ?? ClubSource.ClubSourceOther;
            set => __pbn__Source = value;
        }
        public bool ShouldSerializeSource() => __pbn__Source != null;
        public void ResetSource() => __pbn__Source = null;
        private ClubSource? __pbn__Source;

        [global::ProtoBuf.ProtoMember(5, Name = @"item")]
        public ReportItem Item { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class EntityOptions : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"entity_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string EntityId
        {
            get => __pbn__EntityId ?? "";
            set => __pbn__EntityId = value;
        }
        public bool ShouldSerializeEntityId() => __pbn__EntityId != null;
        public void ResetEntityId() => __pbn__EntityId = null;
        private string __pbn__EntityId;

        [global::ProtoBuf.ProtoMember(2, Name = @"entity_type")]
        [global::System.ComponentModel.DefaultValue("")]
        public string EntityType
        {
            get => __pbn__EntityType ?? "";
            set => __pbn__EntityType = value;
        }
        public bool ShouldSerializeEntityType() => __pbn__EntityType != null;
        public void ResetEntityType() => __pbn__EntityType = null;
        private string __pbn__EntityType;

        [global::ProtoBuf.ProtoMember(5, Name = @"attribute")]
        public global::System.Collections.Generic.List<global::bgs.protocol.v2.Attribute> Attributes { get; } = new global::System.Collections.Generic.List<global::bgs.protocol.v2.Attribute>();

    }

    [global::ProtoBuf.ProtoContract()]
    public enum IssueType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"ISSUE_TYPE_SPAM")]
        IssueTypeSpam = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"ISSUE_TYPE_HARASSMENT")]
        IssueTypeHarassment = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"ISSUE_TYPE_OFFENSIVE_CONTENT")]
        IssueTypeOffensiveContent = 3,
        [global::ProtoBuf.ProtoEnum(Name = @"ISSUE_TYPE_HACKING")]
        IssueTypeHacking = 4,
        [global::ProtoBuf.ProtoEnum(Name = @"ISSUE_TYPE_BOTTING")]
        IssueTypeBotting = 5,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum UserSource
    {
        [global::ProtoBuf.ProtoEnum(Name = @"USER_SOURCE_OTHER")]
        UserSourceOther = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"USER_SOURCE_WHISPER")]
        UserSourceWhisper = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"USER_SOURCE_PROFILE")]
        UserSourceProfile = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"USER_SOURCE_BATTLE_TAG")]
        UserSourceBattleTag = 3,
        [global::ProtoBuf.ProtoEnum(Name = @"USER_SOURCE_CHAT")]
        UserSourceChat = 4,
        [global::ProtoBuf.ProtoEnum(Name = @"USER_SOURCE_FRIEND_INVITATION")]
        UserSourceFriendInvitation = 5,
        [global::ProtoBuf.ProtoEnum(Name = @"USER_SOURCE_VOICE")]
        UserSourceVoice = 6,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ClubSource
    {
        [global::ProtoBuf.ProtoEnum(Name = @"CLUB_SOURCE_OTHER")]
        ClubSourceOther = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"CLUB_SOURCE_MESSAGE")]
        ClubSourceMessage = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"CLUB_SOURCE_CLUB_NAME")]
        ClubSourceClubName = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"CLUB_SOURCE_STREAM_NAME")]
        ClubSourceStreamName = 3,
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
