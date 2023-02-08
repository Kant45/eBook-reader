﻿
using eBook_Reader.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using eBook_Reader.Commands;

namespace eBook_Reader.ViewModel {
    public class MainViewModel : ViewModelBase {
        public ViewModelBase CurrentViewModel { get; }
        private Book m_selectedBook;
        private static ObservableCollection<Model.Book> m_bookList;
        public MainViewModel() {
            AddEpubBookCommand = new AddBookCommand();

            m_bookList = new ObservableCollection<Model.Book>();

            String[] filePaths = Directory.GetFiles("C:/Users/User/source/repos/eBook Reader/eBook Reader/Library");

            foreach(String fPath in filePaths) {
                Model.Book book = new Model.Book(fPath);

                m_bookList.Add(book);
            }
        }

        public AddBookCommand AddEpubBookCommand { get; protected set; }

        public ObservableCollection<Model.Book> BookList {
            get { return m_bookList; }
        }

        public Book SelectedBook {
            get { return m_selectedBook; }
            set {
                m_selectedBook = value;
                OnPropertyChanged("SlectedPhone");
            }
        }
    }
}
