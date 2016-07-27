#include <stdio.h>
#include <stdlib.h>
#include <dlfcn.h>
#include <pthread.h>
#include <unistd.h>
#include <jni.h>

#include "il2cpp.h"

// If you're stuck using gcc like me then be sure to compile with -std=c99

#define TAG "MyCode"

typedef void*(*il2cpp_domain_get_t)(void);
typedef int(*il2cpp_domain_assembly_open_t)(void* a_domain, char* a_file);
typedef int(*il2cpp_assembly_get_image_t)(int a_assembly);
typedef void*(*il2cpp_class_from_name_t)(int a_image, const char* a_name_space, const char *a_name);
typedef void*(*il2cpp_class_get_method_from_name_t) (void* a_klass, const char *a_name, int a_param_count);
typedef int(*il2cpp_runtime_invoke_t)(void* a_method, void *a_obj, void **a_params, int **a_exc);

il2cpp_domain_get_t g_GetMonoDomain = 0;
il2cpp_domain_assembly_open_t g_OpenAssembly = 0;
il2cpp_assembly_get_image_t g_GetAssemblyImage = 0;
il2cpp_class_from_name_t g_GetClassFromName = 0;
il2cpp_class_get_method_from_name_t g_ClassMethodFromName = 0;
il2cpp_runtime_invoke_t g_InvokeRuntime = 0;

typedef Il2CppArray*(*GetAssemblies_t)(void* r0, int r1);
typedef void*(*GetCurrDomain_t)(int r0, int r1);
typedef VirtualInvokeData(*GetVirtualInvokeDat_t)(int method, void* pObj);
typedef String_t*(*GetMonoTypeName_t)(Type_t);
typedef TypeArray*(*GetAsmTypes_t)(Assembly_t*, int);

GetAssemblies_t g_GetAssemblies = 0;
GetCurrDomain_t g_GetCurrDomain = 0;
GetVirtualInvokeDat_t g_GetVirt = 0;
GetMonoTypeName_t g_GetTypeName = 0;
GetAsmTypes_t g_GetAssemblyTypes = 0;

typedef Il2CppImage*(*GetImageFromIndex_t)(uint32_t);
typedef Il2CppClass*(*GetTypeInfoFromIndex_t)(uint32_t);
typedef void(*SetupClass_t)(Il2CppClass*);
typedef char*(*GetDefaultFieldValue_t)(FieldInfo*, void*);

GetImageFromIndex_t g_GetImageFromIndex = 0;
GetTypeInfoFromIndex_t g_GetClassFromIndex = 0;
SetupClass_t g_SetupClass = 0;
GetDefaultFieldValue_t g_GetFieldDefault = 0;

typedef void(*GC_free_t)(void* p);
GC_free_t GC_free = 0;

void* pLibLog = 0;

typedef int(*__android_log_print_t)(int prio, const char *tag, const char *fmt, ...);
__android_log_print_t __android_log_print = 0;

#define ANDROID_LOG_INFO 4
#define nullchk(x) (x!=0)

