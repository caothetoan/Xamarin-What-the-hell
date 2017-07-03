// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace WhatTheHell.iOS
{
    [Register ("ItemDetailViewController")]
    partial class BrowseItemDetailViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ItemAuthorLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ItemDescriptionLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ItemImageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ItemNameLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ItemAuthorLabel != null) {
                ItemAuthorLabel.Dispose ();
                ItemAuthorLabel = null;
            }

            if (ItemDescriptionLabel != null) {
                ItemDescriptionLabel.Dispose ();
                ItemDescriptionLabel = null;
            }

            if (ItemImageView != null) {
                ItemImageView.Dispose ();
                ItemImageView = null;
            }

            if (ItemNameLabel != null) {
                ItemNameLabel.Dispose ();
                ItemNameLabel = null;
            }
        }
    }
}