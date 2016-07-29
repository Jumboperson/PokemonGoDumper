// Injector Called
/*
g_GetMonoDomain a0ff7f44
g_OpenAssembly a0ff7f48
g_GetAssemblyImage a0ff7930
g_GetClassFromName a0ff7954
g_ClassMethodFromName a0ff797c
g_InvokeRuntime a0ff81ec
g_pMetadata 9f8e4000
g_GetAssemblies a0ff9798
g_GetCurrDomain a0ff971c
g_GetVirt a103ecf4
g_GetTypeName a10007a0
g_GetAssemblyTypes a100af10
GC_free a105cdcc
g_GetImageFromIndex a1031ebc
g_GetClassFromIndex a1031ef4
g_SetupClass a1026148
g_GetFieldDefault a102bd5c
*/
// AppDomain ab34bfa0
// Number of assemblies: 18
/* Assembly 7: Niantic.Promenade.Auth, Version=0.0.0.0, Culture=, PublicKeyToken=null
	Contains 0014 classes */
/****************** Beginning class dump ****************************/
// Namespace: 
class <Module>
{
}
// Namespace: Com.Nianticproject.Platform.Auth.Plugins.Google
class GoogleTokenReflection
{
	// Fields
	FileDescriptor descriptor;

	// Methods
	void .cctor(); // a08eb894
	FileDescriptor get_Descriptor(); // a08eb03c

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0cd168c
	virtual void Finalize(); // 1 - a0cd16f4
	virtual int GetHashCode(); // 2 - a0cd16f8
	virtual String ToString(); // 3 - a0cd1704
}
// Namespace: Com.Nianticproject.Platform.Auth.Plugins.Google
class GoogleToken
{
	// Fields
	Generic _parser;
	String idToken_;

	// Methods
	void .ctor(); // a08eae60
	void .ctor(Void other); // a08eaf1c
	MessageDescriptor get_Descriptor(); // a08eaf44
	MessageDescriptor Google.Protobuf.IMessage.get_Descriptor(); // a08eb0ec
	GoogleToken Clone(); // a08eb184
	String get_IdToken(); // a08eb214
	void set_IdToken(String value); // a08eb21c
	boolean Equals(mvar other); // a08eb2bc
	boolean Equals(Boolean other); // a08eb360
	int GetHashCode(); // a08eb46c
	String ToString(); // a08eb4d4
	void WriteTo(Void output); // a08eb57c
	int CalculateSize(); // a08eb5d8
	void MergeFrom(Void input); // a08eb6b0
	void .cctor(); // a08eb710
	GoogleToken <_parser>m__0(); // a08eb80c

	// VTable
	virtual boolean Equals(mvar other); // 0 - a08eb2bc
	virtual void Finalize(); // 1 - a0cd16f4
	virtual int GetHashCode(); // 2 - a08eb46c
	virtual String ToString(); // 3 - a08eb4d4
	virtual void MergeFrom(Void input); // 4 - a08eb6b0
	virtual void WriteTo(Void output); // 5 - a08eb57c
	virtual int CalculateSize(); // 6 - a08eb5d8
	virtual MessageDescriptor Google.Protobuf.IMessage.get_Descriptor(); // 7 - a08eb0ec
	virtual boolean Equals(Boolean other); // 8 - a08eb360
	virtual GoogleToken Clone(); // 9 - a08eb184
}
// Namespace: NianticLabs.Auth
class GoogleTokenSource
{
	// Fields
	String clientId;
	String clientSecret;

