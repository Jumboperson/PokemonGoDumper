// Injector Called
/*
g_GetMonoDomain a0ef2f44
g_OpenAssembly a0ef2f48
g_GetAssemblyImage a0ef2930
g_GetClassFromName a0ef2954
g_ClassMethodFromName a0ef297c
g_InvokeRuntime a0ef31ec
g_pMetadata 9f7df000
g_GetAssemblies a0ef4798
g_GetCurrDomain a0ef471c
g_GetVirt a0f39cf4
g_GetTypeName a0efb7a0
g_GetAssemblyTypes a0f05f10
GC_free a0f57dcc
g_GetImageFromIndex a0f2cebc
g_GetClassFromIndex a0f2cef4
g_SetupClass a0f21148
g_GetFieldDefault a0f26d5c
*/
// AppDomain ab34bfa0
// Number of assemblies: 18
/* Assembly 6: Niantic.Promenade, Version=0.0.0.0, Culture=, PublicKeyToken=null
	Contains 0146 classes */
/****************** Beginning class dump ****************************/
// Namespace: 
class <Module>
{
}
// Namespace: NianticLabs.Platform
class AsyncTaskQueue
{
	// Fields
	Generic completedTasks;
	WaitCallback <>f__mg$cache0;

	// Methods
	void RunAsync(Void action, Void completeOnUnityMain); // a07e82b4
	void RunAsync(Void action, Void completeOnUnityMain, Void token); // a07e8360
	void RunOnUnityMain(Void action); // a07e8560
	void RunOnUnityMain(Void action, Void token); // a07e8604
	int Process(long timeBudgetMs); // a07e87c8
	void ThreadProc(mvar stateInfo); // a07e8c48
	void .cctor(); // a07e8e3c

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: 
class CancellationToken
{
	// Fields
	int cancelled;

	// Methods
	boolean get_IsCancelled(); // a07e8eec

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: 
class Task
{
	// Fields
	Action action;
	Action complete;
	CancellationToken token;

