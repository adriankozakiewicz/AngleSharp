﻿namespace AngleSharp.Dom.Css
{
    using System;
    using AngleSharp.Css;
    using AngleSharp.Extensions;

    /// <summary>
    /// Information can be found on MDN:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/max-height
    /// Gets the specified max-height of the element. A percentage is
    /// calculated with respect to the height of the containing block. If
    /// the height of the containing block is not specified explicitly, the
    /// percentage value is treated as none.
    /// </summary>
    sealed class CssMaxHeightProperty : CssProperty
    {
        #region ctor

        internal CssMaxHeightProperty()
            : base(PropertyNames.MaxHeight, PropertyFlags.Animatable)
        {
        }

        #endregion

        #region Properties

        internal override IValueConverter Converter
        {
            get { return Converters.OptionalLengthOrPercentConverter; }
        }

        #endregion

        #region Methods

        protected override Object GetDefault(IElement element)
        {
            return null;
        }

        #endregion
    }
}
