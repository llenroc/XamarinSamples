﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RadialProgressExample.Controls
{
    public class RadialProgressControl : View
    {
        #region BindableProperty Variables

        public static readonly BindableProperty MinimumProperty = BindableProperty.Create(nameof(Minimum), typeof(float), typeof(RadialProgressControl), default(float));
        public static readonly BindableProperty MaximumProperty = BindableProperty.Create(nameof(Maximum), typeof(float), typeof(RadialProgressControl), default(float));
        public static readonly BindableProperty ValueProperty = BindableProperty.Create(nameof(Value), typeof(float), typeof(RadialProgressControl), default(float));
        public static readonly BindableProperty ProgressColorProperty = BindableProperty.Create(nameof(ProgressColor), typeof(Color), typeof(RadialProgressControl), default(Color));
        public static readonly BindableProperty LabelHiddenProperty = BindableProperty.Create(nameof(LabelHidden), typeof(Boolean), typeof(RadialProgressControl), default(Boolean));
        public static readonly BindableProperty IsDoneProperty = BindableProperty.Create(nameof(IsDone), typeof(Boolean), typeof(RadialProgressControl), default(Boolean));

        #endregion

        #region Properties

        public float Minimum
        {
            get
            {
                return (float)GetValue(MinimumProperty);
            }
            set
            {
                SetValue(MinimumProperty, value);
            }
        }
        public float Maximum
        {
            get
            {
                return (float)GetValue(MaximumProperty);
            }
            set
            {
                SetValue(MaximumProperty, value);
            }
        }
        public float Value
        {
            get
            {
                return (float)GetValue(ValueProperty);
            }
            set
            {
                SetValue(ValueProperty, value);
            }
        }
        public Color ProgressColor
        {
            get
            {
                return (Color)GetValue(ProgressColorProperty);
            }
            set
            {
                SetValue(ProgressColorProperty, value);
            }
        }
        public bool LabelHidden
        {
            get { return (Boolean)GetValue(LabelHiddenProperty); }
            set { SetValue(LabelHiddenProperty, value); }
        }
        public bool IsDone
        {
            get { return (Boolean)GetValue(IsDoneProperty); }
            set { SetValue(IsDoneProperty, value); }
        }

        #endregion
    }
}