int InitIl2Cpp(void* il2cpp)
{
	g_GetMonoDomain = dlsym(il2cpp, "il2cpp_domain_get");
	__android_log_print(ANDROID_LOG_INFO, TAG, "g_GetMonoDomain %x", (unsigned int)g_GetMonoDomain);

	g_OpenAssembly = dlsym(il2cpp, "il2cpp_domain_assembly_open");
	__android_log_print(ANDROID_LOG_INFO, TAG, "g_OpenAssembly %x", (unsigned int)g_OpenAssembly);

	g_GetAssemblyImage = dlsym(il2cpp, "il2cpp_assembly_get_image");
	__android_log_print(ANDROID_LOG_INFO, TAG, "g_GetAssemblyImage %x", (unsigned int)g_GetAssemblyImage);

	g_GetClassFromName = dlsym(il2cpp, "il2cpp_class_from_name");
	__android_log_print(ANDROID_LOG_INFO, TAG, "g_GetClassFromName %x", (unsigned int)g_GetClassFromName);

	g_ClassMethodFromName = dlsym(il2cpp, "il2cpp_class_get_method_from_name");
	__android_log_print(ANDROID_LOG_INFO, TAG, "g_ClassMethodFromName %x", (unsigned int)g_ClassMethodFromName);

	g_InvokeRuntime = dlsym(il2cpp, "il2cpp_runtime_invoke");
	__android_log_print(ANDROID_LOG_INFO, TAG, "g_InvokeRuntime %x", (unsigned int)g_InvokeRuntime);

	/*return nullchk(g_GetMonoDomain) && nullchk(g_OpenAssembly) && nullchk(g_GetAssemblyImage) && nullchk(g_GetClassFromName)
		&& nullchk(g_ClassMethodFromName) && nullchk(g_InvokeRuntime);*/

	// Il2CppArray<Il2CppAssembly> il2cpp::icalls::mscorlib::System::AppDomain::GetAssemblies()
	g_GetAssemblies = dlsym(il2cpp, "_ZN6il2cpp6icalls8mscorlib6System9AppDomain13GetAssembliesEP15Il2CppAppDomainb");
	__android_log_print(ANDROID_LOG_INFO, TAG, "g_GetAssemblies %x", (unsigned int)g_GetAssemblies);

	g_GetCurrDomain = dlsym(il2cpp, "_ZN6il2cpp6icalls8mscorlib6System9AppDomain12getCurDomainEv");
	__android_log_print(ANDROID_LOG_INFO, TAG, "g_GetCurrDomain %x", (unsigned int)g_GetCurrDomain);

	g_GetVirt = dlsym(il2cpp, "_ZN6il2cpp2vm7Runtime20GetVirtualInvokeDataEjPv");
	__android_log_print(ANDROID_LOG_INFO, TAG, "g_GetVirt %x", (unsigned int)g_GetVirt);

	g_GetTypeName = dlsym(il2cpp, "_ZN6il2cpp6icalls8mscorlib6System8MonoType8get_NameEP20Il2CppReflectionType");
	__android_log_print(ANDROID_LOG_INFO, TAG, "g_GetTypeName %x", (unsigned int)g_GetTypeName);

	g_GetAssemblyTypes = dlsym(il2cpp, "_ZN6il2cpp6icalls8mscorlib6System10Reflection8Assembly8GetTypesEP24Il2CppReflectionAssemblyb");
	__android_log_print(ANDROID_LOG_INFO, TAG, "g_GetAssemblyTypes %x", (unsigned int)g_GetAssemblyTypes);

	GC_free = dlsym(il2cpp, "GC_free");
	__android_log_print(ANDROID_LOG_INFO, TAG, "GC_free %x", (unsigned int)GC_free);

	// GetImageFromIndex(uint32_t uiIndex)
	g_GetImageFromIndex = dlsym(il2cpp, "_ZN6il2cpp2vm13MetadataCache17GetImageFromIndexEi");
	__android_log_print(ANDROID_LOG_INFO, TAG, "g_GetImageFromIndex %x", (unsigned int)g_GetImageFromIndex);

	// GetTypeInfoFromTypeDefinitionIndex(uint32_t uiIndex)
	g_GetClassFromIndex = dlsym(il2cpp, "_ZN6il2cpp2vm13MetadataCache34GetTypeInfoFromTypeDefinitionIndexEi");
	__android_log_print(ANDROID_LOG_INFO, TAG, "g_GetClassFromIndex %x", (unsigned int)g_GetClassFromIndex);

	g_SetupClass = dlsym(il2cpp, "_ZN6il2cpp2vm5Class4InitEP11Il2CppClass");
	__android_log_print(ANDROID_LOG_INFO, TAG, "g_SetupClass %x", (unsigned int)g_SetupClass);

	g_GetFieldDefault = dlsym(il2cpp, "_ZN6il2cpp2vm5Field20GetDefaultFieldValueEP9FieldInfoPv");
	__android_log_print(ANDROID_LOG_INFO, TAG, "g_GetFieldDefault %x", (unsigned int)g_GetFieldDefault);

	return nullchk(g_GetAssemblies) && nullchk(g_GetCurrDomain) && nullchk(g_GetVirt) && nullchk(g_GetTypeName) && nullchk(g_GetAssemblyTypes)
		&& nullchk(GC_free) && nullchk(g_GetClassFromIndex) && nullchk(g_GetImageFromIndex) && nullchk(g_SetupClass) && nullchk(g_GetFieldDefault);
}



char* szPath = "/sdcard/dumper.dll";

FILE* fOut;
int iBeenInjected = 0;


void convert_stringt_to_char(char* buffer, uint32_t uiSize)
{
	for (int i = 0; i < uiSize; ++i)
	{
		memcpy(&buffer[i + 1], &buffer[i + 2], (uiSize - i) * 2);
	}
}

