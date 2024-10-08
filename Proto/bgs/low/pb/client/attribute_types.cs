// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: attribute_types.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace bgs.protocol.v2
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Variant : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"bool_value")]
        public bool BoolValue
        {
            get => __pbn__BoolValue.GetValueOrDefault();
            set => __pbn__BoolValue = value;
        }
        public bool ShouldSerializeBoolValue() => __pbn__BoolValue != null;
        public void ResetBoolValue() => __pbn__BoolValue = null;
        private bool? __pbn__BoolValue;

        [global::ProtoBuf.ProtoMember(2, Name = @"int_value")]
        public long IntValue
        {
            get => __pbn__IntValue.GetValueOrDefault();
            set => __pbn__IntValue = value;
        }
        public bool ShouldSerializeIntValue() => __pbn__IntValue != null;
        public void ResetIntValue() => __pbn__IntValue = null;
        private long? __pbn__IntValue;

        [global::ProtoBuf.ProtoMember(3, Name = @"float_value")]
        public double FloatValue
        {
            get => __pbn__FloatValue.GetValueOrDefault();
            set => __pbn__FloatValue = value;
        }
        public bool ShouldSerializeFloatValue() => __pbn__FloatValue != null;
        public void ResetFloatValue() => __pbn__FloatValue = null;
        private double? __pbn__FloatValue;

        [global::ProtoBuf.ProtoMember(4, Name = @"string_value")]
        [global::System.ComponentModel.DefaultValue("")]
        public string StringValue
        {
            get => __pbn__StringValue ?? "";
            set => __pbn__StringValue = value;
        }
        public bool ShouldSerializeStringValue() => __pbn__StringValue != null;
        public void ResetStringValue() => __pbn__StringValue = null;
        private string __pbn__StringValue;

        [global::ProtoBuf.ProtoMember(5, Name = @"blob_value")]
        public byte[] BlobValue
        {
            get => __pbn__BlobValue;
            set => __pbn__BlobValue = value;
        }
        public bool ShouldSerializeBlobValue() => __pbn__BlobValue != null;
        public void ResetBlobValue() => __pbn__BlobValue = null;
        private byte[] __pbn__BlobValue;

        [global::ProtoBuf.ProtoMember(6, Name = @"uint_value")]
        public ulong UintValue
        {
            get => __pbn__UintValue.GetValueOrDefault();
            set => __pbn__UintValue = value;
        }
        public bool ShouldSerializeUintValue() => __pbn__UintValue != null;
        public void ResetUintValue() => __pbn__UintValue = null;
        private ulong? __pbn__UintValue;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Attribute : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name
        {
            get => __pbn__Name ?? "";
            set => __pbn__Name = value;
        }
        public bool ShouldSerializeName() => __pbn__Name != null;
        public void ResetName() => __pbn__Name = null;
        private string __pbn__Name;

        [global::ProtoBuf.ProtoMember(2, Name = @"value")]
        public Variant Value { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class AttributeFilter : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"op")]
        [global::System.ComponentModel.DefaultValue(Operation.MatchNone)]
        public Operation Op
        {
            get => __pbn__Op ?? Operation.MatchNone;
            set => __pbn__Op = value;
        }
        public bool ShouldSerializeOp() => __pbn__Op != null;
        public void ResetOp() => __pbn__Op = null;
        private Operation? __pbn__Op;

        [global::ProtoBuf.ProtoMember(2, Name = @"attribute")]
        public global::System.Collections.Generic.List<Attribute> Attributes { get; } = new global::System.Collections.Generic.List<Attribute>();

        [global::ProtoBuf.ProtoContract()]
        public enum Operation
        {
            [global::ProtoBuf.ProtoEnum(Name = @"MATCH_NONE")]
            MatchNone = 0,
            [global::ProtoBuf.ProtoEnum(Name = @"MATCH_ANY")]
            MatchAny = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"MATCH_ALL")]
            MatchAll = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"MATCH_ALL_MOST_SPECIFIC")]
            MatchAllMostSpecific = 3,
        }

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
