using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComicBookGallery.Models;
namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        private static ComicBook[] _comicBooks = new ComicBook[]
        {
            new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness as <strong>Peter Parker</strong> leaves this world :(</p>",
                Artists = new Artist[]
               {
                    new Artist() { Name = "Dan Slot", Role = "Script" },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() { Name = "Victor Olazaba", Role = "Inks" },
                    new Artist() { Name = "Edgar Delgado", Role = "Colors" },
                    new Artist() { Name = "Chris Eliopoulus", Role = "Letters" }
               }
            },

            new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 657,
                DescriptionHtml = "<p><strong>FF: THREE TIE IN.</strong> Peter Parker visits the Future Foundation HQ</p>",
                Artists = new Artist[]
               {
                    new Artist() { Name = "Dan Slot", Role = "Script" },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() { Name = "Victor Olazaba", Role = "Inks" },
                    new Artist() { Name = "Muntsa Vincent", Role = "Colors" },
                    new Artist() { Name = "Chris Eliopoulus", Role = "Letters" }
               }
            },

            new ComicBook()
            {
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHtml = "<p>The Dungeon and the Parapet Part 1</p>",
                Artists = new Artist[]
               {
                    new Artist() { Name = "Jeff Smith", Role = "Script" },
                    new Artist() { Name = "Jeff Smith", Role = "Pencils" },
                    new Artist() { Name = "Jeff Smith", Role = "Inks" },
                    new Artist() { Name = "Jeff Smith", Role = "Colors" },
                    new Artist() { Name = "Jeff Smith", Role = "Letters" }
               }
            }
        };

    public ComicBook GetComicBook( int id )
        {
            ComicBook comicBookToReturn = null;

            foreach (var comicBook in _comicBooks)
            {
                if (comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;
                    break;
                }
            }
            return comicBookToReturn;
        }
    }
}