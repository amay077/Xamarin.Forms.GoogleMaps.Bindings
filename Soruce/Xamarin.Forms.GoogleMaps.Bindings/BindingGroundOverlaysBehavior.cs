﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public class BindingGroundOverlaysBehavior : BehaviorBase<Map>
    {
        private static readonly BindablePropertyKey ValuePropertyKey = BindableProperty.CreateReadOnly("Value", typeof(ObservableCollection<GroundOverlay>), typeof(BindingGroundOverlaysBehavior), default(ObservableCollection<GroundOverlay>));

        public static readonly BindableProperty ValueProperty = ValuePropertyKey.BindableProperty;
        public ObservableCollection<GroundOverlay> Value
        {
            get { return (ObservableCollection<GroundOverlay>)GetValue(ValueProperty); }
            private set { SetValue(ValuePropertyKey, value); }
        }

        protected override void OnAttachedTo(Map bindable)
        {
            base.OnAttachedTo(bindable);
            Value = bindable.GroundOverlays as ObservableCollection<GroundOverlay>;
        }

        protected override void OnDetachingFrom(Map bindable)
        {
            base.OnDetachingFrom(bindable);
            Value = null;
        }
    }
}
