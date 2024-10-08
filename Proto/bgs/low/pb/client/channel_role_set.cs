// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: channel_role_set.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace bgs.protocol.channel
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ChannelPrivilegeSet : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"can_invite")]
        public bool CanInvite
        {
            get => __pbn__CanInvite.GetValueOrDefault();
            set => __pbn__CanInvite = value;
        }
        public bool ShouldSerializeCanInvite() => __pbn__CanInvite != null;
        public void ResetCanInvite() => __pbn__CanInvite = null;
        private bool? __pbn__CanInvite;

        [global::ProtoBuf.ProtoMember(2, Name = @"can_invite_with_reservation")]
        public bool CanInviteWithReservation
        {
            get => __pbn__CanInviteWithReservation.GetValueOrDefault();
            set => __pbn__CanInviteWithReservation = value;
        }
        public bool ShouldSerializeCanInviteWithReservation() => __pbn__CanInviteWithReservation != null;
        public void ResetCanInviteWithReservation() => __pbn__CanInviteWithReservation = null;
        private bool? __pbn__CanInviteWithReservation;

        [global::ProtoBuf.ProtoMember(3, Name = @"can_revoke_other_invitation")]
        public bool CanRevokeOtherInvitation
        {
            get => __pbn__CanRevokeOtherInvitation.GetValueOrDefault();
            set => __pbn__CanRevokeOtherInvitation = value;
        }
        public bool ShouldSerializeCanRevokeOtherInvitation() => __pbn__CanRevokeOtherInvitation != null;
        public void ResetCanRevokeOtherInvitation() => __pbn__CanRevokeOtherInvitation = null;
        private bool? __pbn__CanRevokeOtherInvitation;

        [global::ProtoBuf.ProtoMember(4, Name = @"can_revoke_own_invitation")]
        public bool CanRevokeOwnInvitation
        {
            get => __pbn__CanRevokeOwnInvitation.GetValueOrDefault();
            set => __pbn__CanRevokeOwnInvitation = value;
        }
        public bool ShouldSerializeCanRevokeOwnInvitation() => __pbn__CanRevokeOwnInvitation != null;
        public void ResetCanRevokeOwnInvitation() => __pbn__CanRevokeOwnInvitation = null;
        private bool? __pbn__CanRevokeOwnInvitation;

        [global::ProtoBuf.ProtoMember(5, Name = @"can_kick")]
        public bool CanKick
        {
            get => __pbn__CanKick.GetValueOrDefault();
            set => __pbn__CanKick = value;
        }
        public bool ShouldSerializeCanKick() => __pbn__CanKick != null;
        public void ResetCanKick() => __pbn__CanKick = null;
        private bool? __pbn__CanKick;

        [global::ProtoBuf.ProtoMember(6, Name = @"can_dissolve")]
        public bool CanDissolve
        {
            get => __pbn__CanDissolve.GetValueOrDefault();
            set => __pbn__CanDissolve = value;
        }
        public bool ShouldSerializeCanDissolve() => __pbn__CanDissolve != null;
        public void ResetCanDissolve() => __pbn__CanDissolve = null;
        private bool? __pbn__CanDissolve;

        [global::ProtoBuf.ProtoMember(7, Name = @"can_set_privacy")]
        public bool CanSetPrivacy
        {
            get => __pbn__CanSetPrivacy.GetValueOrDefault();
            set => __pbn__CanSetPrivacy = value;
        }
        public bool ShouldSerializeCanSetPrivacy() => __pbn__CanSetPrivacy != null;
        public void ResetCanSetPrivacy() => __pbn__CanSetPrivacy = null;
        private bool? __pbn__CanSetPrivacy;

        [global::ProtoBuf.ProtoMember(8, Name = @"can_send_message")]
        public bool CanSendMessage
        {
            get => __pbn__CanSendMessage.GetValueOrDefault();
            set => __pbn__CanSendMessage = value;
        }
        public bool ShouldSerializeCanSendMessage() => __pbn__CanSendMessage != null;
        public void ResetCanSendMessage() => __pbn__CanSendMessage = null;
        private bool? __pbn__CanSendMessage;

        [global::ProtoBuf.ProtoMember(9, Name = @"can_receive_message")]
        public bool CanReceiveMessage
        {
            get => __pbn__CanReceiveMessage.GetValueOrDefault();
            set => __pbn__CanReceiveMessage = value;
        }
        public bool ShouldSerializeCanReceiveMessage() => __pbn__CanReceiveMessage != null;
        public void ResetCanReceiveMessage() => __pbn__CanReceiveMessage = null;
        private bool? __pbn__CanReceiveMessage;

        [global::ProtoBuf.ProtoMember(10, Name = @"can_set_attribute")]
        public bool CanSetAttribute
        {
            get => __pbn__CanSetAttribute.GetValueOrDefault();
            set => __pbn__CanSetAttribute = value;
        }
        public bool ShouldSerializeCanSetAttribute() => __pbn__CanSetAttribute != null;
        public void ResetCanSetAttribute() => __pbn__CanSetAttribute = null;
        private bool? __pbn__CanSetAttribute;

        [global::ProtoBuf.ProtoMember(11, Name = @"can_set_other_member_attribute")]
        public bool CanSetOtherMemberAttribute
        {
            get => __pbn__CanSetOtherMemberAttribute.GetValueOrDefault();
            set => __pbn__CanSetOtherMemberAttribute = value;
        }
        public bool ShouldSerializeCanSetOtherMemberAttribute() => __pbn__CanSetOtherMemberAttribute != null;
        public void ResetCanSetOtherMemberAttribute() => __pbn__CanSetOtherMemberAttribute = null;
        private bool? __pbn__CanSetOtherMemberAttribute;

        [global::ProtoBuf.ProtoMember(12, Name = @"can_set_own_member_attribute")]
        public bool CanSetOwnMemberAttribute
        {
            get => __pbn__CanSetOwnMemberAttribute.GetValueOrDefault();
            set => __pbn__CanSetOwnMemberAttribute = value;
        }
        public bool ShouldSerializeCanSetOwnMemberAttribute() => __pbn__CanSetOwnMemberAttribute != null;
        public void ResetCanSetOwnMemberAttribute() => __pbn__CanSetOwnMemberAttribute = null;
        private bool? __pbn__CanSetOwnMemberAttribute;

        [global::ProtoBuf.ProtoMember(13, Name = @"can_enter_game")]
        public bool CanEnterGame
        {
            get => __pbn__CanEnterGame.GetValueOrDefault();
            set => __pbn__CanEnterGame = value;
        }
        public bool ShouldSerializeCanEnterGame() => __pbn__CanEnterGame != null;
        public void ResetCanEnterGame() => __pbn__CanEnterGame = null;
        private bool? __pbn__CanEnterGame;

        [global::ProtoBuf.ProtoMember(14, Name = @"can_suggest")]
        public bool CanSuggest
        {
            get => __pbn__CanSuggest.GetValueOrDefault();
            set => __pbn__CanSuggest = value;
        }
        public bool ShouldSerializeCanSuggest() => __pbn__CanSuggest != null;
        public void ResetCanSuggest() => __pbn__CanSuggest = null;
        private bool? __pbn__CanSuggest;

        [global::ProtoBuf.ProtoMember(15, Name = @"can_approve")]
        public bool CanApprove
        {
            get => __pbn__CanApprove.GetValueOrDefault();
            set => __pbn__CanApprove = value;
        }
        public bool ShouldSerializeCanApprove() => __pbn__CanApprove != null;
        public void ResetCanApprove() => __pbn__CanApprove = null;
        private bool? __pbn__CanApprove;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ChannelRole : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public uint Id
        {
            get => __pbn__Id.GetValueOrDefault();
            set => __pbn__Id = value;
        }
        public bool ShouldSerializeId() => __pbn__Id != null;
        public void ResetId() => __pbn__Id = null;
        private uint? __pbn__Id;

        [global::ProtoBuf.ProtoMember(2, Name = @"state")]
        public global::bgs.protocol.RoleState State { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"privilege")]
        public ChannelPrivilegeSet Privilege { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ChannelRoleSet : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"role")]
        public global::System.Collections.Generic.List<ChannelRole> Roles { get; } = new global::System.Collections.Generic.List<ChannelRole>();

        [global::ProtoBuf.ProtoMember(2, Name = @"default_role")]
        public uint[] DefaultRoles { get; set; }

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
