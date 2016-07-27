LOCAL_PATH := $(call my-dir)

include $(CLEAR_VARS)

LOCAL_MODULE    := hello-jni
LOCAL_SRC_FILES := main.c

LOCAL_CFLAGS += -std=c99

include $(BUILD_SHARED_LIBRARY)
