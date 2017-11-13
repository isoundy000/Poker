﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_TransformWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Transform), typeof(UnityEngine.Component));
		L.RegFunction("SetParent", SetParent);
		L.RegFunction("Translate", Translate);
		L.RegFunction("Rotate", Rotate);
		L.RegFunction("RotateAround", RotateAround);
		L.RegFunction("LookAt", LookAt);
		L.RegFunction("TransformDirection", TransformDirection);
		L.RegFunction("InverseTransformDirection", InverseTransformDirection);
		L.RegFunction("TransformVector", TransformVector);
		L.RegFunction("InverseTransformVector", InverseTransformVector);
		L.RegFunction("TransformPoint", TransformPoint);
		L.RegFunction("InverseTransformPoint", InverseTransformPoint);
		L.RegFunction("DetachChildren", DetachChildren);
		L.RegFunction("SetAsFirstSibling", SetAsFirstSibling);
		L.RegFunction("SetAsLastSibling", SetAsLastSibling);
		L.RegFunction("SetSiblingIndex", SetSiblingIndex);
		L.RegFunction("GetSiblingIndex", GetSiblingIndex);
		L.RegFunction("Find", Find);
		L.RegFunction("IsChildOf", IsChildOf);
		L.RegFunction("FindChild", FindChild);
		L.RegFunction("GetEnumerator", GetEnumerator);
		L.RegFunction("GetChild", GetChild);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("position", get_position, set_position);
		L.RegVar("localPosition", get_localPosition, set_localPosition);
		L.RegVar("eulerAngles", get_eulerAngles, set_eulerAngles);
		L.RegVar("localEulerAngles", get_localEulerAngles, set_localEulerAngles);
		L.RegVar("right", get_right, set_right);
		L.RegVar("up", get_up, set_up);
		L.RegVar("forward", get_forward, set_forward);
		L.RegVar("rotation", get_rotation, set_rotation);
		L.RegVar("localRotation", get_localRotation, set_localRotation);
		L.RegVar("localScale", get_localScale, set_localScale);
		L.RegVar("parent", get_parent, set_parent);
		L.RegVar("worldToLocalMatrix", get_worldToLocalMatrix, null);
		L.RegVar("localToWorldMatrix", get_localToWorldMatrix, null);
		L.RegVar("root", get_root, null);
		L.RegVar("childCount", get_childCount, null);
		L.RegVar("lossyScale", get_lossyScale, null);
		L.RegVar("hasChanged", get_hasChanged, set_hasChanged);
		L.RegVar("hierarchyCapacity", get_hierarchyCapacity, set_hierarchyCapacity);
		L.RegVar("hierarchyCount", get_hierarchyCount, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetParent(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(UnityEngine.Transform)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.ToObject(L, 2);
				obj.SetParent(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(UnityEngine.Transform), typeof(bool)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.ToObject(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				obj.SetParent(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Transform.SetParent");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Translate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				obj.Translate(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3), typeof(UnityEngine.Transform)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Transform arg1 = (UnityEngine.Transform)ToLua.ToObject(L, 3);
				obj.Translate(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3), typeof(UnityEngine.Space)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Space arg1 = (UnityEngine.Space)ToLua.ToObject(L, 3);
				obj.Translate(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(float), typeof(float), typeof(float)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				float arg0 = (float)LuaDLL.lua_tonumber(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
				obj.Translate(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(float), typeof(float), typeof(float), typeof(UnityEngine.Transform)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				float arg0 = (float)LuaDLL.lua_tonumber(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
				UnityEngine.Transform arg3 = (UnityEngine.Transform)ToLua.ToObject(L, 5);
				obj.Translate(arg0, arg1, arg2, arg3);
				return 0;
			}
			else if (count == 5 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(float), typeof(float), typeof(float), typeof(UnityEngine.Space)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				float arg0 = (float)LuaDLL.lua_tonumber(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
				UnityEngine.Space arg3 = (UnityEngine.Space)ToLua.ToObject(L, 5);
				obj.Translate(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Transform.Translate");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Rotate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				obj.Rotate(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3), typeof(float)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				obj.Rotate(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3), typeof(UnityEngine.Space)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Space arg1 = (UnityEngine.Space)ToLua.ToObject(L, 3);
				obj.Rotate(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3), typeof(float), typeof(UnityEngine.Space)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				UnityEngine.Space arg2 = (UnityEngine.Space)ToLua.ToObject(L, 4);
				obj.Rotate(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(float), typeof(float), typeof(float)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				float arg0 = (float)LuaDLL.lua_tonumber(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
				obj.Rotate(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(float), typeof(float), typeof(float), typeof(UnityEngine.Space)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				float arg0 = (float)LuaDLL.lua_tonumber(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
				UnityEngine.Space arg3 = (UnityEngine.Space)ToLua.ToObject(L, 5);
				obj.Rotate(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Transform.Rotate");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RotateAround(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.CheckObject(L, 1, typeof(UnityEngine.Transform));
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
			obj.RotateAround(arg0, arg1, arg2);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LookAt(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				obj.LookAt(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(UnityEngine.Transform)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.ToObject(L, 2);
				obj.LookAt(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
				obj.LookAt(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.ToObject(L, 2);
				UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
				obj.LookAt(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Transform.LookAt");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TransformDirection(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector3 o = obj.TransformDirection(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(float), typeof(float), typeof(float)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				float arg0 = (float)LuaDLL.lua_tonumber(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
				UnityEngine.Vector3 o = obj.TransformDirection(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Transform.TransformDirection");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InverseTransformDirection(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector3 o = obj.InverseTransformDirection(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(float), typeof(float), typeof(float)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				float arg0 = (float)LuaDLL.lua_tonumber(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
				UnityEngine.Vector3 o = obj.InverseTransformDirection(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Transform.InverseTransformDirection");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TransformVector(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector3 o = obj.TransformVector(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(float), typeof(float), typeof(float)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				float arg0 = (float)LuaDLL.lua_tonumber(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
				UnityEngine.Vector3 o = obj.TransformVector(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Transform.TransformVector");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InverseTransformVector(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector3 o = obj.InverseTransformVector(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(float), typeof(float), typeof(float)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				float arg0 = (float)LuaDLL.lua_tonumber(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
				UnityEngine.Vector3 o = obj.InverseTransformVector(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Transform.InverseTransformVector");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TransformPoint(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector3 o = obj.TransformPoint(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(float), typeof(float), typeof(float)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				float arg0 = (float)LuaDLL.lua_tonumber(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
				UnityEngine.Vector3 o = obj.TransformPoint(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Transform.TransformPoint");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InverseTransformPoint(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector3 o = obj.InverseTransformPoint(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(float), typeof(float), typeof(float)))
			{
				UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				float arg0 = (float)LuaDLL.lua_tonumber(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
				UnityEngine.Vector3 o = obj.InverseTransformPoint(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Transform.InverseTransformPoint");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DetachChildren(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.CheckObject(L, 1, typeof(UnityEngine.Transform));
			obj.DetachChildren();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAsFirstSibling(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.CheckObject(L, 1, typeof(UnityEngine.Transform));
			obj.SetAsFirstSibling();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAsLastSibling(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.CheckObject(L, 1, typeof(UnityEngine.Transform));
			obj.SetAsLastSibling();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetSiblingIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.CheckObject(L, 1, typeof(UnityEngine.Transform));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.SetSiblingIndex(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSiblingIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.CheckObject(L, 1, typeof(UnityEngine.Transform));
			int o = obj.GetSiblingIndex();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Find(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.CheckObject(L, 1, typeof(UnityEngine.Transform));
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.Transform o = obj.Find(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsChildOf(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.CheckObject(L, 1, typeof(UnityEngine.Transform));
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Transform));
			bool o = obj.IsChildOf(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindChild(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.CheckObject(L, 1, typeof(UnityEngine.Transform));
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.Transform o = obj.FindChild(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEnumerator(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.CheckObject(L, 1, typeof(UnityEngine.Transform));
			System.Collections.IEnumerator o = obj.GetEnumerator();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChild(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform obj = (UnityEngine.Transform)ToLua.CheckObject(L, 1, typeof(UnityEngine.Transform));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Transform o = obj.GetChild(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_position(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Vector3 ret = obj.position;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index position on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localPosition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Vector3 ret = obj.localPosition;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index localPosition on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_eulerAngles(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Vector3 ret = obj.eulerAngles;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index eulerAngles on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localEulerAngles(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Vector3 ret = obj.localEulerAngles;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index localEulerAngles on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_right(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Vector3 ret = obj.right;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index right on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_up(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Vector3 ret = obj.up;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index up on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_forward(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Vector3 ret = obj.forward;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index forward on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rotation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Quaternion ret = obj.rotation;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index rotation on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localRotation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Quaternion ret = obj.localRotation;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index localRotation on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localScale(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Vector3 ret = obj.localScale;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index localScale on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_parent(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Transform ret = obj.parent;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index parent on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_worldToLocalMatrix(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Matrix4x4 ret = obj.worldToLocalMatrix;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index worldToLocalMatrix on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localToWorldMatrix(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Matrix4x4 ret = obj.localToWorldMatrix;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index localToWorldMatrix on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_root(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Transform ret = obj.root;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index root on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_childCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			int ret = obj.childCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index childCount on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lossyScale(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Vector3 ret = obj.lossyScale;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index lossyScale on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hasChanged(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			bool ret = obj.hasChanged;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index hasChanged on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hierarchyCapacity(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			int ret = obj.hierarchyCapacity;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index hierarchyCapacity on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hierarchyCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			int ret = obj.hierarchyCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index hierarchyCount on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_position(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.position = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index position on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_localPosition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.localPosition = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index localPosition on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_eulerAngles(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.eulerAngles = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index eulerAngles on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_localEulerAngles(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.localEulerAngles = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index localEulerAngles on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_right(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.right = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index right on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_up(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.up = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index up on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_forward(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.forward = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index forward on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_rotation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Quaternion arg0 = ToLua.ToQuaternion(L, 2);
			obj.rotation = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index rotation on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_localRotation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Quaternion arg0 = ToLua.ToQuaternion(L, 2);
			obj.localRotation = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index localRotation on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_localScale(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.localScale = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index localScale on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_parent(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Transform));
			obj.parent = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index parent on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_hasChanged(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.hasChanged = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index hasChanged on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_hierarchyCapacity(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Transform obj = (UnityEngine.Transform)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.hierarchyCapacity = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index hierarchyCapacity on a nil value" : e.Message);
		}
	}
}

