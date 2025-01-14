﻿using eBook_Reader.Model;
using eBook_Reader.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VersOne.Epub;
using VersOne.Epub.Schema;
using HtmlAgilityPack;
using eBook_Reader.Stores;

namespace eBook_Reader.Commands.NavigationCommands
{
    public class NavigateReadBookCommand : CommandBase
    {

        private readonly NavigationStore m_navigationStore;
        private readonly MenuNavigationStore m_menuNavigationStore;
        private AllBooksViewModel m_allBooksViewModel;

        public NavigateReadBookCommand(NavigationStore navigationStore,
                                       MenuNavigationStore menuNavigationStore,
                                       AllBooksViewModel allBooksViewModel)
        {

            m_navigationStore = navigationStore;
            m_menuNavigationStore = menuNavigationStore;
            m_allBooksViewModel = allBooksViewModel;
        }

        public override bool CanExecute(object? parameter)
        {

            if (parameter == null)
                return false;

            return true;
        }

        public override void Execute(object? parameter)
        {

            if (parameter != null)
                m_navigationStore.CurrentViewModel = new ReadBookViewModel((Book)parameter, m_navigationStore, m_menuNavigationStore, m_allBooksViewModel);
        }
    }
}