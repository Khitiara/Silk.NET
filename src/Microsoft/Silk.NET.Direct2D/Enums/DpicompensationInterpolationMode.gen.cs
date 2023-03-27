// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_DPICOMPENSATION_INTERPOLATION_MODE")]
    public enum DpicompensationInterpolationMode : int
    {
        [Obsolete("Deprecated in favour of \"NearestNeighbor\"")]
        [NativeName("Name", "D2D1_DPICOMPENSATION_INTERPOLATION_MODE_NEAREST_NEIGHBOR")]
        DpicompensationInterpolationModeNearestNeighbor = 0x0,
        [Obsolete("Deprecated in favour of \"Linear\"")]
        [NativeName("Name", "D2D1_DPICOMPENSATION_INTERPOLATION_MODE_LINEAR")]
        DpicompensationInterpolationModeLinear = 0x1,
        [Obsolete("Deprecated in favour of \"Cubic\"")]
        [NativeName("Name", "D2D1_DPICOMPENSATION_INTERPOLATION_MODE_CUBIC")]
        DpicompensationInterpolationModeCubic = 0x2,
        [Obsolete("Deprecated in favour of \"MultiSampleLinear\"")]
        [NativeName("Name", "D2D1_DPICOMPENSATION_INTERPOLATION_MODE_MULTI_SAMPLE_LINEAR")]
        DpicompensationInterpolationModeMultiSampleLinear = 0x3,
        [Obsolete("Deprecated in favour of \"Anisotropic\"")]
        [NativeName("Name", "D2D1_DPICOMPENSATION_INTERPOLATION_MODE_ANISOTROPIC")]
        DpicompensationInterpolationModeAnisotropic = 0x4,
        [Obsolete("Deprecated in favour of \"HighQualityCubic\"")]
        [NativeName("Name", "D2D1_DPICOMPENSATION_INTERPOLATION_MODE_HIGH_QUALITY_CUBIC")]
        DpicompensationInterpolationModeHighQualityCubic = 0x5,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_DPICOMPENSATION_INTERPOLATION_MODE_FORCE_DWORD")]
        DpicompensationInterpolationModeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_DPICOMPENSATION_INTERPOLATION_MODE_NEAREST_NEIGHBOR")]
        NearestNeighbor = 0x0,
        [NativeName("Name", "D2D1_DPICOMPENSATION_INTERPOLATION_MODE_LINEAR")]
        Linear = 0x1,
        [NativeName("Name", "D2D1_DPICOMPENSATION_INTERPOLATION_MODE_CUBIC")]
        Cubic = 0x2,
        [NativeName("Name", "D2D1_DPICOMPENSATION_INTERPOLATION_MODE_MULTI_SAMPLE_LINEAR")]
        MultiSampleLinear = 0x3,
        [NativeName("Name", "D2D1_DPICOMPENSATION_INTERPOLATION_MODE_ANISOTROPIC")]
        Anisotropic = 0x4,
        [NativeName("Name", "D2D1_DPICOMPENSATION_INTERPOLATION_MODE_HIGH_QUALITY_CUBIC")]
        HighQualityCubic = 0x5,
        [NativeName("Name", "D2D1_DPICOMPENSATION_INTERPOLATION_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}