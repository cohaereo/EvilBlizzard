// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: method_options.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace bgs.protocol
{

    [global::ProtoBuf.ProtoContract()]
    public partial class BGSMethodOptions : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(2, Name = @"topic")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Topic
        {
            get => __pbn__Topic ?? "";
            set => __pbn__Topic = value;
        }
        public bool ShouldSerializeTopic() => __pbn__Topic != null;
        public void ResetTopic() => __pbn__Topic = null;
        private string __pbn__Topic;

        [global::ProtoBuf.ProtoMember(3, Name = @"custom_select_shard")]
        public bool CustomSelectShard
        {
            get => __pbn__CustomSelectShard.GetValueOrDefault();
            set => __pbn__CustomSelectShard = value;
        }
        public bool ShouldSerializeCustomSelectShard() => __pbn__CustomSelectShard != null;
        public void ResetCustomSelectShard() => __pbn__CustomSelectShard = null;
        private bool? __pbn__CustomSelectShard;

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
