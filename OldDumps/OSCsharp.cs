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
/* Assembly 8: OSCsharp, Version=1.0.0.0, Culture=, PublicKeyToken=null
	Contains 0013 classes */
/****************** Beginning class dump ****************************/
// Namespace: 
class <Module>
{
}
// Namespace: OSCsharp.Net
class OscBundleReceivedEventArgs
{
	// Fields
	OscBundle <Bundle>k__BackingField;

	// Methods
	void set_Bundle(Void value); // a090a470
	void .ctor(Void bundle); // a090a478

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0cd168c
	virtual void Finalize(); // 1 - a0cd16f4
	virtual int GetHashCode(); // 2 - a0cd16f8
	virtual String ToString(); // 3 - a0cd1704
}
// Namespace: OSCsharp.Data
class OscBundle
{
	// Fields
	static String BUNDLE_PREFIX = @"#bundle";
	OscTimeTag timeStamp;

	// Methods
	boolean get_IsBundle(); // a0907f78
	void .ctor(Void timeStamp); // a0907f80
	OscBundle FromByteArray(cmod_reqd data, int start, int end); // a09080f8
	int Append(mvar value); // a0908428

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0cd168c
	virtual void Finalize(); // 1 - a0cd16f4
	virtual int GetHashCode(); // 2 - a0cd16f8
	virtual String ToString(); // 3 - a0cd1704
	virtual boolean get_IsBundle(); // 4 - a0907f78
	virtual int Append(mvar value); // 5 - a0908428
}
// Namespace: OSCsharp.Data
class OscTimeTag
{
	// Fields
	DateTime Epoch;
	OscTimeTag MinValue;
	DateTime timeStamp;

	// Methods
	DateTime get_DateTime(); // a09098c0
	void .ctor(Void timeStamp); // a09098d0
	void .ctor(cmod_reqd data); // a0909ac4
	boolean op_Equality(Boolean lhs, Boolean rhs); // a0909e70
	boolean op_LessThan(Boolean lhs, Boolean rhs); // a090862c
	boolean IsValidTime(Boolean timeStamp); // a0909fa4
	void Set(Void timeStamp); // a0909914
	boolean Equals(mvar value); // a090a154
	int GetHashCode(); // a090a280
	String ToString(); // a090a28c
	void .cctor(); // a090a298

	// VTable
	virtual boolean Equals(mvar value); // 0 - a090a154
	virtual void Finalize(); // 1 - a0cd16f4
	virtual int GetHashCode(); // 2 - a090a280
	virtual String ToString(); // 3 - a090a28c
}
// Namespace: OSCsharp.Net
class OscMessageReceivedEventArgs
{
	// Fields
	OscMessage <Message>k__BackingField;

	// Methods
	OscMessage get_Message(); // a090a524
	void set_Message(Void value); // a090a52c
	void .ctor(Void message); // a090a534

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0cd168c
	virtual void Finalize(); // 1 - a0cd16f4
	virtual int GetHashCode(); // 2 - a0cd16f8
	virtual String ToString(); // 3 - a0cd1704
}
// Namespace: OSCsharp.Data
class OscMessage
{
	// Fields
	static String ADRESS_PREFIX = @"/";
	String typeTag;
	Generic <>f__switch$map0;

	// Methods
	boolean get_IsBundle(); // a0908730
	void .ctor(String address); // a0908738
	OscMessage FromByteArray(cmod_reqd data, int start); // a0908894
	int Append(mvar value); // a0908f54

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0cd168c
	virtual void Finalize(); // 1 - a0cd16f4
	virtual int GetHashCode(); // 2 - a0cd16f8
	virtual String ToString(); // 3 - a0cd1704
	virtual boolean get_IsBundle(); // 4 - a0908730
	virtual int Append(mvar value); // 5 - a0908f54
}
// Namespace: OSCsharp.Net
class OscPacketReceivedEventArgs
{
	// Fields
	OscPacket <Packet>k__BackingField;

	// Methods
	void set_Packet(Void value); // a090a5e0
	void .ctor(Void packet); // a090a5e8

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0cd168c
	virtual void Finalize(); // 1 - a0cd16f4
	virtual int GetHashCode(); // 2 - a0cd16f8
	virtual String ToString(); // 3 - a0cd1704
}
// Namespace: OSCsharp.Data
class OscPacket
{
	// Fields
	boolean littleEndianByteOrder;
	String address;
	Generic data;
	Generic <>f__switch$map1;

