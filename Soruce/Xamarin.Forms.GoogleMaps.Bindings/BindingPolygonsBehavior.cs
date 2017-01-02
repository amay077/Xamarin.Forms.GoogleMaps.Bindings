﻿using System.Collections.ObjectModel;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public class BindingPolygonsBehavior : BehaviorBase<Map>
    {
        private static readonly BindablePropertyKey ValuePropertyKey = BindableProperty.CreateReadOnly("Value", typeof(ObservableCollection<Polygon>), typeof(BindingPolygonsBehavior), default(ObservableCollection<Polygon>));

        public static readonly BindableProperty ValueProperty = ValuePropertyKey.BindableProperty;
        public ObservableCollection<Polygon> Value
        {
            get { return (ObservableCollection<Polygon>)GetValue(ValueProperty); }
            private set { SetValue(ValuePropertyKey, value); }
        }

        protected override void OnAttachedTo(Map bindable)
        {
            base.OnAttachedTo(bindable);
            Value = bindable.Polygons as ObservableCollection<Polygon>;
        }

        protected override void OnDetachingFrom(Map bindable)
        {
            base.OnDetachingFrom(bindable);
            Value = null;
        }
    }
}
