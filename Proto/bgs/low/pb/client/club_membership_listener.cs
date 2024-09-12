// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: club_membership_listener.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace bgs.protocol.club.v1.membership
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ClubAddedNotification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"agent_id")]
        public global::bgs.protocol.club.v1.MemberId AgentId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"membership")]
        public global::bgs.protocol.club.v1.ClubMembershipDescription Membership { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ClubRemovedNotification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"agent_id")]
        public global::bgs.protocol.club.v1.MemberId AgentId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"member_id")]
        public global::bgs.protocol.club.v1.MemberId MemberId { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"club_id")]
        public ulong ClubId
        {
            get => __pbn__ClubId.GetValueOrDefault();
            set => __pbn__ClubId = value;
        }
        public bool ShouldSerializeClubId() => __pbn__ClubId != null;
        public void ResetClubId() => __pbn__ClubId = null;
        private ulong? __pbn__ClubId;

        [global::ProtoBuf.ProtoMember(5, Name = @"reason")]
        [global::System.ComponentModel.DefaultValue(global::bgs.protocol.club.v1.ClubRemovedReason.ClubRemovedReasonNone)]
        public global::bgs.protocol.club.v1.ClubRemovedReason Reason
        {
            get => __pbn__Reason ?? global::bgs.protocol.club.v1.ClubRemovedReason.ClubRemovedReasonNone;
            set => __pbn__Reason = value;
        }
        public bool ShouldSerializeReason() => __pbn__Reason != null;
        public void ResetReason() => __pbn__Reason = null;
        private global::bgs.protocol.club.v1.ClubRemovedReason? __pbn__Reason;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ReceivedInvitationAddedNotification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"agent_id")]
        public global::bgs.protocol.club.v1.MemberId AgentId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"invitation")]
        public global::bgs.protocol.club.v1.ClubInvitation Invitation { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ReceivedInvitationRemovedNotification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"agent_id")]
        public global::bgs.protocol.club.v1.MemberId AgentId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"invitation_id", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong InvitationId
        {
            get => __pbn__InvitationId.GetValueOrDefault();
            set => __pbn__InvitationId = value;
        }
        public bool ShouldSerializeInvitationId() => __pbn__InvitationId != null;
        public void ResetInvitationId() => __pbn__InvitationId = null;
        private ulong? __pbn__InvitationId;

        [global::ProtoBuf.ProtoMember(4, Name = @"reason")]
        [global::System.ComponentModel.DefaultValue(global::bgs.protocol.InvitationRemovedReason.InvitationRemovedReasonAccepted)]
        public global::bgs.protocol.InvitationRemovedReason Reason
        {
            get => __pbn__Reason ?? global::bgs.protocol.InvitationRemovedReason.InvitationRemovedReasonAccepted;
            set => __pbn__Reason = value;
        }
        public bool ShouldSerializeReason() => __pbn__Reason != null;
        public void ResetReason() => __pbn__Reason = null;
        private global::bgs.protocol.InvitationRemovedReason? __pbn__Reason;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SharedSettingsChangedNotification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"agent_id")]
        public global::bgs.protocol.account.v1.AccountId AgentId { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"assignment")]
        public global::bgs.protocol.club.v1.ClubSharedSettingsAssignment Assignment { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class StreamMentionAddedNotification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"agent_id")]
        public global::bgs.protocol.club.v1.MemberId AgentId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"mention")]
        public global::bgs.protocol.club.v1.StreamMention Mention { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class StreamMentionRemovedNotification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"agent_id")]
        public global::bgs.protocol.account.v1.AccountId AgentId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"mention_id")]
        public global::bgs.protocol.TimeSeriesId MentionId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class StreamMentionAdvanceViewTimeNotification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"agent_id")]
        public global::bgs.protocol.account.v1.AccountId AgentId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"view_time")]
        public ulong ViewTime
        {
            get => __pbn__ViewTime.GetValueOrDefault();
            set => __pbn__ViewTime = value;
        }
        public bool ShouldSerializeViewTime() => __pbn__ViewTime != null;
        public void ResetViewTime() => __pbn__ViewTime = null;
        private ulong? __pbn__ViewTime;

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
