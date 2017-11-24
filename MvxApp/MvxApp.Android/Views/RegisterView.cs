using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Views;
using MvxApp.Core.Converters;

namespace MvxApp.Droid.Views
{
    [Activity(Label = "RegisterView")]
    [MvxViewFor(typeof(MvxApp.Core.ViewModels.RegisterViewModel))]
    public class RegisterView : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.RegisterView);

            var date = FindViewById<EditText>(Resource.Id.DateText);
            var title = FindViewById<EditText>(Resource.Id.TitleText);
            var detail = FindViewById<EditText>(Resource.Id.DetailText);
            var clear = FindViewById<Button>(Resource.Id.ClearButton);
            var register = FindViewById<Button>(Resource.Id.RegisterButton);
            var list = FindViewById<Button>(Resource.Id.ListButton);

            var set = this.CreateBindingSet<RegisterView, Core.ViewModels.RegisterViewModel>();
            set.Bind(date).For(c => c.Text).To(vm => vm.Date)
                .WithConversion<DatetimeToStringValueConverter>("yyyy/MM/dd");
            set.Bind(title).For(c => c.Text).To(vm => vm.Title);
            set.Bind(detail).For(c => c.Text).To(vm => vm.Detail);
            set.Bind(clear).For("Click").To(vm => vm.ClearCommand);
            set.Bind(register).For("Click").To(vm => vm.RegisterCommand);
            set.Bind(list).For("Click").To(vm => vm.ListCommand);
            set.Apply();
        }
    }
}