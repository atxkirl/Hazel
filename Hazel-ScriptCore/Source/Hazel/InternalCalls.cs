using System;
using System.Runtime.CompilerServices;

namespace Hazel
{
	public static class InternalCalls
	{
		//-- ECS
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern bool Entity_HasComponent(ulong entityID, Type componentType);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern ulong Entity_FindEntityByName(string name);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern object GetScriptInstance(ulong entityID);


		//-- Transform
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern void TransformComponent_GetTranslation(ulong entityID, out Vector3 translation);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern void TransformComponent_SetTranslation(ulong entityID, ref Vector3 translation);


		//-- RigidBody2D
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern void Rigidbody2DComponent_ApplyLinearImpulse(ulong entityID, ref Vector2 impulse, ref Vector2 point, bool wake);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern void Rigidbody2DComponent_ApplyLinearImpulseToCenter(ulong entityID, ref Vector2 impulse, bool wake);
		
		
		//-- Input
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern bool Input_IsKeyDown(KeyCode keycode);
	}
}