	// Methods
	boolean get_LittleEndianByteOrder(); // a0909530
	boolean get_IsBundle(); // 0
	String get_Address(); // a09095e0
	void set_Address(String value); // a09095e8
	Generic get_Data(); // a09096ac
	void .cctor(); // a090973c
	void .ctor(String address); // a090803c
	int Append(mvar value); // 0
	OscPacket FromByteArray(cmod_reqd data); // a09097c0
	OscPacket FromByteArray(cmod_reqd data, int start, int end); // a09083b8
	cmod_opt ValueFromByteArray(cmod_reqd data, int start); // 0

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0cd168c
	virtual void Finalize(); // 1 - a0cd16f4
	virtual int GetHashCode(); // 2 - a0cd16f8
	virtual String ToString(); // 3 - a0cd1704
}
// Namespace: OSCsharp.Net
class TransmissionType
{
	// Fields
	int value__;
	static TransmissionType Unicast = 0;
	static TransmissionType Multicast = 1;
	static TransmissionType Broadcast = 2;
	static TransmissionType LocalBroadcast = 3;

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
// Namespace: OSCsharp.Net
class UDPReceiver
{
	// Fields
	Generic PacketReceived;
	Generic BundleReceived;
	Generic ErrorOccured;
	Generic messageReceivedInvoker;
	IPAddress <IPAddress>k__BackingField;
	int <Port>k__BackingField;
	IPAddress <MulticastAddress>k__BackingField;
	IPEndPoint <IPEndPoint>k__BackingField;
	TransmissionType <TransmissionType>k__BackingField;
	boolean <ConsumeParsingExceptions>k__BackingField;
	UdpClient udpClient;
	boolean acceptingConnections;
	AsyncCallback callback;

	// Methods
	void add_ErrorOccured(Generic value); // a090a694
	void remove_ErrorOccured(Generic value); // a090a848
	void add_MessageReceived(Generic value); // a090a9fc
	void remove_MessageReceived(Generic value); // a090ab88
	IPAddress get_IPAddress(); // a090ad14
	void set_IPAddress(Void value); // a090ad1c
	int get_Port(); // a090ad24
	void set_Port(int value); // a090ad2c
	IPAddress get_MulticastAddress(); // a090ad34
	void set_MulticastAddress(Void value); // a090ad3c
	IPEndPoint get_IPEndPoint(); // a090ad44
	void set_IPEndPoint(Void value); // a090ad4c
	TransmissionType get_TransmissionType(); // a090ad54
	void set_TransmissionType(Void value); // a090ad5c
	boolean get_ConsumeParsingExceptions(); // a090ad64
	void set_ConsumeParsingExceptions(boolean value); // a090ad6c
	boolean get_IsRunning(); // a090ad74
	void .ctor(int port, boolean consumeParsingExceptions); // a090ad8c
	void .ctor(Void ipAddress, int port, boolean consumeParsingExceptions); // a090ae68
	void .ctor(Void ipAddress, int port, Void transmissionType, Void multicastAddress, boolean consumeParsingExceptions); // a090ae90
	void Start(); // a090afcc
	void Stop(); // a090b358
	void endReceive(Void asyncResult); // a090b3b0
	void parseData(Void sourceEndPoint, cmod_reqd data); // a090b5c0
	void onPacketReceived(Void packet); // a090b7f0
	void onBundleReceived(Void bundle); // a090b8b0
	void onMessageReceived(Void message); // a090bae0
	void onError(Void ex); // a090bba0

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0cd168c
	virtual void Finalize(); // 1 - a0cd16f4
	virtual int GetHashCode(); // 2 - a0cd16f8
	virtual String ToString(); // 3 - a0cd1704
}
// Namespace: 
class UdpState
{
	// Fields
	UdpClient <Client>k__BackingField;
	IPEndPoint <IPEndPoint>k__BackingField;

	// Methods
	UdpClient get_Client(); // a090b5b0
	void set_Client(Void value); // a090bd0c
	IPEndPoint get_IPEndPoint(); // a090b5b8
	void set_IPEndPoint(Void value); // a090bd14
	void .ctor(Void client, Void ipEndPoint); // a090b330

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0cd168c
	virtual void Finalize(); // 1 - a0cd16f4
	virtual int GetHashCode(); // 2 - a0cd16f8
	virtual String ToString(); // 3 - a0cd1704
}
// Namespace: OSCsharp.Utils
class ExceptionEventArgs
{
	// Fields
	Exception <Exception>k__BackingField;

	// Methods
	void set_Exception(Void value); // a090bd1c
	void .ctor(Void ex); // a090bc60

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0cd168c
	virtual void Finalize(); // 1 - a0cd16f4
	virtual int GetHashCode(); // 2 - a0cd16f8
	virtual String ToString(); // 3 - a0cd1704
}
// Namespace: OSCsharp.Utils
class Utility
{

	// Methods
	cmod_reqd CopySubArray(cmod_reqd source, int start, int length); // 0
	cmod_reqd SwapEndian(cmod_reqd data); // a0909d5c

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0cd168c
	virtual void Finalize(); // 1 - a0cd16f4
	virtual int GetHashCode(); // 2 - a0cd16f8
	virtual String ToString(); // 3 - a0cd1704
}
/****************** Dumped 0013 classes *****************************/
