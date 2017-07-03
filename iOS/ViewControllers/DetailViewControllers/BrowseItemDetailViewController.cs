using System;
using UIKit;

namespace WhatTheHell.iOS
{
    public partial class BrowseItemDetailViewController : UIViewController
    {
        public ItemDetailViewModel ViewModel { get; set; }
        public BrowseItemDetailViewController(IntPtr handle) : base(handle) { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = ViewModel.Title;

            ItemNameLabel.Text = ViewModel.Item.Title;
            ItemDescriptionLabel.Text = ViewModel.Item.Description;
            ItemAuthorLabel.Text = ViewModel.Item.Author;
            ItemImageView.Image = Utils.FromUrl(ViewModel.Item.UrlToImage);
        }


    }
}