char* szTypeString[] = 
{
	"END",
	"void",
	"boolean",
	"char",
	"sbyte",// I1
	"byte",// U1
	"short",// I2
	"ushort",// U2
	"int",// I4
	"uint",// U4
	"long",// I8
	"ulong",// U8
	"float",// R4
	"double",// R8
	"String",
	"Ptr",
	"REF",
	"ValueType",
	"Class",
	"var",
	"array",
	"Generic",
	"TypedREF",
	"int",// I
	"uint",// U
	"FuncPtr",
	"Object",
	"sArray",
	"mvar",
	"cmod_reqd",
	"cmod_opt",
	"internal_type",
	"modifier",
	"sentinel",
	"pinned",
	"enum"
};

Il2CppClass* pDumpedClasses[6000];
uint32_t uiDumpedIndex = 0;
char tempBuff[1024];

void AddDumped(Il2CppClass* klass)
{
	pDumpedClasses[uiDumpedIndex++] = klass;
}

int CheckDumped(Il2CppClass* klass)
{
	for (int i = 0; i < uiDumpedIndex; ++i)
		if (pDumpedClasses[i] == klass)
			return 1;
	return 0;
}

int CheckArr(Il2CppClass** pArr, uint32_t uiSize, Il2CppClass* pVal)
{
	for (int i = 0; i < uiSize; ++i)
		if (pArr[i] == pVal)
			return 1;
	return 0;
}

void dump_class(Il2CppClass* type)
{
	if (CheckDumped(type))
		return;
	__android_log_print(ANDROID_LOG_INFO, TAG, "Class %s %s", type->namespaze, type->name);
	Il2CppClass* arr[50];
	memset(arr, 0, sizeof(arr));
	uint32_t uiIndex = 0;
	g_SetupClass(type);
	if (type->fields)
	{
		for (int z = 0; z < type->field_count; ++z)
		{
			if (!(type->fields[z].type->attrs & FIELD_ATTRIBUTE_STATIC) && (type->fields[z].type->type == IL2CPP_TYPE_CLASS || type->fields[z].type->type == IL2CPP_TYPE_VALUETYPE))
			{
				Il2CppClass* klass = g_GetClassFromIndex(type->fields[z].type->data.klassIndex);
				__android_log_print(ANDROID_LOG_INFO, TAG, "\tField: %s %s", klass->name, type->fields[z].name);

				if (!CheckArr(arr, uiIndex, klass))
					arr[uiIndex++] = klass;
			}
			else
			{
				if (type->fields[z].type->attrs & FIELD_ATTRIBUTE_STATIC)
				{
					union
					{
						float f;
						double d;
						int i;
						long long l;
					} dat;
					dat.l = 0;

					g_GetFieldDefault(&type->fields[z], &dat);
					
					if (type->fields[z].type->type == IL2CPP_TYPE_CLASS || type->fields[z].type->type == IL2CPP_TYPE_VALUETYPE)
					{
						Il2CppClass* klass = g_GetClassFromIndex(type->fields[z].type->data.klassIndex);
						__android_log_print(ANDROID_LOG_INFO, TAG, "\tField: %s %s = %d", klass->name, type->fields[z].name, dat.i);
						
						if (!CheckArr(arr, uiIndex, klass))
							arr[uiIndex++] = klass;
					}
					else if (type->fields[z].type->type == IL2CPP_TYPE_I
						|| type->fields[z].type->type == IL2CPP_TYPE_I4
						|| type->fields[z].type->type == IL2CPP_TYPE_I1
						|| type->fields[z].type->type == IL2CPP_TYPE_I2)
					{
						__android_log_print(ANDROID_LOG_INFO, TAG, "\tField: %s %s = %d", szTypeString[type->fields[z].type->type], type->fields[z].name, dat.i);
					}

					else if (type->fields[z].type->type == IL2CPP_TYPE_U
						|| type->fields[z].type->type == IL2CPP_TYPE_U4
						|| type->fields[z].type->type == IL2CPP_TYPE_U1
						|| type->fields[z].type->type == IL2CPP_TYPE_U2)
					{
						__android_log_print(ANDROID_LOG_INFO, TAG, "\tField: %s %s = %u", szTypeString[type->fields[z].type->type], type->fields[z].name, dat.i);
					}

					else if (type->fields[z].type->type == IL2CPP_TYPE_R4)
					{
						__android_log_print(ANDROID_LOG_INFO, TAG, "\tField: %s %s = %f", szTypeString[type->fields[z].type->type], type->fields[z].name, dat.f);
					}
					else if (type->fields[z].type->type == IL2CPP_TYPE_R8)
					{
						__android_log_print(ANDROID_LOG_INFO, TAG, "\tField: %s %s = %lf", szTypeString[type->fields[z].type->type], type->fields[z].name, dat.d);
					}
					else if (type->fields[z].type->type == IL2CPP_TYPE_U8)
					{
						__android_log_print(ANDROID_LOG_INFO, TAG, "\tField: %s %s = %lu", szTypeString[type->fields[z].type->type], type->fields[z].name, dat.i);
					}
					else if (type->fields[z].type->type == IL2CPP_TYPE_I8)
					{
						__android_log_print(ANDROID_LOG_INFO, TAG, "\tField: %s %s = %ld", szTypeString[type->fields[z].type->type], type->fields[z].name, dat.i);
					}
					else if (type->fields[z].type->type == IL2CPP_TYPE_STRING)
					{
						String_t* pStr = (String_t*)dat.i;
						memset(tempBuff, 0, 2048);
						int copyLen = pStr->___length_0 * 2;
						memcpy(tempBuff, &(pStr->___start_char_1), copyLen);
						convert_stringt_to_char(tempBuff, pStr->___length_0);
						__android_log_print(ANDROID_LOG_INFO, TAG, "\tField: %s %s = \"%s\"", szTypeString[type->fields[z].type->type], type->fields[z].name, tempBuff);
					}
				}
				else
				{
					__android_log_print(ANDROID_LOG_INFO, TAG, "\tField: %s %s", szTypeString[type->fields[z].type->type], type->fields[z].name);
				}
			}
		}
	}

	if (type->methods)
	{
		for (int z = 0; z < type->method_count; ++z)
		{
			if (type->methods[z])
				__android_log_print(ANDROID_LOG_INFO, TAG, "\tMethod: %s - %x", type->methods[z]->name, type->methods[z]->method);
		}
	}

	if (type->vtable)
	{
		for (int z = 0; z < type->vtable_count; ++z)
		{
			if (type->vtable[z])
				__android_log_print(ANDROID_LOG_INFO, TAG, "\tVTable %d: %s - %x", z, type->vtable[z]->name, type->vtable[z]->method);
		}
	}
	AddDumped(type);
	for (int i = 0; i < uiIndex; ++i)
	{
		dump_class(arr[i]);
		usleep(500000);
	}
}

