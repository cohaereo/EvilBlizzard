// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: friends_types.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace bgs.protocol.friends.v1
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Friend : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"account_id", IsRequired = true)]
        public global::bgs.protocol.EntityId AccountId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"attribute")]
        public global::System.Collections.Generic.List<global::bgs.protocol.v2.Attribute> Attributes { get; } = new global::System.Collections.Generic.List<global::bgs.protocol.v2.Attribute>();

        [global::ProtoBuf.ProtoMember(3, Name = @"role")]
        public uint[] Roles { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"privileges")]
        [global::System.ComponentModel.DefaultValue(typeof(ulong), "0")]
        public ulong Privileges
        {
            get => __pbn__Privileges ?? 0ul;
            set => __pbn__Privileges = value;
        }
        public bool ShouldSerializePrivileges() => __pbn__Privileges != null;
        public void ResetPrivileges() => __pbn__Privileges = null;
        private ulong? __pbn__Privileges;

        [global::ProtoBuf.ProtoMember(5, Name = @"attributes_epoch")]
        public ulong AttributesEpoch
        {
            get => __pbn__AttributesEpoch.GetValueOrDefault();
            set => __pbn__AttributesEpoch = value;
        }
        public bool ShouldSerializeAttributesEpoch() => __pbn__AttributesEpoch != null;
        public void ResetAttributesEpoch() => __pbn__AttributesEpoch = null;
        private ulong? __pbn__AttributesEpoch;

        [global::ProtoBuf.ProtoMember(6, Name = @"creation_time")]
        public ulong CreationTime
        {
            get => __pbn__CreationTime.GetValueOrDefault();
            set => __pbn__CreationTime = value;
        }
        public bool ShouldSerializeCreationTime() => __pbn__CreationTime != null;
        public void ResetCreationTime() => __pbn__CreationTime = null;
        private ulong? __pbn__CreationTime;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class FriendOfFriend : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"account_id")]
        public global::bgs.protocol.EntityId AccountId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"role")]
        public uint[] Roles { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"privileges")]
        [global::System.ComponentModel.DefaultValue(typeof(ulong), "0")]
        public ulong Privileges
        {
            get => __pbn__Privileges ?? 0ul;
            set => __pbn__Privileges = value;
        }
        public bool ShouldSerializePrivileges() => __pbn__Privileges != null;
        public void ResetPrivileges() => __pbn__Privileges = null;
        private ulong? __pbn__Privileges;

        [global::ProtoBuf.ProtoMember(6, Name = @"full_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string FullName
        {
            get => __pbn__FullName ?? "";
            set => __pbn__FullName = value;
        }
        public bool ShouldSerializeFullName() => __pbn__FullName != null;
        public void ResetFullName() => __pbn__FullName = null;
        private string __pbn__FullName;

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

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ReceivedInvitation : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", DataFormat = global::ProtoBuf.DataFormat.FixedSize, IsRequired = true)]
        public ulong Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"inviter_identity", IsRequired = true)]
        public global::bgs.protocol.Identity InviterIdentity { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"invitee_identity", IsRequired = true)]
        public global::bgs.protocol.Identity InviteeIdentity { get; set; }

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

        [global::ProtoBuf.ProtoMember(9, Name = @"program", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
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
    public partial class FriendInvitation : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(2, Name = @"role")]
        public uint[] Roles { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"attribute")]
        public global::System.Collections.Generic.List<global::bgs.protocol.v2.Attribute> Attributes { get; } = new global::System.Collections.Generic.List<global::bgs.protocol.v2.Attribute>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SentInvitation : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong Id
        {
            get => __pbn__Id.GetValueOrDefault();
            set => __pbn__Id = value;
        }
        public bool ShouldSerializeId() => __pbn__Id != null;
        public void ResetId() => __pbn__Id = null;
        private ulong? __pbn__Id;

        [global::ProtoBuf.ProtoMember(2, Name = @"target_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string TargetName
        {
            get => __pbn__TargetName ?? "";
            set => __pbn__TargetName = value;
        }
        public bool ShouldSerializeTargetName() => __pbn__TargetName != null;
        public void ResetTargetName() => __pbn__TargetName = null;
        private string __pbn__TargetName;

        [global::ProtoBuf.ProtoMember(3, Name = @"role")]
        public uint Role
        {
            get => __pbn__Role.GetValueOrDefault();
            set => __pbn__Role = value;
        }
        public bool ShouldSerializeRole() => __pbn__Role != null;
        public void ResetRole() => __pbn__Role = null;
        private uint? __pbn__Role;

        [global::ProtoBuf.ProtoMember(4, Name = @"attribute")]
        public global::System.Collections.Generic.List<global::bgs.protocol.v2.Attribute> Attributes { get; } = new global::System.Collections.Generic.List<global::bgs.protocol.v2.Attribute>();

        [global::ProtoBuf.ProtoMember(5, Name = @"creation_time")]
        public ulong CreationTime
        {
            get => __pbn__CreationTime.GetValueOrDefault();
            set => __pbn__CreationTime = value;
        }
        public bool ShouldSerializeCreationTime() => __pbn__CreationTime != null;
        public void ResetCreationTime() => __pbn__CreationTime = null;
        private ulong? __pbn__CreationTime;

        [global::ProtoBuf.ProtoMember(6, Name = @"program", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
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
    public partial class FriendInvitationParams : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"target_email")]
        [global::System.ComponentModel.DefaultValue("")]
        public string TargetEmail
        {
            get => __pbn__TargetEmail ?? "";
            set => __pbn__TargetEmail = value;
        }
        public bool ShouldSerializeTargetEmail() => __pbn__TargetEmail != null;
        public void ResetTargetEmail() => __pbn__TargetEmail = null;
        private string __pbn__TargetEmail;

        [global::ProtoBuf.ProtoMember(2, Name = @"target_battle_tag")]
        [global::System.ComponentModel.DefaultValue("")]
        public string TargetBattleTag
        {
            get => __pbn__TargetBattleTag ?? "";
            set => __pbn__TargetBattleTag = value;
        }
        public bool ShouldSerializeTargetBattleTag() => __pbn__TargetBattleTag != null;
        public void ResetTargetBattleTag() => __pbn__TargetBattleTag = null;
        private string __pbn__TargetBattleTag;

        [global::ProtoBuf.ProtoMember(6, Name = @"role")]
        public uint[] Roles { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"attribute")]
        public global::System.Collections.Generic.List<global::bgs.protocol.v2.Attribute> Attributes { get; } = new global::System.Collections.Generic.List<global::bgs.protocol.v2.Attribute>();

        [global::ProtoBuf.ProtoMember(9, Name = @"target_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string TargetName
        {
            get => __pbn__TargetName ?? "";
            set => __pbn__TargetName = value;
        }
        public bool ShouldSerializeTargetName() => __pbn__TargetName != null;
        public void ResetTargetName() => __pbn__TargetName = null;
        private string __pbn__TargetName;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SubscribeResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"max_friends")]
        public uint MaxFriends
        {
            get => __pbn__MaxFriends.GetValueOrDefault();
            set => __pbn__MaxFriends = value;
        }
        public bool ShouldSerializeMaxFriends() => __pbn__MaxFriends != null;
        public void ResetMaxFriends() => __pbn__MaxFriends = null;
        private uint? __pbn__MaxFriends;

        [global::ProtoBuf.ProtoMember(2, Name = @"max_received_invitations")]
        public uint MaxReceivedInvitations
        {
            get => __pbn__MaxReceivedInvitations.GetValueOrDefault();
            set => __pbn__MaxReceivedInvitations = value;
        }
        public bool ShouldSerializeMaxReceivedInvitations() => __pbn__MaxReceivedInvitations != null;
        public void ResetMaxReceivedInvitations() => __pbn__MaxReceivedInvitations = null;
        private uint? __pbn__MaxReceivedInvitations;

        [global::ProtoBuf.ProtoMember(3, Name = @"max_sent_invitations")]
        public uint MaxSentInvitations
        {
            get => __pbn__MaxSentInvitations.GetValueOrDefault();
            set => __pbn__MaxSentInvitations = value;
        }
        public bool ShouldSerializeMaxSentInvitations() => __pbn__MaxSentInvitations != null;
        public void ResetMaxSentInvitations() => __pbn__MaxSentInvitations = null;
        private uint? __pbn__MaxSentInvitations;

        [global::ProtoBuf.ProtoMember(4, Name = @"role")]
        public global::System.Collections.Generic.List<global::bgs.protocol.Role> Roles { get; } = new global::System.Collections.Generic.List<global::bgs.protocol.Role>();

        [global::ProtoBuf.ProtoMember(5, Name = @"friends")]
        public global::System.Collections.Generic.List<Friend> Friends { get; } = new global::System.Collections.Generic.List<Friend>();

        [global::ProtoBuf.ProtoMember(7, Name = @"received_invitations")]
        public global::System.Collections.Generic.List<ReceivedInvitation> ReceivedInvitations { get; } = new global::System.Collections.Generic.List<ReceivedInvitation>();

        [global::ProtoBuf.ProtoMember(8, Name = @"sent_invitations")]
        public global::System.Collections.Generic.List<SentInvitation> SentInvitations { get; } = new global::System.Collections.Generic.List<SentInvitation>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class AcceptInvitationOptions : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"role")]
        public uint Role
        {
            get => __pbn__Role.GetValueOrDefault();
            set => __pbn__Role = value;
        }
        public bool ShouldSerializeRole() => __pbn__Role != null;
        public void ResetRole() => __pbn__Role = null;
        private uint? __pbn__Role;

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
