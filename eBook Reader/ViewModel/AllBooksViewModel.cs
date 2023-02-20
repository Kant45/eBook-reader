﻿using eBook_Reader.Commands;
using eBook_Reader.Model;
using eBook_Reader.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace eBook_Reader.ViewModel {
    public class AllBooksViewModel : ViewModelBase {

        private ObservableCollection<Book> m_bookList;
        private static Book m_selectedBook;
        private readonly NavigationStore m_navigationStore;

        public Book SelectedBook {
            get { return m_selectedBook; }
            set {
                m_selectedBook = value;
                OnPropertyChanged("SlectedBook");
            }
        }
        public ICommand AddEpubBookCommand { get; 
            protected set; }
        public NavigateReadBookCommand NavigateReadBookCommand { get; set; }

        public ObservableCollection<Model.Book> BookList {
            get { return m_bookList; }
        }

        public AllBooksViewModel(NavigationStore navigationStore) {

            m_bookList = new ObservableCollection<Model.Book>();

            m_navigationStore = navigationStore;

            NavigateReadBookCommand = new NavigateReadBookCommand(this, m_navigationStore);
            

            String[] filePaths = Directory.GetFiles("C:/Users/User/source/repos/eBook Reader/eBook Reader/Library");

            foreach(String fPath in filePaths) {
                Model.Book book = new Model.Book(fPath);

                m_bookList.Add(book);
            }

            AddEpubBookCommand = new AddBookCommand(m_navigationStore, this);
        }
    }
}