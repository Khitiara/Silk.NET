// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_CONTRAST_PROP")]
    public enum ContrastProp : int
    {
        [Obsolete("Deprecated in favour of \"Contrast\"")]
        [NativeName("Name", "D2D1_CONTRAST_PROP_CONTRAST")]
        ContrastPropContrast = 0x0,
        [Obsolete("Deprecated in favour of \"ClampInput\"")]
        [NativeName("Name", "D2D1_CONTRAST_PROP_CLAMP_INPUT")]
        ContrastPropClampInput = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_CONTRAST_PROP_FORCE_DWORD")]
        ContrastPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_CONTRAST_PROP_CONTRAST")]
        Contrast = 0x0,
        [NativeName("Name", "D2D1_CONTRAST_PROP_CLAMP_INPUT")]
        ClampInput = 0x1,
        [NativeName("Name", "D2D1_CONTRAST_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}