int dumped_type_vtable = 0;
void* main_thread(void * arg)
{
	sleep(20);
	iBeenInjected = 1;
	if (!pLibLog)
		pLibLog = dlopen("liblog.so", RTLD_NOW);
	if (!__android_log_print)
		__android_log_print = dlsym(pLibLog, "__android_log_print");

	__android_log_print(ANDROID_LOG_INFO, TAG, "Injector Called");

	void* pLibCpp = dlopen("libil2cpp.so", RTLD_NOW);

	if (pLibCpp)
	{
		InitIl2Cpp(pLibCpp);

		void* pDomain = g_GetCurrDomain(0, 0);
		__android_log_print(ANDROID_LOG_INFO, TAG, "AppDomain %x", pDomain);
		Il2CppArray* pArray = g_GetAssemblies(pDomain, 0);
		__android_log_print(ANDROID_LOG_INFO, TAG, "Number of assemblies: %d", pArray->max_length);
		/*{ // Dumper for System.Reflection.Assembly VTable
			Assembly_t* pAsm = *(Assembly_t**)((int*)(pArray + 1) + 0);
			for (int x = 0; x < 40; ++x)
			{
				VirtualInvokeData vid = g_GetVirt(x, pAsm);
				__android_log_print(ANDROID_LOG_INFO, TAG, "System.Reflection.Assembly::%s = %x, %d", vid.methodInfo->name, vid.methodInfo->method, x);
			}
		}*/
		
		for (int i = 4; i < pArray->max_length; ++i)
		{
			memset(pDumpedClasses, 0, sizeof(pDumpedClasses));
			uiDumpedIndex = 0;
			// This'll crash the app if commmented
			//if (i == 17)
			//	continue;

			Assembly_t* pAsm = *(Assembly_t**)((int*)(pArray + 1) + i);

			VirtualInvokeData vid = g_GetVirt(3, pAsm);
			String_t* pName = vid.methodInfo->method(vid.target, (void*)vid.methodInfo);

			char buff[2048];
			memset(buff, 0, 2048);
			int copyLen = pName->___length_0 * 2;
			memcpy(buff, &(pName->___start_char_1), copyLen);
			convert_stringt_to_char(buff, pName->___length_0);

			Il2CppImage* pImage = g_GetImageFromIndex(pAsm->____mono_assembly_0->uiImageIndex);
			
			__android_log_print(ANDROID_LOG_INFO, TAG, "Assembly %d: %s\n\tContains %d classes", i + 1, buff, pImage->uiTypeCount);

			__android_log_print(ANDROID_LOG_INFO, TAG, "=================Beginning class dump==============================");
			for (int x = 0; x < pImage->uiTypeCount; ++x)
			{
				Il2CppClass* type = g_GetClassFromIndex(x + pImage->uiTypeStart);
				//vid = g_GetVirt(14, type);
				if (strstr(type->name, "<"))
					continue;
				dump_class(type);
				usleep(500000);
			}
			__android_log_print(ANDROID_LOG_INFO, TAG, "=================Dumped %d classes ==============================", uiDumpedIndex);

		}
	}
	
}

