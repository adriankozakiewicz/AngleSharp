﻿namespace AngleSharp.Dom.Css
{
    using System;
    using AngleSharp.Css;
    using AngleSharp.Css.Values;
    using AngleSharp.Extensions;

    /// <summary>
    /// More information available at:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/border-image-outset
    /// </summary>
    sealed class CssBorderImageOutsetProperty : CssProperty
    {
        #region Fields

        internal static readonly IValueConverter<Tuple<Length, Length, Length, Length>> StyleConverter = 
            Converters.LengthOrPercentConverter.Periodic();

        #endregion

        #region ctor

        internal CssBorderImageOutsetProperty()
            : base(PropertyNames.BorderImageOutset)
        {
        }

        #endregion

        #region Properties

        internal override IValueConverter Converter
        {
            get { return StyleConverter; }
        }

        #endregion

        #region Methods

        protected override Object GetDefault(IElement element)
        {
            return Tuple.Create(Length.Zero, Length.Zero, Length.Zero, Length.Zero);
        }

        #endregion
    }
}
