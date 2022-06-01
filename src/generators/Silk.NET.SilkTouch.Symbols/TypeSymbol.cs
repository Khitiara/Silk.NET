﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// A generic <see cref="Symbol"/> representing a named type.
/// </summary>
/// <param name="Identifier">The identifier of this type</param>
/// <seealso cref="StructSymbol"/>
public abstract record TypeSymbol(IdentifierSymbol Identifier) : Symbol;