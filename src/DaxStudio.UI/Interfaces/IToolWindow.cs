﻿using Caliburn.Micro;
namespace DaxStudio.UI.Interfaces
{
    public interface IToolWindow
    {
        string Title { get; set; }
        string DefaultDockingPane { get; set; }
        bool CanCloseWindow { get; set; }
        bool CanHide { get; set; }
        int AutoHideMinHeight { get; set; }
        bool IsSelected { get; set; }
        //bool IsActive { get; set; }
        //TODO ContentId IconSource
    }
}