void start_main()
{
	pthread_t thrd;
	pthread_create(&thrd, 0, main_thread, 0);
}

void* pLibRealUnity = 0;
typedef void(*UnitySendMessage_t)(const char* ob, const char* method, const char* msg);
typedef jint(JNICALL*CallJNI_OnLoad_t)(JavaVM* vm, void* reserved);
typedef void(JNICALL*CallJNI_OnUnload_t)(JavaVM* vm, void* reserved);

UnitySendMessage_t RealUSM = 0;
CallJNI_OnLoad_t RealJNIOnLoad = 0;
CallJNI_OnUnload_t RealJNIOnUnload = 0;

void CallUSM(
	const char* ob, const char* method, const char* msg)
{
	if (!pLibRealUnity)
		pLibRealUnity = dlopen("librealunity.so", RTLD_NOW);
	if (!RealUSM)
		RealUSM = dlsym(pLibRealUnity, "UnitySendMessage");
	RealUSM(ob, method, msg);
}

JNIEXPORT jint JNICALL CallJNIOL(
	JavaVM* vm, void* reserved)
{
	if (!pLibRealUnity)
		pLibRealUnity = dlopen("librealunity.so", RTLD_NOW);
	if (!RealJNIOnLoad)
		RealJNIOnLoad = dlsym(pLibRealUnity, "JNI_OnLoad");
	return RealJNIOnLoad(vm, reserved);
}
JNIEXPORT void JNICALL CallJNIUL(
	JavaVM* vm, void* reserved)
{
	if (!pLibRealUnity)
		pLibRealUnity = dlopen("librealunity.so", RTLD_NOW);
	if (!RealJNIOnLoad)
		RealJNIOnLoad = dlsym(pLibRealUnity, "JNI_OnUnload");
	RealJNIOnLoad(vm, reserved);
}

void UnitySendMessage(const char* ob, const char* method, const char* msg)
{
	if (!pLibLog)
		pLibLog = dlopen("liblog.so", RTLD_NOW);
	if (!__android_log_print)
		__android_log_print = dlsym(pLibLog, "__android_log_print");
	__android_log_print(ANDROID_LOG_INFO, TAG, "USM");

	if (!iBeenInjected)
		start_main();
	CallUSM(ob, method, msg);
}

JNIEXPORT jint JNICALL JNI_OnLoad(JavaVM* vm, void* reserved)
{
	if (!pLibLog)
		pLibLog = dlopen("liblog.so", RTLD_NOW);
	if (!__android_log_print)
		__android_log_print = dlsym(pLibLog, "__android_log_print");
	__android_log_print(ANDROID_LOG_INFO, TAG, "JNI_OnLoad");

	if (!iBeenInjected)
		start_main();
	return CallJNIOL(vm, reserved);
}
JNIEXPORT void JNICALL JNI_OnUnload(JavaVM* vm, void* reserved)
{
	if (!pLibLog)
		pLibLog = dlopen("liblog.so", RTLD_NOW);
	if (!__android_log_print)
		__android_log_print = dlsym(pLibLog, "__android_log_print");
	__android_log_print(ANDROID_LOG_INFO, TAG, "JNI_OnUnload");

	if (!iBeenInjected)
		start_main();
	CallJNIUL(vm, reserved);
}

