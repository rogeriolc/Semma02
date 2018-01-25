using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Semma02.BasicSamples
{
    public partial class HardcodedValuesEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Semma02.BasicSamples.HardcodedValuesEditor";

        public HardcodedValuesEditorAttribute()
            : base(Key)
        {
        }
    }
}
