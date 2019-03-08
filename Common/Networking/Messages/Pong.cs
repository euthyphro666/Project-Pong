// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Pong.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Common.Networking {

  /// <summary>Holder for reflection information generated from Pong.proto</summary>
  public static partial class PongReflection {

    #region Descriptor
    /// <summary>File descriptor for Pong.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PongReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgpQb25nLnByb3RvEglUaXR0eVBvbmcaH2dvb2dsZS9wcm90b2J1Zi90aW1l",
            "c3RhbXAucHJvdG8i4gEKD05ldHdvcmtTbmFwc2hvdBITCgtmcmFtZU51bWJl",
            "chgBIAEoBRIzCghlbnRpdGllcxgCIAMoCzIhLlRpdHR5UG9uZy5OZXR3b3Jr",
            "U25hcHNob3QuRW50aXR5EjAKDGxhc3RfdXBkYXRlZBgDIAEoCzIaLmdvb2ds",
            "ZS5wcm90b2J1Zi5UaW1lc3RhbXAaUwoGRW50aXR5EhEKCW5ldHdvcmtJZBgB",
            "IAEoBRIMCgRwb3NYGAIgASgCEgwKBHBvc1kYAyABKAISDAoEdmVsWBgEIAEo",
            "AhIMCgR2ZWxZGAUgASgCIkEKEE5ldHdvcmtTbmFwc2hvdHMSLQoJc25hcHNo",
            "b3RzGAEgAygLMhouVGl0dHlQb25nLk5ldHdvcmtTbmFwc2hvdEIUqgIRQ29t",
            "bW9uLk5ldHdvcmtpbmdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Common.Networking.NetworkSnapshot), global::Common.Networking.NetworkSnapshot.Parser, new[]{ "FrameNumber", "Entities", "LastUpdated" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Common.Networking.NetworkSnapshot.Types.Entity), global::Common.Networking.NetworkSnapshot.Types.Entity.Parser, new[]{ "NetworkId", "PosX", "PosY", "VelX", "VelY" }, null, null, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::Common.Networking.NetworkSnapshots), global::Common.Networking.NetworkSnapshots.Parser, new[]{ "Snapshots" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class NetworkSnapshot : pb::IMessage<NetworkSnapshot> {
    private static readonly pb::MessageParser<NetworkSnapshot> _parser = new pb::MessageParser<NetworkSnapshot>(() => new NetworkSnapshot());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NetworkSnapshot> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Common.Networking.PongReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NetworkSnapshot() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NetworkSnapshot(NetworkSnapshot other) : this() {
      frameNumber_ = other.frameNumber_;
      entities_ = other.entities_.Clone();
      lastUpdated_ = other.lastUpdated_ != null ? other.lastUpdated_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NetworkSnapshot Clone() {
      return new NetworkSnapshot(this);
    }

    /// <summary>Field number for the "frameNumber" field.</summary>
    public const int FrameNumberFieldNumber = 1;
    private int frameNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int FrameNumber {
      get { return frameNumber_; }
      set {
        frameNumber_ = value;
      }
    }

    /// <summary>Field number for the "entities" field.</summary>
    public const int EntitiesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Common.Networking.NetworkSnapshot.Types.Entity> _repeated_entities_codec
        = pb::FieldCodec.ForMessage(18, global::Common.Networking.NetworkSnapshot.Types.Entity.Parser);
    private readonly pbc::RepeatedField<global::Common.Networking.NetworkSnapshot.Types.Entity> entities_ = new pbc::RepeatedField<global::Common.Networking.NetworkSnapshot.Types.Entity>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Common.Networking.NetworkSnapshot.Types.Entity> Entities {
      get { return entities_; }
    }

    /// <summary>Field number for the "last_updated" field.</summary>
    public const int LastUpdatedFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp lastUpdated_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp LastUpdated {
      get { return lastUpdated_; }
      set {
        lastUpdated_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NetworkSnapshot);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NetworkSnapshot other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FrameNumber != other.FrameNumber) return false;
      if(!entities_.Equals(other.entities_)) return false;
      if (!object.Equals(LastUpdated, other.LastUpdated)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FrameNumber != 0) hash ^= FrameNumber.GetHashCode();
      hash ^= entities_.GetHashCode();
      if (lastUpdated_ != null) hash ^= LastUpdated.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (FrameNumber != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(FrameNumber);
      }
      entities_.WriteTo(output, _repeated_entities_codec);
      if (lastUpdated_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(LastUpdated);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FrameNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FrameNumber);
      }
      size += entities_.CalculateSize(_repeated_entities_codec);
      if (lastUpdated_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LastUpdated);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(NetworkSnapshot other) {
      if (other == null) {
        return;
      }
      if (other.FrameNumber != 0) {
        FrameNumber = other.FrameNumber;
      }
      entities_.Add(other.entities_);
      if (other.lastUpdated_ != null) {
        if (lastUpdated_ == null) {
          LastUpdated = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        LastUpdated.MergeFrom(other.LastUpdated);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            FrameNumber = input.ReadInt32();
            break;
          }
          case 18: {
            entities_.AddEntriesFrom(input, _repeated_entities_codec);
            break;
          }
          case 26: {
            if (lastUpdated_ == null) {
              LastUpdated = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LastUpdated);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the NetworkSnapshot message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class Entity : pb::IMessage<Entity> {
        private static readonly pb::MessageParser<Entity> _parser = new pb::MessageParser<Entity>(() => new Entity());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Entity> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Common.Networking.NetworkSnapshot.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Entity() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Entity(Entity other) : this() {
          networkId_ = other.networkId_;
          posX_ = other.posX_;
          posY_ = other.posY_;
          velX_ = other.velX_;
          velY_ = other.velY_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Entity Clone() {
          return new Entity(this);
        }

        /// <summary>Field number for the "networkId" field.</summary>
        public const int NetworkIdFieldNumber = 1;
        private int networkId_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int NetworkId {
          get { return networkId_; }
          set {
            networkId_ = value;
          }
        }

        /// <summary>Field number for the "posX" field.</summary>
        public const int PosXFieldNumber = 2;
        private float posX_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public float PosX {
          get { return posX_; }
          set {
            posX_ = value;
          }
        }

        /// <summary>Field number for the "posY" field.</summary>
        public const int PosYFieldNumber = 3;
        private float posY_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public float PosY {
          get { return posY_; }
          set {
            posY_ = value;
          }
        }

        /// <summary>Field number for the "velX" field.</summary>
        public const int VelXFieldNumber = 4;
        private float velX_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public float VelX {
          get { return velX_; }
          set {
            velX_ = value;
          }
        }

        /// <summary>Field number for the "velY" field.</summary>
        public const int VelYFieldNumber = 5;
        private float velY_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public float VelY {
          get { return velY_; }
          set {
            velY_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Entity);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Entity other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (NetworkId != other.NetworkId) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PosX, other.PosX)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PosY, other.PosY)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(VelX, other.VelX)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(VelY, other.VelY)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (NetworkId != 0) hash ^= NetworkId.GetHashCode();
          if (PosX != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PosX);
          if (PosY != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PosY);
          if (VelX != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(VelX);
          if (VelY != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(VelY);
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (NetworkId != 0) {
            output.WriteRawTag(8);
            output.WriteInt32(NetworkId);
          }
          if (PosX != 0F) {
            output.WriteRawTag(21);
            output.WriteFloat(PosX);
          }
          if (PosY != 0F) {
            output.WriteRawTag(29);
            output.WriteFloat(PosY);
          }
          if (VelX != 0F) {
            output.WriteRawTag(37);
            output.WriteFloat(VelX);
          }
          if (VelY != 0F) {
            output.WriteRawTag(45);
            output.WriteFloat(VelY);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (NetworkId != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(NetworkId);
          }
          if (PosX != 0F) {
            size += 1 + 4;
          }
          if (PosY != 0F) {
            size += 1 + 4;
          }
          if (VelX != 0F) {
            size += 1 + 4;
          }
          if (VelY != 0F) {
            size += 1 + 4;
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Entity other) {
          if (other == null) {
            return;
          }
          if (other.NetworkId != 0) {
            NetworkId = other.NetworkId;
          }
          if (other.PosX != 0F) {
            PosX = other.PosX;
          }
          if (other.PosY != 0F) {
            PosY = other.PosY;
          }
          if (other.VelX != 0F) {
            VelX = other.VelX;
          }
          if (other.VelY != 0F) {
            VelY = other.VelY;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 8: {
                NetworkId = input.ReadInt32();
                break;
              }
              case 21: {
                PosX = input.ReadFloat();
                break;
              }
              case 29: {
                PosY = input.ReadFloat();
                break;
              }
              case 37: {
                VelX = input.ReadFloat();
                break;
              }
              case 45: {
                VelY = input.ReadFloat();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  /// <summary>
  /// Our address book file is just one of these.
  /// </summary>
  public sealed partial class NetworkSnapshots : pb::IMessage<NetworkSnapshots> {
    private static readonly pb::MessageParser<NetworkSnapshots> _parser = new pb::MessageParser<NetworkSnapshots>(() => new NetworkSnapshots());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NetworkSnapshots> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Common.Networking.PongReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NetworkSnapshots() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NetworkSnapshots(NetworkSnapshots other) : this() {
      snapshots_ = other.snapshots_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NetworkSnapshots Clone() {
      return new NetworkSnapshots(this);
    }

    /// <summary>Field number for the "snapshots" field.</summary>
    public const int SnapshotsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Common.Networking.NetworkSnapshot> _repeated_snapshots_codec
        = pb::FieldCodec.ForMessage(10, global::Common.Networking.NetworkSnapshot.Parser);
    private readonly pbc::RepeatedField<global::Common.Networking.NetworkSnapshot> snapshots_ = new pbc::RepeatedField<global::Common.Networking.NetworkSnapshot>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Common.Networking.NetworkSnapshot> Snapshots {
      get { return snapshots_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NetworkSnapshots);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NetworkSnapshots other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!snapshots_.Equals(other.snapshots_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= snapshots_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      snapshots_.WriteTo(output, _repeated_snapshots_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += snapshots_.CalculateSize(_repeated_snapshots_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(NetworkSnapshots other) {
      if (other == null) {
        return;
      }
      snapshots_.Add(other.snapshots_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            snapshots_.AddEntriesFrom(input, _repeated_snapshots_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code