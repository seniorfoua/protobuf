// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/protobuf/api.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf.WellKnownTypes {

  /// <summary>Holder for reflection information generated from google/protobuf/api.proto</summary>
  public static partial class ApiReflection {

    #region Descriptor
    /// <summary>File descriptor for google/protobuf/api.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ApiReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chlnb29nbGUvcHJvdG9idWYvYXBpLnByb3RvEg9nb29nbGUucHJvdG9idWYa",
            "JGdvb2dsZS9wcm90b2J1Zi9zb3VyY2VfY29udGV4dC5wcm90bxoaZ29vZ2xl",
            "L3Byb3RvYnVmL3R5cGUucHJvdG8igQIKA0FwaRIMCgRuYW1lGAEgASgJEigK",
            "B21ldGhvZHMYAiADKAsyFy5nb29nbGUucHJvdG9idWYuTWV0aG9kEigKB29w",
            "dGlvbnMYAyADKAsyFy5nb29nbGUucHJvdG9idWYuT3B0aW9uEg8KB3ZlcnNp",
            "b24YBCABKAkSNgoOc291cmNlX2NvbnRleHQYBSABKAsyHi5nb29nbGUucHJv",
            "dG9idWYuU291cmNlQ29udGV4dBImCgZtaXhpbnMYBiADKAsyFi5nb29nbGUu",
            "cHJvdG9idWYuTWl4aW4SJwoGc3ludGF4GAcgASgOMhcuZ29vZ2xlLnByb3Rv",
            "YnVmLlN5bnRheCLVAQoGTWV0aG9kEgwKBG5hbWUYASABKAkSGAoQcmVxdWVz",
            "dF90eXBlX3VybBgCIAEoCRIZChFyZXF1ZXN0X3N0cmVhbWluZxgDIAEoCBIZ",
            "ChFyZXNwb25zZV90eXBlX3VybBgEIAEoCRIaChJyZXNwb25zZV9zdHJlYW1p",
            "bmcYBSABKAgSKAoHb3B0aW9ucxgGIAMoCzIXLmdvb2dsZS5wcm90b2J1Zi5P",
            "cHRpb24SJwoGc3ludGF4GAcgASgOMhcuZ29vZ2xlLnByb3RvYnVmLlN5bnRh",
            "eCIjCgVNaXhpbhIMCgRuYW1lGAEgASgJEgwKBHJvb3QYAiABKAlCdgoTY29t",
            "Lmdvb2dsZS5wcm90b2J1ZkIIQXBpUHJvdG9QAVosZ29vZ2xlLmdvbGFuZy5v",
            "cmcvcHJvdG9idWYvdHlwZXMva25vd24vYXBpcGKiAgNHUEKqAh5Hb29nbGUu",
            "UHJvdG9idWYuV2VsbEtub3duVHlwZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.SourceContextReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.WellKnownTypes.Api), global::Google.Protobuf.WellKnownTypes.Api.Parser, new[]{ "Name", "Methods", "Options", "Version", "SourceContext", "Mixins", "Syntax" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.WellKnownTypes.Method), global::Google.Protobuf.WellKnownTypes.Method.Parser, new[]{ "Name", "RequestTypeUrl", "RequestStreaming", "ResponseTypeUrl", "ResponseStreaming", "Options", "Syntax" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.WellKnownTypes.Mixin), global::Google.Protobuf.WellKnownTypes.Mixin.Parser, new[]{ "Name", "Root" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Api is a light-weight descriptor for an API Interface.
  ///
  /// Interfaces are also described as "protocol buffer services" in some contexts,
  /// such as by the "service" keyword in a .proto file, but they are different
  /// from API Services, which represent a concrete implementation of an interface
  /// as opposed to simply a description of methods and bindings. They are also
  /// sometimes simply referred to as "APIs" in other contexts, such as the name of
  /// this message itself. See https://cloud.google.com/apis/design/glossary for
  /// detailed terminology.
  /// </summary>
  public sealed partial class Api : pb::IMessage<Api>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Api> _parser = new pb::MessageParser<Api>(() => new Api());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Api> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.ApiReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Api() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Api(Api other) : this() {
      name_ = other.name_;
      methods_ = other.methods_.Clone();
      options_ = other.options_.Clone();
      version_ = other.version_;
      sourceContext_ = other.sourceContext_ != null ? other.sourceContext_.Clone() : null;
      mixins_ = other.mixins_.Clone();
      syntax_ = other.syntax_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Api Clone() {
      return new Api(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The fully qualified name of this interface, including package name
    /// followed by the interface's simple name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "methods" field.</summary>
    public const int MethodsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.Method> _repeated_methods_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Protobuf.WellKnownTypes.Method.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Method> methods_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Method>();
    /// <summary>
    /// The methods of this interface, in unspecified order.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Method> Methods {
      get { return methods_; }
    }

    /// <summary>Field number for the "options" field.</summary>
    public const int OptionsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec
        = pb::FieldCodec.ForMessage(26, global::Google.Protobuf.WellKnownTypes.Option.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Option> options_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Option>();
    /// <summary>
    /// Any metadata attached to the interface.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Option> Options {
      get { return options_; }
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 4;
    private string version_ = "";
    /// <summary>
    /// A version string for this interface. If specified, must have the form
    /// `major-version.minor-version`, as in `1.10`. If the minor version is
    /// omitted, it defaults to zero. If the entire version field is empty, the
    /// major version is derived from the package name, as outlined below. If the
    /// field is not empty, the version in the package name will be verified to be
    /// consistent with what is provided here.
    ///
    /// The versioning schema uses [semantic
    /// versioning](http://semver.org) where the major version number
    /// indicates a breaking change and the minor version an additive,
    /// non-breaking change. Both version numbers are signals to users
    /// what to expect from different versions, and should be carefully
    /// chosen based on the product plan.
    ///
    /// The major version is also reflected in the package name of the
    /// interface, which must end in `v&lt;major-version>`, as in
    /// `google.feature.v1`. For major versions 0 and 1, the suffix can
    /// be omitted. Zero major versions must only be used for
    /// experimental, non-GA interfaces.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Version {
      get { return version_; }
      set {
        version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "source_context" field.</summary>
    public const int SourceContextFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.SourceContext sourceContext_;
    /// <summary>
    /// Source context for the protocol buffer service represented by this
    /// message.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.SourceContext SourceContext {
      get { return sourceContext_; }
      set {
        sourceContext_ = value;
      }
    }

    /// <summary>Field number for the "mixins" field.</summary>
    public const int MixinsFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.Mixin> _repeated_mixins_codec
        = pb::FieldCodec.ForMessage(50, global::Google.Protobuf.WellKnownTypes.Mixin.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Mixin> mixins_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Mixin>();
    /// <summary>
    /// Included interfaces. See [Mixin][].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Mixin> Mixins {
      get { return mixins_; }
    }

    /// <summary>Field number for the "syntax" field.</summary>
    public const int SyntaxFieldNumber = 7;
    private global::Google.Protobuf.WellKnownTypes.Syntax syntax_ = global::Google.Protobuf.WellKnownTypes.Syntax.Proto2;
    /// <summary>
    /// The source syntax of the service.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Syntax Syntax {
      get { return syntax_; }
      set {
        syntax_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Api);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Api other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if(!methods_.Equals(other.methods_)) return false;
      if(!options_.Equals(other.options_)) return false;
      if (Version != other.Version) return false;
      if (!object.Equals(SourceContext, other.SourceContext)) return false;
      if(!mixins_.Equals(other.mixins_)) return false;
      if (Syntax != other.Syntax) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= methods_.GetHashCode();
      hash ^= options_.GetHashCode();
      if (Version.Length != 0) hash ^= Version.GetHashCode();
      if (sourceContext_ != null) hash ^= SourceContext.GetHashCode();
      hash ^= mixins_.GetHashCode();
      if (Syntax != global::Google.Protobuf.WellKnownTypes.Syntax.Proto2) hash ^= Syntax.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      methods_.WriteTo(output, _repeated_methods_codec);
      options_.WriteTo(output, _repeated_options_codec);
      if (Version.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Version);
      }
      if (sourceContext_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(SourceContext);
      }
      mixins_.WriteTo(output, _repeated_mixins_codec);
      if (Syntax != global::Google.Protobuf.WellKnownTypes.Syntax.Proto2) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Syntax);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += methods_.CalculateSize(_repeated_methods_codec);
      size += options_.CalculateSize(_repeated_options_codec);
      if (Version.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
      }
      if (sourceContext_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SourceContext);
      }
      size += mixins_.CalculateSize(_repeated_mixins_codec);
      if (Syntax != global::Google.Protobuf.WellKnownTypes.Syntax.Proto2) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Syntax);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Api other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      methods_.Add(other.methods_);
      options_.Add(other.options_);
      if (other.Version.Length != 0) {
        Version = other.Version;
      }
      if (other.sourceContext_ != null) {
        if (sourceContext_ == null) {
          SourceContext = new global::Google.Protobuf.WellKnownTypes.SourceContext();
        }
        SourceContext.MergeFrom(other.SourceContext);
      }
      mixins_.Add(other.mixins_);
      if (other.Syntax != global::Google.Protobuf.WellKnownTypes.Syntax.Proto2) {
        Syntax = other.Syntax;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            methods_.AddEntriesFrom(input, _repeated_methods_codec);
            break;
          }
          case 26: {
            options_.AddEntriesFrom(input, _repeated_options_codec);
            break;
          }
          case 34: {
            Version = input.ReadString();
            break;
          }
          case 42: {
            if (sourceContext_ == null) {
              SourceContext = new global::Google.Protobuf.WellKnownTypes.SourceContext();
            }
            input.ReadMessage(SourceContext);
            break;
          }
          case 50: {
            mixins_.AddEntriesFrom(input, _repeated_mixins_codec);
            break;
          }
          case 56: {
            Syntax = (global::Google.Protobuf.WellKnownTypes.Syntax) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            methods_.AddEntriesFrom(ref input, _repeated_methods_codec);
            break;
          }
          case 26: {
            options_.AddEntriesFrom(ref input, _repeated_options_codec);
            break;
          }
          case 34: {
            Version = input.ReadString();
            break;
          }
          case 42: {
            if (sourceContext_ == null) {
              SourceContext = new global::Google.Protobuf.WellKnownTypes.SourceContext();
            }
            input.ReadMessage(SourceContext);
            break;
          }
          case 50: {
            mixins_.AddEntriesFrom(ref input, _repeated_mixins_codec);
            break;
          }
          case 56: {
            Syntax = (global::Google.Protobuf.WellKnownTypes.Syntax) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Method represents a method of an API interface.
  /// </summary>
  public sealed partial class Method : pb::IMessage<Method>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Method> _parser = new pb::MessageParser<Method>(() => new Method());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Method> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.ApiReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Method() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Method(Method other) : this() {
      name_ = other.name_;
      requestTypeUrl_ = other.requestTypeUrl_;
      requestStreaming_ = other.requestStreaming_;
      responseTypeUrl_ = other.responseTypeUrl_;
      responseStreaming_ = other.responseStreaming_;
      options_ = other.options_.Clone();
      syntax_ = other.syntax_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Method Clone() {
      return new Method(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The simple name of this method.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "request_type_url" field.</summary>
    public const int RequestTypeUrlFieldNumber = 2;
    private string requestTypeUrl_ = "";
    /// <summary>
    /// A URL of the input message type.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RequestTypeUrl {
      get { return requestTypeUrl_; }
      set {
        requestTypeUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "request_streaming" field.</summary>
    public const int RequestStreamingFieldNumber = 3;
    private bool requestStreaming_;
    /// <summary>
    /// If true, the request is streamed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool RequestStreaming {
      get { return requestStreaming_; }
      set {
        requestStreaming_ = value;
      }
    }

    /// <summary>Field number for the "response_type_url" field.</summary>
    public const int ResponseTypeUrlFieldNumber = 4;
    private string responseTypeUrl_ = "";
    /// <summary>
    /// The URL of the output message type.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResponseTypeUrl {
      get { return responseTypeUrl_; }
      set {
        responseTypeUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "response_streaming" field.</summary>
    public const int ResponseStreamingFieldNumber = 5;
    private bool responseStreaming_;
    /// <summary>
    /// If true, the response is streamed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ResponseStreaming {
      get { return responseStreaming_; }
      set {
        responseStreaming_ = value;
      }
    }

    /// <summary>Field number for the "options" field.</summary>
    public const int OptionsFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec
        = pb::FieldCodec.ForMessage(50, global::Google.Protobuf.WellKnownTypes.Option.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Option> options_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Option>();
    /// <summary>
    /// Any metadata attached to the method.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Option> Options {
      get { return options_; }
    }

    /// <summary>Field number for the "syntax" field.</summary>
    public const int SyntaxFieldNumber = 7;
    private global::Google.Protobuf.WellKnownTypes.Syntax syntax_ = global::Google.Protobuf.WellKnownTypes.Syntax.Proto2;
    /// <summary>
    /// The source syntax of this method.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Syntax Syntax {
      get { return syntax_; }
      set {
        syntax_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Method);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Method other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (RequestTypeUrl != other.RequestTypeUrl) return false;
      if (RequestStreaming != other.RequestStreaming) return false;
      if (ResponseTypeUrl != other.ResponseTypeUrl) return false;
      if (ResponseStreaming != other.ResponseStreaming) return false;
      if(!options_.Equals(other.options_)) return false;
      if (Syntax != other.Syntax) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (RequestTypeUrl.Length != 0) hash ^= RequestTypeUrl.GetHashCode();
      if (RequestStreaming != false) hash ^= RequestStreaming.GetHashCode();
      if (ResponseTypeUrl.Length != 0) hash ^= ResponseTypeUrl.GetHashCode();
      if (ResponseStreaming != false) hash ^= ResponseStreaming.GetHashCode();
      hash ^= options_.GetHashCode();
      if (Syntax != global::Google.Protobuf.WellKnownTypes.Syntax.Proto2) hash ^= Syntax.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (RequestTypeUrl.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RequestTypeUrl);
      }
      if (RequestStreaming != false) {
        output.WriteRawTag(24);
        output.WriteBool(RequestStreaming);
      }
      if (ResponseTypeUrl.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ResponseTypeUrl);
      }
      if (ResponseStreaming != false) {
        output.WriteRawTag(40);
        output.WriteBool(ResponseStreaming);
      }
      options_.WriteTo(output, _repeated_options_codec);
      if (Syntax != global::Google.Protobuf.WellKnownTypes.Syntax.Proto2) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Syntax);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (RequestTypeUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RequestTypeUrl);
      }
      if (RequestStreaming != false) {
        size += 1 + 1;
      }
      if (ResponseTypeUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResponseTypeUrl);
      }
      if (ResponseStreaming != false) {
        size += 1 + 1;
      }
      size += options_.CalculateSize(_repeated_options_codec);
      if (Syntax != global::Google.Protobuf.WellKnownTypes.Syntax.Proto2) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Syntax);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Method other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.RequestTypeUrl.Length != 0) {
        RequestTypeUrl = other.RequestTypeUrl;
      }
      if (other.RequestStreaming != false) {
        RequestStreaming = other.RequestStreaming;
      }
      if (other.ResponseTypeUrl.Length != 0) {
        ResponseTypeUrl = other.ResponseTypeUrl;
      }
      if (other.ResponseStreaming != false) {
        ResponseStreaming = other.ResponseStreaming;
      }
      options_.Add(other.options_);
      if (other.Syntax != global::Google.Protobuf.WellKnownTypes.Syntax.Proto2) {
        Syntax = other.Syntax;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            RequestTypeUrl = input.ReadString();
            break;
          }
          case 24: {
            RequestStreaming = input.ReadBool();
            break;
          }
          case 34: {
            ResponseTypeUrl = input.ReadString();
            break;
          }
          case 40: {
            ResponseStreaming = input.ReadBool();
            break;
          }
          case 50: {
            options_.AddEntriesFrom(input, _repeated_options_codec);
            break;
          }
          case 56: {
            Syntax = (global::Google.Protobuf.WellKnownTypes.Syntax) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            RequestTypeUrl = input.ReadString();
            break;
          }
          case 24: {
            RequestStreaming = input.ReadBool();
            break;
          }
          case 34: {
            ResponseTypeUrl = input.ReadString();
            break;
          }
          case 40: {
            ResponseStreaming = input.ReadBool();
            break;
          }
          case 50: {
            options_.AddEntriesFrom(ref input, _repeated_options_codec);
            break;
          }
          case 56: {
            Syntax = (global::Google.Protobuf.WellKnownTypes.Syntax) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Declares an API Interface to be included in this interface. The including
  /// interface must redeclare all the methods from the included interface, but
  /// documentation and options are inherited as follows:
  ///
  /// - If after comment and whitespace stripping, the documentation
  ///   string of the redeclared method is empty, it will be inherited
  ///   from the original method.
  ///
  /// - Each annotation belonging to the service config (http,
  ///   visibility) which is not set in the redeclared method will be
  ///   inherited.
  ///
  /// - If an http annotation is inherited, the path pattern will be
  ///   modified as follows. Any version prefix will be replaced by the
  ///   version of the including interface plus the [root][] path if
  ///   specified.
  ///
  /// Example of a simple mixin:
  ///
  ///     package google.acl.v1;
  ///     service AccessControl {
  ///       // Get the underlying ACL object.
  ///       rpc GetAcl(GetAclRequest) returns (Acl) {
  ///         option (google.api.http).get = "/v1/{resource=**}:getAcl";
  ///       }
  ///     }
  ///
  ///     package google.storage.v2;
  ///     service Storage {
  ///       rpc GetAcl(GetAclRequest) returns (Acl);
  ///
  ///       // Get a data record.
  ///       rpc GetData(GetDataRequest) returns (Data) {
  ///         option (google.api.http).get = "/v2/{resource=**}";
  ///       }
  ///     }
  ///
  /// Example of a mixin configuration:
  ///
  ///     apis:
  ///     - name: google.storage.v2.Storage
  ///       mixins:
  ///       - name: google.acl.v1.AccessControl
  ///
  /// The mixin construct implies that all methods in `AccessControl` are
  /// also declared with same name and request/response types in
  /// `Storage`. A documentation generator or annotation processor will
  /// see the effective `Storage.GetAcl` method after inherting
  /// documentation and annotations as follows:
  ///
  ///     service Storage {
  ///       // Get the underlying ACL object.
  ///       rpc GetAcl(GetAclRequest) returns (Acl) {
  ///         option (google.api.http).get = "/v2/{resource=**}:getAcl";
  ///       }
  ///       ...
  ///     }
  ///
  /// Note how the version in the path pattern changed from `v1` to `v2`.
  ///
  /// If the `root` field in the mixin is specified, it should be a
  /// relative path under which inherited HTTP paths are placed. Example:
  ///
  ///     apis:
  ///     - name: google.storage.v2.Storage
  ///       mixins:
  ///       - name: google.acl.v1.AccessControl
  ///         root: acls
  ///
  /// This implies the following inherited HTTP annotation:
  ///
  ///     service Storage {
  ///       // Get the underlying ACL object.
  ///       rpc GetAcl(GetAclRequest) returns (Acl) {
  ///         option (google.api.http).get = "/v2/acls/{resource=**}:getAcl";
  ///       }
  ///       ...
  ///     }
  /// </summary>
  public sealed partial class Mixin : pb::IMessage<Mixin>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Mixin> _parser = new pb::MessageParser<Mixin>(() => new Mixin());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Mixin> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.ApiReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Mixin() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Mixin(Mixin other) : this() {
      name_ = other.name_;
      root_ = other.root_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Mixin Clone() {
      return new Mixin(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The fully qualified name of the interface which is included.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "root" field.</summary>
    public const int RootFieldNumber = 2;
    private string root_ = "";
    /// <summary>
    /// If non-empty specifies a path under which inherited HTTP paths
    /// are rooted.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Root {
      get { return root_; }
      set {
        root_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Mixin);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Mixin other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Root != other.Root) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Root.Length != 0) hash ^= Root.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Root.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Root);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Root.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Root);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Mixin other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Root.Length != 0) {
        Root = other.Root;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            Root = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            Root = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
