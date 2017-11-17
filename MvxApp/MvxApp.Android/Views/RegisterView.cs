﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Views;

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
        }
    }
}