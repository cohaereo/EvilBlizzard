// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: challenge_service.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace bgs.protocol.challenge.v1
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ChallengeExternalRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"request_token")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RequestToken
        {
            get => __pbn__RequestToken ?? "";
            set => __pbn__RequestToken = value;
        }
        public bool ShouldSerializeRequestToken() => __pbn__RequestToken != null;
        public void ResetRequestToken() => __pbn__RequestToken = null;
        private string __pbn__RequestToken;

        [global::ProtoBuf.ProtoMember(2, Name = @"payload_type")]
        [global::System.ComponentModel.DefaultValue("")]
        public string PayloadType
        {
            get => __pbn__PayloadType ?? "";
            set => __pbn__PayloadType = value;
        }
        public bool ShouldSerializePayloadType() => __pbn__PayloadType != null;
        public void ResetPayloadType() => __pbn__PayloadType = null;
        private string __pbn__PayloadType;

        [global::ProtoBuf.ProtoMember(3, Name = @"payload")]
        public byte[] Payload
        {
            get => __pbn__Payload;
            set => __pbn__Payload = value;
        }
        public bool ShouldSerializePayload() => __pbn__Payload != null;
        public void ResetPayload() => __pbn__Payload = null;
        private byte[] __pbn__Payload;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ChallengeExternalResult : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"request_token")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RequestToken
        {
            get => __pbn__RequestToken ?? "";
            set => __pbn__RequestToken = value;
        }
        public bool ShouldSerializeRequestToken() => __pbn__RequestToken != null;
        public void ResetRequestToken() => __pbn__RequestToken = null;
        private string __pbn__RequestToken;

        [global::ProtoBuf.ProtoMember(2, Name = @"passed")]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool Passed
        {
            get => __pbn__Passed ?? true;
            set => __pbn__Passed = value;
        }
        public bool ShouldSerializePassed() => __pbn__Passed != null;
        public void ResetPassed() => __pbn__Passed = null;
        private bool? __pbn__Passed;

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
