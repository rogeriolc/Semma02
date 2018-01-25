using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Semma02.Northwind
{
    public partial class NotesEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Semma02.Northwind.NotesEditor";

        public NotesEditorAttribute()
            : base(Key)
        {
        }
    }
}