	// Methods
	void .ctor(String clientId, String clientSecret); // a08eb918
	String NianticLabs.Auth.ITokenSource.get_AuthenticationProviderId(); // a08eb940
	void NianticLabs.Auth.ITokenSource.GetToken(Generic tokenCallback); // a08eb9b8
	void NianticLabs.Auth.ITokenSource.RefreshToken(Generic tokenCallback); // a08ebb10
	void NianticLabs.Auth.ITokenSource.ClearToken(); // a08ebc68
	IMessage CreateRequest(String sacsid); // a08ebd08

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0cd168c
	virtual void Finalize(); // 1 - a0cd16f4
	virtual int GetHashCode(); // 2 - a0cd16f8
	virtual String ToString(); // 3 - a0cd1704
	virtual String NianticLabs.Auth.ITokenSource.get_AuthenticationProviderId(); // 4 - a08eb940
	virtual void NianticLabs.Auth.ITokenSource.GetToken(Generic tokenCallback); // 5 - a08eb9b8
	virtual void NianticLabs.Auth.ITokenSource.RefreshToken(Generic tokenCallback); // 6 - a08ebb10
	virtual void NianticLabs.Auth.ITokenSource.ClearToken(); // 7 - a08ebc68
}
// Namespace: <NianticLabs.Auth.ITokenSource
class GetToken>c__AnonStorey0
{
	// Fields
	Generic tokenCallback;
	GoogleTokenSource $this;

	// Methods
	void .ctor(); // a08ebb08
	void <>m__0(String token); // a08ebdac

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0cd168c
	virtual void Finalize(); // 1 - a0cd16f4
	virtual int GetHashCode(); // 2 - a0cd16f8
	virtual String ToString(); // 3 - a0cd1704
}
// Namespace: <NianticLabs.Auth.ITokenSource
class GetToken>c__AnonStorey1
{
	// Fields
	IMessage request;
	GetToken>c__AnonStorey0 <>f__ref$0;

	// Methods
	void .ctor(); // a08ebef4
	void <>m__0(); // a08ebefc

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0cd168c
	virtual void Finalize(); // 1 - a0cd16f4
	virtual int GetHashCode(); // 2 - a0cd16f8
	virtual String ToString(); // 3 - a0cd1704
}
// Namespace: <NianticLabs.Auth.ITokenSource
class RefreshToken>c__AnonStorey2
{
	// Fields
	Generic tokenCallback;
	GoogleTokenSource $this;

	// Methods
	void .ctor(); // a08ebc60
	void <>m__0(String token); // a08ebf98

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0cd168c
	virtual void Finalize(); // 1 - a0cd16f4
	virtual int GetHashCode(); // 2 - a0cd16f8
	virtual String ToString(); // 3 - a0cd1704
}
// Namespace: <NianticLabs.Auth.ITokenSource
class RefreshToken>c__AnonStorey3
{
	// Fields
	IMessage request;
	RefreshToken>c__AnonStorey2 <>f__ref$2;

	// Methods
	void .ctor(); // a08ec0e0
	void <>m__0(); // a08ec0e8

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0cd168c
	virtual void Finalize(); // 1 - a0cd16f4
	virtual int GetHashCode(); // 2 - a0cd16f8
	virtual String ToString(); // 3 - a0cd1704
}
// Namespace: NianticLabs.Auth
class TokenManager
{
	// Fields
	String serverHostPort;
	ITokenSource tokenSource;
	boolean started;
	boolean refreshingToken;
	boolean tokenSourceHasStaleCachedToken;
	IMessage token;
	InternalState state;
	AuthEventHandler AuthEvents;

	// Methods
	void .ctor(String serverHostPort, Void tokenSource); // a08ec184
	void Finalize(); // a08ec1b8
	void add_AuthEvents(Void value); // a08ec220
	void remove_AuthEvents(Void value); // a08ec3d4
	void Start(); // a08ec588
	void Stop(); // a08ecf8c
	void Dispose(); // a08ec21c
	void GetTokenCallback(Void token); // a08ed08c
	void ChannelAuthEventCallback(Void evt); // a08ed0a8
	void NotifyAuthEvents(Void evt); // a08ed0f4
	void HandleEvent(Void evt); // a08ec704

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0cd168c
	virtual void Finalize(); // 1 - a08ec1b8
	virtual int GetHashCode(); // 2 - a0cd16f8
	virtual String ToString(); // 3 - a0cd1704
	virtual void Dispose(); // 4 - a08ec21c
}
// Namespace: NianticLabs.Auth
class ITokenSource
{

