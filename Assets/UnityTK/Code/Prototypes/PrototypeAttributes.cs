﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityTK.Prototypes
{
	/// <summary>
	/// This attribute can be used to mark classes or structs to be serialized for <see cref="Prototypes"/>.
	/// A marked class will be generating a type cache object in <see cref="PrototypesCaches"/>
	/// </summary>
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class PrototypesTypeSerializableAttribute : Attribute
	{
	}
}