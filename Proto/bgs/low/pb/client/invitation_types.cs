// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: invitation_types.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace bgs.protocol
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Invitation : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", DataFormat = global::ProtoBuf.DataFormat.FixedSize, IsRequired = true)]
        public ulong Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"inviter_identity", IsRequired = true)]
        public Identity InviterIdentity { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"invitee_identity", IsRequired = true)]
        public Identity InviteeIdentity { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"inviter_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string InviterName
        {
            get => __pbn__InviterName ?? "";
            set => __pbn__InviterName = value;
        }
        public bool ShouldSerializeInviterName() => __pbn__InviterName != null;
        public void ResetInviterName() => __pbn__InviterName = null;
        private string __pbn__InviterName;

        [global::ProtoBuf.ProtoMember(5, Name = @"invitee_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string InviteeName
        {
            get => __pbn__InviteeName ?? "";
            set => __pbn__InviteeName = value;
        }
        public bool ShouldSerializeInviteeName() => __pbn__InviteeName != null;
        public void ResetInviteeName() => __pbn__InviteeName = null;
        private string __pbn__InviteeName;

        [global::ProtoBuf.ProtoMember(6, Name = @"invitation_message")]
        [global::System.ComponentModel.DefaultValue("")]
        public string InvitationMessage
        {
            get => __pbn__InvitationMessage ?? "";
            set => __pbn__InvitationMessage = value;
        }
        public bool ShouldSerializeInvitationMessage() => __pbn__InvitationMessage != null;
        public void ResetInvitationMessage() => __pbn__InvitationMessage = null;
        private string __pbn__InvitationMessage;

        [global::ProtoBuf.ProtoMember(7, Name = @"creation_time")]
        public ulong CreationTime
        {
            get => __pbn__CreationTime.GetValueOrDefault();
            set => __pbn__CreationTime = value;
        }
        public bool ShouldSerializeCreationTime() => __pbn__CreationTime != null;
        public void ResetCreationTime() => __pbn__CreationTime = null;
        private ulong? __pbn__CreationTime;

        [global::ProtoBuf.ProtoMember(8, Name = @"expiration_time")]
        public ulong ExpirationTime
        {
            get => __pbn__ExpirationTime.GetValueOrDefault();
            set => __pbn__ExpirationTime = value;
        }
        public bool ShouldSerializeExpirationTime() => __pbn__ExpirationTime != null;
        public void ResetExpirationTime() => __pbn__ExpirationTime = null;
        private ulong? __pbn__ExpirationTime;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class InvitationParams : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"invitation_message")]
        [global::System.ComponentModel.DefaultValue("")]
        [global::System.Obsolete]
        public string InvitationMessage
        {
            get => __pbn__InvitationMessage ?? "";
            set => __pbn__InvitationMessage = value;
        }
        public bool ShouldSerializeInvitationMessage() => __pbn__InvitationMessage != null;
        public void ResetInvitationMessage() => __pbn__InvitationMessage = null;
        private string __pbn__InvitationMessage;

        [global::ProtoBuf.ProtoMember(2, Name = @"expiration_time")]
        public ulong ExpirationTime
        {
            get => __pbn__ExpirationTime.GetValueOrDefault();
            set => __pbn__ExpirationTime = value;
        }
        public bool ShouldSerializeExpirationTime() => __pbn__ExpirationTime != null;
        public void ResetExpirationTime() => __pbn__ExpirationTime = null;
        private ulong? __pbn__ExpirationTime;

    }

    [global::ProtoBuf.ProtoContract()]
    public enum InvitationRemovedReason
    {
        [global::ProtoBuf.ProtoEnum(Name = @"INVITATION_REMOVED_REASON_ACCEPTED")]
        InvitationRemovedReasonAccepted = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"INVITATION_REMOVED_REASON_DECLINED")]
        InvitationRemovedReasonDeclined = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"INVITATION_REMOVED_REASON_REVOKED")]
        InvitationRemovedReasonRevoked = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"INVITATION_REMOVED_REASON_IGNORED")]
        InvitationRemovedReasonIgnored = 3,
        [global::ProtoBuf.ProtoEnum(Name = @"INVITATION_REMOVED_REASON_EXPIRED")]
        InvitationRemovedReasonExpired = 4,
        [global::ProtoBuf.ProtoEnum(Name = @"INVITATION_REMOVED_REASON_CANCELED")]
        InvitationRemovedReasonCanceled = 5,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum SuggestionRemovedReason
    {
        [global::ProtoBuf.ProtoEnum(Name = @"SUGGESTION_REMOVED_REASON_APPROVED")]
        SuggestionRemovedReasonApproved = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"SUGGESTION_REMOVED_REASON_DECLINED")]
        SuggestionRemovedReasonDeclined = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"SUGGESTION_REMOVED_REASON_EXPIRED")]
        SuggestionRemovedReasonExpired = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"SUGGESTION_REMOVED_REASON_CANCELED")]
        SuggestionRemovedReasonCanceled = 3,
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
