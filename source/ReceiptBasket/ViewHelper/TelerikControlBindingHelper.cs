using System;
using System.Linq.Expressions;
using MvvmFx.Windows.Data;
using Telerik.WinControls.UI;

namespace ReceiptBasket.ViewHelper
{
    public static class TelerikControlBindingHelper
    {
        #region [ Public Methods ]

        public static void BindData<TSource>(
            this RadCheckBox targetObject,
            BindingManager bindingManager,
            TSource sourceObject,
            Expression<Func<TSource, object>> sourceExpression,
            IValueConverter converter = null,
            BindingMode mode = BindingMode.TwoWay)
        {
            bindingManager.Bind(
                targetObject, t => t.Checked,
                sourceObject, sourceExpression, converter, mode);
        }

        public static void BindData<TSource>(
            this RadTrackBar targetObject,
            BindingManager bindingManager,
            TSource sourceObject,
            Expression<Func<TSource, object>> sourceExpression,
            IValueConverter converter = null,
            BindingMode mode = BindingMode.TwoWay)
        {
            bindingManager.Bind(
                targetObject, t => t.TrackBarElement.Value,
                sourceObject, sourceExpression, converter, mode);
        }

        #endregion
    }
}