	// Methods
	String get_AuthenticationProviderId(); // 0
	void GetToken(Generic tokenCallback); // 0
	void RefreshToken(Generic tokenCallback); // 0
	void ClearToken(); // 0
}
// Namespace: 
class InternalState
{
	// Fields
	int value__;
	static InternalState NO_TOKEN = 0;
	static InternalState STOPPING = 1;
	static InternalState GETTING_NEW_TOKEN = 2;
	static InternalState REFRESHING_TOKEN = 3;
	static InternalState SETTING_TOKEN = 4;
	static InternalState AUTHORIZED = 5;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0c8702c
	virtual void Finalize(); // 1 - a0cd16f4
	virtual int GetHashCode(); // 2 - a0c87044
	virtual String ToString(); // 3 - a0c86258
	virtual String ToString(String format, String provider); // 4 - a0c86ecc
	virtual TypeCode GetTypeCode(); // 5 - a0c83e20
	virtual boolean System.IConvertible.ToBoolean(Boolean provider); // 6 - a0c83270
	virtual byte System.IConvertible.ToByte(Byte provider); // 7 - a0c83328
	virtual char System.IConvertible.ToChar(Char provider); // 8 - a0c833dc
	virtual DateTime System.IConvertible.ToDateTime(DateTime provider); // 9 - a0c83490
	virtual Decimal System.IConvertible.ToDecimal(Decimal provider); // 10 - a0c83554
	virtual double System.IConvertible.ToDouble(Double provider); // 11 - a0c83618
	virtual short System.IConvertible.ToInt16(Int16 provider); // 12 - a0c836cc
	virtual int System.IConvertible.ToInt32(Int32 provider); // 13 - a0c83780
	virtual long System.IConvertible.ToInt64(Int64 provider); // 14 - a0c83834
	virtual sbyte System.IConvertible.ToSByte(SByte provider); // 15 - a0c838e8
	virtual float System.IConvertible.ToSingle(Single provider); // 16 - a0c8399c
	virtual String ToString(String provider); // 17 - a0c8643c
	virtual mvar System.IConvertible.ToType(Object targetType, Object provider); // 18 - a0c83a50
	virtual ushort System.IConvertible.ToUInt16(UInt16 provider); // 19 - a0c83c04
	virtual uint System.IConvertible.ToUInt32(UInt32 provider); // 20 - a0c83cb8
	virtual ulong System.IConvertible.ToUInt64(UInt64 provider); // 21 - a0c83d6c
	virtual int CompareTo(mvar target); // 22 - a0c860e8
}
// Namespace: 
class AuthEventHandler
{

