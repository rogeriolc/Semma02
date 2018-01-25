using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Semma02.BasicSamples
{
    public partial class ChangingLookupTextEditorAttribute : LookupEditorBaseAttribute
    {
        public const string Key = "Semma02.BasicSamples.ChangingLookupTextEditor";

        public ChangingLookupTextEditorAttribute()
            : base(Key)
        {
        }
    }
}
