﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Beatmaps.Formats;
using osuTK.Graphics;

namespace osu.Game.Skinning
{
    /// <summary>
    /// An empty skin configuration.
    /// </summary>
    public class SkinConfiguration : IHasComboColours, IHasCustomColours
    {
        public readonly SkinInfo SkinInfo = new SkinInfo();

        public List<Color4> ComboColours { get; set; } = new List<Color4>();

        public Dictionary<string, Color4> CustomColours { get; set; } = new Dictionary<string, Color4>();

        public string HitCircleFont { get; set; }

        public int HitCircleOverlap { get; set; }

        public float? SliderBorderSize { get; set; }

        public float? SliderPathRadius { get; set; }

        public bool? CursorExpand { get; set; }
    }
}
