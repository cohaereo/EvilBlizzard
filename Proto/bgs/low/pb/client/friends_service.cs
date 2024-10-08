// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: friends_service.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace bgs.protocol.friends.v1
{

    [global::ProtoBuf.ProtoContract()]
    public partial class SubscribeRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"agent_id")]
        public global::bgs.protocol.EntityId AgentId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"object_id", IsRequired = true)]
        public ulong ObjectId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class UnsubscribeRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"agent_id")]
        public global::bgs.protocol.EntityId AgentId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"object_id")]
        public ulong ObjectId
        {
            get => __pbn__ObjectId.GetValueOrDefault();
            set => __pbn__ObjectId = value;
        }
        public bool ShouldSerializeObjectId() => __pbn__ObjectId != null;
        public void ResetObjectId() => __pbn__ObjectId = null;
        private ulong? __pbn__ObjectId;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SendInvitationRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"agent_identity")]
        public global::bgs.protocol.Identity AgentIdentity { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"target_id", IsRequired = true)]
        public global::bgs.protocol.EntityId TargetId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"params", IsRequired = true)]
        public global::bgs.protocol.InvitationParams Params { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RevokeInvitationRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"agent_id")]
        public global::bgs.protocol.EntityId AgentId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"invitation_id", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong InvitationId
        {
            get => __pbn__InvitationId.GetValueOrDefault();
            set => __pbn__InvitationId = value;
        }
        public bool ShouldSerializeInvitationId() => __pbn__InvitationId != null;
        public void ResetInvitationId() => __pbn__InvitationId = null;
        private ulong? __pbn__InvitationId;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class AcceptInvitationRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"agent_id")]
        public global::bgs.protocol.EntityId AgentId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"invitation_id", DataFormat = global::ProtoBuf.DataFormat.FixedSize, IsRequired = true)]
        public ulong InvitationId { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"options")]
        public AcceptInvitationOptions Options { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DeclineInvitationRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"agent_id")]
        public global::bgs.protocol.EntityId AgentId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"invitation_id", DataFormat = global::ProtoBuf.DataFormat.FixedSize, IsRequired = true)]
        public ulong InvitationId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class IgnoreInvitationRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"agent_id")]
        public global::bgs.protocol.EntityId AgentId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"invitation_id", DataFormat = global::ProtoBuf.DataFormat.FixedSize, IsRequired = true)]
        public ulong InvitationId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RemoveFriendRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"agent_id")]
        public global::bgs.protocol.EntityId AgentId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"target_id", IsRequired = true)]
        public global::bgs.protocol.EntityId TargetId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RevokeAllInvitationsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(2, Name = @"agent_id")]
        public global::bgs.protocol.EntityId AgentId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ViewFriendsRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"agent_id")]
        public global::bgs.protocol.EntityId AgentId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"target_id", IsRequired = true)]
        public global::bgs.protocol.EntityId TargetId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ViewFriendsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"friends")]
        public global::System.Collections.Generic.List<FriendOfFriend> Friends { get; } = new global::System.Collections.Generic.List<FriendOfFriend>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class UpdateFriendStateRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"agent_id")]
        public global::bgs.protocol.EntityId AgentId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"target_id", IsRequired = true)]
        public global::bgs.protocol.EntityId TargetId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"attribute")]
        public global::System.Collections.Generic.List<global::bgs.protocol.v2.Attribute> Attributes { get; } = new global::System.Collections.Generic.List<global::bgs.protocol.v2.Attribute>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SetAttributeRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"agent_id")]
        public global::bgs.protocol.account.v1.AccountId AgentId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"target_id")]
        public global::bgs.protocol.account.v1.AccountId TargetId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"attribute")]
        public global::System.Collections.Generic.List<global::bgs.protocol.v2.Attribute> Attributes { get; } = new global::System.Collections.Generic.List<global::bgs.protocol.v2.Attribute>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetFriendListRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(2, Name = @"agent_id")]
        public global::bgs.protocol.EntityId AgentId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetFriendListResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"friends")]
        public global::System.Collections.Generic.List<Friend> Friends { get; } = new global::System.Collections.Generic.List<Friend>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CreateFriendshipRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"agent_id")]
        public global::bgs.protocol.EntityId AgentId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"target_id")]
        public global::bgs.protocol.EntityId TargetId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"role")]
        public uint[] Roles { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class FriendNotification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"target", IsRequired = true)]
        public Friend Target { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"account_id")]
        public global::bgs.protocol.EntityId AccountId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class UpdateFriendStateNotification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"changed_friend", IsRequired = true)]
        public Friend ChangedFriend { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"account_id")]
        public global::bgs.protocol.EntityId AccountId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class InvitationNotification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"invitation", IsRequired = true)]
        public ReceivedInvitation Invitation { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"reason")]
        [global::System.ComponentModel.DefaultValue(0u)]
        public uint Reason
        {
            get => __pbn__Reason ?? 0u;
            set => __pbn__Reason = value;
        }
        public bool ShouldSerializeReason() => __pbn__Reason != null;
        public void ResetReason() => __pbn__Reason = null;
        private uint? __pbn__Reason;

        [global::ProtoBuf.ProtoMember(5, Name = @"account_id")]
        public global::bgs.protocol.EntityId AccountId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SentInvitationAddedNotification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"account_id")]
        public global::bgs.protocol.EntityId AccountId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"invitation")]
        public SentInvitation Invitation { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SentInvitationRemovedNotification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"account_id")]
        public global::bgs.protocol.EntityId AccountId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"invitation_id", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong InvitationId
        {
            get => __pbn__InvitationId.GetValueOrDefault();
            set => __pbn__InvitationId = value;
        }
        public bool ShouldSerializeInvitationId() => __pbn__InvitationId != null;
        public void ResetInvitationId() => __pbn__InvitationId = null;
        private ulong? __pbn__InvitationId;

        [global::ProtoBuf.ProtoMember(3, Name = @"reason")]
        public uint Reason
        {
            get => __pbn__Reason.GetValueOrDefault();
            set => __pbn__Reason = value;
        }
        public bool ShouldSerializeReason() => __pbn__Reason != null;
        public void ResetReason() => __pbn__Reason = null;
        private uint? __pbn__Reason;

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
