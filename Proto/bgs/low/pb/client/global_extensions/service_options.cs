// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: service_options.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace bgs.protocol
{

    [global::ProtoBuf.ProtoContract()]
    public partial class BGSServiceOptions : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"descriptor_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DescriptorName
        {
            get => __pbn__DescriptorName ?? "";
            set => __pbn__DescriptorName = value;
        }
        public bool ShouldSerializeDescriptorName() => __pbn__DescriptorName != null;
        public void ResetDescriptorName() => __pbn__DescriptorName = null;
        private string __pbn__DescriptorName;

        [global::ProtoBuf.ProtoMember(2, Name = @"descriptor_hash")]
        public uint DescriptorHash
        {
            get => __pbn__DescriptorHash.GetValueOrDefault();
            set => __pbn__DescriptorHash = value;
        }
        public bool ShouldSerializeDescriptorHash() => __pbn__DescriptorHash != null;
        public void ResetDescriptorHash() => __pbn__DescriptorHash = null;
        private uint? __pbn__DescriptorHash;

        [global::ProtoBuf.ProtoMember(4, Name = @"version")]
        public uint Version
        {
            get => __pbn__Version.GetValueOrDefault();
            set => __pbn__Version = value;
        }
        public bool ShouldSerializeVersion() => __pbn__Version != null;
        public void ResetVersion() => __pbn__Version = null;
        private uint? __pbn__Version;

        [global::ProtoBuf.ProtoMember(5, Name = @"shard_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ShardName
        {
            get => __pbn__ShardName ?? "";
            set => __pbn__ShardName = value;
        }
        public bool ShouldSerializeShardName() => __pbn__ShardName != null;
        public void ResetShardName() => __pbn__ShardName = null;
        private string __pbn__ShardName;

        [global::ProtoBuf.ProtoMember(6, Name = @"resolve_client_instance")]
        public bool ResolveClientInstance
        {
            get => __pbn__ResolveClientInstance.GetValueOrDefault();
            set => __pbn__ResolveClientInstance = value;
        }
        public bool ShouldSerializeResolveClientInstance() => __pbn__ResolveClientInstance != null;
        public void ResetResolveClientInstance() => __pbn__ResolveClientInstance = null;
        private bool? __pbn__ResolveClientInstance;

        [global::ProtoBuf.ProtoMember(7, Name = @"type")]
        [global::System.ComponentModel.DefaultValue(ServiceType.ServiceTypeRpc)]
        public ServiceType Type
        {
            get => __pbn__Type ?? ServiceType.ServiceTypeRpc;
            set => __pbn__Type = value;
        }
        public bool ShouldSerializeType() => __pbn__Type != null;
        public void ResetType() => __pbn__Type = null;
        private ServiceType? __pbn__Type;

        [global::ProtoBuf.ProtoMember(8, Name = @"api_type")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ApiType
        {
            get => __pbn__ApiType ?? "";
            set => __pbn__ApiType = value;
        }
        public bool ShouldSerializeApiType() => __pbn__ApiType != null;
        public void ResetApiType() => __pbn__ApiType = null;
        private string __pbn__ApiType;

        [global::ProtoBuf.ProtoMember(9, Name = @"is_global")]
        public bool IsGlobal
        {
            get => __pbn__IsGlobal.GetValueOrDefault();
            set => __pbn__IsGlobal = value;
        }
        public bool ShouldSerializeIsGlobal() => __pbn__IsGlobal != null;
        public void ResetIsGlobal() => __pbn__IsGlobal = null;
        private bool? __pbn__IsGlobal;

        [global::ProtoBuf.ProtoContract()]
        public enum ServiceType
        {
            [global::ProtoBuf.ProtoEnum(Name = @"SERVICE_TYPE_RPC")]
            ServiceTypeRpc = 0,
            [global::ProtoBuf.ProtoEnum(Name = @"SERVICE_TYPE_RPC_DIRECT")]
            ServiceTypeRpcDirect = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"SERVICE_TYPE_EVENT")]
            ServiceTypeEvent = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"SERVICE_TYPE_EVENT_BROADCAST")]
            ServiceTypeEventBroadcast = 3,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SDKServiceOptions : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"inbound")]
        public bool Inbound
        {
            get => __pbn__Inbound.GetValueOrDefault();
            set => __pbn__Inbound = value;
        }
        public bool ShouldSerializeInbound() => __pbn__Inbound != null;
        public void ResetInbound() => __pbn__Inbound = null;
        private bool? __pbn__Inbound;

        [global::ProtoBuf.ProtoMember(2, Name = @"outbound")]
        public bool Outbound
        {
            get => __pbn__Outbound.GetValueOrDefault();
            set => __pbn__Outbound = value;
        }
        public bool ShouldSerializeOutbound() => __pbn__Outbound != null;
        public void ResetOutbound() => __pbn__Outbound = null;
        private bool? __pbn__Outbound;

        [global::ProtoBuf.ProtoMember(3, Name = @"use_client_id")]
        public bool UseClientId
        {
            get => __pbn__UseClientId.GetValueOrDefault();
            set => __pbn__UseClientId = value;
        }
        public bool ShouldSerializeUseClientId() => __pbn__UseClientId != null;
        public void ResetUseClientId() => __pbn__UseClientId = null;
        private bool? __pbn__UseClientId;

    }

    // public static partial class Extensions
    // {
    //     public static BGSServiceOptions GetServiceOptions(this global::Google.Protobuf.Reflection.ServiceOptions obj)
    //         => obj == null ? default : global::ProtoBuf.Extensible.GetValue<BGSServiceOptions>(obj, 90000);
    //
    //     public static void SetServiceOptions(this global::Google.Protobuf.Reflection.ServiceOptions obj, BGSServiceOptions value)
    //         => global::ProtoBuf.Extensible.AppendValue<BGSServiceOptions>(obj, 90000, value);
    //
    //     public static SDKServiceOptions GetSdkServiceOptions(this global::Google.Protobuf.Reflection.ServiceOptions obj)
    //         => obj == null ? default : global::ProtoBuf.Extensible.GetValue<SDKServiceOptions>(obj, 90001);
    //
    //     public static void SetSdkServiceOptions(this global::Google.Protobuf.Reflection.ServiceOptions obj, SDKServiceOptions value)
    //         => global::ProtoBuf.Extensible.AppendValue<SDKServiceOptions>(obj, 90001, value);
    //
    // }
}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
