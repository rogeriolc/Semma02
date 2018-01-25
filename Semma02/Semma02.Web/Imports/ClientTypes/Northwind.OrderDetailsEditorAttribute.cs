using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Semma02.Northwind
{
    public partial class OrderDetailsEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Semma02.Northwind.OrderDetailsEditor";

        public OrderDetailsEditorAttribute()
            : base(Key)
        {
        }
    }
}
