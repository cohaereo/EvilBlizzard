// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: report_service.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace bgs.protocol.report.v2
{

    [global::ProtoBuf.ProtoContract()]
    public partial class SubmitReportRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"agent_id")]
        public global::bgs.protocol.account.v1.AccountId AgentId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"user_description")]
        [global::System.ComponentModel.DefaultValue("")]
        public string UserDescription
        {
            get => __pbn__UserDescription ?? "";
            set => __pbn__UserDescription = value;
        }
        public bool ShouldSerializeUserDescription() => __pbn__UserDescription != null;
        public void ResetUserDescription() => __pbn__UserDescription = null;
        private string __pbn__UserDescription;

        [global::ProtoBuf.ProtoMember(10, Name = @"user_options")]
        public UserOptions UserOptions
        {
            get => __pbn__type.Is(10) ? ((UserOptions)__pbn__type.Object) : default;
            set => __pbn__type = new global::ProtoBuf.DiscriminatedUnionObject(10, value);
        }
        public bool ShouldSerializeUserOptions() => __pbn__type.Is(10);
        public void ResetUserOptions() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__type, 10);

        private global::ProtoBuf.DiscriminatedUnionObject __pbn__type;

        [global::ProtoBuf.ProtoMember(11, Name = @"club_options")]
        public ClubOptions ClubOptions
        {
            get => __pbn__type.Is(11) ? ((ClubOptions)__pbn__type.Object) : default;
            set => __pbn__type = new global::ProtoBuf.DiscriminatedUnionObject(11, value);
        }
        public bool ShouldSerializeClubOptions() => __pbn__type.Is(11);
        public void ResetClubOptions() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__type, 11);

        [global::ProtoBuf.ProtoMember(20, Name = @"entity_options")]
        public EntityOptions EntityOptions
        {
            get => __pbn__type.Is(20) ? ((EntityOptions)__pbn__type.Object) : default;
            set => __pbn__type = new global::ProtoBuf.DiscriminatedUnionObject(20, value);
        }
        public bool ShouldSerializeEntityOptions() => __pbn__type.Is(20);
        public void ResetEntityOptions() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__type, 20);

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
