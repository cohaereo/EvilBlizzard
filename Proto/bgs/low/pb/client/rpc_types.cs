// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: rpc_types.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace bgs.protocol
{

    [global::ProtoBuf.ProtoContract(Name = @"NO_RESPONSE")]
    public partial class NoResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Address : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, IsRequired = true)]
        public string address { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"port")]
        public uint Port
        {
            get => __pbn__Port.GetValueOrDefault();
            set => __pbn__Port = value;
        }
        public bool ShouldSerializePort() => __pbn__Port != null;
        public void ResetPort() => __pbn__Port = null;
        private uint? __pbn__Port;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ProcessId : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"label", IsRequired = true)]
        public uint Label { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"epoch", IsRequired = true)]
        public uint Epoch { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ObjectAddress : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"host", IsRequired = true)]
        public ProcessId Host { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"object_id")]
        [global::System.ComponentModel.DefaultValue(typeof(ulong), "0")]
        public ulong ObjectId
        {
            get => __pbn__ObjectId ?? 0ul;
            set => __pbn__ObjectId = value;
        }
        public bool ShouldSerializeObjectId() => __pbn__ObjectId != null;
        public void ResetObjectId() => __pbn__ObjectId = null;
        private ulong? __pbn__ObjectId;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class NoData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ErrorInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"object_address", IsRequired = true)]
        public ObjectAddress ObjectAddress { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"status", IsRequired = true)]
        public uint Status { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"service_hash", IsRequired = true)]
        public uint ServiceHash { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"method_id", IsRequired = true)]
        public uint MethodId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class FanoutTarget : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId
        {
            get => __pbn__ClientId ?? "";
            set => __pbn__ClientId = value;
        }
        public bool ShouldSerializeClientId() => __pbn__ClientId != null;
        public void ResetClientId() => __pbn__ClientId = null;
        private string __pbn__ClientId;

        [global::ProtoBuf.ProtoMember(2, Name = @"key")]
        public byte[] Key
        {
            get => __pbn__Key;
            set => __pbn__Key = value;
        }
        public bool ShouldSerializeKey() => __pbn__Key != null;
        public void ResetKey() => __pbn__Key = null;
        private byte[] __pbn__Key;

        [global::ProtoBuf.ProtoMember(3, Name = @"object_id")]
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
    public partial class Header : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"service_id", IsRequired = true)]
        public uint ServiceId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"method_id")]
        public uint MethodId
        {
            get => __pbn__MethodId.GetValueOrDefault();
            set => __pbn__MethodId = value;
        }
        public bool ShouldSerializeMethodId() => __pbn__MethodId != null;
        public void ResetMethodId() => __pbn__MethodId = null;
        private uint? __pbn__MethodId;

        [global::ProtoBuf.ProtoMember(3, Name = @"token", IsRequired = true)]
        public uint Token { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"object_id")]
        [global::System.ComponentModel.DefaultValue(typeof(ulong), "0")]
        public ulong ObjectId
        {
            get => __pbn__ObjectId ?? 0ul;
            set => __pbn__ObjectId = value;
        }
        public bool ShouldSerializeObjectId() => __pbn__ObjectId != null;
        public void ResetObjectId() => __pbn__ObjectId = null;
        private ulong? __pbn__ObjectId;

        [global::ProtoBuf.ProtoMember(5, Name = @"size")]
        [global::System.ComponentModel.DefaultValue(0u)]
        public uint Size
        {
            get => __pbn__Size ?? 0u;
            set => __pbn__Size = value;
        }
        public bool ShouldSerializeSize() => __pbn__Size != null;
        public void ResetSize() => __pbn__Size = null;
        private uint? __pbn__Size;

        [global::ProtoBuf.ProtoMember(6, Name = @"status")]
        [global::System.ComponentModel.DefaultValue(0u)]
        public uint Status
        {
            get => __pbn__Status ?? 0u;
            set => __pbn__Status = value;
        }
        public bool ShouldSerializeStatus() => __pbn__Status != null;
        public void ResetStatus() => __pbn__Status = null;
        private uint? __pbn__Status;

        [global::ProtoBuf.ProtoMember(7, Name = @"error")]
        public global::System.Collections.Generic.List<ErrorInfo> Errors { get; } = new global::System.Collections.Generic.List<ErrorInfo>();

        [global::ProtoBuf.ProtoMember(8, Name = @"timeout")]
        public ulong Timeout
        {
            get => __pbn__Timeout.GetValueOrDefault();
            set => __pbn__Timeout = value;
        }
        public bool ShouldSerializeTimeout() => __pbn__Timeout != null;
        public void ResetTimeout() => __pbn__Timeout = null;
        private ulong? __pbn__Timeout;

        [global::ProtoBuf.ProtoMember(9, Name = @"is_response")]
        public bool IsResponse
        {
            get => __pbn__IsResponse.GetValueOrDefault();
            set => __pbn__IsResponse = value;
        }
        public bool ShouldSerializeIsResponse() => __pbn__IsResponse != null;
        public void ResetIsResponse() => __pbn__IsResponse = null;
        private bool? __pbn__IsResponse;

        [global::ProtoBuf.ProtoMember(10, Name = @"forward_targets")]
        public global::System.Collections.Generic.List<ProcessId> ForwardTargets { get; } = new global::System.Collections.Generic.List<ProcessId>();

        [global::ProtoBuf.ProtoMember(11, Name = @"service_hash", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public uint ServiceHash
        {
            get => __pbn__ServiceHash.GetValueOrDefault();
            set => __pbn__ServiceHash = value;
        }
        public bool ShouldSerializeServiceHash() => __pbn__ServiceHash != null;
        public void ResetServiceHash() => __pbn__ServiceHash = null;
        private uint? __pbn__ServiceHash;

        [global::ProtoBuf.ProtoMember(12, Name = @"request_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RequestId
        {
            get => __pbn__RequestId ?? "";
            set => __pbn__RequestId = value;
        }
        public bool ShouldSerializeRequestId() => __pbn__RequestId != null;
        public void ResetRequestId() => __pbn__RequestId = null;
        private string __pbn__RequestId;

        [global::ProtoBuf.ProtoMember(13, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId
        {
            get => __pbn__ClientId ?? "";
            set => __pbn__ClientId = value;
        }
        public bool ShouldSerializeClientId() => __pbn__ClientId != null;
        public void ResetClientId() => __pbn__ClientId = null;
        private string __pbn__ClientId;

        [global::ProtoBuf.ProtoMember(14, Name = @"fanout_target")]
        public global::System.Collections.Generic.List<FanoutTarget> FanoutTargets { get; } = new global::System.Collections.Generic.List<FanoutTarget>();

        [global::ProtoBuf.ProtoMember(15, Name = @"client_id_fanout_target")]
        public global::System.Collections.Generic.List<string> ClientIdFanoutTargets { get; } = new global::System.Collections.Generic.List<string>();

        [global::ProtoBuf.ProtoMember(16, Name = @"client_record")]
        public byte[] ClientRecord
        {
            get => __pbn__ClientRecord;
            set => __pbn__ClientRecord = value;
        }
        public bool ShouldSerializeClientRecord() => __pbn__ClientRecord != null;
        public void ResetClientRecord() => __pbn__ClientRecord = null;
        private byte[] __pbn__ClientRecord;

        [global::ProtoBuf.ProtoMember(17, Name = @"original_sender")]
        public byte[] OriginalSender
        {
            get => __pbn__OriginalSender;
            set => __pbn__OriginalSender = value;
        }
        public bool ShouldSerializeOriginalSender() => __pbn__OriginalSender != null;
        public void ResetOriginalSender() => __pbn__OriginalSender = null;
        private byte[] __pbn__OriginalSender;

        [global::ProtoBuf.ProtoMember(18, Name = @"sender_token")]
        public uint SenderToken
        {
            get => __pbn__SenderToken.GetValueOrDefault();
            set => __pbn__SenderToken = value;
        }
        public bool ShouldSerializeSenderToken() => __pbn__SenderToken != null;
        public void ResetSenderToken() => __pbn__SenderToken = null;
        private uint? __pbn__SenderToken;

        [global::ProtoBuf.ProtoMember(19, Name = @"router_label")]
        public uint RouterLabel
        {
            get => __pbn__RouterLabel.GetValueOrDefault();
            set => __pbn__RouterLabel = value;
        }
        public bool ShouldSerializeRouterLabel() => __pbn__RouterLabel != null;
        public void ResetRouterLabel() => __pbn__RouterLabel = null;
        private uint? __pbn__RouterLabel;

        [global::ProtoBuf.ProtoMember(20, Name = @"error_reason")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ErrorReason
        {
            get => __pbn__ErrorReason ?? "";
            set => __pbn__ErrorReason = value;
        }
        public bool ShouldSerializeErrorReason() => __pbn__ErrorReason != null;
        public void ResetErrorReason() => __pbn__ErrorReason = null;
        private string __pbn__ErrorReason;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class KafkaHeader : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"service_hash", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public uint ServiceHash
        {
            get => __pbn__ServiceHash.GetValueOrDefault();
            set => __pbn__ServiceHash = value;
        }
        public bool ShouldSerializeServiceHash() => __pbn__ServiceHash != null;
        public void ResetServiceHash() => __pbn__ServiceHash = null;
        private uint? __pbn__ServiceHash;

        [global::ProtoBuf.ProtoMember(2, Name = @"method_id")]
        public uint MethodId
        {
            get => __pbn__MethodId.GetValueOrDefault();
            set => __pbn__MethodId = value;
        }
        public bool ShouldSerializeMethodId() => __pbn__MethodId != null;
        public void ResetMethodId() => __pbn__MethodId = null;
        private uint? __pbn__MethodId;

        [global::ProtoBuf.ProtoMember(3, Name = @"token")]
        public uint Token
        {
            get => __pbn__Token.GetValueOrDefault();
            set => __pbn__Token = value;
        }
        public bool ShouldSerializeToken() => __pbn__Token != null;
        public void ResetToken() => __pbn__Token = null;
        private uint? __pbn__Token;

        [global::ProtoBuf.ProtoMember(4, Name = @"object_id")]
        [global::System.ComponentModel.DefaultValue(typeof(ulong), "0")]
        public ulong ObjectId
        {
            get => __pbn__ObjectId ?? 0ul;
            set => __pbn__ObjectId = value;
        }
        public bool ShouldSerializeObjectId() => __pbn__ObjectId != null;
        public void ResetObjectId() => __pbn__ObjectId = null;
        private ulong? __pbn__ObjectId;

        [global::ProtoBuf.ProtoMember(5, Name = @"size")]
        [global::System.ComponentModel.DefaultValue(0u)]
        public uint Size
        {
            get => __pbn__Size ?? 0u;
            set => __pbn__Size = value;
        }
        public bool ShouldSerializeSize() => __pbn__Size != null;
        public void ResetSize() => __pbn__Size = null;
        private uint? __pbn__Size;

        [global::ProtoBuf.ProtoMember(6, Name = @"status")]
        [global::System.ComponentModel.DefaultValue(0u)]
        public uint Status
        {
            get => __pbn__Status ?? 0u;
            set => __pbn__Status = value;
        }
        public bool ShouldSerializeStatus() => __pbn__Status != null;
        public void ResetStatus() => __pbn__Status = null;
        private uint? __pbn__Status;

        [global::ProtoBuf.ProtoMember(7, Name = @"timeout")]
        public ulong Timeout
        {
            get => __pbn__Timeout.GetValueOrDefault();
            set => __pbn__Timeout = value;
        }
        public bool ShouldSerializeTimeout() => __pbn__Timeout != null;
        public void ResetTimeout() => __pbn__Timeout = null;
        private ulong? __pbn__Timeout;

        [global::ProtoBuf.ProtoMember(8, Name = @"forward_target")]
        public ProcessId ForwardTarget { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"return_topic")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ReturnTopic
        {
            get => __pbn__ReturnTopic ?? "";
            set => __pbn__ReturnTopic = value;
        }
        public bool ShouldSerializeReturnTopic() => __pbn__ReturnTopic != null;
        public void ResetReturnTopic() => __pbn__ReturnTopic = null;
        private string __pbn__ReturnTopic;

        [global::ProtoBuf.ProtoMember(11, Name = @"client_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ClientId
        {
            get => __pbn__ClientId ?? "";
            set => __pbn__ClientId = value;
        }
        public bool ShouldSerializeClientId() => __pbn__ClientId != null;
        public void ResetClientId() => __pbn__ClientId = null;
        private string __pbn__ClientId;

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
