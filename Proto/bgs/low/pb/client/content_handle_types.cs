// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: content_handle_types.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace bgs.protocol
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ContentHandle : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"region", DataFormat = global::ProtoBuf.DataFormat.FixedSize, IsRequired = true)]
        public uint Region { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"usage", DataFormat = global::ProtoBuf.DataFormat.FixedSize, IsRequired = true)]
        public uint Usage { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"hash", IsRequired = true)]
        public byte[] Hash { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"proto_url")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ProtoUrl
        {
            get => __pbn__ProtoUrl ?? "";
            set => __pbn__ProtoUrl = value;
        }
        public bool ShouldSerializeProtoUrl() => __pbn__ProtoUrl != null;
        public void ResetProtoUrl() => __pbn__ProtoUrl = null;
        private string __pbn__ProtoUrl;

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
