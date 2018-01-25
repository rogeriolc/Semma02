using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Semma02.Administration
{
    public partial class RoleCheckEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Semma02.Administration.RoleCheckEditor";

        public RoleCheckEditorAttribute()
            : base(Key)
        {
        }
    }
}