	// Methods
	void .ctor(mvar object, uint method); // a08ed1c8
	void Invoke(Void evt); // a08ed108
	IAsyncResult BeginInvoke(IAsyncResult evt, IAsyncResult callback, mvar object); // a08ed1ec
	void EndInvoke(Void result); // a08ed2a8

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0cc878c
	virtual void Finalize(); // 1 - a0cd16f4
	virtual int GetHashCode(); // 2 - a0cc88a8
	virtual String ToString(); // 3 - a0cd1704
	virtual mvar Clone(); // 4 - a0c7e0fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0cc8718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0cc8738
	virtual mvar Clone(); // 7 - a0c7e0fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0cc8718
	virtual cmod_reqd GetInvocationList(); // 9 - a0cc88b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0cc8ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0cc8fb4
	virtual void Invoke(Void evt); // 12 - a08ed108
	virtual IAsyncResult BeginInvoke(IAsyncResult evt, IAsyncResult callback, mvar object); // 13 - a08ed1ec
	virtual void EndInvoke(Void result); // 14 - a08ed2a8
}
// Namespace: 
class AuthEvent
{
	// Fields
	int value__;
	static AuthEvent UNAUTHORIZED = 0;
	static AuthEvent AUTHORIZATION_PENDING = 1;
	static AuthEvent AUTHORIZED = 2;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0c8702c
	virtual void Finalize(); // 1 - a0cd16f4
	virtual int GetHashCode(); // 2 - a0c87044
	virtual String ToString(); // 3 - a0c86258
	virtual String ToString(String format, String provider); // 4 - a0c86ecc
	virtual TypeCode GetTypeCode(); // 5 - a0c83e20
	virtual boolean System.IConvertible.ToBoolean(Boolean provider); // 6 - a0c83270
	virtual byte System.IConvertible.ToByte(Byte provider); // 7 - a0c83328
	virtual char System.IConvertible.ToChar(Char provider); // 8 - a0c833dc
	virtual DateTime System.IConvertible.ToDateTime(DateTime provider); // 9 - a0c83490
	virtual Decimal System.IConvertible.ToDecimal(Decimal provider); // 10 - a0c83554
	virtual double System.IConvertible.ToDouble(Double provider); // 11 - a0c83618
	virtual short System.IConvertible.ToInt16(Int16 provider); // 12 - a0c836cc
	virtual int System.IConvertible.ToInt32(Int32 provider); // 13 - a0c83780
	virtual long System.IConvertible.ToInt64(Int64 provider); // 14 - a0c83834
	virtual sbyte System.IConvertible.ToSByte(SByte provider); // 15 - a0c838e8
	virtual float System.IConvertible.ToSingle(Single provider); // 16 - a0c8399c
	virtual String ToString(String provider); // 17 - a0c8643c
	virtual mvar System.IConvertible.ToType(Object targetType, Object provider); // 18 - a0c83a50
	virtual ushort System.IConvertible.ToUInt16(UInt16 provider); // 19 - a0c83c04
	virtual uint System.IConvertible.ToUInt32(UInt32 provider); // 20 - a0c83cb8
	virtual ulong System.IConvertible.ToUInt64(UInt64 provider); // 21 - a0c83d6c
	virtual int CompareTo(mvar target); // 22 - a0c860e8
}
// Namespace: 
class InternalStateEvents
{
	// Fields
	int value__;
	static InternalStateEvents START = 0;
	static InternalStateEvents STOP = 1;
	static InternalStateEvents GOT_TOKEN = 2;
	static InternalStateEvents GET_TOKEN_FAILED = 3;
	static InternalStateEvents CHANNEL_TOKEN_REQUEST_FAILED = 4;
	static InternalStateEvents CHANNEL_REFRESH_REQUESTED = 5;
	static InternalStateEvents CHANNEL_PROACTIVE_REFRESH_REQUESTED = 6;
	static InternalStateEvents CHANNEL_GOT_NIANTIC_TOKEN = 7;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0c8702c
	virtual void Finalize(); // 1 - a0cd16f4
	virtual int GetHashCode(); // 2 - a0c87044
	virtual String ToString(); // 3 - a0c86258
	virtual String ToString(String format, String provider); // 4 - a0c86ecc
	virtual TypeCode GetTypeCode(); // 5 - a0c83e20
	virtual boolean System.IConvertible.ToBoolean(Boolean provider); // 6 - a0c83270
	virtual byte System.IConvertible.ToByte(Byte provider); // 7 - a0c83328
	virtual char System.IConvertible.ToChar(Char provider); // 8 - a0c833dc
	virtual DateTime System.IConvertible.ToDateTime(DateTime provider); // 9 - a0c83490
	virtual Decimal System.IConvertible.ToDecimal(Decimal provider); // 10 - a0c83554
	virtual double System.IConvertible.ToDouble(Double provider); // 11 - a0c83618
	virtual short System.IConvertible.ToInt16(Int16 provider); // 12 - a0c836cc
	virtual int System.IConvertible.ToInt32(Int32 provider); // 13 - a0c83780
	virtual long System.IConvertible.ToInt64(Int64 provider); // 14 - a0c83834
	virtual sbyte System.IConvertible.ToSByte(SByte provider); // 15 - a0c838e8
	virtual float System.IConvertible.ToSingle(Single provider); // 16 - a0c8399c
	virtual String ToString(String provider); // 17 - a0c8643c
	virtual mvar System.IConvertible.ToType(Object targetType, Object provider); // 18 - a0c83a50
	virtual ushort System.IConvertible.ToUInt16(UInt16 provider); // 19 - a0c83c04
	virtual uint System.IConvertible.ToUInt32(UInt32 provider); // 20 - a0c83cb8
	virtual ulong System.IConvertible.ToUInt64(UInt64 provider); // 21 - a0c83d6c
	virtual int CompareTo(mvar target); // 22 - a0c860e8
}
/****************** Dumped 0014 classes *****************************/
