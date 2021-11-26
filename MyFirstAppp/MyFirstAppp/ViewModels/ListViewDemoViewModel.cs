using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstAppp.ViewModels
{
    public class ListViewDemoViewModel : BindableBase
    {
        public IPageDialogService _dialogService;
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        List<string> _listItems;
        public List<string> ListItems
        {
            get { return _listItems; }
            set
            {
                SetProperty(ref _listItems, value);
            }
        }

        private string _selectedName;
        public string SelectedName
        {
            get { return _selectedName; }
            set
            {
                SetProperty(ref _selectedName, value);
                if (_selectedName != null)
                {
                    //hiện dialog khi item đc chọn
                    _dialogService.DisplayAlertAsync("ListItem", "selected Name is: " + _selectedName, "OK");
                }
            }
        }
        public ListViewDemoViewModel(INavigationService navigationService, IPageDialogService dialogService)
        {
            Title = "ListView Demo Của Hậu";

            _dialogService = dialogService;


            ListItems = new List<string>()
            {
                "Trương",
                "Công",
                "Hậu",
                "09FHTH1",
                "2001180261",
            };

        }

        //#region ListView be-hide
        ////ListViewDemoViewModel Code be-hide
        //public List<TestListView> ItemsVM { get; }


        //public ListViewDemoViewModel()
        //{
        //    ItemsVM = new List<TestListView>
        //    {
        //        new TestListView{Title1 = "a",Description="1"},
        //        new TestListView{Title1 = "b",Description="2"},
        //        new TestListView{Title1 = "c",Description="3"},
        //        new TestListView{Title1 = "d",Description="4"}
        //    };
        //}
        //#endregion


    }
    //public class TestListView
    //{
    //    string title1 = string.Empty;
    //    public string Title1
    //    {
    //        get => title1; set => title1 = value;
    //    }
    //    string description = string.Empty;
    //    public string Description
    //    {
    //        get => description; set =>
    //        description = value;
    //    }
    //}

}