	// Methods
	void .ctor(Void action, Void complete, Void token); // a07e8530
	boolean get_IsCancelled(); // a07e8c28

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: NianticLabs.Platform.Tasks
class IFuture`1
{

	// Methods
	var get_Value(); // 0
}
// Namespace: NianticLabs.Platform.Tasks
class CancellationToken
{
	// Fields
	boolean cancelled;

	// Methods
	boolean get_IsCancelled(); // a0800948

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: NianticLabs.Platform
class IapEventHandler
{
	// Fields
	IIapEventManager iapManager;
	IapEventDelegateType <>f__mg$cache0;

	// Methods
	int ProcessEvents(); // a07ef904
	void SetEventManager(Void manager); // a07efa40
	void IapEventCallback(Void iapEvent, uint eventParams); // a07efb0c
	void StoreRefreshCallback(uint eventParams); // a07efb18

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: NianticLabs.Platform
class IIapEventManager
{

	// Methods
	void OnStoreRefresh(); // 0
}
// Namespace: 
class IapEventDelegateType
{

	// Methods
	void .ctor(mvar object, uint method); // a07ef384
	void Invoke(Void iapEvent, uint eventParams); // a07ef398
	IAsyncResult BeginInvoke(IAsyncResult iapEvent, uint eventParams, IAsyncResult callback, mvar object); // a07ef490
	void EndInvoke(Void result); // a07ef570

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual void Invoke(Void iapEvent, uint eventParams); // 12 - a07ef398
	virtual IAsyncResult BeginInvoke(IAsyncResult iapEvent, uint eventParams, IAsyncResult callback, mvar object); // 13 - a07ef490
	virtual void EndInvoke(Void result); // 14 - a07ef570
}
// Namespace: NianticLabs.Platform
class ICell
{
}
// Namespace: NianticLabs.Platform
class ICellManager
{

	// Methods
	void UpdateCells(Generic fetchCells, Generic deletedCells, Generic addedToScene, Generic removedFromScene, Generic updatedSceneCells); // 0
}
// Namespace: NianticLabs.Platform
class IMapTileBuilder
{

	// Methods
	void OnBeginTile(ulong tileId); // 0
	void OnEndTile(); // 0
	void OnPoint(Void kind, cmod_reqd points); // 0
	void OnLinear(Void kind, cmod_reqd points, cmod_reqd lineStrips); // 0
	void OnMesh(Void kind, cmod_reqd points, cmod_reqd indices); // 0
	void OnGmmBuilding(Void kind, cmod_reqd points, cmod_reqd indices, cmod_reqd exterior_edges, float height, float base_height); // 0
	void OnArea(Void kind, cmod_reqd points, cmod_reqd indices, cmod_reqd exterior_edges); // 0
}
// Namespace: NianticLabs.Platform
class IMapTileManager
{

	// Methods
	void OnCreateTile(ulong id, double x, double y, double z, double size, int level); // 0
	void OnDeleteTile(ulong id); // 0
	void OnBeginTile(ulong id); // 0
	void OnEndTile(ulong id); // 0
	void OnLayer(Void layer); // 0
	void OnPoint(Void kind, cmod_reqd points); // 0
	void OnLinear(Void kind, cmod_reqd points, cmod_reqd lineStrips); // 0
	void OnMesh(Void kind, cmod_reqd points, cmod_reqd indices); // 0
	void OnGmmBuilding(Void kind, cmod_reqd points, cmod_reqd indices, cmod_reqd exterior_edges, float height, float base_height); // 0
	void OnArea(Void kind, cmod_reqd points, cmod_reqd indices, cmod_reqd exterior_edges); // 0
	boolean OnProcessingPauseCheck(); // 0
	void SubscribeToLayer(Void layer, Void kind, Void builder); // 0
}
// Namespace: NianticLabs.Platform
class MapTileEventHandler
{
	// Fields
	IMapTileManager tileManager;
	TileEventDelegateType <>f__mg$cache0;
	Vector3AllocatorDelegateType <>f__mg$cache1;
	IntegerAllocatorDelegateType <>f__mg$cache2;
	DeallocatorDelegateType <>f__mg$cache3;

	// Methods
	int ProcessEvents(); // a07f20d4
	void SetTileManager(Void manager); // a07f2334
	void SubscribeLayer(Void layer); // a07f23b8
	boolean TileEventCallback(Boolean tileEvent, uint tileParams); // a07f2410
	void Vector3AllocatorCallback(int requestedSize, uint rawPointer, uint handle); // a07f3bb8
	void IntegerAllocatorCallback(int requestedSize, uint rawPointer, uint handle); // a07f3ccc
	void DeallocatorCallback(uint handle); // a07f3db4
	void CreateTileCallback(uint tileParams); // a07f2598
	void DeleteTileCallback(uint tileParams); // a07f27bc
	void BeginTileCallback(uint tileParams); // a07f29b4
	void EndTileCallback(uint tileParams); // a07f2bac
	void LayerCallback(uint tileParams); // a07f2da4
	void PointCallback(uint tileParams); // a07f2f88
	void LinearCallback(uint tileParams); // a07f31a0
	void MeshCallback(uint tileParams); // a07f33ec
	void GmmBuildingCallback(uint tileParams); // a07f3638
	void AreaCallback(uint tileParams); // a07f38d0

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: 
class TileEventDelegateType
{

	// Methods
	void .ctor(mvar object, uint method); // a07f1c60
	boolean Invoke(Boolean tileEvent, uint eventParams); // a07f1c74
	IAsyncResult BeginInvoke(IAsyncResult tileEvent, uint eventParams, IAsyncResult callback, mvar object); // a07f1d68
	boolean EndInvoke(Boolean result); // a07f1e48

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual boolean Invoke(Boolean tileEvent, uint eventParams); // 12 - a07f1c74
	virtual IAsyncResult BeginInvoke(IAsyncResult tileEvent, uint eventParams, IAsyncResult callback, mvar object); // 13 - a07f1d68
	virtual boolean EndInvoke(Boolean result); // 14 - a07f1e48
}
// Namespace: 
class Vector3AllocatorDelegateType
{

	// Methods
	void .ctor(mvar object, uint method); // a07f1e74
	void Invoke(int requestedSize, uint rawPointer, uint handle); // a07f1e88
	IAsyncResult BeginInvoke(int requestedSize, uint rawPointer, uint handle, IAsyncResult callback, mvar object); // a07f1fc4
	void EndInvoke(uint rawPointer, uint handle, Void result); // a07f20b4

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual void Invoke(int requestedSize, uint rawPointer, uint handle); // 12 - a07f1e88
	virtual IAsyncResult BeginInvoke(int requestedSize, uint rawPointer, uint handle, IAsyncResult callback, mvar object); // 13 - a07f1fc4
	virtual void EndInvoke(uint rawPointer, uint handle, Void result); // 14 - a07f20b4
}
// Namespace: 
class IntegerAllocatorDelegateType
{

	// Methods
	void .ctor(mvar object, uint method); // a07f1860
	void Invoke(int requestedSize, uint rawPointer, uint handle); // a07f1874
	IAsyncResult BeginInvoke(int requestedSize, uint rawPointer, uint handle, IAsyncResult callback, mvar object); // a07f19b0
	void EndInvoke(uint rawPointer, uint handle, Void result); // a07f1aa0

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual void Invoke(int requestedSize, uint rawPointer, uint handle); // 12 - a07f1874
	virtual IAsyncResult BeginInvoke(int requestedSize, uint rawPointer, uint handle, IAsyncResult callback, mvar object); // 13 - a07f19b0
	virtual void EndInvoke(uint rawPointer, uint handle, Void result); // 14 - a07f1aa0
}
// Namespace: 
class DeallocatorDelegateType
{

	// Methods
	void .ctor(mvar object, uint method); // a07f16b4
	void Invoke(uint handle); // a07f16c8
	IAsyncResult BeginInvoke(uint handle, IAsyncResult callback, mvar object); // a07f1798
	void EndInvoke(Void result); // a07f1854

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual void Invoke(uint handle); // 12 - a07f16c8
	virtual IAsyncResult BeginInvoke(uint handle, IAsyncResult callback, mvar object); // 13 - a07f1798
	virtual void EndInvoke(Void result); // 14 - a07f1854
}
// Namespace: 
class CreateTileParams
{
	// Fields
	ulong tileId;
	double x;
	double y;
	double z;
	double size;
	int level;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0d18a48
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0d18a60
	virtual String ToString(); // 3 - a0d18b28
}
// Namespace: 
class DeleteTileParams
{
	// Fields
	ulong tileId;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0d18a48
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0d18a60
	virtual String ToString(); // 3 - a0d18b28
}
// Namespace: 
class BeginTileParams
{
	// Fields
	ulong tileId;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0d18a48
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0d18a60
	virtual String ToString(); // 3 - a0d18b28
}
// Namespace: 
class EndTileParams
{
	// Fields
	ulong tileId;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0d18a48
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0d18a60
	virtual String ToString(); // 3 - a0d18b28
}
// Namespace: 
class LayerParams
{
	// Fields
	MapLayer layerId;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0d18a48
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0d18a60
	virtual String ToString(); // 3 - a0d18b28
}
// Namespace: NianticLabs.Platform
class MapLayer
{
	// Fields
	int value__;
	static MapLayer UNDEFINED = 0;
	static MapLayer BOUNDARIES = 1;
	static MapLayer BUILDINGS = 2;
	static MapLayer LANDMASS = 3;
	static MapLayer LANDUSE = 4;
	static MapLayer PLACES = 5;
	static MapLayer POIS = 6;
	static MapLayer ROADS = 7;
	static MapLayer TRANSIT = 8;
	static MapLayer WATER = 9;
	static MapLayer DEBUG_TILE_BOUNDARIES = 10;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0b8202c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0b82044
	virtual String ToString(); // 3 - a0b81258
	virtual String ToString(String format, String provider); // 4 - a0b81ecc
	virtual TypeCode GetTypeCode(); // 5 - a0b7ee20
	virtual boolean System.IConvertible.ToBoolean(Boolean provider); // 6 - a0b7e270
	virtual byte System.IConvertible.ToByte(Byte provider); // 7 - a0b7e328
	virtual char System.IConvertible.ToChar(Char provider); // 8 - a0b7e3dc
	virtual DateTime System.IConvertible.ToDateTime(DateTime provider); // 9 - a0b7e490
	virtual Decimal System.IConvertible.ToDecimal(Decimal provider); // 10 - a0b7e554
	virtual double System.IConvertible.ToDouble(Double provider); // 11 - a0b7e618
	virtual short System.IConvertible.ToInt16(Int16 provider); // 12 - a0b7e6cc
	virtual int System.IConvertible.ToInt32(Int32 provider); // 13 - a0b7e780
	virtual long System.IConvertible.ToInt64(Int64 provider); // 14 - a0b7e834
	virtual sbyte System.IConvertible.ToSByte(SByte provider); // 15 - a0b7e8e8
	virtual float System.IConvertible.ToSingle(Single provider); // 16 - a0b7e99c
	virtual String ToString(String provider); // 17 - a0b8143c
	virtual mvar System.IConvertible.ToType(Object targetType, Object provider); // 18 - a0b7ea50
	virtual ushort System.IConvertible.ToUInt16(UInt16 provider); // 19 - a0b7ec04
	virtual uint System.IConvertible.ToUInt32(UInt32 provider); // 20 - a0b7ecb8
	virtual ulong System.IConvertible.ToUInt64(UInt64 provider); // 21 - a0b7ed6c
	virtual int CompareTo(mvar target); // 22 - a0b810e8
}
// Namespace: 
class PointParams
{
	// Fields
	uint vertices;
	FeatureKind typeId;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0d18a48
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0d18a60
	virtual String ToString(); // 3 - a0d18b28
}
// Namespace: NianticLabs.Platform
class FeatureKind
{
	// Fields
	int value__;
	static FeatureKind UNDEFINED = 0;
	static FeatureKind BASIN = 1;
	static FeatureKind CANAL = 2;
	static FeatureKind CEMETERY = 3;
	static FeatureKind CINEMA = 4;
	static FeatureKind COLLEGE = 5;
	static FeatureKind COMMERCIAL = 6;
	static FeatureKind COMMON = 7;
	static FeatureKind DAM = 8;
	static FeatureKind DITCH = 9;
	static FeatureKind DOCK = 10;
	static FeatureKind DRAIN = 11;
	static FeatureKind FARM = 12;
	static FeatureKind FARMLAND = 13;
	static FeatureKind FARMYARD = 14;
	static FeatureKind FOOTWAY = 15;
	static FeatureKind FOREST = 16;
	static FeatureKind GARDEN = 17;
	static FeatureKind GLACIER = 18;
	static FeatureKind GOLF_COURSE = 19;
	static FeatureKind GRASS = 20;
	static FeatureKind HIGHWAY = 21;
	static FeatureKind HOSPITAL = 22;
	static FeatureKind HOTEL = 23;
	static FeatureKind INDUSTRIAL = 24;
	static FeatureKind LAKE = 25;
	static FeatureKind LAND = 26;
	static FeatureKind LIBRARY = 27;
	static FeatureKind MAJOR_ROAD = 28;
	static FeatureKind MEADOW = 29;
	static FeatureKind MINOR_ROAD = 30;
	static FeatureKind NATURE_RESERVE = 31;
	static FeatureKind OCEAN = 32;
	static FeatureKind PARK = 33;
	static FeatureKind PARKING = 34;
	static FeatureKind PATH = 35;
	static FeatureKind PEDESTRIAN = 36;
	static FeatureKind PITCH = 37;
	static FeatureKind PLACE_OF_WORSHIP = 38;
	static FeatureKind PLAYA = 39;
	static FeatureKind PLAYGROUND = 40;
	static FeatureKind QUARRY = 41;
	static FeatureKind RAILWAY = 42;
	static FeatureKind RECREATION_AREA = 43;
	static FeatureKind RESERVOIR = 44;
	static FeatureKind RESIDENTIAL = 45;
	static FeatureKind RETAIL = 46;
	static FeatureKind RIVER = 47;
	static FeatureKind RIVERBANK = 48;
	static FeatureKind RUNWAY = 49;
	static FeatureKind SCHOOL = 50;
	static FeatureKind SPORTS_CENTER = 51;
	static FeatureKind STADIUM = 52;
	static FeatureKind STREAM = 53;
	static FeatureKind TAXIWAY = 54;
	static FeatureKind THEATRE = 55;
	static FeatureKind UNIVERSITY = 56;
	static FeatureKind URBAN_AREA = 57;
	static FeatureKind WATER = 58;
	static FeatureKind WETLAND = 59;
	static FeatureKind WOOD = 60;
	static FeatureKind DEBUG_TILE_OUTLINE = 61;
	static FeatureKind DEBUG_TILE_SURFACE = 62;
	static FeatureKind OTHER = 63;
	static FeatureKind ANY = 2000;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0b8202c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0b82044
	virtual String ToString(); // 3 - a0b81258
	virtual String ToString(String format, String provider); // 4 - a0b81ecc
	virtual TypeCode GetTypeCode(); // 5 - a0b7ee20
	virtual boolean System.IConvertible.ToBoolean(Boolean provider); // 6 - a0b7e270
	virtual byte System.IConvertible.ToByte(Byte provider); // 7 - a0b7e328
	virtual char System.IConvertible.ToChar(Char provider); // 8 - a0b7e3dc
	virtual DateTime System.IConvertible.ToDateTime(DateTime provider); // 9 - a0b7e490
	virtual Decimal System.IConvertible.ToDecimal(Decimal provider); // 10 - a0b7e554
	virtual double System.IConvertible.ToDouble(Double provider); // 11 - a0b7e618
	virtual short System.IConvertible.ToInt16(Int16 provider); // 12 - a0b7e6cc
	virtual int System.IConvertible.ToInt32(Int32 provider); // 13 - a0b7e780
	virtual long System.IConvertible.ToInt64(Int64 provider); // 14 - a0b7e834
	virtual sbyte System.IConvertible.ToSByte(SByte provider); // 15 - a0b7e8e8
	virtual float System.IConvertible.ToSingle(Single provider); // 16 - a0b7e99c
	virtual String ToString(String provider); // 17 - a0b8143c
	virtual mvar System.IConvertible.ToType(Object targetType, Object provider); // 18 - a0b7ea50
	virtual ushort System.IConvertible.ToUInt16(UInt16 provider); // 19 - a0b7ec04
	virtual uint System.IConvertible.ToUInt32(UInt32 provider); // 20 - a0b7ecb8
	virtual ulong System.IConvertible.ToUInt64(UInt64 provider); // 21 - a0b7ed6c
	virtual int CompareTo(mvar target); // 22 - a0b810e8
}
// Namespace: 
class LinearParams
{
	// Fields
	uint vertices;
	uint lineStrips;
	FeatureKind typeId;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0d18a48
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0d18a60
	virtual String ToString(); // 3 - a0d18b28
}
// Namespace: 
class MeshParams
{
	// Fields
	uint vertices;
	uint indices;
	FeatureKind typeId;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0d18a48
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0d18a60
	virtual String ToString(); // 3 - a0d18b28
}
// Namespace: 
class GmmBuildingParams
{
	// Fields
	uint vertices;
	uint indices;
	uint exterior_edges;
	FeatureKind typeId;
	float height;
	float base_height;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0d18a48
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0d18a60
	virtual String ToString(); // 3 - a0d18b28
}
// Namespace: 
class AreaParams
{
	// Fields
	uint vertices;
	uint indices;
	uint exterior_edges;
	FeatureKind typeId;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0d18a48
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0d18a60
	virtual String ToString(); // 3 - a0d18b28
}
// Namespace: NianticLabs.Platform
class N2EntryPoints
{
	// Fields
	N2NativeBindings n2;
	N2Api n2Api;

	// Methods
	void CheckResult(String api, String entrypoint, Void result); // a07ee4a4
	cmod_opt GetProc(uint funcPtr); // 0
	void LoadApiBindings(); // a07f4094
	void GetN2Api(Void api); // a07f49e4

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: 
class N2NativeBindings
{
	// Fields
	uint N2PluginFlushExtLogs;
	uint N2PluginGetDeviceCountryCode;
	uint N2PluginGetDeviceLanguageCode;
	uint N2PluginGetState;
	uint N2PluginOnNativeEvent;
	uint N2PluginOnPause;
	uint N2PluginOnResume;
	uint N2PluginOnStart;
	uint N2PluginOnStop;
	uint N2PluginOnUpdate;
	uint N2PluginSetExtLogLevel;
	uint N2PluginSetBackgroundMode;
	uint N2MapClearCache;
	uint N2MapGetCompassHeading;
	uint N2MapGetCurrentLocation;
	uint N2MapGetView;
	uint N2MapGetPosition;
	uint N2MapGetWorldLocation;
	uint N2MapS2CacheSetCellData;
	uint N2MapS2CacheUpdateVisibleCells;
	uint N2MapSetView;
	uint N2MapSetMode;
	uint N2MapSubscribeLayer;
	uint N2MapUpdateTiles;
	uint N2ServerClearAuthToken;
	uint N2ServerClearResponse;
	uint N2ServerGetResponsePayloads;
	uint N2ServerHasResponse;
	uint N2ServerProcessEvents;
	uint N2ServerProcessPendingRequests;
	uint N2ServerRefreshAuthToken;
	uint N2ServerResetAuthToken;
	uint N2ServerSend;
	uint N2ServerSetDesktopRcPath;
	uint N2ServerSetServer;
	uint N2AuthClearGoogleToken;
	uint N2AuthGetGoogleToken;
	uint N2AuthRefreshGoogleToken;
	uint N2S2GetLatLngFromPartialS2CellId;
	uint N2S2GetLatLng;
	uint N2IapGetIapState;
	uint N2IapGetPurchaseResult;
	uint N2IapGetSkusAndBalances;
	uint N2IapInitialize;
	uint N2IapProcessEvents;
	uint N2IapPurchaseItem;
	uint N2IapRefreshSkusAndBalances;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0d18a48
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0d18a60
	virtual String ToString(); // 3 - a0d18b28
}
// Namespace: 
class N2Api
{
	// Fields
	N2PluginFlushExtLogs_ N2PluginFlushExtLogs;
	N2PluginGetDeviceCountryCode_ N2PluginGetDeviceCountryCode;
	N2PluginGetDeviceLanguageCode_ N2PluginGetDeviceLanguageCode;
	N2PluginGetState_ N2PluginGetState;
	N2PluginOnNativeEvent_ N2PluginOnNativeEvent;
	N2PluginOnPause_ N2PluginOnPause;
	N2PluginOnResume_ N2PluginOnResume;
	N2PluginOnStart_ N2PluginOnStart;
	N2PluginOnStop_ N2PluginOnStop;
	N2PluginOnUpdate_ N2PluginOnUpdate;
	N2PluginSetExtLogLevel_ N2PluginSetExtLogLevel;
	N2PluginSetBackgroundMode_ N2PluginSetBackgroundMode;
	N2MapClearCache_ N2MapClearCache;
	N2MapGetCompassHeading_ N2MapGetCompassHeading;
	N2MapGetCurrentLocation_ N2MapGetCurrentLocation;
	N2MapGetView_ N2MapGetView;
	N2MapGetPosition_ N2MapGetPosition;
	N2MapGetWorldLocation_ N2MapGetWorldLocation;
	N2MapS2CacheSetCellData_ N2MapS2CacheSetCellData;
	N2MapS2CacheUpdateVisibleCells_ N2MapS2CacheUpdateVisibleCells;
	N2MapSetView_ N2MapSetView;
	N2MapSetMode_ N2MapSetMode;
	N2MapSubscribeLayer_ N2MapSubscribeLayer;
	N2MapUpdateTiles_ N2MapUpdateTiles;
	N2ServerClearAuthToken_ N2ServerClearAuthToken;
	N2ServerClearResponse_ N2ServerClearResponse;
	N2ServerGetResponsePayloads_ N2ServerGetResponsePayloads;
	N2ServerHasResponse_ N2ServerHasResponse;
	N2ServerProcessEvents_ N2ServerProcessEvents;
	N2ServerProcessPendingRequests_ N2ServerProcessPendingRequests;
	N2ServerRefreshAuthToken_ N2ServerRefreshAuthToken;
	N2ServerResetAuthToken_ N2ServerResetAuthToken;
	N2ServerSend_ N2ServerSend;
	N2ServerSetDesktopRcPath_ N2ServerSetDesktopRcPath;
	N2ServerSetServer_ N2ServerSetServer;
	N2AuthClearGoogleToken_ N2AuthClearGoogleToken;
	N2AuthGetGoogleToken_ N2AuthGetGoogleToken;
	N2AuthRefreshGoogleToken_ N2AuthRefreshGoogleToken;
	N2S2GetLatLngFromPartialS2CellId_ N2S2GetLatLngFromPartialS2CellId;
	N2S2GetLatLng_ N2S2GetLatLng;
	N2IapGetIapState_ N2IapGetIapState;
	N2IapGetPurchaseResult_ N2IapGetPurchaseResult;
	N2IapGetSkusAndBalances_ N2IapGetSkusAndBalances;
	N2IapInitialize_ N2IapInitialize;
	N2IapProcessEvents_ N2IapProcessEvents;
	N2IapPurchaseItem_ N2IapPurchaseItem;
	N2IapRefreshSkusAndBalances_ N2IapRefreshSkusAndBalances;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0d18a48
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0d18a60
	virtual String ToString(); // 3 - a0d18b28
}
// Namespace: 
class N2PluginFlushExtLogs_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f6cb8
	ApiError Invoke(ApiError logger_cb); // a07f6ccc
	IAsyncResult BeginInvoke(IAsyncResult logger_cb, IAsyncResult callback, mvar object); // a07f6dd8
	ApiError EndInvoke(ApiError result); // a07f6e04

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(ApiError logger_cb); // 12 - a07f6ccc
	virtual IAsyncResult BeginInvoke(IAsyncResult logger_cb, IAsyncResult callback, mvar object); // 13 - a07f6dd8
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f6e04
}
// Namespace: 
class ApiError
{
	// Fields
	int value__;
	static ApiError SUCCESS = 0;
	static ApiError PLUGIN_NOT_READY = 1;
	static ApiError NOT_SUPPORTED = 2;
	static ApiError NOT_IMPLEMENTED_YET = 3;
	static ApiError INTERNAL_ERROR = 4;
	static ApiError INVALID_PARAMETERS = 5;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0b8202c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0b82044
	virtual String ToString(); // 3 - a0b81258
	virtual String ToString(String format, String provider); // 4 - a0b81ecc
	virtual TypeCode GetTypeCode(); // 5 - a0b7ee20
	virtual boolean System.IConvertible.ToBoolean(Boolean provider); // 6 - a0b7e270
	virtual byte System.IConvertible.ToByte(Byte provider); // 7 - a0b7e328
	virtual char System.IConvertible.ToChar(Char provider); // 8 - a0b7e3dc
	virtual DateTime System.IConvertible.ToDateTime(DateTime provider); // 9 - a0b7e490
	virtual Decimal System.IConvertible.ToDecimal(Decimal provider); // 10 - a0b7e554
	virtual double System.IConvertible.ToDouble(Double provider); // 11 - a0b7e618
	virtual short System.IConvertible.ToInt16(Int16 provider); // 12 - a0b7e6cc
	virtual int System.IConvertible.ToInt32(Int32 provider); // 13 - a0b7e780
	virtual long System.IConvertible.ToInt64(Int64 provider); // 14 - a0b7e834
	virtual sbyte System.IConvertible.ToSByte(SByte provider); // 15 - a0b7e8e8
	virtual float System.IConvertible.ToSingle(Single provider); // 16 - a0b7e99c
	virtual String ToString(String provider); // 17 - a0b8143c
	virtual mvar System.IConvertible.ToType(Object targetType, Object provider); // 18 - a0b7ea50
	virtual ushort System.IConvertible.ToUInt16(UInt16 provider); // 19 - a0b7ec04
	virtual uint System.IConvertible.ToUInt32(UInt32 provider); // 20 - a0b7ecb8
	virtual ulong System.IConvertible.ToUInt64(UInt64 provider); // 21 - a0b7ed6c
	virtual int CompareTo(mvar target); // 22 - a0b810e8
}
// Namespace: 
class N2PluginGetDeviceCountryCode_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f6e30
	ApiError Invoke(uint str); // a07f6e44
	IAsyncResult BeginInvoke(uint str, IAsyncResult callback, mvar object); // a07f6f3c
	ApiError EndInvoke(uint str, ApiError result); // a07f6ff8

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(uint str); // 12 - a07f6e44
	virtual IAsyncResult BeginInvoke(uint str, IAsyncResult callback, mvar object); // 13 - a07f6f3c
	virtual ApiError EndInvoke(uint str, ApiError result); // 14 - a07f6ff8
}
// Namespace: 
class N2PluginGetDeviceLanguageCode_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f7030
	ApiError Invoke(uint str); // a07f7044
	IAsyncResult BeginInvoke(uint str, IAsyncResult callback, mvar object); // a07f713c
	ApiError EndInvoke(uint str, ApiError result); // a07f71f8

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(uint str); // 12 - a07f7044
	virtual IAsyncResult BeginInvoke(uint str, IAsyncResult callback, mvar object); // 13 - a07f713c
	virtual ApiError EndInvoke(uint str, ApiError result); // 14 - a07f71f8
}
// Namespace: 
class N2PluginGetState_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f7230
	ApiError Invoke(ApiError pluginState); // a07f7244
	IAsyncResult BeginInvoke(IAsyncResult pluginState, IAsyncResult callback, mvar object); // a07f7314
	ApiError EndInvoke(ApiError pluginState, ApiError result); // a07f73d0

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(ApiError pluginState); // 12 - a07f7244
	virtual IAsyncResult BeginInvoke(IAsyncResult pluginState, IAsyncResult callback, mvar object); // 13 - a07f7314
	virtual ApiError EndInvoke(ApiError pluginState, ApiError result); // 14 - a07f73d0
}
// Namespace: 
class N2PluginOnNativeEvent_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f7408
	ApiError Invoke(uint buffer, int bufferSize, ApiError eventType); // a07f741c
	IAsyncResult BeginInvoke(uint buffer, int bufferSize, IAsyncResult eventType, IAsyncResult callback, mvar object); // a07f7554
	ApiError EndInvoke(uint buffer, int bufferSize, ApiError eventType, ApiError result); // a07f764c

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(uint buffer, int bufferSize, ApiError eventType); // 12 - a07f741c
	virtual IAsyncResult BeginInvoke(uint buffer, int bufferSize, IAsyncResult eventType, IAsyncResult callback, mvar object); // 13 - a07f7554
	virtual ApiError EndInvoke(uint buffer, int bufferSize, ApiError eventType, ApiError result); // 14 - a07f764c
}
// Namespace: 
class N2PluginOnPause_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f7684
	ApiError Invoke(); // a07f7698
	IAsyncResult BeginInvoke(IAsyncResult callback, mvar object); // a07f7798
	ApiError EndInvoke(ApiError result); // a07f77c4

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(); // 12 - a07f7698
	virtual IAsyncResult BeginInvoke(IAsyncResult callback, mvar object); // 13 - a07f7798
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f77c4
}
// Namespace: 
class N2PluginOnResume_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f77f0
	ApiError Invoke(); // a07f7804
	IAsyncResult BeginInvoke(IAsyncResult callback, mvar object); // a07f7904
	ApiError EndInvoke(ApiError result); // a07f7930

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual IAsyncResult BeginInvoke(IAsyncResult callback, mvar object); // 13 - a07f7904
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f7930
}
// Namespace: 
class N2PluginOnStart_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f795c
	ApiError Invoke(); // a07f7970
	IAsyncResult BeginInvoke(IAsyncResult callback, mvar object); // a07f7a70
	ApiError EndInvoke(ApiError result); // a07f7a9c

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(); // 12 - a07f7970
	virtual IAsyncResult BeginInvoke(IAsyncResult callback, mvar object); // 13 - a07f7a70
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f7a9c
}
// Namespace: 
class N2PluginOnStop_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f7ac8
	ApiError Invoke(); // a07f7adc
	IAsyncResult BeginInvoke(IAsyncResult callback, mvar object); // a07f7bdc
	ApiError EndInvoke(ApiError result); // a07f7c08

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(); // 12 - a07f7adc
	virtual IAsyncResult BeginInvoke(IAsyncResult callback, mvar object); // 13 - a07f7bdc
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f7c08
}
// Namespace: 
class N2PluginOnUpdate_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f7c34
	ApiError Invoke(); // a07f7c48
	IAsyncResult BeginInvoke(IAsyncResult callback, mvar object); // a07f7d48
	ApiError EndInvoke(ApiError result); // a07f7d74

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(); // 12 - a07f7c48
	virtual IAsyncResult BeginInvoke(IAsyncResult callback, mvar object); // 13 - a07f7d48
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f7d74
}
// Namespace: 
class N2PluginSetExtLogLevel_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f7f6c
	ApiError Invoke(ApiError level); // a07f7f80
	IAsyncResult BeginInvoke(IAsyncResult level, IAsyncResult callback, mvar object); // a07f8050
	ApiError EndInvoke(ApiError result); // a07f810c

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(ApiError level); // 12 - a07f7f80
	virtual IAsyncResult BeginInvoke(IAsyncResult level, IAsyncResult callback, mvar object); // 13 - a07f8050
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f810c
}
// Namespace: 
class N2PluginSetBackgroundMode_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f7da0
	ApiError Invoke(int on); // a07f7db4
	IAsyncResult BeginInvoke(int on, IAsyncResult callback, mvar object); // a07f7e84
	ApiError EndInvoke(ApiError result); // a07f7f40

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(int on); // 12 - a07f7db4
	virtual IAsyncResult BeginInvoke(int on, IAsyncResult callback, mvar object); // 13 - a07f7e84
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f7f40
}
// Namespace: 
class N2MapClearCache_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f57d4
	ApiError Invoke(ApiError type); // a07efd1c
	IAsyncResult BeginInvoke(IAsyncResult type, IAsyncResult callback, mvar object); // a07f57f8
	ApiError EndInvoke(ApiError result); // a07f58b4

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(ApiError type); // 12 - a07efd1c
	virtual IAsyncResult BeginInvoke(IAsyncResult type, IAsyncResult callback, mvar object); // 13 - a07f57f8
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f58b4
}
// Namespace: 
class N2MapGetCompassHeading_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f58e0
	ApiError Invoke(ApiError heading); // a07f58f4
	IAsyncResult BeginInvoke(IAsyncResult heading, IAsyncResult callback, mvar object); // a07f59f0
	ApiError EndInvoke(ApiError heading, ApiError result); // a07f5aac

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(ApiError heading); // 12 - a07f58f4
	virtual IAsyncResult BeginInvoke(IAsyncResult heading, IAsyncResult callback, mvar object); // 13 - a07f59f0
	virtual ApiError EndInvoke(ApiError heading, ApiError result); // 14 - a07f5aac
}
// Namespace: 
class N2MapGetCurrentLocation_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f5ae4
	ApiError Invoke(ApiError location); // a07f0b84
	IAsyncResult BeginInvoke(IAsyncResult location, IAsyncResult callback, mvar object); // a07f5b54
	ApiError EndInvoke(ApiError location, ApiError result); // a07f5c10

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(ApiError location); // 12 - a07f0b84
	virtual IAsyncResult BeginInvoke(IAsyncResult location, IAsyncResult callback, mvar object); // 13 - a07f5b54
	virtual ApiError EndInvoke(ApiError location, ApiError result); // 14 - a07f5c10
}
// Namespace: 
class N2MapGetView_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f5ee0
	ApiError Invoke(ApiError view); // a07eff30
	IAsyncResult BeginInvoke(IAsyncResult view, IAsyncResult callback, mvar object); // a07f5f78
	ApiError EndInvoke(ApiError view, ApiError result); // a07f6034

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(ApiError view); // 12 - a07eff30
	virtual IAsyncResult BeginInvoke(IAsyncResult view, IAsyncResult callback, mvar object); // 13 - a07f5f78
	virtual ApiError EndInvoke(ApiError view, ApiError result); // 14 - a07f6034
}
// Namespace: 
class N2MapGetPosition_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f5c48
	ApiError Invoke(double lat, double lng, double alt, double posX, double posY, double posZ, ApiError up); // a07f0274
	IAsyncResult BeginInvoke(double lat, double lng, double alt, double posX, double posY, double posZ, IAsyncResult up, IAsyncResult callback, mvar object); // a07f5d44
	ApiError EndInvoke(double posX, double posY, double posZ, ApiError up, ApiError result); // a07f5ea4

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(double lat, double lng, double alt, double posX, double posY, double posZ, ApiError up); // 12 - a07f0274
	virtual IAsyncResult BeginInvoke(double lat, double lng, double alt, double posX, double posY, double posZ, IAsyncResult up, IAsyncResult callback, mvar object); // 13 - a07f5d44
	virtual ApiError EndInvoke(double posX, double posY, double posZ, ApiError up, ApiError result); // 14 - a07f5ea4
}
// Namespace: 
class N2MapGetWorldLocation_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f606c
	ApiError Invoke(double posX, double posY, double posZ, double lat, double lng, double alt); // a07f04a8
	IAsyncResult BeginInvoke(double posX, double posY, double posZ, double lat, double lng, double alt, IAsyncResult callback, mvar object); // a07f6118
	ApiError EndInvoke(double lat, double lng, double alt, ApiError result); // a07f6260

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(double posX, double posY, double posZ, double lat, double lng, double alt); // 12 - a07f04a8
	virtual IAsyncResult BeginInvoke(double posX, double posY, double posZ, double lat, double lng, double alt, IAsyncResult callback, mvar object); // 13 - a07f6118
	virtual ApiError EndInvoke(double lat, double lng, double alt, ApiError result); // 14 - a07f6260
}
// Namespace: 
class N2MapS2CacheSetCellData_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f6298
	ApiError Invoke(ulong s2cellid, int num_bytes, int is_leaf); // a07f116c
	IAsyncResult BeginInvoke(ulong s2cellid, int num_bytes, int is_leaf, IAsyncResult callback, mvar object); // a07f62d8
	ApiError EndInvoke(ApiError result); // a07f63d0

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(ulong s2cellid, int num_bytes, int is_leaf); // 12 - a07f116c
	virtual IAsyncResult BeginInvoke(ulong s2cellid, int num_bytes, int is_leaf, IAsyncResult callback, mvar object); // 13 - a07f62d8
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f63d0
}
// Namespace: 
class N2MapS2CacheUpdateVisibleCells_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f63fc
	ApiError Invoke(uint event_callback); // a07f0fc8
	IAsyncResult BeginInvoke(uint event_callback, IAsyncResult callback, mvar object); // a07f6420
	ApiError EndInvoke(ApiError result); // a07f64dc

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(uint event_callback); // 12 - a07f0fc8
	virtual IAsyncResult BeginInvoke(uint event_callback, IAsyncResult callback, mvar object); // 13 - a07f6420
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f64dc
}
// Namespace: 
class N2MapSetView_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f66d4
	ApiError Invoke(ApiError view); // a07f00b0
	IAsyncResult BeginInvoke(IAsyncResult view, IAsyncResult callback, mvar object); // a07f6778
	ApiError EndInvoke(ApiError view, ApiError result); // a07f6834

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(ApiError view); // 12 - a07f00b0
	virtual IAsyncResult BeginInvoke(IAsyncResult view, IAsyncResult callback, mvar object); // 13 - a07f6778
	virtual ApiError EndInvoke(ApiError view, ApiError result); // 14 - a07f6834
}
// Namespace: 
class N2MapSetMode_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f6508
	ApiError Invoke(ApiError mode); // a07f651c
	IAsyncResult BeginInvoke(IAsyncResult mode, IAsyncResult callback, mvar object); // a07f65ec
	ApiError EndInvoke(ApiError result); // a07f66a8

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(ApiError mode); // 12 - a07f651c
	virtual IAsyncResult BeginInvoke(IAsyncResult mode, IAsyncResult callback, mvar object); // 13 - a07f65ec
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f66a8
}
// Namespace: 
class N2MapSubscribeLayer_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f686c
	ApiError Invoke(ApiError layer); // a07f0698
	IAsyncResult BeginInvoke(IAsyncResult layer, IAsyncResult callback, mvar object); // a07f6890
	ApiError EndInvoke(ApiError result); // a07f694c

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(ApiError layer); // 12 - a07f0698
	virtual IAsyncResult BeginInvoke(IAsyncResult layer, IAsyncResult callback, mvar object); // 13 - a07f6890
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f694c
}
// Namespace: 
class N2MapUpdateTiles_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f6978
	ApiError Invoke(uint event_cb, uint vector3Alloc_cb, uint intAlloc_cb, uint dealloc_cb, int updatesLeft); // a07f0dbc
	IAsyncResult BeginInvoke(uint event_cb, uint vector3Alloc_cb, uint intAlloc_cb, uint dealloc_cb, int updatesLeft, IAsyncResult callback, mvar object); // a07f69dc
	ApiError EndInvoke(int updatesLeft, ApiError result); // a07f6b04

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(uint event_cb, uint vector3Alloc_cb, uint intAlloc_cb, uint dealloc_cb, int updatesLeft); // 12 - a07f0dbc
	virtual IAsyncResult BeginInvoke(uint event_cb, uint vector3Alloc_cb, uint intAlloc_cb, uint dealloc_cb, int updatesLeft, IAsyncResult callback, mvar object); // 13 - a07f69dc
	virtual ApiError EndInvoke(int updatesLeft, ApiError result); // 14 - a07f6b04
}
// Namespace: 
class N2ServerClearAuthToken_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f86b4
	ApiError Invoke(); // a07f86c8
	IAsyncResult BeginInvoke(IAsyncResult callback, mvar object); // a07f87c8
	ApiError EndInvoke(ApiError result); // a07f87f4

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(); // 12 - a07f86c8
	virtual IAsyncResult BeginInvoke(IAsyncResult callback, mvar object); // 13 - a07f87c8
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f87f4
}
// Namespace: 
class N2ServerClearResponse_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f8820
	ApiError Invoke(int rpcId, int result); // a07f8834
	IAsyncResult BeginInvoke(int rpcId, int result, IAsyncResult callback, mvar object); // a07f8958
	ApiError EndInvoke(int result, ApiError _result); // a07f8a24

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(int rpcId, int result); // 12 - a07f8834
	virtual IAsyncResult BeginInvoke(int rpcId, int result, IAsyncResult callback, mvar object); // 13 - a07f8958
	virtual ApiError EndInvoke(int result, ApiError _result); // 14 - a07f8a24
}
// Namespace: 
class N2ServerGetResponsePayloads_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f8a5c
	ApiError Invoke(int rpcId, cmod_reqd payloads, cmod_reqd payload_sizes, int result); // a07f8a70
	IAsyncResult BeginInvoke(int rpcId, cmod_reqd payloads, cmod_reqd payload_sizes, int result, IAsyncResult callback, mvar object); // a07f8be0
	ApiError EndInvoke(int result, ApiError _result); // a07f8cbc

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(int rpcId, cmod_reqd payloads, cmod_reqd payload_sizes, int result); // 12 - a07f8a70
	virtual IAsyncResult BeginInvoke(int rpcId, cmod_reqd payloads, cmod_reqd payload_sizes, int result, IAsyncResult callback, mvar object); // 13 - a07f8be0
	virtual ApiError EndInvoke(int result, ApiError _result); // 14 - a07f8cbc
}
// Namespace: 
class N2ServerHasResponse_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f8cf4
	ApiError Invoke(ApiError rpcStatus, int actionCount, int result); // a07f8d08
	IAsyncResult BeginInvoke(IAsyncResult rpcStatus, int actionCount, int result, IAsyncResult callback, mvar object); // a07f8e44
	ApiError EndInvoke(ApiError rpcStatus, int actionCount, int result, ApiError _result); // a07f8f30

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(ApiError rpcStatus, int actionCount, int result); // 12 - a07f8d08
	virtual IAsyncResult BeginInvoke(IAsyncResult rpcStatus, int actionCount, int result, IAsyncResult callback, mvar object); // 13 - a07f8e44
	virtual ApiError EndInvoke(ApiError rpcStatus, int actionCount, int result, ApiError _result); // 14 - a07f8f30
}
// Namespace: 
class N2ServerProcessEvents_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f8f68
	ApiError Invoke(uint event_cb, uint byteAlloc_cb, uint dealloc_cb, int updatesLeft); // a07f8f7c
	IAsyncResult BeginInvoke(uint event_cb, uint byteAlloc_cb, uint dealloc_cb, int updatesLeft, IAsyncResult callback, mvar object); // a07f90b8
	ApiError EndInvoke(int updatesLeft, ApiError result); // a07f91c4

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(uint event_cb, uint byteAlloc_cb, uint dealloc_cb, int updatesLeft); // 12 - a07f8f7c
	virtual IAsyncResult BeginInvoke(uint event_cb, uint byteAlloc_cb, uint dealloc_cb, int updatesLeft, IAsyncResult callback, mvar object); // 13 - a07f90b8
	virtual ApiError EndInvoke(int updatesLeft, ApiError result); // 14 - a07f91c4
}
// Namespace: 
class N2ServerProcessPendingRequests_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f91fc
	ApiError Invoke(); // a07f9210
	IAsyncResult BeginInvoke(IAsyncResult callback, mvar object); // a07f9310
	ApiError EndInvoke(ApiError result); // a07f933c

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(); // 12 - a07f9210
	virtual IAsyncResult BeginInvoke(IAsyncResult callback, mvar object); // 13 - a07f9310
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f933c
}
// Namespace: 
class N2ServerRefreshAuthToken_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f9368
	ApiError Invoke(String authId, cmod_reqd token, int tokenSize); // a07f937c
	IAsyncResult BeginInvoke(String authId, cmod_reqd token, int tokenSize, IAsyncResult callback, mvar object); // a07f9504
	ApiError EndInvoke(ApiError result); // a07f95cc

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(String authId, cmod_reqd token, int tokenSize); // 12 - a07f937c
	virtual IAsyncResult BeginInvoke(String authId, cmod_reqd token, int tokenSize, IAsyncResult callback, mvar object); // 13 - a07f9504
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f95cc
}
// Namespace: 
class N2ServerResetAuthToken_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f95f8
	ApiError Invoke(String authId, cmod_reqd token, int tokenSize); // a07f960c
	IAsyncResult BeginInvoke(String authId, cmod_reqd token, int tokenSize, IAsyncResult callback, mvar object); // a07f9794
	ApiError EndInvoke(ApiError result); // a07f985c

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(String authId, cmod_reqd token, int tokenSize); // 12 - a07f960c
	virtual IAsyncResult BeginInvoke(String authId, cmod_reqd token, int tokenSize, IAsyncResult callback, mvar object); // 13 - a07f9794
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f985c
}
// Namespace: 
class N2ServerSend_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f9888
	ApiError Invoke(int timeoutMs, int retryDelayMs, int count, cmod_reqd methods, uint bodies, cmod_reqd sizes, int result); // a07f989c
	IAsyncResult BeginInvoke(int timeoutMs, int retryDelayMs, int count, cmod_reqd methods, uint bodies, cmod_reqd sizes, int result, IAsyncResult callback, mvar object); // a07f9a68
	ApiError EndInvoke(int result, ApiError _result); // a07f9b90

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(int timeoutMs, int retryDelayMs, int count, cmod_reqd methods, uint bodies, cmod_reqd sizes, int result); // 12 - a07f989c
	virtual IAsyncResult BeginInvoke(int timeoutMs, int retryDelayMs, int count, cmod_reqd methods, uint bodies, cmod_reqd sizes, int result, IAsyncResult callback, mvar object); // 13 - a07f9a68
	virtual ApiError EndInvoke(int result, ApiError _result); // 14 - a07f9b90
}
// Namespace: 
class N2ServerSetDesktopRcPath_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f9bc8
	ApiError Invoke(String path); // a07f9bdc
	IAsyncResult BeginInvoke(String path, IAsyncResult callback, mvar object); // a07f9cf8
	ApiError EndInvoke(ApiError result); // a07f9d24

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(String path); // 12 - a07f9bdc
	virtual IAsyncResult BeginInvoke(String path, IAsyncResult callback, mvar object); // 13 - a07f9cf8
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f9d24
}
// Namespace: 
class N2ServerSetServer_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f9d50
	ApiError Invoke(String host_port); // a07f9d64
	IAsyncResult BeginInvoke(String host_port, IAsyncResult callback, mvar object); // a07f9e80
	ApiError EndInvoke(ApiError result); // a07f9eac

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(String host_port); // 12 - a07f9d64
	virtual IAsyncResult BeginInvoke(String host_port, IAsyncResult callback, mvar object); // 13 - a07f9e80
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f9eac
}
// Namespace: 
class N2AuthClearGoogleToken_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f4c78
	ApiError Invoke(); // a07f4c8c
	IAsyncResult BeginInvoke(IAsyncResult callback, mvar object); // a07f4d8c
	ApiError EndInvoke(ApiError result); // a07f4db8

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(); // 12 - a07f4c8c
	virtual IAsyncResult BeginInvoke(IAsyncResult callback, mvar object); // 13 - a07f4d8c
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f4db8
}
// Namespace: 
class N2AuthGetGoogleToken_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f4de4
	ApiError Invoke(String clientId, String clientSecret); // a07f4df8
	IAsyncResult BeginInvoke(String clientId, String clientSecret, IAsyncResult callback, mvar object); // a07f4f58
	ApiError EndInvoke(ApiError result); // a07f4f90

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(String clientId, String clientSecret); // 12 - a07f4df8
	virtual IAsyncResult BeginInvoke(String clientId, String clientSecret, IAsyncResult callback, mvar object); // 13 - a07f4f58
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f4f90
}
// Namespace: 
class N2AuthRefreshGoogleToken_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f4fbc
	ApiError Invoke(String clientId, String clientSecret); // a07f4fd0
	IAsyncResult BeginInvoke(String clientId, String clientSecret, IAsyncResult callback, mvar object); // a07f5130
	ApiError EndInvoke(ApiError result); // a07f5168

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(String clientId, String clientSecret); // 12 - a07f4fd0
	virtual IAsyncResult BeginInvoke(String clientId, String clientSecret, IAsyncResult callback, mvar object); // 13 - a07f5130
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f5168
}
// Namespace: 
class N2S2GetLatLngFromPartialS2CellId_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f83d8
	ApiError Invoke(ulong parent_s2cellid, uint partial_s2cellid, double lat, double lng); // a07f83ec
	IAsyncResult BeginInvoke(ulong parent_s2cellid, uint partial_s2cellid, double lat, double lng, IAsyncResult callback, mvar object); // a07f8568
	ApiError EndInvoke(double lat, double lng, ApiError result); // a07f8680

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(ulong parent_s2cellid, uint partial_s2cellid, double lat, double lng); // 12 - a07f83ec
	virtual IAsyncResult BeginInvoke(ulong parent_s2cellid, uint partial_s2cellid, double lat, double lng, IAsyncResult callback, mvar object); // 13 - a07f8568
	virtual ApiError EndInvoke(double lat, double lng, ApiError result); // 14 - a07f8680
}
// Namespace: 
class N2S2GetLatLng_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f8138
	ApiError Invoke(ulong s2cellid, double lat, double lng); // a07f814c
	IAsyncResult BeginInvoke(ulong s2cellid, double lat, double lng, IAsyncResult callback, mvar object); // a07f82b0
	ApiError EndInvoke(double lat, double lng, ApiError result); // a07f83a4

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(ulong s2cellid, double lat, double lng); // 12 - a07f814c
	virtual IAsyncResult BeginInvoke(ulong s2cellid, double lat, double lng, IAsyncResult callback, mvar object); // 13 - a07f82b0
	virtual ApiError EndInvoke(double lat, double lng, ApiError result); // 14 - a07f83a4
}
// Namespace: 
class N2IapGetIapState_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f5194
	ApiError Invoke(ApiError iapState); // a07ed3b4
	IAsyncResult BeginInvoke(IAsyncResult iapState, IAsyncResult callback, mvar object); // a07f51b8
	ApiError EndInvoke(ApiError iapState, ApiError result); // a07f5274

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(ApiError iapState); // 12 - a07ed3b4
	virtual IAsyncResult BeginInvoke(IAsyncResult iapState, IAsyncResult callback, mvar object); // 13 - a07f51b8
	virtual ApiError EndInvoke(ApiError iapState, ApiError result); // 14 - a07f5274
}
// Namespace: 
class N2IapGetPurchaseResult_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f52ac
	ApiError Invoke(ApiError purchaseResult); // a07ed570
	IAsyncResult BeginInvoke(IAsyncResult purchaseResult, IAsyncResult callback, mvar object); // a07f52d0
	ApiError EndInvoke(ApiError purchaseResult, ApiError result); // a07f538c

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(ApiError purchaseResult); // 12 - a07ed570
	virtual IAsyncResult BeginInvoke(IAsyncResult purchaseResult, IAsyncResult callback, mvar object); // 13 - a07f52d0
	virtual ApiError EndInvoke(ApiError purchaseResult, ApiError result); // 14 - a07f538c
}
// Namespace: 
class N2IapGetSkusAndBalances_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f53c4
	ApiError Invoke(ApiError storeItemCb, ApiError balanceCb, ApiError priceCb, ApiError currencyGrantedCb, ApiError presentationCb, ApiError itemQuantityCb); // a07edf78
	IAsyncResult BeginInvoke(IAsyncResult storeItemCb, IAsyncResult balanceCb, IAsyncResult priceCb, IAsyncResult currencyGrantedCb, IAsyncResult presentationCb, IAsyncResult itemQuantityCb, IAsyncResult callback, mvar object); // a07f545c
	ApiError EndInvoke(ApiError result); // a07f54ac

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(ApiError storeItemCb, ApiError balanceCb, ApiError priceCb, ApiError currencyGrantedCb, ApiError presentationCb, ApiError itemQuantityCb); // 12 - a07edf78
	virtual IAsyncResult BeginInvoke(IAsyncResult storeItemCb, IAsyncResult balanceCb, IAsyncResult priceCb, IAsyncResult currencyGrantedCb, IAsyncResult presentationCb, IAsyncResult itemQuantityCb, IAsyncResult callback, mvar object); // 13 - a07f545c
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f54ac
}
// Namespace: 
class N2IapInitialize_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f54d8
	ApiError Invoke(); // a07ee1cc
	IAsyncResult BeginInvoke(IAsyncResult callback, mvar object); // a07f54f8
	ApiError EndInvoke(ApiError result); // a07f5524

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(); // 12 - a07ee1cc
	virtual IAsyncResult BeginInvoke(IAsyncResult callback, mvar object); // 13 - a07f54f8
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f5524
}
// Namespace: 
class N2IapProcessEvents_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f5550
	ApiError Invoke(uint event_cb, int updatesLeft); // a07ec394
	IAsyncResult BeginInvoke(uint event_cb, int updatesLeft, IAsyncResult callback, mvar object); // a07f55a4
	ApiError EndInvoke(int updatesLeft, ApiError result); // a07f5684

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(uint event_cb, int updatesLeft); // 12 - a07ec394
	virtual IAsyncResult BeginInvoke(uint event_cb, int updatesLeft, IAsyncResult callback, mvar object); // 13 - a07f55a4
	virtual ApiError EndInvoke(int updatesLeft, ApiError result); // 14 - a07f5684
}
// Namespace: 
class N2IapPurchaseItem_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f56bc
	ApiError Invoke(String itemId); // a07ee3bc
	IAsyncResult BeginInvoke(String itemId, IAsyncResult callback, mvar object); // a07f5704
	ApiError EndInvoke(ApiError result); // a07f5730

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(String itemId); // 12 - a07ee3bc
	virtual IAsyncResult BeginInvoke(String itemId, IAsyncResult callback, mvar object); // 13 - a07f5704
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f5730
}
// Namespace: 
class N2IapRefreshSkusAndBalances_
{

	// Methods
	void .ctor(mvar object, uint method); // a07f575c
	ApiError Invoke(); // a07ed724
	IAsyncResult BeginInvoke(IAsyncResult callback, mvar object); // a07f577c
	ApiError EndInvoke(ApiError result); // a07f57a8

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual ApiError Invoke(); // 12 - a07ed724
	virtual IAsyncResult BeginInvoke(IAsyncResult callback, mvar object); // 13 - a07f577c
	virtual ApiError EndInvoke(ApiError result); // 14 - a07f57a8
}
// Namespace: 
class NativeLogDelegateType
{

	// Methods
	void .ctor(mvar object, uint method); // a07fa230
	void Invoke(Void level, uint str); // a07fa244
	IAsyncResult BeginInvoke(IAsyncResult level, uint str, IAsyncResult callback, mvar object); // a07fa33c
	void EndInvoke(Void result); // a07fa41c

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual void Invoke(Void level, uint str); // 12 - a07fa244
	virtual IAsyncResult BeginInvoke(IAsyncResult level, uint str, IAsyncResult callback, mvar object); // 13 - a07fa33c
	virtual void EndInvoke(Void result); // 14 - a07fa41c
}
// Namespace: 
class NativeStoreItemDelegateType
{

	// Methods
	void .ctor(mvar object, uint method); // a07fa5d4
	void Invoke(uint storeItem); // a07fa5e8
	IAsyncResult BeginInvoke(uint storeItem, IAsyncResult callback, mvar object); // a07fa6b8
	void EndInvoke(Void result); // a07fa774

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual void Invoke(uint storeItem); // 12 - a07fa5e8
	virtual IAsyncResult BeginInvoke(uint storeItem, IAsyncResult callback, mvar object); // 13 - a07fa6b8
	virtual void EndInvoke(Void result); // 14 - a07fa774
}
// Namespace: 
class NativeBalanceDelegateType
{

	// Methods
	void .ctor(mvar object, uint method); // a07f9ed8
	void Invoke(uint currencyQuantity); // a07f9eec
	IAsyncResult BeginInvoke(uint currencyQuantity, IAsyncResult callback, mvar object); // a07f9fbc
	void EndInvoke(Void result); // a07fa078

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual void Invoke(uint currencyQuantity); // 12 - a07f9eec
	virtual IAsyncResult BeginInvoke(uint currencyQuantity, IAsyncResult callback, mvar object); // 13 - a07f9fbc
	virtual void EndInvoke(Void result); // 14 - a07fa078
}
// Namespace: 
class NativePresentationDataDelegateType
{

	// Methods
	void .ctor(mvar object, uint method); // a07fa428
	void Invoke(uint keyValuePair); // a07fa43c
	IAsyncResult BeginInvoke(uint keyValuePair, IAsyncResult callback, mvar object); // a07fa50c
	void EndInvoke(Void result); // a07fa5c8

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual void Invoke(uint keyValuePair); // 12 - a07fa43c
	virtual IAsyncResult BeginInvoke(uint keyValuePair, IAsyncResult callback, mvar object); // 13 - a07fa50c
	virtual void EndInvoke(Void result); // 14 - a07fa5c8
}
// Namespace: 
class NativeItemQuantityDelegateType
{

	// Methods
	void .ctor(mvar object, uint method); // a07fa084
	void Invoke(uint itemQuantity); // a07fa098
	IAsyncResult BeginInvoke(uint itemQuantity, IAsyncResult callback, mvar object); // a07fa168
	void EndInvoke(Void result); // a07fa224

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual void Invoke(uint itemQuantity); // 12 - a07fa098
	virtual IAsyncResult BeginInvoke(uint itemQuantity, IAsyncResult callback, mvar object); // 13 - a07fa168
	virtual void EndInvoke(Void result); // 14 - a07fa224
}
// Namespace: NianticLabs.Platform
class NativeEventDispatcher
{
	// Fields
	Generic handlers;
	Generic protoParsers;
	Thread workerThread;
	Generic <>f__mg$cache0;
	Generic <>f__mg$cache1;
	Generic <>f__mg$cache2;
	Generic <>f__mg$cache3;
	Generic <>f__mg$cache4;
	Generic <>f__mg$cache5;
	Generic <>f__mg$cache6;
	Generic <>f__mg$cache7;

	// Methods
	void .ctor(); // a07fa780
	void Start(); // a07fab14
	void Stop(); // a07fae1c
	void AddListener(Void eventType, Generic handler); // a07fb128
	void RemoveListener(Void eventType, Generic handler); // a07fb3a4
	void RegisterParsers(); // a07fa8c8
	void RegisterEventHandlers(); // a07fab40
	void UnregisterEventHandlers(); // a07fae4c
	void DispatchEvents(); // a07fb620

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: NianticLabs.Platform
class MapMode
{
	// Fields
	int value__;
	static MapMode UNDEFINED = 0;
	static MapMode SPHERICAL = 1;
	static MapMode MERCATOR = 2;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0b8202c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0b82044
	virtual String ToString(); // 3 - a0b81258
	virtual String ToString(String format, String provider); // 4 - a0b81ecc
	virtual TypeCode GetTypeCode(); // 5 - a0b7ee20
	virtual boolean System.IConvertible.ToBoolean(Boolean provider); // 6 - a0b7e270
	virtual byte System.IConvertible.ToByte(Byte provider); // 7 - a0b7e328
	virtual char System.IConvertible.ToChar(Char provider); // 8 - a0b7e3dc
	virtual DateTime System.IConvertible.ToDateTime(DateTime provider); // 9 - a0b7e490
	virtual Decimal System.IConvertible.ToDecimal(Decimal provider); // 10 - a0b7e554
	virtual double System.IConvertible.ToDouble(Double provider); // 11 - a0b7e618
	virtual short System.IConvertible.ToInt16(Int16 provider); // 12 - a0b7e6cc
	virtual int System.IConvertible.ToInt32(Int32 provider); // 13 - a0b7e780
	virtual long System.IConvertible.ToInt64(Int64 provider); // 14 - a0b7e834
	virtual sbyte System.IConvertible.ToSByte(SByte provider); // 15 - a0b7e8e8
	virtual float System.IConvertible.ToSingle(Single provider); // 16 - a0b7e99c
	virtual String ToString(String provider); // 17 - a0b8143c
	virtual mvar System.IConvertible.ToType(Object targetType, Object provider); // 18 - a0b7ea50
	virtual ushort System.IConvertible.ToUInt16(UInt16 provider); // 19 - a0b7ec04
	virtual uint System.IConvertible.ToUInt32(UInt32 provider); // 20 - a0b7ecb8
	virtual ulong System.IConvertible.ToUInt64(UInt64 provider); // 21 - a0b7ed6c
	virtual int CompareTo(mvar target); // 22 - a0b810e8
}
// Namespace: NianticLabs.Platform
class CacheType
{
	// Fields
	int value__;
	static CacheType UNDEFINED = 0;
	static CacheType MEMORY = 1;
	static CacheType DISK = 2;
	static CacheType SPATIAL_INDEX = 3;
	static CacheType MAP = 4;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0b8202c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0b82044
	virtual String ToString(); // 3 - a0b81258
	virtual String ToString(String format, String provider); // 4 - a0b81ecc
	virtual TypeCode GetTypeCode(); // 5 - a0b7ee20
	virtual boolean System.IConvertible.ToBoolean(Boolean provider); // 6 - a0b7e270
	virtual byte System.IConvertible.ToByte(Byte provider); // 7 - a0b7e328
	virtual char System.IConvertible.ToChar(Char provider); // 8 - a0b7e3dc
	virtual DateTime System.IConvertible.ToDateTime(DateTime provider); // 9 - a0b7e490
	virtual Decimal System.IConvertible.ToDecimal(Decimal provider); // 10 - a0b7e554
	virtual double System.IConvertible.ToDouble(Double provider); // 11 - a0b7e618
	virtual short System.IConvertible.ToInt16(Int16 provider); // 12 - a0b7e6cc
	virtual int System.IConvertible.ToInt32(Int32 provider); // 13 - a0b7e780
	virtual long System.IConvertible.ToInt64(Int64 provider); // 14 - a0b7e834
	virtual sbyte System.IConvertible.ToSByte(SByte provider); // 15 - a0b7e8e8
	virtual float System.IConvertible.ToSingle(Single provider); // 16 - a0b7e99c
	virtual String ToString(String provider); // 17 - a0b8143c
	virtual mvar System.IConvertible.ToType(Object targetType, Object provider); // 18 - a0b7ea50
	virtual ushort System.IConvertible.ToUInt16(UInt16 provider); // 19 - a0b7ec04
	virtual uint System.IConvertible.ToUInt32(UInt32 provider); // 20 - a0b7ecb8
	virtual ulong System.IConvertible.ToUInt64(UInt64 provider); // 21 - a0b7ed6c
	virtual int CompareTo(mvar target); // 22 - a0b810e8
}
// Namespace: NianticLabs.Platform
class ChannelAuthEvent
{
	// Fields
	int value__;
	static ChannelAuthEvent UNDEFINED = 0;
	static ChannelAuthEvent TOKEN_REQUEST_FAILED = 1;
	static ChannelAuthEvent REFRESH_REQUESTED = 2;
	static ChannelAuthEvent PROACTIVE_REFRESH_REQUESTED = 3;
	static ChannelAuthEvent GOT_NIANTIC_TOKEN = 4;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0b8202c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0b82044
	virtual String ToString(); // 3 - a0b81258
	virtual String ToString(String format, String provider); // 4 - a0b81ecc
	virtual TypeCode GetTypeCode(); // 5 - a0b7ee20
	virtual boolean System.IConvertible.ToBoolean(Boolean provider); // 6 - a0b7e270
	virtual byte System.IConvertible.ToByte(Byte provider); // 7 - a0b7e328
	virtual char System.IConvertible.ToChar(Char provider); // 8 - a0b7e3dc
	virtual DateTime System.IConvertible.ToDateTime(DateTime provider); // 9 - a0b7e490
	virtual Decimal System.IConvertible.ToDecimal(Decimal provider); // 10 - a0b7e554
	virtual double System.IConvertible.ToDouble(Double provider); // 11 - a0b7e618
	virtual short System.IConvertible.ToInt16(Int16 provider); // 12 - a0b7e6cc
	virtual int System.IConvertible.ToInt32(Int32 provider); // 13 - a0b7e780
	virtual long System.IConvertible.ToInt64(Int64 provider); // 14 - a0b7e834
	virtual sbyte System.IConvertible.ToSByte(SByte provider); // 15 - a0b7e8e8
	virtual float System.IConvertible.ToSingle(Single provider); // 16 - a0b7e99c
	virtual String ToString(String provider); // 17 - a0b8143c
	virtual mvar System.IConvertible.ToType(Object targetType, Object provider); // 18 - a0b7ea50
	virtual ushort System.IConvertible.ToUInt16(UInt16 provider); // 19 - a0b7ec04
	virtual uint System.IConvertible.ToUInt32(UInt32 provider); // 20 - a0b7ecb8
	virtual ulong System.IConvertible.ToUInt64(UInt64 provider); // 21 - a0b7ed6c
	virtual int CompareTo(mvar target); // 22 - a0b810e8
}
// Namespace: NianticLabs.Platform
class RpcStatus
{
	// Fields
	int value__;
	static RpcStatus UNDEFINED = 0;
	static RpcStatus SUCCESS = 1;
	static RpcStatus BAD_RESPONSE = 2;
	static RpcStatus ACTION_ERROR = 3;
	static RpcStatus DISPATCH_ERROR = 4;
	static RpcStatus SERVER_ERROR = 5;
	static RpcStatus ASSIGNMENT_ERROR = 6;
	static RpcStatus PROTOCOL_ERROR = 7;
	static RpcStatus AUTHENTICATION_ERROR = 8;
	static RpcStatus CANCELLED_REQUEST = 9;
	static RpcStatus UNKNOWN_ERROR = 10;
	static RpcStatus NO_RETRIES_ERROR = 11;
	static RpcStatus UNAUTHORIZED_ERROR = 12;
	static RpcStatus PARSING_ERROR = 13;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0b8202c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0b82044
	virtual String ToString(); // 3 - a0b81258
	virtual String ToString(String format, String provider); // 4 - a0b81ecc
	virtual TypeCode GetTypeCode(); // 5 - a0b7ee20
	virtual boolean System.IConvertible.ToBoolean(Boolean provider); // 6 - a0b7e270
	virtual byte System.IConvertible.ToByte(Byte provider); // 7 - a0b7e328
	virtual char System.IConvertible.ToChar(Char provider); // 8 - a0b7e3dc
	virtual DateTime System.IConvertible.ToDateTime(DateTime provider); // 9 - a0b7e490
	virtual Decimal System.IConvertible.ToDecimal(Decimal provider); // 10 - a0b7e554
	virtual double System.IConvertible.ToDouble(Double provider); // 11 - a0b7e618
	virtual short System.IConvertible.ToInt16(Int16 provider); // 12 - a0b7e6cc
	virtual int System.IConvertible.ToInt32(Int32 provider); // 13 - a0b7e780
	virtual long System.IConvertible.ToInt64(Int64 provider); // 14 - a0b7e834
	virtual sbyte System.IConvertible.ToSByte(SByte provider); // 15 - a0b7e8e8
	virtual float System.IConvertible.ToSingle(Single provider); // 16 - a0b7e99c
	virtual String ToString(String provider); // 17 - a0b8143c
	virtual mvar System.IConvertible.ToType(Object targetType, Object provider); // 18 - a0b7ea50
	virtual ushort System.IConvertible.ToUInt16(UInt16 provider); // 19 - a0b7ec04
	virtual uint System.IConvertible.ToUInt32(UInt32 provider); // 20 - a0b7ecb8
	virtual ulong System.IConvertible.ToUInt64(UInt64 provider); // 21 - a0b7ed6c
	virtual int CompareTo(mvar target); // 22 - a0b810e8
}
// Namespace: NianticLabs.Platform
class LocationStatus
{
	// Fields
	int value__;
	static LocationStatus UNDEFINED = 0;
	static LocationStatus STOPPED = 1;
	static LocationStatus INITIALIZED = 2;
	static LocationStatus RUNNING = 3;
	static LocationStatus FAILED = 4;
	static LocationStatus PERMISSION_DENIED = 5;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0b8202c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0b82044
	virtual String ToString(); // 3 - a0b81258
	virtual String ToString(String format, String provider); // 4 - a0b81ecc
	virtual TypeCode GetTypeCode(); // 5 - a0b7ee20
	virtual boolean System.IConvertible.ToBoolean(Boolean provider); // 6 - a0b7e270
	virtual byte System.IConvertible.ToByte(Byte provider); // 7 - a0b7e328
	virtual char System.IConvertible.ToChar(Char provider); // 8 - a0b7e3dc
	virtual DateTime System.IConvertible.ToDateTime(DateTime provider); // 9 - a0b7e490
	virtual Decimal System.IConvertible.ToDecimal(Decimal provider); // 10 - a0b7e554
	virtual double System.IConvertible.ToDouble(Double provider); // 11 - a0b7e618
	virtual short System.IConvertible.ToInt16(Int16 provider); // 12 - a0b7e6cc
	virtual int System.IConvertible.ToInt32(Int32 provider); // 13 - a0b7e780
	virtual long System.IConvertible.ToInt64(Int64 provider); // 14 - a0b7e834
	virtual sbyte System.IConvertible.ToSByte(SByte provider); // 15 - a0b7e8e8
	virtual float System.IConvertible.ToSingle(Single provider); // 16 - a0b7e99c
	virtual String ToString(String provider); // 17 - a0b8143c
	virtual mvar System.IConvertible.ToType(Object targetType, Object provider); // 18 - a0b7ea50
	virtual ushort System.IConvertible.ToUInt16(UInt16 provider); // 19 - a0b7ec04
	virtual uint System.IConvertible.ToUInt32(UInt32 provider); // 20 - a0b7ecb8
	virtual ulong System.IConvertible.ToUInt64(UInt64 provider); // 21 - a0b7ed6c
	virtual int CompareTo(mvar target); // 22 - a0b810e8
}
// Namespace: NianticLabs.Platform
class LocationType
{
	// Fields
	int value__;
	static LocationType UNDEFINED = 0;
	static LocationType MEASURED = 1;
	static LocationType COMPUTED = 2;
	static LocationType INTERPOLATED = 3;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0b8202c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0b82044
	virtual String ToString(); // 3 - a0b81258
	virtual String ToString(String format, String provider); // 4 - a0b81ecc
	virtual TypeCode GetTypeCode(); // 5 - a0b7ee20
	virtual boolean System.IConvertible.ToBoolean(Boolean provider); // 6 - a0b7e270
	virtual byte System.IConvertible.ToByte(Byte provider); // 7 - a0b7e328
	virtual char System.IConvertible.ToChar(Char provider); // 8 - a0b7e3dc
	virtual DateTime System.IConvertible.ToDateTime(DateTime provider); // 9 - a0b7e490
	virtual Decimal System.IConvertible.ToDecimal(Decimal provider); // 10 - a0b7e554
	virtual double System.IConvertible.ToDouble(Double provider); // 11 - a0b7e618
	virtual short System.IConvertible.ToInt16(Int16 provider); // 12 - a0b7e6cc
	virtual int System.IConvertible.ToInt32(Int32 provider); // 13 - a0b7e780
	virtual long System.IConvertible.ToInt64(Int64 provider); // 14 - a0b7e834
	virtual sbyte System.IConvertible.ToSByte(SByte provider); // 15 - a0b7e8e8
	virtual float System.IConvertible.ToSingle(Single provider); // 16 - a0b7e99c
	virtual String ToString(String provider); // 17 - a0b8143c
	virtual mvar System.IConvertible.ToType(Object targetType, Object provider); // 18 - a0b7ea50
	virtual ushort System.IConvertible.ToUInt16(UInt16 provider); // 19 - a0b7ec04
	virtual uint System.IConvertible.ToUInt32(UInt32 provider); // 20 - a0b7ecb8
	virtual ulong System.IConvertible.ToUInt64(UInt64 provider); // 21 - a0b7ed6c
	virtual int CompareTo(mvar target); // 22 - a0b810e8
}
// Namespace: NianticLabs.Platform
class IapState
{
	// Fields
	int value__;
	static IapState UNDEFINED = 0;
	static IapState INITIALIZING = 1;
	static IapState TRANSACTION_IN_PROGRESS = 2;
	static IapState READY = 3;
	static IapState REFRESHING_STORE_STATE = 4;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0b8202c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0b82044
	virtual String ToString(); // 3 - a0b81258
	virtual String ToString(String format, String provider); // 4 - a0b81ecc
	virtual TypeCode GetTypeCode(); // 5 - a0b7ee20
	virtual boolean System.IConvertible.ToBoolean(Boolean provider); // 6 - a0b7e270
	virtual byte System.IConvertible.ToByte(Byte provider); // 7 - a0b7e328
	virtual char System.IConvertible.ToChar(Char provider); // 8 - a0b7e3dc
	virtual DateTime System.IConvertible.ToDateTime(DateTime provider); // 9 - a0b7e490
	virtual Decimal System.IConvertible.ToDecimal(Decimal provider); // 10 - a0b7e554
	virtual double System.IConvertible.ToDouble(Double provider); // 11 - a0b7e618
	virtual short System.IConvertible.ToInt16(Int16 provider); // 12 - a0b7e6cc
	virtual int System.IConvertible.ToInt32(Int32 provider); // 13 - a0b7e780
	virtual long System.IConvertible.ToInt64(Int64 provider); // 14 - a0b7e834
	virtual sbyte System.IConvertible.ToSByte(SByte provider); // 15 - a0b7e8e8
	virtual float System.IConvertible.ToSingle(Single provider); // 16 - a0b7e99c
	virtual String ToString(String provider); // 17 - a0b8143c
	virtual mvar System.IConvertible.ToType(Object targetType, Object provider); // 18 - a0b7ea50
	virtual ushort System.IConvertible.ToUInt16(UInt16 provider); // 19 - a0b7ec04
	virtual uint System.IConvertible.ToUInt32(UInt32 provider); // 20 - a0b7ecb8
	virtual ulong System.IConvertible.ToUInt64(UInt64 provider); // 21 - a0b7ed6c
	virtual int CompareTo(mvar target); // 22 - a0b810e8
}
// Namespace: NianticLabs.Platform
class PurchaseResult
{
	// Fields
	int value__;
	static PurchaseResult UNDEFINED = 0;
	static PurchaseResult NO_PURCHASE = 1;
	static PurchaseResult FAILURE = 2;
	static PurchaseResult BALANCE_TOO_LOW = 3;
	static PurchaseResult SKU_NOT_AVAILABLE = 4;
	static PurchaseResult IN_PROGRESS = 5;
	static PurchaseResult SUCCESS = 6;
	static PurchaseResult PURCHASE_DEFERRED = 7;
	static PurchaseResult USER_CANCELLED = 8;
	static PurchaseResult BILLING_UNAVAILABLE = 9;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0b8202c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0b82044
	virtual String ToString(); // 3 - a0b81258
	virtual String ToString(String format, String provider); // 4 - a0b81ecc
	virtual TypeCode GetTypeCode(); // 5 - a0b7ee20
	virtual boolean System.IConvertible.ToBoolean(Boolean provider); // 6 - a0b7e270
	virtual byte System.IConvertible.ToByte(Byte provider); // 7 - a0b7e328
	virtual char System.IConvertible.ToChar(Char provider); // 8 - a0b7e3dc
	virtual DateTime System.IConvertible.ToDateTime(DateTime provider); // 9 - a0b7e490
	virtual Decimal System.IConvertible.ToDecimal(Decimal provider); // 10 - a0b7e554
	virtual double System.IConvertible.ToDouble(Double provider); // 11 - a0b7e618
	virtual short System.IConvertible.ToInt16(Int16 provider); // 12 - a0b7e6cc
	virtual int System.IConvertible.ToInt32(Int32 provider); // 13 - a0b7e780
	virtual long System.IConvertible.ToInt64(Int64 provider); // 14 - a0b7e834
	virtual sbyte System.IConvertible.ToSByte(SByte provider); // 15 - a0b7e8e8
	virtual float System.IConvertible.ToSingle(Single provider); // 16 - a0b7e99c
	virtual String ToString(String provider); // 17 - a0b8143c
	virtual mvar System.IConvertible.ToType(Object targetType, Object provider); // 18 - a0b7ea50
	virtual ushort System.IConvertible.ToUInt16(UInt16 provider); // 19 - a0b7ec04
	virtual uint System.IConvertible.ToUInt32(UInt32 provider); // 20 - a0b7ecb8
	virtual ulong System.IConvertible.ToUInt64(UInt64 provider); // 21 - a0b7ed6c
	virtual int CompareTo(mvar target); // 22 - a0b810e8
}
// Namespace: NianticLabs.Platform
class IapApi
{
	// Fields
	StoreItemDelegate storeItemDelegate;
	BalanceDelegate balanceDelegate;
	BalanceDelegate priceDelegate;
	BalanceDelegate currencyGrantedDelegate;
	PresentationDataDelegate presentationDataDelegate;
	ItemQuantityDelegate itemQuantityDelegate;
	NativeStoreItemDelegateType <>f__mg$cache0;
	NativeBalanceDelegateType <>f__mg$cache1;
	NativeBalanceDelegateType <>f__mg$cache2;
	NativeBalanceDelegateType <>f__mg$cache3;
	NativePresentationDataDelegateType <>f__mg$cache4;
	NativeItemQuantityDelegateType <>f__mg$cache5;

	// Methods
	void ReportNativeStoreItem(uint storeItem); // a07ebe28
	int ProcessEvents(Int32 event_delegate); // a07ec238
	void ReportNativeBalance(uint balance); // a07ec550
	void ReportNativePrice(uint balance); // a07ec838
	void ReportNativeCurrencyGranted(uint balance); // a07ec938
	void ReportNativePresentationData(uint presentationData); // a07eca38
	void ReportNativeItemQuantityDelegate(uint itemQuantity); // a07ece1c
	void MarshalBalanceToDelegate(uint balance, Void returnDelegate); // a07ec60c
	void GetIapState(Void iapState); // a07ed2b8
	void GetPurchaseResult(Void purchaseResult); // a07ed474
	void RefreshSkusAndBalances(); // a07ed630
	void GetSkusAndBalances(Void storeItemHandler, Void balanceHandler, Void priceHandler, Void currencyGrantedHandler, Void presentationHandler, Void itemQuantityHandler); // a07ed818
	void Initialize(); // a07ee0d8
	void PurchaseItem(String itemId); // a07ee2c0
	void CheckResult(String entrypoint, Void result); // a07ec478
	void GetStoreSkusAndBalances(Generic items, Generic balances); // a07ee820
	void .cctor(); // a07eeb30

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: 
class StoreItemDelegate
{

	// Methods
	void .ctor(mvar object, uint method); // a07eeae0
	void Invoke(String sku, boolean isVendorItem, String localCurrencyPrice, boolean canBePurchased); // a07ec110
	IAsyncResult BeginInvoke(String sku, boolean isVendorItem, String localCurrencyPrice, boolean canBePurchased, IAsyncResult callback, mvar object); // a07ef810
	void EndInvoke(Void result); // a07ef8f8

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual void Invoke(String sku, boolean isVendorItem, String localCurrencyPrice, boolean canBePurchased); // 12 - a07ec110
	virtual IAsyncResult BeginInvoke(String sku, boolean isVendorItem, String localCurrencyPrice, boolean canBePurchased, IAsyncResult callback, mvar object); // 13 - a07ef810
	virtual void EndInvoke(Void result); // 14 - a07ef8f8
}
// Namespace: 
class BalanceDelegate
{

	// Methods
	void .ctor(mvar object, uint method); // a07eeaf4
	void Invoke(String currency_type, int amount); // a07ed1ac
	IAsyncResult BeginInvoke(String currency_type, int amount, IAsyncResult callback, mvar object); // a07ef240
	void EndInvoke(Void result); // a07ef308

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual void Invoke(String currency_type, int amount); // 12 - a07ed1ac
	virtual IAsyncResult BeginInvoke(String currency_type, int amount, IAsyncResult callback, mvar object); // 13 - a07ef240
	virtual void EndInvoke(Void result); // 14 - a07ef308
}
// Namespace: 
class PresentationDataDelegate
{

	// Methods
	void .ctor(mvar object, uint method); // a07eeb08
	void Invoke(String key, String presentationValue); // a07ecccc
	IAsyncResult BeginInvoke(String key, String presentationValue, IAsyncResult callback, mvar object); // a07ef728
	void EndInvoke(Void result); // a07ef760

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual void Invoke(String key, String presentationValue); // 12 - a07ecccc
	virtual IAsyncResult BeginInvoke(String key, String presentationValue, IAsyncResult callback, mvar object); // 13 - a07ef728
	virtual void EndInvoke(Void result); // 14 - a07ef760
}
// Namespace: 
class ItemQuantityDelegate
{

	// Methods
	void .ctor(mvar object, uint method); // a07eeb1c
	void Invoke(String item, int quantity); // a07ed0a0
	IAsyncResult BeginInvoke(String item, int quantity, IAsyncResult callback, mvar object); // a07ef5dc
	void EndInvoke(Void result); // a07ef6a4

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual void Invoke(String item, int quantity); // 12 - a07ed0a0
	virtual IAsyncResult BeginInvoke(String item, int quantity, IAsyncResult callback, mvar object); // 13 - a07ef5dc
	virtual void EndInvoke(Void result); // 14 - a07ef6a4
}
// Namespace: 
class StoreItem
{
	// Fields
	uint sku;
	uint localCurrencyPrice;
	int isVendorItem;
	int canBePurchased;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0d18a48
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0d18a60
	virtual String ToString(); // 3 - a0d18b28
}
// Namespace: 
class IapEvent
{
	// Fields
	int value__;
	static IapEvent STORE_REFRESH = 0;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0b8202c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0b82044
	virtual String ToString(); // 3 - a0b81258
	virtual String ToString(String format, String provider); // 4 - a0b81ecc
	virtual TypeCode GetTypeCode(); // 5 - a0b7ee20
	virtual boolean System.IConvertible.ToBoolean(Boolean provider); // 6 - a0b7e270
	virtual byte System.IConvertible.ToByte(Byte provider); // 7 - a0b7e328
	virtual char System.IConvertible.ToChar(Char provider); // 8 - a0b7e3dc
	virtual DateTime System.IConvertible.ToDateTime(DateTime provider); // 9 - a0b7e490
	virtual Decimal System.IConvertible.ToDecimal(Decimal provider); // 10 - a0b7e554
	virtual double System.IConvertible.ToDouble(Double provider); // 11 - a0b7e618
	virtual short System.IConvertible.ToInt16(Int16 provider); // 12 - a0b7e6cc
	virtual int System.IConvertible.ToInt32(Int32 provider); // 13 - a0b7e780
	virtual long System.IConvertible.ToInt64(Int64 provider); // 14 - a0b7e834
	virtual sbyte System.IConvertible.ToSByte(SByte provider); // 15 - a0b7e8e8
	virtual float System.IConvertible.ToSingle(Single provider); // 16 - a0b7e99c
	virtual String ToString(String provider); // 17 - a0b8143c
	virtual mvar System.IConvertible.ToType(Object targetType, Object provider); // 18 - a0b7ea50
	virtual ushort System.IConvertible.ToUInt16(UInt16 provider); // 19 - a0b7ec04
	virtual uint System.IConvertible.ToUInt32(UInt32 provider); // 20 - a0b7ecb8
	virtual ulong System.IConvertible.ToUInt64(UInt64 provider); // 21 - a0b7ed6c
	virtual int CompareTo(mvar target); // 22 - a0b810e8
}
// Namespace: 
class Balance
{
	// Fields
	uint currency_type;
	int amount;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0d18a48
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0d18a60
	virtual String ToString(); // 3 - a0d18b28
}
// Namespace: 
class PresentationData
{
	// Fields
	uint key;
	uint presentationValue;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0d18a48
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0d18a60
	virtual String ToString(); // 3 - a0d18b28
}
// Namespace: 
class ItemQuantity
{
	// Fields
	uint item;
	int quantity;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0d18a48
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0d18a60
	virtual String ToString(); // 3 - a0d18b28
}
// Namespace: 
class IapStoreItem
{
	// Fields
	String sku;
	String localCurrencyPrice;
	boolean isVendorItem;
	boolean canBePurchased;
	Generic virtualCurrencyPrice;
	Generic virtualCurrencyGranted;
	Generic presentationData;
	Generic itemQuantities;

	// Methods
	void .ctor(); // a07eec38

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: 
class IapBalance
{
	// Fields
	String currency_type;
	int amount;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0d18a48
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0d18a60
	virtual String ToString(); // 3 - a0d18b28
}
// Namespace: 
class <GetStoreSkusAndBalances>c__AnonStorey0
{
	// Fields
	Generic items;
	IapStoreItem currentItem;
	Generic balances;

	// Methods
	void .ctor(); // a07eead8
	void <>m__0(String sku, boolean isVendorItem, String localCurrencyPrice, boolean canBePurchased); // a07eeb34
	void <>m__1(String currency_type, int amount); // a07eec40
	void <>m__2(String currency_type, int amount); // a07eed60
	void <>m__3(String currency_type, int amount); // a07eee80
	void <>m__4(String key, String presentationValue); // a07eefa0
	void <>m__5(String item, int quantity); // a07ef0c0

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: NianticLabs.Platform
class Location
{
	// Fields
	double latitudeDeg;
	double longitudeDeg;
	double altitudeM;
	double accuracyM;
	double timestampS;
	LocationStatus status;
	LocationType locationType;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0d18a48
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0d18a60
	virtual String ToString(); // 3 - a0d18b28
}
// Namespace: NianticLabs.Platform
class CompassHeading
{
	// Fields
	double headingDeg;
	double timestampS;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0d18a48
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0d18a60
	virtual String ToString(); // 3 - a0d18b28
}
// Namespace: NianticLabs.Platform
class MapApi
{
	// Fields
	LocationUpdateEventHandler LocationUpdateEvent;

	// Methods
	void ClearCache(Void type); // a07efc5c
	void GetView(Void view); // a07efe70
	void SetView(Void view); // a07efff0
	void GetPosition(double lat, double lng, double alt, double posX, double posY, double posZ, Void up); // a07f0170
	void GetWorldLocation(double posX, double posY, double posZ, double lat, double lng, double alt); // a07f03ac
	void SubscribeLayer(Void layer); // a07f05d8
	void OnLocationUpdateEventHandler(Void msg); // a07f0758
	void GetCurrentLocation(Void location); // a07f0ac4
	int UpdateTiles(Int32 event_delegate, Int32 vector3_allocator, Int32 integer_allocator, Int32 deallocator); // a07f0c44
	void S2CacheUpdateVisibleCells(Void event_delegate); // a07f0ec0
	void S2CacheSetCellData(ulong s2cellid, int num_bytes, boolean isLeaf); // a07f1088
	void CheckResult(String entrypoint, Void result); // a07efddc

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: 
class LocationUpdateEventHandler
{

	// Methods
	void .ctor(mvar object, uint method); // a07f1ac0
	void Invoke(Void location); // a07f12e8
	IAsyncResult BeginInvoke(IAsyncResult location, IAsyncResult callback, mvar object); // a07f1b48
	void EndInvoke(Void result); // a07f1c54

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual void Invoke(Void location); // 12 - a07f12e8
	virtual IAsyncResult BeginInvoke(IAsyncResult location, IAsyncResult callback, mvar object); // 13 - a07f1b48
	virtual void EndInvoke(Void result); // 14 - a07f1c54
}
// Namespace: 
class TileEvent
{
	// Fields
	int value__;
	static TileEvent CREATE_TILE = 0;
	static TileEvent DELETE_TILE = 1;
	static TileEvent BEGIN_TILE = 2;
	static TileEvent END_TILE = 3;
	static TileEvent LAYER = 4;
	static TileEvent POINT = 5;
	static TileEvent LINEAR = 6;
	static TileEvent MESH = 7;
	static TileEvent GMM_BUILDING = 8;
	static TileEvent AREA = 9;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0b8202c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0b82044
	virtual String ToString(); // 3 - a0b81258
	virtual String ToString(String format, String provider); // 4 - a0b81ecc
	virtual TypeCode GetTypeCode(); // 5 - a0b7ee20
	virtual boolean System.IConvertible.ToBoolean(Boolean provider); // 6 - a0b7e270
	virtual byte System.IConvertible.ToByte(Byte provider); // 7 - a0b7e328
	virtual char System.IConvertible.ToChar(Char provider); // 8 - a0b7e3dc
	virtual DateTime System.IConvertible.ToDateTime(DateTime provider); // 9 - a0b7e490
	virtual Decimal System.IConvertible.ToDecimal(Decimal provider); // 10 - a0b7e554
	virtual double System.IConvertible.ToDouble(Double provider); // 11 - a0b7e618
	virtual short System.IConvertible.ToInt16(Int16 provider); // 12 - a0b7e6cc
	virtual int System.IConvertible.ToInt32(Int32 provider); // 13 - a0b7e780
	virtual long System.IConvertible.ToInt64(Int64 provider); // 14 - a0b7e834
	virtual sbyte System.IConvertible.ToSByte(SByte provider); // 15 - a0b7e8e8
	virtual float System.IConvertible.ToSingle(Single provider); // 16 - a0b7e99c
	virtual String ToString(String provider); // 17 - a0b8143c
	virtual mvar System.IConvertible.ToType(Object targetType, Object provider); // 18 - a0b7ea50
	virtual ushort System.IConvertible.ToUInt16(UInt16 provider); // 19 - a0b7ec04
	virtual uint System.IConvertible.ToUInt32(UInt32 provider); // 20 - a0b7ecb8
	virtual ulong System.IConvertible.ToUInt64(UInt64 provider); // 21 - a0b7ed6c
	virtual int CompareTo(mvar target); // 22 - a0b810e8
}
// Namespace: 
class CellEvent
{
	// Fields
	int value__;
	static CellEvent FETCH_CELLS = 0;
	static CellEvent DELETED_CELLS = 1;
	static CellEvent ADDED_TO_SCENE_CELLS = 2;
	static CellEvent REMOVED_FROM_SCENE_CELLS = 3;
	static CellEvent UPDATED_SCENE_CELLS = 4;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0b8202c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0b82044
	virtual String ToString(); // 3 - a0b81258
	virtual String ToString(String format, String provider); // 4 - a0b81ecc
	virtual TypeCode GetTypeCode(); // 5 - a0b7ee20
	virtual boolean System.IConvertible.ToBoolean(Boolean provider); // 6 - a0b7e270
	virtual byte System.IConvertible.ToByte(Byte provider); // 7 - a0b7e328
	virtual char System.IConvertible.ToChar(Char provider); // 8 - a0b7e3dc
	virtual DateTime System.IConvertible.ToDateTime(DateTime provider); // 9 - a0b7e490
	virtual Decimal System.IConvertible.ToDecimal(Decimal provider); // 10 - a0b7e554
	virtual double System.IConvertible.ToDouble(Double provider); // 11 - a0b7e618
	virtual short System.IConvertible.ToInt16(Int16 provider); // 12 - a0b7e6cc
	virtual int System.IConvertible.ToInt32(Int32 provider); // 13 - a0b7e780
	virtual long System.IConvertible.ToInt64(Int64 provider); // 14 - a0b7e834
	virtual sbyte System.IConvertible.ToSByte(SByte provider); // 15 - a0b7e8e8
	virtual float System.IConvertible.ToSingle(Single provider); // 16 - a0b7e99c
	virtual String ToString(String provider); // 17 - a0b8143c
	virtual mvar System.IConvertible.ToType(Object targetType, Object provider); // 18 - a0b7ea50
	virtual ushort System.IConvertible.ToUInt16(UInt16 provider); // 19 - a0b7ec04
	virtual uint System.IConvertible.ToUInt32(UInt32 provider); // 20 - a0b7ecb8
	virtual ulong System.IConvertible.ToUInt64(UInt64 provider); // 21 - a0b7ed6c
	virtual int CompareTo(mvar target); // 22 - a0b810e8
}
// Namespace: 
class CellEventDelegateType
{

	// Methods
	void .ctor(mvar object, uint method); // a07f14b0
	void Invoke(Void cellEvent, ulong s2cellid); // a07f14c4
	IAsyncResult BeginInvoke(IAsyncResult cellEvent, ulong s2cellid, IAsyncResult callback, mvar object); // a07f15c4
	void EndInvoke(Void result); // a07f16a8

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual void Invoke(Void cellEvent, ulong s2cellid); // 12 - a07f14c4
	virtual IAsyncResult BeginInvoke(IAsyncResult cellEvent, ulong s2cellid, IAsyncResult callback, mvar object); // 13 - a07f15c4
	virtual void EndInvoke(Void result); // 14 - a07f16a8
}
// Namespace: 
class <OnLocationUpdateEventHandler>c__AnonStorey0
{
	// Fields
	LocationUpdateEventHandler handler;

	// Methods
	void .ctor(); // a07f0ab4

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: 
class <OnLocationUpdateEventHandler>c__AnonStorey1
{
	// Fields
	Location location;
	<OnLocationUpdateEventHandler>c__AnonStorey0 <>f__ref$0;

	// Methods
	void .ctor(); // a07f0abc
	void <>m__0(); // a07f126c

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: NianticLabs.Platform
class NianticPlugin
{
	// Fields
	LogLevel logLevel;
	int perFrameProcessingTimeMs;
	boolean isPaused;
	boolean firstResume;
	NativeEventDispatcher nativeDispatcher;

	// Methods
	void .ctor(); // a07fbe48
	NianticPlugin InitializePlugin(NianticPlugin logLevel); // a07fbe60
	void Awake(); // a07fc20c
	void Update(); // a07fc7ac
	void OnApplicationFocus(boolean focusStatus); // a07fcbdc
	void OnApplicationPause(boolean pauseStatus); // a07fcd90
	void OnApplicationQuit(); // a07fcfb4

	// VTable
	virtual boolean Equals(mvar o); // 0 - a0acdcac
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0acddb8
	virtual String ToString(); // 3 - a0acdb7c
}
// Namespace: NianticLabs.Platform
class LogLevel
{
	// Fields
	int value__;
	static LogLevel OFF = 0;
	static LogLevel FATAL = 1;
	static LogLevel ERROR = 2;
	static LogLevel WARNING = 3;
	static LogLevel INFO = 4;
	static LogLevel VERBOSE = 5;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0b8202c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0b82044
	virtual String ToString(); // 3 - a0b81258
	virtual String ToString(String format, String provider); // 4 - a0b81ecc
	virtual TypeCode GetTypeCode(); // 5 - a0b7ee20
	virtual boolean System.IConvertible.ToBoolean(Boolean provider); // 6 - a0b7e270
	virtual byte System.IConvertible.ToByte(Byte provider); // 7 - a0b7e328
	virtual char System.IConvertible.ToChar(Char provider); // 8 - a0b7e3dc
	virtual DateTime System.IConvertible.ToDateTime(DateTime provider); // 9 - a0b7e490
	virtual Decimal System.IConvertible.ToDecimal(Decimal provider); // 10 - a0b7e554
	virtual double System.IConvertible.ToDouble(Double provider); // 11 - a0b7e618
	virtual short System.IConvertible.ToInt16(Int16 provider); // 12 - a0b7e6cc
	virtual int System.IConvertible.ToInt32(Int32 provider); // 13 - a0b7e780
	virtual long System.IConvertible.ToInt64(Int64 provider); // 14 - a0b7e834
	virtual sbyte System.IConvertible.ToSByte(SByte provider); // 15 - a0b7e8e8
	virtual float System.IConvertible.ToSingle(Single provider); // 16 - a0b7e99c
	virtual String ToString(String provider); // 17 - a0b8143c
	virtual mvar System.IConvertible.ToType(Object targetType, Object provider); // 18 - a0b7ea50
	virtual ushort System.IConvertible.ToUInt16(UInt16 provider); // 19 - a0b7ec04
	virtual uint System.IConvertible.ToUInt32(UInt32 provider); // 20 - a0b7ecb8
	virtual ulong System.IConvertible.ToUInt64(UInt64 provider); // 21 - a0b7ed6c
	virtual int CompareTo(mvar target); // 22 - a0b810e8
}
// Namespace: NianticLabs.Platform
class MonoPInvokeCallbackAttribute
{
	// Fields
	Type type;

	// Methods
	void .ctor(Void t); // a07f4074

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0b3976c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0b394cc
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar get_TypeId(); // 4 - a0b38888
	virtual boolean IsDefaultAttribute(); // 5 - a0b394d4
}
// Namespace: NianticLabs.Platform
class PluginState
{
	// Fields
	int value__;
	static PluginState UNDEFINED = 0;
	static PluginState INIT = 1;
	static PluginState START = 2;
	static PluginState STOP = 3;
	static PluginState PAUSE = 4;
	static PluginState RESUME = 5;
	static PluginState ACTIVE = 6;
	static PluginState IDLE = 7;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0b8202c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0b82044
	virtual String ToString(); // 3 - a0b81258
	virtual String ToString(String format, String provider); // 4 - a0b81ecc
	virtual TypeCode GetTypeCode(); // 5 - a0b7ee20
	virtual boolean System.IConvertible.ToBoolean(Boolean provider); // 6 - a0b7e270
	virtual byte System.IConvertible.ToByte(Byte provider); // 7 - a0b7e328
	virtual char System.IConvertible.ToChar(Char provider); // 8 - a0b7e3dc
	virtual DateTime System.IConvertible.ToDateTime(DateTime provider); // 9 - a0b7e490
	virtual Decimal System.IConvertible.ToDecimal(Decimal provider); // 10 - a0b7e554
	virtual double System.IConvertible.ToDouble(Double provider); // 11 - a0b7e618
	virtual short System.IConvertible.ToInt16(Int16 provider); // 12 - a0b7e6cc
	virtual int System.IConvertible.ToInt32(Int32 provider); // 13 - a0b7e780
	virtual long System.IConvertible.ToInt64(Int64 provider); // 14 - a0b7e834
	virtual sbyte System.IConvertible.ToSByte(SByte provider); // 15 - a0b7e8e8
	virtual float System.IConvertible.ToSingle(Single provider); // 16 - a0b7e99c
	virtual String ToString(String provider); // 17 - a0b8143c
	virtual mvar System.IConvertible.ToType(Object targetType, Object provider); // 18 - a0b7ea50
	virtual ushort System.IConvertible.ToUInt16(UInt16 provider); // 19 - a0b7ec04
	virtual uint System.IConvertible.ToUInt32(UInt32 provider); // 20 - a0b7ecb8
	virtual ulong System.IConvertible.ToUInt64(UInt64 provider); // 21 - a0b7ed6c
	virtual int CompareTo(mvar target); // 22 - a0b810e8
}
// Namespace: NianticLabs.Platform
class PluginApi
{
	// Fields
	OnLoadHandler OnLoadEvent;
	DebugLogsDelegate logDelegate;
	int mainThreadId;
	NativeLogDelegateType <>f__mg$cache0;

	// Methods
	void SetBackgroundMode(boolean on); // a07fc5b8
	void FlushDebugLogs(); // a07fd240
	void SetLogLevel(Void level); // a07fc4bc
	String GetDeviceCountryCode(); // a07fd424
	void LogError(Void e); // a07fd614
	void LogError(String message); // a07fd804
	void LogWarning(String message); // a07fd8a8
	void LogVerbose(String message); // a07fbc8c
	void Log(Void sts, String message); // a07fd6ec
	void OnLoad(); // a07fc330
	void OnPause(); // a07fcebc
	void OnResume(); // a07fcc98
	void OnStart(); // a07fc6b4
	void OnStop(); // a07fd0a8
	void OnUpdate(); // a07fcae4
	void OnNativeEvent(uint buffer, int bufferSize, Void eventType); // a07fbd30
	void CheckResult(String entrypoint, Void result); // a07fd1a0
	void ReportNativeLog(Void level, uint str); // a07fdb88
	void .cctor(); // a07fdcec

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: 
class OnLoadHandler
{

	// Methods
	void .ctor(mvar object, uint method); // a07fde0c
	void Invoke(); // a07fda30
	IAsyncResult BeginInvoke(IAsyncResult callback, mvar object); // a07fde2c
	void EndInvoke(Void result); // a07fde58

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual void Invoke(); // 12 - a07fda30
	virtual IAsyncResult BeginInvoke(IAsyncResult callback, mvar object); // 13 - a07fde2c
	virtual void EndInvoke(Void result); // 14 - a07fde58
}
// Namespace: 
class DebugLogsDelegate
{

	// Methods
	void .ctor(mvar object, uint method); // a07fdcf0
	void Invoke(Void level, String message); // a07fd94c
	IAsyncResult BeginInvoke(IAsyncResult level, String message, IAsyncResult callback, mvar object); // a07fdd3c
	void EndInvoke(Void result); // a07fde00

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual void Invoke(Void level, String message); // 12 - a07fd94c
	virtual IAsyncResult BeginInvoke(IAsyncResult level, String message, IAsyncResult callback, mvar object); // 13 - a07fdd3c
	virtual void EndInvoke(Void result); // 14 - a07fde00
}
// Namespace: NianticLabs.Platform
class PluginUtils
{

	// Methods
	cmod_opt RecoverPluginEventParams(uint eventParams); // 0
	cmod_opt RecoverFromHandle(uint hdl); // 0
	cmod_reqd RecoverArrayFromHandle(uint hdl); // 0
	void ArrayAllocator(int requestedSize, uint rawPointer, uint handle); // 0

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: NianticLabs.Platform
class RpcException
{
	// Fields
	RpcStatus rpcStatus;
	int rpcId;

	// Methods
	void .ctor(int rpcId, Void rpcStatus); // a08007f4
	RpcStatus get_Status(); // a0800958
	int get_RpcId(); // a0800960

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0b8584c
	virtual void GetObjectData(Void info, Void context); // 4 - a0b3067c
	virtual Exception get_InnerException(); // 5 - a0b84b44
	virtual String get_Message(); // 6 - a0b304c0
	virtual String get_Source(); // 7 - a0b84bc0
	virtual String get_StackTrace(); // 8 - a0b84d84
	virtual void GetObjectData(Void info, Void context); // 9 - a0b3067c
	virtual Type GetType(); // 10 - a0b85ab0
}
// Namespace: NianticLabs.Platform
class RpcData
{
	// Fields
	int rpcId;
	CodedInputStream stream;

	// Methods
	void .ctor(int rpcId, Void stream); // a07ffa00
	int get_RpcId(); // a08007ec
	CodedInputStream get_Stream(); // a0800950

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: NianticLabs.Platform
class Rpc
{
	// Fields
	int DEFAULT_RPC_TIMEOUT_MS;
	int DEFAULT_RPC_RETRY_DELAY_MS;
	int NO_RETRY;
	Generic pendingRequests;
	Generic preActionHooks;
	Generic postActionHooks;
	Result resultInstance;
	UnmanagedStream sendBuffer;

	// Methods
	int get_PendingRequestCount(); // a07fde64
	void DispatchPendingMessages(); // a07fc8f0
	int Send(int method, int timeoutMs, int retryDelayMs, Int32 inProto, Generic outCallback, Int32 cancelToken); // a07fe740
	void DispatchCallbacks(cmod_reqd requests, Void result); // a07ff5a4
	int Send(int timeoutMs, int retryDelayMs, cmod_reqd requests, Generic outCallback); // a07fee6c
	void Recv(Void rpcResult); // a07fe390
	void RegisterPostAction(Generic hook); // a07ffcac
	void RemovePostAction(Generic hook); // a07ffd90
	void OnRpcResponseEventHandler(Void msg); // a07ffe74
	void .cctor(); // a0800228

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: 
class Result
{
	// Fields
	int rpcId;
	RpcStatus rpcStatus;
	cmod_reqd payloadSizes;
	cmod_reqd payloads;
	Generic rpcPayloads;
	int actionCount;

	// Methods
	void .ctor(int id, int actionCount); // a0800150
	Result Recycle(int id, int actionCount); // a07fe150

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0d18a48
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0d18a60
	virtual String ToString(); // 3 - a0d18b28
}
// Namespace: NianticLabs.Platform
class UnmanagedStream
{
	// Fields
	uint ptr;
	int capacity;
	long position;
	long length;

	// Methods
	void .ctor(int capacity); // a07ffa50
	void Dispose(boolean disposing); // a0802844
	uint GetBuffer(); // a07ffb64
	boolean get_CanRead(); // a080292c
	boolean get_CanSeek(); // a0802934
	boolean get_CanWrite(); // a080293c
	long get_Position(); // a0802944
	void set_Position(long value); // a080294c
	int get_Capacity(); // a07ffa48
	long get_Length(); // a0802a30
	void Flush(); // a0802a38
	int Read(cmod_reqd buffer, int offset, int count); // a0802a3c
	long Seek(long offset, Int64 origin); // a0802b70
	void SetLength(long value); // a0802c7c
	void Write(cmod_reqd buffer, int offset, int count); // a0802d68

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
	virtual void Dispose(); // 4 - a0bb1030
	virtual boolean get_CanRead(); // 5 - a080292c
	virtual boolean get_CanSeek(); // 6 - a0802934
	virtual boolean get_CanWrite(); // 7 - a080293c
	virtual long get_Length(); // 8 - a0802a30
	virtual long get_Position(); // 9 - a0802944
	virtual void set_Position(long value); // 10 - a080294c
	virtual void Dispose(boolean disposing); // 11 - a0802844
	virtual void Close(); // 12 - a0bb1064
	virtual int get_ReadTimeout(); // 13 - a0bb1098
	virtual int get_WriteTimeout(); // 14 - a0bb1154
	virtual void Flush(); // 15 - a0802a38
	virtual int Read(cmod_reqd buffer, int offset, int count); // 16 - a0802a3c
	virtual int ReadByte(); // 17 - a0bb1210
	virtual long Seek(long offset, Int64 origin); // 18 - a0802b70
	virtual void SetLength(long value); // 19 - a0802c7c
	virtual void Write(cmod_reqd buffer, int offset, int count); // 20 - a0802d68
	virtual void WriteByte(byte value); // 21 - a0bb1310
	virtual IAsyncResult BeginRead(cmod_reqd buffer, int offset, int count, IAsyncResult callback, mvar state); // 22 - a0ba84d0
	virtual IAsyncResult BeginWrite(cmod_reqd buffer, int offset, int count, IAsyncResult callback, mvar state); // 23 - a0ba9604
	virtual int EndRead(Int32 asyncResult); // 24 - a0ba89ec
	virtual void EndWrite(Void asyncResult); // 25 - a0ba9e94
}
// Namespace: 
class RpcFuture
{
	// Fields
	boolean retSet;
	RpcData retValue;
	RpcStatus rpcStatus;
	Generic onReady;
	CancellationToken cancelToken;

	// Methods
	void .ctor(Generic onReady, Void cancelToken); // a0800564
	void Recycle(Generic onReady, Void cancelToken); // a08006b8
	RpcData NianticLabs.Platform.Tasks.IFuture<NianticLabs.Platform.RpcData>.get_Value(); // a08006d4
	boolean get_IsCancelled(); // a0800928
	void Set(Void rpcStatus, Void data); // a080059c

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
	virtual RpcData NianticLabs.Platform.Tasks.IFuture<NianticLabs.Platform.RpcData>.get_Value(); // 4 - a08006d4
}
// Namespace: 
class Request
{
	// Fields
	int method;
	IMessage payload;
	RpcFuture future;

	// Methods
	void .ctor(int method, Void payload, Generic outCallback, Void cancelToken); // a07feda4
	void SetResult(Void rpcStatus, Void data); // a07ffa28

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0d18a48
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0d18a60
	virtual String ToString(); // 3 - a0d18b28
}
// Namespace: 
class <Send>c__AnonStorey0
{
	// Fields
	cmod_reqd requests;

	// Methods
	void .ctor(); // a07fed9c
	void <>m__0(Void result); // a080048c

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: 
class <OnRpcResponseEventHandler>c__AnonStorey2
{
	// Fields
	Result res;

	// Methods
	void .ctor(); // a0800148
	void <>m__0(); // a08003bc

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: NianticLabs.Platform
class S2Api
{

	// Methods
	void GetLatLng(ulong s2cellid, double lat, double lng); // a0800968

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: NianticLabs.Platform
class ServerApi
{
	// Fields
	ChannelAuthEventHandler AuthEvent;
	Generic googleTokenCallback;

	// Methods
	void add_AuthEvent(Void value); // a0800a24
	void remove_AuthEvent(Void value); // a0800c74
	void OnChannelAuthEventHandler(Void msg); // a0800ec4
	void SetServer(String host_port); // a0801164
	void ResetAuthToken(String authId, Void token); // a0801300
	void RefreshAuthToken(String authId, Void token); // a0801510
	void ClearAuthToken(); // a0801720
	void OnGoogleTokenEventHandler(Void msg); // a0801814
	void GetGoogleToken(String clientId, String clientSecret, Generic tokenCallback); // a0801a44
	void RefreshGoogleToken(String clientId, String clientSecret, Generic tokenCallback); // a0801bfc
	void ClearGoogleToken(); // a0801db4
	void ProcessPendingRequests(); // a07fdf40
	int HasResponse(Int32 status, int action_count); // a07fe034
	boolean GetResponsePayloads(int rpcId, cmod_reqd payloads, cmod_reqd payload_sizes); // a07fe25c
	boolean ClearResponse(int rpcId); // a07fe61c
	int Send(int timeoutMs, int retryDelayMs, int count, cmod_reqd methods, uint bodies, cmod_reqd sizes); // a07ffb6c
	void CheckResult(String entrypoint, Void result); // a0801260
	void .cctor(); // a0801ea8

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: 
class ChannelAuthEventHandler
{

	// Methods
	void .ctor(mvar object, uint method); // a0801fac
	void Invoke(Void evt); // a0801eec
	IAsyncResult BeginInvoke(IAsyncResult evt, IAsyncResult callback, mvar object); // a0801fd0
	void EndInvoke(Void result); // a080208c

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bc378c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bc38a8
	virtual String ToString(); // 3 - a0bcc704
	virtual mvar Clone(); // 4 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 5 - a0bc3718
	virtual mvar DynamicInvokeImpl(cmod_reqd args); // 6 - a0bc3738
	virtual mvar Clone(); // 7 - a0b790fc
	virtual void GetObjectData(Void info, Void context); // 8 - a0bc3718
	virtual cmod_reqd GetInvocationList(); // 9 - a0bc38b0
	virtual Delegate CombineImpl(Delegate follow); // 10 - a0bc3ba4
	virtual Delegate RemoveImpl(Delegate value); // 11 - a0bc3fb4
	virtual void Invoke(Void evt); // 12 - a0801eec
	virtual IAsyncResult BeginInvoke(IAsyncResult evt, IAsyncResult callback, mvar object); // 13 - a0801fd0
	virtual void EndInvoke(Void result); // 14 - a080208c
}
// Namespace: 
class <OnChannelAuthEventHandler>c__AnonStorey0
{
	// Fields
	ChannelAuthEventParams proto;
	ChannelAuthEventHandler handler;

	// Methods
	void .ctor(); // a080115c
	void <>m__0(); // a0801eac

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: Nianticlabs.Platform.Bridge
class ChannelAuthEventParams
{
	// Fields
	Generic _parser;
	uint status_;

	// Methods
	void .ctor(); // a07e90d4
	void .ctor(Void other); // a07e90dc
	Generic get_Parser(); // a07e9108
	MessageDescriptor get_Descriptor(); // a07e91b8
	MessageDescriptor Google.Protobuf.IMessage.get_Descriptor(); // a07e92b0
	ChannelAuthEventParams Clone(); // a07e9348
	uint get_Status(); // a07e93d8
	void set_Status(uint value); // a07e93e0
	boolean Equals(mvar other); // a07e93e8
	boolean Equals(Boolean other); // a07e948c
	int GetHashCode(); // a07e9500
	String ToString(); // a07e9540
	void WriteTo(Void output); // a07e95e8
	int CalculateSize(); // a07e9634
	void MergeFrom(Void input); // a07e96f0
	void .cctor(); // a07e9748
	ChannelAuthEventParams <_parser>m__0(); // a07e9844

	// VTable
	virtual boolean Equals(mvar other); // 0 - a07e93e8
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a07e9500
	virtual String ToString(); // 3 - a07e9540
	virtual void MergeFrom(Void input); // 4 - a07e96f0
	virtual void WriteTo(Void output); // 5 - a07e95e8
	virtual int CalculateSize(); // 6 - a07e9634
	virtual MessageDescriptor Google.Protobuf.IMessage.get_Descriptor(); // 7 - a07e92b0
	virtual boolean Equals(Boolean other); // 8 - a07e948c
	virtual ChannelAuthEventParams Clone(); // 9 - a07e9348
}
// Namespace: NianticLabs.Platform
class ViewPoint
{
	// Fields
	double longitudeDeg;
	double latitudeDeg;
	double lineOfSightM;
	double tileSizeM;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0d18a48
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0d18a60
	virtual String ToString(); // 3 - a0d18b28
}
// Namespace: NianticLabs.Platform
class SpatialCacheManager
{
	// Fields
	CellEventDelegateType cellEventDelegate;
	Generic fetchCells;
	Generic deletedCells;
	Generic addToSceneCells;
	Generic removeFromSceneCells;
	Generic updatedSceneCells;

	// Methods
	void .ctor(); // a0802098
	void CellEventCallback(Void cellEvent, ulong s2cellid); // a08021b8
	void SetCellData(ulong s2cellid, int protoBytes, boolean isLeaf); // a080244c
	void UpdateVisibleCells(Void manager); // a0802480
	void Clear(); // a0802704
	void .cctor(); // a0802714

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: Nianticlabs.Platform.Bridge
class BridgeReflection
{
	// Fields
	FileDescriptor descriptor;

	// Methods
	void .cctor(); // a07e8fa0
	FileDescriptor get_Descriptor(); // a07e9024

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0bcc68c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0bcc6f8
	virtual String ToString(); // 3 - a0bcc704
}
// Namespace: Nianticlabs.Platform.Bridge
class NativeEventType
{
	// Fields
	int value__;
	static NativeEventType UNDEFINED_EVENT = 0;
	static NativeEventType SHUTDOWN_DISPATCHER_EVENT = 1;
	static NativeEventType GOOGLE_AUTH_EVENT = 2;
	static NativeEventType CHANNEL_AUTH_EVENT = 3;
	static NativeEventType LOCATION_UPDATE_EVENT = 4;
	static NativeEventType RPC_RESPONSE_EVENT = 5;

	// VTable
	virtual boolean Equals(mvar obj); // 0 - a0b8202c
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a0b82044
	virtual String ToString(); // 3 - a0b81258
	virtual String ToString(String format, String provider); // 4 - a0b81ecc
	virtual TypeCode GetTypeCode(); // 5 - a0b7ee20
	virtual boolean System.IConvertible.ToBoolean(Boolean provider); // 6 - a0b7e270
	virtual byte System.IConvertible.ToByte(Byte provider); // 7 - a0b7e328
	virtual char System.IConvertible.ToChar(Char provider); // 8 - a0b7e3dc
	virtual DateTime System.IConvertible.ToDateTime(DateTime provider); // 9 - a0b7e490
	virtual Decimal System.IConvertible.ToDecimal(Decimal provider); // 10 - a0b7e554
	virtual double System.IConvertible.ToDouble(Double provider); // 11 - a0b7e618
	virtual short System.IConvertible.ToInt16(Int16 provider); // 12 - a0b7e6cc
	virtual int System.IConvertible.ToInt32(Int32 provider); // 13 - a0b7e780
	virtual long System.IConvertible.ToInt64(Int64 provider); // 14 - a0b7e834
	virtual sbyte System.IConvertible.ToSByte(SByte provider); // 15 - a0b7e8e8
	virtual float System.IConvertible.ToSingle(Single provider); // 16 - a0b7e99c
	virtual String ToString(String provider); // 17 - a0b8143c
	virtual mvar System.IConvertible.ToType(Object targetType, Object provider); // 18 - a0b7ea50
	virtual ushort System.IConvertible.ToUInt16(UInt16 provider); // 19 - a0b7ec04
	virtual uint System.IConvertible.ToUInt32(UInt32 provider); // 20 - a0b7ecb8
	virtual ulong System.IConvertible.ToUInt64(UInt64 provider); // 21 - a0b7ed6c
	virtual int CompareTo(mvar target); // 22 - a0b810e8
}
// Namespace: Nianticlabs.Platform.Bridge
class GoogleAuthEventParams
{
	// Fields
	Generic _parser;
	String payload_;

	// Methods
	void .ctor(); // a07e98d0
	void .ctor(Void other); // a07e9994
	Generic get_Parser(); // a07e99bc
	MessageDescriptor get_Descriptor(); // a07e9a6c
	MessageDescriptor Google.Protobuf.IMessage.get_Descriptor(); // a07e9b64
	GoogleAuthEventParams Clone(); // a07e9bfc
	String get_Payload(); // a07e9c8c
	void set_Payload(String value); // a07e9c94
	boolean Equals(mvar other); // a07e9d34
	boolean Equals(Boolean other); // a07e9dd8
	int GetHashCode(); // a07e9ee4
	String ToString(); // a07e9f4c
	void WriteTo(Void output); // a07e9ff4
	int CalculateSize(); // a07ea050
	void MergeFrom(Void input); // a07ea128
	void .cctor(); // a07ea188
	GoogleAuthEventParams <_parser>m__0(); // a07ea284

	// VTable
	virtual boolean Equals(mvar other); // 0 - a07e9d34
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a07e9ee4
	virtual String ToString(); // 3 - a07e9f4c
	virtual void MergeFrom(Void input); // 4 - a07ea128
	virtual void WriteTo(Void output); // 5 - a07e9ff4
	virtual int CalculateSize(); // 6 - a07ea050
	virtual MessageDescriptor Google.Protobuf.IMessage.get_Descriptor(); // 7 - a07e9b64
	virtual boolean Equals(Boolean other); // 8 - a07e9dd8
	virtual GoogleAuthEventParams Clone(); // 9 - a07e9bfc
}
// Namespace: Nianticlabs.Platform.Bridge
class LocationUpdateEventParams
{
	// Fields
	Generic _parser;
	double latitudeDeg_;
	double longitudeDeg_;
	double altitudeM_;
	double accuracyM_;
	double timestampS_;
	uint providerStatus_;
	uint locationType_;

	// Methods
	void .ctor(); // a07ea30c
	void .ctor(Void other); // a07ea314
	Generic get_Parser(); // a07ea370
	MessageDescriptor get_Descriptor(); // a07ea420
	MessageDescriptor Google.Protobuf.IMessage.get_Descriptor(); // a07ea518
	LocationUpdateEventParams Clone(); // a07ea5b0
	double get_LatitudeDeg(); // a07ea640
	void set_LatitudeDeg(double value); // a07ea64c
	double get_LongitudeDeg(); // a07ea65c
	void set_LongitudeDeg(double value); // a07ea668
	double get_AltitudeM(); // a07ea678
	void set_AltitudeM(double value); // a07ea684
	double get_AccuracyM(); // a07ea694
	void set_AccuracyM(double value); // a07ea6a0
	double get_TimestampS(); // a07ea6b0
	void set_TimestampS(double value); // a07ea6bc
	uint get_ProviderStatus(); // a07ea6cc
	void set_ProviderStatus(uint value); // a07ea6d4
	uint get_LocationType(); // a07ea6dc
	void set_LocationType(uint value); // a07ea6e4
	boolean Equals(mvar other); // a07ea6ec
	boolean Equals(Boolean other); // a07ea790
	int GetHashCode(); // a07ea87c
	String ToString(); // a07ea9c4
	void WriteTo(Void output); // a07eaa6c
	int CalculateSize(); // a07eac3c
	void MergeFrom(Void input); // a07eada0
	void .cctor(); // a07eaecc
	LocationUpdateEventParams <_parser>m__0(); // a07eafc8

	// VTable
	virtual boolean Equals(mvar other); // 0 - a07ea6ec
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a07ea87c
	virtual String ToString(); // 3 - a07ea9c4
	virtual void MergeFrom(Void input); // 4 - a07eada0
	virtual void WriteTo(Void output); // 5 - a07eaa6c
	virtual int CalculateSize(); // 6 - a07eac3c
	virtual MessageDescriptor Google.Protobuf.IMessage.get_Descriptor(); // 7 - a07ea518
	virtual boolean Equals(Boolean other); // 8 - a07ea790
	virtual LocationUpdateEventParams Clone(); // 9 - a07ea5b0
}
// Namespace: Nianticlabs.Platform.Bridge
class RpcResponseEventParams
{
	// Fields
	Generic _parser;
	uint rpcId_;
	uint status_;
	Generic _repeated_payloads_codec;
	Generic payloads_;

	// Methods
	void .ctor(); // a07eb054
	void .ctor(Void other); // a07eb100
	Generic get_Parser(); // a07eb1b4
	MessageDescriptor get_Descriptor(); // a07eb264
	MessageDescriptor Google.Protobuf.IMessage.get_Descriptor(); // a07eb35c
	RpcResponseEventParams Clone(); // a07eb3f4
	uint get_RpcId(); // a07eb484
	void set_RpcId(uint value); // a07eb48c
	uint get_Status(); // a07eb494
	void set_Status(uint value); // a07eb49c
	Generic get_Payloads(); // a07eb4a4
	boolean Equals(mvar other); // a07eb4ac
	boolean Equals(Boolean other); // a07eb550
	int GetHashCode(); // a07eb65c
	String ToString(); // a07eb6f4
	void WriteTo(Void output); // a07eb79c
	int CalculateSize(); // a07eb8e8
	void MergeFrom(Void input); // a07eba7c
	void .cctor(); // a07ebbe4
	RpcResponseEventParams <_parser>m__0(); // a07ebcfc

	// VTable
	virtual boolean Equals(mvar other); // 0 - a07eb4ac
	virtual void Finalize(); // 1 - a0bcc6f4
	virtual int GetHashCode(); // 2 - a07eb65c
	virtual String ToString(); // 3 - a07eb6f4
	virtual void MergeFrom(Void input); // 4 - a07eba7c
	virtual void WriteTo(Void output); // 5 - a07eb79c
	virtual int CalculateSize(); // 6 - a07eb8e8
	virtual MessageDescriptor Google.Protobuf.IMessage.get_Descriptor(); // 7 - a07eb35c
	virtual boolean Equals(Boolean other); // 8 - a07eb550
	virtual RpcResponseEventParams Clone(); // 9 - a07eb3f4
}
/****************** Dumped 0146 classes *****************************/
